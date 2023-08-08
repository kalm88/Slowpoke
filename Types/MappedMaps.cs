//SlowPoke
// Type: Flintstones.MappedMaps
//SlowPoke
//SlowPoke
//SlowPoke

using System.Collections.Generic;

namespace Flintstones
{
  public class MappedMaps
  {
    public bool Checked;
    public bool Deadend;
    public Dictionary<int, Location> ConnectedTo = new Dictionary<int, Location>();
    public Location Default;
    public int Routes;
    public Dictionary<int, List<int>> RoutesDic = new Dictionary<int, List<int>>();

    public int Number { get; set; }
  }
}
