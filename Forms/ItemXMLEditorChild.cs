//SlowPoke
// Type: Flintstones.ItemXMLEditorChild
//SlowPoke
//SlowPoke
//SlowPoke

using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace Flintstones
{
  public class ItemXMLEditorChild : Form
  {
    private IContainer components;
    private GroupBox groupBox2;
    public TextBox obtainbox;
    private GroupBox groupBox1;
    public TextBox usesbox;
    public TextBox namebox;
    private Label label3;
    public TextBox secondnamebox;
    private Label label2;
    public TextBox imagebox;
    private Label label1;
    private Splitter splitter1;
    public Button saveform;

    public ItemXMLEditorChild() => this.InitializeComponent();

    private void saveform_Click(object sender, EventArgs e)
    {
      string str1 = Program.StartupPath + "\\Settings\\ItemDatabase.xml";
      XmlDocument xmlDocument = new XmlDocument();
      if (File.Exists(str1))
      {
        xmlDocument.Load(str1);
        XmlNode documentElement = (XmlNode) xmlDocument.DocumentElement;
        XmlNode xmlNode1 = (XmlNode) null;
        foreach (XmlNode childNode1 in documentElement.ChildNodes)
        {
          foreach (XmlNode childNode2 in childNode1.ChildNodes)
          {
            if (childNode2.Name == "Name" && childNode2.InnerText.Equals(this.namebox.Text, StringComparison.CurrentCultureIgnoreCase))
            {
              xmlNode1 = childNode1;
              break;
            }
          }
        }
        if (xmlNode1 != null)
        {
          foreach (XmlNode childNode3 in documentElement.ChildNodes)
          {
            if (childNode3 == xmlNode1)
            {
              foreach (XmlNode childNode4 in childNode3.ChildNodes)
              {
                if (childNode4.Name == "SecondName" && childNode4.InnerText == string.Empty)
                  childNode4.InnerText = this.secondnamebox.Text;
                else if (childNode4.Name == "Image")
                  childNode4.InnerText = this.imagebox.Text;
                else if (childNode4.Name == "Usedfor")
                {
                  string[] strArray = this.usesbox.Text.Split('\n');
                  if (strArray.Length != 0)
                  {
                    foreach (string str2 in strArray)
                    {
                      if (str2 != string.Empty && !childNode4.InnerText.Contains(str2))
                      {
                        XmlNode xmlNode2 = childNode4;
                        xmlNode2.InnerText = xmlNode2.InnerText + str2 + Environment.NewLine;
                      }
                    }
                  }
                }
                else if (childNode4.Name == "Obtainedby")
                {
                  string[] strArray = this.obtainbox.Text.Split('\n');
                  if (strArray.Length != 0)
                  {
                    foreach (string str3 in strArray)
                    {
                      if (str3 != string.Empty && !childNode4.InnerText.Contains(str3))
                      {
                        XmlNode xmlNode3 = childNode4;
                        xmlNode3.InnerText = xmlNode3.InnerText + str3 + Environment.NewLine;
                      }
                    }
                  }
                }
              }
              if (Server.ItemDatabase.ContainsKey(this.namebox.Text))
              {
                Server.ItemDatabase[this.namebox.Text].SecondName = this.secondnamebox.Text;
                if (this.imagebox.Text != string.Empty)
                  Server.ItemDatabase[this.namebox.Text].Image = int.Parse(this.imagebox.Text);
                if (this.usesbox.Text.Length > 0)
                {
                  string[] strArray = this.usesbox.Text.Split('\n');
                  if (strArray.Length != 0)
                  {
                    foreach (string str4 in strArray)
                    {
                      if (str4 != string.Empty && !Server.ItemDatabase[this.namebox.Text].Usedfor.Contains(str4))
                        Server.ItemDatabase[this.namebox.Text].Usedfor.Add(str4);
                    }
                  }
                }
                if (this.obtainbox.Text.Length > 0)
                {
                  string[] strArray = this.obtainbox.Text.Split('\n');
                  if (strArray.Length != 0)
                  {
                    foreach (string str5 in strArray)
                    {
                      if (str5 != string.Empty && !Server.ItemDatabase[this.namebox.Text].Obtainedby.Contains(str5))
                        Server.ItemDatabase[this.namebox.Text].Obtainedby.Add(str5);
                    }
                  }
                }
              }
            }
          }
        }
        else
        {
          if (!Server.ItemDatabase.ContainsKey(this.namebox.Text))
          {
            ItemXML itemXml = new ItemXML();
            itemXml.Name = this.namebox.Text;
            itemXml.SecondName = this.secondnamebox.Text;
            if (this.imagebox.Text != string.Empty)
              itemXml.Image = int.Parse(this.imagebox.Text);
            if (this.usesbox.Text.Length > 0)
            {
              string[] strArray = this.usesbox.Text.Split('\n');
              if (strArray.Length != 0)
              {
                foreach (string str6 in strArray)
                {
                  if (str6 != string.Empty && !itemXml.Usedfor.Contains(str6))
                    itemXml.Usedfor.Add(str6);
                }
              }
            }
            if (this.obtainbox.Text.Length > 0)
            {
              string[] strArray = this.obtainbox.Text.Split('\n');
              if (strArray.Length != 0)
              {
                foreach (string str7 in strArray)
                {
                  if (str7 != string.Empty && !itemXml.Obtainedby.Contains(str7))
                    itemXml.Obtainedby.Add(str7);
                }
              }
            }
            Server.ItemDatabase.Add(itemXml.Name, itemXml);
          }
          else
          {
            Server.ItemDatabase[this.namebox.Text].SecondName = this.secondnamebox.Text;
            if (this.imagebox.Text != string.Empty)
              Server.ItemDatabase[this.namebox.Text].Image = int.Parse(this.imagebox.Text);
            if (this.usesbox.Text.Length > 0)
            {
              string[] strArray = this.usesbox.Text.Split('\n');
              if (strArray.Length != 0)
              {
                foreach (string str8 in strArray)
                {
                  if (str8 != string.Empty && !Server.ItemDatabase[this.namebox.Text].Usedfor.Contains(str8))
                    Server.ItemDatabase[this.namebox.Text].Usedfor.Add(str8);
                }
              }
            }
            if (this.obtainbox.Text.Length > 0)
            {
              string[] strArray = this.obtainbox.Text.Split('\n');
              if (strArray.Length != 0)
              {
                foreach (string str9 in strArray)
                {
                  if (str9 != string.Empty && !Server.ItemDatabase[this.namebox.Text].Obtainedby.Contains(str9))
                    Server.ItemDatabase[this.namebox.Text].Obtainedby.Add(str9);
                }
              }
            }
          }
          this.Text = this.namebox.Text;
          XmlNode element1 = (XmlNode) xmlDocument.CreateElement("Item");
          documentElement.AppendChild(element1);
          XmlNode element2 = (XmlNode) xmlDocument.CreateElement("Name");
          element2.InnerText = this.namebox.Text;
          element1.AppendChild(element2);
          XmlNode element3 = (XmlNode) xmlDocument.CreateElement("SecondName");
          element3.InnerText = this.secondnamebox.Text;
          element1.AppendChild(element3);
          XmlNode element4 = (XmlNode) xmlDocument.CreateElement("Image");
          element4.InnerText = this.imagebox.Text;
          element1.AppendChild(element4);
          XmlNode element5 = (XmlNode) xmlDocument.CreateElement("Usedfor");
          element5.InnerText = this.usesbox.Text;
          element1.AppendChild(element5);
          XmlNode element6 = (XmlNode) xmlDocument.CreateElement("Obtainedby");
          element6.InnerText = this.obtainbox.Text;
          element1.AppendChild(element6);
        }
        xmlDocument.Save(str1);
      }
      else
      {
        if (!Server.ItemDatabase.ContainsKey(this.namebox.Text))
        {
          ItemXML itemXml = new ItemXML();
          itemXml.Name = this.namebox.Text;
          itemXml.SecondName = this.secondnamebox.Text;
          if (this.imagebox.Text != string.Empty)
            itemXml.Image = int.Parse(this.imagebox.Text);
          if (this.usesbox.Text.Length > 0)
          {
            string[] strArray = this.usesbox.Text.Split('\n');
            if (strArray.Length != 0)
            {
              foreach (string str10 in strArray)
              {
                if (str10 != string.Empty && !itemXml.Usedfor.Contains(str10))
                  itemXml.Usedfor.Add(str10);
              }
            }
          }
          if (this.obtainbox.Text.Length > 0)
          {
            string[] strArray = this.obtainbox.Text.Split('\n');
            if (strArray.Length != 0)
            {
              foreach (string str11 in strArray)
              {
                if (str11 != string.Empty && !itemXml.Obtainedby.Contains(str11))
                  itemXml.Obtainedby.Add(str11);
              }
            }
          }
          Server.ItemDatabase.Add(itemXml.Name, itemXml);
        }
        else
        {
          Server.ItemDatabase[this.namebox.Text].SecondName = this.secondnamebox.Text;
          if (this.imagebox.Text != string.Empty)
            Server.ItemDatabase[this.namebox.Text].Image = int.Parse(this.imagebox.Text);
          if (this.usesbox.Text.Length > 0)
          {
            string[] strArray = this.usesbox.Text.Split('\n');
            if (strArray.Length != 0)
            {
              foreach (string str12 in strArray)
              {
                if (str12 != string.Empty && !Server.ItemDatabase[this.namebox.Text].Usedfor.Contains(str12))
                  Server.ItemDatabase[this.namebox.Text].Usedfor.Add(str12);
              }
            }
          }
          if (this.obtainbox.Text.Length > 0)
          {
            string[] strArray = this.obtainbox.Text.Split('\n');
            if (strArray.Length != 0)
            {
              foreach (string str13 in strArray)
              {
                if (str13 != string.Empty && !Server.ItemDatabase[this.namebox.Text].Obtainedby.Contains(str13))
                  Server.ItemDatabase[this.namebox.Text].Obtainedby.Add(str13);
              }
            }
          }
        }
        this.Text = this.namebox.Text;
        XmlNode element7 = (XmlNode) xmlDocument.CreateElement("DarkAgesItems");
        xmlDocument.AppendChild(element7);
        XmlNode element8 = (XmlNode) xmlDocument.CreateElement("Item");
        element7.AppendChild(element8);
        XmlNode element9 = (XmlNode) xmlDocument.CreateElement("Name");
        element9.InnerText = this.namebox.Text;
        element8.AppendChild(element9);
        XmlNode element10 = (XmlNode) xmlDocument.CreateElement("SecondName");
        element10.InnerText = this.secondnamebox.Text;
        element8.AppendChild(element10);
        XmlNode element11 = (XmlNode) xmlDocument.CreateElement("Image");
        element11.InnerText = this.imagebox.Text;
        element8.AppendChild(element11);
        XmlNode element12 = (XmlNode) xmlDocument.CreateElement("Usedfor");
        element12.InnerText = this.usesbox.Text;
        element8.AppendChild(element12);
        XmlNode element13 = (XmlNode) xmlDocument.CreateElement("Obtainedby");
        element13.InnerText = this.obtainbox.Text;
        element8.AppendChild(element13);
        xmlDocument.Save(str1);
      }
      this.saveform.Enabled = false;
      this.Close();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.groupBox2 = new GroupBox();
      this.obtainbox = new TextBox();
      this.groupBox1 = new GroupBox();
      this.usesbox = new TextBox();
      this.namebox = new TextBox();
      this.label3 = new Label();
      this.secondnamebox = new TextBox();
      this.label2 = new Label();
      this.imagebox = new TextBox();
      this.label1 = new Label();
      this.splitter1 = new Splitter();
      this.saveform = new Button();
      this.groupBox2.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      this.groupBox2.Controls.Add((Control) this.obtainbox);
      this.groupBox2.Location = new System.Drawing.Point(229, 88);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new Size(318, 266);
      this.groupBox2.TabIndex = 39;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "How to find";
      this.obtainbox.Location = new System.Drawing.Point(6, 19);
      this.obtainbox.Multiline = true;
      this.obtainbox.Name = "obtainbox";
      this.obtainbox.ScrollBars = ScrollBars.Vertical;
      this.obtainbox.Size = new Size(306, 242);
      this.obtainbox.TabIndex = 42;
      this.groupBox1.Controls.Add((Control) this.usesbox);
      this.groupBox1.Location = new System.Drawing.Point(1, 152);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(212, 202);
      this.groupBox1.TabIndex = 38;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Uses";
      this.usesbox.Location = new System.Drawing.Point(6, 19);
      this.usesbox.Multiline = true;
      this.usesbox.Name = "usesbox";
      this.usesbox.ScrollBars = ScrollBars.Vertical;
      this.usesbox.Size = new Size(200, 177);
      this.usesbox.TabIndex = 41;
      this.namebox.Location = new System.Drawing.Point(68, 59);
      this.namebox.Name = "namebox";
      this.namebox.Size = new Size(232, 20);
      this.namebox.TabIndex = 33;
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 62);
      this.label3.Name = "label3";
      this.label3.Size = new Size(35, 13);
      this.label3.TabIndex = 36;
      this.label3.Text = "Name";
      this.secondnamebox.Location = new System.Drawing.Point(68, 85);
      this.secondnamebox.Name = "secondnamebox";
      this.secondnamebox.Size = new Size(145, 20);
      this.secondnamebox.TabIndex = 35;
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 88);
      this.label2.Name = "label2";
      this.label2.Size = new Size(56, 13);
      this.label2.TabIndex = 34;
      this.label2.Text = "2nd Name";
      this.imagebox.Location = new System.Drawing.Point(68, 111);
      this.imagebox.Name = "imagebox";
      this.imagebox.Size = new Size(49, 20);
      this.imagebox.TabIndex = 37;
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 114);
      this.label1.Name = "label1";
      this.label1.Size = new Size(36, 13);
      this.label1.TabIndex = 32;
      this.label1.Text = "Image";
      this.splitter1.BackColor = SystemColors.Control;
      this.splitter1.BorderStyle = BorderStyle.FixedSingle;
      this.splitter1.Cursor = Cursors.Default;
      this.splitter1.Dock = DockStyle.Top;
      this.splitter1.Location = new System.Drawing.Point(0, 0);
      this.splitter1.Name = "splitter1";
      this.splitter1.Size = new Size(552, 43);
      this.splitter1.TabIndex = 40;
      this.splitter1.TabStop = false;
      this.saveform.Location = new System.Drawing.Point(209, 0);
      this.saveform.Name = "saveform";
      this.saveform.Size = new Size(122, 43);
      this.saveform.TabIndex = 43;
      this.saveform.Text = "Save";
      this.saveform.UseVisualStyleBackColor = true;
      this.saveform.Click += new EventHandler(this.saveform_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(552, 360);
      this.Controls.Add((Control) this.saveform);
      this.Controls.Add((Control) this.splitter1);
      this.Controls.Add((Control) this.groupBox2);
      this.Controls.Add((Control) this.groupBox1);
      this.Controls.Add((Control) this.namebox);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.secondnamebox);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.imagebox);
      this.Controls.Add((Control) this.label1);
      this.Name =  "ItemXMLEditorChild";
      this.Text = "*";
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
