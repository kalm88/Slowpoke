using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Flintstones
{
  public class MonsterKills
  {
    public Dictionary<int, Monster> Monsters { get; set; }
    public Dictionary<string, List<int>> KillAreas { get; set; }
    public Dictionary<int, List<int>> CountResetAreas { get; set; }

    public MonsterKills()
    {
      Monsters = LoadMonsters();
      KillAreas = LoadKillAreas();
      CountResetAreas = LoadResetAreas();
      Console.WriteLine($"Loaded {Monsters.Count} monsters for kill counting.");
    }


    /// <summary>
    /// Loads all monsters and their associated information for counting from the quest counts XML file.
    /// </summary>
    /// <remarks>The method reads from the 'questcounts.xml' file located in the application's Settings
    /// directory. If the file is missing or malformed, an exception may be thrown. Each monster is keyed by its unique
    /// ID.</remarks>
    /// <returns>A dictionary mapping monster IDs to their corresponding <see cref="Monster"/> objects. The dictionary will be
    /// empty if no monsters are defined in the file.</returns>
    private Dictionary<int, Monster> LoadMonsters()
    {
      string filePath = Program.StartupPath + "\\Settings\\questcounts.xml";
      var doc = XDocument.Load(filePath);

      Dictionary<int, Monster> monsters = new Dictionary<int, Monster>();

      foreach (var m in doc.Root.Elements("Monster"))
      {
        var monster = new Monster
        {
          Id = (int)m.Attribute("id"),
          Name = (string)m.Element("Name"),
          DisplayName = (string)m.Element("DisplayName"),
          CountTo = (int)m.Element("CountTo"),
          CombineWith = (int?)m.Element("CombineWith"),
          CounterResetLocation = m.Element("CounterResetLocation")?
                .Elements("MapID")
                .Select(x => (int)x)
                .ToList() ?? new List<int>(),
          CountAtMaps = m.Element("CountAtMaps")?
                .Elements("MapName")
                .Select(x => (string)x)
                .ToList() ?? new List<string>()
        };
        monsters[monster.Id] = monster;
      }

      return monsters;
    }


    /// <summary>
    /// Builds a mapping of area names to lists monster IDs that appear in those areas. This list is used to track where counters of monsters 
    /// will be displayed.
    /// </summary>
    /// <returns>A dictionary where each key is an area name and the corresponding value is a list of monster IDs present in that
    /// area. If no monsters are present in an area, the area will not be included in the dictionary.</returns>
    private Dictionary<string, List<int>> LoadKillAreas()
    {
      Dictionary<string, List<int>> areas = new Dictionary<string, List<int>>();
      foreach (KeyValuePair<int, Monster> entry in Monsters)
      {
        int id = entry.Key;
        Monster monster = entry.Value;

        foreach (string area in monster.CountAtMaps)
        {
          if (areas.ContainsKey(area))
          {
            areas[area].Add(id);
          }
          else
          {
            areas[area] = new List<int> { id };
          }
        }
      }
      return areas;
    }

    /// <summary>
    /// Builds a mapping of reset area identifiers to lists of monster IDs that reset in each area. If player enters the area, the
    /// the counters of the monsters listed in this area will be reset.
    /// </summary>
    /// <returns>A dictionary where each key is a reset area identifier and the corresponding value is a list of monster IDs that
    /// reset in that area. If no monsters are present, the dictionary will be empty.</returns>
    private Dictionary<int, List<int>> LoadResetAreas()
    {
      Dictionary<int, List<int>> areas = new Dictionary<int, List<int>>();
      foreach (KeyValuePair<int, Monster> entry in Monsters)
      {
        int id = entry.Key;
        Monster monster = entry.Value;

        foreach (int resetLocation in monster.CounterResetLocation)
        {
          if (areas.ContainsKey(resetLocation))
          {
            areas[resetLocation].Add(id);
          }
          else
          {
            areas[resetLocation] = new List<int> { id };
          }
        }
      }
      return areas;
    }

    /// <summary>
    /// Resets the kill counts of all monsters if current area is an area to reset the monster count.
    /// </summary>
    /// <remarks>If the specified area does not exist or has no associated monsters, this method performs no
    /// action.</remarks>
    /// <param name="areaId">The identifier of the area where associated monsters' kill counts will be reset.</param>
    public void Reset(int areaId)
    {
      if (CountResetAreas.ContainsKey(areaId))
      {
        foreach (int monsterId in CountResetAreas[areaId])
        {
          if (Monsters.ContainsKey(monsterId))
          {
            Monsters[monsterId].KillCount = 0;
          }
        }
      }
    }

    /// <summary>
    /// Increments the kill count for the specified monster untill it reaches its max count.
    /// </summary>
    /// <remarks>It can also combine a kill count with another monsterID</remarks>
    /// <param name="monsterId">The unique identifier of the monster whose kill count is to be incremented.</param>
    /// <returns>true if the the monster exists in the list; otherwise, false.</returns>
    public bool Count(int monsterId)
    {
      int kills = 0;

      if (Monsters.ContainsKey(monsterId))
      {
        Monster monster = Monsters[monsterId];
        if (monster.CombineWith != null)
        {
          kills = monster.KillCount + Monsters[(int)monster.CombineWith].KillCount;
        }
        else
        {
          kills = monster.KillCount;
        }
        if (kills < monster.CountTo)
        {
          monster.KillCount++;
        }
        return true;
      }
      return false;
    }

    /// <summary>
    /// Returns string with kill information for all monsters in the  area.
    /// </summary>
    /// <remarks>It can also combine a kill count with another monsterID</remarks>
    /// <param name="areaName">The name of the area for which to display monster kill information. Must not be null or empty.</param>
    /// <returns>A string containing the display names and kill counts of monsters in the specified area. Returns an empty string
    /// if the area does not exist or contains no monsters.</returns>
    public string Display(string areaName)
    {
      string killInfo = "";
      Console.WriteLine($"Displaying kill counts for area: {areaName}");
      // Find the first matching area that starts with the provided area name
      var matchingArea = KillAreas.Keys
        .FirstOrDefault(k => areaName.StartsWith(k));

      if (matchingArea != null)
      {
        killInfo += "{=b"; // make text red
        int combinedID = 0;
        int kills = 0;
        foreach (int monsterId in KillAreas[matchingArea])
        {
          if (Monsters.ContainsKey(monsterId))
          {
            Monster monster = Monsters[monsterId];

            // Make sure that a combined kill count is only displayed once with both values added up
            if (combinedID == 0 && (monster.CombineWith != null && monster.CombineWith != 0))
            {
              kills = monster.KillCount + Monsters[(int)monster.CombineWith].KillCount;
              combinedID = (int)monster.CombineWith;
            }
            
            if (monster.CombineWith == null)
            {
              kills = monster.KillCount;
            }

            if (kills > 0)
            {
              killInfo += $"{monster.DisplayName}:{kills:D2} ";
            }
            Console.WriteLine($"{monster.Name}: {kills}/{monster.CountTo}");
          }
        }
      }
      return killInfo;
    }
  }
}
