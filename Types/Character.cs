//SlowPoke
// Type: Flintstones.Character
//SlowPoke
//SlowPoke
//SlowPoke

using System;
using System.Collections.Generic;

namespace Flintstones
{
  public class Character
  {
    public uint ID;
    public string Name = string.Empty;
    public Location Location = new Location(0, 0);
    public int Map = int.MinValue;
    public string MapName = string.Empty;
    public Dictionary<int, DateTime> SpellAnimationHistory = new Dictionary<int, DateTime>();
    public Dictionary<int, string> ProbableSpellType = new Dictionary<int, string>();
    public Dictionary<int, int> AnimationFrom = new Dictionary<int, int>();
    public bool IsOnScreen = true;
    public bool IsLoggedOn = true;
    public bool IsCupping;
    public double HpAmount = 100.0;
    public int AnotherCurseCount;
    public int AnotherFasCount;
    public DateTime CreateTime = DateTime.MinValue;
    public DateTime DeathTime = DateTime.MinValue;
    public DateTime InViewTime = DateTime.MinValue;
    public string LastBlueText = string.Empty;
    public bool Counted;
    public int BestTargetCount = int.MinValue;
    public DateTime LyliacTime = DateTime.MinValue;
    public Statistics.Elements element;
    public bool IsDead;
    public bool HasSummoned;
    public DateTime LastAction = DateTime.MinValue;
    public bool Lured;
    public uint LastHitByID;
    public bool NameIsRed;
    public DateTime asrsdelay = DateTime.MinValue;
    public DateTime healdelayedreaction = DateTime.MinValue;
    public DateTime lastheal = DateTime.MinValue;
    public DateTime aosuaindelayedreaction = DateTime.MinValue;
    public DateTime lastaosuain = DateTime.MinValue;
    public DateTime aodalldelayedreaction = DateTime.MinValue;
    public DateTime lastaodall = DateTime.MinValue;
    public DateTime aopoisondelayedreaction = DateTime.MinValue;
    public DateTime lastaopoison = DateTime.MinValue;
    public bool wantsflowered;
    public bool wasseenwarning;
    public byte ItemCount;
    public Location SpawnLocation = new Location(0, 0);
    public List<uint> DropList = new List<uint>();
    public bool WasDropped;
    public bool Looted;
    public int InventorySlot = int.MinValue;
    public DateTime FakeChatDelay = DateTime.MinValue;
    public byte FakeChatCount;
    public string SecondName = string.Empty;
    public bool IsIdentified;
    public int diontime = int.MinValue;
    public bool IsSkulled;
    public bool OutofReach;
    public bool WrongKey;
    public bool CountedItsKill;
    public uint GoldAmount;
    public List<uint> GoldList = new List<uint>();
    public Dictionary<string, DateTime> PreventSpam = new Dictionary<string, DateTime>((IEqualityComparer<string>) StringComparer.CurrentCultureIgnoreCase);
    public DateTime unhidetimer = DateTime.MinValue;
    public bool wassummoned;
    public bool Moved;
    public bool isParentGrime;
    public bool isGrimeSpawn;
    public bool CantAttack;
    public ulong HitCount;
    public DateTime cantattacktimer = DateTime.MinValue;
    public DateTime wasJUSThitbymspgdelay = DateTime.MinValue;
    public DateTime firstspellattackhit = DateTime.MinValue;
    public bool sensed;
    public DateTime senseanimationdelay = DateTime.MinValue;
    public bool Passive = true;
    public bool FollowMode;

    public bool breisd
    {
      get => this.SpellAnimationHistory.ContainsKey(25) && DateTime.UtcNow.Subtract(this.SpellAnimationHistory[25]).TotalMilliseconds >= 500.0;
      set
      {
      }
    }

    public bool canbetaken => DateTime.UtcNow.Subtract(this.CreateTime).TotalSeconds < 3.0;

    public bool hascurse => this.hasardcradh || this.hasdemonseal || this.hasdemise || this.hasdarkerseal || this.hasdarkseal || this.hasmorcradh;

    public bool hasardcradh => this.SpellAnimationHistory.ContainsKey(257) && DateTime.UtcNow.Subtract(this.SpellAnimationHistory[257]).TotalSeconds < 240.0;

