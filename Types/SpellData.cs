//SlowPoke
// Type: Flintstones.SpellData
//SlowPoke
//SlowPoke
//SlowPoke

namespace Flintstones
{
  public class SpellData
  {
    public string Name { get; set; }

    public int ManaCost { get; set; }

    public int BaseLines { get; set; }

    public SpellData(string name, int manacost, int baselines)
    {
      this.Name = name;
      this.ManaCost = manacost;
      this.BaseLines = baselines;
    }
  }
}
