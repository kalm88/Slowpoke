//SlowPoke
// Type: Flintstones.ItemMapXML
//SlowPoke
//SlowPoke
//SlowPoke

using System.Collections.Generic;

namespace Flintstones
{
  public class ItemMapXML
  {
    public Dictionary<string, ItemMonsterXML> Monsters = new Dictionary<string, ItemMonsterXML>();

    public string Name { get; set; }

    public int Number { get; set; }
  }
}