    public bool hasmorcradh => this.SpellAnimationHistory.ContainsKey(243) && DateTime.UtcNow.Subtract(this.SpellAnimationHistory[243]).TotalSeconds < 210.0;

    public bool hascradh => this.SpellAnimationHistory.ContainsKey(258) && DateTime.UtcNow.Subtract(this.SpellAnimationHistory[258]).TotalSeconds < 180.0;

    public bool hasbeagcradh => this.SpellAnimationHistory.ContainsKey(259) && DateTime.UtcNow.Subtract(this.SpellAnimationHistory[259]).TotalSeconds < 150.0;

    public bool hasbardo => this.SpellAnimationHistory.ContainsKey(44) && DateTime.UtcNow.Subtract(this.SpellAnimationHistory[44]).TotalSeconds < 180.0;

    public bool hasdarkseal => this.SpellAnimationHistory.ContainsKey(104) && DateTime.UtcNow.Subtract(this.SpellAnimationHistory[104]).TotalSeconds < 153.0;

    public bool hasdarkerseal => this.SpellAnimationHistory.ContainsKey(82) && DateTime.UtcNow.Subtract(this.SpellAnimationHistory[82]).TotalSeconds < 153.0;

    public bool hasdemise => this.SpellAnimationHistory.ContainsKey(75) && DateTime.UtcNow.Subtract(this.SpellAnimationHistory[75]).TotalSeconds < 153.0;

    public bool hasdemonseal => this.SpellAnimationHistory.ContainsKey(76) && DateTime.UtcNow.Subtract(this.SpellAnimationHistory[76]).TotalSeconds < 153.0;

    public bool hasaite
    {
      get
      {
        if (!this.SpellAnimationHistory.ContainsKey(231))
          return false;
        if (this.ProbableSpellType.ContainsKey(231) && this.ProbableSpellType[231].Equals("ard naomh aite"))
          return DateTime.UtcNow.Subtract(this.SpellAnimationHistory[231]).TotalSeconds < 601.0;
        if (this.ProbableSpellType.ContainsKey(231) && this.ProbableSpellType[231].Equals("mor naomh aite"))
          return DateTime.UtcNow.Subtract(this.SpellAnimationHistory[231]).TotalSeconds < 301.0;
        return (!this.ProbableSpellType.ContainsKey(231) || !this.ProbableSpellType[231].Equals("naomh aite")) && this.ProbableSpellType.ContainsKey(231) && this.ProbableSpellType[231].Equals("beag naomh aite") ? DateTime.UtcNow.Subtract(this.SpellAnimationHistory[231]).TotalSeconds < 61.0 : DateTime.UtcNow.Subtract(this.SpellAnimationHistory[231]).TotalSeconds < 181.0;
      }
    }

    public bool hasfas
    {
      get
      {
        if (!this.SpellAnimationHistory.ContainsKey(273))
          return false;
        if (this.ProbableSpellType.ContainsKey(273) && this.ProbableSpellType[273].Equals("ard fas nadur"))
          return DateTime.UtcNow.Subtract(this.SpellAnimationHistory[273]).TotalSeconds < 226.0;
        if (this.ProbableSpellType.ContainsKey(273) && this.ProbableSpellType[273].Equals("mor fas nadur"))
          return DateTime.UtcNow.Subtract(this.SpellAnimationHistory[273]).TotalSeconds < 451.0;
        if (this.ProbableSpellType.ContainsKey(273) && this.ProbableSpellType[273].Equals("fas nadur"))
          return DateTime.UtcNow.Subtract(this.SpellAnimationHistory[273]).TotalSeconds < 201.0;
        return !this.ProbableSpellType.ContainsKey(273) || !this.ProbableSpellType[273].Equals("beag fas nadur") ? DateTime.UtcNow.Subtract(this.SpellAnimationHistory[273]).TotalSeconds < 226.0 : DateTime.UtcNow.Subtract(this.SpellAnimationHistory[273]).TotalSeconds < 451.0;
      }
    }

    public bool hasarmachd => this.SpellAnimationHistory.ContainsKey(20) && DateTime.UtcNow.Subtract(this.SpellAnimationHistory[20]).TotalSeconds < 150.0;

