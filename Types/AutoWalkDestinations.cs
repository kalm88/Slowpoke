using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flintstones

{
  internal class AutoWalkDestinations
  {
    Dictionary<string, List<WalkLocation>> Destinations = new Dictionary<string, List<WalkLocation>>
    {
      { "Arena", new List<WalkLocation> {
        new WalkLocation { Area = "Arena", Location = "Coliseum Arena"  },
        new WalkLocation {Area = "Arena", Location = "Balanced Arena"},
        }
      }
    };


  }
}
