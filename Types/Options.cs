//SlowPoke
// Type: Flintstones.Options
//SlowPoke
//SlowPoke
//SlowPoke

using System;
using System.IO;
using System.Xml.Linq;

namespace Flintstones
{
  public static class Options
  {
    public static string DarkAgesFileName { get; set; }

    public static string DarkAgesDirectoryName { get; set; }

    public static string DarkAgesMapsDirectoryName { get; set; }

    public static string FullDarkAgesPath => Path.Combine(Options.DarkAgesDirectoryName, Options.DarkAgesFileName);

    public static void Save()
    {
      XDocument xdocument = new XDocument();
      xdocument.Add((object) new XElement((XName) "Settings"));
      xdocument.Element((XName) "Settings").Add((object) new XElement((XName) "DarkAgesFileName", (object) Options.DarkAgesFileName));
      xdocument.Element((XName) "Settings").Add((object) new XElement((XName) "DarkAgesDirectory", (object) Options.DarkAgesDirectoryName));
      if (Directory.Exists(Program.StartupPath + "\\Settings"))
      {
        xdocument.Save(Program.StartupPath + "\\Settings\\settings.xml");
      }
      else
      {
        Directory.CreateDirectory(Program.StartupPath + "\\Settings");
        xdocument.Save(Program.StartupPath + "\\Settings\\settings.xml");
      }
      string str1 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\VirtualStore";
      string str2 = Options.DarkAgesDirectoryName + "\\maps";
      string path = Options.DarkAgesDirectoryName.Replace("C:\\Program Files", str1 + "\\Program Files") + "\\maps";
      Options.DarkAgesMapsDirectoryName = Directory.Exists(path) ? path : str2;
    }

    public static void Load()
    {
      Options.DarkAgesFileName = "Darkages.exe";
      Options.DarkAgesDirectoryName = "C:\\Program Files\\KRU\\Dark Ages";
      if (Directory.Exists("C:\\Program Files (x86)\\KRU"))
        Options.DarkAgesDirectoryName = "C:\\Program Files (x86)\\KRU\\Dark Ages";
      if (!Directory.Exists(Program.StartupPath + "\\Settings") || !File.Exists(Program.StartupPath + "\\Settings\\settings.xml"))
        return;
      XDocument xdocument = XDocument.Load(Program.StartupPath + "\\Settings\\settings.xml");
      if (xdocument.Element((XName) "Settings") == null)
        return;
      if (xdocument.Element((XName) "Settings").Element((XName) "DarkAgesFileName") != null)
        Options.DarkAgesFileName = xdocument.Element((XName) "Settings").Element((XName) "DarkAgesFileName").Value;
      if (xdocument.Element((XName) "Settings").Element((XName) "DarkAgesDirectory") == null)
        return;
      Options.DarkAgesDirectoryName = xdocument.Element((XName) "Settings").Element((XName) "DarkAgesDirectory").Value;
    }
  }
}
