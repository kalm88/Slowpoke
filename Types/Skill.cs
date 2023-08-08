//SlowPoke
// Type: Flintstones.Skill
//SlowPoke
//SlowPoke
//SlowPoke

using System;

namespace Flintstones
{
  public class Skill
  {
    public bool moved;

    public string Name { get; set; }

    public int SkillSlot { get; set; }

    public DateTime NextUse { get; set; }

    public string Caption { get; set; }

    public int CurrentLevel { get; set; }

    public int MaximumLevel { get; set; }

    public int Icon { get; set; }

    public int NewSlot { get; set; }

    public Skill() => this.NextUse = DateTime.UtcNow;

    public override string ToString() => string.Format("{0} (Lev:{1}/{2})", (object) this.Name, (object) this.CurrentLevel, (object) this.MaximumLevel);
  }
}
