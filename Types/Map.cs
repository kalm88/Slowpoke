//SlowPoke
// Type: Flintstones.Map
//SlowPoke
//SlowPoke
//SlowPoke

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Flintstones
{
  public class Map
  {
    public byte[,] BaseMatrix = new byte[0, 0];

    public static byte[] Sotp { get; private set; }

    public string Name { get; set; }

    public int Number { get; set; }

    public int Width { get; set; }

    public int Height { get; set; }

    public byte Bitmask { get; set; }

    public ushort Checksum { get; set; }

    public Point[,] Tiles { get; private set; }

    public bool IsLoaded { get; private set; }

    public bool Initialize()
    {
      try
      {
        this.Tiles = new Point[this.Width, this.Height];
        string path = Options.DarkAgesMapsDirectoryName + "\\lod" + this.Number.ToString() + ".map";
        this.IsLoaded = false;
        if (File.Exists(path))
        {
          FileStream fileStream = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.Read);
          for (int y = 0; y < this.Height; ++y)
          {
            for (int x = 0; x < this.Width; ++x)
            {
              this.Tiles[x, y] = new Point(x, y);
              this.Tiles[x, y].StepCount = -1;
              fileStream.ReadByte();
              fileStream.ReadByte();
              ushort num1 = (ushort) (fileStream.ReadByte() | fileStream.ReadByte() << 8);
              ushort num2 = (ushort) (fileStream.ReadByte() | fileStream.ReadByte() << 8);
              this.Tiles[x, y].IsWall = num1 != (ushort) 0 && Map.Sotp[(int) num1 - 1] != (byte) 0 || num2 != (ushort) 0 && Map.Sotp[(int) num2 - 1] > (byte) 0;
            }
          }
          fileStream.Close();
          this.LoadMatrix();
          this.IsLoaded = true;
        }
        return true;
      }
      catch
      {
        return true;
      }
    }

    public static bool LoadSotp(string iaDatPath)
    {
      if (Map.Sotp == null && File.Exists(iaDatPath))
      {
        using (FileStream input = File.Open(iaDatPath, FileMode.Open, FileAccess.Read, FileShare.Read))
        {
          using (BinaryReader binaryReader = new BinaryReader((Stream) input))
          {
            int count = binaryReader.ReadInt32() - 1;
            for (int index = 0; index < count; ++index)
            {
              int num = binaryReader.ReadInt32();
              byte[] bytes = binaryReader.ReadBytes(13);
              binaryReader.ReadInt32();
              if (Encoding.ASCII.GetString(bytes).StartsWith("sotp.dat\0"))
              {
                input.Position = (long) num;
                Map.Sotp = binaryReader.ReadBytes(count);
                break;
              }
              input.Position -= 4L;
            }
          }
        }
      }
      return Map.Sotp != null;
    }

    private static bool CheckSOTP(ushort Left, ushort Right)
    {
      if (Left == (ushort) 0 && Right == (ushort) 0)
        return false;
      if (Left == (ushort) 0)
      {
        try
        {
          return Map.Sotp[(int) Right - 1] > (byte) 0;
        }
        catch
        {
          return true;
        }
      }
      else if (Right == (ushort) 0)
      {
        try
        {
          return Map.Sotp[(int) Left - 1] > (byte) 0;
        }
        catch
        {
          return true;
        }
      }
      else
      {
        try
        {
          return Map.Sotp[(int) Left - 1] != (byte) 0 || Map.Sotp[(int) Right - 1] > (byte) 0;
        }
        catch
        {
          return true;
        }
      }
    }

    public bool LoadMatrix()
    {
      try
      {
        FileStream input = File.OpenRead(Options.DarkAgesMapsDirectoryName + "\\lod" + this.Number.ToString() + ".map");
        BinaryReader binaryReader = new BinaryReader((Stream) input);
        this.BaseMatrix = new byte[this.Width + 1, this.Height + 1];
        for (int index1 = 0; index1 < this.Height; ++index1)
        {
          for (int index2 = 0; index2 < this.Width; ++index2)
          {
            int num = (int) binaryReader.ReadUInt16();
            this.BaseMatrix[index2, index1] = Map.CheckSOTP(binaryReader.ReadUInt16(), binaryReader.ReadUInt16()) ? (byte) 0 : (byte) 1;
          }
        }
        input.Close();
        return true;
      }
      catch (ObjectDisposedException ex)
      {
        return true;
      }
      catch (Exception ex)
      {
        return false;
      }
    }

    public Point[] SurroundingPoints(Point pt)
    {
      List<Point> pointList = new List<Point>();
      if (pt.X > 0)
        pointList.Add(this.Tiles[pt.X - 1, pt.Y]);
      if (pt.Y > 0)
        pointList.Add(this.Tiles[pt.X, pt.Y - 1]);
      if (pt.X < this.Width - 1)
        pointList.Add(this.Tiles[pt.X + 1, pt.Y]);
      if (pt.Y < this.Height - 1)
        pointList.Add(this.Tiles[pt.X, pt.Y + 1]);
      return pointList.ToArray();
    }

    public void UpdateBlocks(Client client)
    {
      Point[,] tiles = this.Tiles;
      int upperBound1 = tiles.GetUpperBound(0);
      int upperBound2 = tiles.GetUpperBound(1);
      for (int lowerBound1 = tiles.GetLowerBound(0); lowerBound1 <= upperBound1; ++lowerBound1)
      {
        for (int lowerBound2 = tiles.GetLowerBound(1); lowerBound2 <= upperBound2; ++lowerBound2)
        {
          Point point = tiles[lowerBound1, lowerBound2];
          if (point != null)
          {
            DateTime today;
            if (this.Name == "Pravat Deep")
            {
              int num = point.X == 3 && point.Y == 9 || point.X == 3 && point.Y == 10 || point.X == 3 && point.Y == 11 || point.X == 4 && point.Y == 9 || point.X == 4 && point.Y == 10 || point.X == 4 && point.Y == 11 || point.X == 5 && point.Y == 9 || point.X == 5 && point.Y == 10 || point.X == 5 && point.Y == 11 || point.X == 9 && point.Y == 3 || point.X == 9 && point.Y == 2 || point.X == 9 && point.Y == 1 || point.X == 10 && point.Y == 3 || point.X == 10 && point.Y == 2 || point.X == 10 && point.Y == 1 || point.X == 11 && point.Y == 3 || point.X == 11 && point.Y == 2 ? 1 : (point.X != 11 ? 0 : (point.Y == 1 ? 1 : 0));
              point.HasBlock = num != 0;
            }
            else if (this.Number == 662)
            {
              int num = point.X != 84 || point.Y != 15 ? (point.X != 85 ? 0 : (point.Y == 15 ? 1 : 0)) : 1;
              point.HasBlock = num != 0;
            }
            else if (this.Number == 501)
            {
              int num = point.X != 58 ? 0 : (point.Y == 57 ? 1 : 0);
              point.HasBlock = num != 0;
            }
            else if (this.Number == 190)
            {
              int num = point.X != 12 ? 0 : (point.Y == 20 ? 1 : 0);
              point.HasBlock = num != 0;
            }
            else if (this.Number == 187)
            {
              int num = point.X != 13 ? 0 : (point.Y == 3 ? 1 : 0);
              point.HasBlock = num != 0;
            }
            else if (this.Number == 3006)
            {
              int num = point.X != 15 ? 0 : (point.Y == 5 ? 1 : 0);
              point.HasBlock = num != 0;
            }
            else if (this.Number == 13)
            {
              int num = point.X != 44 ? 0 : (point.Y == 9 ? 1 : 0);
              point.HasBlock = num != 0;
            }
            else if (this.Name == "Mileth Village")
            {
              today = DateTime.Today;
              string str = today.ToString();
              if (str == "2/14/2021 12:00:00 AM" || str == "2/15/2021 12:00:00 AM" || str == "2/16/2021 12:00:00 AM" || str == "2/17/2021 12:00:00 AM" || str == "2/18/2021 12:00:00 AM" || str == "2/19/2021 12:00:00 AM" || str == "2/20/2021 12:00:00 AM" || str == "2/21/2021 12:00:00 AM" || str == "2/22/2021 12:00:00 AM" || str == "2/23/2021 12:00:00 AM" || str == "2/24/2021 12:00:00 AM" || str == "2/25/2021 12:00:00 AM" || str == "2/26/2021 12:00:00 AM" || str == "2/27/2021 12:00:00 AM" || str == "2/28/2021 12:00:00 AM" || str == "2/29/2021 12:00:00 AM" || str == "3/1/2021 12:00:00 AM" || str == "3/2/2021 12:00:00 AM")
              {
                if (point.X == 88 && point.Y == 32 || point.X == 88 && point.Y == 31)
                  point.HasBlock = true;
                else if (point.Y == 30 && (point.X == 87 || point.X == 86 || point.X == 85 || point.X == 84 || point.X == 83))
                  point.HasBlock = true;
                else if (point.Y == 32 && (point.X == 96 || point.X == 95 || point.X == 94))
                {
                  point.HasBlock = true;
                }
                else
                {
                  int num = point.X != 75 ? 0 : (point.Y == 41 || point.Y == 40 || point.Y == 39 ? 1 : (point.Y == 38 ? 1 : 0));
                  point.HasBlock = num != 0;
                }
              }
              else
                point.HasBlock = false;
            }
            else if (this.Name == "Undine Village Way")
            {
              today = DateTime.Today;
              string str = today.ToString();
              if (str == "2/14/2021 12:00:00 AM" || str == "2/15/2021 12:00:00 AM" || str == "2/16/2021 12:00:00 AM" || str == "2/17/2021 12:00:00 AM" || str == "2/18/2021 12:00:00 AM" || str == "2/19/2021 12:00:00 AM" || str == "2/20/2021 12:00:00 AM" || str == "2/21/2021 12:00:00 AM" || str == "2/22/2021 12:00:00 AM" || str == "2/23/2021 12:00:00 AM" || str == "2/24/2021 12:00:00 AM" || str == "2/25/2021 12:00:00 AM" || str == "2/26/2021 12:00:00 AM" || str == "2/27/2021 12:00:00 AM" || str == "2/28/2021 12:00:00 AM" || str == "2/29/2021 12:00:00 AM" || str == "3/1/2021 12:00:00 AM" || str == "3/2/2021 12:00:00 AM")
              {
                if (point.X == 15 && point.Y == 5)
                  point.HasBlock = true;
                else if (point.X == 14 && point.Y == 4)
                  point.HasBlock = true;
                else if (point.X == 12 && point.Y == 4)
                  point.HasBlock = true;
                else if (point.X == 13 && (point.Y == 3 || point.Y == 4))
                {
                  point.HasBlock = true;
                }
                else
                {
                  int num = point.X != 11 ? 0 : (point.Y == 7 || point.Y == 6 ? 1 : (point.Y == 5 ? 1 : 0));
                  point.HasBlock = num != 0;
                }
              }
              else
                point.HasBlock = false;
            }
            else if (this.Name == "Undine Village")
            {
              today = DateTime.Today;
              string str = today.ToString();
              if (str == "2/14/2021 12:00:00 AM" || str == "2/15/2021 12:00:00 AM" || str == "2/16/2021 12:00:00 AM" || str == "2/17/2021 12:00:00 AM" || str == "2/18/2021 12:00:00 AM" || str == "2/19/2021 12:00:00 AM" || str == "2/20/2021 12:00:00 AM" || str == "2/21/2021 12:00:00 AM" || str == "2/22/2021 12:00:00 AM" || str == "2/23/2021 12:00:00 AM" || str == "2/24/2021 12:00:00 AM" || str == "2/25/2021 12:00:00 AM" || str == "2/26/2021 12:00:00 AM" || str == "2/27/2021 12:00:00 AM" || str == "2/28/2021 12:00:00 AM" || str == "2/29/2021 12:00:00 AM" || str == "3/1/2021 12:00:00 AM" || str == "3/2/2021 12:00:00 AM")
              {
                if (point.X == 63 && point.Y == 49)
                  point.HasBlock = true;
                else if (point.X == 64 && point.Y == 44)
                  point.HasBlock = true;
                else if (point.X == 61 && (point.Y == 48 || point.Y == 42))
                  point.HasBlock = true;
                else if (point.X == 60 && (point.Y == 47 || point.Y == 46 || point.Y == 45))
                {
                  point.HasBlock = true;
                }
                else
                {
                  int num = point.X != 61 ? 0 : (point.Y == 48 ? 1 : (point.Y == 42 ? 1 : 0));
                  point.HasBlock = num != 0;
                }
              }
              else
                point.HasBlock = false;
            }
            else if (this.Name == "Suomi Village")
            {
              today = DateTime.Today;
              string str = today.ToString();
              if (str == "2/14/2021 12:00:00 AM" || str == "2/15/2021 12:00:00 AM" || str == "2/16/2021 12:00:00 AM" || str == "2/17/2021 12:00:00 AM" || str == "2/18/2021 12:00:00 AM" || str == "2/19/2021 12:00:00 AM" || str == "2/20/2021 12:00:00 AM" || str == "2/21/2021 12:00:00 AM" || str == "2/22/2021 12:00:00 AM" || str == "2/23/2021 12:00:00 AM" || str == "2/24/2021 12:00:00 AM" || str == "2/25/2021 12:00:00 AM" || str == "2/26/2021 12:00:00 AM" || str == "2/27/2021 12:00:00 AM" || str == "2/28/2021 12:00:00 AM" || str == "2/29/2021 12:00:00 AM" || str == "3/1/2021 12:00:00 AM" || str == "3/2/2021 12:00:00 AM")
              {
                if (point.X == 33 && point.Y == 6)
                  point.HasBlock = true;
                else if (point.X == 29 && point.Y == 6)
                  point.HasBlock = true;
                else if (point.X == 27 && point.Y == 5)
                  point.HasBlock = true;
                else if (point.X == 36 && (point.Y == 10 || point.Y == 13))
                  point.HasBlock = true;
                else if (point.X == 37 && (point.Y == 10 || point.Y == 15))
                {
                  point.HasBlock = true;
                }
                else
                {
                  int num = point.X != 34 ? 0 : (point.Y == 6 ? 1 : (point.Y == 15 ? 1 : 0));
                  point.HasBlock = num != 0;
                }
              }
              else
                point.HasBlock = false;
            }
            else if (this.Name == "Rucesion Village")
            {
              if (point.X == 29 && point.Y == 12)
                point.HasBlock = true;
            }
            else if (this.Name == "Pyramid Maze")
            {
              int num = point.Y != 55 ? 0 : (point.X == 83 || point.X == 84 || point.X == 85 || point.X == 86 || point.X == 87 || point.X == 88 || point.X == 89 ? 1 : (point.X == 90 ? 1 : 0));
              point.HasBlock = num != 0;
            }
            else if (this.Name == "Mount Giragan 1")
            {
              int num = point.X != 39 ? 0 : (point.Y == 9 || point.Y == 8 || point.Y == 7 ? 1 : (point.Y == 6 ? 1 : 0));
              point.HasBlock = num != 0;
            }
            else if (this.Number == 11348)
            {
              if (point.X == 24 && point.Y == 20)
              {
                point.HasBlock = true;
              }
              else
              {
                int num = point.X != 25 ? 0 : (point.Y == 20 || point.Y == 21 ? 1 : (point.Y == 22 ? 1 : 0));
                point.HasBlock = num != 0;
              }
            }
            else if (this.Number == 11352)
            {
              int num = point.Y != 23 ? 0 : (point.X == 38 || point.X == 39 ? 1 : (point.X == 40 ? 1 : 0));
              point.HasBlock = num != 0;
            }
            else if (this.Number == 11309)
            {
              if (point.X == 23 && (point.Y == 11 || point.X == 12 || point.X == 13))
                point.HasBlock = true;
              else if (point.X == 24 && (point.Y == 13 || point.Y == 14))
              {
                point.HasBlock = true;
              }
              else
              {
                int num = point.X != 25 ? 0 : (point.Y == 13 ? 1 : 0);
                point.HasBlock = num != 0;
              }
            }
            else if (this.Number == 11338)
            {
              int num = point.X != 27 ? 0 : (point.Y == 16 || point.X == 17 ? 1 : (point.X == 18 ? 1 : 0));
              point.HasBlock = num != 0;
            }
            else if (this.Number == 4009)
            {
              int num = point.X != 25 ? 0 : (point.Y == 12 || point.Y == 13 || point.Y == 14 ? 1 : (point.Y == 15 ? 1 : 0));
              point.HasBlock = num != 0;
            }
            else if (this.Number == 3041)
            {
              int num = point.X != 2 || point.Y != 9 ? (point.X != 1 ? 0 : (point.Y == 14 ? 1 : 0)) : 1;
              point.HasBlock = num != 0;
            }
            else if (this.Number == 120)
            {
              int num = point.X != 6 ? 0 : (point.Y == 1 ? 1 : 0);
              point.HasBlock = num != 0;
            }
            else if (this.Number == 126)
            {
              int num = point.X != 1 ? 0 : (point.Y == 7 ? 1 : 0);
              point.HasBlock = num != 0;
            }
            else if (this.Number == 115)
            {
              int num = point.X != 1 || point.Y != 7 ? (point.X != 1 ? 0 : (point.Y == 10 ? 1 : 0)) : 1;
              point.HasBlock = num != 0;
            }
            else if (this.Number == 3085)
            {
              int num = point.X != 10 || point.Y != 5 ? (point.X != 10 ? 0 : (point.Y == 6 ? 1 : 0)) : 1;
              point.HasBlock = num != 0;
            }
            else if (this.Name == "North Pole")
            {
              int num = point.X == 20 && point.Y == 8 || point.X == 8 && point.Y == 11 ? 1 : (point.X != 9 ? 0 : (point.Y == 11 ? 1 : 0));
              point.HasBlock = num != 0;
            }
            else if (this.Name == "Mount Merry 4-2")
            {
              int num = point.X != 31 || point.Y != 48 ? (point.X != 29 ? 0 : (point.Y == 48 ? 1 : 0)) : 1;
              point.HasBlock = num != 0;
            }
            else if (this.Name == "Pravat West Entrance")
              point.HasBlock = point.Y == 0;
            else if (this.Name == "Pravat South Entrance")
            {
              int num = point.Y == 25 && (point.X == 26 || point.X == 25 || point.X == 24 || point.X == 27 || point.X == 33 || point.X == 34 || point.X == 35 || point.X == 36) || point.Y == 14 && (point.X == 35 || point.X == 36 || point.X == 37 || point.X == 38) || point.X == 88 && (point.Y == 32 || point.Y == 31) || point.Y == 30 && (point.X == 87 || point.X == 86 || point.X == 85 || point.X == 84 || point.X == 83) || point.Y == 32 && (point.X == 96 || point.X == 95 || point.X == 94) ? 1 : (point.X != 75 ? 0 : (point.Y == 41 || point.Y == 40 || point.Y == 39 ? 1 : (point.Y == 38 ? 1 : 0)));
              point.HasBlock = num != 0;
            }
            else if (this.Name == "Preserved Vault")
            {
              int num = point.X == 13 && point.Y == 16 || point.X == 1 && point.Y == 17 || point.X == 13 && point.Y == 18 || point.X == 13 && point.Y == 19 || point.X == 16 && point.Y == 13 || point.X == 17 && point.Y == 13 || point.X == 18 && point.Y == 13 || point.X == 19 && point.Y == 13 || point.X == 25 && point.Y == 13 || point.X == 26 && point.Y == 13 || point.X == 27 && point.Y == 13 || point.X == 28 && point.Y == 13 || point.X == 13 && point.Y == 25 || point.X == 13 && point.Y == 26 || point.X == 13 && point.Y == 27 || point.X == 13 && point.Y == 28 || point.X == 2 && point.Y == 25 || point.X == 2 && point.Y == 26 || point.X == 2 && point.Y == 27 || point.X == 2 && point.Y == 28 || point.X == 2 && point.Y == 5 || point.X == 2 && point.Y == 6 || point.X == 2 && point.Y == 7 || point.X == 2 && point.Y == 8 || point.X == 5 && point.Y == 2 || point.X == 6 && point.Y == 2 || point.X == 7 && point.Y == 2 ? 1 : (point.X != 8 ? 0 : (point.Y == 2 ? 1 : 0));
              point.HasBlock = num != 0;
            }
            else if (this.Name == "Chaos 13")
            {
              int num = point.X != 63 ? 0 : (point.Y == 71 ? 1 : 0);
              point.HasBlock = num != 0;
            }
            else if (this.Name == "Oren Island City")
            {
              int num = point.X == 64 && point.Y == 120 || point.X == 71 && point.Y == 112 || point.X == 74 && point.Y == 105 ? 1 : (point.X != 56 ? 0 : (point.Y == 134 || point.Y == 133 || point.Y == 132 || point.Y == 131 || point.Y == 130 ? 1 : (point.Y == 129 ? 1 : 0)));
              point.HasBlock = num != 0;
            }
            else if (this.Name == "Oren Ruins 1-4")
            {
              int num = point.X != 0 ? 0 : (point.Y < 44 ? 0 : (point.Y <= 51 ? 1 : 0));
              point.HasBlock = num != 0;
            }
            else if (this.Name == "Oren Ruins 1-3")
            {
              int num = point.X != 68 ? 0 : (point.Y == 0 ? 1 : 0);
              point.HasBlock = num != 0;
            }
            else if (this.Name == "Oren Ruins 2-3")
            {
              int num = point.Y != 0 ? 0 : (point.X < 49 ? 0 : (point.X <= 67 ? 1 : 0));
              point.HasBlock = num != 0;
            }
            else if (this.Name == "Lost Ruins 1")
            {
              int num = point.Y == 28 && point.X >= 42 && point.X <= 46 || point.Y == 0 && point.X >= 21 && point.X <= 33 ? 1 : (point.X != 0 ? 0 : (point.Y < 33 ? 0 : (point.Y <= 36 ? 1 : 0)));
              point.HasBlock = num != 0;
            }
            else
              point.HasBlock = false;
            point.HasEntity = false;
          }
        }
      }
      if (client.TempRegions.ContainsKey(this.Number))
      {
        foreach (KeyValuePair<Location, string> region in client.TempRegions[this.Number].Regions)
        {
          if (region.Key != null && region.Value == "Block" && client.MapInfo.Tiles[region.Key.X, region.Key.Y] != null)
            client.MapInfo.Tiles[region.Key.X, region.Key.Y].HasBlock = true;
        }
      }
      lock (client.Characters)
      {
        foreach (Character character in client.Characters.Values.ToArray<Character>())
        {
          if (character != null && character.IsOnScreen && (int) character.ID != (int) client.PlayerID)
          {
            int num;
            switch (character)
            {
              case Player _:
                if (((character as Player).Body != (byte) 0 || character.Name != "" && !character.Name.Equals("ishikawa", StringComparison.CurrentCultureIgnoreCase) && !character.Name.Equals("error", StringComparison.CurrentCultureIgnoreCase) && !character.Name.Equals("and", StringComparison.CurrentCultureIgnoreCase) && !character.Name.Equals("trial", StringComparison.CurrentCultureIgnoreCase)) && client.MapInfo.Tiles[character.Location.X, character.Location.Y] != null)
                {
                  client.MapInfo.Tiles[character.Location.X, character.Location.Y].HasBlock = true;
                  client.MapInfo.Tiles[character.Location.X, character.Location.Y].HasEntity = true;
                  continue;
                }
                continue;
              case Npc _:
                num = (character as Npc).Type == Npc.NpcType.PassableMonster || character.Map != client.MapInfo.Number ? 0 : ((character as Npc).Type != Npc.NpcType.Item ? 1 : 0);
                break;
              default:
                num = 1;
                break;
            }
            if (num != 0 && client.MapInfo.Tiles[character.Location.X, character.Location.Y] != null)
            {
              client.MapInfo.Tiles[character.Location.X, character.Location.Y].HasBlock = true;
              client.MapInfo.Tiles[character.Location.X, character.Location.Y].HasEntity = true;
            }
          }
        }
      }
    }

    public Point[] FindPath(int startX, int startY, int endX, int endY, bool ignoreentities)
    {
      List<Point> pointList1 = new List<Point>();
      List<Point> pointList2 = new List<Point>();
      List<Point> pointList3 = new List<Point>();
      List<Point> pointList4 = new List<Point>();
      bool[,] flagArray = new bool[this.Width, this.Height];
      bool flag = false;
      try
      {
        if ((startX + 1) * (startY + 1) > this.Tiles.Length)
          return new Point[0];
        if ((endX + 1) * (endY + 1) > this.Tiles.Length)
          return new Point[0];
        Point[,] tiles = this.Tiles;
        int upperBound1 = tiles.GetUpperBound(0);
        int upperBound2 = tiles.GetUpperBound(1);
        for (int lowerBound1 = tiles.GetLowerBound(0); lowerBound1 <= upperBound1; ++lowerBound1)
        {
          for (int lowerBound2 = tiles.GetLowerBound(1); lowerBound2 <= upperBound2; ++lowerBound2)
          {
            Point point = tiles[lowerBound1, lowerBound2];
            if (point != null)
              point.StepCount = -1;
          }
        }
        if (this.Tiles[startX, startY] != null)
        {
          this.Tiles[startX, startY].StepCount = 0;
          pointList2.Add(this.Tiles[startX, startY]);
        }
        while (!flag)
        {
          List<Point> pointList5 = new List<Point>();
          foreach (Point pt in pointList2)
          {
            if (pt != null)
            {
              foreach (Point surroundingPoint in this.SurroundingPoints(pt))
              {
                if (surroundingPoint != null)
                {
                  if (!flagArray[surroundingPoint.X, surroundingPoint.Y])
                  {
                    if (!ignoreentities)
                    {
                      if (surroundingPoint.Passable || surroundingPoint.X == endX && surroundingPoint.Y == endY)
                      {
                        pointList5.Add(surroundingPoint);
                        flagArray[surroundingPoint.X, surroundingPoint.Y] = true;
                        surroundingPoint.StepCount = pt.StepCount + 1;
                        if (surroundingPoint.X == endX && surroundingPoint.Y == endY)
                          flag = true;
                      }
                    }
                    else if (!surroundingPoint.IsWall || surroundingPoint.X == endX && surroundingPoint.Y == endY)
                    {
                      pointList5.Add(surroundingPoint);
                      flagArray[surroundingPoint.X, surroundingPoint.Y] = true;
                      surroundingPoint.StepCount = pt.StepCount + 1;
                      if (surroundingPoint.X == endX && surroundingPoint.Y == endY)
                        flag = true;
                    }
                  }
                  pointList1.Add(pt);
                  flagArray[pt.X, pt.Y] = true;
                }
              }
            }
          }
          pointList2 = pointList5;
          if (pointList2.Count < 1)
            return new Point[0];
        }
        Point pt1 = this.Tiles[endX, endY];
        pointList3.Add(this.Tiles[endX, endY]);
        while (pt1.StepCount > 1)
        {
          foreach (Point surroundingPoint in this.SurroundingPoints(pt1))
          {
            if (surroundingPoint != null)
            {
              flagArray[surroundingPoint.X, surroundingPoint.Y] = false;
              if (surroundingPoint.StepCount == pt1.StepCount - 1)
              {
                pointList3.Add(surroundingPoint);
                pt1 = surroundingPoint;
                break;
              }
            }
          }
        }
        pointList3.Reverse();
      }
      catch
      {
        return new Point[0];
      }
      return pointList3.ToArray();
    }

    public Point this[int x, int y] => (x + 1) * (y + 1) > this.Tiles.Length ? new Point(-1, -1) : this.Tiles[x, y];
  }
}
