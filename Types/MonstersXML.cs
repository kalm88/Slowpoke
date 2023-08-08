//SlowPoke
// Type: Flintstones.MonstersXML
//SlowPoke
//SlowPoke
//SlowPoke

using System.Collections.Generic;

namespace Flintstones
{
  public class MonstersXML
  {
    public List<string> ItemDrops = new List<string>();

    public string Name { get; set; }

    public ushort Image { get; set; }

    public ushort GoldDropMin { get; set; }

    public ushort GoldDropMax { get; set; }
  }
}
