//SlowPoke
// Type: Flintstones.ItemXMLEditor
//SlowPoke
//SlowPoke
//SlowPoke

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Flintstones
{
  public class ItemXMLEditor : Form
  {
    public MainForm Mainy;
    public Timer label1timer;
    private IContainer components;
    private Button newform;
    private Button loadform;
    private Splitter splitter1;
    public TextBox itemnametextbox;
    public Label label1;

    public ItemXMLEditor(MainForm main)
    {
      this.Mainy = main;
      this.InitializeComponent();
      this.label1timer = new Timer();
      this.label1timer.Interval = 3000;
      this.label1timer.Tick += new EventHandler(this.label1Tick);
      this.LayoutMdi(MdiLayout.Cascade);
    }

    private void label1Tick(object sender, EventArgs e)
    {
      this.label1.Visible = false;
      this.label1timer.Stop();
    }

    private void newform_Click(object sender, EventArgs e) => this.UpdateChestsForm();

    private void loadform_Click(object sender, EventArgs e)
    {
      this.LoadForm();
      this.itemnametextbox.Focus();
    }

    public void LoadForm()
    {
      if (!(this.itemnametextbox.Text != string.Empty) || !(this.itemnametextbox.Text != "item name") || Server.ItemDatabase.Count<KeyValuePair<string, ItemXML>>() <= 0)
        return;
      bool flag = false;
      foreach (ItemXML itemXml in Server.ItemDatabase.Values.ToArray<ItemXML>())
      {
        if (itemXml != null)
        {
          foreach (string str1 in itemXml.Obtainedby)
          {
            if (str1 != string.Empty && str1.Contains(" at "))
            {
              string str2 = str1.Substring(str1.IndexOf("Dropped by ") + 11, str1.IndexOf(" at ") - 11);
              string str3 = str1.Substring(str1.IndexOf(" at ") + 4);
              if (itemXml != null && (str2.Equals(this.itemnametextbox.Text, StringComparison.CurrentCultureIgnoreCase) || str3.Equals(this.itemnametextbox.Text, StringComparison.CurrentCultureIgnoreCase)))
              {
                this.NewForm(Server.ItemDatabase[itemXml.Name]);
                flag = true;
              }
            }
          }
          if (itemXml.Name.Equals(this.itemnametextbox.Text, StringComparison.CurrentCultureIgnoreCase) || itemXml.SecondName.Equals(this.itemnametextbox.Text, StringComparison.CurrentCultureIgnoreCase))
          {
            this.NewForm(Server.ItemDatabase[itemXml.Name]);
            flag = true;
          }
        }
      }
      if (flag)
        return;
      this.label1.Visible = true;
      this.label1timer.Start();
    }

    public void NewForm(ItemXML itemxml)
    {
      bool flag = false;
      if (((IEnumerable<Form>) this.MdiChildren).Count<Form>() > 0)
      {
        foreach (Form mdiChild in this.MdiChildren)
        {
          if (mdiChild.Text.Equals(itemxml.Name, StringComparison.CurrentCultureIgnoreCase))
          {
            if (itemxml.Obtainedby.Count<string>() > 0)
            {
              foreach (string str in itemxml.Obtainedby)
              {
                if (str != string.Empty && !(mdiChild as ItemXMLEditorChild).obtainbox.Text.Contains(str))
                {
                  TextBox obtainbox = (mdiChild as ItemXMLEditorChild).obtainbox;
                  obtainbox.Text = obtainbox.Text + str + Environment.NewLine;
                }
              }
            }
            if (itemxml.Usedfor.Count<string>() > 0)
            {
              foreach (string str in itemxml.Usedfor)
              {
                if (str != string.Empty && !(mdiChild as ItemXMLEditorChild).usesbox.Text.Contains(str))
                {
                  TextBox usesbox = (mdiChild as ItemXMLEditorChild).usesbox;
                  usesbox.Text = usesbox.Text + str + Environment.NewLine;
                }
              }
            }
            flag = true;
          }
        }
      }
      if (flag)
        return;
      ItemXMLEditorChild itemXmlEditorChild = new ItemXMLEditorChild();
      itemXmlEditorChild.MdiParent = (Form) this;
      itemXmlEditorChild.Text = itemxml.Name;
      itemXmlEditorChild.namebox.Text = itemxml.Name;
      itemXmlEditorChild.secondnamebox.Text = itemxml.SecondName;
      if (itemxml.Image != 0)
        itemXmlEditorChild.imagebox.Text = itemxml.Image.ToString();
      if (itemxml.Obtainedby.Count<string>() > 0)
      {
        foreach (string str in itemxml.Obtainedby)
        {
          if (str != string.Empty && !itemXmlEditorChild.obtainbox.Text.Contains(str))
          {
            TextBox obtainbox = itemXmlEditorChild.obtainbox;
            obtainbox.Text = obtainbox.Text + str + Environment.NewLine;
          }
        }
      }
      if (itemxml.Usedfor.Count<string>() > 0)
      {
        foreach (string str in itemxml.Usedfor)
        {
          if (str != string.Empty && !itemXmlEditorChild.usesbox.Text.Contains(str))
          {
            TextBox usesbox = itemXmlEditorChild.usesbox;
            usesbox.Text = usesbox.Text + str + Environment.NewLine;
          }
        }
      }
      itemXmlEditorChild.Show();
    }

    private void ItemXMLEditor_FormClosing(object sender, FormClosingEventArgs e)
    {
      e.Cancel = true;
      this.Hide();
      this.Mainy.openitemxmleditor.Enabled = true;
    }

    private void itemnametextbox_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar != '\r')
        return;
      e.Handled = true;
      this.LoadForm();
    }

    public void UpdateChestsForm()
    {
      if (Program.MainForm.openitemxmleditor.Enabled)
        Program.MainForm.BeginInvoke((Action) (() =>
        {
          Program.MainForm.openitemxmleditor.Enabled = false;
          Program.MainForm.ItemXMLEditor.Show();
        }));
      bool flag = false;
      if (((IEnumerable<Form>) this.MdiChildren).Count<Form>() > 0)
      {
        foreach (Control mdiChild in this.MdiChildren)
        {
          if (mdiChild.Text.Equals("Treasure Chests"))
          {
            flag = true;
            break;
          }
        }
      }
      if (!flag)
      {
        ChestItemXMLEditorChild itemXmlEditorChild = new ChestItemXMLEditorChild();
        itemXmlEditorChild.MdiParent = (Form) this;
        itemXmlEditorChild.Show();
      }
      ChestItemXMLEditorChild itemXmlEditorChild1 = (ChestItemXMLEditorChild) null;
      if (((IEnumerable<Form>) this.MdiChildren).Count<Form>() > 0)
      {
        foreach (Form mdiChild in this.MdiChildren)
        {
          if (mdiChild.Text.Equals("Treasure Chests"))
          {
            itemXmlEditorChild1 = mdiChild as ChestItemXMLEditorChild;
            itemXmlEditorChild1.Activate();
            itemXmlEditorChild1.Refresh();
            break;
          }
        }
      }
      foreach (string key in Server.ChestDatabase.Keys)
      {
        if (!itemXmlEditorChild1.monsterlist.Items.ContainsKey(key))
          itemXmlEditorChild1.monsterlist.Items.Add(new ListViewItem(key)
          {
            Name = key,
            SubItems = {
              Server.ChestDatabase[key].OpenedCount.ToString()
            }
          });
        else
          itemXmlEditorChild1.monsterlist.Items[key].SubItems[1].Text = Server.ChestDatabase[key].OpenedCount.ToString();
        if (itemXmlEditorChild1.monsterlist.SelectedItems.Count > 0 && itemXmlEditorChild1.monsterlist.SelectedItems[0] == itemXmlEditorChild1.monsterlist.Items[key])
        {
          uint num = 0;
          if (Server.ChestDatabase[key].Treasure.Count<KeyValuePair<string, int>>() > 0)
          {
            foreach (KeyValuePair<string, int> keyValuePair in Server.ChestDatabase[key].Treasure)
            {
              if (keyValuePair.Key != null)
              {
                num += (uint) keyValuePair.Value;
                if (!itemXmlEditorChild1.itemlist.Items.ContainsKey(keyValuePair.Key))
                  itemXmlEditorChild1.itemlist.Items.Add(new ListViewItem(keyValuePair.Key)
                  {
                    Name = keyValuePair.Key,
                    SubItems = {
                      keyValuePair.Value.ToString()
                    }
                  });
                else
                  itemXmlEditorChild1.itemlist.Items[keyValuePair.Key].SubItems[1].Text = keyValuePair.Value.ToString();
              }
            }
          }
          itemXmlEditorChild1.totallab.Text = "Total: " + num.ToString();
        }
      }
      itemXmlEditorChild1.Activate();
      itemXmlEditorChild1.Refresh();
    }

    public void UpdateMapForm(ItemMapXML itemxml, string name)
    {
      bool flag = false;
      if (((IEnumerable<Form>) this.MdiChildren).Count<Form>() > 0)
      {
        foreach (Control mdiChild in this.MdiChildren)
        {
          if (mdiChild.Text.Equals(itemxml.Number.ToString() + "_" + itemxml.Name, StringComparison.CurrentCultureIgnoreCase))
          {
            flag = true;
            break;
          }
        }
      }
      int number;
      if (!flag)
      {
        ItemMapXMLEditorChild mapXmlEditorChild1 = new ItemMapXMLEditorChild();
        mapXmlEditorChild1.MdiParent = (Form) this;
        ItemMapXMLEditorChild mapXmlEditorChild2 = mapXmlEditorChild1;
        number = itemxml.Number;
        string str1 = number.ToString() + "_" + itemxml.Name;
        mapXmlEditorChild2.Text = str1;
        mapXmlEditorChild1.mapname.Text = "Map Name: " + itemxml.Name;
        Label mapnumber = mapXmlEditorChild1.mapnumber;
        number = itemxml.Number;
        string str2 = "Map #: " + number.ToString();
        mapnumber.Text = str2;
        if (name != string.Empty)
          mapXmlEditorChild1.charname.Text = name;
        mapXmlEditorChild1.Show();
      }
      ItemMapXMLEditorChild mapXmlEditorChild = (ItemMapXMLEditorChild) null;
      if (((IEnumerable<Form>) this.MdiChildren).Count<Form>() > 0)
      {
        foreach (Form mdiChild in this.MdiChildren)
        {
          string text = mdiChild.Text;
          number = itemxml.Number;
          string str = number.ToString() + "_" + itemxml.Name;
          if (text.Equals(str, StringComparison.CurrentCultureIgnoreCase))
          {
            mapXmlEditorChild = mdiChild as ItemMapXMLEditorChild;
            mapXmlEditorChild.Activate();
            mapXmlEditorChild.Refresh();
            break;
          }
        }
      }
      if (itemxml.Monsters.Count<KeyValuePair<string, ItemMonsterXML>>() > 0)
      {
        foreach (string key1 in itemxml.Monsters.Keys)
        {
          if (key1 != string.Empty)
          {
            ItemMonsterXML monster = itemxml.Monsters[key1];
            uint num;
            if (!mapXmlEditorChild.monsterlist.Items.ContainsKey(key1))
            {
              ListView.ListViewItemCollection items = mapXmlEditorChild.monsterlist.Items;
              ListViewItem listViewItem = new ListViewItem(key1);
              listViewItem.Name = key1;
              ListViewItem.ListViewSubItemCollection subItems = listViewItem.SubItems;
              num = monster.KillCount;
              string text = num.ToString();
              subItems.Add(text);
              items.Add(listViewItem);
            }
            else
            {
              ListViewItem.ListViewSubItem subItem = mapXmlEditorChild.monsterlist.Items[key1].SubItems[1];
              num = monster.KillCount;
              string str = num.ToString();
              subItem.Text = str;
            }
            if (mapXmlEditorChild.monsterlist.SelectedItems.Count > 0 && mapXmlEditorChild.monsterlist.SelectedItems[0] == mapXmlEditorChild.monsterlist.Items[key1])
            {
              if (monster.Drops.Count<KeyValuePair<string, Item2XML>>() > 0)
              {
                foreach (string key2 in monster.Drops.Keys)
                {
                  if (key2 != null)
                  {
                    Item2XML drop = monster.Drops[key2];
                    if (!mapXmlEditorChild.itemlist.Items.ContainsKey(key2))
                    {
                      ListView.ListViewItemCollection items = mapXmlEditorChild.itemlist.Items;
                      ListViewItem listViewItem = new ListViewItem(key2);
                      listViewItem.Name = key2;
                      ListViewItem.ListViewSubItemCollection subItems = listViewItem.SubItems;
                      num = drop.DropCount;
                      string text = num.ToString();
                      subItems.Add(text);
                      items.Add(listViewItem);
                    }
                    else
                    {
                      ListViewItem.ListViewSubItem subItem = mapXmlEditorChild.itemlist.Items[key2].SubItems[1];
                      num = drop.DropCount;
                      string str = num.ToString();
                      subItem.Text = str;
                    }
                  }
                }
              }
              if (monster.GoldAmounts.Count<string>() > 0)
              {
                foreach (string goldAmount in monster.GoldAmounts)
                {
                  if (goldAmount != null && !mapXmlEditorChild.goldlist.Items.ContainsKey(goldAmount))
                    mapXmlEditorChild.goldlist.Items.Add(new ListViewItem(goldAmount)
                    {
                      Name = goldAmount
                    });
                }
              }
            }
          }
        }
      }
      mapXmlEditorChild.Activate();
      mapXmlEditorChild.Refresh();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.newform = new Button();
      this.loadform = new Button();
      this.itemnametextbox = new TextBox();
      this.splitter1 = new Splitter();
      this.label1 = new Label();
      this.SuspendLayout();
      this.newform.Location = new System.Drawing.Point(567, 12);
      this.newform.Name = "newform";
      this.newform.Size = new Size(108, 20);
      this.newform.TabIndex = 23;
      this.newform.Text = "Show Chest Data";
      this.newform.UseVisualStyleBackColor = true;
      this.newform.Click += new EventHandler(this.newform_Click);
      this.loadform.Location = new System.Drawing.Point(163, 12);
      this.loadform.Name = "loadform";
      this.loadform.Size = new Size(153, 20);
      this.loadform.TabIndex = 21;
      this.loadform.Text = "Search Item/Zone/Monster";
      this.loadform.UseVisualStyleBackColor = true;
      this.loadform.Click += new EventHandler(this.loadform_Click);
      this.itemnametextbox.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.itemnametextbox.Location = new System.Drawing.Point(12, 12);
      this.itemnametextbox.Name = "itemnametextbox";
      this.itemnametextbox.Size = new Size(145, 20);
      this.itemnametextbox.TabIndex = 20;
      this.itemnametextbox.Text = "item name";
      this.itemnametextbox.KeyPress += new KeyPressEventHandler(this.itemnametextbox_KeyPress);
      this.splitter1.BackColor = SystemColors.Control;
      this.splitter1.BorderStyle = BorderStyle.FixedSingle;
      this.splitter1.Cursor = Cursors.Default;
      this.splitter1.Dock = DockStyle.Top;
      this.splitter1.Location = new System.Drawing.Point(0, 0);
      this.splitter1.Name = "splitter1";
      this.splitter1.Size = new Size(927, 43);
      this.splitter1.TabIndex = 19;
      this.splitter1.TabStop = false;
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label1.ForeColor = Color.DarkRed;
      this.label1.Location = new System.Drawing.Point(322, 15);
      this.label1.Name = "label1";
      this.label1.Size = new Size(122, 13);
      this.label1.TabIndex = 25;
      this.label1.Text = "item not in database";
      this.label1.Visible = false;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(927, 605);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.newform);
      this.Controls.Add((Control) this.loadform);
      this.Controls.Add((Control) this.itemnametextbox);
      this.Controls.Add((Control) this.splitter1);
      this.IsMdiContainer = true;
      this.Name =  "ItemXMLEditor";
      this.Text =  "ItemXMLEditor";
      this.FormClosing += new FormClosingEventHandler(this.ItemXMLEditor_FormClosing);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
