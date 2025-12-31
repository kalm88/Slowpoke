using Flintstones;
using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Flintstones
{
    /// <summary>
    /// Provides static properties and methods for managing generic application settings.
    /// </summary>
    /// <remarks>The Options class centralizes configuration for file paths and directories used by the
    /// application, including loading and saving these settings to disk. All members are static and thread safety is not
    /// guaranteed. Use the Save and Load methods to persist or restore settings as needed.</remarks>
    public static class Options
    {
        public static string FullSettingsPath { get; private set; }
        public static string DarkAgesFileName { get; set; }
        public static string DarkAgesDirectoryName { get; set; }
        public static string DarkAgesMapsDirectoryName { get; private set; }
        public static string FullDarkAgesPath => Path.Combine(Options.DarkAgesDirectoryName, Options.DarkAgesFileName);
        public static bool HasForceGroup { get; set; }
        public static string ForceGroupName { get; set; }
        public static bool PreplayEnabled { get; set; }

        /// <summary>
        /// Initializes application options and settings to their default values, ensuring required directories and
        /// configuration files are present.
        /// </summary>
        /// <remarks>This method should be called at application startup to configure paths and settings
        /// before other components access them. If the expected game files are not found at their default locations, a
        /// notification is displayed to the user. The method also accounts for Windows VirtualStore redirection when
        /// determining the maps directory.</remarks>
        public static void Initialize()
        {
            // Set default values
            DarkAgesFileName = "Darkages.exe";
            DarkAgesDirectoryName = "C:\\Program Files (x86)\\KRU\\Dark Ages";

            // Ensure the Settings directory exists
            if (!Directory.Exists(Program.StartupPath + "\\Settings"))
            {
                Directory.CreateDirectory(Program.StartupPath + "\\Settings");
            }
            FullSettingsPath = Program.StartupPath + "\\Settings\\settings.xml";


            // Determine the correct maps directory, accounting for VirtualStore redirection on Windows
            string str1 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\VirtualStore";
            string str2 = DarkAgesDirectoryName + "\\maps";
            string path = DarkAgesDirectoryName.Replace("C:\\Program Files", str1 + "\\Program Files") + "\\maps";
            Options.DarkAgesMapsDirectoryName = Directory.Exists(path) ? path : str2;

            HasForceGroup = false;
            ForceGroupName = "";
            PreplayEnabled = false;

            if (File.Exists(FullSettingsPath))
                Load();

            // If Dark Ages not at expected location, alert user
            if (!File.Exists(FullDarkAgesPath))
            {
                MessageBox.Show("Darkages not at expected location, please check \"options => Choose DA path\"", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        /// <summary>
        /// Saves the current application settings to settings.xml in the applications settings directory.
        /// </summary>
        /// <remarks>If the settings file cannot be saved due to an error, a message box is displayed to
        /// inform the user. This method does not throw exceptions for file I/O errors; instead, errors are reported via
        /// the user interface.</remarks>
        public static void Save()
        {
            XDocument xdocument = new XDocument(
                new XElement("Settings",
                    new XElement("DarkAgesFileName", DarkAgesFileName),
                    new XElement("DarkAgesDirectory", DarkAgesDirectoryName),
                    new XElement("HasForceGroup", HasForceGroup),
                    new XElement("ForceGroupName", ForceGroupName),
                    new XElement("PrePlayEnabled", PreplayEnabled)
                )
            );

            try
            {
                // Save settings to settings.xml file
                xdocument.Save(FullSettingsPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not save setting.xml file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Loads application settings from settings.xml in the applications settings directory.
        /// </summary>
        /// <remarks>If the settings file or required elements are missing, the method does not modify any
        /// options. If an error occurs while loading the file, an informational message is displayed to the user. This
        /// method does not throw exceptions for file access or XML parsing errors.</remarks>
        public static void Load()
        {
            string el;

            try
            {
                XDocument xdocument = XDocument.Load(FullSettingsPath);

                // If settings elements exist, load their values
                el = (string)(xdocument.Root?.Element("DarkAgesFileName"));
                if (el != null)
                    DarkAgesFileName = el;

                el = (string)(xdocument.Root?.Element("DarkAgesDirectory"));
                if (el != null)
                    DarkAgesDirectoryName = el;

                // Make explicit false when not existing
                HasForceGroup = (bool?)(xdocument.Root?.Element("HasForceGroup")) ?? false;

                el = (string)(xdocument.Root?.Element("ForceGroupName"));
                if (el != null)
                    ForceGroupName = el;

                // Make explicit false when not existing
                PreplayEnabled = (bool?)(xdocument.Root?.Element("PrePlayEnabled")) ?? false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load setting.xml file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
