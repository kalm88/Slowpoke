//SlowPoke
// Type: Flintstones.ComboEdit
//SlowPoke
//SlowPoke
//SlowPoke

using System;
using System.ComponentModel;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Flintstones
{
  public class ComboEdit : Form
  {
    public string[] macro1 = new string[1]{ "" };
    public MainForm parent;
    public int combo1val;
    private IContainer components;
    public Label label41;
    public TextBox combo1box;
    public ComboBox combo1mod;
    public Label label17;
    public TextBox combo1trigger;
    public CheckBox usemacro1;
    public ListBox comboslistbox;

    public Client Client { get; private set; }

    public ComboEdit(Client client)
    {
      this.parent = Program.MainForm;
      this.Client = client;
      this.InitializeComponent();
    }

    private void ComboEdit_FormClosing(object sender, FormClosingEventArgs e)
    {
      e.Cancel = true;
      this.Hide();
      this.Client.Tab.opencomboform.Enabled = true;
    }

    public static string ConvertWhitespaceToSpacesRegex(string value)
    {
      value = Regex.Replace(value, "[\n\r\t]", " ");
      return value;
    }

    public string[] ConvertMacro(string[] convertee)
    {
      string[] strArray = Array.ConvertAll<string, string>(convertee, (Converter<string, string>) (s => s.ToLower()));
      for (int index = 0; index < strArray.Length; ++index)
      {
        if (strArray[index].Equals("wk"))
          strArray[index] = "wheel kick";
        else if (strArray[index].Equals("ck"))
          strArray[index] = "cyclone kick";
        else if (strArray[index].Equals("sd"))
          strArray[index] = "strikedown";
        else if (strArray[index].Equals("ds"))
          strArray[index] = "dune swipe";
        else if (strArray[index].Equals("kelb"))
          strArray[index] = "kelberoth strike";
        else if (strArray[index].Equals("ms"))
          strArray[index] = "mad soul";
        else if (strArray[index].Equals("sac"))
          strArray[index] = "sacrifice";
        else if (strArray[index].Equals("af"))
          strArray[index] = "animal feast";
        else if (strArray[index].Equals("ra"))
          strArray[index] = "raging attack";
        else if (strArray[index].Equals("fb"))
          strArray[index] = "furious bash";
        else if (strArray[index].Equals("mk"))
          strArray[index] = "mantis kick";
        else if (strArray[index].Equals("dtk"))
          strArray[index] = "draco tail kick";
        else if (strArray[index].Equals("wff"))
          strArray[index] = "wolf fang fist";
        else if (strArray[index].Equals("hem"))
          strArray[index] = "hemloch";
        else if (strArray[index].Equals("wb"))
          strArray[index] = "wind blade";
        else if (strArray[index].Equals("bs"))
          strArray[index] = "beag suain";
        else if (strArray[index].Equals("fs"))
          strArray[index] = "frost strike";
        else if (strArray[index].Equals("lp"))
          strArray[index] = "lullaby punch";
      }
      return strArray;
    }

    public void LoadCombos()
    {
      this.SetMacro1();
      if (this.combo1trigger.Text == "Insert")
        this.combo1val = 45;
      if (this.combo1trigger.Text == "Del")
        this.combo1val = 36;
      if (this.combo1trigger.Text == "Home")
        this.combo1val = 36;
      if (this.combo1trigger.Text == "End")
        this.combo1val = 35;
      if (this.combo1trigger.Text == "Pg Up")
        this.combo1val = 33;
      if (this.combo1trigger.Text == "Pg Dwn")
        this.combo1val = 34;
      if (this.combo1trigger.Text == "F11")
        this.combo1val = 122;
      if (this.combo1trigger.Text == "F2")
        this.combo1val = 113;
      if (this.combo1trigger.Text == "F3")
        this.combo1val = 114;
      if (this.combo1trigger.Text == "F4")
        this.combo1val = 115;
      if (this.combo1trigger.Text == "F6")
        this.combo1val = 117;
      if (this.combo1trigger.Text == "F7")
        this.combo1val = 118;
      if (this.combo1trigger.Text == "F8")
        this.combo1val = 119;
      if (this.combo1trigger.Text == "~")
        this.combo1val = 192;
      if (this.combo1trigger.Text == "-")
        this.combo1val = 189;
      if (this.combo1trigger.Text == "=")
        this.combo1val = 187;
      if (this.combo1trigger.Text == "[")
        this.combo1val = 219;
      if (this.combo1trigger.Text == "]")
        this.combo1val = 221;
      if (this.combo1trigger.Text == "\\")
        this.combo1val = 220;
      if (this.combo1trigger.Text == "'")
        this.combo1val = 222;
      if (this.combo1trigger.Text == ";")
        this.combo1val = 186;
      if (this.combo1trigger.Text == "/")
        this.combo1val = 191;
      if (this.combo1trigger.Text == ".")
        this.combo1val = 190;
      if (this.combo1trigger.Text == ",")
        this.combo1val = 188;
      if (this.combo1trigger.Text == "Num0")
        this.combo1val = 96;
      if (this.combo1trigger.Text == "Num1")
        this.combo1val = 97;
      if (this.combo1trigger.Text == "Num2")
        this.combo1val = 98;
      if (this.combo1trigger.Text == "Num3")
        this.combo1val = 99;
      if (this.combo1trigger.Text == "Num4")
        this.combo1val = 100;
      if (this.combo1trigger.Text == "Num5")
        this.combo1val = 101;
      if (this.combo1trigger.Text == "Num6")
        this.combo1val = 102;
      if (this.combo1trigger.Text == "Num7")
        this.combo1val = 103;
      if (this.combo1trigger.Text == "Num8")
        this.combo1val = 104;
      if (this.combo1trigger.Text == "Num9")
        this.combo1val = 105;
      if (this.combo1trigger.Text == "Mult")
        this.combo1val = 106;
      if (this.combo1trigger.Text == "Div")
        this.combo1val = 111;
      if (this.combo1trigger.Text == "Sub")
        this.combo1val = 109;
      if (this.combo1trigger.Text == "Add")
        this.combo1val = 107;
      if (this.combo1trigger.Text == "Dec")
        this.combo1val = 110;
      if (this.combo1trigger.Text == "0")
        this.combo1val = 48;
      if (this.combo1trigger.Text == "1")
        this.combo1val = 49;
      if (this.combo1trigger.Text == "2")
        this.combo1val = 50;
      if (this.combo1trigger.Text == "3")
        this.combo1val = 51;
      if (this.combo1trigger.Text == "4")
        this.combo1val = 52;
      if (this.combo1trigger.Text == "5")
        this.combo1val = 53;
      if (this.combo1trigger.Text == "6")
        this.combo1val = 54;
      if (this.combo1trigger.Text == "7")
        this.combo1val = 55;
      if (this.combo1trigger.Text == "8")
        this.combo1val = 56;
      if (this.combo1trigger.Text == "9")
        this.combo1val = 57;
      if (this.combo1trigger.Text == "a")
        this.combo1val = 65;
      if (this.combo1trigger.Text == "b")
        this.combo1val = 66;
      if (this.combo1trigger.Text == "c")
        this.combo1val = 67;
      if (this.combo1trigger.Text == "d")
        this.combo1val = 68;
      if (this.combo1trigger.Text == "e")
        this.combo1val = 69;
      if (this.combo1trigger.Text == "f")
        this.combo1val = 70;
      if (this.combo1trigger.Text == "g")
        this.combo1val = 71;
      if (this.combo1trigger.Text == "h")
        this.combo1val = 72;
      if (this.combo1trigger.Text == "i")
        this.combo1val = 73;
      if (this.combo1trigger.Text == "j")
        this.combo1val = 74;
      if (this.combo1trigger.Text == "k")
        this.combo1val = 75;
      if (this.combo1trigger.Text == "l")
        this.combo1val = 76;
      if (this.combo1trigger.Text == "m")
        this.combo1val = 77;
      if (this.combo1trigger.Text == "n")
        this.combo1val = 78;
      if (this.combo1trigger.Text == "o")
        this.combo1val = 79;
      if (this.combo1trigger.Text == "p")
        this.combo1val = 80;
      if (this.combo1trigger.Text == "q")
        this.combo1val = 81;
      if (this.combo1trigger.Text == "r")
        this.combo1val = 82;
      if (this.combo1trigger.Text == "s")
        this.combo1val = 83;
      if (this.combo1trigger.Text == "t")
        this.combo1val = 84;
      if (this.combo1trigger.Text == "u")
        this.combo1val = 85;
      if (this.combo1trigger.Text == "v")
        this.combo1val = 86;
      if (this.combo1trigger.Text == "w")
        this.combo1val = 87;
      if (this.combo1trigger.Text == "x")
        this.combo1val = 88;
      if (this.combo1trigger.Text == "y")
        this.combo1val = 89;
      if (!(this.combo1trigger.Text == "z"))
        return;
      this.combo1val = 90;
    }

    public void SetMacro1() => this.macro1 = this.ConvertMacro(ComboEdit.ConvertWhitespaceToSpacesRegex(this.combo1box.Text).Replace("  ", ",").Split(','));

    private void combo1_leave(object sender, EventArgs e) => this.SetMacro1();

    private void macro1_key(object sender, KeyEventArgs e)
    {
      this.combo1val = e.KeyValue;
      if (e.KeyValue == 45)
        this.combo1trigger.Text = "Insert";
      else if (e.KeyValue == 46)
        this.combo1trigger.Text = "Del";
      else if (e.KeyValue == 36)
        this.combo1trigger.Text = "Home";
      else if (e.KeyValue == 35)
        this.combo1trigger.Text = "End";
      else if (e.KeyValue == 33)
        this.combo1trigger.Text = "Pg Up";
      else if (e.KeyValue == 34)
        this.combo1trigger.Text = "Pg Dwn";
      else if (e.KeyValue == 122)
        this.combo1trigger.Text = "F11";
      else if (e.KeyValue == 113)
        this.combo1trigger.Text = "F2";
      else if (e.KeyValue == 114)
        this.combo1trigger.Text = "F3";
      else if (e.KeyValue == 115)
        this.combo1trigger.Text = "F4";
      else if (e.KeyValue == 117)
        this.combo1trigger.Text = "F6";
      else if (e.KeyValue == 118)
        this.combo1trigger.Text = "F7";
      else if (e.KeyValue == 119)
        this.combo1trigger.Text = "F8";
      else if (e.KeyValue == 192)
        this.combo1trigger.Text = "~";
      else if (e.KeyValue == 189)
        this.combo1trigger.Text = "-";
      else if (e.KeyValue == 187)
        this.combo1trigger.Text = "=";
      else if (e.KeyValue == 219)
        this.combo1trigger.Text = "[";
      else if (e.KeyValue == 221)
        this.combo1trigger.Text = "]";
      else if (e.KeyValue == 220)
        this.combo1trigger.Text = "\\";
      else if (e.KeyValue == 222)
        this.combo1trigger.Text = "'";
      else if (e.KeyValue == 186)
        this.combo1trigger.Text = ";";
      else if (e.KeyValue == 191)
        this.combo1trigger.Text = "/";
      else if (e.KeyValue == 190)
        this.combo1trigger.Text = ".";
      else if (e.KeyValue == 188)
        this.combo1trigger.Text = ",";
      else if (e.KeyValue == 96)
        this.combo1trigger.Text = "Num0";
      else if (e.KeyValue == 97)
        this.combo1trigger.Text = "Num1";
      else if (e.KeyValue == 98)
        this.combo1trigger.Text = "Num2";
      else if (e.KeyValue == 99)
        this.combo1trigger.Text = "Num3";
      else if (e.KeyValue == 100)
        this.combo1trigger.Text = "Num4";
      else if (e.KeyValue == 101)
        this.combo1trigger.Text = "Num5";
      else if (e.KeyValue == 102)
        this.combo1trigger.Text = "Num6";
      else if (e.KeyValue == 103)
        this.combo1trigger.Text = "Num7";
      else if (e.KeyValue == 104)
        this.combo1trigger.Text = "Num8";
      else if (e.KeyValue == 105)
        this.combo1trigger.Text = "Num9";
      else if (e.KeyValue == 106)
        this.combo1trigger.Text = "Mult";
      else if (e.KeyValue == 111)
        this.combo1trigger.Text = "Div";
      else if (e.KeyValue == 109)
        this.combo1trigger.Text = "Sub";
      else if (e.KeyValue == 107)
        this.combo1trigger.Text = "Add";
      else if (e.KeyValue == 110)
        this.combo1trigger.Text = "Dec";
      else if (e.KeyValue == 65)
        this.combo1trigger.Text = "a";
      else if (e.KeyValue == 66)
        this.combo1trigger.Text = "b";
      else if (e.KeyValue == 67)
        this.combo1trigger.Text = "c";
      else if (e.KeyValue == 68)
        this.combo1trigger.Text = "d";
      else if (e.KeyValue == 69)
        this.combo1trigger.Text = "e";
      else if (e.KeyValue == 70)
        this.combo1trigger.Text = "f";
      else if (e.KeyValue == 71)
        this.combo1trigger.Text = "g";
      else if (e.KeyValue == 72)
        this.combo1trigger.Text = "h";
      else if (e.KeyValue == 73)
        this.combo1trigger.Text = "i";
      else if (e.KeyValue == 74)
        this.combo1trigger.Text = "j";
      else if (e.KeyValue == 75)
        this.combo1trigger.Text = "k";
      else if (e.KeyValue == 76)
        this.combo1trigger.Text = "l";
      else if (e.KeyValue == 77)
        this.combo1trigger.Text = "m";
      else if (e.KeyValue == 78)
        this.combo1trigger.Text = "n";
      else if (e.KeyValue == 79)
        this.combo1trigger.Text = "o";
      else if (e.KeyValue == 80)
        this.combo1trigger.Text = "p";
      else if (e.KeyValue == 81)
        this.combo1trigger.Text = "q";
      else if (e.KeyValue == 82)
        this.combo1trigger.Text = "r";
      else if (e.KeyValue == 83)
        this.combo1trigger.Text = "s";
      else if (e.KeyValue == 84)
        this.combo1trigger.Text = "t";
      else if (e.KeyValue == 85)
        this.combo1trigger.Text = "u";
      else if (e.KeyValue == 86)
        this.combo1trigger.Text = "v";
      else if (e.KeyValue == 87)
        this.combo1trigger.Text = "w";
      else if (e.KeyValue == 88)
        this.combo1trigger.Text = "x";
      else if (e.KeyValue == 89)
        this.combo1trigger.Text = "y";
      else if (e.KeyValue == 90)
        this.combo1trigger.Text = "z";
      else if (e.KeyValue == 48)
        this.combo1trigger.Text = "0";
      else if (e.KeyValue == 49)
        this.combo1trigger.Text = "1";
      else if (e.KeyValue == 50)
        this.combo1trigger.Text = "2";
      else if (e.KeyValue == 51)
        this.combo1trigger.Text = "3";
      else if (e.KeyValue == 52)
        this.combo1trigger.Text = "4";
      else if (e.KeyValue == 53)
        this.combo1trigger.Text = "5";
      else if (e.KeyValue == 54)
        this.combo1trigger.Text = "6";
      else if (e.KeyValue == 55)
        this.combo1trigger.Text = "7";
      else if (e.KeyValue == 56)
      {
        this.combo1trigger.Text = "8";
      }
      else
      {
        if (e.KeyValue != 57)
          return;
        this.combo1trigger.Text = "9";
      }
    }

    private void macro1_keydown(object sender, KeyEventArgs e) => e.Handled = true;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.label41 = new Label();
      this.combo1box = new TextBox();
      this.combo1mod = new ComboBox();
      this.label17 = new Label();
      this.combo1trigger = new TextBox();
      this.usemacro1 = new CheckBox();
      this.comboslistbox = new ListBox();
      this.SuspendLayout();
      this.label41.AutoSize = true;
      this.label41.Location = new System.Drawing.Point(228, 329);
      this.label41.Name = "label41";
      this.label41.Size = new Size(44, 13);
      this.label41.TabIndex = 44;
      this.label41.Text = "Modifier";
      this.combo1box.Font = new Font("Arial", 9f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.combo1box.Location = new System.Drawing.Point(225, 32);
      this.combo1box.Multiline = true;
      this.combo1box.Name = "combo1box";
      this.combo1box.ScrollBars = ScrollBars.Vertical;
      this.combo1box.Size = new Size(122, 223);
      this.combo1box.TabIndex = 43;
      this.combo1box.Text = "WFF\r\nCK\r\nS:100\r\nSD\r\nDS\r\nWK\r\nSever\r\nCharge\r\nHemloch\r\nCrasher\r\nSpace";
      this.combo1mod.DropDownStyle = ComboBoxStyle.DropDownList;
      this.combo1mod.Font = new Font("Arial", 9f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.combo1mod.FormattingEnabled = true;
      this.combo1mod.Items.AddRange(new object[4]
      {
        (object) "None",
        (object) "Ctrl",
        (object) "Alt",
        (object) "Shift"
      });
      this.combo1mod.Location = new System.Drawing.Point(284, 326);
      this.combo1mod.Name = "combo1mod";
      this.combo1mod.Size = new Size(53, 23);
      this.combo1mod.TabIndex = 42;
      this.label17.AutoSize = true;
      this.label17.Location = new System.Drawing.Point(228, 302);
      this.label17.Name = "label17";
      this.label17.Size = new Size(43, 13);
      this.label17.TabIndex = 41;
      this.label17.Text = "Trigger:";
      this.combo1trigger.Font = new Font("Arial", 9f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.combo1trigger.Location = new System.Drawing.Point(281, 299);
      this.combo1trigger.MaxLength = 7;
      this.combo1trigger.Name = "combo1trigger";
      this.combo1trigger.Size = new Size(56, 21);
      this.combo1trigger.TabIndex = 40;
      this.combo1trigger.Text = "a";
      this.usemacro1.AutoSize = true;
      this.usemacro1.Location = new System.Drawing.Point(225, 274);
      this.usemacro1.Name = "usemacro1";
      this.usemacro1.Size = new Size(87, 17);
      this.usemacro1.TabIndex = 39;
      this.usemacro1.Text = "Use Macro 1";
      this.usemacro1.UseVisualStyleBackColor = true;
      this.comboslistbox.FormattingEnabled = true;
      this.comboslistbox.Location = new System.Drawing.Point(46, 32);
      this.comboslistbox.Name = "comboslistbox";
      this.comboslistbox.Size = new Size(103, 199);
      this.comboslistbox.TabIndex = 45;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(399, 374);
      this.Controls.Add((Control) this.comboslistbox);
      this.Controls.Add((Control) this.label41);
      this.Controls.Add((Control) this.combo1box);
      this.Controls.Add((Control) this.combo1mod);
      this.Controls.Add((Control) this.label17);
      this.Controls.Add((Control) this.combo1trigger);
      this.Controls.Add((Control) this.usemacro1);
      this.Name =  "ComboEdit";
      this.Text =  "ComboEdit";
      this.FormClosing += new FormClosingEventHandler(this.ComboEdit_FormClosing);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
