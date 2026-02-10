using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Flintstones
{
  internal class SpeakCommands
  {
    private Dictionary<string, Action<Client>> Commands { get; }


    public SpeakCommands()
    {
      Commands = new Dictionary<string, Action<Client>>(StringComparer.OrdinalIgnoreCase);

      // Register aliases for a command
      Register(Frosty, "/frosty");
      Register(ToCWarrior, "/warrior");
      Register(ToCMonk, "/monk");
      Register(ToCRogue, "/rogue");
      Register(ToCPriest, "/priest");
      Register(ToCWizard, "/wizard");
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

    public void Frosty(Client client)
    {
      client.frostygift = true;
      client.Tab.autowalker_locales.SelectedItem = (object)"Loures";
      client.Tab.walklocaleslist.SelectedItem = (object)"Frosty (x-mas)";
      client.Tab.autowalker_button.Text = "Stop";
      client.autowalkon = true;
      if (!client.BotThread.IsAlive)
        client.BotThread.Start();
      client.pause = false;
      client.Tab.btnPlay.Enabled = false;
      client.Tab.btnStop.Enabled = true;
      client.Tab.mediumwalk.Checked = true;
    }

    public void ToCWarrior(Client client)
    {
      client.warrior = true;
      client.Tab.autowalker_locales.SelectedItem = (object)"Mileth";
      client.Tab.walklocaleslist.SelectedItem = (object)"ToC Warrior";
      client.Tab.autowalker_button.Text = "Stop";
      client.autowalkon = true;
      if (!client.BotThread.IsAlive)
        client.BotThread.Start();
      client.pause = false;
      client.Tab.btnPlay.Enabled = false;
      client.Tab.btnStop.Enabled = true;
      client.Tab.fastwalk.Checked = true;
    }

    public void ToCMonk(Client client)
    {
      client.monk = true;
      client.Tab.autowalker_locales.SelectedItem = (object)"Mileth";
      client.Tab.walklocaleslist.SelectedItem = (object)"ToC Monk";
      client.Tab.autowalker_button.Text = "Stop";
      client.autowalkon = true;
      if (!client.BotThread.IsAlive)
        client.BotThread.Start();
      client.pause = false;
      client.Tab.btnPlay.Enabled = false;
      client.Tab.btnStop.Enabled = true;
      client.Tab.fastwalk.Checked = true;
    }
    public void ToCRogue(Client client)
    {
      client.rogue = true;
      client.Tab.autowalker_locales.SelectedItem = (object)"Mileth";
      client.Tab.walklocaleslist.SelectedItem = (object)"ToC Rogue";
      client.Tab.autowalker_button.Text = "Stop";
      client.autowalkon = true;
      if (!client.BotThread.IsAlive)
        client.BotThread.Start();
      client.pause = false;
      client.Tab.btnPlay.Enabled = false;
      client.Tab.btnStop.Enabled = true;
      client.Tab.fastwalk.Checked = true;
    }
    public void ToCPriest(Client client)
    {
      client.priest = true;
      client.Tab.autowalker_locales.SelectedItem = (object)"Mileth";
      client.Tab.walklocaleslist.SelectedItem = (object)"ToC Priest";
      client.Tab.autowalker_button.Text = "Stop";
      client.autowalkon = true;
      if (!client.BotThread.IsAlive)
        client.BotThread.Start();
      client.pause = false;
      client.Tab.btnPlay.Enabled = false;
      client.Tab.btnStop.Enabled = true;
      client.Tab.fastwalk.Checked = true;
    }
    public void ToCWizard(Client client)
    {
      client.wizard = true;
      client.Tab.autowalker_locales.SelectedItem = (object)"Mileth";
      client.Tab.walklocaleslist.SelectedItem = (object)"ToC Wizard";
      client.Tab.autowalker_button.Text = "Stop";
      client.autowalkon = true;
      if (!client.BotThread.IsAlive)
        client.BotThread.Start();
      client.pause = false;
      client.Tab.btnPlay.Enabled = false;
      client.Tab.btnStop.Enabled = true;
      client.Tab.fastwalk.Checked = true;
    }
  }
}
