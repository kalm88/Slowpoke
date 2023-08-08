//SlowPoke
// Type: Flintstones.Item
//SlowPoke
//SlowPoke
//SlowPoke

using System;

namespace Flintstones
{
  public class Item
  {
    public uint Amount = 1;
    public bool Gone;
    public bool IsIdentified;

    public string Name { get; set; }

    public int InventorySlot { get; set; }

    public DateTime NextUse { get; set; }

    public ushort Icon { get; set; }

    public byte IconPal { get; set; }

    public byte Stackable { get; set; }

    public uint CurrentDurability { get; set; }

    public uint MaximumDurability { get; set; }

    public Item() => this.NextUse = DateTime.UtcNow;

    public override string ToString() => this.Name;
  }
}
