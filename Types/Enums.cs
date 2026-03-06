using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flintstones
{
  /// <summary>
  /// Enum with all dugon colors in order of achieving.
  /// </summary>
  public enum DugonColor
  {
    White,
    Green,
    Blue,
    Yellow,
    Purple,
    Brown,
    Red,
    Black
  }

  /// <summary>
  /// Enum to specify the available character classes for a player character.
  /// </summary>
  /// <remarks> Using a byte with Peasant = 0, Warrior = 1, Rogue = 2, Wizard = 3, Priest = 4, Monk = 5</remarks>
  public enum CharacterClass : byte
  {
    Peasant = 0,
    Warrior,
    Rogue,
    Wizard,
    Priest,
    Monk,
  }

}
