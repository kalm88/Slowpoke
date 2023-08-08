//SlowPoke
// Type: Flintstones.ComboOptions1
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
  public class ComboOptions1 : Form
  {
    public MainForm parent;
    public string[] macro1 = new string[1]{ "" };
    public string[] macro2 = new string[1]{ "" };
    public string[] macro3 = new string[1]{ "" };
    public string[] macro4 = new string[1]{ "" };
    public string[] macro5 = new string[1]{ "" };
    public string[] macro6 = new string[1]{ "" };
    public string[] macro7 = new string[1]{ "" };
    public string[] macro8 = new string[1]{ "" };
    public string[] macro9 = new string[1]{ "" };
    public string[] macro10 = new string[1]{ "" };
    public int combo1val;
    public int combo2val;
    public int combo3val;
    public int combo4val;
    public int combo5val;
    public int combo6val;
    public int combo7val;
    public int combo8val;
    public int combo9val;
    public int combo10val;
    private IContainer components;
    private GroupBox groupBox35;
    public Label label44;
    public Label label43;
    public Label label42;
    public Label label41;
    public TextBox combo4box;
    public TextBox combo3box;
    public TextBox combo2box;
    public TextBox combo1box;
    public Label label40;
    public TextBox combo4trigger;
    public ComboBox combo4mod;
    public CheckBox usemacro4;
    public ComboBox combo2mod;
    public Label label32;
    public TextBox combo3trigger;
    public ComboBox combo3mod;
    public Label label26;
    public TextBox combo2trigger;
    public ComboBox combo1mod;
    public Label label17;
    public TextBox combo1trigger;
    private Label label12;
    public CheckBox usemacro3;
    public CheckBox usemacro2;
    public CheckBox usemacro1;
    public Label label1;
    public TextBox combo5box;
    public Label label2;
    public TextBox combo5trigger;
    public ComboBox combo5mod;
    public CheckBox usemacro5;
    public TextBox combo1name;
    private Label label14;
    public TextBox combo5name;
    private Label label19;
    public TextBox combo4name;
    private Label label18;
    public TextBox combo3name;
    private Label label16;
    public TextBox combo2name;
    private Label label15;
    public TextBox combo10name;
    private Label label22;
    public Label label23;
    public TextBox combo10box;
    public Label label24;
    public TextBox combo10trigger;
    public ComboBox combo10mod;
    public CheckBox usemacro10;
    public TextBox combo9name;
    private Label label13;
    public Label label20;
    public TextBox combo9box;
    public Label label21;
    public TextBox combo9trigger;
    public ComboBox combo9mod;
    public CheckBox usemacro9;
    public TextBox combo8name;
    private Label label9;
    public Label label10;
    public TextBox combo8box;
    public Label label11;
    public TextBox combo8trigger;
    public ComboBox combo8mod;
    public CheckBox usemacro8;
    public TextBox combo7name;
    private Label label6;
    public Label label7;
    public TextBox combo7box;
    public Label label8;
    public TextBox combo7trigger;
    public ComboBox combo7mod;
    public CheckBox usemacro7;
    public TextBox combo6name;
    private Label label3;
    public Label label4;
    public TextBox combo6box;
    public Label label5;
    public TextBox combo6trigger;
    public ComboBox combo6mod;
    public CheckBox usemacro6;
    private Label label25;

    public Client Client { get; private set; }

    public ComboOptions1(Client client)
    {
      this.parent = Program.MainForm;
      this.Client = client;
      this.InitializeComponent();
      this.combo1mod.SelectedIndex = 0;
      this.combo2mod.SelectedIndex = 0;
      this.combo3mod.SelectedIndex = 0;
      this.combo4mod.SelectedIndex = 0;
      this.combo5mod.SelectedIndex = 0;
      this.combo6mod.SelectedIndex = 0;
      this.combo7mod.SelectedIndex = 0;
      this.combo8mod.SelectedIndex = 0;
      this.combo9mod.SelectedIndex = 0;
      this.combo10mod.SelectedIndex = 0;
    }

    private void ComboOptions1_FormClosing(object sender, FormClosingEventArgs e)
    {
      e.Cancel = true;
      this.Hide();
      this.Client.Tab.opencomboform.Enabled = true;
    }

    public void LoadCombos()
    {
      this.SetMacro1();
      this.SetMacro2();
      this.SetMacro3();
      this.SetMacro4();
      this.SetMacro5();
      this.SetMacro6();
      this.SetMacro7();
      this.SetMacro8();
      this.SetMacro9();
      this.SetMacro10();
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
      if (this.combo1trigger.Text == "z")
        this.combo1val = 90;
      if (this.combo2trigger.Text == "Insert")
        this.combo2val = 45;
      if (this.combo2trigger.Text == "Del")
        this.combo2val = 36;
      if (this.combo2trigger.Text == "Home")
        this.combo2val = 36;
      if (this.combo2trigger.Text == "End")
        this.combo2val = 35;
      if (this.combo2trigger.Text == "Pg Up")
        this.combo2val = 33;
      if (this.combo2trigger.Text == "Pg Dwn")
        this.combo2val = 34;
      if (this.combo2trigger.Text == "F11")
        this.combo2val = 122;
      if (this.combo2trigger.Text == "F2")
        this.combo2val = 113;
      if (this.combo2trigger.Text == "F3")
        this.combo2val = 114;
      if (this.combo2trigger.Text == "F4")
        this.combo2val = 115;
      if (this.combo2trigger.Text == "F6")
        this.combo2val = 117;
      if (this.combo2trigger.Text == "F7")
        this.combo2val = 118;
      if (this.combo2trigger.Text == "F8")
        this.combo2val = 119;
      if (this.combo2trigger.Text == "~")
        this.combo2val = 192;
      if (this.combo2trigger.Text == "-")
        this.combo2val = 189;
      if (this.combo2trigger.Text == "=")
        this.combo2val = 187;
      if (this.combo2trigger.Text == "[")
        this.combo2val = 219;
      if (this.combo2trigger.Text == "]")
        this.combo2val = 221;
      if (this.combo2trigger.Text == "\\")
        this.combo2val = 220;
      if (this.combo2trigger.Text == "'")
        this.combo2val = 222;
      if (this.combo2trigger.Text == ";")
        this.combo2val = 186;
      if (this.combo2trigger.Text == "/")
        this.combo2val = 191;
      if (this.combo2trigger.Text == ".")
        this.combo2val = 190;
      if (this.combo2trigger.Text == ",")
        this.combo2val = 188;
      if (this.combo2trigger.Text == "Num0")
        this.combo2val = 96;
      if (this.combo2trigger.Text == "Num1")
        this.combo2val = 97;
      if (this.combo2trigger.Text == "Num2")
        this.combo2val = 98;
      if (this.combo2trigger.Text == "Num3")
        this.combo2val = 99;
      if (this.combo2trigger.Text == "Num4")
        this.combo2val = 100;
      if (this.combo2trigger.Text == "Num5")
        this.combo2val = 101;
      if (this.combo2trigger.Text == "Num6")
        this.combo2val = 102;
      if (this.combo2trigger.Text == "Num7")
        this.combo2val = 103;
      if (this.combo2trigger.Text == "Num8")
        this.combo2val = 104;
      if (this.combo2trigger.Text == "Num9")
        this.combo2val = 105;
      if (this.combo2trigger.Text == "Mult")
        this.combo2val = 106;
      if (this.combo2trigger.Text == "Div")
        this.combo2val = 111;
      if (this.combo2trigger.Text == "Sub")
        this.combo2val = 109;
      if (this.combo2trigger.Text == "Add")
        this.combo2val = 107;
      if (this.combo2trigger.Text == "Dec")
        this.combo2val = 110;
      if (this.combo2trigger.Text == "0")
        this.combo2val = 48;
      if (this.combo2trigger.Text == "1")
        this.combo2val = 49;
      if (this.combo2trigger.Text == "2")
        this.combo2val = 50;
      if (this.combo2trigger.Text == "3")
        this.combo2val = 51;
      if (this.combo2trigger.Text == "4")
        this.combo2val = 52;
      if (this.combo2trigger.Text == "5")
        this.combo2val = 53;
      if (this.combo2trigger.Text == "6")
        this.combo2val = 54;
      if (this.combo2trigger.Text == "7")
        this.combo2val = 55;
      if (this.combo2trigger.Text == "8")
        this.combo2val = 56;
      if (this.combo2trigger.Text == "9")
        this.combo2val = 57;
      if (this.combo2trigger.Text == "a")
        this.combo2val = 65;
      if (this.combo2trigger.Text == "b")
        this.combo2val = 66;
      if (this.combo2trigger.Text == "c")
        this.combo2val = 67;
      if (this.combo2trigger.Text == "d")
        this.combo2val = 68;
      if (this.combo2trigger.Text == "e")
        this.combo2val = 69;
      if (this.combo2trigger.Text == "f")
        this.combo2val = 70;
      if (this.combo2trigger.Text == "g")
        this.combo2val = 71;
      if (this.combo2trigger.Text == "h")
        this.combo2val = 72;
      if (this.combo2trigger.Text == "i")
        this.combo2val = 73;
      if (this.combo2trigger.Text == "j")
        this.combo2val = 74;
      if (this.combo2trigger.Text == "k")
        this.combo2val = 75;
      if (this.combo2trigger.Text == "l")
        this.combo2val = 76;
      if (this.combo2trigger.Text == "m")
        this.combo2val = 77;
      if (this.combo2trigger.Text == "n")
        this.combo2val = 78;
      if (this.combo2trigger.Text == "o")
        this.combo2val = 79;
      if (this.combo2trigger.Text == "p")
        this.combo2val = 80;
      if (this.combo2trigger.Text == "q")
        this.combo2val = 81;
      if (this.combo2trigger.Text == "r")
        this.combo2val = 82;
      if (this.combo2trigger.Text == "s")
        this.combo2val = 83;
      if (this.combo2trigger.Text == "t")
        this.combo2val = 84;
      if (this.combo2trigger.Text == "u")
        this.combo2val = 85;
      if (this.combo2trigger.Text == "v")
        this.combo2val = 86;
      if (this.combo2trigger.Text == "w")
        this.combo2val = 87;
      if (this.combo2trigger.Text == "x")
        this.combo2val = 88;
      if (this.combo2trigger.Text == "y")
        this.combo2val = 89;
      if (this.combo2trigger.Text == "z")
        this.combo2val = 90;
      if (this.combo3trigger.Text == "Insert")
        this.combo3val = 45;
      if (this.combo3trigger.Text == "Del")
        this.combo3val = 36;
      if (this.combo3trigger.Text == "Home")
        this.combo3val = 36;
      if (this.combo3trigger.Text == "End")
        this.combo3val = 35;
      if (this.combo3trigger.Text == "Pg Up")
        this.combo3val = 33;
      if (this.combo3trigger.Text == "Pg Dwn")
        this.combo3val = 34;
      if (this.combo3trigger.Text == "F11")
        this.combo3val = 122;
      if (this.combo3trigger.Text == "F2")
        this.combo3val = 113;
      if (this.combo3trigger.Text == "F3")
        this.combo3val = 114;
      if (this.combo3trigger.Text == "F4")
        this.combo3val = 115;
      if (this.combo3trigger.Text == "F6")
        this.combo3val = 117;
      if (this.combo3trigger.Text == "F7")
        this.combo3val = 118;
      if (this.combo3trigger.Text == "F8")
        this.combo3val = 119;
      if (this.combo3trigger.Text == "~")
        this.combo3val = 192;
      if (this.combo3trigger.Text == "-")
        this.combo3val = 189;
      if (this.combo3trigger.Text == "=")
        this.combo3val = 187;
      if (this.combo3trigger.Text == "[")
        this.combo3val = 219;
      if (this.combo3trigger.Text == "]")
        this.combo3val = 221;
      if (this.combo3trigger.Text == "\\")
        this.combo3val = 220;
      if (this.combo3trigger.Text == "'")
        this.combo3val = 222;
      if (this.combo3trigger.Text == ";")
        this.combo3val = 186;
      if (this.combo3trigger.Text == "/")
        this.combo3val = 191;
      if (this.combo3trigger.Text == ".")
        this.combo3val = 190;
      if (this.combo3trigger.Text == ",")
        this.combo3val = 188;
      if (this.combo3trigger.Text == "Num0")
        this.combo3val = 96;
      if (this.combo3trigger.Text == "Num1")
        this.combo3val = 97;
      if (this.combo3trigger.Text == "Num2")
        this.combo3val = 98;
      if (this.combo3trigger.Text == "Num3")
        this.combo3val = 99;
      if (this.combo3trigger.Text == "Num4")
        this.combo3val = 100;
      if (this.combo3trigger.Text == "Num5")
        this.combo3val = 101;
      if (this.combo3trigger.Text == "Num6")
        this.combo3val = 102;
      if (this.combo3trigger.Text == "Num7")
        this.combo3val = 103;
      if (this.combo3trigger.Text == "Num8")
        this.combo3val = 104;
      if (this.combo3trigger.Text == "Num9")
        this.combo3val = 105;
      if (this.combo3trigger.Text == "Mult")
        this.combo3val = 106;
      if (this.combo3trigger.Text == "Div")
        this.combo3val = 111;
      if (this.combo3trigger.Text == "Sub")
        this.combo3val = 109;
      if (this.combo3trigger.Text == "Add")
        this.combo3val = 107;
      if (this.combo3trigger.Text == "Dec")
        this.combo3val = 110;
      if (this.combo3trigger.Text == "0")
        this.combo3val = 48;
      if (this.combo3trigger.Text == "1")
        this.combo3val = 49;
      if (this.combo3trigger.Text == "2")
        this.combo3val = 50;
      if (this.combo3trigger.Text == "3")
        this.combo3val = 51;
      if (this.combo3trigger.Text == "4")
        this.combo3val = 52;
      if (this.combo3trigger.Text == "5")
        this.combo3val = 53;
      if (this.combo3trigger.Text == "6")
        this.combo3val = 54;
      if (this.combo3trigger.Text == "7")
        this.combo3val = 55;
      if (this.combo3trigger.Text == "8")
        this.combo3val = 56;
      if (this.combo3trigger.Text == "9")
        this.combo3val = 57;
      if (this.combo3trigger.Text == "a")
        this.combo3val = 65;
      if (this.combo3trigger.Text == "b")
        this.combo3val = 66;
      if (this.combo3trigger.Text == "c")
        this.combo3val = 67;
      if (this.combo3trigger.Text == "d")
        this.combo3val = 68;
      if (this.combo3trigger.Text == "e")
        this.combo3val = 69;
      if (this.combo3trigger.Text == "f")
        this.combo3val = 70;
      if (this.combo3trigger.Text == "g")
        this.combo3val = 71;
      if (this.combo3trigger.Text == "h")
        this.combo3val = 72;
      if (this.combo3trigger.Text == "i")
        this.combo3val = 73;
      if (this.combo3trigger.Text == "j")
        this.combo3val = 74;
      if (this.combo3trigger.Text == "k")
        this.combo3val = 75;
      if (this.combo3trigger.Text == "l")
        this.combo3val = 76;
      if (this.combo3trigger.Text == "m")
        this.combo3val = 77;
      if (this.combo3trigger.Text == "n")
        this.combo3val = 78;
      if (this.combo3trigger.Text == "o")
        this.combo3val = 79;
      if (this.combo3trigger.Text == "p")
        this.combo3val = 80;
      if (this.combo3trigger.Text == "q")
        this.combo3val = 81;
      if (this.combo3trigger.Text == "r")
        this.combo3val = 82;
      if (this.combo3trigger.Text == "s")
        this.combo3val = 83;
      if (this.combo3trigger.Text == "t")
        this.combo3val = 84;
      if (this.combo3trigger.Text == "u")
        this.combo3val = 85;
      if (this.combo3trigger.Text == "v")
        this.combo3val = 86;
      if (this.combo3trigger.Text == "w")
        this.combo3val = 87;
      if (this.combo3trigger.Text == "x")
        this.combo3val = 88;
      if (this.combo3trigger.Text == "y")
        this.combo3val = 89;
      if (this.combo3trigger.Text == "z")
        this.combo3val = 90;
      if (this.combo4trigger.Text == "Insert")
        this.combo4val = 45;
      if (this.combo4trigger.Text == "Del")
        this.combo4val = 36;
      if (this.combo4trigger.Text == "Home")
        this.combo4val = 36;
      if (this.combo4trigger.Text == "End")
        this.combo4val = 35;
      if (this.combo4trigger.Text == "Pg Up")
        this.combo4val = 33;
      if (this.combo4trigger.Text == "Pg Dwn")
        this.combo4val = 34;
      if (this.combo4trigger.Text == "F11")
        this.combo4val = 122;
      if (this.combo4trigger.Text == "F2")
        this.combo4val = 113;
      if (this.combo4trigger.Text == "F3")
        this.combo4val = 114;
      if (this.combo4trigger.Text == "F4")
        this.combo4val = 115;
      if (this.combo4trigger.Text == "F6")
        this.combo4val = 117;
      if (this.combo4trigger.Text == "F7")
        this.combo4val = 118;
      if (this.combo4trigger.Text == "F8")
        this.combo4val = 119;
      if (this.combo4trigger.Text == "~")
        this.combo4val = 192;
      if (this.combo4trigger.Text == "-")
        this.combo4val = 189;
      if (this.combo4trigger.Text == "=")
        this.combo4val = 187;
      if (this.combo4trigger.Text == "[")
        this.combo4val = 219;
      if (this.combo4trigger.Text == "]")
        this.combo4val = 221;
      if (this.combo4trigger.Text == "\\")
        this.combo4val = 220;
      if (this.combo4trigger.Text == "'")
        this.combo4val = 222;
      if (this.combo4trigger.Text == ";")
        this.combo4val = 186;
      if (this.combo4trigger.Text == "/")
        this.combo4val = 191;
      if (this.combo4trigger.Text == ".")
        this.combo4val = 190;
      if (this.combo4trigger.Text == ",")
        this.combo4val = 188;
      if (this.combo4trigger.Text == "Num0")
        this.combo4val = 96;
      if (this.combo4trigger.Text == "Num1")
        this.combo4val = 97;
      if (this.combo4trigger.Text == "Num2")
        this.combo4val = 98;
      if (this.combo4trigger.Text == "Num3")
        this.combo4val = 99;
      if (this.combo4trigger.Text == "Num4")
        this.combo4val = 100;
      if (this.combo4trigger.Text == "Num5")
        this.combo4val = 101;
      if (this.combo4trigger.Text == "Num6")
        this.combo4val = 102;
      if (this.combo4trigger.Text == "Num7")
        this.combo4val = 103;
      if (this.combo4trigger.Text == "Num8")
        this.combo4val = 104;
      if (this.combo4trigger.Text == "Num9")
        this.combo4val = 105;
      if (this.combo4trigger.Text == "Mult")
        this.combo4val = 106;
      if (this.combo4trigger.Text == "Div")
        this.combo4val = 111;
      if (this.combo4trigger.Text == "Sub")
        this.combo4val = 109;
      if (this.combo4trigger.Text == "Add")
        this.combo4val = 107;
      if (this.combo4trigger.Text == "Dec")
        this.combo4val = 110;
      if (this.combo4trigger.Text == "0")
        this.combo4val = 48;
      if (this.combo4trigger.Text == "1")
        this.combo4val = 49;
      if (this.combo4trigger.Text == "2")
        this.combo4val = 50;
      if (this.combo4trigger.Text == "3")
        this.combo4val = 51;
      if (this.combo4trigger.Text == "4")
        this.combo4val = 52;
      if (this.combo4trigger.Text == "5")
        this.combo4val = 53;
      if (this.combo4trigger.Text == "6")
        this.combo4val = 54;
      if (this.combo4trigger.Text == "7")
        this.combo4val = 55;
      if (this.combo4trigger.Text == "8")
        this.combo4val = 56;
      if (this.combo4trigger.Text == "9")
        this.combo4val = 57;
      if (this.combo4trigger.Text == "a")
        this.combo4val = 65;
      if (this.combo4trigger.Text == "b")
        this.combo4val = 66;
      if (this.combo4trigger.Text == "c")
        this.combo4val = 67;
      if (this.combo4trigger.Text == "d")
        this.combo4val = 68;
      if (this.combo4trigger.Text == "e")
        this.combo4val = 69;
      if (this.combo4trigger.Text == "f")
        this.combo4val = 70;
      if (this.combo4trigger.Text == "g")
        this.combo4val = 71;
      if (this.combo4trigger.Text == "h")
        this.combo4val = 72;
      if (this.combo4trigger.Text == "i")
        this.combo4val = 73;
      if (this.combo4trigger.Text == "j")
        this.combo4val = 74;
      if (this.combo4trigger.Text == "k")
        this.combo4val = 75;
      if (this.combo4trigger.Text == "l")
        this.combo4val = 76;
      if (this.combo4trigger.Text == "m")
        this.combo4val = 77;
      if (this.combo4trigger.Text == "n")
        this.combo4val = 78;
      if (this.combo4trigger.Text == "o")
        this.combo4val = 79;
      if (this.combo4trigger.Text == "p")
        this.combo4val = 80;
      if (this.combo4trigger.Text == "q")
        this.combo4val = 81;
      if (this.combo4trigger.Text == "r")
        this.combo4val = 82;
      if (this.combo4trigger.Text == "s")
        this.combo4val = 83;
      if (this.combo4trigger.Text == "t")
        this.combo4val = 84;
      if (this.combo4trigger.Text == "u")
        this.combo4val = 85;
      if (this.combo4trigger.Text == "v")
        this.combo4val = 86;
      if (this.combo4trigger.Text == "w")
        this.combo4val = 87;
      if (this.combo4trigger.Text == "x")
        this.combo4val = 88;
      if (this.combo4trigger.Text == "y")
        this.combo4val = 89;
      if (this.combo4trigger.Text == "z")
        this.combo4val = 90;
      if (this.combo5trigger.Text == "Insert")
        this.combo5val = 45;
      if (this.combo5trigger.Text == "Del")
        this.combo5val = 36;
      if (this.combo5trigger.Text == "Home")
        this.combo5val = 36;
      if (this.combo5trigger.Text == "End")
        this.combo5val = 35;
      if (this.combo5trigger.Text == "Pg Up")
        this.combo5val = 33;
      if (this.combo5trigger.Text == "Pg Dwn")
        this.combo5val = 34;
      if (this.combo5trigger.Text == "F11")
        this.combo5val = 122;
      if (this.combo5trigger.Text == "F2")
        this.combo5val = 113;
      if (this.combo5trigger.Text == "F3")
        this.combo5val = 114;
      if (this.combo5trigger.Text == "F4")
        this.combo5val = 115;
      if (this.combo5trigger.Text == "F6")
        this.combo5val = 117;
      if (this.combo5trigger.Text == "F7")
        this.combo5val = 118;
      if (this.combo5trigger.Text == "F8")
        this.combo5val = 119;
      if (this.combo5trigger.Text == "~")
        this.combo5val = 192;
      if (this.combo5trigger.Text == "-")
        this.combo5val = 189;
      if (this.combo5trigger.Text == "=")
        this.combo5val = 187;
      if (this.combo5trigger.Text == "[")
        this.combo5val = 219;
      if (this.combo5trigger.Text == "]")
        this.combo5val = 221;
      if (this.combo5trigger.Text == "\\")
        this.combo5val = 220;
      if (this.combo5trigger.Text == "'")
        this.combo5val = 222;
      if (this.combo5trigger.Text == ";")
        this.combo5val = 186;
      if (this.combo5trigger.Text == "/")
        this.combo5val = 191;
      if (this.combo5trigger.Text == ".")
        this.combo5val = 190;
      if (this.combo5trigger.Text == ",")
        this.combo5val = 188;
      if (this.combo5trigger.Text == "Num0")
        this.combo5val = 96;
      if (this.combo5trigger.Text == "Num1")
        this.combo5val = 97;
      if (this.combo5trigger.Text == "Num2")
        this.combo5val = 98;
      if (this.combo5trigger.Text == "Num3")
        this.combo5val = 99;
      if (this.combo5trigger.Text == "Num4")
        this.combo5val = 100;
      if (this.combo5trigger.Text == "Num5")
        this.combo5val = 101;
      if (this.combo5trigger.Text == "Num6")
        this.combo5val = 102;
      if (this.combo5trigger.Text == "Num7")
        this.combo5val = 103;
      if (this.combo5trigger.Text == "Num8")
        this.combo5val = 104;
      if (this.combo5trigger.Text == "Num9")
        this.combo5val = 105;
      if (this.combo5trigger.Text == "Mult")
        this.combo5val = 106;
      if (this.combo5trigger.Text == "Div")
        this.combo5val = 111;
      if (this.combo5trigger.Text == "Sub")
        this.combo5val = 109;
      if (this.combo5trigger.Text == "Add")
        this.combo5val = 107;
      if (this.combo5trigger.Text == "Dec")
        this.combo5val = 110;
      if (this.combo5trigger.Text == "0")
        this.combo5val = 48;
      if (this.combo5trigger.Text == "1")
        this.combo5val = 49;
      if (this.combo5trigger.Text == "2")
        this.combo5val = 50;
      if (this.combo5trigger.Text == "3")
        this.combo5val = 51;
      if (this.combo5trigger.Text == "4")
        this.combo5val = 52;
      if (this.combo5trigger.Text == "5")
        this.combo5val = 53;
      if (this.combo5trigger.Text == "6")
        this.combo5val = 54;
      if (this.combo5trigger.Text == "7")
        this.combo5val = 55;
      if (this.combo5trigger.Text == "8")
        this.combo5val = 56;
      if (this.combo5trigger.Text == "9")
        this.combo5val = 57;
      if (this.combo5trigger.Text == "a")
        this.combo5val = 65;
      if (this.combo5trigger.Text == "b")
        this.combo5val = 66;
      if (this.combo5trigger.Text == "c")
        this.combo5val = 67;
      if (this.combo5trigger.Text == "d")
        this.combo5val = 68;
      if (this.combo5trigger.Text == "e")
        this.combo5val = 69;
      if (this.combo5trigger.Text == "f")
        this.combo5val = 70;
      if (this.combo5trigger.Text == "g")
        this.combo5val = 71;
      if (this.combo5trigger.Text == "h")
        this.combo5val = 72;
      if (this.combo5trigger.Text == "i")
        this.combo5val = 73;
      if (this.combo5trigger.Text == "j")
        this.combo5val = 74;
      if (this.combo5trigger.Text == "k")
        this.combo5val = 75;
      if (this.combo5trigger.Text == "l")
        this.combo5val = 76;
      if (this.combo5trigger.Text == "m")
        this.combo5val = 77;
      if (this.combo5trigger.Text == "n")
        this.combo5val = 78;
      if (this.combo5trigger.Text == "o")
        this.combo5val = 79;
      if (this.combo5trigger.Text == "p")
        this.combo5val = 80;
      if (this.combo5trigger.Text == "q")
        this.combo5val = 81;
      if (this.combo5trigger.Text == "r")
        this.combo5val = 82;
      if (this.combo5trigger.Text == "s")
        this.combo5val = 83;
      if (this.combo5trigger.Text == "t")
        this.combo5val = 84;
      if (this.combo5trigger.Text == "u")
        this.combo5val = 85;
      if (this.combo5trigger.Text == "v")
        this.combo5val = 86;
      if (this.combo5trigger.Text == "w")
        this.combo5val = 87;
      if (this.combo5trigger.Text == "x")
        this.combo5val = 88;
      if (this.combo5trigger.Text == "y")
        this.combo5val = 89;
      if (this.combo5trigger.Text == "z")
        this.combo5val = 90;
      if (this.combo6trigger.Text == "Insert")
        this.combo6val = 45;
      if (this.combo6trigger.Text == "Del")
        this.combo6val = 36;
      if (this.combo6trigger.Text == "Home")
        this.combo6val = 36;
      if (this.combo6trigger.Text == "End")
        this.combo6val = 35;
      if (this.combo6trigger.Text == "Pg Up")
        this.combo6val = 33;
      if (this.combo6trigger.Text == "Pg Dwn")
        this.combo6val = 34;
      if (this.combo6trigger.Text == "F11")
        this.combo6val = 122;
      if (this.combo6trigger.Text == "F2")
        this.combo6val = 113;
      if (this.combo6trigger.Text == "F3")
        this.combo6val = 114;
      if (this.combo6trigger.Text == "F4")
        this.combo6val = 115;
      if (this.combo6trigger.Text == "F6")
        this.combo6val = 117;
      if (this.combo6trigger.Text == "F7")
        this.combo6val = 118;
      if (this.combo6trigger.Text == "F8")
        this.combo6val = 119;
      if (this.combo6trigger.Text == "~")
        this.combo6val = 192;
      if (this.combo6trigger.Text == "-")
        this.combo6val = 189;
      if (this.combo6trigger.Text == "=")
        this.combo6val = 187;
      if (this.combo6trigger.Text == "[")
        this.combo6val = 219;
      if (this.combo6trigger.Text == "]")
        this.combo6val = 221;
      if (this.combo6trigger.Text == "\\")
        this.combo6val = 220;
      if (this.combo6trigger.Text == "'")
        this.combo6val = 222;
      if (this.combo6trigger.Text == ";")
        this.combo6val = 186;
      if (this.combo6trigger.Text == "/")
        this.combo6val = 191;
      if (this.combo6trigger.Text == ".")
        this.combo6val = 190;
      if (this.combo6trigger.Text == ",")
        this.combo6val = 188;
      if (this.combo6trigger.Text == "Num0")
        this.combo6val = 96;
      if (this.combo6trigger.Text == "Num1")
        this.combo6val = 97;
      if (this.combo6trigger.Text == "Num2")
        this.combo6val = 98;
      if (this.combo6trigger.Text == "Num3")
        this.combo6val = 99;
      if (this.combo6trigger.Text == "Num4")
        this.combo6val = 100;
      if (this.combo6trigger.Text == "Num5")
        this.combo6val = 101;
      if (this.combo6trigger.Text == "Num6")
        this.combo6val = 102;
      if (this.combo6trigger.Text == "Num7")
        this.combo6val = 103;
      if (this.combo6trigger.Text == "Num8")
        this.combo6val = 104;
      if (this.combo6trigger.Text == "Num9")
        this.combo6val = 105;
      if (this.combo6trigger.Text == "Mult")
        this.combo6val = 106;
      if (this.combo6trigger.Text == "Div")
        this.combo6val = 111;
      if (this.combo6trigger.Text == "Sub")
        this.combo6val = 109;
      if (this.combo6trigger.Text == "Add")
        this.combo6val = 107;
      if (this.combo6trigger.Text == "Dec")
        this.combo6val = 110;
      if (this.combo6trigger.Text == "0")
        this.combo6val = 48;
      if (this.combo6trigger.Text == "1")
        this.combo6val = 49;
      if (this.combo6trigger.Text == "2")
        this.combo6val = 50;
      if (this.combo6trigger.Text == "3")
        this.combo6val = 51;
      if (this.combo6trigger.Text == "4")
        this.combo6val = 52;
      if (this.combo6trigger.Text == "5")
        this.combo6val = 53;
      if (this.combo6trigger.Text == "6")
        this.combo6val = 54;
      if (this.combo6trigger.Text == "7")
        this.combo6val = 55;
      if (this.combo6trigger.Text == "8")
        this.combo6val = 56;
      if (this.combo6trigger.Text == "9")
        this.combo6val = 57;
      if (this.combo6trigger.Text == "a")
        this.combo6val = 65;
      if (this.combo6trigger.Text == "b")
        this.combo6val = 66;
      if (this.combo6trigger.Text == "c")
        this.combo6val = 67;
      if (this.combo6trigger.Text == "d")
        this.combo6val = 68;
      if (this.combo6trigger.Text == "e")
        this.combo6val = 69;
      if (this.combo6trigger.Text == "f")
        this.combo6val = 70;
      if (this.combo6trigger.Text == "g")
        this.combo6val = 71;
      if (this.combo6trigger.Text == "h")
        this.combo6val = 72;
      if (this.combo6trigger.Text == "i")
        this.combo6val = 73;
      if (this.combo6trigger.Text == "j")
        this.combo6val = 74;
      if (this.combo6trigger.Text == "k")
        this.combo6val = 75;
      if (this.combo6trigger.Text == "l")
        this.combo6val = 76;
      if (this.combo6trigger.Text == "m")
        this.combo6val = 77;
      if (this.combo6trigger.Text == "n")
        this.combo6val = 78;
      if (this.combo6trigger.Text == "o")
        this.combo6val = 79;
      if (this.combo6trigger.Text == "p")
        this.combo6val = 80;
      if (this.combo6trigger.Text == "q")
        this.combo6val = 81;
      if (this.combo6trigger.Text == "r")
        this.combo6val = 82;
      if (this.combo6trigger.Text == "s")
        this.combo6val = 83;
      if (this.combo6trigger.Text == "t")
        this.combo6val = 84;
      if (this.combo6trigger.Text == "u")
        this.combo6val = 85;
      if (this.combo6trigger.Text == "v")
        this.combo6val = 86;
      if (this.combo6trigger.Text == "w")
        this.combo6val = 87;
      if (this.combo6trigger.Text == "x")
        this.combo6val = 88;
      if (this.combo6trigger.Text == "y")
        this.combo6val = 89;
      if (this.combo6trigger.Text == "z")
        this.combo6val = 90;
      if (this.combo7trigger.Text == "Insert")
        this.combo7val = 45;
      if (this.combo7trigger.Text == "Del")
        this.combo7val = 36;
      if (this.combo7trigger.Text == "Home")
        this.combo7val = 36;
      if (this.combo7trigger.Text == "End")
        this.combo7val = 35;
      if (this.combo7trigger.Text == "Pg Up")
        this.combo7val = 33;
      if (this.combo7trigger.Text == "Pg Dwn")
        this.combo7val = 34;
      if (this.combo7trigger.Text == "F11")
        this.combo7val = 122;
      if (this.combo7trigger.Text == "F2")
        this.combo7val = 113;
      if (this.combo7trigger.Text == "F3")
        this.combo7val = 114;
      if (this.combo7trigger.Text == "F4")
        this.combo7val = 115;
      if (this.combo7trigger.Text == "F6")
        this.combo7val = 117;
      if (this.combo7trigger.Text == "F7")
        this.combo7val = 118;
      if (this.combo7trigger.Text == "F8")
        this.combo7val = 119;
      if (this.combo7trigger.Text == "~")
        this.combo7val = 192;
      if (this.combo7trigger.Text == "-")
        this.combo7val = 189;
      if (this.combo7trigger.Text == "=")
        this.combo7val = 187;
      if (this.combo7trigger.Text == "[")
        this.combo7val = 219;
      if (this.combo7trigger.Text == "]")
        this.combo7val = 221;
      if (this.combo7trigger.Text == "\\")
        this.combo7val = 220;
      if (this.combo7trigger.Text == "'")
        this.combo7val = 222;
      if (this.combo7trigger.Text == ";")
        this.combo7val = 186;
      if (this.combo7trigger.Text == "/")
        this.combo7val = 191;
      if (this.combo7trigger.Text == ".")
        this.combo7val = 190;
      if (this.combo7trigger.Text == ",")
        this.combo7val = 188;
      if (this.combo7trigger.Text == "Num0")
        this.combo7val = 96;
      if (this.combo7trigger.Text == "Num1")
        this.combo7val = 97;
      if (this.combo7trigger.Text == "Num2")
        this.combo7val = 98;
      if (this.combo7trigger.Text == "Num3")
        this.combo7val = 99;
      if (this.combo7trigger.Text == "Num4")
        this.combo7val = 100;
      if (this.combo7trigger.Text == "Num5")
        this.combo7val = 101;
      if (this.combo7trigger.Text == "Num6")
        this.combo7val = 102;
      if (this.combo7trigger.Text == "Num7")
        this.combo7val = 103;
      if (this.combo7trigger.Text == "Num8")
        this.combo7val = 104;
      if (this.combo7trigger.Text == "Num9")
        this.combo7val = 105;
      if (this.combo7trigger.Text == "Mult")
        this.combo7val = 106;
      if (this.combo7trigger.Text == "Div")
        this.combo7val = 111;
      if (this.combo7trigger.Text == "Sub")
        this.combo7val = 109;
      if (this.combo7trigger.Text == "Add")
        this.combo7val = 107;
      if (this.combo7trigger.Text == "Dec")
        this.combo7val = 110;
      if (this.combo7trigger.Text == "0")
        this.combo7val = 48;
      if (this.combo7trigger.Text == "1")
        this.combo7val = 49;
      if (this.combo7trigger.Text == "2")
        this.combo7val = 50;
      if (this.combo7trigger.Text == "3")
        this.combo7val = 51;
      if (this.combo7trigger.Text == "4")
        this.combo7val = 52;
      if (this.combo7trigger.Text == "5")
        this.combo7val = 53;
      if (this.combo7trigger.Text == "6")
        this.combo7val = 54;
      if (this.combo7trigger.Text == "7")
        this.combo7val = 55;
      if (this.combo7trigger.Text == "8")
        this.combo7val = 56;
      if (this.combo7trigger.Text == "9")
        this.combo7val = 57;
      if (this.combo7trigger.Text == "a")
        this.combo7val = 65;
      if (this.combo7trigger.Text == "b")
        this.combo7val = 66;
      if (this.combo7trigger.Text == "c")
        this.combo7val = 67;
      if (this.combo7trigger.Text == "d")
        this.combo7val = 68;
      if (this.combo7trigger.Text == "e")
        this.combo7val = 69;
      if (this.combo7trigger.Text == "f")
        this.combo7val = 70;
      if (this.combo7trigger.Text == "g")
        this.combo7val = 71;
      if (this.combo7trigger.Text == "h")
        this.combo7val = 72;
      if (this.combo7trigger.Text == "i")
        this.combo7val = 73;
      if (this.combo7trigger.Text == "j")
        this.combo7val = 74;
      if (this.combo7trigger.Text == "k")
        this.combo7val = 75;
      if (this.combo7trigger.Text == "l")
        this.combo7val = 76;
      if (this.combo7trigger.Text == "m")
        this.combo7val = 77;
      if (this.combo7trigger.Text == "n")
        this.combo7val = 78;
      if (this.combo7trigger.Text == "o")
        this.combo7val = 79;
      if (this.combo7trigger.Text == "p")
        this.combo7val = 80;
      if (this.combo7trigger.Text == "q")
        this.combo7val = 81;
      if (this.combo7trigger.Text == "r")
        this.combo7val = 82;
      if (this.combo7trigger.Text == "s")
        this.combo7val = 83;
      if (this.combo7trigger.Text == "t")
        this.combo7val = 84;
      if (this.combo7trigger.Text == "u")
        this.combo7val = 85;
      if (this.combo7trigger.Text == "v")
        this.combo7val = 86;
      if (this.combo7trigger.Text == "w")
        this.combo7val = 87;
      if (this.combo7trigger.Text == "x")
        this.combo7val = 88;
      if (this.combo7trigger.Text == "y")
        this.combo7val = 89;
      if (this.combo7trigger.Text == "z")
        this.combo7val = 90;
      if (this.combo8trigger.Text == "Insert")
        this.combo8val = 45;
      if (this.combo8trigger.Text == "Del")
        this.combo8val = 36;
      if (this.combo8trigger.Text == "Home")
        this.combo8val = 36;
      if (this.combo8trigger.Text == "End")
        this.combo8val = 35;
      if (this.combo8trigger.Text == "Pg Up")
        this.combo8val = 33;
      if (this.combo8trigger.Text == "Pg Dwn")
        this.combo8val = 34;
      if (this.combo8trigger.Text == "F11")
        this.combo8val = 122;
      if (this.combo8trigger.Text == "F2")
        this.combo8val = 113;
      if (this.combo8trigger.Text == "F3")
        this.combo8val = 114;
      if (this.combo8trigger.Text == "F4")
        this.combo8val = 115;
      if (this.combo8trigger.Text == "F6")
        this.combo8val = 117;
      if (this.combo8trigger.Text == "F7")
        this.combo8val = 118;
      if (this.combo8trigger.Text == "F8")
        this.combo8val = 119;
      if (this.combo8trigger.Text == "~")
        this.combo8val = 192;
      if (this.combo8trigger.Text == "-")
        this.combo8val = 189;
      if (this.combo8trigger.Text == "=")
        this.combo8val = 187;
      if (this.combo8trigger.Text == "[")
        this.combo8val = 219;
      if (this.combo8trigger.Text == "]")
        this.combo8val = 221;
      if (this.combo8trigger.Text == "\\")
        this.combo8val = 220;
      if (this.combo8trigger.Text == "'")
        this.combo8val = 222;
      if (this.combo8trigger.Text == ";")
        this.combo8val = 186;
      if (this.combo8trigger.Text == "/")
        this.combo8val = 191;
      if (this.combo8trigger.Text == ".")
        this.combo8val = 190;
      if (this.combo8trigger.Text == ",")
        this.combo8val = 188;
      if (this.combo8trigger.Text == "Num0")
        this.combo8val = 96;
      if (this.combo8trigger.Text == "Num1")
        this.combo8val = 97;
      if (this.combo8trigger.Text == "Num2")
        this.combo8val = 98;
      if (this.combo8trigger.Text == "Num3")
        this.combo8val = 99;
      if (this.combo8trigger.Text == "Num4")
        this.combo8val = 100;
      if (this.combo8trigger.Text == "Num5")
        this.combo8val = 101;
      if (this.combo8trigger.Text == "Num6")
        this.combo8val = 102;
      if (this.combo8trigger.Text == "Num7")
        this.combo8val = 103;
      if (this.combo8trigger.Text == "Num8")
        this.combo8val = 104;
      if (this.combo8trigger.Text == "Num9")
        this.combo8val = 105;
      if (this.combo8trigger.Text == "Mult")
        this.combo8val = 106;
      if (this.combo8trigger.Text == "Div")
        this.combo8val = 111;
      if (this.combo8trigger.Text == "Sub")
        this.combo8val = 109;
      if (this.combo8trigger.Text == "Add")
        this.combo8val = 107;
      if (this.combo8trigger.Text == "Dec")
        this.combo8val = 110;
      if (this.combo8trigger.Text == "0")
        this.combo8val = 48;
      if (this.combo8trigger.Text == "1")
        this.combo8val = 49;
      if (this.combo8trigger.Text == "2")
        this.combo8val = 50;
      if (this.combo8trigger.Text == "3")
        this.combo8val = 51;
      if (this.combo8trigger.Text == "4")
        this.combo8val = 52;
      if (this.combo8trigger.Text == "5")
        this.combo8val = 53;
      if (this.combo8trigger.Text == "6")
        this.combo8val = 54;
      if (this.combo8trigger.Text == "7")
        this.combo8val = 55;
      if (this.combo8trigger.Text == "8")
        this.combo8val = 56;
      if (this.combo8trigger.Text == "9")
        this.combo8val = 57;
      if (this.combo8trigger.Text == "a")
        this.combo8val = 65;
      if (this.combo8trigger.Text == "b")
        this.combo8val = 66;
      if (this.combo8trigger.Text == "c")
        this.combo8val = 67;
      if (this.combo8trigger.Text == "d")
        this.combo8val = 68;
      if (this.combo8trigger.Text == "e")
        this.combo8val = 69;
      if (this.combo8trigger.Text == "f")
        this.combo8val = 70;
      if (this.combo8trigger.Text == "g")
        this.combo8val = 71;
      if (this.combo8trigger.Text == "h")
        this.combo8val = 72;
      if (this.combo8trigger.Text == "i")
        this.combo8val = 73;
      if (this.combo8trigger.Text == "j")
        this.combo8val = 74;
      if (this.combo8trigger.Text == "k")
        this.combo8val = 75;
      if (this.combo8trigger.Text == "l")
        this.combo8val = 76;
      if (this.combo8trigger.Text == "m")
        this.combo8val = 77;
      if (this.combo8trigger.Text == "n")
        this.combo8val = 78;
      if (this.combo8trigger.Text == "o")
        this.combo8val = 79;
      if (this.combo8trigger.Text == "p")
        this.combo8val = 80;
      if (this.combo8trigger.Text == "q")
        this.combo8val = 81;
      if (this.combo8trigger.Text == "r")
        this.combo8val = 82;
      if (this.combo8trigger.Text == "s")
        this.combo8val = 83;
      if (this.combo8trigger.Text == "t")
        this.combo8val = 84;
      if (this.combo8trigger.Text == "u")
        this.combo8val = 85;
      if (this.combo8trigger.Text == "v")
        this.combo8val = 86;
      if (this.combo8trigger.Text == "w")
        this.combo8val = 87;
      if (this.combo8trigger.Text == "x")
        this.combo8val = 88;
      if (this.combo8trigger.Text == "y")
        this.combo8val = 89;
      if (this.combo8trigger.Text == "z")
        this.combo8val = 90;
      if (this.combo9trigger.Text == "Insert")
        this.combo9val = 45;
      if (this.combo9trigger.Text == "Del")
        this.combo9val = 36;
      if (this.combo9trigger.Text == "Home")
        this.combo9val = 36;
      if (this.combo9trigger.Text == "End")
        this.combo9val = 35;
      if (this.combo9trigger.Text == "Pg Up")
        this.combo9val = 33;
      if (this.combo9trigger.Text == "Pg Dwn")
        this.combo9val = 34;
      if (this.combo9trigger.Text == "F11")
        this.combo9val = 122;
      if (this.combo9trigger.Text == "F2")
        this.combo9val = 113;
      if (this.combo9trigger.Text == "F3")
        this.combo9val = 114;
      if (this.combo9trigger.Text == "F4")
        this.combo9val = 115;
      if (this.combo9trigger.Text == "F6")
        this.combo9val = 117;
      if (this.combo9trigger.Text == "F7")
        this.combo9val = 118;
      if (this.combo9trigger.Text == "F8")
        this.combo9val = 119;
      if (this.combo9trigger.Text == "~")
        this.combo9val = 192;
      if (this.combo9trigger.Text == "-")
        this.combo9val = 189;
      if (this.combo9trigger.Text == "=")
        this.combo9val = 187;
      if (this.combo9trigger.Text == "[")
        this.combo9val = 219;
      if (this.combo9trigger.Text == "]")
        this.combo9val = 221;
      if (this.combo9trigger.Text == "\\")
        this.combo9val = 220;
      if (this.combo9trigger.Text == "'")
        this.combo9val = 222;
      if (this.combo9trigger.Text == ";")
        this.combo9val = 186;
      if (this.combo9trigger.Text == "/")
        this.combo9val = 191;
      if (this.combo9trigger.Text == ".")
        this.combo9val = 190;
      if (this.combo9trigger.Text == ",")
        this.combo9val = 188;
      if (this.combo9trigger.Text == "Num0")
        this.combo9val = 96;
      if (this.combo9trigger.Text == "Num1")
        this.combo9val = 97;
      if (this.combo9trigger.Text == "Num2")
        this.combo9val = 98;
      if (this.combo9trigger.Text == "Num3")
        this.combo9val = 99;
      if (this.combo9trigger.Text == "Num4")
        this.combo9val = 100;
      if (this.combo9trigger.Text == "Num5")
        this.combo9val = 101;
      if (this.combo9trigger.Text == "Num6")
        this.combo9val = 102;
      if (this.combo9trigger.Text == "Num7")
        this.combo9val = 103;
      if (this.combo9trigger.Text == "Num8")
        this.combo9val = 104;
      if (this.combo9trigger.Text == "Num9")
        this.combo9val = 105;
      if (this.combo9trigger.Text == "Mult")
        this.combo9val = 106;
      if (this.combo9trigger.Text == "Div")
        this.combo9val = 111;
      if (this.combo9trigger.Text == "Sub")
        this.combo9val = 109;
      if (this.combo9trigger.Text == "Add")
        this.combo9val = 107;
      if (this.combo9trigger.Text == "Dec")
        this.combo9val = 110;
      if (this.combo9trigger.Text == "0")
        this.combo9val = 48;
      if (this.combo9trigger.Text == "1")
        this.combo9val = 49;
      if (this.combo9trigger.Text == "2")
        this.combo9val = 50;
      if (this.combo9trigger.Text == "3")
        this.combo9val = 51;
      if (this.combo9trigger.Text == "4")
        this.combo9val = 52;
      if (this.combo9trigger.Text == "5")
        this.combo9val = 53;
      if (this.combo9trigger.Text == "6")
        this.combo9val = 54;
      if (this.combo9trigger.Text == "7")
        this.combo9val = 55;
      if (this.combo9trigger.Text == "8")
        this.combo9val = 56;
      if (this.combo9trigger.Text == "9")
        this.combo9val = 57;
      if (this.combo9trigger.Text == "a")
        this.combo9val = 65;
      if (this.combo9trigger.Text == "b")
        this.combo9val = 66;
      if (this.combo9trigger.Text == "c")
        this.combo9val = 67;
      if (this.combo9trigger.Text == "d")
        this.combo9val = 68;
      if (this.combo9trigger.Text == "e")
        this.combo9val = 69;
      if (this.combo9trigger.Text == "f")
        this.combo9val = 70;
      if (this.combo9trigger.Text == "g")
        this.combo9val = 71;
      if (this.combo9trigger.Text == "h")
        this.combo9val = 72;
      if (this.combo9trigger.Text == "i")
        this.combo9val = 73;
      if (this.combo9trigger.Text == "j")
        this.combo9val = 74;
      if (this.combo9trigger.Text == "k")
        this.combo9val = 75;
      if (this.combo9trigger.Text == "l")
        this.combo9val = 76;
      if (this.combo9trigger.Text == "m")
        this.combo9val = 77;
      if (this.combo9trigger.Text == "n")
        this.combo9val = 78;
      if (this.combo9trigger.Text == "o")
        this.combo9val = 79;
      if (this.combo9trigger.Text == "p")
        this.combo9val = 80;
      if (this.combo9trigger.Text == "q")
        this.combo9val = 81;
      if (this.combo9trigger.Text == "r")
        this.combo9val = 82;
      if (this.combo9trigger.Text == "s")
        this.combo9val = 83;
      if (this.combo9trigger.Text == "t")
        this.combo9val = 84;
      if (this.combo9trigger.Text == "u")
        this.combo9val = 85;
      if (this.combo9trigger.Text == "v")
        this.combo9val = 86;
      if (this.combo9trigger.Text == "w")
        this.combo9val = 87;
      if (this.combo9trigger.Text == "x")
        this.combo9val = 88;
      if (this.combo9trigger.Text == "y")
        this.combo9val = 89;
      if (this.combo9trigger.Text == "z")
        this.combo9val = 90;
      if (this.combo10trigger.Text == "Insert")
        this.combo10val = 45;
      if (this.combo10trigger.Text == "Del")
        this.combo10val = 36;
      if (this.combo10trigger.Text == "Home")
        this.combo10val = 36;
      if (this.combo10trigger.Text == "End")
        this.combo10val = 35;
      if (this.combo10trigger.Text == "Pg Up")
        this.combo10val = 33;
      if (this.combo10trigger.Text == "Pg Dwn")
        this.combo10val = 34;
      if (this.combo10trigger.Text == "F11")
        this.combo10val = 122;
      if (this.combo10trigger.Text == "F2")
        this.combo10val = 113;
      if (this.combo10trigger.Text == "F3")
        this.combo10val = 114;
      if (this.combo10trigger.Text == "F4")
        this.combo10val = 115;
      if (this.combo10trigger.Text == "F6")
        this.combo10val = 117;
      if (this.combo10trigger.Text == "F7")
        this.combo10val = 118;
      if (this.combo10trigger.Text == "F8")
        this.combo10val = 119;
      if (this.combo10trigger.Text == "~")
        this.combo10val = 192;
      if (this.combo10trigger.Text == "-")
        this.combo10val = 189;
      if (this.combo10trigger.Text == "=")
        this.combo10val = 187;
      if (this.combo10trigger.Text == "[")
        this.combo10val = 219;
      if (this.combo10trigger.Text == "]")
        this.combo10val = 221;
      if (this.combo10trigger.Text == "\\")
        this.combo10val = 220;
      if (this.combo10trigger.Text == "'")
        this.combo10val = 222;
      if (this.combo10trigger.Text == ";")
        this.combo10val = 186;
      if (this.combo10trigger.Text == "/")
        this.combo10val = 191;
      if (this.combo10trigger.Text == ".")
        this.combo10val = 190;
      if (this.combo10trigger.Text == ",")
        this.combo10val = 188;
      if (this.combo10trigger.Text == "Num0")
        this.combo10val = 96;
      if (this.combo10trigger.Text == "Num1")
        this.combo10val = 97;
      if (this.combo10trigger.Text == "Num2")
        this.combo10val = 98;
      if (this.combo10trigger.Text == "Num3")
        this.combo10val = 99;
      if (this.combo10trigger.Text == "Num4")
        this.combo10val = 100;
      if (this.combo10trigger.Text == "Num5")
        this.combo10val = 101;
      if (this.combo10trigger.Text == "Num6")
        this.combo10val = 102;
      if (this.combo10trigger.Text == "Num7")
        this.combo10val = 103;
      if (this.combo10trigger.Text == "Num8")
        this.combo10val = 104;
      if (this.combo10trigger.Text == "Num9")
        this.combo10val = 105;
      if (this.combo10trigger.Text == "Mult")
        this.combo10val = 106;
      if (this.combo10trigger.Text == "Div")
        this.combo10val = 111;
      if (this.combo10trigger.Text == "Sub")
        this.combo10val = 109;
      if (this.combo10trigger.Text == "Add")
        this.combo10val = 107;
      if (this.combo10trigger.Text == "Dec")
        this.combo10val = 110;
      if (this.combo10trigger.Text == "0")
        this.combo10val = 48;
      if (this.combo10trigger.Text == "1")
        this.combo10val = 49;
      if (this.combo10trigger.Text == "2")
        this.combo10val = 50;
      if (this.combo10trigger.Text == "3")
        this.combo10val = 51;
      if (this.combo10trigger.Text == "4")
        this.combo10val = 52;
      if (this.combo10trigger.Text == "5")
        this.combo10val = 53;
      if (this.combo10trigger.Text == "6")
        this.combo10val = 54;
      if (this.combo10trigger.Text == "7")
        this.combo10val = 55;
      if (this.combo10trigger.Text == "8")
        this.combo10val = 56;
      if (this.combo10trigger.Text == "9")
        this.combo10val = 57;
      if (this.combo10trigger.Text == "a")
        this.combo10val = 65;
      if (this.combo10trigger.Text == "b")
        this.combo10val = 66;
      if (this.combo10trigger.Text == "c")
        this.combo10val = 67;
      if (this.combo10trigger.Text == "d")
        this.combo10val = 68;
      if (this.combo10trigger.Text == "e")
        this.combo10val = 69;
      if (this.combo10trigger.Text == "f")
        this.combo10val = 70;
      if (this.combo10trigger.Text == "g")
        this.combo10val = 71;
      if (this.combo10trigger.Text == "h")
        this.combo10val = 72;
      if (this.combo10trigger.Text == "i")
        this.combo10val = 73;
      if (this.combo10trigger.Text == "j")
        this.combo10val = 74;
      if (this.combo10trigger.Text == "k")
        this.combo10val = 75;
      if (this.combo10trigger.Text == "l")
        this.combo10val = 76;
      if (this.combo10trigger.Text == "m")
        this.combo10val = 77;
      if (this.combo10trigger.Text == "n")
        this.combo10val = 78;
      if (this.combo10trigger.Text == "o")
        this.combo10val = 79;
      if (this.combo10trigger.Text == "p")
        this.combo10val = 80;
      if (this.combo10trigger.Text == "q")
        this.combo10val = 81;
      if (this.combo10trigger.Text == "r")
        this.combo10val = 82;
      if (this.combo10trigger.Text == "s")
        this.combo10val = 83;
      if (this.combo10trigger.Text == "t")
        this.combo10val = 84;
      if (this.combo10trigger.Text == "u")
        this.combo10val = 85;
      if (this.combo10trigger.Text == "v")
        this.combo10val = 86;
      if (this.combo10trigger.Text == "w")
        this.combo10val = 87;
      if (this.combo10trigger.Text == "x")
        this.combo10val = 88;
      if (this.combo10trigger.Text == "y")
        this.combo10val = 89;
      if (!(this.combo10trigger.Text == "z"))
        return;
      this.combo10val = 90;
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

    public void SetMacro1() => this.macro1 = this.ConvertMacro(ComboOptions1.ConvertWhitespaceToSpacesRegex(this.combo1box.Text).Replace("  ", ",").Split(','));

    public void SetMacro2() => this.macro2 = this.ConvertMacro(ComboOptions1.ConvertWhitespaceToSpacesRegex(this.combo2box.Text).Replace("  ", ",").Split(','));

    public void SetMacro3() => this.macro3 = this.ConvertMacro(ComboOptions1.ConvertWhitespaceToSpacesRegex(this.combo3box.Text).Replace("  ", ",").Split(','));

    public void SetMacro4() => this.macro4 = this.ConvertMacro(ComboOptions1.ConvertWhitespaceToSpacesRegex(this.combo4box.Text).Replace("  ", ",").Split(','));

    public void SetMacro5() => this.macro5 = this.ConvertMacro(ComboOptions1.ConvertWhitespaceToSpacesRegex(this.combo5box.Text).Replace("  ", ",").Split(','));

    public void SetMacro6() => this.macro6 = this.ConvertMacro(ComboOptions1.ConvertWhitespaceToSpacesRegex(this.combo6box.Text).Replace("  ", ",").Split(','));

    public void SetMacro7() => this.macro7 = this.ConvertMacro(ComboOptions1.ConvertWhitespaceToSpacesRegex(this.combo7box.Text).Replace("  ", ",").Split(','));

    public void SetMacro8() => this.macro8 = this.ConvertMacro(ComboOptions1.ConvertWhitespaceToSpacesRegex(this.combo8box.Text).Replace("  ", ",").Split(','));

    public void SetMacro9() => this.macro9 = this.ConvertMacro(ComboOptions1.ConvertWhitespaceToSpacesRegex(this.combo9box.Text).Replace("  ", ",").Split(','));

    public void SetMacro10() => this.macro10 = this.ConvertMacro(ComboOptions1.ConvertWhitespaceToSpacesRegex(this.combo10box.Text).Replace("  ", ",").Split(','));

    private void combo1_leave(object sender, EventArgs e) => this.SetMacro1();

    private void combo2_leave(object sender, EventArgs e) => this.SetMacro2();

    private void combo3_leave(object sender, EventArgs e) => this.SetMacro3();

    private void combo4_leave(object sender, EventArgs e) => this.SetMacro4();

    private void combo5_leave(object sender, EventArgs e) => this.SetMacro5();

    private void combo6_leave(object sender, EventArgs e) => this.SetMacro6();

    private void combo7_leave(object sender, EventArgs e) => this.SetMacro7();

    private void combo8_leave(object sender, EventArgs e) => this.SetMacro8();

    private void combo9_leave(object sender, EventArgs e) => this.SetMacro9();

    private void combo10_leave(object sender, EventArgs e) => this.SetMacro10();

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

    private void macro2_key(object sender, KeyEventArgs e)
    {
      this.combo1val = e.KeyValue;
      if (e.KeyValue == 45)
        this.combo2trigger.Text = "Insert";
      else if (e.KeyValue == 46)
        this.combo2trigger.Text = "Del";
      else if (e.KeyValue == 36)
        this.combo2trigger.Text = "Home";
      else if (e.KeyValue == 35)
        this.combo2trigger.Text = "End";
      else if (e.KeyValue == 33)
        this.combo2trigger.Text = "Pg Up";
      else if (e.KeyValue == 34)
        this.combo2trigger.Text = "Pg Dwn";
      else if (e.KeyValue == 122)
        this.combo2trigger.Text = "F11";
      else if (e.KeyValue == 113)
        this.combo2trigger.Text = "F2";
      else if (e.KeyValue == 114)
        this.combo2trigger.Text = "F3";
      else if (e.KeyValue == 115)
        this.combo2trigger.Text = "F4";
      else if (e.KeyValue == 117)
        this.combo2trigger.Text = "F6";
      else if (e.KeyValue == 118)
        this.combo2trigger.Text = "F7";
      else if (e.KeyValue == 119)
        this.combo2trigger.Text = "F8";
      else if (e.KeyValue == 192)
        this.combo2trigger.Text = "~";
      else if (e.KeyValue == 189)
        this.combo2trigger.Text = "-";
      else if (e.KeyValue == 187)
        this.combo2trigger.Text = "=";
      else if (e.KeyValue == 219)
        this.combo2trigger.Text = "[";
      else if (e.KeyValue == 221)
        this.combo2trigger.Text = "]";
      else if (e.KeyValue == 220)
        this.combo2trigger.Text = "\\";
      else if (e.KeyValue == 222)
        this.combo2trigger.Text = "'";
      else if (e.KeyValue == 186)
        this.combo2trigger.Text = ";";
      else if (e.KeyValue == 191)
        this.combo2trigger.Text = "/";
      else if (e.KeyValue == 190)
        this.combo2trigger.Text = ".";
      else if (e.KeyValue == 188)
        this.combo2trigger.Text = ",";
      else if (e.KeyValue == 96)
        this.combo2trigger.Text = "Num0";
      else if (e.KeyValue == 97)
        this.combo2trigger.Text = "Num1";
      else if (e.KeyValue == 98)
        this.combo2trigger.Text = "Num2";
      else if (e.KeyValue == 99)
        this.combo2trigger.Text = "Num3";
      else if (e.KeyValue == 100)
        this.combo2trigger.Text = "Num4";
      else if (e.KeyValue == 101)
        this.combo2trigger.Text = "Num5";
      else if (e.KeyValue == 102)
        this.combo2trigger.Text = "Num6";
      else if (e.KeyValue == 103)
        this.combo2trigger.Text = "Num7";
      else if (e.KeyValue == 104)
        this.combo2trigger.Text = "Num8";
      else if (e.KeyValue == 105)
        this.combo2trigger.Text = "Num9";
      else if (e.KeyValue == 106)
        this.combo2trigger.Text = "Mult";
      else if (e.KeyValue == 111)
        this.combo2trigger.Text = "Div";
      else if (e.KeyValue == 109)
        this.combo2trigger.Text = "Sub";
      else if (e.KeyValue == 107)
        this.combo2trigger.Text = "Add";
      else if (e.KeyValue == 110)
        this.combo2trigger.Text = "Dec";
      else if (e.KeyValue == 65)
        this.combo2trigger.Text = "a";
      else if (e.KeyValue == 66)
        this.combo2trigger.Text = "b";
      else if (e.KeyValue == 67)
        this.combo2trigger.Text = "c";
      else if (e.KeyValue == 68)
        this.combo2trigger.Text = "d";
      else if (e.KeyValue == 69)
        this.combo2trigger.Text =  "e";
      else if (e.KeyValue == 70)
        this.combo2trigger.Text = "f";
      else if (e.KeyValue == 71)
        this.combo2trigger.Text = "g";
      else if (e.KeyValue == 72)
        this.combo2trigger.Text = "h";
      else if (e.KeyValue == 73)
        this.combo2trigger.Text = "i";
      else if (e.KeyValue == 74)
        this.combo2trigger.Text = "j";
      else if (e.KeyValue == 75)
        this.combo2trigger.Text = "k";
      else if (e.KeyValue == 76)
        this.combo2trigger.Text = "l";
      else if (e.KeyValue == 77)
        this.combo2trigger.Text = "m";
      else if (e.KeyValue == 78)
        this.combo2trigger.Text = "n";
      else if (e.KeyValue == 79)
        this.combo2trigger.Text = "o";
      else if (e.KeyValue == 80)
        this.combo2trigger.Text = "p";
      else if (e.KeyValue == 81)
        this.combo2trigger.Text = "q";
      else if (e.KeyValue == 82)
        this.combo2trigger.Text = "r";
      else if (e.KeyValue == 83)
        this.combo2trigger.Text = "s";
      else if (e.KeyValue == 84)
        this.combo2trigger.Text = "t";
      else if (e.KeyValue == 85)
        this.combo2trigger.Text = "u";
      else if (e.KeyValue == 86)
        this.combo2trigger.Text = "v";
      else if (e.KeyValue == 87)
        this.combo2trigger.Text = "w";
      else if (e.KeyValue == 88)
        this.combo2trigger.Text = "x";
      else if (e.KeyValue == 89)
        this.combo2trigger.Text = "y";
      else if (e.KeyValue == 90)
        this.combo2trigger.Text = "z";
      else if (e.KeyValue == 48)
        this.combo2trigger.Text = "0";
      else if (e.KeyValue == 49)
        this.combo2trigger.Text = "1";
      else if (e.KeyValue == 50)
        this.combo2trigger.Text = "2";
      else if (e.KeyValue == 51)
        this.combo2trigger.Text = "3";
      else if (e.KeyValue == 52)
        this.combo2trigger.Text = "4";
      else if (e.KeyValue == 53)
        this.combo2trigger.Text = "5";
      else if (e.KeyValue == 54)
        this.combo2trigger.Text = "6";
      else if (e.KeyValue == 55)
        this.combo2trigger.Text = "7";
      else if (e.KeyValue == 56)
      {
        this.combo2trigger.Text = "8";
      }
      else
      {
        if (e.KeyValue != 57)
          return;
        this.combo2trigger.Text = "9";
      }
    }

    private void macro3_key(object sender, KeyEventArgs e)
    {
      this.combo3val = e.KeyValue;
      if (e.KeyValue == 45)
        this.combo3trigger.Text = "Insert";
      else if (e.KeyValue == 46)
        this.combo3trigger.Text = "Del";
      else if (e.KeyValue == 36)
        this.combo3trigger.Text = "Home";
      else if (e.KeyValue == 35)
        this.combo3trigger.Text = "End";
      else if (e.KeyValue == 33)
        this.combo3trigger.Text = "Pg Up";
      else if (e.KeyValue == 34)
        this.combo3trigger.Text = "Pg Dwn";
      else if (e.KeyValue == 122)
        this.combo3trigger.Text = "F11";
      else if (e.KeyValue == 113)
        this.combo3trigger.Text = "F2";
      else if (e.KeyValue == 114)
        this.combo3trigger.Text = "F3";
      else if (e.KeyValue == 115)
        this.combo3trigger.Text = "F4";
      else if (e.KeyValue == 117)
        this.combo3trigger.Text = "F6";
      else if (e.KeyValue == 118)
        this.combo3trigger.Text = "F7";
      else if (e.KeyValue == 119)
        this.combo3trigger.Text = "F8";
      else if (e.KeyValue == 192)
        this.combo3trigger.Text = "~";
      else if (e.KeyValue == 189)
        this.combo3trigger.Text = "-";
      else if (e.KeyValue == 187)
        this.combo3trigger.Text = "=";
      else if (e.KeyValue == 219)
        this.combo3trigger.Text = "[";
      else if (e.KeyValue == 221)
        this.combo3trigger.Text = "]";
      else if (e.KeyValue == 220)
        this.combo3trigger.Text = "\\";
      else if (e.KeyValue == 222)
        this.combo3trigger.Text = "'";
      else if (e.KeyValue == 186)
        this.combo3trigger.Text = ";";
      else if (e.KeyValue == 191)
        this.combo3trigger.Text = "/";
      else if (e.KeyValue == 190)
        this.combo3trigger.Text = ".";
      else if (e.KeyValue == 188)
        this.combo3trigger.Text = ",";
      else if (e.KeyValue == 96)
        this.combo3trigger.Text = "Num0";
      else if (e.KeyValue == 97)
        this.combo3trigger.Text = "Num1";
      else if (e.KeyValue == 98)
        this.combo3trigger.Text = "Num2";
      else if (e.KeyValue == 99)
        this.combo3trigger.Text = "Num3";
      else if (e.KeyValue == 100)
        this.combo3trigger.Text = "Num4";
      else if (e.KeyValue == 101)
        this.combo3trigger.Text = "Num5";
      else if (e.KeyValue == 102)
        this.combo3trigger.Text = "Num6";
      else if (e.KeyValue == 103)
        this.combo3trigger.Text = "Num7";
      else if (e.KeyValue == 104)
        this.combo3trigger.Text = "Num8";
      else if (e.KeyValue == 105)
        this.combo3trigger.Text = "Num9";
      else if (e.KeyValue == 106)
        this.combo3trigger.Text = "Mult";
      else if (e.KeyValue == 111)
        this.combo3trigger.Text = "Div";
      else if (e.KeyValue == 109)
        this.combo3trigger.Text = "Sub";
      else if (e.KeyValue == 107)
        this.combo3trigger.Text = "Add";
      else if (e.KeyValue == 110)
        this.combo3trigger.Text = "Dec";
      else if (e.KeyValue == 65)
        this.combo3trigger.Text = "a";
      else if (e.KeyValue == 66)
        this.combo3trigger.Text = "b";
      else if (e.KeyValue == 67)
        this.combo3trigger.Text = "c";
      else if (e.KeyValue == 68)
        this.combo3trigger.Text = "d";
      else if (e.KeyValue == 69)
        this.combo3trigger.Text =  "e";
      else if (e.KeyValue == 70)
        this.combo3trigger.Text = "f";
      else if (e.KeyValue == 71)
        this.combo3trigger.Text = "g";
      else if (e.KeyValue == 72)
        this.combo3trigger.Text = "h";
      else if (e.KeyValue == 73)
        this.combo3trigger.Text = "i";
      else if (e.KeyValue == 74)
        this.combo3trigger.Text = "j";
      else if (e.KeyValue == 75)
        this.combo3trigger.Text = "k";
      else if (e.KeyValue == 76)
        this.combo3trigger.Text = "l";
      else if (e.KeyValue == 77)
        this.combo3trigger.Text = "m";
      else if (e.KeyValue == 78)
        this.combo3trigger.Text = "n";
      else if (e.KeyValue == 79)
        this.combo3trigger.Text = "o";
      else if (e.KeyValue == 80)
        this.combo3trigger.Text = "p";
      else if (e.KeyValue == 81)
        this.combo3trigger.Text = "q";
      else if (e.KeyValue == 82)
        this.combo3trigger.Text = "r";
      else if (e.KeyValue == 83)
        this.combo3trigger.Text = "s";
      else if (e.KeyValue == 84)
        this.combo3trigger.Text = "t";
      else if (e.KeyValue == 85)
        this.combo3trigger.Text = "u";
      else if (e.KeyValue == 86)
        this.combo3trigger.Text = "v";
      else if (e.KeyValue == 87)
        this.combo3trigger.Text = "w";
      else if (e.KeyValue == 88)
        this.combo3trigger.Text = "x";
      else if (e.KeyValue == 89)
        this.combo3trigger.Text = "y";
      else if (e.KeyValue == 90)
        this.combo3trigger.Text = "z";
      else if (e.KeyValue == 48)
        this.combo3trigger.Text = "0";
      else if (e.KeyValue == 49)
        this.combo3trigger.Text = "1";
      else if (e.KeyValue == 50)
        this.combo3trigger.Text = "2";
      else if (e.KeyValue == 51)
        this.combo3trigger.Text = "3";
      else if (e.KeyValue == 52)
        this.combo3trigger.Text = "4";
      else if (e.KeyValue == 53)
        this.combo3trigger.Text = "5";
      else if (e.KeyValue == 54)
        this.combo3trigger.Text = "6";
      else if (e.KeyValue == 55)
        this.combo3trigger.Text = "7";
      else if (e.KeyValue == 56)
      {
        this.combo3trigger.Text = "8";
      }
      else
      {
        if (e.KeyValue != 57)
          return;
        this.combo3trigger.Text = "9";
      }
    }

    private void macro4_key(object sender, KeyEventArgs e)
    {
      this.combo4val = e.KeyValue;
      if (e.KeyValue == 45)
        this.combo4trigger.Text = "Insert";
      else if (e.KeyValue == 46)
        this.combo4trigger.Text = "Del";
      else if (e.KeyValue == 36)
        this.combo4trigger.Text = "Home";
      else if (e.KeyValue == 35)
        this.combo4trigger.Text = "End";
      else if (e.KeyValue == 33)
        this.combo4trigger.Text = "Pg Up";
      else if (e.KeyValue == 34)
        this.combo4trigger.Text = "Pg Dwn";
      else if (e.KeyValue == 122)
        this.combo4trigger.Text = "F11";
      else if (e.KeyValue == 113)
        this.combo4trigger.Text = "F2";
      else if (e.KeyValue == 114)
        this.combo4trigger.Text = "F3";
      else if (e.KeyValue == 115)
        this.combo4trigger.Text = "F4";
      else if (e.KeyValue == 117)
        this.combo4trigger.Text = "F6";
      else if (e.KeyValue == 118)
        this.combo4trigger.Text = "F7";
      else if (e.KeyValue == 119)
        this.combo4trigger.Text = "F8";
      else if (e.KeyValue == 192)
        this.combo4trigger.Text = "~";
      else if (e.KeyValue == 189)
        this.combo4trigger.Text = "-";
      else if (e.KeyValue == 187)
        this.combo4trigger.Text = "=";
      else if (e.KeyValue == 219)
        this.combo4trigger.Text = "[";
      else if (e.KeyValue == 221)
        this.combo4trigger.Text = "]";
      else if (e.KeyValue == 220)
        this.combo4trigger.Text = "\\";
      else if (e.KeyValue == 222)
        this.combo4trigger.Text = "'";
      else if (e.KeyValue == 186)
        this.combo4trigger.Text = ";";
      else if (e.KeyValue == 191)
        this.combo4trigger.Text = "/";
      else if (e.KeyValue == 190)
        this.combo4trigger.Text = ".";
      else if (e.KeyValue == 188)
        this.combo4trigger.Text = ",";
      else if (e.KeyValue == 96)
        this.combo4trigger.Text = "Num0";
      else if (e.KeyValue == 97)
        this.combo4trigger.Text = "Num1";
      else if (e.KeyValue == 98)
        this.combo4trigger.Text = "Num2";
      else if (e.KeyValue == 99)
        this.combo4trigger.Text = "Num3";
      else if (e.KeyValue == 100)
        this.combo4trigger.Text = "Num4";
      else if (e.KeyValue == 101)
        this.combo4trigger.Text = "Num5";
      else if (e.KeyValue == 102)
        this.combo4trigger.Text = "Num6";
      else if (e.KeyValue == 103)
        this.combo4trigger.Text = "Num7";
      else if (e.KeyValue == 104)
        this.combo4trigger.Text = "Num8";
      else if (e.KeyValue == 105)
        this.combo4trigger.Text = "Num9";
      else if (e.KeyValue == 106)
        this.combo4trigger.Text = "Mult";
      else if (e.KeyValue == 111)
        this.combo4trigger.Text = "Div";
      else if (e.KeyValue == 109)
        this.combo4trigger.Text = "Sub";
      else if (e.KeyValue == 107)
        this.combo4trigger.Text = "Add";
      else if (e.KeyValue == 110)
        this.combo4trigger.Text = "Dec";
      else if (e.KeyValue == 65)
        this.combo4trigger.Text = "a";
      else if (e.KeyValue == 66)
        this.combo4trigger.Text = "b";
      else if (e.KeyValue == 67)
        this.combo4trigger.Text = "c";
      else if (e.KeyValue == 68)
        this.combo4trigger.Text = "d";
      else if (e.KeyValue == 69)
        this.combo4trigger.Text = "e";
      else if (e.KeyValue == 70)
        this.combo4trigger.Text = "f";
      else if (e.KeyValue == 71)
        this.combo4trigger.Text = "g";
      else if (e.KeyValue == 72)
        this.combo4trigger.Text = "h";
      else if (e.KeyValue == 73)
        this.combo4trigger.Text = "i";
      else if (e.KeyValue == 74)
        this.combo4trigger.Text = "j";
      else if (e.KeyValue == 75)
        this.combo4trigger.Text = "k";
      else if (e.KeyValue == 76)
        this.combo4trigger.Text = "l";
      else if (e.KeyValue == 77)
        this.combo4trigger.Text = "m";
      else if (e.KeyValue == 78)
        this.combo4trigger.Text = "n";
      else if (e.KeyValue == 79)
        this.combo4trigger.Text = "o";
      else if (e.KeyValue == 80)
        this.combo4trigger.Text = "p";
      else if (e.KeyValue == 81)
        this.combo4trigger.Text = "q";
      else if (e.KeyValue == 82)
        this.combo4trigger.Text = "r";
      else if (e.KeyValue == 83)
        this.combo4trigger.Text = "s";
      else if (e.KeyValue == 84)
        this.combo4trigger.Text = "t";
      else if (e.KeyValue == 85)
        this.combo4trigger.Text = "u";
      else if (e.KeyValue == 86)
        this.combo4trigger.Text = "v";
      else if (e.KeyValue == 87)
        this.combo4trigger.Text = "w";
      else if (e.KeyValue == 88)
        this.combo4trigger.Text = "x";
      else if (e.KeyValue == 89)
        this.combo4trigger.Text = "y";
      else if (e.KeyValue == 90)
        this.combo4trigger.Text = "z";
      else if (e.KeyValue == 48)
        this.combo4trigger.Text = "0";
      else if (e.KeyValue == 49)
        this.combo4trigger.Text = "1";
      else if (e.KeyValue == 50)
        this.combo4trigger.Text = "2";
      else if (e.KeyValue == 51)
        this.combo4trigger.Text = "3";
      else if (e.KeyValue == 52)
        this.combo4trigger.Text = "4";
      else if (e.KeyValue == 53)
        this.combo4trigger.Text = "5";
      else if (e.KeyValue == 54)
        this.combo4trigger.Text = "6";
      else if (e.KeyValue == 55)
        this.combo4trigger.Text = "7";
      else if (e.KeyValue == 56)
      {
        this.combo4trigger.Text = "8";
      }
      else
      {
        if (e.KeyValue != 57)
          return;
        this.combo4trigger.Text = "9";
      }
    }

    private void macro5_key(object sender, KeyEventArgs e)
    {
      this.combo5val = e.KeyValue;
      if (e.KeyValue == 45)
        this.combo5trigger.Text = "Insert";
      else if (e.KeyValue == 46)
        this.combo5trigger.Text = "Del";
      else if (e.KeyValue == 36)
        this.combo5trigger.Text = "Home";
      else if (e.KeyValue == 35)
        this.combo5trigger.Text = "End";
      else if (e.KeyValue == 33)
        this.combo5trigger.Text = "Pg Up";
      else if (e.KeyValue == 34)
        this.combo5trigger.Text = "Pg Dwn";
      else if (e.KeyValue == 122)
        this.combo5trigger.Text = "F11";
      else if (e.KeyValue == 113)
        this.combo5trigger.Text = "F2";
      else if (e.KeyValue == 114)
        this.combo5trigger.Text = "F3";
      else if (e.KeyValue == 115)
        this.combo5trigger.Text = "F4";
      else if (e.KeyValue == 117)
        this.combo5trigger.Text = "F6";
      else if (e.KeyValue == 118)
        this.combo5trigger.Text = "F7";
      else if (e.KeyValue == 119)
        this.combo5trigger.Text = "F8";
      else if (e.KeyValue == 192)
        this.combo5trigger.Text = "~";
      else if (e.KeyValue == 189)
        this.combo5trigger.Text = "-";
      else if (e.KeyValue == 187)
        this.combo5trigger.Text = "=";
      else if (e.KeyValue == 219)
        this.combo5trigger.Text = "[";
      else if (e.KeyValue == 221)
        this.combo5trigger.Text = "]";
      else if (e.KeyValue == 220)
        this.combo5trigger.Text = "\\";
      else if (e.KeyValue == 222)
        this.combo5trigger.Text = "'";
      else if (e.KeyValue == 186)
        this.combo5trigger.Text = ";";
      else if (e.KeyValue == 191)
        this.combo5trigger.Text = "/";
      else if (e.KeyValue == 190)
        this.combo5trigger.Text = ".";
      else if (e.KeyValue == 188)
        this.combo5trigger.Text = ",";
      else if (e.KeyValue == 96)
        this.combo5trigger.Text = "Num0";
      else if (e.KeyValue == 97)
        this.combo5trigger.Text = "Num1";
      else if (e.KeyValue == 98)
        this.combo5trigger.Text = "Num2";
      else if (e.KeyValue == 99)
        this.combo5trigger.Text = "Num3";
      else if (e.KeyValue == 100)
        this.combo5trigger.Text = "Num4";
      else if (e.KeyValue == 101)
        this.combo5trigger.Text = "Num5";
      else if (e.KeyValue == 102)
        this.combo5trigger.Text = "Num6";
      else if (e.KeyValue == 103)
        this.combo5trigger.Text = "Num7";
      else if (e.KeyValue == 104)
        this.combo5trigger.Text = "Num8";
      else if (e.KeyValue == 105)
        this.combo5trigger.Text = "Num9";
      else if (e.KeyValue == 106)
        this.combo5trigger.Text = "Mult";
      else if (e.KeyValue == 111)
        this.combo5trigger.Text = "Div";
      else if (e.KeyValue == 109)
        this.combo5trigger.Text = "Sub";
      else if (e.KeyValue == 107)
        this.combo5trigger.Text = "Add";
      else if (e.KeyValue == 110)
        this.combo5trigger.Text = "Dec";
      else if (e.KeyValue == 65)
        this.combo5trigger.Text = "a";
      else if (e.KeyValue == 66)
        this.combo5trigger.Text = "b";
      else if (e.KeyValue == 67)
        this.combo5trigger.Text = "c";
      else if (e.KeyValue == 68)
        this.combo5trigger.Text = "d";
      else if (e.KeyValue == 69)
        this.combo5trigger.Text =  "e";
      else if (e.KeyValue == 70)
        this.combo5trigger.Text = "f";
      else if (e.KeyValue == 71)
        this.combo5trigger.Text = "g";
      else if (e.KeyValue == 72)
        this.combo5trigger.Text = "h";
      else if (e.KeyValue == 73)
        this.combo5trigger.Text = "i";
      else if (e.KeyValue == 74)
        this.combo5trigger.Text = "j";
      else if (e.KeyValue == 75)
        this.combo5trigger.Text = "k";
      else if (e.KeyValue == 76)
        this.combo5trigger.Text = "l";
      else if (e.KeyValue == 77)
        this.combo5trigger.Text = "m";
      else if (e.KeyValue == 78)
        this.combo5trigger.Text = "n";
      else if (e.KeyValue == 79)
        this.combo5trigger.Text = "o";
      else if (e.KeyValue == 80)
        this.combo5trigger.Text = "p";
      else if (e.KeyValue == 81)
        this.combo5trigger.Text = "q";
      else if (e.KeyValue == 82)
        this.combo5trigger.Text = "r";
      else if (e.KeyValue == 83)
        this.combo5trigger.Text = "s";
      else if (e.KeyValue == 84)
        this.combo5trigger.Text = "t";
      else if (e.KeyValue == 85)
        this.combo5trigger.Text = "u";
      else if (e.KeyValue == 86)
        this.combo5trigger.Text = "v";
      else if (e.KeyValue == 87)
        this.combo5trigger.Text = "w";
      else if (e.KeyValue == 88)
        this.combo5trigger.Text = "x";
      else if (e.KeyValue == 89)
        this.combo5trigger.Text = "y";
      else if (e.KeyValue == 90)
        this.combo5trigger.Text = "z";
      else if (e.KeyValue == 48)
        this.combo5trigger.Text = "0";
      else if (e.KeyValue == 49)
        this.combo5trigger.Text = "1";
      else if (e.KeyValue == 50)
        this.combo5trigger.Text = "2";
      else if (e.KeyValue == 51)
        this.combo5trigger.Text = "3";
      else if (e.KeyValue == 52)
        this.combo5trigger.Text = "4";
      else if (e.KeyValue == 53)
        this.combo5trigger.Text = "5";
      else if (e.KeyValue == 54)
        this.combo5trigger.Text = "6";
      else if (e.KeyValue == 55)
        this.combo5trigger.Text = "7";
      else if (e.KeyValue == 56)
      {
        this.combo5trigger.Text = "8";
      }
      else
      {
        if (e.KeyValue != 57)
          return;
        this.combo5trigger.Text = "9";
      }
    }

    private void macro6_key(object sender, KeyEventArgs e)
    {
      this.combo6val = e.KeyValue;
      if (e.KeyValue == 45)
        this.combo6trigger.Text = "Insert";
      else if (e.KeyValue == 46)
        this.combo6trigger.Text = "Del";
      else if (e.KeyValue == 36)
        this.combo6trigger.Text = "Home";
      else if (e.KeyValue == 35)
        this.combo6trigger.Text = "End";
      else if (e.KeyValue == 33)
        this.combo6trigger.Text = "Pg Up";
      else if (e.KeyValue == 34)
        this.combo6trigger.Text = "Pg Dwn";
      else if (e.KeyValue == 122)
        this.combo6trigger.Text = "F11";
      else if (e.KeyValue == 113)
        this.combo6trigger.Text = "F2";
      else if (e.KeyValue == 114)
        this.combo6trigger.Text = "F3";
      else if (e.KeyValue == 115)
        this.combo6trigger.Text = "F4";
      else if (e.KeyValue == 117)
        this.combo6trigger.Text = "F6";
      else if (e.KeyValue == 118)
        this.combo6trigger.Text = "F7";
      else if (e.KeyValue == 119)
        this.combo6trigger.Text = "F8";
      else if (e.KeyValue == 192)
        this.combo6trigger.Text = "~";
      else if (e.KeyValue == 189)
        this.combo6trigger.Text = "-";
      else if (e.KeyValue == 187)
        this.combo6trigger.Text = "=";
      else if (e.KeyValue == 219)
        this.combo6trigger.Text = "[";
      else if (e.KeyValue == 221)
        this.combo6trigger.Text = "]";
      else if (e.KeyValue == 220)
        this.combo6trigger.Text = "\\";
      else if (e.KeyValue == 222)
        this.combo6trigger.Text = "'";
      else if (e.KeyValue == 186)
        this.combo6trigger.Text = ";";
      else if (e.KeyValue == 191)
        this.combo6trigger.Text = "/";
      else if (e.KeyValue == 190)
        this.combo6trigger.Text = ".";
      else if (e.KeyValue == 188)
        this.combo6trigger.Text = ",";
      else if (e.KeyValue == 96)
        this.combo6trigger.Text = "Num0";
      else if (e.KeyValue == 97)
        this.combo6trigger.Text = "Num1";
      else if (e.KeyValue == 98)
        this.combo6trigger.Text = "Num2";
      else if (e.KeyValue == 99)
        this.combo6trigger.Text = "Num3";
      else if (e.KeyValue == 100)
        this.combo6trigger.Text = "Num4";
      else if (e.KeyValue == 101)
        this.combo6trigger.Text = "Num5";
      else if (e.KeyValue == 102)
        this.combo6trigger.Text = "Num6";
      else if (e.KeyValue == 103)
        this.combo6trigger.Text = "Num7";
      else if (e.KeyValue == 104)
        this.combo6trigger.Text = "Num8";
      else if (e.KeyValue == 105)
        this.combo6trigger.Text = "Num9";
      else if (e.KeyValue == 106)
        this.combo6trigger.Text = "Mult";
      else if (e.KeyValue == 111)
        this.combo6trigger.Text = "Div";
      else if (e.KeyValue == 109)
        this.combo6trigger.Text = "Sub";
      else if (e.KeyValue == 107)
        this.combo6trigger.Text = "Add";
      else if (e.KeyValue == 110)
        this.combo6trigger.Text = "Dec";
      else if (e.KeyValue == 65)
        this.combo6trigger.Text = "a";
      else if (e.KeyValue == 66)
        this.combo6trigger.Text = "b";
      else if (e.KeyValue == 67)
        this.combo6trigger.Text = "c";
      else if (e.KeyValue == 68)
        this.combo6trigger.Text = "d";
      else if (e.KeyValue == 69)
        this.combo6trigger.Text = "e";
      else if (e.KeyValue == 70)
        this.combo6trigger.Text = "f";
      else if (e.KeyValue == 71)
        this.combo6trigger.Text = "g";
      else if (e.KeyValue == 72)
        this.combo6trigger.Text = "h";
      else if (e.KeyValue == 73)
        this.combo6trigger.Text = "i";
      else if (e.KeyValue == 74)
        this.combo6trigger.Text = "j";
      else if (e.KeyValue == 75)
        this.combo6trigger.Text = "k";
      else if (e.KeyValue == 76)
        this.combo6trigger.Text = "l";
      else if (e.KeyValue == 77)
        this.combo6trigger.Text = "m";
      else if (e.KeyValue == 78)
        this.combo6trigger.Text = "n";
      else if (e.KeyValue == 79)
        this.combo6trigger.Text = "o";
      else if (e.KeyValue == 80)
        this.combo6trigger.Text = "p";
      else if (e.KeyValue == 81)
        this.combo6trigger.Text = "q";
      else if (e.KeyValue == 82)
        this.combo6trigger.Text = "r";
      else if (e.KeyValue == 83)
        this.combo6trigger.Text = "s";
      else if (e.KeyValue == 84)
        this.combo6trigger.Text = "t";
      else if (e.KeyValue == 85)
        this.combo6trigger.Text = "u";
      else if (e.KeyValue == 86)
        this.combo6trigger.Text = "v";
      else if (e.KeyValue == 87)
        this.combo6trigger.Text = "w";
      else if (e.KeyValue == 88)
        this.combo6trigger.Text = "x";
      else if (e.KeyValue == 89)
        this.combo6trigger.Text = "y";
      else if (e.KeyValue == 90)
        this.combo6trigger.Text = "z";
      else if (e.KeyValue == 48)
        this.combo6trigger.Text = "0";
      else if (e.KeyValue == 49)
        this.combo6trigger.Text = "1";
      else if (e.KeyValue == 50)
        this.combo6trigger.Text = "2";
      else if (e.KeyValue == 51)
        this.combo6trigger.Text = "3";
      else if (e.KeyValue == 52)
        this.combo6trigger.Text = "4";
      else if (e.KeyValue == 53)
        this.combo6trigger.Text = "5";
      else if (e.KeyValue == 54)
        this.combo6trigger.Text = "6";
      else if (e.KeyValue == 55)
        this.combo6trigger.Text = "7";
      else if (e.KeyValue == 56)
      {
        this.combo6trigger.Text = "8";
      }
      else
      {
        if (e.KeyValue != 57)
          return;
        this.combo6trigger.Text = "9";
      }
    }

    private void macro7_key(object sender, KeyEventArgs e)
    {
      this.combo7val = e.KeyValue;
      if (e.KeyValue == 45)
        this.combo7trigger.Text = "Insert";
      else if (e.KeyValue == 46)
        this.combo7trigger.Text = "Del";
      else if (e.KeyValue == 36)
        this.combo7trigger.Text = "Home";
      else if (e.KeyValue == 35)
        this.combo7trigger.Text = "End";
      else if (e.KeyValue == 33)
        this.combo7trigger.Text = "Pg Up";
      else if (e.KeyValue == 34)
        this.combo7trigger.Text = "Pg Dwn";
      else if (e.KeyValue == 122)
        this.combo7trigger.Text = "F11";
      else if (e.KeyValue == 113)
        this.combo7trigger.Text = "F2";
      else if (e.KeyValue == 114)
        this.combo7trigger.Text = "F3";
      else if (e.KeyValue == 115)
        this.combo7trigger.Text = "F4";
      else if (e.KeyValue == 117)
        this.combo7trigger.Text = "F6";
      else if (e.KeyValue == 118)
        this.combo7trigger.Text = "F7";
      else if (e.KeyValue == 119)
        this.combo7trigger.Text = "F8";
      else if (e.KeyValue == 192)
        this.combo7trigger.Text = "~";
      else if (e.KeyValue == 189)
        this.combo7trigger.Text = "-";
      else if (e.KeyValue == 187)
        this.combo7trigger.Text = "=";
      else if (e.KeyValue == 219)
        this.combo7trigger.Text = "[";
      else if (e.KeyValue == 221)
        this.combo7trigger.Text = "]";
      else if (e.KeyValue == 220)
        this.combo7trigger.Text = "\\";
      else if (e.KeyValue == 222)
        this.combo7trigger.Text = "'";
      else if (e.KeyValue == 186)
        this.combo7trigger.Text = ";";
      else if (e.KeyValue == 191)
        this.combo7trigger.Text = "/";
      else if (e.KeyValue == 190)
        this.combo7trigger.Text = ".";
      else if (e.KeyValue == 188)
        this.combo7trigger.Text = ",";
      else if (e.KeyValue == 96)
        this.combo7trigger.Text = "Num0";
      else if (e.KeyValue == 97)
        this.combo7trigger.Text = "Num1";
      else if (e.KeyValue == 98)
        this.combo7trigger.Text = "Num2";
      else if (e.KeyValue == 99)
        this.combo7trigger.Text = "Num3";
      else if (e.KeyValue == 100)
        this.combo7trigger.Text = "Num4";
      else if (e.KeyValue == 101)
        this.combo7trigger.Text = "Num5";
      else if (e.KeyValue == 102)
        this.combo7trigger.Text = "Num6";
      else if (e.KeyValue == 103)
        this.combo7trigger.Text = "Num7";
      else if (e.KeyValue == 104)
        this.combo7trigger.Text = "Num8";
      else if (e.KeyValue == 105)
        this.combo7trigger.Text = "Num9";
      else if (e.KeyValue == 106)
        this.combo7trigger.Text = "Mult";
      else if (e.KeyValue == 111)
        this.combo7trigger.Text = "Div";
      else if (e.KeyValue == 109)
        this.combo7trigger.Text = "Sub";
      else if (e.KeyValue == 107)
        this.combo7trigger.Text = "Add";
      else if (e.KeyValue == 110)
        this.combo7trigger.Text = "Dec";
      else if (e.KeyValue == 65)
        this.combo7trigger.Text = "a";
      else if (e.KeyValue == 66)
        this.combo7trigger.Text = "b";
      else if (e.KeyValue == 67)
        this.combo7trigger.Text = "c";
      else if (e.KeyValue == 68)
        this.combo7trigger.Text = "d";
      else if (e.KeyValue == 69)
        this.combo7trigger.Text =  "e";
      else if (e.KeyValue == 70)
        this.combo7trigger.Text = "f";
      else if (e.KeyValue == 71)
        this.combo7trigger.Text = "g";
      else if (e.KeyValue == 72)
        this.combo7trigger.Text = "h";
      else if (e.KeyValue == 73)
        this.combo7trigger.Text = "i";
      else if (e.KeyValue == 74)
        this.combo7trigger.Text = "j";
      else if (e.KeyValue == 75)
        this.combo7trigger.Text = "k";
      else if (e.KeyValue == 76)
        this.combo7trigger.Text = "l";
      else if (e.KeyValue == 77)
        this.combo7trigger.Text = "m";
      else if (e.KeyValue == 78)
        this.combo7trigger.Text = "n";
      else if (e.KeyValue == 79)
        this.combo7trigger.Text = "o";
      else if (e.KeyValue == 80)
        this.combo7trigger.Text = "p";
      else if (e.KeyValue == 81)
        this.combo7trigger.Text = "q";
      else if (e.KeyValue == 82)
        this.combo7trigger.Text = "r";
      else if (e.KeyValue == 83)
        this.combo7trigger.Text = "s";
      else if (e.KeyValue == 84)
        this.combo7trigger.Text = "t";
      else if (e.KeyValue == 85)
        this.combo7trigger.Text = "u";
      else if (e.KeyValue == 86)
        this.combo7trigger.Text = "v";
      else if (e.KeyValue == 87)
        this.combo7trigger.Text = "w";
      else if (e.KeyValue == 88)
        this.combo7trigger.Text = "x";
      else if (e.KeyValue == 89)
        this.combo7trigger.Text = "y";
      else if (e.KeyValue == 90)
        this.combo7trigger.Text = "z";
      else if (e.KeyValue == 48)
        this.combo7trigger.Text = "0";
      else if (e.KeyValue == 49)
        this.combo7trigger.Text = "1";
      else if (e.KeyValue == 50)
        this.combo7trigger.Text = "2";
      else if (e.KeyValue == 51)
        this.combo7trigger.Text = "3";
      else if (e.KeyValue == 52)
        this.combo7trigger.Text = "4";
      else if (e.KeyValue == 53)
        this.combo7trigger.Text = "5";
      else if (e.KeyValue == 54)
        this.combo7trigger.Text = "6";
      else if (e.KeyValue == 55)
        this.combo7trigger.Text = "7";
      else if (e.KeyValue == 56)
      {
        this.combo7trigger.Text = "8";
      }
      else
      {
        if (e.KeyValue != 57)
          return;
        this.combo7trigger.Text = "9";
      }
    }

    private void macro8_key(object sender, KeyEventArgs e)
    {
      this.combo8val = e.KeyValue;
      if (e.KeyValue == 45)
        this.combo8trigger.Text = "Insert";
      else if (e.KeyValue == 46)
        this.combo8trigger.Text = "Del";
      else if (e.KeyValue == 36)
        this.combo8trigger.Text = "Home";
      else if (e.KeyValue == 35)
        this.combo8trigger.Text = "End";
      else if (e.KeyValue == 33)
        this.combo8trigger.Text = "Pg Up";
      else if (e.KeyValue == 34)
        this.combo8trigger.Text = "Pg Dwn";
      else if (e.KeyValue == 122)
        this.combo8trigger.Text = "F11";
      else if (e.KeyValue == 113)
        this.combo8trigger.Text = "F2";
      else if (e.KeyValue == 114)
        this.combo8trigger.Text = "F3";
      else if (e.KeyValue == 115)
        this.combo8trigger.Text = "F4";
      else if (e.KeyValue == 117)
        this.combo8trigger.Text = "F6";
      else if (e.KeyValue == 118)
        this.combo8trigger.Text = "F7";
      else if (e.KeyValue == 119)
        this.combo8trigger.Text = "F8";
      else if (e.KeyValue == 192)
        this.combo8trigger.Text = "~";
      else if (e.KeyValue == 189)
        this.combo8trigger.Text = "-";
      else if (e.KeyValue == 187)
        this.combo8trigger.Text = "=";
      else if (e.KeyValue == 219)
        this.combo8trigger.Text = "[";
      else if (e.KeyValue == 221)
        this.combo8trigger.Text = "]";
      else if (e.KeyValue == 220)
        this.combo8trigger.Text = "\\";
      else if (e.KeyValue == 222)
        this.combo8trigger.Text = "'";
      else if (e.KeyValue == 186)
        this.combo8trigger.Text = ";";
      else if (e.KeyValue == 191)
        this.combo8trigger.Text = "/";
      else if (e.KeyValue == 190)
        this.combo8trigger.Text = ".";
      else if (e.KeyValue == 188)
        this.combo8trigger.Text = ",";
      else if (e.KeyValue == 96)
        this.combo8trigger.Text = "Num0";
      else if (e.KeyValue == 97)
        this.combo8trigger.Text = "Num1";
      else if (e.KeyValue == 98)
        this.combo8trigger.Text = "Num2";
      else if (e.KeyValue == 99)
        this.combo8trigger.Text = "Num3";
      else if (e.KeyValue == 100)
        this.combo8trigger.Text = "Num4";
      else if (e.KeyValue == 101)
        this.combo8trigger.Text = "Num5";
      else if (e.KeyValue == 102)
        this.combo8trigger.Text = "Num6";
      else if (e.KeyValue == 103)
        this.combo8trigger.Text = "Num7";
      else if (e.KeyValue == 104)
        this.combo8trigger.Text = "Num8";
      else if (e.KeyValue == 105)
        this.combo8trigger.Text = "Num9";
      else if (e.KeyValue == 106)
        this.combo8trigger.Text = "Mult";
      else if (e.KeyValue == 111)
        this.combo8trigger.Text = "Div";
      else if (e.KeyValue == 109)
        this.combo8trigger.Text = "Sub";
      else if (e.KeyValue == 107)
        this.combo8trigger.Text = "Add";
      else if (e.KeyValue == 110)
        this.combo8trigger.Text = "Dec";
      else if (e.KeyValue == 65)
        this.combo8trigger.Text = "a";
      else if (e.KeyValue == 66)
        this.combo8trigger.Text = "b";
      else if (e.KeyValue == 67)
        this.combo8trigger.Text = "c";
      else if (e.KeyValue == 68)
        this.combo8trigger.Text = "d";
      else if (e.KeyValue == 69)
        this.combo8trigger.Text =  "e";
      else if (e.KeyValue == 70)
        this.combo8trigger.Text = "f";
      else if (e.KeyValue == 71)
        this.combo8trigger.Text = "g";
      else if (e.KeyValue == 72)
        this.combo8trigger.Text = "h";
      else if (e.KeyValue == 73)
        this.combo8trigger.Text = "i";
      else if (e.KeyValue == 74)
        this.combo8trigger.Text = "j";
      else if (e.KeyValue == 75)
        this.combo8trigger.Text = "k";
      else if (e.KeyValue == 76)
        this.combo8trigger.Text = "l";
      else if (e.KeyValue == 77)
        this.combo8trigger.Text = "m";
      else if (e.KeyValue == 78)
        this.combo8trigger.Text = "n";
      else if (e.KeyValue == 79)
        this.combo8trigger.Text = "o";
      else if (e.KeyValue == 80)
        this.combo8trigger.Text = "p";
      else if (e.KeyValue == 81)
        this.combo8trigger.Text = "q";
      else if (e.KeyValue == 82)
        this.combo8trigger.Text = "r";
      else if (e.KeyValue == 83)
        this.combo8trigger.Text = "s";
      else if (e.KeyValue == 84)
        this.combo8trigger.Text = "t";
      else if (e.KeyValue == 85)
        this.combo8trigger.Text = "u";
      else if (e.KeyValue == 86)
        this.combo8trigger.Text = "v";
      else if (e.KeyValue == 87)
        this.combo8trigger.Text = "w";
      else if (e.KeyValue == 88)
        this.combo8trigger.Text = "x";
      else if (e.KeyValue == 89)
        this.combo8trigger.Text = "y";
      else if (e.KeyValue == 90)
        this.combo8trigger.Text = "z";
      else if (e.KeyValue == 48)
        this.combo8trigger.Text = "0";
      else if (e.KeyValue == 49)
        this.combo8trigger.Text = "1";
      else if (e.KeyValue == 50)
        this.combo8trigger.Text = "2";
      else if (e.KeyValue == 51)
        this.combo8trigger.Text = "3";
      else if (e.KeyValue == 52)
        this.combo8trigger.Text = "4";
      else if (e.KeyValue == 53)
        this.combo8trigger.Text = "5";
      else if (e.KeyValue == 54)
        this.combo8trigger.Text = "6";
      else if (e.KeyValue == 55)
        this.combo8trigger.Text = "7";
      else if (e.KeyValue == 56)
      {
        this.combo8trigger.Text = "8";
      }
      else
      {
        if (e.KeyValue != 57)
          return;
        this.combo8trigger.Text = "9";
      }
    }

    private void macro9_key(object sender, KeyEventArgs e)
    {
      this.combo9val = e.KeyValue;
            if (e.KeyValue == 45)
                this.combo9trigger.Text = "Insert";
            else if (e.KeyValue == 46)
                this.combo9trigger.Text = "Del";
            else if (e.KeyValue == 36)
                this.combo9trigger.Text = "Home";
            else if (e.KeyValue == 35)
                this.combo9trigger.Text = "End";
            else if (e.KeyValue == 33)
                this.combo9trigger.Text = "Pg Up";
            else if (e.KeyValue == 34)
                this.combo9trigger.Text = "Pg Dwn";
            else if (e.KeyValue == 122)
                this.combo9trigger.Text = "F11";
            else if (e.KeyValue == 113)
                this.combo9trigger.Text = "F2";
            else if (e.KeyValue == 114)
                this.combo9trigger.Text = "F3";
            else if (e.KeyValue == 115)
                this.combo9trigger.Text = "F4";
            else if (e.KeyValue == 117)
                this.combo9trigger.Text = "F6";
            else if (e.KeyValue == 118)
                this.combo9trigger.Text = "F7";
            else if (e.KeyValue == 119)
                this.combo9trigger.Text = "F8";
            else if (e.KeyValue == 192)
                this.combo9trigger.Text = "~";
            else if (e.KeyValue == 189)
                this.combo9trigger.Text = "-";
            else if (e.KeyValue == 187)
                this.combo9trigger.Text = "=";
            else if (e.KeyValue == 219)
                this.combo9trigger.Text = "[";
            else if (e.KeyValue == 221)
                this.combo9trigger.Text = "]";
            else if (e.KeyValue == 220)
                this.combo9trigger.Text = "\\";
            else if (e.KeyValue == 222)
                this.combo9trigger.Text = "'";
            else if (e.KeyValue == 186)
                this.combo9trigger.Text = ";";
            else if (e.KeyValue == 191)
                this.combo9trigger.Text = "/";
            else if (e.KeyValue == 190)
                this.combo9trigger.Text = ".";
            else if (e.KeyValue == 188)
                this.combo9trigger.Text = ",";
            else if (e.KeyValue == 96)
                this.combo9trigger.Text = "Num0";
            else if (e.KeyValue == 97)
                this.combo9trigger.Text = "Num1";
            else if (e.KeyValue == 98)
                this.combo9trigger.Text = "Num2";
            else if (e.KeyValue == 99)
                this.combo9trigger.Text = "Num3";
            else if (e.KeyValue == 100)
                this.combo9trigger.Text = "Num4";
            else if (e.KeyValue == 101)
                this.combo9trigger.Text = "Num5";
            else if (e.KeyValue == 102)
                this.combo9trigger.Text = "Num6";
            else if (e.KeyValue == 103)
                this.combo9trigger.Text = "Num7";
            else if (e.KeyValue == 104)
                this.combo9trigger.Text = "Num8";
            else if (e.KeyValue == 105)
                this.combo9trigger.Text = "Num9";
            else if (e.KeyValue == 106)
                this.combo9trigger.Text = "Mult";
            else if (e.KeyValue == 111)
                this.combo9trigger.Text = "Div";
            else if (e.KeyValue == 109)
                this.combo9trigger.Text = "Sub";
            else if (e.KeyValue == 107)
                this.combo9trigger.Text = "Add";
            else if (e.KeyValue == 110)
                this.combo9trigger.Text = "Dec";
            else if (e.KeyValue == 65)
                this.combo9trigger.Text = "a";
            else if (e.KeyValue == 66)
                this.combo9trigger.Text = "b";
            else if (e.KeyValue == 67)
                this.combo9trigger.Text = "c";
            else if (e.KeyValue == 68)
                this.combo9trigger.Text = "d";
            else if (e.KeyValue == 69)
                this.combo9trigger.Text = "e";
            else if (e.KeyValue == 70)
                this.combo9trigger.Text = "f";
            else if (e.KeyValue == 71)
                this.combo9trigger.Text = "g";
            else if (e.KeyValue == 72)
                this.combo9trigger.Text = "h";
            else if (e.KeyValue == 73)
                this.combo9trigger.Text = "i";
            else if (e.KeyValue == 74)
                this.combo9trigger.Text = "j";
            else if (e.KeyValue == 75)
                this.combo9trigger.Text = "k";
            else if (e.KeyValue == 76)
                this.combo9trigger.Text = "l";
            else if (e.KeyValue == 77)
                this.combo9trigger.Text = "m";
            else if (e.KeyValue == 78)
                this.combo9trigger.Text = "n";
            else if (e.KeyValue == 79)
                this.combo9trigger.Text = "o";
            else if (e.KeyValue == 80)
                this.combo9trigger.Text = "p";
            else if (e.KeyValue == 81)
                this.combo9trigger.Text = "q";
            else if (e.KeyValue == 82)
                this.combo9trigger.Text = "r";
            else if (e.KeyValue == 83)
                this.combo9trigger.Text = "s";
            else if (e.KeyValue == 84)
                this.combo9trigger.Text = "t";
            else if (e.KeyValue == 85)
                this.combo9trigger.Text = "u";
            else if (e.KeyValue == 86)
                this.combo9trigger.Text = "v";
            else if (e.KeyValue == 87)
                this.combo9trigger.Text = "w";
            else if (e.KeyValue == 88)
                this.combo9trigger.Text = "x";
            else if (e.KeyValue == 89)
                this.combo9trigger.Text = "y";
            else if (e.KeyValue == 90)
                this.combo9trigger.Text = "z";
            else if (e.KeyValue == 48)
                this.combo9trigger.Text = "0";
            else if (e.KeyValue == 49)
                this.combo9trigger.Text = "1";
            else if (e.KeyValue == 50)
                this.combo9trigger.Text = "2";
            else if (e.KeyValue == 51)
                this.combo9trigger.Text = "3";
            else if (e.KeyValue == 52)
                this.combo9trigger.Text = "4";
            else if (e.KeyValue == 53)
                this.combo9trigger.Text = "5";
            else if (e.KeyValue == 54)
                this.combo9trigger.Text = "6";
            else if (e.KeyValue == 55)
                this.combo9trigger.Text = "7";
            else if (e.KeyValue == 56)
            {
                this.combo9trigger.Text = "8";
            }
            else
            {
                if (e.KeyValue != 57)
                    return;
                this.combo9trigger.Text = "9";
            }
    }

    private void macro10_key(object sender, KeyEventArgs e)
    {
      this.combo10val = e.KeyValue;
      if (e.KeyValue == 45)
        this.combo10trigger.Text = "Insert";
      else if (e.KeyValue == 46)
        this.combo10trigger.Text = "Del";
      else if (e.KeyValue == 36)
        this.combo10trigger.Text = "Home";
      else if (e.KeyValue == 35)
        this.combo10trigger.Text = "End";
      else if (e.KeyValue == 33)
        this.combo10trigger.Text = "Pg Up";
      else if (e.KeyValue == 34)
        this.combo10trigger.Text = "Pg Dwn";
      else if (e.KeyValue == 122)
        this.combo10trigger.Text = "F11";
      else if (e.KeyValue == 113)
        this.combo10trigger.Text = "F2";
      else if (e.KeyValue == 114)
        this.combo10trigger.Text = "F3";
      else if (e.KeyValue == 115)
        this.combo10trigger.Text = "F4";
      else if (e.KeyValue == 117)
        this.combo10trigger.Text = "F6";
      else if (e.KeyValue == 118)
        this.combo10trigger.Text = "F7";
      else if (e.KeyValue == 119)
        this.combo10trigger.Text = "F8";
      else if (e.KeyValue == 192)
        this.combo10trigger.Text = "~";
      else if (e.KeyValue == 189)
        this.combo10trigger.Text = "-";
      else if (e.KeyValue == 187)
        this.combo10trigger.Text = "=";
      else if (e.KeyValue == 219)
        this.combo10trigger.Text = "[";
      else if (e.KeyValue == 221)
        this.combo10trigger.Text = "]";
      else if (e.KeyValue == 220)
        this.combo10trigger.Text = "\\";
      else if (e.KeyValue == 222)
        this.combo10trigger.Text = "'";
      else if (e.KeyValue == 186)
        this.combo10trigger.Text = ";";
      else if (e.KeyValue == 191)
        this.combo10trigger.Text = "/";
      else if (e.KeyValue == 190)
        this.combo10trigger.Text = ".";
      else if (e.KeyValue == 188)
        this.combo10trigger.Text = ",";
      else if (e.KeyValue == 96)
        this.combo10trigger.Text = "Num0";
      else if (e.KeyValue == 97)
        this.combo10trigger.Text = "Num1";
      else if (e.KeyValue == 98)
        this.combo10trigger.Text = "Num2";
      else if (e.KeyValue == 99)
        this.combo10trigger.Text = "Num3";
      else if (e.KeyValue == 100)
        this.combo10trigger.Text = "Num4";
      else if (e.KeyValue == 101)
        this.combo10trigger.Text = "Num5";
      else if (e.KeyValue == 102)
        this.combo10trigger.Text = "Num6";
      else if (e.KeyValue == 103)
        this.combo10trigger.Text = "Num7";
      else if (e.KeyValue == 104)
        this.combo10trigger.Text = "Num8";
      else if (e.KeyValue == 105)
        this.combo10trigger.Text = "Num9";
      else if (e.KeyValue == 106)
        this.combo10trigger.Text = "Mult";
      else if (e.KeyValue == 111)
        this.combo10trigger.Text = "Div";
      else if (e.KeyValue == 109)
        this.combo10trigger.Text = "Sub";
      else if (e.KeyValue == 107)
        this.combo10trigger.Text = "Add";
      else if (e.KeyValue == 110)
        this.combo10trigger.Text = "Dec";
      else if (e.KeyValue == 65)
        this.combo10trigger.Text = "a";
      else if (e.KeyValue == 66)
        this.combo10trigger.Text = "b";
      else if (e.KeyValue == 67)
        this.combo10trigger.Text = "c";
      else if (e.KeyValue == 68)
        this.combo10trigger.Text = "d";
      else if (e.KeyValue == 69)
        this.combo10trigger.Text =  "e";
      else if (e.KeyValue == 70)
        this.combo10trigger.Text = "f";
      else if (e.KeyValue == 71)
        this.combo10trigger.Text = "g";
      else if (e.KeyValue == 72)
        this.combo10trigger.Text = "h";
      else if (e.KeyValue == 73)
        this.combo10trigger.Text = "i";
      else if (e.KeyValue == 74)
        this.combo10trigger.Text = "j";
      else if (e.KeyValue == 75)
        this.combo10trigger.Text = "k";
      else if (e.KeyValue == 76)
        this.combo10trigger.Text = "l";
      else if (e.KeyValue == 77)
        this.combo10trigger.Text = "m";
      else if (e.KeyValue == 78)
        this.combo10trigger.Text = "n";
      else if (e.KeyValue == 79)
        this.combo10trigger.Text = "o";
      else if (e.KeyValue == 80)
        this.combo10trigger.Text = "p";
      else if (e.KeyValue == 81)
        this.combo10trigger.Text = "q";
      else if (e.KeyValue == 82)
        this.combo10trigger.Text = "r";
      else if (e.KeyValue == 83)
        this.combo10trigger.Text = "s";
      else if (e.KeyValue == 84)
        this.combo10trigger.Text = "t";
      else if (e.KeyValue == 85)
        this.combo10trigger.Text = "u";
      else if (e.KeyValue == 86)
        this.combo10trigger.Text = "v";
      else if (e.KeyValue == 87)
        this.combo10trigger.Text = "w";
      else if (e.KeyValue == 88)
        this.combo10trigger.Text = "x";
      else if (e.KeyValue == 89)
        this.combo10trigger.Text = "y";
      else if (e.KeyValue == 90)
        this.combo10trigger.Text = "z";
      else if (e.KeyValue == 48)
        this.combo10trigger.Text = "0";
      else if (e.KeyValue == 49)
        this.combo10trigger.Text = "1";
      else if (e.KeyValue == 50)
        this.combo10trigger.Text = "2";
      else if (e.KeyValue == 51)
        this.combo10trigger.Text = "3";
      else if (e.KeyValue == 52)
        this.combo10trigger.Text = "4";
      else if (e.KeyValue == 53)
        this.combo10trigger.Text = "5";
      else if (e.KeyValue == 54)
        this.combo10trigger.Text = "6";
      else if (e.KeyValue == 55)
        this.combo10trigger.Text = "7";
      else if (e.KeyValue == 56)
      {
        this.combo10trigger.Text = "8";
      }
      else
      {
        if (e.KeyValue != 57)
          return;
        this.combo10trigger.Text = "9";
      }
    }

    private void macro_keydown(object sender, KeyEventArgs e) => e.Handled = true;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (ComboOptions1));
      this.groupBox35 = new GroupBox();
      this.label25 = new Label();
      this.combo10name = new TextBox();
      this.label22 = new Label();
      this.label23 = new Label();
      this.combo10box = new TextBox();
      this.label24 = new Label();
      this.combo10trigger = new TextBox();
      this.combo10mod = new ComboBox();
      this.usemacro10 = new CheckBox();
      this.combo9name = new TextBox();
      this.label13 = new Label();
      this.label20 = new Label();
      this.combo9box = new TextBox();
      this.label21 = new Label();
      this.combo9trigger = new TextBox();
      this.combo9mod = new ComboBox();
      this.usemacro9 = new CheckBox();
      this.combo8name = new TextBox();
      this.label9 = new Label();
      this.label10 = new Label();
      this.combo8box = new TextBox();
      this.label11 = new Label();
      this.combo8trigger = new TextBox();
      this.combo8mod = new ComboBox();
      this.usemacro8 = new CheckBox();
      this.combo7name = new TextBox();
      this.label6 = new Label();
      this.label7 = new Label();
      this.combo7box = new TextBox();
      this.label8 = new Label();
      this.combo7trigger = new TextBox();
      this.combo7mod = new ComboBox();
      this.usemacro7 = new CheckBox();
      this.combo6name = new TextBox();
      this.label3 = new Label();
      this.label4 = new Label();
      this.combo6box = new TextBox();
      this.label5 = new Label();
      this.combo6trigger = new TextBox();
      this.combo6mod = new ComboBox();
      this.usemacro6 = new CheckBox();
      this.combo5name = new TextBox();
      this.label19 = new Label();
      this.combo4name = new TextBox();
      this.label18 = new Label();
      this.combo3name = new TextBox();
      this.label16 = new Label();
      this.combo2name = new TextBox();
      this.label15 = new Label();
      this.combo1name = new TextBox();
      this.label14 = new Label();
      this.label1 = new Label();
      this.combo5box = new TextBox();
      this.label2 = new Label();
      this.combo5trigger = new TextBox();
      this.combo5mod = new ComboBox();
      this.usemacro5 = new CheckBox();
      this.label44 = new Label();
      this.label43 = new Label();
      this.label42 = new Label();
      this.label41 = new Label();
      this.combo4box = new TextBox();
      this.combo3box = new TextBox();
      this.combo2box = new TextBox();
      this.combo1box = new TextBox();
      this.label40 = new Label();
      this.combo4trigger = new TextBox();
      this.combo4mod = new ComboBox();
      this.usemacro4 = new CheckBox();
      this.combo2mod = new ComboBox();
      this.label32 = new Label();
      this.combo3trigger = new TextBox();
      this.combo3mod = new ComboBox();
      this.label26 = new Label();
      this.combo2trigger = new TextBox();
      this.combo1mod = new ComboBox();
      this.label17 = new Label();
      this.combo1trigger = new TextBox();
      this.label12 = new Label();
      this.usemacro3 = new CheckBox();
      this.usemacro2 = new CheckBox();
      this.usemacro1 = new CheckBox();
      this.groupBox35.SuspendLayout();
      this.SuspendLayout();
      this.groupBox35.Controls.Add((Control) this.label25);
      this.groupBox35.Controls.Add((Control) this.combo10name);
      this.groupBox35.Controls.Add((Control) this.label22);
      this.groupBox35.Controls.Add((Control) this.label23);
      this.groupBox35.Controls.Add((Control) this.combo10box);
      this.groupBox35.Controls.Add((Control) this.label24);
      this.groupBox35.Controls.Add((Control) this.combo10trigger);
      this.groupBox35.Controls.Add((Control) this.combo10mod);
      this.groupBox35.Controls.Add((Control) this.usemacro10);
      this.groupBox35.Controls.Add((Control) this.combo9name);
      this.groupBox35.Controls.Add((Control) this.label13);
      this.groupBox35.Controls.Add((Control) this.label20);
      this.groupBox35.Controls.Add((Control) this.combo9box);
      this.groupBox35.Controls.Add((Control) this.label21);
      this.groupBox35.Controls.Add((Control) this.combo9trigger);
      this.groupBox35.Controls.Add((Control) this.combo9mod);
      this.groupBox35.Controls.Add((Control) this.usemacro9);
      this.groupBox35.Controls.Add((Control) this.combo8name);
      this.groupBox35.Controls.Add((Control) this.label9);
      this.groupBox35.Controls.Add((Control) this.label10);
      this.groupBox35.Controls.Add((Control) this.combo8box);
      this.groupBox35.Controls.Add((Control) this.label11);
      this.groupBox35.Controls.Add((Control) this.combo8trigger);
      this.groupBox35.Controls.Add((Control) this.combo8mod);
      this.groupBox35.Controls.Add((Control) this.usemacro8);
      this.groupBox35.Controls.Add((Control) this.combo7name);
      this.groupBox35.Controls.Add((Control) this.label6);
      this.groupBox35.Controls.Add((Control) this.label7);
      this.groupBox35.Controls.Add((Control) this.combo7box);
      this.groupBox35.Controls.Add((Control) this.label8);
      this.groupBox35.Controls.Add((Control) this.combo7trigger);
      this.groupBox35.Controls.Add((Control) this.combo7mod);
      this.groupBox35.Controls.Add((Control) this.usemacro7);
      this.groupBox35.Controls.Add((Control) this.combo6name);
      this.groupBox35.Controls.Add((Control) this.label3);
      this.groupBox35.Controls.Add((Control) this.label4);
      this.groupBox35.Controls.Add((Control) this.combo6box);
      this.groupBox35.Controls.Add((Control) this.label5);
      this.groupBox35.Controls.Add((Control) this.combo6trigger);
      this.groupBox35.Controls.Add((Control) this.combo6mod);
      this.groupBox35.Controls.Add((Control) this.usemacro6);
      this.groupBox35.Controls.Add((Control) this.combo5name);
      this.groupBox35.Controls.Add((Control) this.label19);
      this.groupBox35.Controls.Add((Control) this.combo4name);
      this.groupBox35.Controls.Add((Control) this.label18);
      this.groupBox35.Controls.Add((Control) this.combo3name);
      this.groupBox35.Controls.Add((Control) this.label16);
      this.groupBox35.Controls.Add((Control) this.combo2name);
      this.groupBox35.Controls.Add((Control) this.label15);
      this.groupBox35.Controls.Add((Control) this.combo1name);
      this.groupBox35.Controls.Add((Control) this.label14);
      this.groupBox35.Controls.Add((Control) this.label1);
      this.groupBox35.Controls.Add((Control) this.combo5box);
      this.groupBox35.Controls.Add((Control) this.label2);
      this.groupBox35.Controls.Add((Control) this.combo5trigger);
      this.groupBox35.Controls.Add((Control) this.combo5mod);
      this.groupBox35.Controls.Add((Control) this.usemacro5);
      this.groupBox35.Controls.Add((Control) this.label44);
      this.groupBox35.Controls.Add((Control) this.label43);
      this.groupBox35.Controls.Add((Control) this.label42);
      this.groupBox35.Controls.Add((Control) this.label41);
      this.groupBox35.Controls.Add((Control) this.combo4box);
      this.groupBox35.Controls.Add((Control) this.combo3box);
      this.groupBox35.Controls.Add((Control) this.combo2box);
      this.groupBox35.Controls.Add((Control) this.combo1box);
      this.groupBox35.Controls.Add((Control) this.label40);
      this.groupBox35.Controls.Add((Control) this.combo4trigger);
      this.groupBox35.Controls.Add((Control) this.combo4mod);
      this.groupBox35.Controls.Add((Control) this.usemacro4);
      this.groupBox35.Controls.Add((Control) this.combo2mod);
      this.groupBox35.Controls.Add((Control) this.label32);
      this.groupBox35.Controls.Add((Control) this.combo3trigger);
      this.groupBox35.Controls.Add((Control) this.combo3mod);
      this.groupBox35.Controls.Add((Control) this.label26);
      this.groupBox35.Controls.Add((Control) this.combo2trigger);
      this.groupBox35.Controls.Add((Control) this.combo1mod);
      this.groupBox35.Controls.Add((Control) this.label17);
      this.groupBox35.Controls.Add((Control) this.combo1trigger);
      this.groupBox35.Controls.Add((Control) this.label12);
      this.groupBox35.Controls.Add((Control) this.usemacro3);
      this.groupBox35.Controls.Add((Control) this.usemacro2);
      this.groupBox35.Controls.Add((Control) this.usemacro1);
      this.groupBox35.Location = new System.Drawing.Point(1, 3);
      this.groupBox35.Name = "groupBox35";
      this.groupBox35.Size = new Size(1517, 396);
      this.groupBox35.TabIndex = 12;
      this.groupBox35.TabStop = false;
      this.groupBox35.Text = "Hotkey Combo Macros";
      this.label25.AutoSize = true;
      this.label25.Font = new Font("Arial", 9f, FontStyle.Italic);
      this.label25.ForeColor = SystemColors.ControlDarkDark;
      this.label25.Location = new System.Drawing.Point(472, 32);
      this.label25.Name = "label25";
      this.label25.Size = new Size(263, 30);
      this.label25.TabIndex = 129;
      this.label25.Text = "Re-save your Template after updating combos.\r\n(ie; /save default)";
      this.combo10name.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.combo10name.Location = new System.Drawing.Point(1379, 359);
      this.combo10name.Name = "combo10name";
      this.combo10name.Size = new Size(104, 20);
      this.combo10name.TabIndex = 128;
      this.label22.AutoSize = true;
      this.label22.Location = new System.Drawing.Point(1376, 343);
      this.label22.Name = "label22";
      this.label22.Size = new Size(38, 13);
      this.label22.TabIndex = (int) sbyte.MaxValue;
      this.label22.Text = "Name:";
      this.label23.AutoSize = true;
      this.label23.Location = new System.Drawing.Point(1376, 320);
      this.label23.Name = "label23";
      this.label23.Size = new Size(44, 13);
      this.label23.TabIndex = 126;
      this.label23.Text = "Modifier";
      this.combo10box.Font = new Font("Arial", 9f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.combo10box.Location = new System.Drawing.Point(1368, 79);
      this.combo10box.Multiline = true;
      this.combo10box.Name = "combo10box";
      this.combo10box.ScrollBars = ScrollBars.Both;
      this.combo10box.Size = new Size(122, 180);
      this.combo10box.TabIndex = 125;
      this.combo10box.WordWrap = false;
      this.combo10box.TextChanged += new EventHandler(this.combo10_leave);
      this.combo10box.Leave += new EventHandler(this.combo10_leave);
      this.label24.AutoSize = true;
      this.label24.Location = new System.Drawing.Point(1376, 293);
      this.label24.Name = "label24";
      this.label24.Size = new Size(43, 13);
      this.label24.TabIndex = 124;
      this.label24.Text = "Trigger:";
      this.combo10trigger.Font = new Font("Arial", 9f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.combo10trigger.Location = new System.Drawing.Point(1432, 290);
      this.combo10trigger.MaxLength = 7;
      this.combo10trigger.Name = "combo10trigger";
      this.combo10trigger.Size = new Size(51, 21);
      this.combo10trigger.TabIndex = 123;
      this.combo10trigger.KeyDown += new KeyEventHandler(this.macro_keydown);
      this.combo10trigger.KeyUp += new KeyEventHandler(this.macro10_key);
      this.combo10mod.DropDownStyle = ComboBoxStyle.DropDownList;
      this.combo10mod.Font = new Font("Arial", 9f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.combo10mod.FormattingEnabled = true;
      this.combo10mod.Items.AddRange(new object[4]
      {
        (object) "None",
        (object) "Ctrl",
        (object) "Alt",
        (object) "Shift"
      });
      this.combo10mod.Location = new System.Drawing.Point(1432, 317);
      this.combo10mod.Name = "combo10mod";
      this.combo10mod.Size = new Size(51, 23);
      this.combo10mod.TabIndex = 122;
      this.usemacro10.AutoSize = true;
      this.usemacro10.Location = new System.Drawing.Point(1379, 268);
      this.usemacro10.Name = "usemacro10";
      this.usemacro10.Size = new Size(93, 17);
      this.usemacro10.TabIndex = 121;
      this.usemacro10.Text = "Use Macro 10";
      this.usemacro10.UseVisualStyleBackColor = true;
      this.combo9name.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.combo9name.Location = new System.Drawing.Point(1232, 359);
      this.combo9name.Name = "combo9name";
      this.combo9name.Size = new Size(104, 20);
      this.combo9name.TabIndex = 120;
      this.label13.AutoSize = true;
      this.label13.Location = new System.Drawing.Point(1229, 343);
      this.label13.Name = "label13";
      this.label13.Size = new Size(38, 13);
      this.label13.TabIndex = 119;
      this.label13.Text = "Name:";
      this.label20.AutoSize = true;
      this.label20.Location = new System.Drawing.Point(1229, 320);
      this.label20.Name = "label20";
      this.label20.Size = new Size(44, 13);
      this.label20.TabIndex = 118;
      this.label20.Text = "Modifier";
      this.combo9box.Font = new Font("Arial", 9f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.combo9box.Location = new System.Drawing.Point(1221, 79);
      this.combo9box.Multiline = true;
      this.combo9box.Name = "combo9box";
      this.combo9box.ScrollBars = ScrollBars.Both;
      this.combo9box.Size = new Size(122, 180);
      this.combo9box.TabIndex = 117;
      this.combo9box.WordWrap = false;
      this.combo9box.TextChanged += new EventHandler(this.combo9_leave);
      this.combo9box.Leave += new EventHandler(this.combo9_leave);
      this.label21.AutoSize = true;
      this.label21.Location = new System.Drawing.Point(1229, 293);
      this.label21.Name = "label21";
      this.label21.Size = new Size(43, 13);
      this.label21.TabIndex = 116;
      this.label21.Text = "Trigger:";
      this.combo9trigger.Font = new Font("Arial", 9f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.combo9trigger.Location = new System.Drawing.Point(1285, 290);
      this.combo9trigger.MaxLength = 7;
      this.combo9trigger.Name = "combo9trigger";
      this.combo9trigger.Size = new Size(51, 21);
      this.combo9trigger.TabIndex = 115;
      this.combo9trigger.KeyDown += new KeyEventHandler(this.macro_keydown);
      this.combo9trigger.KeyUp += new KeyEventHandler(this.macro9_key);
      this.combo9mod.DropDownStyle = ComboBoxStyle.DropDownList;
      this.combo9mod.Font = new Font("Arial", 9f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.combo9mod.FormattingEnabled = true;
      this.combo9mod.Items.AddRange(new object[4]
      {
        (object) "None",
        (object) "Ctrl",
        (object) "Alt",
        (object) "Shift"
      });
      this.combo9mod.Location = new System.Drawing.Point(1285, 317);
      this.combo9mod.Name = "combo9mod";
      this.combo9mod.Size = new Size(51, 23);
      this.combo9mod.TabIndex = 114;
      this.usemacro9.AutoSize = true;
      this.usemacro9.Location = new System.Drawing.Point(1232, 268);
      this.usemacro9.Name = "usemacro9";
      this.usemacro9.Size = new Size(87, 17);
      this.usemacro9.TabIndex = 113;
      this.usemacro9.Text = "Use Macro 9";
      this.usemacro9.UseVisualStyleBackColor = true;
      this.combo8name.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.combo8name.Location = new System.Drawing.Point(1082, 359);
      this.combo8name.Name = "combo8name";
      this.combo8name.Size = new Size(104, 20);
      this.combo8name.TabIndex = 112;
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(1079, 343);
      this.label9.Name = "label9";
      this.label9.Size = new Size(38, 13);
      this.label9.TabIndex = 111;
      this.label9.Text = "Name:";
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(1079, 320);
      this.label10.Name = "label10";
      this.label10.Size = new Size(44, 13);
      this.label10.TabIndex = 110;
      this.label10.Text = "Modifier";
      this.combo8box.Font = new Font("Arial", 9f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.combo8box.Location = new System.Drawing.Point(1071, 79);
      this.combo8box.Multiline = true;
      this.combo8box.Name = "combo8box";
      this.combo8box.ScrollBars = ScrollBars.Both;
      this.combo8box.Size = new Size(122, 180);
      this.combo8box.TabIndex = 109;
      this.combo8box.WordWrap = false;
      this.combo8box.TextChanged += new EventHandler(this.combo8_leave);
      this.combo8box.Leave += new EventHandler(this.combo8_leave);
      this.label11.AutoSize = true;
      this.label11.Location = new System.Drawing.Point(1079, 293);
      this.label11.Name = "label11";
      this.label11.Size = new Size(43, 13);
      this.label11.TabIndex = 108;
      this.label11.Text = "Trigger:";
      this.combo8trigger.Font = new Font("Arial", 9f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.combo8trigger.Location = new System.Drawing.Point(1135, 290);
      this.combo8trigger.MaxLength = 7;
      this.combo8trigger.Name = "combo8trigger";
      this.combo8trigger.Size = new Size(51, 21);
      this.combo8trigger.TabIndex = 107;
      this.combo8trigger.KeyDown += new KeyEventHandler(this.macro_keydown);
      this.combo8trigger.KeyUp += new KeyEventHandler(this.macro8_key);
      this.combo8mod.DropDownStyle = ComboBoxStyle.DropDownList;
      this.combo8mod.Font = new Font("Arial", 9f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.combo8mod.FormattingEnabled = true;
      this.combo8mod.Items.AddRange(new object[4]
      {
        (object) "None",
        (object) "Ctrl",
        (object) "Alt",
        (object) "Shift"
      });
      this.combo8mod.Location = new System.Drawing.Point(1135, 317);
      this.combo8mod.Name = "combo8mod";
      this.combo8mod.Size = new Size(51, 23);
      this.combo8mod.TabIndex = 106;
      this.usemacro8.AutoSize = true;
      this.usemacro8.Location = new System.Drawing.Point(1082, 268);
      this.usemacro8.Name = "usemacro8";
      this.usemacro8.Size = new Size(87, 17);
      this.usemacro8.TabIndex = 105;
      this.usemacro8.Text = "Use Macro 8";
      this.usemacro8.UseVisualStyleBackColor = true;
      this.combo7name.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.combo7name.Location = new System.Drawing.Point(930, 359);
      this.combo7name.Name = "combo7name";
      this.combo7name.Size = new Size(104, 20);
      this.combo7name.TabIndex = 104;
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(927, 343);
      this.label6.Name = "label6";
      this.label6.Size = new Size(38, 13);
      this.label6.TabIndex = 103;
      this.label6.Text = "Name:";
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(927, 320);
      this.label7.Name = "label7";
      this.label7.Size = new Size(44, 13);
      this.label7.TabIndex = 102;
      this.label7.Text = "Modifier";
      this.combo7box.Font = new Font("Arial", 9f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.combo7box.Location = new System.Drawing.Point(919, 79);
      this.combo7box.Multiline = true;
      this.combo7box.Name = "combo7box";
      this.combo7box.ScrollBars = ScrollBars.Both;
      this.combo7box.Size = new Size(122, 180);
      this.combo7box.TabIndex = 101;
      this.combo7box.WordWrap = false;
      this.combo7box.TextChanged += new EventHandler(this.combo7_leave);
      this.combo7box.Leave += new EventHandler(this.combo7_leave);
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(927, 293);
      this.label8.Name = "label8";
      this.label8.Size = new Size(43, 13);
      this.label8.TabIndex = 100;
      this.label8.Text = "Trigger:";
      this.combo7trigger.Font = new Font("Arial", 9f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.combo7trigger.Location = new System.Drawing.Point(983, 290);
      this.combo7trigger.MaxLength = 7;
      this.combo7trigger.Name = "combo7trigger";
      this.combo7trigger.Size = new Size(51, 21);
      this.combo7trigger.TabIndex = 99;
      this.combo7trigger.Text = "F8";
      this.combo7trigger.KeyDown += new KeyEventHandler(this.macro_keydown);
      this.combo7trigger.KeyUp += new KeyEventHandler(this.macro7_key);
      this.combo7mod.DropDownStyle = ComboBoxStyle.DropDownList;
      this.combo7mod.Font = new Font("Arial", 9f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.combo7mod.FormattingEnabled = true;
      this.combo7mod.Items.AddRange(new object[4]
      {
        (object) "None",
        (object) "Ctrl",
        (object) "Alt",
        (object) "Shift"
      });
      this.combo7mod.Location = new System.Drawing.Point(983, 317);
      this.combo7mod.Name = "combo7mod";
      this.combo7mod.Size = new Size(51, 23);
      this.combo7mod.TabIndex = 98;
      this.usemacro7.AutoSize = true;
      this.usemacro7.Location = new System.Drawing.Point(930, 268);
      this.usemacro7.Name = "usemacro7";
      this.usemacro7.Size = new Size(87, 17);
      this.usemacro7.TabIndex = 97;
      this.usemacro7.Text = "Use Macro 7";
      this.usemacro7.UseVisualStyleBackColor = true;
      this.combo6name.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.combo6name.Location = new System.Drawing.Point(778, 359);
      this.combo6name.Name = "combo6name";
      this.combo6name.Size = new Size(104, 20);
      this.combo6name.TabIndex = 96;
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(775, 343);
      this.label3.Name = "label3";
      this.label3.Size = new Size(38, 13);
      this.label3.TabIndex = 95;
      this.label3.Text = "Name:";
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(775, 320);
      this.label4.Name = "label4";
      this.label4.Size = new Size(44, 13);
      this.label4.TabIndex = 94;
      this.label4.Text = "Modifier";
      this.combo6box.Font = new Font("Arial", 9f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.combo6box.Location = new System.Drawing.Point(767, 79);
      this.combo6box.Multiline = true;
      this.combo6box.Name = "combo6box";
      this.combo6box.ScrollBars = ScrollBars.Both;
      this.combo6box.Size = new Size(122, 180);
      this.combo6box.TabIndex = 93;
      this.combo6box.WordWrap = false;
      this.combo6box.TextChanged += new EventHandler(this.combo6_leave);
      this.combo6box.Leave += new EventHandler(this.combo6_leave);
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(775, 293);
      this.label5.Name = "label5";
      this.label5.Size = new Size(43, 13);
      this.label5.TabIndex = 92;
      this.label5.Text = "Trigger:";
      this.combo6trigger.Font = new Font("Arial", 9f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.combo6trigger.Location = new System.Drawing.Point(831, 290);
      this.combo6trigger.MaxLength = 7;
      this.combo6trigger.Name = "combo6trigger";
      this.combo6trigger.Size = new Size(51, 21);
      this.combo6trigger.TabIndex = 91;
      this.combo6trigger.Text = "F7";
      this.combo6trigger.KeyDown += new KeyEventHandler(this.macro_keydown);
      this.combo6trigger.KeyUp += new KeyEventHandler(this.macro6_key);
      this.combo6mod.DropDownStyle = ComboBoxStyle.DropDownList;
      this.combo6mod.Font = new Font("Arial", 9f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.combo6mod.FormattingEnabled = true;
      this.combo6mod.Items.AddRange(new object[4]
      {
        (object) "None",
        (object) "Ctrl",
        (object) "Alt",
        (object) "Shift"
      });
      this.combo6mod.Location = new System.Drawing.Point(831, 317);
      this.combo6mod.Name = "combo6mod";
      this.combo6mod.Size = new Size(51, 23);
      this.combo6mod.TabIndex = 90;
      this.usemacro6.AutoSize = true;
      this.usemacro6.Location = new System.Drawing.Point(778, 268);
      this.usemacro6.Name = "usemacro6";
      this.usemacro6.Size = new Size(87, 17);
      this.usemacro6.TabIndex = 89;
      this.usemacro6.Text = "Use Macro 6";
      this.usemacro6.UseVisualStyleBackColor = true;
      this.combo5name.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.combo5name.Location = new System.Drawing.Point(624, 359);
      this.combo5name.Name = "combo5name";
      this.combo5name.Size = new Size(104, 20);
      this.combo5name.TabIndex = 88;
      this.label19.AutoSize = true;
      this.label19.Location = new System.Drawing.Point(621, 343);
      this.label19.Name = "label19";
      this.label19.Size = new Size(38, 13);
      this.label19.TabIndex = 87;
      this.label19.Text = "Name:";
      this.combo4name.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.combo4name.Location = new System.Drawing.Point(471, 359);
      this.combo4name.Name = "combo4name";
      this.combo4name.Size = new Size(106, 20);
      this.combo4name.TabIndex = 86;
      this.label18.AutoSize = true;
      this.label18.Location = new System.Drawing.Point(470, 343);
      this.label18.Name = "label18";
      this.label18.Size = new Size(38, 13);
      this.label18.TabIndex = 85;
      this.label18.Text = "Name:";
      this.combo3name.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.combo3name.Location = new System.Drawing.Point(316, 359);
      this.combo3name.Name = "combo3name";
      this.combo3name.Size = new Size(113, 20);
      this.combo3name.TabIndex = 84;
      this.label16.AutoSize = true;
      this.label16.Location = new System.Drawing.Point(313, 343);
      this.label16.Name = "label16";
      this.label16.Size = new Size(38, 13);
      this.label16.TabIndex = 83;
      this.label16.Text = "Name:";
      this.combo2name.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.combo2name.Location = new System.Drawing.Point(170, 359);
      this.combo2name.Name = "combo2name";
      this.combo2name.Size = new Size(112, 20);
      this.combo2name.TabIndex = 82;
      this.label15.AutoSize = true;
      this.label15.Location = new System.Drawing.Point(167, 343);
      this.label15.Name = "label15";
      this.label15.Size = new Size(38, 13);
      this.label15.TabIndex = 81;
      this.label15.Text = "Name:";
      this.combo1name.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.combo1name.Location = new System.Drawing.Point(21, 359);
      this.combo1name.Name = "combo1name";
      this.combo1name.Size = new Size(115, 20);
      this.combo1name.TabIndex = 80;
      this.label14.AutoSize = true;
      this.label14.Location = new System.Drawing.Point(18, 343);
      this.label14.Name = "label14";
      this.label14.Size = new Size(38, 13);
      this.label14.TabIndex = 79;
      this.label14.Text = "Name:";
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(621, 320);
      this.label1.Name = "label1";
      this.label1.Size = new Size(44, 13);
      this.label1.TabIndex = 48;
      this.label1.Text = "Modifier";
      this.combo5box.Font = new Font("Arial", 9f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.combo5box.Location = new System.Drawing.Point(613, 79);
      this.combo5box.Multiline = true;
      this.combo5box.Name = "combo5box";
      this.combo5box.ScrollBars = ScrollBars.Both;
      this.combo5box.Size = new Size(122, 180);
      this.combo5box.TabIndex = 47;
      this.combo5box.WordWrap = false;
      this.combo5box.TextChanged += new EventHandler(this.combo5_leave);
      this.combo5box.Leave += new EventHandler(this.combo5_leave);
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(621, 293);
      this.label2.Name = "label2";
      this.label2.Size = new Size(43, 13);
      this.label2.TabIndex = 46;
      this.label2.Text = "Trigger:";
      this.combo5trigger.Font = new Font("Arial", 9f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.combo5trigger.Location = new System.Drawing.Point(677, 290);
      this.combo5trigger.MaxLength = 7;
      this.combo5trigger.Name = "combo5trigger";
      this.combo5trigger.Size = new Size(51, 21);
      this.combo5trigger.TabIndex = 45;
      this.combo5trigger.Text = "F6";
      this.combo5trigger.KeyDown += new KeyEventHandler(this.macro_keydown);
      this.combo5trigger.KeyUp += new KeyEventHandler(this.macro5_key);
      this.combo5mod.DropDownStyle = ComboBoxStyle.DropDownList;
      this.combo5mod.Font = new Font("Arial", 9f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.combo5mod.FormattingEnabled = true;
      this.combo5mod.Items.AddRange(new object[4]
      {
        (object) "None",
        (object) "Ctrl",
        (object) "Alt",
        (object) "Shift"
      });
      this.combo5mod.Location = new System.Drawing.Point(677, 317);
      this.combo5mod.Name = "combo5mod";
      this.combo5mod.Size = new Size(51, 23);
      this.combo5mod.TabIndex = 44;
      this.usemacro5.AutoSize = true;
      this.usemacro5.Location = new System.Drawing.Point(624, 268);
      this.usemacro5.Name = "usemacro5";
      this.usemacro5.Size = new Size(87, 17);
      this.usemacro5.TabIndex = 43;
      this.usemacro5.Text = "Use Macro 5";
      this.usemacro5.UseVisualStyleBackColor = true;
      this.label44.AutoSize = true;
      this.label44.Location = new System.Drawing.Point(470, 320);
      this.label44.Name = "label44";
      this.label44.Size = new Size(44, 13);
      this.label44.TabIndex = 41;
      this.label44.Text = "Modifier";
      this.label43.AutoSize = true;
      this.label43.Location = new System.Drawing.Point(313, 320);
      this.label43.Name = "label43";
      this.label43.Size = new Size(44, 13);
      this.label43.TabIndex = 40;
      this.label43.Text = "Modifier";
      this.label42.AutoSize = true;
      this.label42.Location = new System.Drawing.Point(167, 320);
      this.label42.Name = "label42";
      this.label42.Size = new Size(44, 13);
      this.label42.TabIndex = 39;
      this.label42.Text = "Modifier";
      this.label41.AutoSize = true;
      this.label41.Location = new System.Drawing.Point(18, 320);
      this.label41.Name = "label41";
      this.label41.Size = new Size(44, 13);
      this.label41.TabIndex = 38;
      this.label41.Text = "Modifier";
      this.combo4box.Font = new Font("Arial", 9f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.combo4box.Location = new System.Drawing.Point(461, 79);
      this.combo4box.Multiline = true;
      this.combo4box.Name = "combo4box";
      this.combo4box.ScrollBars = ScrollBars.Both;
      this.combo4box.Size = new Size(122, 180);
      this.combo4box.TabIndex = 37;
      this.combo4box.WordWrap = false;
      this.combo4box.TextChanged += new EventHandler(this.combo4_leave);
      this.combo4box.Leave += new EventHandler(this.combo4_leave);
      this.combo3box.Font = new Font("Arial", 9f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.combo3box.Location = new System.Drawing.Point(307, 79);
      this.combo3box.Multiline = true;
      this.combo3box.Name = "combo3box";
      this.combo3box.ScrollBars = ScrollBars.Both;
      this.combo3box.Size = new Size(122, 180);
      this.combo3box.TabIndex = 36;
      this.combo3box.WordWrap = false;
      this.combo3box.TextChanged += new EventHandler(this.combo3_leave);
      this.combo3box.Leave += new EventHandler(this.combo3_leave);
      this.combo2box.Font = new Font("Arial", 9f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.combo2box.Location = new System.Drawing.Point(160, 79);
      this.combo2box.Multiline = true;
      this.combo2box.Name = "combo2box";
      this.combo2box.ScrollBars = ScrollBars.Both;
      this.combo2box.Size = new Size(122, 180);
      this.combo2box.TabIndex = 35;
      this.combo2box.WordWrap = false;
      this.combo2box.TextChanged += new EventHandler(this.combo2_leave);
      this.combo2box.Leave += new EventHandler(this.combo2_leave);
      this.combo1box.Font = new Font("Arial", 9f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.combo1box.Location = new System.Drawing.Point(14, 79);
      this.combo1box.Multiline = true;
      this.combo1box.Name = "combo1box";
      this.combo1box.ScrollBars = ScrollBars.Both;
      this.combo1box.Size = new Size(122, 180);
      this.combo1box.TabIndex = 34;
      this.combo1box.Text = "WFF\r\nCK\r\nD:100\r\nSD\r\nDS\r\nWK\r\nSever\r\nCharge\r\nHemloch\r\nCrasher\r\nSpace";
      this.combo1box.WordWrap = false;
      this.combo1box.TextChanged += new EventHandler(this.combo1_leave);
      this.combo1box.Leave += new EventHandler(this.combo1_leave);
      this.label40.AutoSize = true;
      this.label40.Location = new System.Drawing.Point(470, 293);
      this.label40.Name = "label40";
      this.label40.Size = new Size(43, 13);
      this.label40.TabIndex = 32;
      this.label40.Text = "Trigger:";
      this.combo4trigger.Font = new Font("Arial", 9f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.combo4trigger.Location = new System.Drawing.Point(526, 290);
      this.combo4trigger.MaxLength = 7;
      this.combo4trigger.Name = "combo4trigger";
      this.combo4trigger.Size = new Size(51, 21);
      this.combo4trigger.TabIndex = 31;
      this.combo4trigger.Text = "F4";
      this.combo4trigger.KeyDown += new KeyEventHandler(this.macro_keydown);
      this.combo4trigger.KeyUp += new KeyEventHandler(this.macro4_key);
      this.combo4mod.DropDownStyle = ComboBoxStyle.DropDownList;
      this.combo4mod.Font = new Font("Arial", 9f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.combo4mod.FormattingEnabled = true;
      this.combo4mod.Items.AddRange(new object[4]
      {
        (object) "None",
        (object) "Ctrl",
        (object) "Alt",
        (object) "Shift"
      });
      this.combo4mod.Location = new System.Drawing.Point(526, 317);
      this.combo4mod.Name = "combo4mod";
      this.combo4mod.Size = new Size(51, 23);
      this.combo4mod.TabIndex = 30;
      this.usemacro4.AutoSize = true;
      this.usemacro4.Location = new System.Drawing.Point(473, 268);
      this.usemacro4.Name = "usemacro4";
      this.usemacro4.Size = new Size(87, 17);
      this.usemacro4.TabIndex = 29;
      this.usemacro4.Text = "Use Macro 4";
      this.usemacro4.UseVisualStyleBackColor = true;
      this.combo2mod.DropDownStyle = ComboBoxStyle.DropDownList;
      this.combo2mod.Font = new Font("Arial", 9f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.combo2mod.FormattingEnabled = true;
      this.combo2mod.Items.AddRange(new object[4]
      {
        (object) "None",
        (object) "Ctrl",
        (object) "Alt",
        (object) "Shift"
      });
      this.combo2mod.Location = new System.Drawing.Point(233, 317);
      this.combo2mod.Name = "combo2mod";
      this.combo2mod.Size = new Size(51, 23);
      this.combo2mod.TabIndex = 24;
      this.label32.AutoSize = true;
      this.label32.Location = new System.Drawing.Point(313, 293);
      this.label32.Name = "label32";
      this.label32.Size = new Size(43, 13);
      this.label32.TabIndex = 22;
      this.label32.Text = "Trigger:";
      this.combo3trigger.Font = new Font("Arial", 9f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.combo3trigger.Location = new System.Drawing.Point(378, 290);
      this.combo3trigger.MaxLength = 7;
      this.combo3trigger.Name = "combo3trigger";
      this.combo3trigger.Size = new Size(51, 21);
      this.combo3trigger.TabIndex = 21;
      this.combo3trigger.Text = "F3";
      this.combo3trigger.KeyDown += new KeyEventHandler(this.macro_keydown);
      this.combo3trigger.KeyUp += new KeyEventHandler(this.macro3_key);
      this.combo3mod.DropDownStyle = ComboBoxStyle.DropDownList;
      this.combo3mod.Font = new Font("Arial", 9f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.combo3mod.FormattingEnabled = true;
      this.combo3mod.Items.AddRange(new object[4]
      {
        (object) "None",
        (object) "Ctrl",
        (object) "Alt",
        (object) "Shift"
      });
      this.combo3mod.Location = new System.Drawing.Point(378, 317);
      this.combo3mod.Name = "combo3mod";
      this.combo3mod.Size = new Size(51, 23);
      this.combo3mod.TabIndex = 20;
      this.label26.AutoSize = true;
      this.label26.Location = new System.Drawing.Point(167, 293);
      this.label26.Name = "label26";
      this.label26.Size = new Size(43, 13);
      this.label26.TabIndex = 18;
      this.label26.Text = "Trigger:";
      this.combo2trigger.Font = new Font("Arial", 9f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.combo2trigger.Location = new System.Drawing.Point(233, 290);
      this.combo2trigger.MaxLength = 7;
      this.combo2trigger.Name = "combo2trigger";
      this.combo2trigger.Size = new Size(49, 21);
      this.combo2trigger.TabIndex = 17;
      this.combo2trigger.Text = "F2";
      this.combo2trigger.KeyDown += new KeyEventHandler(this.macro_keydown);
      this.combo2trigger.KeyUp += new KeyEventHandler(this.macro2_key);
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
      this.combo1mod.Location = new System.Drawing.Point(74, 317);
      this.combo1mod.Name = "combo1mod";
      this.combo1mod.Size = new Size(51, 23);
      this.combo1mod.TabIndex = 16;
      this.label17.AutoSize = true;
      this.label17.Location = new System.Drawing.Point(18, 293);
      this.label17.Name = "label17";
      this.label17.Size = new Size(43, 13);
      this.label17.TabIndex = 14;
      this.label17.Text = "Trigger:";
      this.combo1trigger.Font = new Font("Arial", 9f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.combo1trigger.Location = new System.Drawing.Point(74, 290);
      this.combo1trigger.MaxLength = 7;
      this.combo1trigger.Name = "combo1trigger";
      this.combo1trigger.Size = new Size(53, 21);
      this.combo1trigger.TabIndex = 13;
      this.combo1trigger.Text = "F11";
      this.combo1trigger.KeyDown += new KeyEventHandler(this.macro_keydown);
      this.combo1trigger.KeyUp += new KeyEventHandler(this.macro1_key);
  //    this.label12.AutoSize = true;
   //   this.label12.Font = new Font("Arial", 9f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
  //    this.label12.ForeColor = SystemColors.ControlDarkDark;
    //  this.label12.Location = new System.Drawing.Point(11, 16);
  //    this.label12.Name = "label12";
    //  this.label12.Size = new Size(402, 60);
   //   this.label12.TabIndex = 11;
//      this.label12.Text = componentResourceManager.GetString("label12.Text"); //label12.Text
            this.usemacro3.AutoSize = true;
      this.usemacro3.Location = new System.Drawing.Point(316, 265);
      this.usemacro3.Name = "usemacro3";
      this.usemacro3.Size = new Size(87, 17);
      this.usemacro3.TabIndex = 9;
      this.usemacro3.Text = "Use Macro 3";
      this.usemacro3.UseVisualStyleBackColor = true;
      this.usemacro2.AutoSize = true;
      this.usemacro2.Location = new System.Drawing.Point(170, 265);
      this.usemacro2.Name = "usemacro2";
      this.usemacro2.Size = new Size(87, 17);
      this.usemacro2.TabIndex = 7;
      this.usemacro2.Text = "Use Macro 2";
      this.usemacro2.UseVisualStyleBackColor = true;
      this.usemacro1.AutoSize = true;
      this.usemacro1.Location = new System.Drawing.Point(21, 265);
      this.usemacro1.Name = "usemacro1";
      this.usemacro1.Size = new Size(87, 17);
      this.usemacro1.TabIndex = 6;
      this.usemacro1.Text = "Use Macro 1";
      this.usemacro1.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.AutoScroll = true;
      this.ClientSize = new Size(759, 416);
      this.Controls.Add((Control) this.groupBox35);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "ComboOptions1";
      this.Text = "Combo Editor";
      this.FormClosing += new FormClosingEventHandler(this.ComboOptions1_FormClosing);
      this.groupBox35.ResumeLayout(false);
      this.groupBox35.PerformLayout();
      this.ResumeLayout(false);
    }
  }
}
