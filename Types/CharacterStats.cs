using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flintstones
{

  /// <summary>
  /// Primary statistics for a character
  /// </summary>
  public class CharacterStats
  {
    public uint Maxhp { get; set; }
    public uint Str { get; set; }
    public uint Int { get; set; }
    public uint Wis { get; set; }
    public uint Con { get; set; }
    public uint Dex { get; set; }

  }
}
