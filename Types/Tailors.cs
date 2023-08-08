//SlowPoke
// Type: Flintstones.Tailors
//SlowPoke
//SlowPoke
//SlowPoke

using System.Collections.Generic;

namespace Flintstones
{
  public class Tailors
  {
    public Dictionary<string, Flintstones.TailorLevCounts> TailorLevCounts = new Dictionary<string, Flintstones.TailorLevCounts>();
    public bool UseAssistant;
    public List<string> Armors = new List<string>();

    public string CharName { get; set; }
  }
}
