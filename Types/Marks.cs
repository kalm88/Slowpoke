//SlowPoke
// Type: Flintstones.Marks
//SlowPoke
//SlowPoke
//SlowPoke

namespace Flintstones
{
  public class Marks
  {
    public string Name { get; set; }

    public string Cat { get; set; }

    public Marks(string name, string cat)
    {
      this.Name = name;
      this.Cat = cat;
    }

    public override string ToString() => this.Name;
  }
}
