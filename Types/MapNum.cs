//SlowPoke
// Type: Flintstones.MapNum
//SlowPoke
//SlowPoke
//SlowPoke

using System.Collections.Generic;

namespace Flintstones
{
  public class MapNum
  {
    public int Number = int.MinValue;
    public Dictionary<Location, string> Regions = new Dictionary<Location, string>();
    public Dictionary<Location, string> Previous = new Dictionary<Location, string>();
    public Location LastPoint;
  }
}
