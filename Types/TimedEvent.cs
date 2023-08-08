//SlowPoke
// Type: Flintstones.TimedEvent
//SlowPoke
//SlowPoke
//SlowPoke

using System;

namespace Flintstones
{
  public class TimedEvent
  {
    public bool Messaged;

    public string Name { get; set; }

    public string Event { get; set; }

    public DateTime Time { get; set; }

    public bool Track { get; set; }

    public uint TimeLeft()
    {
      double totalMinutes = DateTime.UtcNow.Subtract(this.Time).TotalMinutes;
      double num1 = 0.0;
      double num2 = 0.0;
      if (this.Event.Equals("Skrull"))
        num1 = 180.0;
      else if (this.Event.Equals("Captain"))
        num1 = 180.0;
      else if (this.Event.Equals("Blob 1"))
        num1 = 180.0;
      else if (this.Event.Equals("Blob 2"))
        num1 = 180.0;
      else if (this.Event.Equals("Mass"))
        num1 = 180.0;
      else if (this.Event.Equals("Gan"))
        num1 = 180.0;
      else if (this.Event.Equals("Morg"))
        num1 = 180.0;
      else if (this.Event.Equals("Veltain Queen"))
        num1 = 180.0;
      else if (this.Event.Equals("King & Queen"))
        num1 = 180.0;
      else if (this.Event.Equals("Assassin Lord"))
        num1 = 180.0;
      else if (this.Event.Equals("Law"))
        num1 = 60.0;
      else if (this.Event.Equals("Filthy Erbies"))
        num1 = 180.0;
      else if (this.Event.Equals("Pig Chase"))
        num1 = 180.0;
      else if (this.Event.Equals("Lucky Clover"))
        num1 = 7200.0;
      else if (this.Event.Equals("Gold Starfish"))
        num1 = 7200.0;
      else if (this.Event.Equals("Frog Set"))
        num1 = 10080.0;
      else if (this.Event.Equals("Spore Set"))
        num1 = 10080.0;
      else if (this.Event.Equals("Cursed Home"))
        num1 = 20160.0;
      else if (this.Event.Equals("Water Dungeon"))
        num1 = 10080.0;
      else if (this.Event.Equals("WD Chest"))
        num1 = 2880.0;
      else if (this.Event.Equals("Andor Chest"))
        num1 = 2880.0;
      else if (this.Event.Equals("Queen Chest"))
        num1 = 2880.0;
      else if (this.Event.Equals("MEG"))
        num1 = 4320.0;
      else if (this.Event.Equals("Ab Gift"))
        num1 = 4320.0;
      else if (this.Event.Equals("Ab Box"))
        num1 = 1440.0;
      else if (this.Event.Equals("Oren Fountain"))
        num1 = 262975.0;
      else if (this.Event.Equals("Perfect Hairstyle"))
        num1 = 10080.0;
      else if (this.Event.Equals("Mothers Love"))
        num1 = 1440.0;
      else if (this.Event.Equals("Labor"))
        num1 = 720.0;
      else if (this.Event.Equals("The Letter"))
        num1 = 5760.0;
      else if (this.Event.Equals("Mentored"))
        num1 = 10080.0;
      else if (this.Event.Equals("Yule Quest"))
        num1 = 4320.0;
      else if (this.Event.Equals("Altar"))
        num1 = 181.0;
      else if (this.Event.Equals("Rudolph"))
        num1 = 7200.0;
      else if (this.Event.Equals("Penguins"))
        num1 = 7200.0;
      else if (this.Event.Equals("Pet Faerie"))
        num1 = 64800.0;
      else if (this.Event.Equals("YT Boss"))
        num1 = 120.0;
      else if (this.Event.Equals("Fowls"))
        num1 = 120.0;
      else if (this.Event.Equals("Spare Stick"))
        num1 = 480.0;
      else if (this.Event.Equals("Drakari"))
        num1 = 180.0;
      else if (this.Event.Equals("Muisir Beast"))
        num1 = 60.0;
      else if (this.Event.Equals("Chadul Invasion"))
        num1 = 90.0;
      else if (this.Event.Equals("Blackstar"))
        num1 = 1440.0;
      if (totalMinutes <= num1)
        num2 = num1 - totalMinutes;
      return num2 <= 1.0 && num2 != 0.0 ? 1U : (uint) num2;
    }
  }
}