    public bool hasbeann => this.SpellAnimationHistory.ContainsKey(280) && DateTime.UtcNow.Subtract(this.SpellAnimationHistory[280]).TotalSeconds < 240.0;

    public bool hascreagneart => this.SpellAnimationHistory.ContainsKey(6) && DateTime.UtcNow.Subtract(this.SpellAnimationHistory[6]).TotalSeconds < 163.0;

    public bool hasregen => this.SpellAnimationHistory.ContainsKey(187) && DateTime.UtcNow.Subtract(this.SpellAnimationHistory[187]).TotalSeconds < 1.5;

    public bool hasca => this.SpellAnimationHistory.ContainsKey(184) && DateTime.UtcNow.Subtract(this.SpellAnimationHistory[184]).TotalSeconds < 21.0;

    public bool haspramh => this.SpellAnimationHistory.ContainsKey(32) && DateTime.UtcNow.Subtract(this.SpellAnimationHistory[32]).TotalSeconds < 2.2;

    public bool haswff => this.SpellAnimationHistory.ContainsKey(40) && (!this.AnimationFrom.ContainsKey(40) || this.AnimationFrom[40] == 208 || this.AnimationFrom[40] == 204 || this.AnimationFrom[40] == 356 || this.AnimationFrom[40] == 357 || this.AnimationFrom[40] == 537 || this.AnimationFrom[40] == 538 || this.AnimationFrom[40] == 539 || this.AnimationFrom[40] == 540 || this.AnimationFrom[40] == 541) && DateTime.UtcNow.Subtract(this.SpellAnimationHistory[40]).TotalSeconds < 2.2;

    public bool hassuain => this.SpellAnimationHistory.ContainsKey(40) && (!this.AnimationFrom.ContainsKey(40) || this.AnimationFrom[40] != 208 && this.AnimationFrom[40] != 204 && this.AnimationFrom[40] != 356 && this.AnimationFrom[40] != 357 && this.AnimationFrom[40] != 537 && this.AnimationFrom[40] != 538 && this.AnimationFrom[40] != 539 && this.AnimationFrom[40] != 540 && this.AnimationFrom[40] != 541) && DateTime.UtcNow.Subtract(this.SpellAnimationHistory[40]).TotalSeconds < 2.2;

    public bool hasbeagsuain => this.SpellAnimationHistory.ContainsKey(41) && DateTime.UtcNow.Subtract(this.SpellAnimationHistory[41]).TotalSeconds < 2.2;

    public bool hasdall => this.SpellAnimationHistory.ContainsKey(42) && DateTime.UtcNow.Subtract(this.SpellAnimationHistory[42]).TotalSeconds < 18.0;

    public bool hasmes => this.SpellAnimationHistory.ContainsKey(117) && DateTime.UtcNow.Subtract(this.SpellAnimationHistory[117]).TotalSeconds < 2.2;

    public bool justfright
    {
      get
      {
        if (!this.SpellAnimationHistory.ContainsKey(328) || this.AnimationFrom.ContainsKey(328) && this.AnimationFrom[328] != 716)
          return false;
        this.SpellAnimationHistory.Remove(328);
        return true;
      }
    }

    public bool justeyeattack
    {
      get
      {
        if (!this.SpellAnimationHistory.ContainsKey(236) || this.AnimationFrom.ContainsKey(236) && this.AnimationFrom[236] != 716)
          return false;
        this.SpellAnimationHistory.Remove(236);
        return true;
      }
    }

    public bool justfaeattack
    {
      get
      {
        if (!this.SpellAnimationHistory.ContainsKey(287) || this.AnimationFrom.ContainsKey(287) && this.AnimationFrom[287] != 704)
          return false;
        this.SpellAnimationHistory.Remove(287);
        return true;
      }
    }

    public bool justsquidattack
    {
      get
      {
        if (!this.SpellAnimationHistory.ContainsKey(332) || this.AnimationFrom.ContainsKey(332) && this.AnimationFrom[332] != 715)
          return false;
        this.SpellAnimationHistory.Remove(332);
        return true;
      }
    }

