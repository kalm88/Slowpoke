//SlowPoke
// Type: Flintstones.LegendMarks
//SlowPoke
//SlowPoke
//SlowPoke

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Flintstones
{
  public class LegendMarks : Form
  {
    public MainForm parent;
    public Dictionary<string, Flintstones.Marks> Marks = new Dictionary<string, Flintstones.Marks>();
    private IContainer components;
    public ListView listView1;
    public CheckBox events;
    public CheckBox politics;
    public CheckBox pets;
    public CheckBox arena;
    public CheckBox guild;
    private ColumnHeader columnHeader1;
    public CheckBox defunct;
    private CheckBox award;
    public CheckBox jails;
    public CheckBox roleplay;
    public CheckBox regular;
    public CheckBox paths;

    public Client Client { get; private set; }

    public LegendMarks(Client client)
    {
      this.parent = Program.MainForm;
      this.Client = client;
      this.Marks.Add("Sep1", new Flintstones.Marks("-------------------------------General----------------------------------------", "Regular"));
      this.Marks.Add("BbdT1", new Flintstones.Marks("(Town) mundane birth", "Regular"));
      this.Marks.Add("BbdT2", new Flintstones.Marks("(Town) mundane birth", "Regular"));
      this.Marks.Add("BbdT3", new Flintstones.Marks("(Town) mundane birth", "Regular"));
      this.Marks.Add("BbdT4", new Flintstones.Marks("(Town) mundane birth", "Regular"));
      this.Marks.Add("BbdT5", new Flintstones.Marks("(Town) mundane birth", "Regular"));
      this.Marks.Add("BbdT6", new Flintstones.Marks("(Town) mundane birth", "Regular"));
      this.Marks.Add("BadT1", new Flintstones.Marks("(Town) mundane birth", "Regular"));
      this.Marks.Add("BadT2", new Flintstones.Marks("(Town) mundane birth", "Regular"));
      this.Marks.Add("BadT3", new Flintstones.Marks("(Town) mundane birth", "Regular"));
      this.Marks.Add("BadT4", new Flintstones.Marks("(Town) mundane birth", "Regular"));
      this.Marks.Add("BadT5", new Flintstones.Marks("(Town) mundane birth", "Regular"));
      this.Marks.Add("BadT6", new Flintstones.Marks("(Town) mundane birth", "Regular"));
      this.Marks.Add("MilethLove", new Flintstones.Marks("Loved by Mileth Mundanes", "Regular"));
      this.Marks.Add("SuomiLove", new Flintstones.Marks("Loved by Suomi Mundanes", "Regular"));
      this.Marks.Add("Terror", new Flintstones.Marks("Slew Terror of the Alley/Garden/Crypt", "Regular"));
      this.Marks.Add("Urchin1", new Flintstones.Marks("Completed Ciad Quest", "Regular"));
      this.Marks.Add("HrtFir", new Flintstones.Marks("(Small) Heart of Fire/Moon/Stone", "Regular"));
      this.Marks.Add("HrtMon", new Flintstones.Marks("(Small) Heart of Fire/Moon/Stone", "Regular"));
      this.Marks.Add("HrtStn", new Flintstones.Marks("(Small) Heart of Fire/Moon/Stone", "Regular"));
      this.Marks.Add("HrtFir-2", new Flintstones.Marks("(Small) Heart of Fire/Moon/Stone", "Regular"));
      this.Marks.Add("HrtMon-2", new Flintstones.Marks("(Small) Heart of Fire/Moon/Stone", "Regular"));
      this.Marks.Add("HrtStn-2", new Flintstones.Marks("(Small) Heart of Fire/Moon/Stone", "Regular"));
      this.Marks.Add("MnkMtr", new Flintstones.Marks("Guided Monk (name)", "Regular"));
      this.Marks.Add("RogMtr", new Flintstones.Marks("Guided Rogue (name)", "Regular"));
      this.Marks.Add("PriMtr", new Flintstones.Marks("Guided Priest (name)", "Regular"));
      this.Marks.Add("WizMtr", new Flintstones.Marks("Guided Wizard (name)", "Regular"));
      this.Marks.Add("WarMtr", new Flintstones.Marks("Guided Warrior (name)", "Regular"));
      this.Marks.Add("PctSav-2", new Flintstones.Marks("Cured a sick child in Loures", "Regular"));
      this.Marks.Add("PctAna-2", new Flintstones.Marks("Cured a sick child in Loures", "Regular"));
      this.Marks.Add("EmeraldS", new Flintstones.Marks("Recovered the Emerald Knight Insignia", "Regular"));
      this.Marks.Add("EmeraldN", new Flintstones.Marks("Aided the Emerald Knights/Necromancer Order", "Regular"));
      this.Marks.Add("EmeraldK", new Flintstones.Marks("Aided the Emerald Knights/Necromancer Order", "Regular"));
      this.Marks.Add("Mt", new Flintstones.Marks("Mentored by (name)", "Regular"));
      this.Marks.Add("Mtr", new Flintstones.Marks("Mentored (name)", "Regular"));
      this.Marks.Add("KeptSecret", new Flintstones.Marks("Kept Fisk's Secret", "Regular"));
      this.Marks.Add("ToldSecret", new Flintstones.Marks("Kept Fisk's Secret", "Regular"));
      this.Marks.Add("PorteForest", new Flintstones.Marks("Saved daughter of Porte Forest", "Regular"));
      this.Marks.Add("PorteSave", new Flintstones.Marks("Eased the suffering of Porte Forest", "Regular"));
      this.Marks.Add("Urchin2", new Flintstones.Marks("Completed Tiota Quest", "Regular"));
      this.Marks.Add("OrenEnt", new Flintstones.Marks("Explorer of Oren Sewers", "Regular"));
      this.Marks.Add("LQuest35", new Flintstones.Marks("Defeated the Octopus of Karlopos", "Regular"));
      this.Marks.Add("LMorwin1", new Flintstones.Marks("Helped Mephit/Morwin", "Regular"));
      this.Marks.Add("LMephit1", new Flintstones.Marks("Helped Mephit/Morwin", "Regular"));
      this.Marks.Add("Capquest", new Flintstones.Marks("Worthy of the Band/Cap of Danaan", "Regular"));
      this.Marks.Add("Capquest1", new Flintstones.Marks("Worthy of the Band/Cap of Danaan", "Regular"));
      this.Marks.Add("Urchin3", new Flintstones.Marks("Completed Treas Quest", "Regular"));
      this.Marks.Add("LegWoodMon", new Flintstones.Marks("Hunted down a wolf of West Woodland", "Regular"));
      this.Marks.Add("OrenPirate", new Flintstones.Marks("Has Defeated # of Oren's Pirates", "Regular"));
      this.Marks.Add("ReinSgrios", new Flintstones.Marks("Chadul/Danaan Reincarnation", "Regular"));
      this.Marks.Add("ReinDeoch", new Flintstones.Marks("Chadul/Danaan Reincarnation", "Regular"));
      this.Marks.Add("Crc5Tlg", new Flintstones.Marks("Aisling of Talgonite", "Regular"));
      this.Marks.Add("Crc5Mth", new Flintstones.Marks("Aisling of Mythril", "Regular"));
      this.Marks.Add("GChamp", new Flintstones.Marks("Arena Circuit Champion", "Regular"));
      this.Marks.Add("Beal", new Flintstones.Marks("Archaeologist of Beal na Carraige", "Regular"));
      this.Marks.Add("GWar", new Flintstones.Marks("Great Soldier of the Goblin War", "Regular"));
      this.Marks.Add("CPriest", new Flintstones.Marks("(Class) Dedication", "Regular"));
      this.Marks.Add("CThief", new Flintstones.Marks("(Class) Dedication", "Regular"));
      this.Marks.Add("CMonk", new Flintstones.Marks("(Class) Dedication", "Regular"));
      this.Marks.Add("CMage", new Flintstones.Marks("(Class) Dedication", "Regular"));
      this.Marks.Add("CWarror", new Flintstones.Marks("(Class) Dedication", "Regular"));
      this.Marks.Add("Master", new Flintstones.Marks("Master", "Regular"));
      this.Marks.Add("DefeatAncientOne", new Flintstones.Marks("Defeated Arsaidh Aon", "Regular"));
      this.Marks.Add("RevLev", new Flintstones.Marks("(Spirit) Reverence", "Regular"));
      this.Marks.Add("LDioram", new Flintstones.Marks("Found Dioram", "Regular"));
      this.Marks.Add("LLorai", new Flintstones.Marks("Killed Lorais", "Regular"));
      this.Marks.Add("PED", new Flintstones.Marks("Explorer of Andor Dungeon", "Regular"));
      this.Marks.Add("WarKill", new Flintstones.Marks("Hwarone War kills", "Regular"));
      this.Marks.Add("SavedOriana", new Flintstones.Marks("Kept Oriana Safe from Dendron Flower", "Regular"));
      this.Marks.Add("FoundElemus", new Flintstones.Marks("Helped Oriana find Elemus", "Regular"));
      this.Marks.Add("HostOutfit1", new Flintstones.Marks("Obtained Hostile Disguise from Glenna", "Regular"));
      this.Marks.Add("HChiefFriend", new Flintstones.Marks("Befriended the Hostile Chief", "Regular"));
      this.Marks.Add("ReunitedChiefs", new Flintstones.Marks("Reunited Chief Vortigern and Hostile Chief", "Regular"));
      this.Marks.Add("StrngWnds", new Flintstones.Marks("Gathered Materials for Jowella's House", "Regular"));
      this.Marks.Add("AccessSArea", new Flintstones.Marks("Allowed to Enter Secured Caves", "Regular"));
      this.Marks.Add("HelpJowKharl", new Flintstones.Marks("Mended Jowella and Kharlo's Relationship", "Regular"));
      this.Marks.Add("FLuwellaKey", new Flintstones.Marks("Found Luwella's House Key", "Regular"));
      this.Marks.Add("ProtectLuwella", new Flintstones.Marks("Protected Luwella from Baby Brutes", "Regular"));
      this.Marks.Add("SecretWFEnt", new Flintstones.Marks("Learned the Secret Waterfall Entrance", "Regular"));
      this.Marks.Add("GotYowCostume", new Flintstones.Marks("Obtained the Yowien Costume", "Regular"));
      this.Marks.Add("ArcelleSBags", new Flintstones.Marks("Returned Arcella's Stolen Bag", "Regular"));
      this.Marks.Add("ArcelleSBags2", new Flintstones.Marks("Received a Gift from Arcella", "Regular"));
      this.Marks.Add("LuredFS", new Flintstones.Marks("Lured Fire Serpent Out", "Regular"));
      this.Marks.Add("FinishLR", new Flintstones.Marks("Defeated Law & Discovered Lost Ruins", "Regular"));
      this.Marks.Add("MuisirEnt", new Flintstones.Marks("Entered Muisir Village", "Regular"));
      this.Marks.Add("MuisirTDone", new Flintstones.Marks("Completed Muisir Training", "Regular"));
      this.Marks.Add("LegendaryA", new Flintstones.Marks("Legendary Aisling", "Regular"));
      this.Marks.Add("EduCon", new Flintstones.Marks("Educated", "Regular"));
      this.Marks.Add("LoveA", new Flintstones.Marks("Loves (name)", "Regular"));
      this.Marks.Add("WedA", new Flintstones.Marks("Married (name)", "Regular"));
      this.Marks.Add("LoveL", new Flintstones.Marks("Broke up with (name)", "Regular"));
      this.Marks.Add("WedL", new Flintstones.Marks("Divorced (name)", "Regular"));
      this.Marks.Add("D", new Flintstones.Marks("Sgrios's Scar", "Regular"));
      this.Marks.Add("RlgL", new Flintstones.Marks("Has forsaken (god)", "Regular"));
      this.Marks.Add("Rlg1-2", new Flintstones.Marks("(God) Acolyte/Priest/Etc by (self/name)", "Regular"));
      this.Marks.Add("Rlg2-2", new Flintstones.Marks("(God) Acolyte/Priest/Etc by (self/name)", "Regular"));
      this.Marks.Add("Rlg3-2", new Flintstones.Marks("(God) Acolyte/Priest/Etc by (self/name)", "Regular"));
      this.Marks.Add("Rlg4-2", new Flintstones.Marks("(God) Acolyte/Priest/Etc by (self/name)", "Regular"));
      this.Marks.Add("Rlg5-2", new Flintstones.Marks("(God) Acolyte/Priest/Etc by (self/name)", "Regular"));
      this.Marks.Add("Rlg6-2", new Flintstones.Marks("(God) Acolyte/Priest/Etc by (self/name)", "Regular"));
      this.Marks.Add("Rlg7-2", new Flintstones.Marks("(God) Acolyte/Priest/Etc by (self/name)", "Regular"));
      this.Marks.Add("Rlg8-2", new Flintstones.Marks("(God) Acolyte/Priest/Etc by (self/name)", "Regular"));
      this.Marks.Add("RlgQ", new Flintstones.Marks("Completed religious geas for (name)", "Regular"));
      this.Marks.Add("Sep2", new Flintstones.Marks("-------------------------------Priest-----------------------------------------", "Priest"));
      this.Marks.Add("PriMt", new Flintstones.Marks("Priest, guided by (name)", "Priest"));
      this.Marks.Add("PriA", new Flintstones.Marks("Priest by oath of (name)", "Priest"));
      this.Marks.Add("Alt", new Flintstones.Marks("Mileth Altar Worshipper", "Priest"));
      this.Marks.Add("LoveAr", new Flintstones.Marks("Joined (name) to a lover", "Priest"));
      this.Marks.Add("LoveLr", new Flintstones.Marks("Broke up (name)'s love", "Priest"));
      this.Marks.Add("WedLr", new Flintstones.Marks("Performed divorce of (name)", "Priest"));
      this.Marks.Add("Rlg-1r", new Flintstones.Marks("Initiated Worshipper (name)", "Priest"));
      this.Marks.Add("RlgHeld", new Flintstones.Marks("Last Held Mass", "Priest"));
      this.Marks.Add("RlgEr", new Flintstones.Marks("Excommunicated (name)", "Priest"));
      this.Marks.Add("KRarePriest", new Flintstones.Marks("Discovered the Cluais Jewel", "Priest"));
      this.Marks.Add("Sep3", new Flintstones.Marks("-------------------------------Wizard----------------------------------------", "Wizard"));
      this.Marks.Add("WizMt", new Flintstones.Marks("Wizard, guided by (name)", "Wizard"));
      this.Marks.Add("WizA", new Flintstones.Marks("Wizard by oath of (name)", "Wizard"));
      this.Marks.Add("NecroA", new Flintstones.Marks("Walks the path of Necromancy", "Wizard"));
      this.Marks.Add("LabWiz", new Flintstones.Marks("Wizardry Researcher", "Wizard"));
      this.Marks.Add("CftEle", new Flintstones.Marks("Elementalist", "Wizard"));
      this.Marks.Add("KRareWizard", new Flintstones.Marks("Discovered the Dark Ring", "Wizard"));
      this.Marks.Add("Sep4", new Flintstones.Marks("-------------------------------Rogue----------------------------------------", "Rogue"));
      this.Marks.Add("RogMt", new Flintstones.Marks("Rogue, guided by (name)", "Rogue"));
      this.Marks.Add("RogA", new Flintstones.Marks("Rogue by oath of (name)", "Rogue"));
      this.Marks.Add("CftGem", new Flintstones.Marks("Gem Smith", "Rogue"));
      this.Marks.Add("NgmMrd3", new Flintstones.Marks("Marauder of Gold", "Rogue"));
      this.Marks.Add("KRareRogue", new Flintstones.Marks("Recovered the Arcane Gauntlet", "Rogue"));
      this.Marks.Add("Sep5", new Flintstones.Marks("-------------------------------Monk----------------------------------------", "Monk"));
      this.Marks.Add("MnkMt", new Flintstones.Marks("Monk, guided by (name)", "Monk"));
      this.Marks.Add("MnkA", new Flintstones.Marks("Monk by oath of (name)", "Monk"));
      this.Marks.Add("Form1", new Flintstones.Marks("(Animal) Form", "Monk"));
      this.Marks.Add("Form2", new Flintstones.Marks("(Animal) Form", "Monk"));
      this.Marks.Add("Form3", new Flintstones.Marks("(Animal) Form", "Monk"));
      this.Marks.Add("Form4", new Flintstones.Marks("(Animal) Form", "Monk"));
      this.Marks.Add("Dgnr", new Flintstones.Marks("Sabonim of # Dugon", "Monk"));
      this.Marks.Add("Dgn-1", new Flintstones.Marks("(Color) Dugon by (self/name)", "Monk"));
      this.Marks.Add("Dgn-2", new Flintstones.Marks("(Color) Dugon by (self/name)", "Monk"));
      this.Marks.Add("Dgn-3", new Flintstones.Marks("(Color) Dugon by (self/name)", "Monk"));
      this.Marks.Add("Dgn-4", new Flintstones.Marks("(Color) Dugon by (self/name)", "Monk"));
      this.Marks.Add("Dgn-5", new Flintstones.Marks("(Color) Dugon by (self/name)", "Monk"));
      this.Marks.Add("Dgn-6", new Flintstones.Marks("(Color) Dugon by (self/name)", "Monk"));
      this.Marks.Add("Dgn-7", new Flintstones.Marks("(Color) Dugon by (self/name)", "Monk"));
      this.Marks.Add("LBeast1", new Flintstones.Marks("Druid (Animal) Form", "Monk"));
      this.Marks.Add("LBeast2", new Flintstones.Marks("Druid (Animal) Form", "Monk"));
      this.Marks.Add("LBeast3", new Flintstones.Marks("Druid (Animal) Form", "Monk"));
      this.Marks.Add("TwoMove", new Flintstones.Marks("Two/Three Move", "Monk"));
      this.Marks.Add("ThreeMove", new Flintstones.Marks("Two/Three Move", "Monk"));
      this.Marks.Add("NgmPtw1", new Flintstones.Marks("Pattern Walker of Earth/Night/Sea", "Monk"));
      this.Marks.Add("NgmPtw2", new Flintstones.Marks("Pattern Walker of Earth/Night/Sea", "Monk"));
      this.Marks.Add("NgmPtw3", new Flintstones.Marks("Pattern Walker of Earth/Night/Sea", "Monk"));
      this.Marks.Add("KRareMonk", new Flintstones.Marks("Recovered the Obsidian", "Monk"));
      this.Marks.Add("Sep6", new Flintstones.Marks("-------------------------------Warrior----------------------------------------", "Warrior"));
      this.Marks.Add("WarMt", new Flintstones.Marks("Warrior, guided by (name)", "Warrior"));
      this.Marks.Add("WarA", new Flintstones.Marks("Warrior by oath of (name)", "Warrior"));
      this.Marks.Add("PitFight", new Flintstones.Marks("Won # Pit Fights", "Warrior"));
      this.Marks.Add("NgmCrn3", new Flintstones.Marks("Dreamed of Carnun's Trial", "Warrior"));
      this.Marks.Add("KRareWarrior", new Flintstones.Marks("Reforged Eclipse", "Warrior"));
      this.Marks.Add("Sep16", new Flintstones.Marks("-------------------------------Mixed Class----------------------------------", "Mixed"));
      this.Marks.Add("CftSwd", new Flintstones.Marks("Blade Smith", "Mixed"));
      this.Marks.Add("CftSew", new Flintstones.Marks("Tailor", "Mixed"));
      this.Marks.Add("CftHrb", new Flintstones.Marks("Herbalist", "Mixed"));
      this.Marks.Add("NgmCth1", new Flintstones.Marks("Cthonic Disciple of Dawn/Death/Decay (male)", "Mixed"));
      this.Marks.Add("NgmCth2", new Flintstones.Marks("Cthonic Disciple of Dawn/Death/Decay (male)", "Mixed"));
      this.Marks.Add("NgmCth3", new Flintstones.Marks("Cthonic Disciple of Dawn/Death/Decay (male)", "Mixed"));
      this.Marks.Add("NgmMrg1", new Flintstones.Marks("Dreamed of Ana/Macha/Madb (female)", "Mixed"));
      this.Marks.Add("NgmMrg2", new Flintstones.Marks("Dreamed of Ana/Macha/Madb (female)", "Mixed"));
      this.Marks.Add("NgmMrg3", new Flintstones.Marks("Dreamed of Ana/Macha/Madb (female)", "Mixed"));
      this.Marks.Add("Sep7", new Flintstones.Marks("-------------------------------Arena----------------------------------------", "Arena"));
      this.Marks.Add("TAWins", new Flintstones.Marks("Team Arena Wins", "Arena"));
      this.Marks.Add("ArnI", new Flintstones.Marks("Arena Battles", "Arena"));
      this.Marks.Add("Arn", new Flintstones.Marks("Arena Victories", "Arena"));
      this.Marks.Add("Arnr", new Flintstones.Marks("Arena Host", "Arena"));
      this.Marks.Add("MArnr", new Flintstones.Marks("Master Arena Host", "Arena"));
      this.Marks.Add("Sep8", new Flintstones.Marks("-------------------------------Guild----------------------------------------", "Guild"));
      this.Marks.Add("Felleader", new Flintstones.Marks("Fellowship Leader", "Guild"));
      this.Marks.Add("Gld1-3", new Flintstones.Marks("Guild Council", "Guild"));
      this.Marks.Add("Gld1Ct", new Flintstones.Marks("Founded Guild (a)", "Guild"));
      this.Marks.Add("Gld1-6", new Flintstones.Marks("Guild Leader", "Guild"));
      this.Marks.Add("Sep9", new Flintstones.Marks("-------------------------------Politics----------------------------------------", "Politics"));
      this.Marks.Add("PolN1-0", new Flintstones.Marks("Mileth Guest by oath of (name)", "Politics"));
      this.Marks.Add("PolN1-1", new Flintstones.Marks("Mileth Citizen by oath of (name)", "Politics"));
      this.Marks.Add("PolN2-0", new Flintstones.Marks("Rucesion Guest by oath of (name)", "Politics"));
      this.Marks.Add("PolN2-1", new Flintstones.Marks("Rucesion Citizen by oath of (name)", "Politics"));
      this.Marks.Add("SuomiCitzen", new Flintstones.Marks("Suomi Citizen by oath of (name)", "Politics"));
      this.Marks.Add("PolSpn", new Flintstones.Marks("Politically Sponsored by (name)", "Politics"));
      this.Marks.Add("Pol-2I", new Flintstones.Marks("Attempting to become (office)", "Politics"));
      this.Marks.Add("Pol-3I", new Flintstones.Marks("Attempting to become (office)", "Politics"));
      this.Marks.Add("Pol-4I", new Flintstones.Marks("Attempting to become (office)", "Politics"));
      this.Marks.Add("Law-2I", new Flintstones.Marks("Attempting to become (office)", "Politics"));
      this.Marks.Add("Law-3I", new Flintstones.Marks("Attempting to become (office)", "Politics"));
      this.Marks.Add("Law-5I", new Flintstones.Marks("Attempting to become (office)", "Politics"));
      this.Marks.Add("Pol-2", new Flintstones.Marks("Respected Citizen by", "Politics"));
      this.Marks.Add("Pol-3", new Flintstones.Marks("Demagogue by", "Politics"));
      this.Marks.Add("Pol-4", new Flintstones.Marks("Burgess by", "Politics"));
      this.Marks.Add("Law-2", new Flintstones.Marks("Guard", "Politics"));
      this.Marks.Add("Law-3", new Flintstones.Marks("Guard Captain", "Politics"));
      this.Marks.Add("Law-5", new Flintstones.Marks("Judge", "Politics"));
      this.Marks.Add("Ranger", new Flintstones.Marks("Ranger", "Politics"));
      this.Marks.Add("Law-6a", new Flintstones.Marks("Master Ranger", "Politics"));
      this.Marks.Add("Knight", new Flintstones.Marks("Knight of Temuair", "Politics"));
      this.Marks.Add("HwaroneSold", new Flintstones.Marks("Hwarone Soldier/Captain/General/Delegate/Councilman", "Politics"));
      this.Marks.Add("HwaroneCapt", new Flintstones.Marks("Hwarone Soldier/Captain/General/Delegate/Councilman", "Politics"));
      this.Marks.Add("HwaroneGen", new Flintstones.Marks("Hwarone Soldier/Captain/General/Delegate/Councilman", "Politics"));
      this.Marks.Add("Dlgte", new Flintstones.Marks("Hwarone Soldier/Captain/General/Delegate/Councilman", "Politics"));
      this.Marks.Add("Clman", new Flintstones.Marks("Hwarone Soldier/Captain/General/Delegate/Councilman", "Politics"));
      this.Marks.Add("Pol-1r", new Flintstones.Marks("Admitted Citizen (name)", "Politics"));
      this.Marks.Add("PolEfr", new Flintstones.Marks("Pardoned exiled of (name)", "Politics"));
      this.Marks.Add("PolEr", new Flintstones.Marks("Exiled (name)", "Politics"));
      this.Marks.Add("SHr", new Flintstones.Marks("Sgath summoning on (name)", "Politics"));
      this.Marks.Add("Summoned", new Flintstones.Marks("Summoned to Court by (name)", "Politics"));
      this.Marks.Add("Arrested", new Flintstones.Marks("Sentenced # Criminals", "Politics"));
      this.Marks.Add("Sep15", new Flintstones.Marks("-------------------------------Pets----------------------------------------", "Pets"));
      this.Marks.Add("Fae", new Flintstones.Marks("Master to a pet fae", "Pets"));
      this.Marks.Add("Penguin", new Flintstones.Marks("Master to a pet penguin/tagor pets", "Pets"));
      this.Marks.Add("FFloppy", new Flintstones.Marks("Master to a pet penguin/tagor pets", "Pets"));
      this.Marks.Add("MFloppy", new Flintstones.Marks("Master to a pet penguin/tagor pets", "Pets"));
      this.Marks.Add("Blob", new Flintstones.Marks("Master to a pet penguin/tagor pets", "Pets"));
      this.Marks.Add("Mongrel", new Flintstones.Marks("Master to a pet penguin/tagor pets", "Pets"));
      this.Marks.Add("Cat", new Flintstones.Marks("Master to a pet penguin/tagor pets", "Pets"));
      this.Marks.Add("Dog", new Flintstones.Marks("Master to a pet penguin/tagor pets", "Pets"));
      this.Marks.Add("Ducklings", new Flintstones.Marks("Master to a pet penguin/tagor pets", "Pets"));
      this.Marks.Add("Bunny", new Flintstones.Marks("Master to a pet penguin/tagor pets", "Pets"));
      this.Marks.Add("PetMantis", new Flintstones.Marks("Owner of pet mantis", "Pets"));
      this.Marks.Add("PetFlame", new Flintstones.Marks("Owner of pet flame", "Pets"));
      this.Marks.Add("PetPolyp", new Flintstones.Marks("Owner of pet polyp", "Pets"));
      this.Marks.Add("PetCrab", new Flintstones.Marks("Owner of pet crab", "Pets"));
      this.Marks.Add("PetBat", new Flintstones.Marks("Owner of pet bat", "Pets"));
      this.Marks.Add("PetWolf", new Flintstones.Marks("Owner of pet wolf", "Pets"));
      this.Marks.Add("PetPupa", new Flintstones.Marks("Owner of pet pupa", "Pets"));
      this.Marks.Add("PetWasp", new Flintstones.Marks("Owner of pet wasp", "Pets"));
      this.Marks.Add("PetErbie", new Flintstones.Marks("Owner of pet erbie", "Pets"));
      this.Marks.Add("PetGhost", new Flintstones.Marks("Owner of pet ghost", "Pets"));
      this.Marks.Add("PetSucc", new Flintstones.Marks("Owner of pet succubus", "Pets"));
      this.Marks.Add("PetDragon", new Flintstones.Marks("Owner of pet dragon", "Pets"));
      this.Marks.Add("PetHorse", new Flintstones.Marks("Owner of pet horse", "Pets"));
      this.Marks.Add("PetDeer", new Flintstones.Marks("Owner of pet deer", "Pets"));
      this.Marks.Add("PetBast", new Flintstones.Marks("Owner of pet bast", "Pets"));
      this.Marks.Add("PetHolidayErbie", new Flintstones.Marks("Owner of pet holiday erbie", "Pets"));
      this.Marks.Add("PetMummy", new Flintstones.Marks("Buddy of Mummy", "Pets"));
      this.Marks.Add("PetZombie", new Flintstones.Marks("Buddy of Zombie", "Pets"));
      this.Marks.Add("PetChicken", new Flintstones.Marks("Owner of pet chicken", "Pets"));
      this.Marks.Add("PetMalePig", new Flintstones.Marks("Owner of pet male pig", "Pets"));
      this.Marks.Add("PetFemalePig", new Flintstones.Marks("Owner of pet female pig", "Pets"));
      this.Marks.Add("PetBrownOctopus", new Flintstones.Marks("Owner of pet brown octopus", "Pets"));
      this.Marks.Add("PetRedStarfish", new Flintstones.Marks("Owner of pet red starfish", "Pets"));
      this.Marks.Add("PetGreenStarfish", new Flintstones.Marks("Owner of pet green starfish", "Pets"));
      this.Marks.Add("PetBlueOctopus", new Flintstones.Marks("Owner of pet blue octopus", "Pets"));
      this.Marks.Add("PetMouse", new Flintstones.Marks("Owner of pet mouse", "Pets"));
      this.Marks.Add("PetLeprechaun", new Flintstones.Marks("Friend of Leprechaun", "Pets"));
      this.Marks.Add("PetFaerie", new Flintstones.Marks("Friend of Faerie", "Pets"));
      this.Marks.Add("PetFrog", new Flintstones.Marks("Owner of pet frog", "Pets"));
      this.Marks.Add("PetRockScorpian", new Flintstones.Marks("Owner of pet rock scorpion", "Pets"));
      this.Marks.Add("PetGrimSuccubus", new Flintstones.Marks("Owner of pet grim succubus", "Pets"));
      this.Marks.Add("PetSpinningDoll", new Flintstones.Marks("Owner of pet spinning doll", "Pets"));
      this.Marks.Add("PetWhiteBaboon", new Flintstones.Marks("Owner of pet white baboon", "Pets"));
      this.Marks.Add("PetUnmaskedWarrior", new Flintstones.Marks("Owner of pet unmasked warrior", "Pets"));
      this.Marks.Add("PetGreyYowie", new Flintstones.Marks("Owner of pet grey yowie", "Pets"));
      this.Marks.Add("PetBabyBrute", new Flintstones.Marks("Owner of pet baby brute", "Pets"));
      this.Marks.Add("PetRougeMushroom2", new Flintstones.Marks("Owner of pet rouge mushroom 2", "Pets"));
      this.Marks.Add("PetRougeMushroom3", new Flintstones.Marks("Owner of pet rouge mushroom 3", "Pets"));
      this.Marks.Add("PetBlaze", new Flintstones.Marks("Owner of pet blaze", "Pets"));
      this.Marks.Add("PetGel", new Flintstones.Marks("Owner of pet gel", "Pets"));
      this.Marks.Add("PetLeafFox", new Flintstones.Marks("Owner of pet fox", "Pets"));
      this.Marks.Add("PetKraken", new Flintstones.Marks("Owner of pet kraken", "Pets"));
      this.Marks.Add("PetViper", new Flintstones.Marks("Owner of pet viper", "Pets"));
      this.Marks.Add("PetMarauder", new Flintstones.Marks("Owner of pet marauder", "Pets"));
      this.Marks.Add("PetLarva", new Flintstones.Marks("Owner of pet larva", "Pets"));
      this.Marks.Add("PetScorpion", new Flintstones.Marks("Owner of pet scorpion", "Pets"));
      this.Marks.Add("PetBeetle", new Flintstones.Marks("Owner of pet beetle", "Pets"));
      this.Marks.Add("PetBrawlfish", new Flintstones.Marks("Owner of pet brawlfish", "Pets"));
      this.Marks.Add("PetKardi", new Flintstones.Marks("Owner of pet kardi", "Pets"));
      this.Marks.Add("PetGremlin", new Flintstones.Marks("Owner of pet gremlin", "Pets"));
      this.Marks.Add("PetTurtle", new Flintstones.Marks("Owner of pet turtle", "Pets"));
      this.Marks.Add("PetLeech", new Flintstones.Marks("Owner of pet leech", "Pets"));
      this.Marks.Add("PetCentipede", new Flintstones.Marks("Owner of pet centipede", "Pets"));
      this.Marks.Add("PetNagetier", new Flintstones.Marks("Owner of pet nagetier", "Pets"));
      this.Marks.Add("PetNikuru", new Flintstones.Marks("Owner of pet nikuru", "Pets"));
      this.Marks.Add("PetSkrull", new Flintstones.Marks("Owner of pet skrull", "Pets"));
      this.Marks.Add("PetScrummel", new Flintstones.Marks("Owner of pet scrummel", "Pets"));
      this.Marks.Add("PetGrime", new Flintstones.Marks("Owner of pet grime", "Pets"));
      this.Marks.Add("PetSmoldy", new Flintstones.Marks("Owner of pet smoldy", "Pets"));
      this.Marks.Add("PetSalog", new Flintstones.Marks("Owner of pet salog", "Pets"));
      this.Marks.Add("PetRein", new Flintstones.Marks("Owner of pet reindeer", "Pets"));
      this.Marks.Add("PetNamu", new Flintstones.Marks("Owner of pet namu", "Pets"));
      this.Marks.Add("PetGreenDroplet", new Flintstones.Marks("Owner of pet green droplet", "Pets"));
      this.Marks.Add("PetGreenWasp", new Flintstones.Marks("Owner of pet green wasp", "Pets"));
      this.Marks.Add("PetPinkFloppy", new Flintstones.Marks("Owner of pet pink floppy", "Pets"));
      this.Marks.Add("PetVulture", new Flintstones.Marks("Owner of pet vulture", "Pets"));
      this.Marks.Add("PetThree-EyedEagle", new Flintstones.Marks("Owner of pet three-eyed eagle", "Pets"));
      this.Marks.Add("PetSandRat", new Flintstones.Marks("Owner of pet sand rat", "Pets"));
      this.Marks.Add("PetCursedDog", new Flintstones.Marks("Owner of pet cursed dog", "Pets"));
      this.Marks.Add("PetHyena", new Flintstones.Marks("Owner of pet hyena", "Pets"));
      this.Marks.Add("PetSmilyBlob", new Flintstones.Marks("Owner of pet smily blob", "Pets"));
      this.Marks.Add("PetBlackScorpion", new Flintstones.Marks("Owner of pet black scorpion", "Pets"));
      this.Marks.Add("PetWinterErbie", new Flintstones.Marks("Owner of pet winter erbie", "Pets"));
      this.Marks.Add("Sep13", new Flintstones.Marks("-------------------------------Event----------------------------------------", "Event"));
      this.Marks.Add("ElgPrv", new Flintstones.Marks("Eulogy to Adranuch at Pravat", "Event"));
      this.Marks.Add("ElgPrvR", new Flintstones.Marks("Adranuch's Redemption at Pravat", "Event"));
      this.Marks.Add("ElgMhd", new Flintstones.Marks("Eulogy to Matrika at Mehadi", "Event"));
      this.Marks.Add("ElgMhdR", new Flintstones.Marks("Matrika's Redemption at Mehadi", "Event"));
      this.Marks.Add("ElgAst", new Flintstones.Marks("Eulogy to Arpina at Astrid", "Event"));
      this.Marks.Add("ElgAstR", new Flintstones.Marks("Arpina's Redemption at Astrid", "Event"));
      this.Marks.Add("ElgAdr", new Flintstones.Marks("Adoration of Danaan", "Event"));
      this.Marks.Add("HntT7-0", new Flintstones.Marks("(Loures NPC)'s Hunt", "Event"));
      this.Marks.Add("HntT7-1", new Flintstones.Marks("(Loures NPC)'s Hunt", "Event"));
      this.Marks.Add("HntT7-2", new Flintstones.Marks("(Loures NPC)'s Hunt", "Event"));
      this.Marks.Add("HntT7-3", new Flintstones.Marks("(Loures NPC)'s Hunt", "Event"));
      this.Marks.Add("HntT7-4", new Flintstones.Marks("(Loures NPC)'s Hunt", "Event"));
      this.Marks.Add("HntT7-5", new Flintstones.Marks("(Loures NPC)'s Hunt", "Event"));
      this.Marks.Add("GotGStarfish", new Flintstones.Marks("Found a Golden Starfish", "Event"));
      this.Marks.Add("Got4Clover4", new Flintstones.Marks("Found Lucky Clovers", "Event"));
      this.Marks.Add("LockyCharms", new Flintstones.Marks("Found Locky's Charms", "Event"));
      this.Marks.Add("FowlCatcher", new Flintstones.Marks("Completed Capture the Fowl Event", "Event"));
      this.Marks.Add("MechInvasion", new Flintstones.Marks("Survived Mech Invasion", "Event"));
      this.Marks.Add("CountEvent", new Flintstones.Marks("Defeated Count and Countess of Macabre", "Event"));
      this.Marks.Add("ZSlayer", new Flintstones.Marks("Zombie Slayer Record: Round #, # zombies slayed", "Event"));
      this.Marks.Add("DoneYuleLog", new Flintstones.Marks("Crafted Yule Logs for the Inns", "Event"));
      this.Marks.Add("InsectEvnt", new Flintstones.Marks("Completed Quarterly Insect Event", "Event"));
      this.Marks.Add("EasterEvent4", new Flintstones.Marks("Defeated Giant Floppy", "Event"));
      this.Marks.Add("ReceivedHen", new Flintstones.Marks("Received Pet Hen from Areini", "Event"));
      this.Marks.Add("ReceivedRooster", new Flintstones.Marks("Received Pet Rooster from Areini", "Event"));
      this.Marks.Add("GreenAle", new Flintstones.Marks("Drank The Famous Green Ale", "Event"));
      this.Marks.Add("GiftFromGods2", new Flintstones.Marks("Received a pet from the Gods", "Event"));
      this.Marks.Add("SavedEwan", new Flintstones.Marks("Helped Egan's Father Return Home", "Event"));
      this.Marks.Add("Sep11", new Flintstones.Marks("-------------------------------Roleplay----------------------------------------", "Roleplay"));
      this.Marks.Add("SuomiMark", new Flintstones.Marks("Suomi Culture Advocate", "Roleplay"));
      this.Marks.Add("SuomiMark2", new Flintstones.Marks("Suomi Coordinator", "Roleplay"));
      this.Marks.Add("Troupe", new Flintstones.Marks("Member of the Suomi Troupe", "Roleplay"));
      this.Marks.Add("STroupeLeader", new Flintstones.Marks("Burgess of the Suomi Troupe", "Roleplay"));
      this.Marks.Add("TheatreDir", new Flintstones.Marks("Theatre Director", "Roleplay"));
      this.Marks.Add("FairMarshal", new Flintstones.Marks("Fair Marshal", "Roleplay"));
      this.Marks.Add("Sep12", new Flintstones.Marks("-------------------------------Award----------------------------------------", "Award"));
      this.Marks.Add("ManC1", new Flintstones.Marks("Aisling Lore Keeper", "Award"));
      this.Marks.Add("ManC2", new Flintstones.Marks("Rucesion Kingdom Lore Keeper", "Award"));
      this.Marks.Add("ManC3", new Flintstones.Marks("Suomi Village Lore Keeper", "Award"));
      this.Marks.Add("ManC4", new Flintstones.Marks("Mileth Clave Lore Keeper", "Award"));
      this.Marks.Add("ArtC1", new Flintstones.Marks("Aisling Artist", "Award"));
      this.Marks.Add("ArtC2", new Flintstones.Marks("Rucesion Kingdom Artist", "Award"));
      this.Marks.Add("ArtC3", new Flintstones.Marks("Undine Village Artist", "Award"));
      this.Marks.Add("ArtC4", new Flintstones.Marks("Abel Clave Artist", "Award"));
      this.Marks.Add("BioC1", new Flintstones.Marks("Aisling Persona", "Award"));
      this.Marks.Add("BioC2", new Flintstones.Marks("Mileth Kingdom Persona", "Award"));
      this.Marks.Add("BioC3", new Flintstones.Marks("Mileth Village Persona", "Award"));
      this.Marks.Add("BioC4", new Flintstones.Marks("Mileth Clave Persona", "Award"));
      this.Marks.Add("LitC1", new Flintstones.Marks("Aisling Bard", "Award"));
      this.Marks.Add("LitC2", new Flintstones.Marks("Mileth Kingdom Bard", "Award"));
      this.Marks.Add("LitC3", new Flintstones.Marks("Mileth Village Bard", "Award"));
      this.Marks.Add("LitC4", new Flintstones.Marks("Mileth Clave Bard", "Award"));
      this.Marks.Add("PhiC1", new Flintstones.Marks("Aisling Philosopher", "Award"));
      this.Marks.Add("PhiC2", new Flintstones.Marks("Suomi Kingdom Philosopher", "Award"));
      this.Marks.Add("PhiC3", new Flintstones.Marks("Suomi Village Philosopher", "Award"));
      this.Marks.Add("PhiC4", new Flintstones.Marks("Suomi Clave Philosopher", "Award"));
      this.Marks.Add("HisC1", new Flintstones.Marks("Aisling Historian", "Award"));
      this.Marks.Add("HisC2", new Flintstones.Marks("Piet Kingdom Historian", "Award"));
      this.Marks.Add("HisC3", new Flintstones.Marks("Suomi Village Historian", "Award"));
      this.Marks.Add("HisC4", new Flintstones.Marks("Undine Clave Historian", "Award"));
      this.Marks.Add("Crc5Hbs", new Flintstones.Marks("Aisling of Hy-brasyl", "Award"));
      this.Marks.Add("CNbl0", new Flintstones.Marks("Lady/Lord of the Arts", "Award"));
      this.Marks.Add("CNbl1", new Flintstones.Marks("Lady/Lord of the Arts", "Award"));
      this.Marks.Add("Sep14", new Flintstones.Marks("-------------------------------Defunct----------------------------------------", "Defunct"));
      this.Marks.Add("Bd", new Flintstones.Marks("Atavism Age (I/II/III) Aisling - Deoch 1-5", "Defunct"));
      this.Marks.Add("RpC1", new Flintstones.Marks("Aisling Wise One - Deoch 2", "Defunct"));
      this.Marks.Add("Ast-1", new Flintstones.Marks("Astrid Salvation - Deoch 7", "Defunct"));
      this.Marks.Add("PctSav", new Flintstones.Marks("Cured Jacqueline of Loures - Deoch 7", "Defunct"));
      this.Marks.Add("MtI", new Flintstones.Marks("Currently mentored by (name) - Deoch ?-8", "Defunct"));
      this.Marks.Add("Prv1Rlg4", new Flintstones.Marks("Goblin/Grimlok Calling Stone for (god) - Deoch ?-10", "Defunct"));
      this.Marks.Add("ChampDark", new Flintstones.Marks("Champion of the Dark/Light", "Defunct"));
      this.Marks.Add("ChampLight", new Flintstones.Marks("Champion of the Dark/Light", "Defunct"));
      this.Marks.Add("Disciple", new Flintstones.Marks("Has # Disciples", "Defunct"));
      this.Marks.Add("FollowDark", new Flintstones.Marks("Follows Krytos/Pashura of the Dark/Light", "Defunct"));
      this.Marks.Add("FollowLight", new Flintstones.Marks("Follows Krytos/Pashura of the Dark/Light", "Defunct"));
      this.Marks.Add("FirNbl60", new Flintstones.Marks("Fair King/Queen with Eternalty/Secresy - Deoch 32", "Defunct"));
      this.Marks.Add("KillCount", new Flintstones.Marks("Killed # Dark Aislings", "Defunct"));
      this.Marks.Add("GenofCean", new Flintstones.Marks("Event- General of Ceannlaidir's Army, Deoch 34", "Defunct"));
      this.Marks.Add("Lguard1", new Flintstones.Marks("Defeated Warrior Guardian - Deoch 34", "Defunct"));
      this.Marks.Add("Lguard2", new Flintstones.Marks("Defeated Rogue Guardian - Deoch 34", "Defunct"));
      this.Marks.Add("Lguard3", new Flintstones.Marks("Defeated Monk Guardian - Deoch 34", "Defunct"));
      this.Marks.Add("Lguard4", new Flintstones.Marks("Defeated Wizard Guardian - Deoch 34", "Defunct"));
      this.Marks.Add("Lguard5", new Flintstones.Marks("Defeated Priest Guardian - Deoch 34", "Defunct"));
      this.Marks.Add("BSeal", new Flintstones.Marks("Broke the Seal - Deoch 35", "Defunct"));
      this.Marks.Add("UndineReb", new Flintstones.Marks("Aided the Undine Rebels - Deoch 39", "Defunct"));
      this.Marks.Add("LouresWar", new Flintstones.Marks("Defender of Loures Invasion - Deoch 44", "Defunct"));
      this.Marks.Add("FErb", new Flintstones.Marks("Reviving Erbie Species - Deoch 48", "Defunct"));
      this.Marks.Add("Event1", new Flintstones.Marks("Event Alchemist - Case of the Hanging Handmaid - Deoch 53", "Defunct"));
      this.Marks.Add("Event2", new Flintstones.Marks("Event- Destroyed the Ancient Power - Deoch 55", "Defunct"));
      this.Marks.Add("Event3", new Flintstones.Marks("Event- Seized the Ancient Power - Deoch 55", "Defunct"));
      this.Marks.Add("Event4", new Flintstones.Marks("Event- Lost the Ancient Power - Deoch 55", "Defunct"));
      this.Marks.Add("Event5", new Flintstones.Marks("Event- Heart of Gold - Deoch 58", "Defunct"));
      this.Marks.Add("SuomiInn", new Flintstones.Marks("Helped Build Suomi Inn - Deoch 63", "Defunct"));
      this.Marks.Add("SuomiPlans", new Flintstones.Marks("Helped Design Suomi Inn - Deoch 63", "Defunct"));
      this.Marks.Add("Event6", new Flintstones.Marks("Event- Grey Council of Loures - Deoch 65", "Defunct"));
      this.Marks.Add("Event7", new Flintstones.Marks("Event- Grey Council of the Undine Rebels - Deoch 65", "Defunct"));
      this.Marks.Add("Event8", new Flintstones.Marks("Event- Grey Council of the Pact of Anaman - Deoch 65", "Defunct"));
      this.Marks.Add("Event9", new Flintstones.Marks("Event Returned a stolen egg - Deoch 72", "Defunct"));
      this.Marks.Add("Event10", new Flintstones.Marks("Event Completed: The Riddle Quest - Deoch 73", "Defunct"));
      this.Marks.Add("GotPGold", new Flintstones.Marks("Event - Captured Leprechaun - Deoch 74", "Defunct"));
      this.Marks.Add("CleanBank", new Flintstones.Marks("Helped Clean Bank", "Defunct"));
      this.Marks.Add("InsectT5", new Flintstones.Marks("1st Annual Insect Event - Deoch 77", "Defunct"));
      this.Marks.Add("PigEvent", new Flintstones.Marks("Completed the 1st Annual Pig Chase Event - Deoch 80", "Defunct"));
      this.Marks.Add("Event11", new Flintstones.Marks("Event Survived the Super Arena Gauntlet - Deoch 81", "Defunct"));
      this.Marks.Add("VDayL1", new Flintstones.Marks("Delivered Love Packages - Deoch 82", "Defunct"));
      this.Marks.Add("VDayL2", new Flintstones.Marks("Messenger of the Heart - Deoch 82", "Defunct"));
      this.Marks.Add("Event12", new Flintstones.Marks("Event Found the Lost Lute of Mioas - Deoch 82", "Defunct"));
      this.Marks.Add("Got4Clover", new Flintstones.Marks("Found 1st Lucky Clover - Deoch 82", "Defunct"));
      this.Marks.Add("GotPGold2", new Flintstones.Marks("Event - Received Pot of Gold - Deoch 82", "Defunct"));
      this.Marks.Add("EasterEvent", new Flintstones.Marks("Captured Giant Floppy - Deoch 83", "Defunct"));
      this.Marks.Add("InsectT5A", new Flintstones.Marks("2nd Annual Insect Event - Deoch 85", "Defunct"));
      this.Marks.Add("OrenFair2009", new Flintstones.Marks("Aided Temuairian Merchant's Guild - Deoch 86", "Defunct"));
      this.Marks.Add("GotParchment", new Flintstones.Marks("Aided The Temuairian Beggar - Deoch 87", "Defunct"));
      this.Marks.Add("PigEvent2", new Flintstones.Marks("Completed the 2nd Annual Pig Chase Event - Deoch 88", "Defunct"));
      this.Marks.Add("WGoodHealth", new Flintstones.Marks("Wished for Pudgy's Health - Deoch 89", "Defunct"));
      this.Marks.Add("Got4Clover2", new Flintstones.Marks("Found 2nd Lucky Clovers - Deoch 90", "Defunct"));
      this.Marks.Add("GotPGold3", new Flintstones.Marks("Event - Found Leprechaun's Gold - Deoch 90", "Defunct"));
      this.Marks.Add("EasterEvent2", new Flintstones.Marks("Slayed Giant Floppy - Deoch 91", "Defunct"));
      this.Marks.Add("Event13", new Flintstones.Marks("Event Riddle Mastermind - Deoch 92", "Defunct"));
      this.Marks.Add("Event14", new Flintstones.Marks("Event Scavenger of Suomi - Deoch 92", "Defunct"));
      this.Marks.Add("Event15", new Flintstones.Marks("Event Flag Hunter Participant - Deoch 92", "Defunct"));
      this.Marks.Add("Event16", new Flintstones.Marks("Event Flag Hunter Champion of Suomi - Deoch 92", "Defunct"));
      this.Marks.Add("InsectT5B", new Flintstones.Marks("3rd Annual Insect Event - Deoch 93", "Defunct"));
      this.Marks.Add("OrenFair2010", new Flintstones.Marks("Gathered Treasures for Gillam - Deoch 94", "Defunct"));
      this.Marks.Add("GotParchment2", new Flintstones.Marks("Assisted The Temuarian Beggar - Deoch 95", "Defunct"));
      this.Marks.Add("Event17", new Flintstones.Marks("Event Has Holiday Spirit (1) - Deoch 96", "Defunct"));
      this.Marks.Add("Event18", new Flintstones.Marks("Event (Legendary 99er) - Deoch 96", "Defunct"));
      this.Marks.Add("PigEvent3", new Flintstones.Marks("Completed the 3rd Annual Pig Chase Event - Deoch 96", "Defunct"));
      this.Marks.Add("Got4Clover3", new Flintstones.Marks("Found 3rd Lucky Clovers - Deoch 98", "Defunct"));
      this.Marks.Add("GotPGold4", new Flintstones.Marks("Event - Found The End Of The Rainbow - Deoch 98", "Defunct"));
      this.Marks.Add("EasterEvent3", new Flintstones.Marks("Tamed Giant Floppy - Deoch 99", "Defunct"));
      this.Marks.Add("Event19", new Flintstones.Marks("Event Poet of Temuair - Deoch 100", "Defunct"));
      this.Marks.Add("SavedBeach", new Flintstones.Marks("Kept Paradise Beach Safe - Deoch 102", "Defunct"));
      this.Marks.Add("OrenFair2011", new Flintstones.Marks("Assisted Gillam's Guild - Deoch 102", "Defunct"));
      this.Marks.Add("GotParchment3", new Flintstones.Marks("Helped The Temuarian Beggar - Deoch 103", "Defunct"));
      this.Marks.Add("PigEvent4", new Flintstones.Marks("Completed the 4th Annual Pig Chase Event - Deoch 104", "Defunct"));
      this.Marks.Add("Event20", new Flintstones.Marks("Event Most Knowledgeable Aisling in Temuair - Deoch 105", "Defunct"));
      this.Marks.Add("GotPGold5", new Flintstones.Marks("Event - Found The Pot of Gold - Deoch 106", "Defunct"));
      this.Marks.Add("Event21", new Flintstones.Marks("Event - History Trivia Winner - Deoch 108", "Defunct"));
      this.Marks.Add("BACombatant", new Flintstones.Marks("Balanced Arena Combatant - Deoch 109", "Defunct"));
      this.Marks.Add("TestBlananceArena", new Flintstones.Marks("Balanced Arena Tester", "Defunct"));
      this.Marks.Add("SavedBeach2", new Flintstones.Marks("Saved Paradise Beach - Deoch 109", "Defunct"));
      this.Marks.Add("GiftFromGods", new Flintstones.Marks("Received a Gift from the Gods", "Defunct"));
      this.Marks.Add("OrenFair2012", new Flintstones.Marks("Recovered Gillam's precious coins - Deoch 110", "Defunct"));
      this.Marks.Add("GotParchment4", new Flintstones.Marks("Befriended The Temuarian Beggar - Deoch 111", "Defunct"));
      this.Marks.Add("Event22", new Flintstones.Marks("Event - Loures Soccer Champion - Deoch 113", "Defunct"));
      this.Marks.Add("Event23", new Flintstones.Marks("Event Arena Duo Tournament Second Runner-up - Deoch 113", "Defunct"));
      this.Marks.Add("Event24", new Flintstones.Marks("Event Arena Duo Tournament First Runner-up - Deoch 113", "Defunct"));
      this.Marks.Add("Event25", new Flintstones.Marks("Event Arena Duo Tournament Champion - Deoch 113", "Defunct"));
      this.Marks.Add("GotPGold6", new Flintstones.Marks("Event - Uncovered The Pot of Gold - Deoch 114", "Defunct"));
      this.Marks.Add("OrenFair2013", new Flintstones.Marks("Reclaimed Gillam's precious coins - Deoch 118", "Defunct"));
      this.Marks.Add("GotParchment5", new Flintstones.Marks("Supported The Temuarian Beggar - Deoch 119", "Defunct"));
      this.Marks.Add("Event26", new Flintstones.Marks("Event Temuairian Travel Agent - Deoch 119", "Defunct"));
      this.Marks.Add("Event27", new Flintstones.Marks("Event First Place Best Costume of Temuair - Deoch 119", "Defunct"));
      this.Marks.Add("Event28", new Flintstones.Marks("Event First Place Best Threads of Temauir - Deoch 120", "Defunct"));
      this.Marks.Add("GotPGold7", new Flintstones.Marks("Event - Discovered The Pot of Gold - Deoch 122", "Defunct"));
      this.Marks.Add("Event29", new Flintstones.Marks("Event Trans-Temuairian Race - 1st Place - Deoch 123", "Defunct"));
      this.Marks.Add("Event30", new Flintstones.Marks("Event Saved Sweety from the Kobolds - Deoch 123", "Defunct"));
      this.Marks.Add("Event31", new Flintstones.Marks("Event Mythril Chef - Deoch 125", "Defunct"));
      this.Marks.Add("OrenFair2014", new Flintstones.Marks("Collected Gillam's precious coins - Deoch 126", "Defunct"));
      this.Marks.Add("PigEvent5", new Flintstones.Marks("Completed the 4th(5th/6th) Annual Pig Chase Event - Deoch 128", "Defunct"));
      this.Marks.Add("GotPGold8", new Flintstones.Marks("Event - Obtained Lumen Amulet from Leprechaun - Deoch 130", "Defunct"));
      this.Marks.Add("GuildA", new Flintstones.Marks("Motley by oath of (name)", "Defunct"));
      this.Marks.Add("MotleyQ", new Flintstones.Marks("Completed motley Geas for (name)", "Defunct"));
      this.Marks.Add("MotleyCo", new Flintstones.Marks("Motley Council (a)", "Defunct"));
      this.Marks.Add("GuildCo", new Flintstones.Marks("Motley Council (b)", "Defunct"));
      this.Marks.Add("MotleyCt", new Flintstones.Marks("Founded Motley", "Defunct"));
      this.Marks.Add("MotleyMa", new Flintstones.Marks("Motley Leader", "Defunct"));
      this.Marks.Add("GuildAr", new Flintstones.Marks("Initiated (name) into a Motley", "Defunct"));
      this.Marks.Add("GuildL", new Flintstones.Marks("Left Guild", "Defunct"));
      this.Marks.Add("Gld1-1", new Flintstones.Marks("Guild by oath of (name)", "Defunct"));
      this.Marks.Add("Gld1Q", new Flintstones.Marks("Completed Guild Geas for (name)", "Defunct"));
      this.Marks.Add("GuildCt", new Flintstones.Marks("Founded Guild (b)", "Defunct"));
      this.Marks.Add("GuildMa", new Flintstones.Marks("Guild Master", "Defunct"));
      this.Marks.Add("GuildCorI", new Flintstones.Marks("May Appoint Guild Council (a)", "Defunct"));
      this.Marks.Add("Gld1-3rI", new Flintstones.Marks("May appoint Guild Council (b)", "Defunct"));
      this.Marks.Add("Gld1-1r", new Flintstones.Marks("Admitted Guild member (name)", "Defunct"));
      this.Marks.Add("GuildEr", new Flintstones.Marks("Exiled Guild member (name)", "Defunct"));
      this.Marks.Add("Ass", new Flintstones.Marks("Annoyed (name)", "Defunct"));
      this.Marks.Add("GuildE", new Flintstones.Marks("Exiled from Guild by (name)", "Defunct"));
      this.Marks.Add("Law-7I", new Flintstones.Marks("Attempting to become Sheriff", "Defunct"));
      this.Marks.Add("PicC3", new Flintstones.Marks("Suomi Village Memory", "Defunct"));
      this.Marks.Add("PicC4", new Flintstones.Marks("Piet Clave Memory", "Defunct"));
      this.Marks.Add("Sep10", new Flintstones.Marks("-------------------------------Jails----------------------------------------", "Jails"));
      this.Marks.Add("TagorMurder", new Flintstones.Marks("Murdered # Tagor citizens", "Jails"));
      this.Marks.Add("AllJ", new Flintstones.Marks("Jailed # times - last by (name)", "Jails"));
      this.Marks.Add("AutoHJ", new Flintstones.Marks("Arrested by (name) ((Auto Hunting))", "Jails"));
      this.Marks.Add("HwaroneArrested", new Flintstones.Marks("Hwarone Arrest", "Jails"));
      this.Marks.Add("RlgOv", new Flintstones.Marks("Heretic by oath of (name)", "Jails"));
      this.Marks.Add("ArenaEx", new Flintstones.Marks("Exiled from the Arena", "Jails"));
      this.Marks.Add("PolN1E", new Flintstones.Marks("Exiled from Mileth by (name)", "Jails"));
      this.Marks.Add("PolN2E", new Flintstones.Marks("Exiled from Rucesion by (name)", "Jails"));
      this.InitializeComponent();
    }

    private void LegendMarks_Load(object sender, EventArgs e)
    {
      if (this.listView1.Items.Count > 0)
        this.listView1.Items.Clear();
      this.PopulateList();
    }

    private void PopulateList()
    {
      this.listView1.BeginUpdate();
      foreach (KeyValuePair<string, Flintstones.Marks> mark in this.Marks)
      {
        bool flag = false;
        if (mark.Key != null && (this.regular.Checked || !(mark.Value.Cat == "Regular")) && (this.paths.Checked || !(mark.Value.Cat == "Priest") && !(mark.Value.Cat == "Rogue") && !(mark.Value.Cat == "Monk") && !(mark.Value.Cat == "Warrior") && !(mark.Value.Cat == "Wizard") && !(mark.Value.Cat == "Mixed")) && (this.arena.Checked || !(mark.Value.Cat == "Arena")) && (this.guild.Checked || !(mark.Value.Cat == "Guild")) && (this.politics.Checked || !(mark.Value.Cat == "Politics")) && (this.jails.Checked || !(mark.Value.Cat == "Jails")) && (this.roleplay.Checked || !(mark.Value.Cat == "Roleplay")) && (this.award.Checked || !(mark.Value.Cat == "Award")) && (this.events.Checked || !(mark.Value.Cat == "Event")) && (this.defunct.Checked || !(mark.Value.Cat == "Defunct")) && (this.pets.Checked || !(mark.Value.Cat == "Pets")) && !this.listView1.Items.ContainsKey(mark.Value.Name) && !this.Client.LegendMarks.ContainsKey(mark.Key) && (!(mark.Value.Name == "(Town) mundane birth") || !this.Client.LegendMarks.ContainsKey("BbdT1") && !this.Client.LegendMarks.ContainsKey("BbdT2") && !this.Client.LegendMarks.ContainsKey("BbdT3") && !this.Client.LegendMarks.ContainsKey("BbdT4") && !this.Client.LegendMarks.ContainsKey("BbdT5") && !this.Client.LegendMarks.ContainsKey("BbdT6") && !this.Client.LegendMarks.ContainsKey("BadT1") && !this.Client.LegendMarks.ContainsKey("BadT2") && !this.Client.LegendMarks.ContainsKey("BadT3") && !this.Client.LegendMarks.ContainsKey("BadT4") && !this.Client.LegendMarks.ContainsKey("BadT5") && !this.Client.LegendMarks.ContainsKey("BadT6")) && (!(mark.Value.Name == "Cured a sick child in Loures") || !this.Client.LegendMarks.ContainsKey("PctSav-2") && !this.Client.LegendMarks.ContainsKey("PctAna-2")) && (!(mark.Value.Name == "(Small) Heart of Fire/Moon/Stone") || !this.Client.LegendMarks.ContainsKey("HrtFir") && !this.Client.LegendMarks.ContainsKey("HrtFir-2") && !this.Client.LegendMarks.ContainsKey("HrtMon") && !this.Client.LegendMarks.ContainsKey("HrtMon-2") && !this.Client.LegendMarks.ContainsKey("HrtStn") && !this.Client.LegendMarks.ContainsKey("HrtStn-2")) && (!(mark.Value.Name == "Aided the Emerald Knights/Necromancer Order") || !this.Client.LegendMarks.ContainsKey("EmeraldN") && !this.Client.LegendMarks.ContainsKey("EmeraldK")) && (!(mark.Value.Name == "Kept Fisk's Secret") || !this.Client.LegendMarks.ContainsKey("KeptSecret") && !this.Client.LegendMarks.ContainsKey("ToldSecret")) && (!(mark.Value.Name == "Helped Mephit/Morwin") || !this.Client.LegendMarks.ContainsKey("LMorwin1") && !this.Client.LegendMarks.ContainsKey("LMephit1")) && (!(mark.Value.Name == "Worthy of the Band/Cap of Danaan") || !this.Client.LegendMarks.ContainsKey("Capquest") && !this.Client.LegendMarks.ContainsKey("Capquest1")) && (!(mark.Value.Name == "(Color) Dugon by (self/name)") || !this.Client.LegendMarks.ContainsKey("Dgn") && !this.Client.LegendMarks.ContainsKey("Dgn-1") && !this.Client.LegendMarks.ContainsKey("Dgn-2") && !this.Client.LegendMarks.ContainsKey("Dgn-3") && !this.Client.LegendMarks.ContainsKey("Dgn-4") && !this.Client.LegendMarks.ContainsKey("Dgn-5") && !this.Client.LegendMarks.ContainsKey("Dgn-6") && !this.Client.LegendMarks.ContainsKey("Dgn-7")) && (!(mark.Value.Name == "(Animal) Form") || !this.Client.LegendMarks.ContainsKey("Form1") && !this.Client.LegendMarks.ContainsKey("Form2") && !this.Client.LegendMarks.ContainsKey("Form3") && !this.Client.LegendMarks.ContainsKey("Form4")) && (!(mark.Value.Name == "Druid (Animal) Form") || !this.Client.LegendMarks.ContainsKey("LBeast1") && !this.Client.LegendMarks.ContainsKey("LBeast2") && !this.Client.LegendMarks.ContainsKey("LBeast3")) && (!(mark.Value.Name == "Two/Three Move") || !this.Client.LegendMarks.ContainsKey("TwoMove") && !this.Client.LegendMarks.ContainsKey("ThreeMove")) && (!(mark.Value.Name == "Cthonic Disciple of Dawn/Death/Decay (male)") || !this.Client.LegendMarks.ContainsKey("NgmCth1") && !this.Client.LegendMarks.ContainsKey("NgmCth2") && !this.Client.LegendMarks.ContainsKey("NgmCth3")) && (!(mark.Value.Name == "Dreamed of Ana/Macha/Madb (female)") || !this.Client.LegendMarks.ContainsKey("NgmMrg1") && !this.Client.LegendMarks.ContainsKey("NgmMrg2") && !this.Client.LegendMarks.ContainsKey("NgmMrg3")) && (!(mark.Value.Name == "Pattern Walker of Earth/Night/Sea") || !this.Client.LegendMarks.ContainsKey("NgmPtw1") && !this.Client.LegendMarks.ContainsKey("NgmPtw2") && !this.Client.LegendMarks.ContainsKey("NgmPtw3")) && (!(mark.Value.Name == "Chadul/Danaan Reincarnation") || !this.Client.LegendMarks.ContainsKey("ReinSgrios") && !this.Client.LegendMarks.ContainsKey("ReinDeoch")) && (!(mark.Value.Name == "(Class) Dedication") || !this.Client.LegendMarks.ContainsKey("Master") && !this.Client.LegendMarks.ContainsKey("CPriest") && !this.Client.LegendMarks.ContainsKey("CThief") && !this.Client.LegendMarks.ContainsKey("CMonk") && !this.Client.LegendMarks.ContainsKey("CMage") && !this.Client.LegendMarks.ContainsKey("CWarror")) && (!(mark.Value.Name == "Follows Krytos/Pashura of the Dark/Light") || !this.Client.LegendMarks.ContainsKey("FollowDark") && !this.Client.LegendMarks.ContainsKey("FollowLight")) && (!(mark.Value.Name == "Champion of the Dark/Light") || !this.Client.LegendMarks.ContainsKey("ChampDark") && !this.Client.LegendMarks.ContainsKey("ChampLight")) && (!(mark.Value.Name == "(Loures NPC)'s Hunt") || !this.Client.LegendMarks.ContainsKey("HntT7-0") && !this.Client.LegendMarks.ContainsKey("HntT7-1") && !this.Client.LegendMarks.ContainsKey("HntT7-2") && !this.Client.LegendMarks.ContainsKey("HntT7-3") && !this.Client.LegendMarks.ContainsKey("HntT7-4") && !this.Client.LegendMarks.ContainsKey("HntT7-5")) && (!(mark.Value.Name == "Attempting to become (office)") || !this.Client.LegendMarks.ContainsKey("Law-2I") && !this.Client.LegendMarks.ContainsKey("Law-3I") && !this.Client.LegendMarks.ContainsKey("Law-5I") && !this.Client.LegendMarks.ContainsKey("Pol-2I") && !this.Client.LegendMarks.ContainsKey("Pol-3I") && !this.Client.LegendMarks.ContainsKey("Pol-4I")) && (!(mark.Value.Name == "Lady/Lord of the Arts") || !this.Client.LegendMarks.ContainsKey("CNbl0") && !this.Client.LegendMarks.ContainsKey("CNbl1")) && (!(mark.Value.Name == "Hwarone Soldier/Captain/General/Delegate/Councilman") || !this.Client.LegendMarks.ContainsKey("HwaroneGen") && !this.Client.LegendMarks.ContainsKey("HwaroneSold") && !this.Client.LegendMarks.ContainsKey("HwaroneCapt") && !this.Client.LegendMarks.ContainsKey("Dlgte") && !this.Client.LegendMarks.ContainsKey("Clman")) && (!(mark.Value.Name == "(God) Acolyte/Priest/Etc by (self/name)") || !this.Client.LegendMarks.ContainsKey("Rlg1-2") && !this.Client.LegendMarks.ContainsKey("Rlg2-2") && !this.Client.LegendMarks.ContainsKey("Rlg3-2") && !this.Client.LegendMarks.ContainsKey("Rlg4-2") && !this.Client.LegendMarks.ContainsKey("Rlg5-2") && !this.Client.LegendMarks.ContainsKey("Rlg6-2") && !this.Client.LegendMarks.ContainsKey("Rlg7-2") && !this.Client.LegendMarks.ContainsKey("Rlg8-2") && !this.Client.LegendMarks.ContainsKey("Rlg1-3") && !this.Client.LegendMarks.ContainsKey("Rlg2-3") && !this.Client.LegendMarks.ContainsKey("Rlg3-3") && !this.Client.LegendMarks.ContainsKey("Rlg4-3") && !this.Client.LegendMarks.ContainsKey("Rlg5-3") && !this.Client.LegendMarks.ContainsKey("Rlg6-3") && !this.Client.LegendMarks.ContainsKey("Rlg7-3") && !this.Client.LegendMarks.ContainsKey("Rlg8-3") && !this.Client.LegendMarks.ContainsKey("Rlg1-4") && !this.Client.LegendMarks.ContainsKey("Rlg2-4") && !this.Client.LegendMarks.ContainsKey("Rlg3-4") && !this.Client.LegendMarks.ContainsKey("Rlg4-4") && !this.Client.LegendMarks.ContainsKey("Rlg5-4") && !this.Client.LegendMarks.ContainsKey("Rlg6-4") && !this.Client.LegendMarks.ContainsKey("Rlg7-4") && !this.Client.LegendMarks.ContainsKey("Rlg8-4") && !this.Client.LegendMarks.ContainsKey("Rlg1-5") && !this.Client.LegendMarks.ContainsKey("Rlg2-5") && !this.Client.LegendMarks.ContainsKey("Rlg3-5") && !this.Client.LegendMarks.ContainsKey("Rlg4-5") && !this.Client.LegendMarks.ContainsKey("Rlg5-5") && !this.Client.LegendMarks.ContainsKey("Rlg6-5") && !this.Client.LegendMarks.ContainsKey("Rlg7-5") && !this.Client.LegendMarks.ContainsKey("Rlg8-5") && !this.Client.LegendMarks.ContainsKey("Rlg1-6") && !this.Client.LegendMarks.ContainsKey("Rlg2-6") && !this.Client.LegendMarks.ContainsKey("Rlg3-6") && !this.Client.LegendMarks.ContainsKey("Rlg4-6") && !this.Client.LegendMarks.ContainsKey("Rlg5-6") && !this.Client.LegendMarks.ContainsKey("Rlg6-6") && !this.Client.LegendMarks.ContainsKey("Rlg7-6") && !this.Client.LegendMarks.ContainsKey("Rlg8-6")) && (!(mark.Value.Name == "Master to a pet penguin/tagor pets") || !this.Client.LegendMarks.ContainsKey("Ducklings") && !this.Client.LegendMarks.ContainsKey("Cat") && !this.Client.LegendMarks.ContainsKey("Bunny") && !this.Client.LegendMarks.ContainsKey("Dog") && !this.Client.LegendMarks.ContainsKey("Mongrel") && !this.Client.LegendMarks.ContainsKey("Blob") && !this.Client.LegendMarks.ContainsKey("Penguin") && !this.Client.LegendMarks.ContainsKey("FFloppy") && !this.Client.LegendMarks.ContainsKey("MFloppy")))
        {
          if (mark.Key == "PetMouse" || mark.Key == "PetRedStarfish" || mark.Key == "PetGreenStarfish" || mark.Key == "PetFrog" || mark.Key == "PetRockScorpian")
            flag = true;
          if (mark.Value.Name == "Herbalist" && this.Client.Path != (byte) 3 && this.Client.Path != (byte) 4 && this.Client.Path != (byte) 5)
          {
            if (this.Client.LegendMarks.ContainsKey("CPriest") || this.Client.LegendMarks.ContainsKey("CMonk") || this.Client.LegendMarks.ContainsKey("CMage"))
              flag = true;
            else if (!this.Client.HasSkill("Herbal Lore"))
              continue;
          }
          if (mark.Value.Name == "Tailor" && this.Client.Path != (byte) 1 && this.Client.Path != (byte) 2 && this.Client.Path != (byte) 5)
          {
            if (this.Client.LegendMarks.ContainsKey("CWarror") || this.Client.LegendMarks.ContainsKey("CMonk") || this.Client.LegendMarks.ContainsKey("CThief"))
              flag = true;
            else if (!this.Client.HasSkill("Tailoring"))
              continue;
          }
          if (mark.Value.Name == "Great Soldier of the Goblin War" && this.Client.Medenian == (byte) 1)
            flag = true;
          if (mark.Value.Name == "Completed Treas Quest" && this.Client.Statistics.Level > 75)
            flag = true;
          if (mark.Value.Name == "Defeated the Octopus of Karlopos" && this.Client.Statistics.Level > 70)
            flag = true;
          if (mark.Value.Name == "Completed Tiota Quest" && this.Client.Statistics.Level > 50)
            flag = true;
          if (mark.Value.Name == "Eased the suffering of Porte Forest" && this.Client.Statistics.Level > 41)
            flag = true;
          if (mark.Value.Name == "Saved daughter of Porte Forest" && this.Client.Statistics.Level > 41)
            flag = true;
          if (mark.Value.Name == "Completed Ciad Quest" && this.Client.Statistics.Level > 25)
            flag = true;
          if (mark.Value.Name == "Slew Terror of the Alley/Garden/Crypt" && this.Client.Statistics.Level > 49)
            flag = true;
          if (mark.Value.Name == "Loved by Mileth Mundanes" && this.Client.Statistics.Level > 11)
            flag = true;
          if (mark.Key == "WarMt")
          {
            if (this.Client.LegendMarks.ContainsKey("CWarror"))
              flag = true;
            else if (this.Client.Path != (byte) 1)
              continue;
          }
          if (mark.Key == "WarA")
          {
            if (this.Client.LegendMarks.ContainsKey("CWarror"))
              flag = true;
            else if (this.Client.Path != (byte) 1)
              continue;
          }
          if (mark.Key == "PitFight")
          {
            if (this.Client.LegendMarks.ContainsKey("CWarror"))
              flag = true;
            else if (this.Client.Path != (byte) 1)
              continue;
          }
          if (mark.Key == "NgmCrn3")
          {
            if (this.Client.LegendMarks.ContainsKey("CWarror"))
              flag = true;
            else if (this.Client.Path != (byte) 1)
              continue;
          }
          if (mark.Value.Name == "Blade Smith" && this.Client.Path != (byte) 2 && this.Client.Path != (byte) 1)
          {
            if (this.Client.Path != (byte) 1 && this.Client.Path != (byte) 2 && (this.Client.LegendMarks.ContainsKey("CThief") || this.Client.LegendMarks.ContainsKey("CWarror")))
              flag = true;
            else if (this.Client.Path != (byte) 1 && this.Client.Path != (byte) 2)
              continue;
          }
          if ((!(mark.Key == "KRareWarrior") || this.Client.Path == (byte) 1) && (!(mark.Key == "Sep6") || this.Client.LegendMarks.ContainsKey("CWarror") || this.Client.Path == (byte) 1))
          {
            if (mark.Key == "RogMt")
            {
              if (this.Client.LegendMarks.ContainsKey("CThief"))
                flag = true;
              else if (this.Client.Path != (byte) 2)
                continue;
            }
            if (mark.Key == "RogA")
            {
              if (this.Client.LegendMarks.ContainsKey("CThief"))
                flag = true;
              else if (this.Client.Path != (byte) 2)
                continue;
            }
            if (mark.Key == "NgmMrd3")
            {
              if (this.Client.LegendMarks.ContainsKey("CThief"))
                flag = true;
              else if (this.Client.Path != (byte) 2)
                continue;
            }
            if (mark.Value.Name == "Gem Smith")
            {
              if (this.Client.LegendMarks.ContainsKey("CThief"))
                flag = true;
              else if (this.Client.Path != (byte) 2)
                continue;
            }
            if ((!(mark.Key == "KRareRogue") || this.Client.Path == (byte) 2) && (!(mark.Key == "Sep4") || this.Client.LegendMarks.ContainsKey("CThief") || this.Client.Path == (byte) 2))
            {
              if (mark.Key == "WizMt")
              {
                if (this.Client.LegendMarks.ContainsKey("CMage"))
                  flag = true;
                else if (this.Client.Path != (byte) 3)
                  continue;
              }
              if (mark.Key == "WizA")
              {
                if (this.Client.LegendMarks.ContainsKey("CMage"))
                  flag = true;
                else if (this.Client.Path != (byte) 3)
                  continue;
              }
              if (mark.Value.Name == "Elementalist")
              {
                if (this.Client.LegendMarks.ContainsKey("CMage"))
                  flag = true;
                else if (this.Client.Path != (byte) 3)
                  continue;
              }
              if (mark.Value.Name == "Wizardry Researcher")
              {
                if (this.Client.LegendMarks.ContainsKey("CMage"))
                  flag = true;
                else if (this.Client.Path != (byte) 3)
                  continue;
              }
              if (mark.Value.Name == "Walks the path of Necromancy")
              {
                if (this.Client.LegendMarks.ContainsKey("CMage"))
                  flag = true;
                else if (this.Client.Path != (byte) 3)
                  continue;
              }
              if (mark.Value.Name == "Cthonic Disciple of Dawn/Death/Decay (male)" && this.Client.Path != (byte) 4 && this.Client.Path != (byte) 3)
              {
                if (this.Client.Path != (byte) 3 && this.Client.Path != (byte) 4 && (this.Client.LegendMarks.ContainsKey("CMage") || this.Client.LegendMarks.ContainsKey("CPriest")))
                  flag = true;
                else if (this.Client.Path != (byte) 3 && this.Client.Path != (byte) 4)
                  continue;
              }
              if (mark.Value.Name == "Dreamed of Ana/Macha/Madb (female)" && this.Client.Path != (byte) 4 && this.Client.Path != (byte) 3)
              {
                if (this.Client.Path != (byte) 3 && this.Client.Path != (byte) 4 && (this.Client.LegendMarks.ContainsKey("CMage") || this.Client.LegendMarks.ContainsKey("CPriest")))
                  flag = true;
                else if (this.Client.Path != (byte) 3 && this.Client.Path != (byte) 4)
                  continue;
              }
              if ((!(mark.Key == "KRareWizard") || this.Client.Path == (byte) 3) && (!(mark.Key == "Sep3") || this.Client.LegendMarks.ContainsKey("CMage") || this.Client.Path == (byte) 3))
              {
                if (mark.Key == "PriMt")
                {
                  if (this.Client.LegendMarks.ContainsKey("CPriest"))
                    flag = true;
                  else if (this.Client.Path != (byte) 4)
                    continue;
                }
                if (mark.Key == "PriA")
                {
                  if (this.Client.LegendMarks.ContainsKey("CPriest"))
                    flag = true;
                  else if (this.Client.Path != (byte) 4)
                    continue;
                }
                if (mark.Key == "Alt")
                {
                  if (this.Client.LegendMarks.ContainsKey("CPriest"))
                    flag = true;
                  else if (this.Client.Path != (byte) 4)
                    continue;
                }
                if (mark.Key == "LoveAr")
                {
                  if (this.Client.LegendMarks.ContainsKey("CPriest"))
                    flag = true;
                  else if (this.Client.Path != (byte) 4)
                    continue;
                }
                if (mark.Key == "LoveLr")
                {
                  if (this.Client.LegendMarks.ContainsKey("CPriest"))
                    flag = true;
                  else if (this.Client.Path != (byte) 4)
                    continue;
                }
                if (mark.Key == "WedLr")
                {
                  if (this.Client.LegendMarks.ContainsKey("CPriest"))
                    flag = true;
                  else if (this.Client.Path != (byte) 4)
                    continue;
                }
                if (mark.Key == "Rlg-1r")
                {
                  if (this.Client.LegendMarks.ContainsKey("CPriest"))
                    flag = true;
                  else if (this.Client.Path != (byte) 4)
                    continue;
                }
                if (mark.Key == "RlgEr")
                {
                  if (this.Client.LegendMarks.ContainsKey("CPriest"))
                    flag = true;
                  else if (this.Client.Path != (byte) 4)
                    continue;
                }
                if (mark.Key == "RlgHeld")
                {
                  if (this.Client.LegendMarks.ContainsKey("CPriest"))
                    flag = true;
                  else if (this.Client.Path != (byte) 4)
                    continue;
                }
                if ((!(mark.Key == "KRarePriest") || this.Client.Path == (byte) 4) && (!(mark.Key == "Sep2") || this.Client.LegendMarks.ContainsKey("CPriest") || this.Client.Path == (byte) 4))
                {
                  if (mark.Key == "MnkMt")
                  {
                    if (this.Client.LegendMarks.ContainsKey("CMonk"))
                      flag = true;
                    else if (this.Client.Path != (byte) 5)
                      continue;
                  }
                  if (mark.Key == "MnkA")
                  {
                    if (this.Client.LegendMarks.ContainsKey("CMonk"))
                      flag = true;
                    else if (this.Client.Path != (byte) 5)
                      continue;
                  }
                  if (mark.Value.Name == "(Animal) Form")
                  {
                    if (this.Client.LegendMarks.ContainsKey("CMonk"))
                      flag = true;
                    else if (this.Client.Path != (byte) 5)
                      continue;
                  }
                  if (!(mark.Key == "Dgnr") || this.Client.Path == (byte) 5)
                  {
                    if (mark.Value.Name == "(Color) Dugon by (self/name)")
                    {
                      if (this.Client.LegendMarks.ContainsKey("CMonk"))
                        flag = true;
                      else if (this.Client.Path != (byte) 5)
                        continue;
                    }
                    if (mark.Value.Name == "Pattern Walker of Earth/Night/Sea")
                    {
                      if (this.Client.LegendMarks.ContainsKey("CMonk"))
                        flag = true;
                      else if (this.Client.Path != (byte) 5)
                        continue;
                    }
                    if ((!(mark.Key == "KRareMonk") || this.Client.Path == (byte) 5) && (!(mark.Value.Name == "Druid (Animal) Form") || this.Client.Path == (byte) 5) && (!(mark.Value.Name == "Two/Three Move") || this.Client.Path == (byte) 5) && (!(mark.Key == "Sep5") || this.Client.LegendMarks.ContainsKey("CMonk") || this.Client.Path == (byte) 5) && (!(mark.Key == "Sep16") || this.Client.LegendMarks.ContainsKey("CftSwd") || this.Client.LegendMarks.ContainsKey("CftSew") || this.Client.LegendMarks.ContainsKey("CftHrb") || this.Client.LegendMarks.ContainsKey("NgmMrg1") || this.Client.LegendMarks.ContainsKey("NgmMrg2") || this.Client.LegendMarks.ContainsKey("NgmMrg3") || this.Client.LegendMarks.ContainsKey("NgmCth1") || this.Client.LegendMarks.ContainsKey("NgmCth2") || this.Client.LegendMarks.ContainsKey("NgmCth3")))
                    {
                      ListViewItem listViewItem = this.listView1.Items.Add(mark.Value.Name.ToString(), mark.Value.Name.ToString(), -1);
                      if (mark.Key == "MilethLove" || mark.Key == "SuomiLove" || mark.Key == "Terror" || mark.Key.StartsWith("Urchin") || mark.Key.Contains("Mtr") || mark.Key == "PorteSave" || mark.Value.Name.Contains("of Mythril") || mark.Value.Name.Contains("of Hy-brasyl") || mark.Key == "Master" || mark.Value.Name.Contains(" Dedication") || mark.Key == "KeptSecret" || mark.Key == "RevLev" || mark.Key == "Alt" || mark.Key == "TAWins" || mark.Key == "RpC1" || mark.Key.StartsWith("Insect") || mark.Key == "DoneYuleLog" || mark.Key == "ElgAdr" || mark.Key == "VDayL2" || mark.Key == "STroupeLeader" || mark.Key == "SuomiMark2" || mark.Key == "CNbl0" || mark.Key == "CNbl1" || mark.Key == "Pol-3" || mark.Key == "Pol-4" || mark.Key == "PicC3" || mark.Key == "PicC4" || mark.Key == "ManC1" || mark.Key == "ManC2" || mark.Key == "ManC3" || mark.Key == "ManC4" || mark.Key == "ArtC1" || mark.Key == "ArtC2" || mark.Key == "ArtC3" || mark.Key == "ArtC4" || mark.Key == "BioC1" || mark.Key == "BioC2" || mark.Key == "BioC3" || mark.Key == "BioC4" || mark.Key == "LitC1" || mark.Key == "LitC2" || mark.Key == "LitC3" || mark.Key == "LitC4" || mark.Key == "PhiC1" || mark.Key == "PhiC2" || mark.Key == "PhiC3" || mark.Key == "PhiC4" || mark.Key == "HisC1" || mark.Key == "HisC2" || mark.Key == "HisC3" || mark.Key == "HisC4" || mark.Key == "Gld1-3" || mark.Key == "Gld1Ct" || mark.Key == "Gld1-6" || mark.Key == "MotleyCo" || mark.Key == "GuildCo" || mark.Key == "MotleyCt" || mark.Key == "MotleyMa" || mark.Key == "GuildMa" || mark.Key == "Gld1-3rI")
                        listViewItem.ForeColor = Color.Blue;
                      if (mark.Key == "D" || mark.Key == "WedL" || mark.Key == "LoveLr" || mark.Key == "WedLr" || mark.Key == "NecroA" || mark.Value.Name == "Attempting to become (office)" || mark.Key == "SHr" || mark.Key == "Summoned" || mark.Key == "Arrested" || mark.Key == "Law-7I")
                        listViewItem.ForeColor = Color.Brown;
                      if (mark.Key == "TagorMurder" || mark.Key == "AllJ" || mark.Key == "AutoHJ" || mark.Key == "RlgOv" || mark.Key == "Ass" || mark.Key == "GuildE" || mark.Key == "ArenaEx" || mark.Key == "PolN1E" || mark.Key == "PolN2E")
                        listViewItem.ForeColor = Color.DarkOrange;
                      if (mark.Key == "LockyCharms" || mark.Key == "GotPGold8")
                        listViewItem.ForeColor = Color.DarkGreen;
                      if (mark.Key == "LegendaryA")
                        listViewItem.ForeColor = Color.Yellow;
                      if (flag)
                        listViewItem.ForeColor = Color.Gray;
                    }
                  }
                }
              }
            }
          }
        }
      }
      this.listView1.EndUpdate();
      if (this.listView1.Items.Count <= 0)
        return;
      this.listView1.EnsureVisible(this.listView1.Items.Count - 1);
    }

    private void LegendMarks_FormClosing(object sender, FormClosingEventArgs e)
    {
      e.Cancel = true;
      this.Hide();
      this.Client.Tab.legendopen.Enabled = true;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.listView1 = new ListView();
      this.columnHeader1 = new ColumnHeader();
      this.events = new CheckBox();
      this.politics = new CheckBox();
      this.pets = new CheckBox();
      this.arena = new CheckBox();
      this.guild = new CheckBox();
      this.defunct = new CheckBox();
      this.award = new CheckBox();
      this.jails = new CheckBox();
      this.roleplay = new CheckBox();
      this.regular = new CheckBox();
      this.paths = new CheckBox();
      this.SuspendLayout();
      this.listView1.Columns.AddRange(new ColumnHeader[1]
      {
        this.columnHeader1
      });
      this.listView1.Font = new Font("Microsoft Sans Serif", 9.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.listView1.FullRowSelect = true;
      this.listView1.HeaderStyle = ColumnHeaderStyle.None;
      this.listView1.LabelWrap = false;
      this.listView1.Location = new System.Drawing.Point(12, 12);
      this.listView1.MultiSelect = false;
      this.listView1.Name = "listView1";
      this.listView1.Size = new Size(378, 511);
      this.listView1.TabIndex = 0;
      this.listView1.UseCompatibleStateImageBehavior = false;
      this.listView1.View = View.Details;
      this.columnHeader1.Text = "Legend Mark";
      this.columnHeader1.Width = 370;
      this.events.AutoSize = true;
      this.events.Location = new System.Drawing.Point(396, 235);
      this.events.Name = "events";
      this.events.Size = new Size(59, 17);
      this.events.TabIndex = 1;
      this.events.Text = "Events";
      this.events.UseVisualStyleBackColor = true;
      this.events.CheckedChanged += new EventHandler(this.LegendMarks_Load);
      this.politics.AutoSize = true;
      this.politics.Location = new System.Drawing.Point(396, 162);
      this.politics.Name = "politics";
      this.politics.Size = new Size(59, 17);
      this.politics.TabIndex = 2;
      this.politics.Text = "Politics";
      this.politics.UseVisualStyleBackColor = true;
      this.politics.CheckedChanged += new EventHandler(this.LegendMarks_Load);
      this.pets.AutoSize = true;
      this.pets.Location = new System.Drawing.Point(396, 201);
      this.pets.Name = "pets";
      this.pets.Size = new Size(47, 17);
      this.pets.TabIndex = 3;
      this.pets.Text = "Pets";
      this.pets.UseVisualStyleBackColor = true;
      this.pets.CheckedChanged += new EventHandler(this.LegendMarks_Load);
      this.arena.AutoSize = true;
      this.arena.Location = new System.Drawing.Point(396, 87);
      this.arena.Name = "arena";
      this.arena.Size = new Size(54, 17);
      this.arena.TabIndex = 4;
      this.arena.Text = "Arena";
      this.arena.UseVisualStyleBackColor = true;
      this.arena.CheckedChanged += new EventHandler(this.LegendMarks_Load);
      this.guild.AutoSize = true;
      this.guild.Location = new System.Drawing.Point(396, (int) sbyte.MaxValue);
      this.guild.Name = "guild";
      this.guild.Size = new Size(50, 17);
      this.guild.TabIndex = 5;
      this.guild.Text = "Guild";
      this.guild.UseVisualStyleBackColor = true;
      this.guild.CheckedChanged += new EventHandler(this.LegendMarks_Load);
      this.defunct.AutoSize = true;
      this.defunct.Location = new System.Drawing.Point(396, 351);
      this.defunct.Name = "defunct";
      this.defunct.Size = new Size(64, 17);
      this.defunct.TabIndex = 6;
      this.defunct.Text = "Defunct";
      this.defunct.UseVisualStyleBackColor = true;
      this.defunct.CheckedChanged += new EventHandler(this.LegendMarks_Load);
      this.award.AutoSize = true;
      this.award.Location = new System.Drawing.Point(396, 312);
      this.award.Name = "award";
      this.award.Size = new Size(56, 17);
      this.award.TabIndex = 7;
      this.award.Text = "Award";
      this.award.UseVisualStyleBackColor = true;
      this.award.CheckedChanged += new EventHandler(this.LegendMarks_Load);
      this.jails.AutoSize = true;
      this.jails.Location = new System.Drawing.Point(396, 388);
      this.jails.Name = "jails";
      this.jails.Size = new Size(67, 17);
      this.jails.TabIndex = 8;
      this.jails.Text = "Jails etc.";
      this.jails.UseVisualStyleBackColor = true;
      this.jails.CheckedChanged += new EventHandler(this.LegendMarks_Load);
      this.roleplay.AutoSize = true;
      this.roleplay.Location = new System.Drawing.Point(396, 275);
      this.roleplay.Name = "roleplay";
      this.roleplay.Size = new Size(67, 17);
      this.roleplay.TabIndex = 9;
      this.roleplay.Text = "Roleplay";
      this.roleplay.UseVisualStyleBackColor = true;
      this.roleplay.CheckedChanged += new EventHandler(this.LegendMarks_Load);
      this.regular.AutoSize = true;
      this.regular.Location = new System.Drawing.Point(396, 12);
      this.regular.Name = "regular";
      this.regular.Size = new Size(63, 17);
      this.regular.TabIndex = 10;
      this.regular.Text = "General";
      this.regular.UseVisualStyleBackColor = true;
      this.regular.CheckedChanged += new EventHandler(this.LegendMarks_Load);
      this.paths.AutoSize = true;
      this.paths.Location = new System.Drawing.Point(396, 50);
      this.paths.Name = "paths";
      this.paths.Size = new Size(53, 17);
      this.paths.TabIndex = 11;
      this.paths.Text = "Paths";
      this.paths.UseVisualStyleBackColor = true;
      this.paths.CheckedChanged += new EventHandler(this.LegendMarks_Load);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(468, 535);
      this.Controls.Add((Control) this.paths);
      this.Controls.Add((Control) this.regular);
      this.Controls.Add((Control) this.roleplay);
      this.Controls.Add((Control) this.jails);
      this.Controls.Add((Control) this.award);
      this.Controls.Add((Control) this.defunct);
      this.Controls.Add((Control) this.guild);
      this.Controls.Add((Control) this.arena);
      this.Controls.Add((Control) this.pets);
      this.Controls.Add((Control) this.politics);
      this.Controls.Add((Control) this.events);
      this.Controls.Add((Control) this.listView1);
      this.Name =  "LegendMarks";
      this.Text = "LegendMarks";
      this.FormClosing += new FormClosingEventHandler(this.LegendMarks_FormClosing);
      this.Load += new EventHandler(this.LegendMarks_Load);
      this.VisibleChanged += new EventHandler(this.LegendMarks_Load);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
