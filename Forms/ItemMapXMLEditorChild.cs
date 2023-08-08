//SlowPoke
// Type: Flintstones.ItemMapXMLEditorChild
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
  public class ItemMapXMLEditorChild : Form
  {
    private IContainer components;
    private GroupBox groupBox2;
    private Splitter splitter1;
    public Button saveform;
    public Label mapnumber;
    public Label mapname;
    public ListView monsterlist;
    private ColumnHeader columnHeader1;
    private ColumnHeader columnHeader2;
    private GroupBox groupBox1;
    private ColumnHeader columnHeader3;
    private ColumnHeader columnHeader4;
    public ListView itemlist;
    private GroupBox groupBox3;
    private ColumnHeader columnHeader5;
    public Button closebtn;
    public ListView goldlist;
    public Label charname;

    public ItemMapXMLEditorChild() => this.InitializeComponent();

    public void Save(string name, bool allfive = false)
    {
      if (!(this.charname.Text != string.Empty) || !(name == this.charname.Text))
        return;
      string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\DaItemDB\\";
      if (!Directory.Exists(path))
        Directory.CreateDirectory(path);
      XmlDocument xmlDocument = new XmlDocument();
      string str = path + "maps.xml";
      if (allfive)
        str = path + "mapsallfive.xml";
      string text = this.Text;
      bool flag1 = false;
      ItemMapXML itemMapXml = Server.ItemMapDatabase[text];
      if (!File.Exists(str))
      {
        XmlNode element = (XmlNode) xmlDocument.CreateElement("DarkAgesMaps");
        xmlDocument.AppendChild(element);
        xmlDocument.Save(str);
      }
      if (File.Exists(str))
      {
        xmlDocument.Load(str);
        XmlNode documentElement = (XmlNode) xmlDocument.DocumentElement;
        foreach (XmlNode childNode1 in documentElement.ChildNodes)
        {
          foreach (XmlNode childNode2 in childNode1.ChildNodes)
          {
            if (childNode2.Name == "MapName" && childNode2.InnerText == text)
            {
              foreach (string key1 in itemMapXml.Monsters.Keys)
              {
                bool flag2 = false;
                ItemMonsterXML monster = itemMapXml.Monsters[key1];
                foreach (XmlNode childNode3 in childNode1.ChildNodes)
                {
                  foreach (XmlNode childNode4 in childNode3.ChildNodes)
                  {
                    if (childNode4.Name == "MonsterName" && childNode4.InnerText == key1)
                    {
                      foreach (XmlNode childNode5 in childNode3.ChildNodes)
                      {
                        if (childNode5.Name == "KillCount")
                          childNode5.InnerText = (uint.Parse(childNode5.InnerText) + monster.KillCount).ToString();
                      }
                      foreach (string goldAmount in monster.GoldAmounts)
                      {
                        bool flag3 = false;
                        foreach (XmlNode childNode6 in childNode3.ChildNodes)
                        {
                          if (childNode6.Name == "GoldAmounts")
                          {
                            foreach (XmlNode childNode7 in childNode6.ChildNodes)
                            {
                              if (childNode7.Name == "Gold" && childNode7.InnerText == goldAmount)
                              {
                                flag3 = true;
                                break;
                              }
                            }
                            if (!flag3)
                            {
                              XmlNode element = (XmlNode) xmlDocument.CreateElement("Gold");
                              element.InnerText = goldAmount;
                              childNode6.AppendChild(element);
                            }
                          }
                          if (flag3)
                            break;
                        }
                      }
                      foreach (string key2 in monster.Drops.Keys)
                      {
                        bool flag4 = false;
                        Item2XML drop = monster.Drops[key2];
                        foreach (XmlNode childNode8 in childNode3.ChildNodes)
                        {
                          foreach (XmlNode childNode9 in childNode8.ChildNodes)
                          {
                            if (childNode9.Name == "ItemName" && childNode9.InnerText == key2)
                            {
                              foreach (XmlNode childNode10 in childNode8.ChildNodes)
                              {
                                if (childNode10.Name == "DropCount")
                                  childNode10.InnerText = (uint.Parse(childNode10.InnerText) + drop.DropCount).ToString();
                                else if (childNode10.Name == "SecondName" && childNode10.InnerText == string.Empty)
                                  childNode10.InnerText = drop.SecondName;
                              }
                              flag4 = true;
                              break;
                            }
                          }
                          if (flag4)
                            break;
                        }
                        if (!flag4)
                        {
                          XmlNode element1 = (XmlNode) xmlDocument.CreateElement("Item");
                          childNode3.AppendChild(element1);
                          XmlNode element2 = (XmlNode) xmlDocument.CreateElement("ItemName");
                          element2.InnerText = key2;
                          element1.AppendChild(element2);
                          XmlNode element3 = (XmlNode) xmlDocument.CreateElement("SecondName");
                          element3.InnerText = drop.SecondName;
                          element1.AppendChild(element3);
                          XmlNode element4 = (XmlNode) xmlDocument.CreateElement("DropCount");
                          element4.InnerText = drop.DropCount.ToString();
                          element1.AppendChild(element4);
                        }
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
                  XmlNode element5 = (XmlNode) xmlDocument.CreateElement("Monster");
                  childNode1.AppendChild(element5);
                  XmlNode element6 = (XmlNode) xmlDocument.CreateElement("MonsterName");
                  element6.InnerText = key1;
                  element5.AppendChild(element6);
                  XmlNode element7 = (XmlNode) xmlDocument.CreateElement("KillCount");
                  element7.InnerText = monster.KillCount.ToString();
                  element5.AppendChild(element7);
                  XmlNode element8 = (XmlNode) xmlDocument.CreateElement("GoldAmounts");
                  element5.AppendChild(element8);
                  foreach (string goldAmount in monster.GoldAmounts)
                  {
                    XmlNode element9 = (XmlNode) xmlDocument.CreateElement("Gold");
                    element9.InnerText = goldAmount;
                    element8.AppendChild(element9);
                  }
                  foreach (string key3 in monster.Drops.Keys)
                  {
                    Item2XML drop = monster.Drops[key3];
                    XmlNode element10 = (XmlNode) xmlDocument.CreateElement("Item");
                    element5.AppendChild(element10);
                    XmlNode element11 = (XmlNode) xmlDocument.CreateElement("ItemName");
                    element11.InnerText = key3;
                    element10.AppendChild(element11);
                    XmlNode element12 = (XmlNode) xmlDocument.CreateElement("SecondName");
                    element12.InnerText = drop.SecondName;
                    element10.AppendChild(element12);
                    XmlNode element13 = (XmlNode) xmlDocument.CreateElement("DropCount");
                    element13.InnerText = drop.DropCount.ToString();
                    element10.AppendChild(element13);
                  }
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
          XmlNode element14 = (XmlNode) xmlDocument.CreateElement("Map");
          documentElement.AppendChild(element14);
          XmlNode element15 = (XmlNode) xmlDocument.CreateElement("MapName");
          element15.InnerText = text;
          element14.AppendChild(element15);
          foreach (string key4 in itemMapXml.Monsters.Keys)
          {
            ItemMonsterXML monster = itemMapXml.Monsters[key4];
            XmlNode element16 = (XmlNode) xmlDocument.CreateElement("Monster");
            element14.AppendChild(element16);
            XmlNode element17 = (XmlNode) xmlDocument.CreateElement("MonsterName");
            element17.InnerText = key4;
            element16.AppendChild(element17);
            XmlNode element18 = (XmlNode) xmlDocument.CreateElement("KillCount");
            element18.InnerText = monster.KillCount.ToString();
            element16.AppendChild(element18);
            XmlNode element19 = (XmlNode) xmlDocument.CreateElement("GoldAmounts");
            element16.AppendChild(element19);
            foreach (string goldAmount in monster.GoldAmounts)
            {
              XmlNode element20 = (XmlNode) xmlDocument.CreateElement("Gold");
              element20.InnerText = goldAmount;
              element19.AppendChild(element20);
            }
            foreach (string key5 in monster.Drops.Keys)
            {
              Item2XML drop = monster.Drops[key5];
              XmlNode element21 = (XmlNode) xmlDocument.CreateElement("Item");
              element16.AppendChild(element21);
              XmlNode element22 = (XmlNode) xmlDocument.CreateElement("ItemName");
              element22.InnerText = key5;
              element21.AppendChild(element22);
              XmlNode element23 = (XmlNode) xmlDocument.CreateElement("SecondName");
              element23.InnerText = drop.SecondName;
              element21.AppendChild(element23);
              XmlNode element24 = (XmlNode) xmlDocument.CreateElement("DropCount");
              element24.InnerText = drop.DropCount.ToString();
              element21.AppendChild(element24);
            }
          }
        }
        xmlDocument.Save(str);
      }
      Server.ItemMapDatabase.Remove(text);
      this.Close();
      if (!Program.MainForm.ItemXMLEditor.HasChildren)
        return;
      foreach (Form mdiChild in Program.MainForm.ItemXMLEditor.MdiChildren)
      {
        if (mdiChild != null && mdiChild.Text != text)
          mdiChild.Refresh();
      }
    }

    private void saveform_Click(object sender, EventArgs e)
    {
      if (!(this.charname.Text != string.Empty))
        return;
      this.Save(this.charname.Text);
    }

    private void monsterlist_SelectedIndexChanged(object sender, EventArgs e)
    {
      string mapkey = this.Text;
      if (this.monsterlist.SelectedItems.Count != 1)
        return;
      this.goldlist.Items.Clear();
      this.itemlist.Items.Clear();
      if (!Server.ItemMapDatabase.ContainsKey(mapkey))
        return;
      Program.MainForm.BeginInvoke((Action) (() => Program.MainForm.ItemXMLEditor.UpdateMapForm(Server.ItemMapDatabase[mapkey], (string) null)));
    }

    private void closebtn_Click(object sender, EventArgs e)
    {
      Server.ItemMapDatabase.Remove(this.Text);
      this.Close();
    }

    private void ItemMapXMLEditorChild_FormClosing(object sender, FormClosingEventArgs e)
    {
      Server.ItemMapDatabase.Remove(this.Text);
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
      this.monsterlist = new ListView();
      this.columnHeader1 = new ColumnHeader();
      this.columnHeader2 = new ColumnHeader();
      this.splitter1 = new Splitter();
      this.saveform = new Button();
      this.mapnumber = new Label();
      this.mapname = new Label();
      this.groupBox1 = new GroupBox();
      this.itemlist = new ListView();
      this.columnHeader3 = new ColumnHeader();
      this.columnHeader4 = new ColumnHeader();
      this.groupBox3 = new GroupBox();
      this.goldlist = new ListView();
      this.columnHeader5 = new ColumnHeader();
      this.closebtn = new Button();
      this.charname = new Label();
      this.groupBox2.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.SuspendLayout();
      this.groupBox2.Controls.Add((Control) this.monsterlist);
      this.groupBox2.Location = new System.Drawing.Point(12, 121);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new Size(219, 266);
      this.groupBox2.TabIndex = 39;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Monster";
      this.monsterlist.Columns.AddRange(new ColumnHeader[2]
      {
        this.columnHeader1,
        this.columnHeader2
      });
      this.monsterlist.FullRowSelect = true;
      this.monsterlist.Location = new System.Drawing.Point(6, 19);
      this.monsterlist.MultiSelect = false;
      this.monsterlist.Name = "monsterlist";
      this.monsterlist.Size = new Size(207, 241);
      this.monsterlist.TabIndex = 0;
      this.monsterlist.UseCompatibleStateImageBehavior = false;
      this.monsterlist.View = View.Details;
      this.monsterlist.SelectedIndexChanged += new EventHandler(this.monsterlist_SelectedIndexChanged);
      this.columnHeader1.Text = "Image/Name";
      this.columnHeader1.Width = 132;
      this.columnHeader2.Text = "Kill Count";
      this.columnHeader2.TextAlign = HorizontalAlignment.Center;
      this.columnHeader2.Width = 70;
      this.splitter1.BackColor = SystemColors.Control;
      this.splitter1.BorderStyle = BorderStyle.FixedSingle;
      this.splitter1.Cursor = Cursors.Default;
      this.splitter1.Dock = DockStyle.Top;
      this.splitter1.Location = new System.Drawing.Point(0, 0);
      this.splitter1.Name = "splitter1";
      this.splitter1.Size = new Size(613, 43);
      this.splitter1.TabIndex = 40;
      this.splitter1.TabStop = false;
      this.saveform.Location = new System.Drawing.Point(123, 0);
      this.saveform.Name = "saveform";
      this.saveform.Size = new Size(122, 43);
      this.saveform.TabIndex = 43;
      this.saveform.Text = "Save";
      this.saveform.UseVisualStyleBackColor = true;
      this.saveform.Click += new EventHandler(this.saveform_Click);
      this.mapnumber.AutoSize = true;
      this.mapnumber.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.mapnumber.Location = new System.Drawing.Point(41, 89);
      this.mapnumber.Name = "mapnumber";
      this.mapnumber.Size = new Size(51, 17);
      this.mapnumber.TabIndex = 44;
      this.mapnumber.Text = "Map #:";
      this.mapname.AutoSize = true;
      this.mapname.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.mapname.Location = new System.Drawing.Point(12, 61);
      this.mapname.Name = "mapname";
      this.mapname.Size = new Size(80, 17);
      this.mapname.TabIndex = 45;
      this.mapname.Text = "Map Name:";
      this.groupBox1.Controls.Add((Control) this.itemlist);
      this.groupBox1.Location = new System.Drawing.Point(237, 121);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(250, 266);
      this.groupBox1.TabIndex = 46;
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
      this.itemlist.Size = new Size(238, 241);
      this.itemlist.TabIndex = 0;
      this.itemlist.UseCompatibleStateImageBehavior = false;
      this.itemlist.View = View.Details;
      this.columnHeader3.Text = "Image/Name";
      this.columnHeader3.Width = 162;
      this.columnHeader4.Text = "Drop Count";
      this.columnHeader4.TextAlign = HorizontalAlignment.Center;
      this.columnHeader4.Width = 70;
      this.groupBox3.Controls.Add((Control) this.goldlist);
      this.groupBox3.Location = new System.Drawing.Point(493, 121);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new Size(108, 266);
      this.groupBox3.TabIndex = 47;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Gold";
      this.goldlist.Columns.AddRange(new ColumnHeader[1]
      {
        this.columnHeader5
      });
      this.goldlist.FullRowSelect = true;
      this.goldlist.Location = new System.Drawing.Point(6, 19);
      this.goldlist.MultiSelect = false;
      this.goldlist.Name = "goldlist";
      this.goldlist.Size = new Size(96, 241);
      this.goldlist.TabIndex = 0;
      this.goldlist.UseCompatibleStateImageBehavior = false;
      this.goldlist.View = View.Details;
      this.columnHeader5.Text = "Gold Amounts";
      this.columnHeader5.Width = 90;
      this.closebtn.Location = new System.Drawing.Point(365, 0);
      this.closebtn.Name = "closebtn";
      this.closebtn.Size = new Size(122, 43);
      this.closebtn.TabIndex = 48;
      this.closebtn.Text = "Close";
      this.closebtn.UseVisualStyleBackColor = true;
      this.closebtn.Click += new EventHandler(this.closebtn_Click);
      this.charname.AutoSize = true;
      this.charname.Location = new System.Drawing.Point(446, 63);
      this.charname.Name = "charname";
      this.charname.Size = new Size(0, 13);
      this.charname.TabIndex = 49;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(613, 394);
      this.Controls.Add((Control) this.charname);
      this.Controls.Add((Control) this.closebtn);
      this.Controls.Add((Control) this.groupBox3);
      this.Controls.Add((Control) this.groupBox1);
      this.Controls.Add((Control) this.mapname);
      this.Controls.Add((Control) this.mapnumber);
      this.Controls.Add((Control) this.saveform);
      this.Controls.Add((Control) this.splitter1);
      this.Controls.Add((Control) this.groupBox2);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.MaximizeBox = false;
      this.Name =  "ItemMapXMLEditorChild";
      this.Text = "name";
      this.FormClosing += new FormClosingEventHandler(this.ItemMapXMLEditorChild_FormClosing);
      this.groupBox2.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      this.groupBox3.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
