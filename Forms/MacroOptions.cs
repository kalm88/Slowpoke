//SlowPoke
// Type: Flintstones.MacroOptions
//SlowPoke
//SlowPoke
//SlowPoke

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Flintstones
{
  public class MacroOptions : Form
  {
    public MainForm parent;
    private IContainer components;
    private GroupBox groupBox30;
    public CheckBox macropoisoncrasher;
    public ListView macroskillslistview;
    private ColumnHeader columnHeader1;
    private ColumnHeader columnHeader2;
    public CheckBox macroskill;
    public CheckBox macrohemcrasher;
    public CheckBox macromend;
    public CheckBox macroassail;
    private Label label1;
    private GroupBox groupBox1;
    private ColumnHeader columnHeader3;
    private ColumnHeader columnHeader4;
    private ColumnHeader columnHeader5;
    private ColumnHeader columnHeader6;
    public ComboBox macrospellscombobox;
    public TextBox macrostopat;
    public ListView macrospellslistview;
    public Button macrospelladd;
    public ComboBox macrotarget;
    public Button macrospellremove;
    public Button macrospellmovedown;
    public Button macrospellmoveup;
    public Label targetlabel;
    public Label stoplabel;
    public CheckBox macrospell;

    public Client Client { get; private set; }

    public MacroOptions(Client client)
    {
      this.parent = Program.MainForm;
      this.Client = client;
      this.InitializeComponent();
      this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
    }

        private void MacroOptions_FormClosing(object sender, FormClosingEventArgs e)
    {
      e.Cancel = true;
      this.Hide();
      this.Client.Tab.openmacroform.Enabled = true;
    }

    private void macrospellscombobox_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.macrospellscombobox.SelectedItem == null || !(this.macrospellscombobox.SelectedItem.ToString() != ""))
        return;
      this.macrostopat.Enabled = true;
      this.stoplabel.Enabled = true;
    }

    private void macrospellslistview_ColumnWidthChanging(
      object sender,
      ColumnWidthChangingEventArgs e)
    {
      e.Cancel = true;
      e.NewWidth = this.macrospellslistview.Columns[e.ColumnIndex].Width;
    }

    private void macroskillslistview_ColumnWidthChanging(
      object sender,
      ColumnWidthChangingEventArgs e)
    {
      e.Cancel = true;
      e.NewWidth = this.macroskillslistview.Columns[e.ColumnIndex].Width;
    }

    private void macrospelladd_Click(object sender, EventArgs e)
    {
      this.macrospelladd.Enabled = false;
      this.macrostopat.Enabled = false;
      this.macrotarget.Enabled = false;
      this.stoplabel.Enabled = false;
      this.targetlabel.Enabled = false;
      string str1 = this.macrospellscombobox.SelectedItem.ToString();
      string str2 = str1.Substring(0, str1.IndexOf('(') - 1);
      string str3 = str1.Remove(0, str1.IndexOf('(') + 1);
      string text = str3.Remove(str3.IndexOf('/'));
      ListViewItem listViewItem = this.macrospellslistview.Items.Add(str2, str2, -1);
      listViewItem.SubItems.Add(text);
      listViewItem.SubItems.Add(this.macrostopat.Text);
      listViewItem.SubItems.Add(this.macrotarget.Text);
      this.macrospellscombobox.Items.Clear();
      this.macrospellscombobox.Text = "";
      this.macrostopat.Text = "";
      this.Client.MacroSpells();
      if (this.macrospellslistview.SelectedItems.Count > 0)
      {
        int index = this.macrospellslistview.SelectedItems[0].Index;
        int count = this.macrospellslistview.Items.Count;
        if (index == 0)
          this.macrospellmoveup.Enabled = false;
        else
          this.macrospellmoveup.Enabled = true;
        if (index == count - 1)
          this.macrospellmovedown.Enabled = false;
        else
          this.macrospellmovedown.Enabled = true;
        this.macrospellremove.Enabled = true;
      }
      this.Client.SaveMacroList();
    }

    private void macrospellslistview_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.macrospellslistview.SelectedItems.Count > 0)
      {
        int index = this.macrospellslistview.SelectedItems[0].Index;
        int count = this.macrospellslistview.Items.Count;
        if (index == 0)
          this.macrospellmoveup.Enabled = false;
        else
          this.macrospellmoveup.Enabled = true;
        if (index == count - 1)
          this.macrospellmovedown.Enabled = false;
        else
          this.macrospellmovedown.Enabled = true;
        this.macrospellremove.Enabled = true;
      }
      else
      {
        this.macrospellmoveup.Enabled = false;
        this.macrospellmovedown.Enabled = false;
        this.macrospellremove.Enabled = false;
      }
    }

    private void macrospellmoveup_Click(object sender, EventArgs e)
    {
      if (this.macrospellslistview.SelectedItems.Count <= 0)
        return;
      ListViewItem selectedItem = this.macrospellslistview.SelectedItems[0];
      int index = selectedItem.Index;
      if (index == 0)
        return;
      this.macrospellslistview.Items.Remove(selectedItem);
      this.macrospellslistview.Items.Insert(index - 1, selectedItem);
      if (this.macrospellslistview.SelectedItems[0].Index != 0)
        return;
      this.macrospellmoveup.Enabled = false;
    }

    private void macrospellmovedown_Click(object sender, EventArgs e)
    {
      if (this.macrospellslistview.SelectedItems.Count <= 0)
        return;
      ListViewItem selectedItem = this.macrospellslistview.SelectedItems[0];
      int index = selectedItem.Index;
      int count = this.macrospellslistview.Items.Count;
      if (index == count - 1)
        return;
      this.macrospellslistview.Items.Remove(selectedItem);
      this.macrospellslistview.Items.Insert(index + 1, selectedItem);
      if (this.macrospellslistview.SelectedItems[0].Index != this.macrospellslistview.Items.Count - 1)
        return;
      this.macrospellmovedown.Enabled = false;
    }

    private void macrospellremove_Click(object sender, EventArgs e)
    {
      if (this.macrospellslistview.SelectedItems.Count <= 0)
        return;
      this.macrospellslistview.Items.Remove(this.macrospellslistview.SelectedItems[0]);
      this.Client.MacroSpells();
      this.Client.SaveMacroList();
    }

    private void macrostopat_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
        return;
      e.Handled = true;
    }

    private void macrostopat_TextChanged(object sender, EventArgs e)
    {
      if (this.macrostopat.TextLength != 0)
      {
        if (int.Parse(this.macrostopat.Text) == 0 || int.Parse(this.macrostopat.Text) > 100)
        {
          this.macrospelladd.Enabled = false;
          this.macrotarget.Enabled = false;
          this.targetlabel.Enabled = false;
        }
        else
        {
          this.macrotarget.Enabled = true;
          this.targetlabel.Enabled = true;
        }
      }
      else
      {
        this.macrospelladd.Enabled = false;
        this.macrotarget.Enabled = false;
        this.targetlabel.Enabled = false;
      }
    }

    private void macrotarget_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (!(this.macrotarget.SelectedItem.ToString() != ""))
        return;
      this.macrospelladd.Enabled = true;
    }

    private void macrospellscombobox_Click(object sender, EventArgs e) => this.Client.MacroSpells();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.groupBox30 = new GroupBox();
      this.macropoisoncrasher = new CheckBox();
      this.macroskillslistview = new ListView();
      this.columnHeader1 = new ColumnHeader();
      this.columnHeader2 = new ColumnHeader();
      this.macroskill = new CheckBox();
      this.macrohemcrasher = new CheckBox();
      this.macromend = new CheckBox();
      this.macroassail = new CheckBox();
      this.macrospellscombobox = new ComboBox();
      this.label1 = new Label();
      this.groupBox1 = new GroupBox();
      this.macrospell = new CheckBox();
      this.macrospellremove = new Button();
      this.macrospellmovedown = new Button();
      this.macrospellmoveup = new Button();
      this.targetlabel = new Label();
      this.macrotarget = new ComboBox();
      this.stoplabel = new Label();
      this.macrostopat = new TextBox();
      this.macrospellslistview = new ListView();
      this.columnHeader3 = new ColumnHeader();
      this.columnHeader4 = new ColumnHeader();
      this.columnHeader5 = new ColumnHeader();
      this.columnHeader6 = new ColumnHeader();
      this.macrospelladd = new Button();
      this.groupBox30.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      this.groupBox30.Controls.Add((Control) this.macropoisoncrasher);
      this.groupBox30.Controls.Add((Control) this.macroskillslistview);
      this.groupBox30.Controls.Add((Control) this.macroskill);
      this.groupBox30.Controls.Add((Control) this.macrohemcrasher);
      this.groupBox30.Controls.Add((Control) this.macromend);
      this.groupBox30.Controls.Add((Control) this.macroassail);
      this.groupBox30.Location = new System.Drawing.Point(12, 227);
      this.groupBox30.Name = "groupBox30";
      this.groupBox30.Size = new Size(541, 194);
      this.groupBox30.TabIndex = 5;
      this.groupBox30.TabStop = false;
      this.groupBox30.Text = "Skills";
      this.macropoisoncrasher.AutoSize = true;
      this.macropoisoncrasher.Location = new System.Drawing.Point(326, 157);
      this.macropoisoncrasher.Name = "macropoisoncrasher";
      this.macropoisoncrasher.Size = new Size(145, 17);
      this.macropoisoncrasher.TabIndex = 18;
      this.macropoisoncrasher.Text = "Crasher /Request Poison";
      this.macropoisoncrasher.UseVisualStyleBackColor = true;
      this.macroskillslistview.CheckBoxes = true;
      this.macroskillslistview.Columns.AddRange(new ColumnHeader[2]
      {
        this.columnHeader1,
        this.columnHeader2
      });
      this.macroskillslistview.Font = new Font("Arial", 8.25f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.macroskillslistview.HeaderStyle = ColumnHeaderStyle.Nonclickable;
      this.macroskillslistview.Location = new System.Drawing.Point(6, 19);
      this.macroskillslistview.Name = "macroskillslistview";
      this.macroskillslistview.Size = new Size(271, 167);
      this.macroskillslistview.Sorting = SortOrder.Ascending;
      this.macroskillslistview.TabIndex = 17;
      this.macroskillslistview.UseCompatibleStateImageBehavior = false;
      this.macroskillslistview.View = View.Details;
      this.macroskillslistview.ColumnWidthChanging += new ColumnWidthChangingEventHandler(this.macroskillslistview_ColumnWidthChanging);
      this.columnHeader1.Text = "Skill";
      this.columnHeader1.Width = 166;
      this.columnHeader2.Text = "Level";
      this.columnHeader2.TextAlign = HorizontalAlignment.Center;
      this.columnHeader2.Width = 55;
      this.macroskill.AutoSize = true;
      this.macroskill.Location = new System.Drawing.Point(326, 32);
      this.macroskill.Name = "macroskill";
      this.macroskill.Size = new Size(128, 17);
      this.macroskill.TabIndex = 16;
      this.macroskill.Text = "Checked Skills in Box";
      this.macroskill.UseVisualStyleBackColor = true;
      this.macrohemcrasher.AutoSize = true;
      this.macrohemcrasher.Location = new System.Drawing.Point(326, 132);
      this.macrohemcrasher.Name = "macrohemcrasher";
      this.macrohemcrasher.Size = new Size(143, 17);
      this.macrohemcrasher.TabIndex = 15;
      this.macrohemcrasher.Text = "Crasher, using Hemlochs";
      this.macrohemcrasher.UseVisualStyleBackColor = true;
      this.macromend.AutoSize = true;
      this.macromend.Checked = true;
      this.macromend.CheckState = CheckState.Checked;
      this.macromend.Location = new System.Drawing.Point(326, 82);
      this.macromend.Name = "macromend";
      this.macromend.Size = new Size(167, 17);
      this.macromend.TabIndex = 9;
      this.macromend.Text = "Use mends on non-equipment";
      this.macromend.UseVisualStyleBackColor = true;
      this.macroassail.AutoSize = true;
      this.macroassail.Location = new System.Drawing.Point(326, 57);
      this.macroassail.Name = "macroassail";
      this.macroassail.Size = new Size(58, 17);
      this.macroassail.TabIndex = 0;
      this.macroassail.Text = "Assails";
      this.macroassail.UseVisualStyleBackColor = true;
      this.macrospellscombobox.DropDownStyle = ComboBoxStyle.DropDownList;
      this.macrospellscombobox.FormattingEnabled = true;
      this.macrospellscombobox.Location = new System.Drawing.Point(9, 43);
      this.macrospellscombobox.Name = "macrospellscombobox";
      this.macrospellscombobox.Size = new Size(143, 21);
      this.macrospellscombobox.TabIndex = 6;
      this.macrospellscombobox.SelectedIndexChanged += new EventHandler(this.macrospellscombobox_SelectedIndexChanged);
      this.macrospellscombobox.Click += new EventHandler(this.macrospellscombobox_Click);
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(6, 27);
      this.label1.Name = "label1";
      this.label1.Size = new Size(131, 13);
      this.label1.TabIndex = 7;
      this.label1.Text = "Unmaxed spells (pick one)";
      this.groupBox1.Controls.Add((Control) this.macrospell);
      this.groupBox1.Controls.Add((Control) this.macrospellremove);
      this.groupBox1.Controls.Add((Control) this.macrospellmovedown);
      this.groupBox1.Controls.Add((Control) this.macrospellmoveup);
      this.groupBox1.Controls.Add((Control) this.targetlabel);
      this.groupBox1.Controls.Add((Control) this.macrotarget);
      this.groupBox1.Controls.Add((Control) this.stoplabel);
      this.groupBox1.Controls.Add((Control) this.macrostopat);
      this.groupBox1.Controls.Add((Control) this.macrospellslistview);
      this.groupBox1.Controls.Add((Control) this.macrospelladd);
      this.groupBox1.Controls.Add((Control) this.label1);
      this.groupBox1.Controls.Add((Control) this.macrospellscombobox);
      this.groupBox1.Location = new System.Drawing.Point(12, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(541, 209);
      this.groupBox1.TabIndex = 8;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Spells";
      this.macrospell.AutoSize = true;
      this.macrospell.Location = new System.Drawing.Point(24, 177);
      this.macrospell.Name = "macrospell";
      this.macrospell.Size = new Size(98, 17);
      this.macrospell.TabIndex = 17;
      this.macrospell.Text = "Macro top spell";
      this.macrospell.UseVisualStyleBackColor = true;
      this.macrospellremove.Enabled = false;
      this.macrospellremove.Location = new System.Drawing.Point(407, 177);
      this.macrospellremove.Name = "macrospellremove";
      this.macrospellremove.Size = new Size(75, 23);
      this.macrospellremove.TabIndex = 16;
      this.macrospellremove.Text = "Remove";
      this.macrospellremove.UseVisualStyleBackColor = true;
      this.macrospellremove.Click += new EventHandler(this.macrospellremove_Click);
      this.macrospellmovedown.Enabled = false;
      this.macrospellmovedown.Location = new System.Drawing.Point(265, 177);
      this.macrospellmovedown.Name = "macrospellmovedown";
      this.macrospellmovedown.Size = new Size(75, 23);
      this.macrospellmovedown.TabIndex = 15;
      this.macrospellmovedown.Text = "Move Down";
      this.macrospellmovedown.UseVisualStyleBackColor = true;
      this.macrospellmovedown.Click += new EventHandler(this.macrospellmovedown_Click);
      this.macrospellmoveup.Enabled = false;
      this.macrospellmoveup.Location = new System.Drawing.Point(170, 177);
      this.macrospellmoveup.Name = "macrospellmoveup";
      this.macrospellmoveup.Size = new Size(75, 23);
      this.macrospellmoveup.TabIndex = 14;
      this.macrospellmoveup.Text = "Move Up";
      this.macrospellmoveup.UseVisualStyleBackColor = true;
      this.macrospellmoveup.Click += new EventHandler(this.macrospellmoveup_Click);
      this.targetlabel.AutoSize = true;
      this.targetlabel.Enabled = false;
      this.targetlabel.Location = new System.Drawing.Point(8, 99);
      this.targetlabel.Name = "targetlabel";
      this.targetlabel.Size = new Size(61, 13);
      this.targetlabel.TabIndex = 13;
      this.targetlabel.Text = "Target type";
      this.macrotarget.DropDownStyle = ComboBoxStyle.DropDownList;
      this.macrotarget.Enabled = false;
      this.macrotarget.FormattingEnabled = true;
      this.macrotarget.Items.AddRange(new object[3]
      {
        (object) "none",
        (object) "self",
        (object) "monster"
      });
      this.macrotarget.Location = new System.Drawing.Point(82, 96);
      this.macrotarget.Name = "macrotarget";
      this.macrotarget.Size = new Size(70, 21);
      this.macrotarget.TabIndex = 12;
      this.macrotarget.SelectedIndexChanged += new EventHandler(this.macrotarget_SelectedIndexChanged);
      this.stoplabel.AutoSize = true;
      this.stoplabel.Enabled = false;
      this.stoplabel.Location = new System.Drawing.Point(7, 73);
      this.stoplabel.Name = "stoplabel";
      this.stoplabel.Size = new Size(69, 13);
      this.stoplabel.TabIndex = 11;
      this.stoplabel.Text = "Stop at level:";
      this.macrostopat.Enabled = false;
      this.macrostopat.Location = new System.Drawing.Point(82, 70);
      this.macrostopat.MaxLength = 3;
      this.macrostopat.Name = "macrostopat";
      this.macrostopat.Size = new Size(40, 20);
      this.macrostopat.TabIndex = 10;
      this.macrostopat.TextChanged += new EventHandler(this.macrostopat_TextChanged);
      this.macrostopat.KeyPress += new KeyPressEventHandler(this.macrostopat_KeyPress);
      this.macrospellslistview.Columns.AddRange(new ColumnHeader[4]
      {
        this.columnHeader3,
        this.columnHeader4,
        this.columnHeader5,
        this.columnHeader6
      });
      this.macrospellslistview.Font = new Font("Arial", 8.25f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.macrospellslistview.FullRowSelect = true;
      this.macrospellslistview.HeaderStyle = ColumnHeaderStyle.Nonclickable;
      this.macrospellslistview.HideSelection = false;
      this.macrospellslistview.LabelWrap = false;
      this.macrospellslistview.Location = new System.Drawing.Point(170, 19);
      this.macrospellslistview.MultiSelect = false;
      this.macrospellslistview.Name = "macrospellslistview";
      this.macrospellslistview.Size = new Size(361, 152);
      this.macrospellslistview.TabIndex = 9;
      this.macrospellslistview.UseCompatibleStateImageBehavior = false;
      this.macrospellslistview.View = View.Details;
      this.macrospellslistview.ColumnWidthChanging += new ColumnWidthChangingEventHandler(this.macrospellslistview_ColumnWidthChanging);
      this.macrospellslistview.SelectedIndexChanged += new EventHandler(this.macrospellslistview_SelectedIndexChanged);
      this.columnHeader3.Text = "Spell";
      this.columnHeader3.Width = 171;
      this.columnHeader4.Text = "Level";
      this.columnHeader4.Width = 48;
      this.columnHeader5.Text = "StopAt";
      this.columnHeader5.Width = 46;
      this.columnHeader6.Text = "Target";
      this.columnHeader6.Width = 48;
      this.macrospelladd.Enabled = false;
      this.macrospelladd.Location = new System.Drawing.Point(47, 134);
      this.macrospelladd.Name = "macrospelladd";
      this.macrospelladd.Size = new Size(75, 23);
      this.macrospelladd.TabIndex = 8;
      this.macrospelladd.Text = "Add";
      this.macrospelladd.UseVisualStyleBackColor = true;
      this.macrospelladd.Click += new EventHandler(this.macrospelladd_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(566, 431);
      this.Controls.Add((Control) this.groupBox1);
      this.Controls.Add((Control) this.groupBox30);
      this.Name =  "MacroOptions";
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text =  "MacroOptions";
      this.FormClosing += new FormClosingEventHandler(this.MacroOptions_FormClosing);
      this.groupBox30.ResumeLayout(false);
      this.groupBox30.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
    }
  }
}
