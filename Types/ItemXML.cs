//SlowPoke
// Type: Flintstones.ItemXML
//SlowPoke
//SlowPoke
//SlowPoke

using System.Collections.Generic;

namespace Flintstones
{
  public class ItemXML
  {
    public List<string> Usedfor = new List<string>();
    public List<string> Obtainedby = new List<string>();

    public string Name { get; set; }

    public string SecondName { get; set; }

    public int Image { get; set; }
  }
}
