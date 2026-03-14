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
    public ItemType ItemType { get; set; }
    public int MaxStack { get; set; }
    public bool NeedsIdentify { get; set; }
    public Gender AllowedGender { get; set; }

    public ItemData(string name, ItemType itemType, int maxstack, bool needsIdentify, Gender gender)
    {
      Name = name;
      ItemType = itemType;
      MaxStack = maxstack;
      NeedsIdentify = needsIdentify;
      AllowedGender = gender;
    }

    public bool CanBeUsedBy(Gender gender)
    {
      return AllowedGender == Gender.Any || AllowedGender == gender;
    }
  }
}
