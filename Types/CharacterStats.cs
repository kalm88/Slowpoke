using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flintstones
{
    /// <summary>
    /// Specifies the character classes for a client.
    /// </summary>
    /// <remarks>Use this enumeration to indicate or determine the role or archetype of a client character as returned from the DA server. The values can be used for character creation, filtering, or logic based on
    /// class type.</remarks>
    public enum CharacterClass : byte
    {
        warrior = 1, // start with 1 to match DA server values
        rogue,
        wizard,
        priest,
        monk,
    }

    /// <summary>
    /// Holds the character stats MaxHP, Str, Int, Wis, Con, Dex.
    /// </summary>
    public class CharacterStats
    {
        public uint MaxHP { get; set; }
        public uint Str { get; set; }
        public uint Int { get; set; }
        public uint Wis { get; set; }
        public uint Con { get; set; }
        public uint Dex { get; set; }
    }
}
