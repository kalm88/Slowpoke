//SlowPoke
// Type: Flintstones.ItemMonsterXML
//SlowPoke
//SlowPoke
//SlowPoke

using System.Collections.Generic;

namespace Flintstones
{
  public class ItemMonsterXML
  {
    public Dictionary<string, Item2XML> Drops = new Dictionary<string, Item2XML>();
    public List<string> GoldAmounts = new List<string>();

    public string Name { get; set; }

    public int Image { get; set; }

    public uint KillCount { get; set; }
  }
}
