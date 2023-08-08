//SlowPoke
// Type: Flintstones.ChestItemXML
//SlowPoke
//SlowPoke
//SlowPoke

using System.Collections.Generic;

namespace Flintstones
{
  public class ChestItemXML
  {
    public Dictionary<string, int> Treasure = new Dictionary<string, int>();

    public string Name { get; set; }

    public uint OpenedCount { get; set; }

    public ChestItemXML(string name, uint opened)
    {
      this.Name = name;
      this.OpenedCount = opened;
      this.Treasure = new Dictionary<string, int>();
    }
  }
}
