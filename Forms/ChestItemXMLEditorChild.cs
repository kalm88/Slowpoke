//SlowPoke
// Type: Flintstones.ChestItemXMLEditorChild
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
  public class ChestItemXMLEditorChild : Form
  {
    private IContainer components;
    public Button closebtn;
    public Button saveform;
    private Splitter splitter1;
    private GroupBox groupBox1;
    public ListView itemlist;
    private ColumnHeader columnHeader3;
    private ColumnHeader columnHeader4;
    private GroupBox groupBox2;
    public ListView monsterlist;
    private ColumnHeader columnHeader1;
    private ColumnHeader columnHeader2;
    private Label label1;
    public Label totallab;

    public ChestItemXMLEditorChild() => this.InitializeComponent();

    private void saveform_Click(object sender, EventArgs e)
    {
      string path = Program.StartupPath + "\\Settings\\ItemDatabase\\";
      if (!Directory.Exists(path))
        Directory.CreateDirectory(path);
      XmlDocument xmlDocument = new XmlDocument();
      string str = path + "treasurechests.xml";
      if (!File.Exists(str))
      {
        XmlNode element = (XmlNode) xmlDocument.CreateElement("TreasureChests");
        xmlDocument.AppendChild(element);
        xmlDocument.Save(str);
      }
      if (File.Exists(str))
      {
        xmlDocument.Load(str);
        XmlNode documentElement = (XmlNode) xmlDocument.DocumentElement;
        documentElement.RemoveAll();
        foreach (string key1 in Server.ChestDatabase.Keys)
        {
          bool flag1 = false;
          foreach (XmlNode childNode1 in documentElement.ChildNodes)
          {
            foreach (XmlNode childNode2 in childNode1.ChildNodes)
            {
              if (childNode2.Name == "ChestName" && childNode2.InnerText == key1)
              {
                foreach (XmlNode childNode3 in childNode1.ChildNodes)
                {
                  if (childNode3.Name == "Opened")
                    childNode3.InnerText = Server.ChestDatabase[key1].OpenedCount.ToString();
                }
                foreach (string key2 in Server.ChestDatabase[key1].Treasure.Keys)
                {
                  bool flag2 = false;
                  foreach (XmlNode childNode4 in childNode1.ChildNodes)
                  {
                    foreach (XmlNode childNode5 in childNode4.ChildNodes)
                    {
                      if (childNode5.Name == "ItemName" && childNode5.InnerText == key2)
                      {
                        foreach (XmlNode childNode6 in childNode4.ChildNodes)
                        {
                          if (childNode6.Name == "DropCount")
                            childNode6.InnerText = Server.ChestDatabase[key1].Treasure[key2].ToString();
                        }
                        flag2 = true;
                        break;
                      }
                    }
                    if (flag2)
                      break;
                  }
                  if (!flag2)
                  {
                    XmlNode element1 = (XmlNode) xmlDocument.CreateElement("Item");
                    childNode1.AppendChild(element1);
                    XmlNode element2 = (XmlNode) xmlDocument.CreateElement("ItemName");
                    element2.InnerText = key2;
                    element1.AppendChild(element2);
                    XmlNode element3 = (XmlNode) xmlDocument.CreateElement("DropCount");
                    element3.InnerText = Server.ChestDatabase[key1].Treasure[key2].ToString();
                    element1.AppendChild(element3);
                  }
                }
                flag1 = true;
                break;
              }
            }
            if (flag1)
              break;
          }
          if (!flag1)
          {
            foreach (string key3 in Server.ChestDatabase.Keys)
            {
              XmlNode element4 = (XmlNode) xmlDocument.CreateElement("Chest");
              documentElement.AppendChild(element4);
              XmlNode element5 = (XmlNode) xmlDocument.CreateElement("ChestName");
              element5.InnerText = key3;
              element4.AppendChild(element5);
              XmlNode element6 = (XmlNode) xmlDocument.CreateElement("Opened");
              element6.InnerText = Server.ChestDatabase[key3].OpenedCount.ToString();
              element4.AppendChild(element6);
              foreach (string key4 in Server.ChestDatabase[key3].Treasure.Keys)
              {
                XmlNode element7 = (XmlNode) xmlDocument.CreateElement("Item");
                element4.AppendChild(element7);
                XmlNode element8 = (XmlNode) xmlDocument.CreateElement("ItemName");
                element8.InnerText = key4;
                element7.AppendChild(element8);
                XmlNode element9 = (XmlNode) xmlDocument.CreateElement("DropCount");
                element9.InnerText = Server.ChestDatabase[key3].Treasure[key4].ToString();
                element7.AppendChild(element9);
              }
            }
          }
        }
        xmlDocument.Save(str);
      }
      this.Close();
      if (!Program.MainForm.ItemXMLEditor.HasChildren)
        return;
      foreach (Form mdiChild in Program.MainForm.ItemXMLEditor.MdiChildren)
      {
        if (mdiChild != null && mdiChild.Text != "Treasure Chests")
          mdiChild.Refresh();
      }
    }

    private void closebtn_Click(object sender, EventArgs e) => this.Close();

    private void monsterlist_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.monsterlist.SelectedItems.Count != 1)
        return;
      this.itemlist.Items.Clear();
      this.totallab.Text = "Total:";
      if (!Server.ChestDatabase.ContainsKey(this.monsterlist.SelectedItems[0].Text))
        return;
      Program.MainForm.BeginInvoke((Action) (() => Program.MainForm.ItemXMLEditor.UpdateChestsForm()));
    }

    private void ChestItemXMLEditorChild_FormClosing(object sender, FormClosingEventArgs e)
    {

    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.closebtn = new Button();
      this.saveform = new Button();
      this.splitter1 = new Splitter();
      this.groupBox1 = new GroupBox();
      this.itemlist = new ListView();
      this.columnHeader3 = new ColumnHeader();
      this.columnHeader4 = new ColumnHeader();
      this.groupBox2 = new GroupBox();
      this.monsterlist = new ListView();
      this.columnHeader1 = new ColumnHeader();
      this.columnHeader2 = new ColumnHeader();
      this.label1 = new Label();
      this.totallab = new Label();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      this.closebtn.Location = new System.Drawing.Point(268, 0);
      this.closebtn.Name = "closebtn";
      this.closebtn.Size = new Size(122, 43);
      this.closebtn.TabIndex = 53;
      this.closebtn.Text = "Close";
      this.closebtn.UseVisualStyleBackColor = true;
      this.closebtn.Click += new EventHandler(this.closebtn_Click);
      this.saveform.Location = new System.Drawing.Point(79, 0);
      this.saveform.Name = "saveform";
      this.saveform.Size = new Size(122, 43);
      this.saveform.TabIndex = 51;
      this.saveform.Text = "Save";
      this.saveform.UseVisualStyleBackColor = true;
      this.saveform.Click += new EventHandler(this.saveform_Click);
      this.splitter1.BackColor = SystemColors.Control;
      this.splitter1.BorderStyle = BorderStyle.FixedSingle;
      this.splitter1.Cursor = Cursors.Default;
      this.splitter1.Dock = DockStyle.Top;
      this.splitter1.Location = new System.Drawing.Point(0, 0);
      this.splitter1.Name = "splitter1";
      this.splitter1.Size = new Size(483, 43);
      this.splitter1.TabIndex = 50;
      this.splitter1.TabStop = false;
      this.groupBox1.Controls.Add((Control) this.itemlist);
      this.groupBox1.Location = new System.Drawing.Point(240, 69);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(231, 437);
      this.groupBox1.TabIndex = 55;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Items";
      this.itemlist.Columns.AddRange(new ColumnHeader[2]
      {
        this.columnHeader3,
        this.columnHeader4
      });
      this.itemlist.FullRowSelect = true;
      this.itemlist.Location = new System.Drawing.Point(6, 19);
      this.itemlist.MultiSelect = false;
      this.itemlist.Name = "itemlist";
      this.itemlist.Size = new Size(222, 412);
      this.itemlist.TabIndex = 0;
      this.itemlist.UseCompatibleStateImageBehavior = false;
      this.itemlist.View = View.Details;
      this.columnHeader3.Text = "Name";
      this.columnHeader3.Width = 157;
      this.columnHeader4.Text = "Count";
      this.columnHeader4.TextAlign = HorizontalAlignment.Center;
      this.columnHeader4.Width = 47;
      this.groupBox2.Controls.Add((Control) this.monsterlist);
      this.groupBox2.Location = new System.Drawing.Point(4, 69);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new Size(230, 437);
      this.groupBox2.TabIndex = 54;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Treasure Chest";
      this.monsterlist.Columns.AddRange(new ColumnHeader[2]
      {
        this.columnHeader1,
        this.columnHeader2
      });
      this.monsterlist.FullRowSelect = true;
      this.monsterlist.Location = new System.Drawing.Point(8, 19);
      this.monsterlist.MultiSelect = false;
      this.monsterlist.Name = "monsterlist";
      this.monsterlist.Size = new Size(216, 412);
      this.monsterlist.TabIndex = 0;
      this.monsterlist.UseCompatibleStateImageBehavior = false;
      this.monsterlist.View = View.Details;
      this.monsterlist.SelectedIndexChanged += new EventHandler(this.monsterlist_SelectedIndexChanged);
      this.columnHeader1.Text = "Name";
      this.columnHeader1.Width = 152;
      this.columnHeader2.Text = "Count";
      this.columnHeader2.TextAlign = HorizontalAlignment.Center;
      this.columnHeader2.Width = 48;
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label1.Location = new System.Drawing.Point(175, 46);
      this.label1.Name = "label1";
      this.label1.Size = new Size(126, 20);
      this.label1.TabIndex = 56;
      this.label1.Text = "Treasure Chests";
      this.totallab.AutoSize = true;
      this.totallab.Location = new System.Drawing.Point(373, 60);
      this.totallab.Name = "totallab";
      this.totallab.Size = new Size(34, 13);
      this.totallab.TabIndex = 57;
      this.totallab.Text = "Total:";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(483, 507);
      this.Controls.Add((Control) this.totallab);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.groupBox1);
      this.Controls.Add((Control) this.groupBox2);
      this.Controls.Add((Control) this.closebtn);
      this.Controls.Add((Control) this.saveform);
      this.Controls.Add((Control) this.splitter1);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.MaximizeBox = false;
      this.Name =  "ChestItemXMLEditorChild";
      this.Text = "Treasure Chests";
      this.FormClosing += new FormClosingEventHandler(this.ChestItemXMLEditorChild_FormClosing);
      this.groupBox1.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
