using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flintstones
{
  /// <summary>
  /// Enum to specify the available character classes for a player character.
  /// </summary>
  /// <remarks> Using a byte with Warrior = 1, Rogue = 2, Wizard = 3, Priest = 4, Monk = 5</remarks>
  public enum CharacterClass : byte
  {
    Warrior = 1,
    Rogue,
    Wizard,
    Priest,
    Monk,
  }
}
