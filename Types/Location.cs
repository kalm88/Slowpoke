//SlowPoke
// Type: Flintstones.Location
//SlowPoke
//SlowPoke
//SlowPoke

using System;

namespace Flintstones
{
  public class Location
  {
    public Direction Direction = Direction.None;

    public int X { get; set; }

    public int Y { get; set; }

    public Location(int x, int y)
    {
      this.X = x;
      this.Y = y;
    }

    public int DistanceFrom(Location loc) => Math.Abs(this.X - loc.X) + Math.Abs(this.Y - loc.Y);

    public int DistanceFrom(int x, int y) => Math.Abs(this.X - x) + Math.Abs(this.Y - y);

    public bool WithinSquare(Location loc, int num) => Math.Abs(this.X - loc.X) <= num && Math.Abs(this.Y - loc.Y) <= num;

    public static Location operator +(Location a, Direction b)
    {
      Location location = new Location(a.X, a.Y);
      switch (b)
      {
        case Direction.North:
          --location.Y;
          break;
        case Direction.East:
          ++location.X;
          break;
        case Direction.South:
          ++location.Y;
          break;
        case Direction.West:
          --location.X;
          break;
      }
      return location;
    }

    public static Direction operator -(Location a, Location b)
    {
      if (a.X == b.X && a.Y == b.Y + 1)
        return Direction.North;
      if (a.X == b.X && a.Y == b.Y - 1)
        return Direction.South;
      if (a.X == b.X + 1 && a.Y == b.Y)
        return Direction.West;
      return a.X != b.X - 1 || a.Y != b.Y ? Direction.None : Direction.East;
    }
  }
}
