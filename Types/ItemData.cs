//SlowPoke
// Type: Flintstones.ItemData
//SlowPoke
//SlowPoke
//SlowPoke

namespace Flintstones
{
  public class ItemData
  {
    public string Name { get; set; }

    public int MaxStack { get; set; }

    public ItemData(string name, int maxstack)
    {
      this.Name = name;
      this.MaxStack = maxstack;
    }
  }
}
