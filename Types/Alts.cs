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
    string filePath = Path.Combine(Program.StartupPath, "Settings", "AltList.xml");
    Dictionary<string, string> _alts = new Dictionary<string, string>();

    public Alts() 
    { 
      Load();
    } 

    public void Add(string name, string pass)
    {
      if (_alts.ContainsKey(name))
        _alts[name] = pass;
      else
        _alts.Add(name, pass);

      Save();
    }

    public void Remove(string name)
    {
      _alts.Remove(name);

      Save();
    }

    /// <summary>
    /// Loas the list with alts and their password from AltList.xml
    /// </summary>
    public void Load()
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
    public void Save()
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

    public string Pass(string name)
    {
      return _alts[name];
    }
  }
}