    public bool justramattack
    {
      get
      {
        if (!this.SpellAnimationHistory.ContainsKey(129) || this.AnimationFrom.ContainsKey(129) && this.AnimationFrom[129] != 706)
          return false;
        this.SpellAnimationHistory.Remove(129);
        return true;
      }
    }

    public bool justhpcupped
    {
      get
      {
        if (!this.SpellAnimationHistory.ContainsKey(162))
          return false;
        this.SpellAnimationHistory.Remove(162);
        return true;
      }
    }

    public bool justcrashered
    {
      get
      {
        if (!this.SpellAnimationHistory.ContainsKey(50))
          return false;
        this.SpellAnimationHistory.Remove(50);
        return true;
      }
    }

    public bool justmadsouled
    {
      get
      {
        if (!this.SpellAnimationHistory.ContainsKey(53))
          return false;
        this.SpellAnimationHistory.Remove(53);
        return true;
      }
    }

    public bool justkelbed
    {
      get
      {
        if (!this.SpellAnimationHistory.ContainsKey(48))
          return false;
        this.SpellAnimationHistory.Remove(48);
        return true;
      }
    }

    public bool justspioraded
    {
      get
      {
        if (!this.SpellAnimationHistory.ContainsKey(1))
          return false;
        this.SpellAnimationHistory.Remove(1);
        return true;
      }
    }

    public bool justgotflowered
    {
      get
      {
        if (!this.SpellAnimationHistory.ContainsKey(84))
          return false;
        this.SpellAnimationHistory.Remove(84);
        return true;
      }
    }

    public bool hasct => this.SpellAnimationHistory.ContainsKey(295) && DateTime.UtcNow.Subtract(this.SpellAnimationHistory[295]).TotalSeconds < 3.25;

    public bool isskulled => this.SpellAnimationHistory.ContainsKey(24) && DateTime.UtcNow.Subtract(this.SpellAnimationHistory[24]).TotalSeconds < 1.5;

    public bool hasswirlpoison => this.SpellAnimationHistory.ContainsKey(25) && DateTime.UtcNow.Subtract(this.SpellAnimationHistory[25]).TotalSeconds < 2.2;

    public bool hasbubblepoison => this.SpellAnimationHistory.ContainsKey(247) && DateTime.UtcNow.Subtract(this.SpellAnimationHistory[247]).TotalSeconds < 0.5;

    public bool hasmonsterdion
    {
      get
      {
        if (!this.SpellAnimationHistory.ContainsKey(271))
          return false;
        return !(this is Npc) || (this as Npc).Image == 204 || (this as Npc).Image == 208 || (this as Npc).Image == 356 || (this as Npc).Image == 357 ? DateTime.UtcNow.Subtract(this.SpellAnimationHistory[271]).TotalSeconds < 20.0 : DateTime.UtcNow.Subtract(this.SpellAnimationHistory[271]).TotalSeconds < 8.0;
      }
    }

    public bool hasdion => this.SpellAnimationHistory.ContainsKey(244) && DateTime.UtcNow.Subtract(this.SpellAnimationHistory[244]).TotalSeconds < 20.0;

    public bool hasshortdion => this.SpellAnimationHistory.ContainsKey(244) && DateTime.UtcNow.Subtract(this.SpellAnimationHistory[244]).TotalSeconds < 8.0;

    public bool hasdracostance => this.SpellAnimationHistory.ContainsKey(6) && DateTime.UtcNow.Subtract(this.SpellAnimationHistory[6]).TotalSeconds < 8.0;

    public bool hasdioncomlha => this.SpellAnimationHistory.ContainsKey(93) && DateTime.UtcNow.Subtract(this.SpellAnimationHistory[93]).TotalSeconds < 20.0;

    public bool hasironskin => this.SpellAnimationHistory.ContainsKey(89) && DateTime.UtcNow.Subtract(this.SpellAnimationHistory[89]).TotalSeconds < 19.0;

    public bool haswingsofprot => this.SpellAnimationHistory.ContainsKey(86) && DateTime.UtcNow.Subtract(this.SpellAnimationHistory[86]).TotalSeconds < 14.0;

    public bool hasasgall => this.SpellAnimationHistory.ContainsKey(66) && DateTime.UtcNow.Subtract(this.SpellAnimationHistory[66]).TotalSeconds < 13.0;

