using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Flintstones
{
  /// <summary>
  /// Contains the alts and their passwords as provided in AltList.xml
  /// </summary>
  internal class Alts
  {
    private string filePath = Path.Combine(Program.StartupPath, "Settings", "AltList.xml");
    private Dictionary<string, string> _alts = new Dictionary<string, string>();

    public Alts() 
    { 
      Load();
    }

    /// <summary>
    /// Add an alt with the given name and password to the list and saves the list to AltList.xml. If an alt with the same name already exists, its password will be updated.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="pass"></param>
    public void Add(string name, string pass)
    {
      if (_alts.ContainsKey(name))
        _alts[name] = pass;
      else
        _alts.Add(name, pass);

      Save();
    }

    /// <summary>
    /// Removes the alt with the given name from the list and saves the list to AltList.xml. Does nothing if the alt name is not found.
    /// </summary>
    /// <param name="name"></param>
    public void Remove(string name)
    {
      _alts.Remove(name);

      Save();
    }

    /// <summary>
    /// Loas the list with alts and their password from AltList.xml
    /// </summary>
    private void Load()
    {
      XDocument document;

      if (!File.Exists(filePath))
      {
        document = new XDocument(new XElement("Alts"));
        document.Save(filePath);
        return;
      }

      document = XDocument.Load(filePath);
      foreach (var alt in document.Root.Elements("Alt"))
      {
        string name = alt.Attribute("name")?.Value;
        string pass = alt.Attribute("pass")?.Value;

        // Skip if name or pass is null or whitespace
        if (string.IsNullOrWhiteSpace(name) || string.IsNullOrEmpty(pass))
          continue;
        
        if (!_alts.ContainsKey(name))
          _alts.Add(name, pass);
      }

      Console.WriteLine($"Loaded {_alts.Count} alts from {filePath}");
    }

    /// <summary>
    /// Save the alts and their password to AltList.xml
    /// </summary>
    private void Save()
    {
      var document = new XDocument(
          new XElement("Alts",
              _alts.Select(x =>
                  new XElement("Alt",
                      new XAttribute("name", x.Key),
                      new XAttribute("pass", x.Value)
                  )
              )
          )
      );

      document.Save(filePath);
    }

    /// <summary>
    /// Gives a list with known alts.
    /// </summary>
    /// <returns>List<string> with alts</returns>
    public List<string> Get()
    {
      return _alts.Keys.ToList();
    }

    /// <summary>
    /// Give the password for the given alt name. Returns null if the alt name is not found.
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public string Pass(string name)
    {
      return _alts[name];
    }
  }
}
