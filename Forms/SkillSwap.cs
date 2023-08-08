//SlowPoke
// Type: Flintstones.SkillSwap
//SlowPoke
//SlowPoke
//SlowPoke

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Flintstones
{
  public class SkillSwap : Form
  {
    public MainForm parent;
    private IContainer components;
    private TabControl tabControl1;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private ColumnHeader columnHeader1;
    private ColumnHeader columnHeader2;
    private Label label3;
    private ColumnHeader columnHeader5;
    private ColumnHeader columnHeader6;
    private ColumnHeader columnHeader7;
    private ColumnHeader columnHeader8;
    private Label label6;
    public ListView spellmedlist;
    public Button spellswapbtn;
    public ListView skillmedlist;
    public ListView skilltemlist;
    public Button skillswapbtn;
    public ListView spelltemlist;
    private ColumnHeader columnHeader3;
    private ColumnHeader columnHeader4;
    public Label spelltemlab;
    public Label spellmedlab;
    public Label skilltemlab;
    public Label skillmedlab;

    public Client Client { get; private set; }

    public SkillSwap(Client client)
    {
      this.parent = Program.MainForm;
      this.Client = client;
      this.InitializeComponent();
      this.spelltemlist.Items.Add("1", "1", 0);
      this.spelltemlist.Items.Add("2", "2", 0);
      this.spelltemlist.Items.Add("3", "3", 0);
      this.spelltemlist.Items.Add("4", "4", 0);
      this.spelltemlist.Items.Add("5", "5", 0);
      this.spelltemlist.Items.Add("6", "6", 0);
      this.spelltemlist.Items.Add("7", "7", 0);
      this.spelltemlist.Items.Add("8", "8", 0);
      this.spelltemlist.Items.Add("9", "9", 0);
      this.spelltemlist.Items.Add("10", "10", 0);
      this.spelltemlist.Items.Add("11", "11", 0);
      this.spelltemlist.Items.Add("12", "12", 0);
      this.spelltemlist.Items.Add("13", "13", 0);
      this.spelltemlist.Items.Add("14", "14", 0);
      this.spelltemlist.Items.Add("15", "15", 0);
      this.spelltemlist.Items.Add("16", "16", 0);
      this.spelltemlist.Items.Add("17", "17", 0);
      this.spelltemlist.Items.Add("18", "18", 0);
      this.spelltemlist.Items.Add("19", "19", 0);
      this.spelltemlist.Items.Add("20", "20", 0);
      this.spelltemlist.Items.Add("21", "21", 0);
      this.spelltemlist.Items.Add("22", "22", 0);
      this.spelltemlist.Items.Add("23", "23", 0);
      this.spelltemlist.Items.Add("24", "24", 0);
      this.spelltemlist.Items.Add("25", "25", 0);
      this.spelltemlist.Items.Add("26", "26", 0);
      this.spelltemlist.Items.Add("27", "27", 0);
      this.spelltemlist.Items.Add("28", "28", 0);
      this.spelltemlist.Items.Add("29", "29", 0);
      this.spelltemlist.Items.Add("30", "30", 0);
      this.spelltemlist.Items.Add("31", "31", 0);
      this.spelltemlist.Items.Add("32", "32", 0);
      this.spelltemlist.Items.Add("33", "33", 0);
      this.spelltemlist.Items.Add("34", "34", 0);
      this.spelltemlist.Items.Add("35", "35", 0);
      this.spellmedlist.Items.Add("1", "1", 0);
      this.spellmedlist.Items.Add("2", "2", 0);
      this.spellmedlist.Items.Add("3", "3", 0);
      this.spellmedlist.Items.Add("4", "4", 0);
      this.spellmedlist.Items.Add("5", "5", 0);
      this.spellmedlist.Items.Add("6", "6", 0);
      this.spellmedlist.Items.Add("7", "7", 0);
      this.spellmedlist.Items.Add("8", "8", 0);
      this.spellmedlist.Items.Add("9", "9", 0);
      this.spellmedlist.Items.Add("10", "10", 0);
      this.spellmedlist.Items.Add("11", "11", 0);
      this.spellmedlist.Items.Add("12", "12", 0);
      this.spellmedlist.Items.Add("13", "13", 0);
      this.spellmedlist.Items.Add("14", "14", 0);
      this.spellmedlist.Items.Add("15", "15", 0);
      this.spellmedlist.Items.Add("16", "16", 0);
      this.spellmedlist.Items.Add("17", "17", 0);
      this.spellmedlist.Items.Add("18", "18", 0);
      this.spellmedlist.Items.Add("19", "19", 0);
      this.spellmedlist.Items.Add("20", "20", 0);
      this.spellmedlist.Items.Add("21", "21", 0);
      this.spellmedlist.Items.Add("22", "22", 0);
      this.spellmedlist.Items.Add("23", "23", 0);
      this.spellmedlist.Items.Add("24", "24", 0);
      this.spellmedlist.Items.Add("25", "25", 0);
      this.spellmedlist.Items.Add("26", "26", 0);
      this.spellmedlist.Items.Add("27", "27", 0);
      this.spellmedlist.Items.Add("28", "28", 0);
      this.spellmedlist.Items.Add("29", "29", 0);
      this.spellmedlist.Items.Add("30", "30", 0);
      this.spellmedlist.Items.Add("31", "31", 0);
      this.spellmedlist.Items.Add("32", "32", 0);
      this.spellmedlist.Items.Add("33", "33", 0);
      this.spellmedlist.Items.Add("34", "34", 0);
      this.spellmedlist.Items.Add("35", "35", 0);
      this.skilltemlist.Items.Add("1", "1", 0);
      this.skilltemlist.Items.Add("2", "2", 0);
      this.skilltemlist.Items.Add("3", "3", 0);
      this.skilltemlist.Items.Add("4", "4", 0);
      this.skilltemlist.Items.Add("5", "5", 0);
      this.skilltemlist.Items.Add("6", "6", 0);
      this.skilltemlist.Items.Add("7", "7", 0);
      this.skilltemlist.Items.Add("8", "8", 0);
      this.skilltemlist.Items.Add("9", "9", 0);
      this.skilltemlist.Items.Add("10", "10", 0);
      this.skilltemlist.Items.Add("11", "11", 0);
      this.skilltemlist.Items.Add("12", "12", 0);
      this.skilltemlist.Items.Add("13", "13", 0);
      this.skilltemlist.Items.Add("14", "14", 0);
      this.skilltemlist.Items.Add("15", "15", 0);
      this.skilltemlist.Items.Add("16", "16", 0);
      this.skilltemlist.Items.Add("17", "17", 0);
      this.skilltemlist.Items.Add("18", "18", 0);
      this.skilltemlist.Items.Add("19", "19", 0);
      this.skilltemlist.Items.Add("20", "20", 0);
      this.skilltemlist.Items.Add("21", "21", 0);
      this.skilltemlist.Items.Add("22", "22", 0);
      this.skilltemlist.Items.Add("23", "23", 0);
      this.skilltemlist.Items.Add("24", "24", 0);
      this.skilltemlist.Items.Add("25", "25", 0);
      this.skilltemlist.Items.Add("26", "26", 0);
      this.skilltemlist.Items.Add("27", "27", 0);
      this.skilltemlist.Items.Add("28", "28", 0);
      this.skilltemlist.Items.Add("29", "29", 0);
      this.skilltemlist.Items.Add("30", "30", 0);
      this.skilltemlist.Items.Add("31", "31", 0);
      this.skilltemlist.Items.Add("32", "32", 0);
      this.skilltemlist.Items.Add("33", "33", 0);
      this.skilltemlist.Items.Add("34", "34", 0);
      this.skilltemlist.Items.Add("35", "35", 0);
      this.skillmedlist.Items.Add("1", "1", 0);
      this.skillmedlist.Items.Add("2", "2", 0);
      this.skillmedlist.Items.Add("3", "3", 0);
      this.skillmedlist.Items.Add("4", "4", 0);
      this.skillmedlist.Items.Add("5", "5", 0);
      this.skillmedlist.Items.Add("6", "6", 0);
      this.skillmedlist.Items.Add("7", "7", 0);
      this.skillmedlist.Items.Add("8", "8", 0);
      this.skillmedlist.Items.Add("9", "9", 0);
      this.skillmedlist.Items.Add("10", "10", 0);
      this.skillmedlist.Items.Add("11", "11", 0);
      this.skillmedlist.Items.Add("12", "12", 0);
      this.skillmedlist.Items.Add("13", "13", 0);
      this.skillmedlist.Items.Add("14", "14", 0);
      this.skillmedlist.Items.Add("15", "15", 0);
      this.skillmedlist.Items.Add("16", "16", 0);
      this.skillmedlist.Items.Add("17", "17", 0);
      this.skillmedlist.Items.Add("18", "18", 0);
      this.skillmedlist.Items.Add("19", "19", 0);
      this.skillmedlist.Items.Add("20", "20", 0);
      this.skillmedlist.Items.Add("21", "21", 0);
      this.skillmedlist.Items.Add("22", "22", 0);
      this.skillmedlist.Items.Add("23", "23", 0);
      this.skillmedlist.Items.Add("24", "24", 0);
      this.skillmedlist.Items.Add("25", "25", 0);
      this.skillmedlist.Items.Add("26", "26", 0);
      this.skillmedlist.Items.Add("27", "27", 0);
      this.skillmedlist.Items.Add("28", "28", 0);
      this.skillmedlist.Items.Add("29", "29", 0);
      this.skillmedlist.Items.Add("30", "30", 0);
      this.skillmedlist.Items.Add("31", "31", 0);
      this.skillmedlist.Items.Add("32", "32", 0);
      this.skillmedlist.Items.Add("33", "33", 0);
      this.skillmedlist.Items.Add("34", "34", 0);
      this.skillmedlist.Items.Add("35", "35", 0);
    }

    private void SkillSwap_FormClosing(object sender, FormClosingEventArgs e)
    {
      e.Cancel = true;
      this.Hide();
      this.Client.Tab.openswapform.Enabled = true;
    }

    private void spelltemlist_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.spelltemlist.SelectedItems.Count > 0 && this.spelltemlist.SelectedItems[0].SubItems.Count > 1 && this.spelltemlist.SelectedItems[0].SubItems[1].Text != "")
        this.spelltemlab.Text = "Temuair Panel - " + this.spelltemlist.SelectedItems[0].SubItems[1].Text;
      else if (this.spelltemlist.SelectedItems.Count > 0)
        this.spelltemlab.Text = "Temuair Panel - Empty Slot #" + this.spelltemlist.SelectedItems[0].Text;
      else
        this.spelltemlab.Text = "Temuair Panel";
      if (this.spelltemlist.SelectedItems.Count > 0 && this.spellmedlist.SelectedItems.Count > 0)
      {
        if ((this.spelltemlist.SelectedItems[0].SubItems.Count <= 1 || !(this.spelltemlist.SelectedItems[0].SubItems[1].Text != "")) && (this.spellmedlist.SelectedItems[0].SubItems.Count <= 1 || !(this.spellmedlist.SelectedItems[0].SubItems[1].Text != "")))
          return;
        this.spellswapbtn.Enabled = true;
      }
      else
        this.spellswapbtn.Enabled = false;
    }

    private void spellmedlist_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.spellmedlist.SelectedItems.Count > 0 && this.spellmedlist.SelectedItems[0].SubItems.Count > 1 && this.spellmedlist.SelectedItems[0].SubItems[1].Text != "")
        this.spellmedlab.Text = "Medenia Panel - " + this.spellmedlist.SelectedItems[0].SubItems[1].Text;
      else if (this.spellmedlist.SelectedItems.Count > 0)
        this.spellmedlab.Text = "Medenia Panel - Empty Slot #" + this.spellmedlist.SelectedItems[0].Text;
      else
        this.spellmedlab.Text = "Medenia Panel";
      if (this.spelltemlist.SelectedItems.Count > 0 && this.spellmedlist.SelectedItems.Count > 0)
      {
        if ((this.spelltemlist.SelectedItems[0].SubItems.Count <= 1 || !(this.spelltemlist.SelectedItems[0].SubItems[1].Text != "")) && (this.spellmedlist.SelectedItems[0].SubItems.Count <= 1 || !(this.spellmedlist.SelectedItems[0].SubItems[1].Text != "")))
          return;
        this.spellswapbtn.Enabled = true;
      }
      else
        this.spellswapbtn.Enabled = false;
    }

    private void skilltemlist_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.skilltemlist.SelectedItems.Count > 0 && this.skilltemlist.SelectedItems[0].SubItems.Count > 1 && this.skilltemlist.SelectedItems[0].SubItems[1].Text != "")
        this.skilltemlab.Text = "Temuair Panel - " + this.skilltemlist.SelectedItems[0].SubItems[1].Text;
      else if (this.skilltemlist.SelectedItems.Count > 0)
        this.skilltemlab.Text = "Temuair Panel - Empty Slot #" + this.skilltemlist.SelectedItems[0].Text;
      else
        this.skilltemlab.Text = "Temuair Panel";
      if (this.skilltemlist.SelectedItems.Count > 0 && this.skillmedlist.SelectedItems.Count > 0)
      {
        if ((this.skilltemlist.SelectedItems[0].SubItems.Count <= 1 || !(this.skilltemlist.SelectedItems[0].SubItems[1].Text != "")) && (this.skillmedlist.SelectedItems[0].SubItems.Count <= 1 || !(this.skillmedlist.SelectedItems[0].SubItems[1].Text != "")))
          return;
        this.skillswapbtn.Enabled = true;
      }
      else
        this.skillswapbtn.Enabled = false;
    }

    private void skillmedlist_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.skillmedlist.SelectedItems.Count > 0 && this.skillmedlist.SelectedItems[0].SubItems.Count > 1 && this.skillmedlist.SelectedItems[0].SubItems[1].Text != "")
        this.skillmedlab.Text = "Medenia Panel - " + this.skillmedlist.SelectedItems[0].SubItems[1].Text;
      else if (this.skillmedlist.SelectedItems.Count > 0)
        this.skillmedlab.Text = "Medenia Panel - Empty Slot #" + this.skillmedlist.SelectedItems[0].Text;
      else
        this.skillmedlab.Text = "Medenia Panel";
      if (this.skilltemlist.SelectedItems.Count > 0 && this.skillmedlist.SelectedItems.Count > 0)
      {
        if ((this.skilltemlist.SelectedItems[0].SubItems.Count <= 1 || !(this.skilltemlist.SelectedItems[0].SubItems[1].Text != "")) && (this.skillmedlist.SelectedItems[0].SubItems.Count <= 1 || !(this.skillmedlist.SelectedItems[0].SubItems[1].Text != "")))
          return;
        this.skillswapbtn.Enabled = true;
      }
      else
        this.skillswapbtn.Enabled = false;
    }

    private void skillswapbtn_Click(object sender, EventArgs e)
    {
      this.skillswapbtn.Enabled = false;
      if (this.skilltemlist.SelectedItems.Count <= 0 || this.skillmedlist.SelectedItems.Count <= 0)
        return;
      if (this.skilltemlist.SelectedItems[0].SubItems.Count > 1 && this.skilltemlist.SelectedItems[0].SubItems[1].Text != "")
      {
        string text1 = this.skilltemlist.SelectedItems[0].SubItems[1].Text;
      }
      if (this.skillmedlist.SelectedItems[0].SubItems.Count > 1 && this.skillmedlist.SelectedItems[0].SubItems[1].Text != "")
      {
        string text2 = this.skillmedlist.SelectedItems[0].SubItems[1].Text;
      }
      byte end = (byte) ((uint) byte.Parse(this.skillmedlist.SelectedItems[0].Text) + 36U);
      this.Client.SwitchSlots((byte) 2, (int) byte.Parse(this.skilltemlist.SelectedItems[0].Text), (int) end);
      this.skilltemlist.SelectedItems.Clear();
      this.skillmedlist.SelectedItems.Clear();
    }

    private void spellswapbtn_Click(object sender, EventArgs e)
    {
      this.spellswapbtn.Enabled = false;
      if (this.spelltemlist.SelectedItems.Count <= 0 || this.spellmedlist.SelectedItems.Count <= 0)
        return;
      if (this.spelltemlist.SelectedItems[0].SubItems.Count > 1 && this.spelltemlist.SelectedItems[0].SubItems[1].Text != "")
      {
        string text1 = this.spelltemlist.SelectedItems[0].SubItems[1].Text;
      }
      if (this.spellmedlist.SelectedItems[0].SubItems.Count > 1 && this.spellmedlist.SelectedItems[0].SubItems[1].Text != "")
      {
        string text2 = this.spellmedlist.SelectedItems[0].SubItems[1].Text;
      }
      byte end = (byte) ((uint) byte.Parse(this.spellmedlist.SelectedItems[0].Text) + 36U);
      this.Client.SwitchSlots((byte) 1, (int) byte.Parse(this.spelltemlist.SelectedItems[0].Text), (int) end);
      this.spelltemlist.SelectedItems.Clear();
      this.spellmedlist.SelectedItems.Clear();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.tabControl1 = new TabControl();
      this.tabPage1 = new TabPage();
      this.spelltemlist = new ListView();
      this.columnHeader3 = new ColumnHeader();
      this.columnHeader4 = new ColumnHeader();
      this.spellmedlist = new ListView();
      this.columnHeader1 = new ColumnHeader();
      this.columnHeader2 = new ColumnHeader();
      this.spellmedlab = new Label();
      this.spelltemlab = new Label();
      this.spellswapbtn = new Button();
      this.label3 = new Label();
      this.tabPage2 = new TabPage();
      this.skillmedlist = new ListView();
      this.columnHeader5 = new ColumnHeader();
      this.columnHeader6 = new ColumnHeader();
      this.skilltemlist = new ListView();
      this.columnHeader7 = new ColumnHeader();
      this.columnHeader8 = new ColumnHeader();
      this.skillmedlab = new Label();
      this.skilltemlab = new Label();
      this.skillswapbtn = new Button();
      this.label6 = new Label();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.SuspendLayout();
      this.tabControl1.Controls.Add((Control) this.tabPage1);
      this.tabControl1.Controls.Add((Control) this.tabPage2);
      this.tabControl1.Location = new System.Drawing.Point(0, 0);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new Size(477, 478);
      this.tabControl1.TabIndex = 5;
      this.tabPage1.Controls.Add((Control) this.spelltemlist);
      this.tabPage1.Controls.Add((Control) this.spellmedlist);
      this.tabPage1.Controls.Add((Control) this.spellmedlab);
      this.tabPage1.Controls.Add((Control) this.spelltemlab);
      this.tabPage1.Controls.Add((Control) this.spellswapbtn);
      this.tabPage1.Controls.Add((Control) this.label3);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new Padding(3);
      this.tabPage1.Size = new Size(469, 452);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Spells";
      this.tabPage1.UseVisualStyleBackColor = true;
      this.spelltemlist.Columns.AddRange(new ColumnHeader[2]
      {
        this.columnHeader3,
        this.columnHeader4
      });
      this.spelltemlist.FullRowSelect = true;
      this.spelltemlist.HideSelection = false;
      this.spelltemlist.Location = new System.Drawing.Point(13, 49);
      this.spelltemlist.MultiSelect = false;
      this.spelltemlist.Name = "spelltemlist";
      this.spelltemlist.Size = new Size(178, 393);
      this.spelltemlist.TabIndex = 27;
      this.spelltemlist.UseCompatibleStateImageBehavior = false;
      this.spelltemlist.View = View.Details;
      this.spelltemlist.SelectedIndexChanged += new EventHandler(this.spelltemlist_SelectedIndexChanged);
      this.columnHeader3.Text = "Slot";
      this.columnHeader3.Width = 31;
      this.columnHeader4.Text = "Name";
      this.columnHeader4.Width = 124;
      this.spellmedlist.Columns.AddRange(new ColumnHeader[2]
      {
        this.columnHeader1,
        this.columnHeader2
      });
      this.spellmedlist.FullRowSelect = true;
      this.spellmedlist.HideSelection = false;
      this.spellmedlist.Location = new System.Drawing.Point(278, 49);
      this.spellmedlist.MultiSelect = false;
      this.spellmedlist.Name = "spellmedlist";
      this.spellmedlist.Size = new Size(178, 393);
      this.spellmedlist.TabIndex = 26;
      this.spellmedlist.UseCompatibleStateImageBehavior = false;
      this.spellmedlist.View = View.Details;
      this.spellmedlist.SelectedIndexChanged += new EventHandler(this.spellmedlist_SelectedIndexChanged);
      this.columnHeader1.Text = "Slot";
      this.columnHeader1.Width = 31;
      this.columnHeader2.Text = "Name";
      this.columnHeader2.Width = 123;
      this.spellmedlab.AutoSize = true;
      this.spellmedlab.Location = new System.Drawing.Point(275, 33);
      this.spellmedlab.Name = "spellmedlab";
      this.spellmedlab.Size = new Size(78, 13);
      this.spellmedlab.TabIndex = 24;
      this.spellmedlab.Text = "Medenia Panel";
      this.spelltemlab.AutoSize = true;
      this.spelltemlab.Location = new System.Drawing.Point(10, 33);
      this.spelltemlab.Name = "spelltemlab";
      this.spelltemlab.Size = new Size(75, 13);
      this.spelltemlab.TabIndex = 23;
      this.spelltemlab.Text = "Temuair Panel";
      this.spellswapbtn.Enabled = false;
      this.spellswapbtn.Location = new System.Drawing.Point(197, 141);
      this.spellswapbtn.Name = "spellswapbtn";
      this.spellswapbtn.Size = new Size(75, 39);
      this.spellswapbtn.TabIndex = 22;
      this.spellswapbtn.Text = "Swap em!";
      this.spellswapbtn.UseVisualStyleBackColor = true;
      this.spellswapbtn.Click += new EventHandler(this.spellswapbtn_Click);
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(120, 11);
      this.label3.Name = "label3";
      this.label3.Size = new Size(220, 13);
      this.label3.TabIndex = 21;
      this.label3.Text = "Select a Slot in each List and click Swap em!";
      this.tabPage2.Controls.Add((Control) this.skillmedlist);
      this.tabPage2.Controls.Add((Control) this.skilltemlist);
      this.tabPage2.Controls.Add((Control) this.skillmedlab);
      this.tabPage2.Controls.Add((Control) this.skilltemlab);
      this.tabPage2.Controls.Add((Control) this.skillswapbtn);
      this.tabPage2.Controls.Add((Control) this.label6);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new Padding(3);
      this.tabPage2.Size = new Size(469, 452);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Skills";
      this.tabPage2.UseVisualStyleBackColor = true;
      this.skillmedlist.Columns.AddRange(new ColumnHeader[2]
      {
        this.columnHeader5,
        this.columnHeader6
      });
      this.skillmedlist.FullRowSelect = true;
      this.skillmedlist.HideSelection = false;
      this.skillmedlist.Location = new System.Drawing.Point(278, 49);
      this.skillmedlist.MultiSelect = false;
      this.skillmedlist.Name = "skillmedlist";
      this.skillmedlist.Size = new Size(178, 393);
      this.skillmedlist.TabIndex = 26;
      this.skillmedlist.UseCompatibleStateImageBehavior = false;
      this.skillmedlist.View = View.Details;
      this.skillmedlist.SelectedIndexChanged += new EventHandler(this.skillmedlist_SelectedIndexChanged);
      this.columnHeader5.Text = "Slot";
      this.columnHeader5.Width = 31;
      this.columnHeader6.Text = "Name";
      this.columnHeader6.Width = 118;
      this.skilltemlist.Columns.AddRange(new ColumnHeader[2]
      {
        this.columnHeader7,
        this.columnHeader8
      });
      this.skilltemlist.FullRowSelect = true;
      this.skilltemlist.HideSelection = false;
      this.skilltemlist.Location = new System.Drawing.Point(13, 49);
      this.skilltemlist.MultiSelect = false;
      this.skilltemlist.Name = "skilltemlist";
      this.skilltemlist.Size = new Size(178, 393);
      this.skilltemlist.TabIndex = 25;
      this.skilltemlist.UseCompatibleStateImageBehavior = false;
      this.skilltemlist.View = View.Details;
      this.skilltemlist.SelectedIndexChanged += new EventHandler(this.skilltemlist_SelectedIndexChanged);
      this.columnHeader7.Text = "Slot";
      this.columnHeader7.Width = 31;
      this.columnHeader8.Text = "Name";
      this.columnHeader8.Width = 118;
      this.skillmedlab.AutoSize = true;
      this.skillmedlab.Location = new System.Drawing.Point(275, 33);
      this.skillmedlab.Name = "skillmedlab";
      this.skillmedlab.Size = new Size(78, 13);
      this.skillmedlab.TabIndex = 24;
      this.skillmedlab.Text = "Medenia Panel";
      this.skilltemlab.AutoSize = true;
      this.skilltemlab.Location = new System.Drawing.Point(10, 33);
      this.skilltemlab.Name = "skilltemlab";
      this.skilltemlab.Size = new Size(75, 13);
      this.skilltemlab.TabIndex = 23;
      this.skilltemlab.Text = "Temuair Panel";
      this.skillswapbtn.Enabled = false;
      this.skillswapbtn.Location = new System.Drawing.Point(197, 141);
      this.skillswapbtn.Name = "skillswapbtn";
      this.skillswapbtn.Size = new Size(75, 39);
      this.skillswapbtn.TabIndex = 22;
      this.skillswapbtn.Text = "Swap em!";
      this.skillswapbtn.UseVisualStyleBackColor = true;
      this.skillswapbtn.Click += new EventHandler(this.skillswapbtn_Click);
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(120, 11);
      this.label6.Name = "label6";
      this.label6.Size = new Size(220, 13);
      this.label6.TabIndex = 21;
      this.label6.Text = "Select a Slot in each List and click Swap em!";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(475, 477);
      this.Controls.Add((Control) this.tabControl1);
      this.Name =  "SkillSwap";
      this.Text =  "SkillSwap";
      this.FormClosing += new FormClosingEventHandler(this.SkillSwap_FormClosing);
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage1.PerformLayout();
      this.tabPage2.ResumeLayout(false);
      this.tabPage2.PerformLayout();
      this.ResumeLayout(false);
    }
  }
}
