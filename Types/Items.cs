using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Flintstones

{
  internal class Items
  {
    private List<ItemData> AllItems = new List<ItemData>();
    public List<String> Armors = new List<String>();
    public List<String> MaleArmors = new List<String>();
    public List<String> FemaleArmors = new List<String>();
    public Dictionary<String, ItemData> Unidentifiable = new Dictionary<String, ItemData>();
    public List<String> Identifiable = new List<String>();

    private string filePath = Path.Combine(Program.StartupPath, "Settings", "ItemList.xml");

    public Items() 
    {
      Load();

      foreach(var item in AllItems)
      {
        if (item.ItemType == ItemType.Armor)
        {
          Armors.Add(item.Name);

          if (item.AllowedGender == Gender.Male)
            MaleArmors.Add(item.Name);
          else if (item.AllowedGender != Gender.Female)
            FemaleArmors.Add(item.Name);
        }

        if (item.NeedsIdentify)
          Unidentifiable.Add(item.Name, item);
        else
          Identifiable.Add(item.Name);
      }
    }

    /// <summary>
    /// Loas the list with alts and their password from AltList.xml
    /// </summary>
    private void Load()
    {
      var items = new Dictionary<String, ItemData>();

      XDocument doc = XDocument.Load(filePath);

      foreach (var itemElement in doc.Root.Elements("Item"))
      {
        string name = itemElement.Attribute("name")?.Value;
        if (name is null)
          continue;

        Enum.TryParse(itemElement.Element("Gender")?.Value, true, out Gender gender);

        int maxStack = int.Parse(
            itemElement.Element("MaxStack")?.Value ?? "1");

        bool needsIdentify = bool.Parse(
            itemElement.Element("NeedsIdentify")?.Value ?? "false");

        Enum.TryParse<ItemType>(itemElement.Element("Type")?.Value, true, out ItemType type);

        AllItems.Add(new ItemData(name, type, maxStack, needsIdentify, gender));
      }

      Console.WriteLine($"Loaded {AllItems.Count} items from {filePath}");
    }
  }
}
