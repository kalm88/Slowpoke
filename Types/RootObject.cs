//SlowPoke
// Type: Flintstones.RootObject
//SlowPoke
//SlowPoke
//SlowPoke

using System.Collections.Generic;

namespace Flintstones
{
  public class RootObject
  {
    public string mapnum { get; set; }

    public string mapname { get; set; }

    public string width { get; set; }

    public string height { get; set; }

    public List<Spawnarea> spawnareas { get; set; }

    public List<To> to { get; set; }
  }
}
