using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flintstones
{
  internal class SpeakCommands
  {
    private Dictionary<string, Action<Client>> Commands { get; }

    /// <summary>
    /// List of spells used to attack boss (Count/Countess)
    /// </summary>
    private List<string> AttackBossSpells = new List<string>
    {
      "ard pian na dion",
      "mor pian na dion",
      "Shock Arrow",
      "Frost Arrow",
      "Frost + 3 Shocks",
      "Cursed Tune",
    };

    private Dictionary<string, string> ItemAbbreviations = new Dictionary<string, string>
    {
      { "suc",  "succubus's hair" },
      { "war", "warranty bag" },
      { "xmas d", "xmas double exp-ap(x5)" },
      { "double", "double bonus exp-ap(x5)" },
      { "christmas", "christmas double exp-ap(x5)" },
      { "vday", "vday bonus exp-ap(x5)" },
      { "gsf", "golden starfish" },
      { "bog", "band of gales" },
      { "bos", "band of storms" },
      { "divinities", "divinities staff" },
      { "eagles", "eagles grasp" },
      { "hell", "hellreavers blade" },
      { "inferno", "inferno blade" },
      { "satchel", "satchel of goods" },
      { "skylight", "skylight staff" },
      { "thunder", "thunderfury" },
    };

    public SpeakCommands()
    {
      Commands = new Dictionary<string, Action<Client>>(StringComparer.OrdinalIgnoreCase);

      // Register aliases for a command
      Register(Stop, "/s");
      Register(StopAll, "/s all");
      Register(Play, "/p");
      Register(PlayAll, "/p all");
      Register(StopWalking, "/stop");
      Register(StopWalkingAll, "/stop all");
      //Register(StartWalking, "/start");
      //Register(StartWalkingAll, "/start all");
      Register(ToCWarrior, "/warrior");
      Register(ToCMonk, "/monk");
      Register(ToCRogue, "/rogue");
      Register(ToCPriest, "/priest");
      Register(ToCWizard, "/wizard");
      Register(AscendHP, "/ascendhp", "/hp", "/ascend hp");
      Register(AscendMP, "/ascendmp", "/mp", "/ascend mp");
      Register(Dojo, "/dojo");
      Register(TeachDugon, "/teach");
      Register(DoneDugon, "/done");
      Register(RemoveMonsters, "/ram");

      // Quest commands
      Register(DarkMaze, "/darkmaze");
      Register(DragonScaleSword, "/tent", "/tentacle", "/dss");
      Register(GiantPearl, "/pearl");
      Register(HalfTalisman, "/tali", "/halftalisman");
      Register(Law, "/law");
      Register(LawAll, "/law all");
      Register(MothersLove, "/molo", "/motherslove");
      Register(StoneSlabs, "/slab", "/stoneslab");
      Register(TheLetter, "/thel", "/theletter");

      // Seasonal event commands
      Register(SunProtection, "/hat", "/sunprotection");
      Register(BeachAttire, "/attire");
      Register(MakeAWish, "/wish");
      Register(AttackCount, "/attack count");
      Register(AttackCountess, "/attack countess");
      Register(YuleLogs, "/yule");
      Register(Frosty, "/frosty");
      Register(FilthyErbies, "/meg", "/filthyerbies");

    }


    /// <summary>
    /// Registers aliases for a command script.
    /// </summary>
    /// <remarks>If multiple aliases are provided, each will be mapped to the same handler. Existing handlers
    /// for the specified aliases will be overwritten.</remarks>
    /// <param name="action">The delegate to execute when a command matching one of the provided aliases is invoked. Cannot be null.</param>
    /// <param name="aliases">An array of command aliases that will be associated with the handler. Each alias must be a non-empty string.</param>
    private void Register(Action<Client> action, params string[] aliases)
    {
      foreach (var alias in aliases)
      {
        Commands[alias] = action;
      }
    }

    /// <summary>
    /// Attempts to execute the command.
    /// </summary>
    /// <remarks>If the command does not exist in the command registry, no action is performed and the method
    /// returns false. This method does not throw an exception if the command is not found.</remarks>
    /// <param name="command">The speak command to execute. Cannot be null or empty.</param>
    /// <param name="client">The client class reference. Cannot be null.</param>
    /// <returns>true if the command was found and executed; otherwise, false.</returns>
    public bool TryExecuteCommand(string command, Client client)
    {
      if (Commands.TryGetValue(command, out Action<Client> action))
      {
        action(client);
        return true;
      }
      return false;
    }

    /// <summary>
    /// Initializes walking mode, enabling autowalk and updating the user interface.
    /// </summary>
    /// <remarks>This method enables autowalk, updates UI controls, and ensures the bot thread is
    /// running. Call this method to start walking mode.</remarks>
    /// <param name="client">The client instance for which walking mode is to be initialized. Cannot be null.</param>
    private void InitWalking(Client client)
    {
      client.Tab.autowalker_button.Text = "Stop";
      client.autowalkon = true;
      if (!client.BotThread.IsAlive)
        client.BotThread.Start();
      client.pause = false;
      client.Tab.btnPlay.Enabled = false;
      client.Tab.btnStop.Enabled = true;
      client.Tab.fastwalk.Checked = true;
    }

    /// <summary>
    /// Stops the client.
    /// </summary>
    /// <param name="client">The client instance to stop. Cannot be null.</param>
    public void Stop(Client client)
    {
      if (!client.BotThread.IsAlive)
        client.BotThread.Start();
      client.pause = true;
      client.Tab.btnPlay.Enabled = true;
      client.Tab.btnStop.Enabled = false;
      client.SendMessage($"{client.Name} is Stopped.", "grey");
    }

    /// <summary>
    /// Stops all client.
    /// </summary>
    /// <param name="client"></param>
    public void StopAll(Client client)
    {
      Client[] runningClients = Server.Alts.Values.ToArray<Client>();
      for (int clientNr = 0; clientNr < runningClients.Length; ++clientNr)
      {
        Stop(runningClients[clientNr]);
      }
      client.SendMessage("All clients are Playing.", "grey");
    }

    /// <summary>
    /// Starts the client.
    /// </summary>
    /// <param name="client">The client instance whose bot will be started. Cannot be null.</param>
    public void Play(Client client)
    {
      if (!client.BotThread.IsAlive)
        client.BotThread.Start();
      client.pause = false;
      client.Tab.btnPlay.Enabled = false;
      client.Tab.btnStop.Enabled = true;
      client.lastaction = DateTime.UtcNow;
      client.laststep = DateTime.UtcNow;
      client.SendMessage($"{client.Name} is Playing.", "grey");
    }

    /// <summary>
    /// Starts all clients.
    /// </summary>
    /// <param name="client"></param>
    public void PlayAll(Client client)
    {
      Client[] runningClients = Server.Alts.Values.ToArray<Client>();
      for (int clientNr = 0; clientNr < runningClients.Length; ++clientNr)
      {
        Play(runningClients[clientNr]);
      }
      client.SendMessage("All clients are Playing.", "grey");
    }

    /// <summary>
    /// Stops the client's automatic walking .
    /// </summary>
    /// <param name="client">The client instance for which to stop automatic walking. Cannot be null.</param>
    public void StopWalking(Client client)
    {
      client.Tab.followplayer.Checked = false;
      client.Tab.autowalker_button.Text = "Start";
      client.autowalkon = false;
      client.Tab.wayregionson.Checked = false;
      client.Tab.actonlyinmobs.Checked = false;
      client.SendMessage("You stopped walking.", "grey");
    }

    /// <summary>
    /// Stops all connected clients from walking.
    /// </summary>
    /// <param name="client">The client to receive the notification message after all clients have been stopped.</param>
    public void StopWalkingAll(Client client)
    {
      Client[] runningClients = Server.Alts.Values.ToArray<Client>();
      for (int clientNr = 0; clientNr < runningClients.Length; ++clientNr)
      {
        StopWalking(runningClients[clientNr]);
      }
      client.SendMessage("All clients stopped walking.", "grey");

    }

    /// <summary>
    /// Walk to ToC Warrior and become warrior.
    /// </summary>
    /// <param name="client"></param>
    public void ToCWarrior(Client client)
    {
      client.warrior = true;
      client.Tab.autowalker_locales.SelectedItem = "Mileth";
      client.Tab.walklocaleslist.SelectedItem = "ToC Warrior";
      InitWalking(client);
    }

    /// <summary>
    /// Walk to ToC Monk and become monk.
    /// </summary>
    /// <param name="client"></param>

    public void ToCMonk(Client client)
    {
      client.monk = true;
      client.Tab.autowalker_locales.SelectedItem = "Mileth";
      client.Tab.walklocaleslist.SelectedItem = "ToC Monk";
      InitWalking(client);
    }

    /// <summary>
    /// Walk to ToC Rogue and become rogue.
    /// </summary>
    /// <param name="client"></param>
    public void ToCRogue(Client client)
    {
      client.rogue = true;
      client.Tab.autowalker_locales.SelectedItem = "Mileth";
      client.Tab.walklocaleslist.SelectedItem = "ToC Rogue";
      InitWalking(client);
    }

    /// <summary>
    /// Walk to ToC Priest and become priest.
    /// </summary>
    /// <param name="client"></param>
    public void ToCPriest(Client client)
    {
      client.priest = true;
      client.Tab.autowalker_locales.SelectedItem = "Mileth";
      client.Tab.walklocaleslist.SelectedItem = "ToC Priest";
      InitWalking(client);
    }

    /// <summary>
    /// Walk to ToC Wizard and become wizard.
    /// </summary>
    /// <param name="client"></param>
    public void ToCWizard(Client client)
    {
      client.wizard = true;
      client.Tab.autowalker_locales.SelectedItem = "Mileth";
      client.Tab.walklocaleslist.SelectedItem = "ToC Wizard";
      InitWalking(client);
    }

    /// <summary>
    /// Ascend and put all XP into HP.
    /// </summary>
    /// <param name="client"></param>
    public void AscendHP(Client client)
    {
      client.Tab.AscendOptions.instantascend.Checked = true;
      client.Tab.AscendOptions.ascendhp.Checked = true;
      client.Tab.AscendOptions.ascendbutton.Text = "Stop";
    }

    /// <summary>
    /// Ascend and put all XP into MP.
    /// </summary>
    /// <param name="client"></param>
    public void AscendMP(Client client)
    {
      client.Tab.AscendOptions.instantascend.Checked = true;
      client.Tab.AscendOptions.ascendmp.Checked = true;
      client.Tab.AscendOptions.ascendbutton.Text = "Stop";
    }

    /// <summary>
    /// Activates the dojo tab client.
    /// </summary>
    /// <param name="client">The client for which to activate the dojo tab. Cannot be null.</param>
    public void Dojo(Client client)
    {
      if (client.Tab.dojo.Checked)
        client.Tab.dojo.Checked = false;
      client.Tab.dojo.Checked = true;
    }

    /// <summary>
    /// Initieates teaching the dugon at Sapphire Stream and walking to right stone
    /// </summary>
    /// <remarks>The correct dugon is known.</remarks>
    /// <param name="client"></param>
    public void TeachDugon(Client client)
    {
      client.RequestGroupList();
      client.SendMessage("wait a sec...");
      Thread.Sleep(1000);
      client.Speak("sabonim, please teach me the " + client.currentdugon + " dugon");
    }

    /// <summary>
    /// Complete teaching the dugon at Sapphire Stream.
    /// </summary>
    /// <remarks>The correct dugon is known.</remarks>
    /// <param name="client"></param>
    public void DoneDugon(Client client)
    {
      client.Speak("sabonim, i understand the " + client.currentdugon + " dugon");
    }

    /// <summary>
    /// Remove all monsters from spell configuration of all clients.
    /// </summary>
    /// <param name="client"></param>
    public void RemoveMonsters(Client client)
    {
      Client[] runningClients = Server.Alts.Values.ToArray<Client>();
      for (int clientNr = 0; clientNr < runningClients.Length; ++clientNr)
      {
        Client companionClient = runningClients[clientNr];
        if (companionClient.Tab.allMonsters != null)
        {
          --companionClient.Tab.spellMonsters.SelectedIndex;
          companionClient.Tab.spellMonsters.TabPages.Remove((TabPage)client.Tab.allMonsters);
          companionClient.Tab.allMonsters = (targetAllMonster)null;
          companionClient.Tab.newmonster.Enabled = true;
          companionClient.Tab.newallmonsters.Enabled = true;
          companionClient.Tab.newmonsterbyplayer.Enabled = true;
          companionClient.Tab.createnewmonster.Enabled = true;
        }
      }
      client.SendMessage("Removed All Monsters Tabs from all clients", "grey");
    }

    /// <summary>
    /// Initiates the Dark Maze quest, if the required beothaich deum is in the inventory.
    /// </summary>
    /// <param name="client">The client instance for which to initiate the Dark Maze entry. Cannot be null.</param>
    public void DarkMaze(Client client)
    {
      if (!client.HasItem("beothaich deum") && !client.HasItem("Red Potion"))
      {
        client.SendMessage("Get some beothaich deum");
      }
      else
      {
        client.darkmaze = true;
        client.Tab.autowalker_locales.SelectedItem = "Loures";
        client.Tab.walklocaleslist.SelectedItem = "Dungeon (aite)";
        InitWalking(client);
      }
    }

    /// <summary>
    /// Initiates the Lost Ruins Law quest.
    /// </summary>
    /// <remarks>Client must each have 5 giant remains.</remarks>
    /// <param name="client"></param>
    public void Law(Client client)
    {
      client.Tab.LoadTemplate("default");
      client.lawquest = true;
      client.Tab.fastwalk.Checked = true;
      client.Tab.autowalker_locales.Text = "Lost Ruins";
      client.Tab.walklocaleslist.SelectedItem = "Nairn";
      InitWalking(client);

      client.LastnpcpopupID = 0U;
    }

    /// <summary>
    /// Initiates the Lost Ruins Law quest for all clients.
    /// </summary>
    /// <remarks>Clients must each have 5 giant remains.</remarks>
    /// <param name="client"></param>
    public void LawAll(Client client)
    {
      Client[] runningClients = Server.Alts.Values.ToArray<Client>();
      for (int clientNr = 0; clientNr < runningClients.Length; ++clientNr)
      {
        Client companionClient = runningClients[clientNr];
        if (companionClient != null && companionClient.Name != string.Empty && companionClient.MapInfo.Number == 8995)
        {
          companionClient.Tab.LoadTemplate("default");
          companionClient.lawquest = true;
          companionClient.Tab.fastwalk.Checked = true;
          companionClient.Tab.autowalker_locales.Text = "Lost Ruins";
          companionClient.Tab.walklocaleslist.SelectedItem = "Nairn";
          InitWalking(companionClient);

          client.LastnpcpopupID = 0U;
        }
      }
    }

    /// <summary>
    /// Initiates the Mother's Love quest.
    /// </summary>
    /// <param name="client"></param>
    public void MothersLove(Client client)
    {
      client.molo = true;
      client.Tab.autowalker_locales.SelectedItem = "Nearest Restaurant";
      InitWalking(client);

    }

    /// <summary>
    /// Initiates the Hwarone/Lost Ruins stone slab quest.
    /// </summary>
    /// <param name="client">The client instance for which to start the stone slab quest. Cannot be null.</param>
    public void StoneSlabs(Client client)
    {
      client.slabquest = true;
      client.Tab.autowalker_locales.SelectedItem = "Hwarone";
      client.Tab.walklocaleslist.SelectedItem = "Inn";
      InitWalking(client);
    }


    /// <summary>
    /// Initiates the letter quest, if client is grouped with another player.
    /// </summary>
    /// <param name="client"></param>
    public void TheLetter(Client client)
    {
      if (client.GroupMembers.Count<string>() == 1)
      {
        Client[] runningClients = Server.Alts.Values.ToArray<Client>();
        for (int clientNr = 0; clientNr < runningClients.Length; ++clientNr)
        {
          Client companionClient = runningClients[clientNr];
          if (companionClient.Name.ToLower() == client.GroupMembers[0].ToLower())
          {
            companionClient.letterquest = 1;
            companionClient.theletter = true;
            if (client.MapInfo.Number != 168 && client.MapInfo.Number != 393 && client.MapInfo.Number != 134 && client.MapInfo.Number != 136 && client.MapInfo.Number != 115 && client.MapInfo.Number != 118 && client.MapInfo.Number != 122 && client.MapInfo.Number != 303 && client.MapInfo.Number != 3041)
            {
              companionClient.Tab.autowalker_locales.SelectedItem = "Mileth";
              companionClient.Tab.walklocaleslist.SelectedItem = "Restaurant";
              InitWalking(companionClient);
            }
          }
        }
      }

      client.letterquest = 1;
      client.theletter = true;
      if (client.MapInfo.Number != 168 && client.MapInfo.Number != 393 && client.MapInfo.Number != 134 && client.MapInfo.Number != 136 && client.MapInfo.Number != 115 && client.MapInfo.Number != 118 && client.MapInfo.Number != 122 && client.MapInfo.Number != 303 && client.MapInfo.Number != 3041)
      {
        client.Tab.autowalker_locales.SelectedItem = "Mileth";
        client.Tab.walklocaleslist.SelectedItem = "Restaurant";
        InitWalking(client);
      }
    }

    /// <summary>
    /// Initiates the Dragon Scale Sword quest.
    /// </summary>
    /// <remarks>Needs to have a tentacle.</remarks>
    /// <param name="client"></param>
    public void DragonScaleSword(Client client)
    {
      client.Tab.autowalker_locales.SelectedItem = "Mileth";
      client.Tab.walklocaleslist.SelectedItem = "Tavern";
      InitWalking(client);
    }

    /// <summary>
    /// Initiates getting the giant pearl for the Medusa creant quest.
    /// </summary>
    /// <param name="client"></param>
    public void GiantPearl(Client client)
    {
      client.giantpearl = true;
      client.Tab.looton.Checked = true;
      client.Tab.autowalker_locales.SelectedItem = "Lynith";
      client.Tab.walklocaleslist.SelectedItem = "Giant Pearl";
      InitWalking(client);

    }

    /// <summary>
    /// Initiates buying the 2nd half talisman for the Medusa creant quest.
    /// </summary>
    /// <param name="client"></param>
    public void HalfTalisman(Client client)
    {
      client.buy2ndtalisman = true;
      if (!client.BotThread.IsAlive)
        client.BotThread.Start();
      client.pause = false;
      client.Tab.btnPlay.Enabled = false;
      client.Tab.btnStop.Enabled = true;
    }

    /// <summary>
    /// Get sunprotection in August event.
    /// </summary>
    /// <param name="client"></param>
    public void SunProtection(Client client)
    {
      client.claimsunprotection = true;
      client.Tab.autowalker_locales.SelectedItem = "Loures";
      client.Tab.walklocaleslist.SelectedItem = "Francis (summer)";
      InitWalking(client);
    }

    /// <summary>
    /// Get paradise outfit in August event.
    /// </summary>
    /// <param name="client"></param>
    public void BeachAttire(Client client)
    {
      client.claimbeachattire = true;
      if (client.HasSkill("swimming"))
      {
        client.Tab.autowalker_locales.SelectedItem = "Lynith";
        client.Tab.walklocaleslist.SelectedItem = "Paradise";
      }
      else
      {
        client.learnswim = true;
        client.SendMessage("Learning to swim at mileth inn first");
        client.Tab.autowalker_locales.SelectedItem = "Mileth";
        client.Tab.walklocaleslist.SelectedItem = "Inn";
      }
      InitWalking(client);
    }

    /// <summary>
    /// Make a wish in February event.
    /// </summary>
    /// <param name="client"></param>
    public void MakeAWish(Client client)
    {
      client.makeawish = true;
      client.Tab.autowalker_locales.SelectedItem = "Mileth";
      client.Tab.walklocaleslist.SelectedItem = "Church";
      InitWalking(client);
    }


    public void AttackCount(Client client)
    {
      if (Program.MainForm.attackcount)
      {
        Client[] runningClients = Server.Alts.Values.ToArray<Client>();
        for (int clientNr = 0; clientNr < runningClients.Length; ++clientNr)
        {
          Client companion = runningClients[clientNr];
          if (companion.Tab.Monsters != null)
          {
            foreach (targetMonster targetMonster in companion.targetmonster)
            {
              if (targetMonster != null && targetMonster.Text.Equals("814"))
              {
                if (AttackBossSpells.Contains(targetMonster.attack1type.Text))
                  targetMonster.attack1.Checked = false;
                if (AttackBossSpells.Contains(targetMonster.attack2type.Text))
                  targetMonster.attack2.Checked = false;
              }
            }
          }
        }
        Program.MainForm.attackcount = false;
        client.SendMessage("No longer attacking Count.", "pink");
      }
      else
      {
        Client[] runningClients = Server.Alts.Values.ToArray<Client>();
        for (int clientNr = 0; clientNr < runningClients.Length; ++clientNr)
        {
          Client companion = runningClients[clientNr];
          if (companion.Tab.Monsters != null)
          {
            foreach (targetMonster targetMonster in companion.targetmonster)
            {
              if (targetMonster != null && targetMonster.Text.Equals("814"))
              {
                if (AttackBossSpells.Contains(targetMonster.attack1type.Text))
                  targetMonster.attack1.Checked = true;
                if (AttackBossSpells.Contains(targetMonster.attack2type.Text))
                  targetMonster.attack2.Checked = true;
              }
            }
          }
        }
        Program.MainForm.attackcount = true;
        client.SendMessage("Now set to attack Count.", "pink");
      }
    }

    public void AttackCountess(Client client)
    {
      if (Program.MainForm.attackcountess)
      {
        Client[] runningClients = Server.Alts.Values.ToArray<Client>();
        for (int clientNr = 0; clientNr < runningClients.Length; ++clientNr)
        {
          Client companion = runningClients[clientNr];
          if (companion.Tab.Monsters != null)
          {
            foreach (targetMonster targetMonster in companion.targetmonster)
            {
              if (targetMonster != null && targetMonster.Text.Equals("815"))
              {
                if (AttackBossSpells.Contains(targetMonster.attack1type.Text))
                  targetMonster.attack1.Checked = false;
                if (AttackBossSpells.Contains(targetMonster.attack2type.Text))
                  targetMonster.attack2.Checked = false;
              }
            }
          }
        }
        Program.MainForm.attackcount = false;
        client.SendMessage("No longer attacking Countess.", "pink");
      }
      else
      {
        Client[] runningClients = Server.Alts.Values.ToArray<Client>();
        for (int clientNr = 0; clientNr < runningClients.Length; ++clientNr)
        {
          Client companion = runningClients[clientNr];
          if (companion.Tab.Monsters != null)
          {
            foreach (targetMonster targetMonster in companion.targetmonster)
            {
              if (targetMonster != null && targetMonster.Text.Equals("815"))
              {
                if (AttackBossSpells.Contains(targetMonster.attack1type.Text))
                  targetMonster.attack1.Checked = true;
                if (AttackBossSpells.Contains(targetMonster.attack2type.Text))
                  targetMonster.attack2.Checked = true;
              }
            }
          }
        }
        Program.MainForm.attackcount = true;
        client.SendMessage("Now set to attack Countess.", "pink");
      }
    }

    /// <summary>
    /// Yule Logs in November event.
    /// </summary>
    /// <param name="client"></param>
    public void YuleLogs(Client client)
    {
      client.yulequest = true;
      client.Tab.autowalker_locales.SelectedItem = "Suomi";
      client.Tab.walklocaleslist.SelectedItem = "Weapon Shop";
      InitWalking(client);
      client.Tab.mediumwalk.Checked = true;
      client.LastnpcpopupID = 0U;
    }

    /// <summary>
    /// Frosty gift in December event.
    /// </summary>
    /// <param name="client"></param>
    public void Frosty(Client client)
    {
      client.frostygift = true;
      client.Tab.autowalker_locales.SelectedItem = "Loures";
      client.Tab.walklocaleslist.SelectedItem = "Frosty (x-mas)";
      InitWalking(client);
      client.Tab.mediumwalk.Checked = true;
    }

    /// <summary>
    /// Filthy Erbie quest in December event.
    /// </summary>
    /// <remarks>Walks to mother erbie to complete the quest but does not check the killing of 20 filthy erbies</remarks>
    /// <param name="client">The client instance to configure and initiate walking. Cannot be null.</param>
    public void FilthyErbies(Client client)
    {
      client.megprize = true;
      client.Tab.autowalker_locales.SelectedItem = "Mt Merry";
      client.Tab.walklocaleslist.SelectedItem = "Mother Erbie";
      InitWalking(client);
    }
  }
}