    public bool hasdragonsfire => this.SpellAnimationHistory.ContainsKey(34) && DateTime.UtcNow.Subtract(this.SpellAnimationHistory[34]).TotalSeconds < 600.0;

    public bool IsInMaxView(Location loc, int dist) => (dist <= 8 || (dist < 11 || this.Location.X > loc.X || this.Location.Y < loc.Y || this.DistanceFrom(loc) <= 11) && (dist != 12 || this.Location.X < loc.X || this.Location.Y >= loc.Y || this.DistanceFrom(loc) <= 11)) && this.DistanceFrom(loc) <= dist;

    public int DistanceFrom(Location loc) => Math.Abs(this.Location.X - loc.X) + Math.Abs(this.Location.Y - loc.Y);

    public bool WithinSquare(Location loc, int num) => Math.Abs(this.Location.X - loc.X) <= num && Math.Abs(this.Location.Y - loc.Y) <= num;

    public bool IsInRSRange(Location loc, int dist)
    {
      if (loc.Direction == Direction.North)
      {
        if (this.Location.X == loc.X && Math.Abs(this.Location.Y - loc.Y) < dist && this.Location.Y <= loc.Y)
          return true;
      }
      else if (loc.Direction == Direction.South)
      {
        if (this.Location.X == loc.X && Math.Abs(this.Location.Y - loc.Y) < dist && this.Location.Y >= loc.Y)
          return true;
      }
      else if (loc.Direction == Direction.East)
      {
        if (this.Location.Y == loc.Y && Math.Abs(this.Location.X - loc.X) < dist && this.Location.X >= loc.X)
          return true;
      }
      else if (loc.Direction == Direction.West && this.Location.Y == loc.Y && Math.Abs(this.Location.X - loc.X) < dist && this.Location.X <= loc.X)
        return true;
      return false;
    }

    public bool IsBehind(Location loc)
    {
      if (loc.Direction == Direction.North)
      {
        if (this.Location.Y > loc.Y)
          return true;
      }
      else if (loc.Direction == Direction.South)
      {
        if (this.Location.Y < loc.Y)
          return true;
      }
      else if (loc.Direction == Direction.East)
      {
        if (this.Location.X < loc.X)
          return true;
      }
      else if (loc.Direction == Direction.West && this.Location.X > loc.X)
        return true;
      return false;
    }

    public bool IsInFront(Location loc)
    {
      if (loc.Direction == Direction.South)
      {
        if (this.Location.Y >= loc.Y + 1 && this.Location.X == loc.X && this.Location.DistanceFrom(loc) == 1)
          return true;
      }
      else if (loc.Direction == Direction.North)
      {
        if (this.Location.Y <= loc.Y - 1 && this.Location.X == loc.X && this.Location.DistanceFrom(loc) == 1)
          return true;
      }
      else if (loc.Direction == Direction.West)
      {
        if (this.Location.X <= loc.X - 1 && this.Location.Y == loc.Y && this.Location.DistanceFrom(loc) == 1)
          return true;
      }
      else if (loc.Direction == Direction.East && this.Location.X >= loc.X + 1 && this.Location.Y == loc.Y && this.Location.DistanceFrom(loc) == 1)
        return true;
      return false;
    }

    public bool IsFacing(Location loc, int dist)
    {
      if (this.Location.Direction == Direction.North)
      {
        if (this.Location.X == loc.X && Math.Abs(this.Location.Y - loc.Y) < dist && this.Location.Y > loc.Y)
          return true;
      }
      else if (this.Location.Direction == Direction.South)
      {
        if (this.Location.X == loc.X && Math.Abs(this.Location.Y - loc.Y) < dist && this.Location.Y < loc.Y)
          return true;
      }
      else if (this.Location.Direction == Direction.East)
      {
        if (this.Location.Y == loc.Y && Math.Abs(this.Location.X - loc.X) < dist && this.Location.X < loc.X)
          return true;
      }
      else if (this.Location.Direction == Direction.West && this.Location.Y == loc.Y && Math.Abs(this.Location.X - loc.X) < dist && this.Location.X > loc.X)
        return true;
      return false;
    }
  }
}
