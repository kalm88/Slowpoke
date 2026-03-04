using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flintstones
{
  public class Monster
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string DisplayName { get; set; }
    public int CountTo { get; set; }
    public int? CombineWith { get; set; } = null;
    public int KillCount { get; set; } = 0;
    public List<string> CountAtMaps { get; set; } = new List<string>();
    public List<int> CounterResetLocation { get; set; } = new List<int>();
  }
}
