//SlowPoke
// Type: Flintstones.Spell
//SlowPoke
//SlowPoke
//SlowPoke

using System;

namespace Flintstones
{
  public class Spell
  {
    public string Name { get; set; }

    public int CastLines { get; set; }

    public int SpellSlot { get; set; }

    public string[] Captions { get; set; }

    public DateTime NextUse { get; set; }

    public int CurrentLevel { get; set; }

    public int MaximumLevel { get; set; }

    public string Prompt { get; set; }

    public int Type { get; set; }

    public int Icon { get; set; }

    public Spell()
    {
      this.Captions = new string[10];
      this.NextUse = DateTime.UtcNow;
    }

    public override string ToString() => string.Format("{0} (Lev:{1}/{2})", (object) this.Name, (object) this.CurrentLevel, (object) this.MaximumLevel);
  }
}
