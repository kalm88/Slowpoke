

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Flintstones
{
  public class AscendOptions : Form
  {
    public MainForm parent;
    public bool vascendbutton;
    public bool vascendhp;
    public bool vascendmp;
    public bool vbuystatsbtn;
    public bool vwithdrawhem = true;
    public bool vwithdrawwine = true;
    private IContainer components;
    private GroupBox groupBox49;
    public CheckBox withdrawwine;
    public CheckBox withdrawhem;
    public TextBox rescuername;
    private Label label55;
    public Button maxdex;
    public Button maxcon;
    public Button maxwis;
    public Button maxint;
    public Button maxstr;
    public Label totall2;
    public Label totall;
    public Button buystatsbtn;
    public NumericUpDown buynum;
    private Label label57;
    public Label numstatl;
    private GroupBox groupBox51;
    public Label dexl;
    public Label conl;
    public Label wisl;
    public Label intl;
    public Label strl;
    private GroupBox groupBox50;
    private Label label23;
    public TextBox dext;
    private Label label47;
    public TextBox cont;
    private Label label52;
    public TextBox wist;
    private Label label53;
    public TextBox intt;
    private Label label54;
    public TextBox strt;
    private GroupBox groupBox23;
    public Button ascendbutton;
    private Label label28;
    public RadioButton ascendmp;
    public RadioButton ascendhp;
    private Label label1;
    public Label currentexpboxed;
    public CheckBox instantascend;
    private Label label2;
    private Label label3;
    public Label currentbasehp;
    public Label currentbasemp;
    private Label label4;
    private Label label5;
    private Label label6;
    public Label buytoexpreqlab;
    public NumericUpDown buytompvalue;
    public NumericUpDown buytohpvalue;
    public RadioButton buyto;
    public CheckBox powermonk;

    public Client Client { get; private set; }

    public AscendOptions(Client client)
    {
      this.parent = Program.MainForm;
      this.Client = client;
      this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
      this.InitializeComponent();
    }

    private void AscendOptions_FormClosing(object sender, FormClosingEventArgs e)
    {
      e.Cancel = true;
      this.Hide();
      this.Client.Tab.openascendform.Enabled = true;
    }

    private void ascendbutton_TextChanged(object sender, EventArgs e)
    {
      if (this.ascendbutton.Text.Equals("Start"))
        this.vascendbutton = false;
      else
        this.vascendbutton = true;
    }

    private void ascendbutton_Click(object sender, EventArgs e)
    {
      if (this.ascendbutton.Text.Equals("Start"))
        this.ascendbutton.Text = "Stop";
      else
        this.ascendbutton.Text = "Start";
    }

    private void ascendhp_CheckedChanged(object sender, EventArgs e) => this.vascendhp = this.ascendhp.Checked;

    private void ascendmp_CheckedChanged(object sender, EventArgs e) => this.vascendmp = this.ascendmp.Checked;

    private void buystatsbtn_TextChanged(object sender, EventArgs e)
    {
      if (this.buystatsbtn.Text.Equals("Start"))
        this.vbuystatsbtn = false;
      else
        this.vbuystatsbtn = true;
    }

    private void buystatsbtn_Click(object sender, EventArgs e)
    {
      double d = (double) (this.Client.Statistics.MaximumHP - this.Client.pathmaxhp) / 150.0;
      if (this.buystatsbtn.Text.Equals("Start"))
      {
        this.statbuyupdate();
        if (this.statboxesempty() || !this.canaffordallstats() || !this.canaffordonestat() && Math.Floor(d) <= 0.0)
          return;
        this.buystatsbtn.Text = "Stop";
      }
      else
        this.buystatsbtn.Text = "Start";
    }

    public bool statboxesempty()
    {
      int num1 = 0;
      int num2 = 0;
      int num3 = 0;
      int num4 = 0;
      int num5 = 0;
      if (this.strt.Text != string.Empty)
        num1 = int.Parse(this.strt.Text);
      if (this.intt.Text != string.Empty)
        num2 = int.Parse(this.intt.Text);
      if (this.wist.Text != string.Empty)
        num3 = int.Parse(this.wist.Text);
      if (this.cont.Text != string.Empty)
        num4 = int.Parse(this.cont.Text);
      if (this.dext.Text != string.Empty)
        num5 = int.Parse(this.dext.Text);
      if ((this.strt.Text == string.Empty || num1 == 0) && (this.intt.Text == string.Empty || num2 == 0) && (this.wist.Text == string.Empty || num3 == 0) && (this.cont.Text == string.Empty || num4 == 0) && (this.dext.Text == string.Empty || num5 == 0))
      {
        this.Client.SendMessage("Set amount of stats first.");
        return true;
      }
      if ((long) (this.Client.Statistics.Str + num1) > (long) this.Client.pathstr)
      {
        this.Client.SendMessage("Str cannot exceed " + this.Client.pathstr.ToString());
        return true;
      }
      if ((long) (this.Client.Statistics.Int + num2) > (long) this.Client.pathint)
      {
        this.Client.SendMessage("Int cannot exceed " + this.Client.pathint.ToString());
        return true;
      }
      if ((long) (this.Client.Statistics.Wis + num3) > (long) this.Client.pathwis)
      {
        this.Client.SendMessage("Wis cannot exceed " + this.Client.pathwis.ToString());
        return true;
      }
      if ((long) (this.Client.Statistics.Con + num4) > (long) this.Client.pathcon)
      {
        this.Client.SendMessage("Con cannot exceed " + this.Client.pathcon.ToString());
        return true;
      }
      if ((long) (this.Client.Statistics.Dex + num5) > (long) this.Client.pathdex)
      {
        this.Client.SendMessage("Dex cannot exceed " + this.Client.pathdex.ToString());
        return true;
      }
      if (!(this.rescuername.Text == string.Empty))
        return false;
      this.Client.SendMessage("You need a Rescuer.");
      return true;
    }

    public bool canaffordonestat()
    {
      if (this.Client.Statistics.MaximumHP < this.Client.pathmaxhp)
      {
        this.Client.SendMessage("You are below base (" + this.Client.pathmaxhp.ToString() + "), go buy hp.");
        this.buystatsbtn.Text = "Start";
        return false;
      }
      uint experience = this.Client.Statistics.Experience;
      double num1 = (double) (this.Client.Statistics.MaximumHP - this.Client.pathmaxhp) / 150.0;
      int num2 = ((int) this.Client.Statistics.MaximumHP - (int) this.Client.pathmaxhp) % 50;
      int num3 = ((int) this.Client.Statistics.MaximumHP - (int) this.Client.pathmaxhp) % 150 / 50;
      int pathmaxhp = (int) this.Client.pathmaxhp;
      int num4 = ((int) this.Client.Statistics.MaximumHP - (int) this.Client.pathmaxhp) % 150 + (int) this.Client.pathmaxhp;
      uint num5 = 0;
      for (int index = 0; index < 3 - num3; ++index)
        num5 += (uint) ((num4 + index * 50) * 500);
      if (Math.Floor((double) experience / (double) num5) > 0.0)
        return true;
      this.Client.SendMessage("Insufficient Experience for one stat");
      return false;
    }

    public bool canaffordallstats()
    {
      if (this.Client.Statistics.MaximumHP < this.Client.pathmaxhp)
      {
        this.Client.SendMessage("You are below base (" + this.Client.pathmaxhp.ToString() + "), go buy hp.");
        this.buystatsbtn.Text = "Start";
        return false;
      }
      long num1 = 0;
      int num2 = 0;
      int num3 = 0;
      int num4 = 0;
      int num5 = 0;
      int num6 = 0;
      if (this.strt.Text != string.Empty)
        num2 = int.Parse(this.strt.Text);
      if (this.intt.Text != string.Empty)
        num3 = int.Parse(this.intt.Text);
      if (this.wist.Text != string.Empty)
        num4 = int.Parse(this.wist.Text);
      if (this.cont.Text != string.Empty)
        num5 = int.Parse(this.cont.Text);
      if (this.dext.Text != string.Empty)
        num6 = int.Parse(this.dext.Text);
      int num7 = num2 + num3 + num4 + num5 + num6;
      uint experience = this.Client.Statistics.Experience;
      double d = (double) (this.Client.Statistics.MaximumHP - this.Client.pathmaxhp) / 150.0;
      int num8 = ((int) this.Client.Statistics.MaximumHP - (int) this.Client.pathmaxhp) % 50;
      int num9 = ((int) this.Client.Statistics.MaximumHP - (int) this.Client.pathmaxhp) % 150 / 50;
      int pathmaxhp = (int) this.Client.pathmaxhp;
      int num10 = num8 + pathmaxhp;
      int num11 = ((int) this.Client.Statistics.MaximumHP - (int) this.Client.pathmaxhp) % 150 + (int) this.Client.pathmaxhp;
      uint num12 = 0;
      for (int index = 0; (Decimal) index < this.buynum.Value * 3M; ++index)
        num12 += (uint) ((num10 + index * 50) * 500);
      if ((double) num7 > Math.Floor(d))
      {
        int num13 = num7 - (int) Math.Floor(d);
        uint num14 = 0;
        uint num15;
        if ((Decimal) num13 > this.buynum.Value)
        {
          int num16 = num13 / (int) this.buynum.Value - 1;
          int num17 = num13 % (int) this.buynum.Value;
          uint num18 = 0;
          for (int index = 0; index < num17 * 3; ++index)
            num18 += (uint) ((num10 + index * 50) * 500);
          for (int index = 0; (Decimal) index < this.buynum.Value * 3M - (Decimal) num9; ++index)
            num14 += (uint) ((num11 + index * 50) * 500);
          num15 = (uint) ((ulong) num12 * (ulong) num16) + num18;
        }
        else
        {
          num15 = 0U;
          for (int index = 0; index < num13 * 3 - num9; ++index)
            num14 += (uint) ((num11 + index * 50) * 500);
        }
        num1 = (long) num15 + (long) num14;
      }
      if ((long) experience >= num1)
        return true;
      this.Client.SendMessage("Insufficient Experience for total stats");
      return false;
    }

    public void statbuyupdate()
    {
      int num1 = 0;
      int num2 = 0;
      int num3 = 0;
      int num4 = 0;
      int num5 = 0;
      if (this.strt.Text != string.Empty)
        num1 = int.Parse(this.strt.Text);
      if (this.intt.Text != string.Empty)
        num2 = int.Parse(this.intt.Text);
      if (this.wist.Text != string.Empty)
        num3 = int.Parse(this.wist.Text);
      if (this.cont.Text != string.Empty)
        num4 = int.Parse(this.cont.Text);
      if (this.dext.Text != string.Empty)
        num5 = int.Parse(this.dext.Text);
      int num6 = num1 + num2 + num3 + num4 + num5;
      uint experience = this.Client.Statistics.Experience;
      double d = (double) (this.Client.Statistics.MaximumHP - this.Client.pathmaxhp) / 150.0;
      int num7 = ((int) this.Client.Statistics.MaximumHP - (int) this.Client.pathmaxhp) % 50;
      int num8 = ((int) this.Client.Statistics.MaximumHP - (int) this.Client.pathmaxhp) % 150 / 50;
      int pathmaxhp = (int) this.Client.pathmaxhp;
      int num9 = num7 + pathmaxhp;
      int num10 = ((int) this.Client.Statistics.MaximumHP - (int) this.Client.pathmaxhp) % 150 + (int) this.Client.pathmaxhp;
      uint num11 = 0;
      for (int index = 0; (Decimal) index < this.buynum.Value * 3M; ++index)
        num11 += (uint) ((num9 + index * 50) * 500);
      double num12 = (double) experience / (double) num11;
      if ((double) num6 <= Math.Floor(d))
      {
        this.totall.Text = "0 Exp needed for";
        this.totall2.Text = num6.ToString() + " stats at " + this.buynum.Value.ToString() + " stats per ascension.";
      }
      else
      {
        int num13 = num6 - (int) Math.Floor(d);
        uint num14 = 0;
        uint num15;
        if ((Decimal) num13 > this.buynum.Value)
        {
          int num16 = num13 / (int) this.buynum.Value - 1;
          int num17 = num13 % (int) this.buynum.Value;
          uint num18 = 0;
          for (int index = 0; index < num17 * 3; ++index)
            num18 += (uint) ((num9 + index * 50) * 500);
          for (int index = 0; (Decimal) index < this.buynum.Value * 3M - (Decimal) num8; ++index)
            num14 += (uint) ((num10 + index * 50) * 500);
          num15 = (uint) ((ulong) num11 * (ulong) num16) + num18;
        }
        else
        {
          num15 = 0U;
          for (int index = 0; index < num13 * 3 - num8; ++index)
            num14 += (uint) ((num10 + index * 50) * 500);
        }
        this.totall.Text = ((long) num15 + (long) num14).ToString("#,##0") + " Exp needed for";
        this.totall2.Text = num13.ToString() + " stats at " + this.buynum.Value.ToString() + " stats per ascension.";
      }
      double num19 = Math.Floor(num12 * (double) this.buynum.Value) + Math.Floor(d) - (double) num6;
      this.strl.Text = (this.Client.Statistics.Str + num1).ToString();
      this.intl.Text = (this.Client.Statistics.Int + num2).ToString();
      this.wisl.Text = (this.Client.Statistics.Wis + num3).ToString();
      this.conl.Text = (this.Client.Statistics.Con + num4).ToString();
      this.dexl.Text = (this.Client.Statistics.Dex + num5).ToString();
      if ((long) int.Parse(this.strl.Text) > (long) this.Client.pathstr)
        this.strl.ForeColor = Color.Red;
      else
        this.strl.ForeColor = Color.Black;
      if ((long) int.Parse(this.intl.Text) > (long) this.Client.pathint)
        this.intl.ForeColor = Color.Red;
      else
        this.intl.ForeColor = Color.Black;
      if ((long) int.Parse(this.wisl.Text) > (long) this.Client.pathwis)
        this.wisl.ForeColor = Color.Red;
      else
        this.wisl.ForeColor = Color.Black;
      if ((long) int.Parse(this.conl.Text) > (long) this.Client.pathcon)
        this.conl.ForeColor = Color.Red;
      else
        this.conl.ForeColor = Color.Black;
      if ((long) int.Parse(this.dexl.Text) > (long) this.Client.pathdex)
        this.dexl.ForeColor = Color.Red;
      else
        this.dexl.ForeColor = Color.Black;
      this.numstatl.Text = "# of stats available: " + num19.ToString();
      if (num19 > 0.0)
        this.numstatl.ForeColor = Color.Blue;
      else
        this.numstatl.ForeColor = Color.Black;
    }

    private void maxstr_Click(object sender, EventArgs e)
    {
      int num = 0;
      if (this.strt.Text != string.Empty)
        num = int.Parse(this.strt.Text);
      this.strt.Text = (num + (int) this.Client.pathstr - int.Parse(this.strl.Text)).ToString();
    }

    private void maxint_Click(object sender, EventArgs e)
    {
      int num = 0;
      if (this.intt.Text != string.Empty)
        num = int.Parse(this.intt.Text);
      this.intt.Text = (num + (int) this.Client.pathint - int.Parse(this.intl.Text)).ToString();
    }

    private void maxwis_Click(object sender, EventArgs e)
    {
      int num = 0;
      if (this.wist.Text != string.Empty)
        num = int.Parse(this.wist.Text);
      this.wist.Text = (num + (int) this.Client.pathwis - int.Parse(this.wisl.Text)).ToString();
    }

    private void maxcon_Click(object sender, EventArgs e)
    {
      int num = 0;
      if (this.cont.Text != string.Empty)
        num = int.Parse(this.cont.Text);
      this.cont.Text = (num + (int) this.Client.pathcon - int.Parse(this.conl.Text)).ToString();
    }

    private void maxdex_Click(object sender, EventArgs e)
    {
      int num = 0;
      if (this.dext.Text != string.Empty)
        num = int.Parse(this.dext.Text);
      this.dext.Text = (num + (int) this.Client.pathdex - int.Parse(this.dexl.Text)).ToString();
    }

    private void strt_TextChanged(object sender, EventArgs e) => this.statbuyupdate();

    private void buynum_ValueChanged(object sender, EventArgs e) => this.statbuyupdate();

    private void strt_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
        return;
      e.Handled = true;
    }

    private void withdrawhem_CheckedChanged(object sender, EventArgs e) => this.vwithdrawhem = this.withdrawhem.Checked;

    private void withdrawwine_CheckedChanged(object sender, EventArgs e) => this.vwithdrawwine = this.withdrawwine.Checked;

    private void buytohpvalue_ValueChanged(object sender, EventArgs e)
    {
      uint num1 = 0;
      if (this.buytohpvalue.Value > 0M && this.buytohpvalue.Value > (Decimal) this.Client.Statistics.MaximumHP)
      {
        int num2 = (int) Math.Ceiling(((double) this.buytohpvalue.Value - (double) this.Client.Statistics.MaximumHP) / 50.0);
        for (int index = 0; index < num2; ++index)
          num1 += (uint) (((ulong) this.Client.Statistics.MaximumHP + (ulong) (index * 50)) * 500UL);
      }
      if (this.buytompvalue.Value > 0M && this.buytompvalue.Value > (Decimal) this.Client.Statistics.MaximumMP)
      {
        int num3 = (int) Math.Ceiling(((double) this.buytompvalue.Value - (double) this.Client.Statistics.MaximumMP) / 25.0);
        for (int index = 0; index < num3; ++index)
          num1 += (uint) (((ulong) this.Client.Statistics.MaximumMP + (ulong) (index * 25)) * 500UL);
      }
      this.buytoexpreqlab.Text = num1.ToString("#,##0");
    }

    private void powermonk_CheckedChanged(object sender, EventArgs e)
    {
      if (this.powermonk.Checked)
      {
        if (this.Client.Path != (byte) 5)
          return;
        this.Client.pathmaxhp = 8850U;
      }
      else
      {
        if (this.Client.Path != (byte) 5)
          return;
        this.Client.pathmaxhp = 6850U;
      }
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.groupBox49 = new GroupBox();
      this.withdrawwine = new CheckBox();
      this.withdrawhem = new CheckBox();
      this.rescuername = new TextBox();
      this.label55 = new Label();
      this.maxdex = new Button();
      this.maxcon = new Button();
      this.maxwis = new Button();
      this.maxint = new Button();
      this.maxstr = new Button();
      this.totall2 = new Label();
      this.totall = new Label();
      this.buystatsbtn = new Button();
      this.buynum = new NumericUpDown();
      this.label57 = new Label();
      this.numstatl = new Label();
      this.groupBox51 = new GroupBox();
      this.dexl = new Label();
      this.conl = new Label();
      this.wisl = new Label();
      this.intl = new Label();
      this.strl = new Label();
      this.groupBox50 = new GroupBox();
      this.label23 = new Label();
      this.dext = new TextBox();
      this.label47 = new Label();
      this.cont = new TextBox();
      this.label52 = new Label();
      this.wist = new TextBox();
      this.label53 = new Label();
      this.intt = new TextBox();
      this.label54 = new Label();
      this.strt = new TextBox();
      this.groupBox23 = new GroupBox();
      this.currentbasemp = new Label();
      this.buytoexpreqlab = new Label();
      this.currentbasehp = new Label();
      this.label6 = new Label();
      this.label3 = new Label();
      this.label5 = new Label();
      this.label2 = new Label();
      this.label4 = new Label();
      this.instantascend = new CheckBox();
      this.ascendbutton = new Button();
      this.label28 = new Label();
      this.buytompvalue = new NumericUpDown();
      this.buytohpvalue = new NumericUpDown();
      this.buyto = new RadioButton();
      this.ascendmp = new RadioButton();
      this.ascendhp = new RadioButton();
      this.label1 = new Label();
      this.currentexpboxed = new Label();
      this.powermonk = new CheckBox();
      this.groupBox49.SuspendLayout();
      this.buynum.BeginInit();
      this.groupBox51.SuspendLayout();
      this.groupBox50.SuspendLayout();
      this.groupBox23.SuspendLayout();
      this.buytompvalue.BeginInit();
      this.buytohpvalue.BeginInit();
      this.SuspendLayout();
      this.groupBox49.Controls.Add((Control) this.powermonk);
      this.groupBox49.Controls.Add((Control) this.withdrawwine);
      this.groupBox49.Controls.Add((Control) this.withdrawhem);
      this.groupBox49.Controls.Add((Control) this.rescuername);
      this.groupBox49.Controls.Add((Control) this.label55);
      this.groupBox49.Controls.Add((Control) this.maxdex);
      this.groupBox49.Controls.Add((Control) this.maxcon);
      this.groupBox49.Controls.Add((Control) this.maxwis);
      this.groupBox49.Controls.Add((Control) this.maxint);
      this.groupBox49.Controls.Add((Control) this.maxstr);
      this.groupBox49.Controls.Add((Control) this.totall2);
      this.groupBox49.Controls.Add((Control) this.totall);
      this.groupBox49.Controls.Add((Control) this.buystatsbtn);
      this.groupBox49.Controls.Add((Control) this.buynum);
      this.groupBox49.Controls.Add((Control) this.label57);
      this.groupBox49.Controls.Add((Control) this.numstatl);
      this.groupBox49.Controls.Add((Control) this.groupBox51);
      this.groupBox49.Controls.Add((Control) this.groupBox50);
      this.groupBox49.Location = new System.Drawing.Point(12, 12);
      this.groupBox49.Name = "groupBox49";
      this.groupBox49.Size = new Size(343, 369);
      this.groupBox49.TabIndex = 10;
      this.groupBox49.TabStop = false;
      this.groupBox49.Text = "Buy Stats";
      this.withdrawwine.AutoSize = true;
      this.withdrawwine.Checked = true;
      this.withdrawwine.CheckState = CheckState.Checked;
      this.withdrawwine.Location = new System.Drawing.Point(233, 137);
      this.withdrawwine.Name = "withdrawwine";
      this.withdrawwine.Size = new Size(99, 17);
      this.withdrawwine.TabIndex = 28;
      this.withdrawwine.Text = "Wtihdraw Wine";
      this.withdrawwine.UseVisualStyleBackColor = true;
      this.withdrawwine.CheckedChanged += new EventHandler(this.withdrawwine_CheckedChanged);
      this.withdrawhem.AutoSize = true;
      this.withdrawhem.Checked = true;
      this.withdrawhem.CheckState = CheckState.Checked;
      this.withdrawhem.Location = new System.Drawing.Point(233, 112);
      this.withdrawhem.Name = "withdrawhem";
      this.withdrawhem.Size = new Size(96, 17);
      this.withdrawhem.TabIndex = 27;
      this.withdrawhem.Text = "Withdraw Hem";
      this.withdrawhem.UseVisualStyleBackColor = true;
      this.withdrawhem.CheckedChanged += new EventHandler(this.withdrawhem_CheckedChanged);
      this.rescuername.Location = new System.Drawing.Point(233, 63);
      this.rescuername.Name = "rescuername";
      this.rescuername.Size = new Size(100, 20);
      this.rescuername.TabIndex = 25;
      this.label55.AutoSize = true;
      this.label55.Location = new System.Drawing.Point(249, 43);
      this.label55.Name = "label55";
      this.label55.Size = new Size(50, 13);
      this.label55.TabIndex = 24;
      this.label55.Text = "Rescuer:";
      this.maxdex.Location = new System.Drawing.Point(161, 149);
      this.maxdex.Name = "maxdex";
      this.maxdex.Size = new Size(45, 23);
      this.maxdex.TabIndex = 23;
      this.maxdex.Text = "fill";
      this.maxdex.UseVisualStyleBackColor = true;
      this.maxdex.Click += new EventHandler(this.maxdex_Click);
      this.maxcon.Location = new System.Drawing.Point(161, 121);
      this.maxcon.Name = "maxcon";
      this.maxcon.Size = new Size(45, 23);
      this.maxcon.TabIndex = 22;
      this.maxcon.Text = "fill";
      this.maxcon.UseVisualStyleBackColor = true;
      this.maxcon.Click += new EventHandler(this.maxcon_Click);
      this.maxwis.Location = new System.Drawing.Point(161, 93);
      this.maxwis.Name = "maxwis";
      this.maxwis.Size = new Size(45, 23);
      this.maxwis.TabIndex = 21;
      this.maxwis.Text = "fill";
      this.maxwis.UseVisualStyleBackColor = true;
      this.maxwis.Click += new EventHandler(this.maxwis_Click);
      this.maxint.Location = new System.Drawing.Point(161, 65);
      this.maxint.Name = "maxint";
      this.maxint.Size = new Size(45, 23);
      this.maxint.TabIndex = 20;
      this.maxint.Text = "fill";
      this.maxint.UseVisualStyleBackColor = true;
      this.maxint.Click += new EventHandler(this.maxint_Click);
      this.maxstr.Location = new System.Drawing.Point(161, 39);
      this.maxstr.Name = "maxstr";
      this.maxstr.Size = new Size(45, 23);
      this.maxstr.TabIndex = 19;
      this.maxstr.Text = "fill";
      this.maxstr.UseVisualStyleBackColor = true;
      this.maxstr.Click += new EventHandler(this.maxstr_Click);
      this.totall2.AutoSize = true;
      this.totall2.Location = new System.Drawing.Point(6, 292);
      this.totall2.Name = "totall2";
      this.totall2.Size = new Size(156, 13);
      this.totall2.TabIndex = 18;
      this.totall2.Text = "0 stats at 0 stats per ascension.";
      this.totall.AutoSize = true;
      this.totall.Location = new System.Drawing.Point(6, 268);
      this.totall.Name = "totall";
      this.totall.Size = new Size(88, 13);
      this.totall.TabIndex = 17;
      this.totall.Text = "0 Exp needed for";
      this.buystatsbtn.Location = new System.Drawing.Point(224, 316);
      this.buystatsbtn.Name = "buystatsbtn";
      this.buystatsbtn.Size = new Size(95, 36);
      this.buystatsbtn.TabIndex = 16;
      this.buystatsbtn.Text = "Start";
      this.buystatsbtn.UseVisualStyleBackColor = true;
      this.buystatsbtn.TextChanged += new EventHandler(this.buystatsbtn_TextChanged);
      this.buystatsbtn.Click += new EventHandler(this.buystatsbtn_Click);
      this.buynum.Location = new System.Drawing.Point(172, 231);
      this.buynum.Maximum = new Decimal(new int[4]
      {
        (int) byte.MaxValue,
        0,
        0,
        0
      });
      this.buynum.Minimum = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.buynum.Name = "buynum";
      this.buynum.Size = new Size(34, 20);
      this.buynum.TabIndex = 15;
      this.buynum.Value = new Decimal(new int[4]
      {
        5,
        0,
        0,
        0
      });
      this.buynum.ValueChanged += new EventHandler(this.buynum_ValueChanged);
      this.label57.AutoSize = true;
      this.label57.Location = new System.Drawing.Point(6, 233);
      this.label57.Name = "label57";
      this.label57.Size = new Size(142, 13);
      this.label57.TabIndex = 14;
      this.label57.Text = "# of stats to buy per ascend:";
      this.numstatl.AutoSize = true;
      this.numstatl.Location = new System.Drawing.Point(6, 199);
      this.numstatl.Name = "numstatl";
      this.numstatl.Size = new Size(99, 13);
      this.numstatl.TabIndex = 12;
      this.numstatl.Text = "# of stats available:";
      this.groupBox51.Controls.Add((Control) this.dexl);
      this.groupBox51.Controls.Add((Control) this.conl);
      this.groupBox51.Controls.Add((Control) this.wisl);
      this.groupBox51.Controls.Add((Control) this.intl);
      this.groupBox51.Controls.Add((Control) this.strl);
      this.groupBox51.Location = new System.Drawing.Point(106, 20);
      this.groupBox51.Name = "groupBox51";
      this.groupBox51.Size = new Size(49, 161);
      this.groupBox51.TabIndex = 11;
      this.groupBox51.TabStop = false;
      this.dexl.AutoSize = true;
      this.dexl.Location = new System.Drawing.Point(15, 133);
      this.dexl.Name = "dexl";
      this.dexl.Size = new Size(13, 13);
      this.dexl.TabIndex = 4;
      this.dexl.Text = "0";
      this.conl.AutoSize = true;
      this.conl.Location = new System.Drawing.Point(15, 105);
      this.conl.Name = "conl";
      this.conl.Size = new Size(13, 13);
      this.conl.TabIndex = 3;
      this.conl.Text = "0";
      this.wisl.AutoSize = true;
      this.wisl.Location = new System.Drawing.Point(15, 77);
      this.wisl.Name = "wisl";
      this.wisl.Size = new Size(13, 13);
      this.wisl.TabIndex = 2;
      this.wisl.Text = "0";
      this.intl.AutoSize = true;
      this.intl.Location = new System.Drawing.Point(15, 49);
      this.intl.Name = "intl";
      this.intl.Size = new Size(13, 13);
      this.intl.TabIndex = 1;
      this.intl.Text = "0";
      this.strl.AutoSize = true;
      this.strl.Location = new System.Drawing.Point(15, 23);
      this.strl.Name = "strl";
      this.strl.Size = new Size(13, 13);
      this.strl.TabIndex = 0;
      this.strl.Text = "0";
      this.groupBox50.Controls.Add((Control) this.label23);
      this.groupBox50.Controls.Add((Control) this.dext);
      this.groupBox50.Controls.Add((Control) this.label47);
      this.groupBox50.Controls.Add((Control) this.cont);
      this.groupBox50.Controls.Add((Control) this.label52);
      this.groupBox50.Controls.Add((Control) this.wist);
      this.groupBox50.Controls.Add((Control) this.label53);
      this.groupBox50.Controls.Add((Control) this.intt);
      this.groupBox50.Controls.Add((Control) this.label54);
      this.groupBox50.Controls.Add((Control) this.strt);
      this.groupBox50.Location = new System.Drawing.Point(6, 20);
      this.groupBox50.Name = "groupBox50";
      this.groupBox50.Size = new Size(94, 161);
      this.groupBox50.TabIndex = 10;
      this.groupBox50.TabStop = false;
      this.label23.AutoSize = true;
      this.label23.Location = new System.Drawing.Point(6, 23);
      this.label23.Name = "label23";
      this.label23.Size = new Size(32, 13);
      this.label23.TabIndex = 0;
      this.label23.Text = "STR:";
      this.dext.Location = new System.Drawing.Point(46, 130);
      this.dext.MaxLength = 5;
      this.dext.Name = "dext";
      this.dext.Size = new Size(38, 20);
      this.dext.TabIndex = 9;
      this.dext.TextChanged += new EventHandler(this.strt_TextChanged);
      this.dext.KeyPress += new KeyPressEventHandler(this.strt_KeyPress);
      this.label47.AutoSize = true;
      this.label47.Location = new System.Drawing.Point(6, 49);
      this.label47.Name = "label47";
      this.label47.Size = new Size(28, 13);
      this.label47.TabIndex = 1;
      this.label47.Text = "INT:";
      this.cont.Location = new System.Drawing.Point(46, 102);
      this.cont.MaxLength = 5;
      this.cont.Name = "cont";
      this.cont.Size = new Size(38, 20);
      this.cont.TabIndex = 8;
      this.cont.TextChanged += new EventHandler(this.strt_TextChanged);
      this.cont.KeyPress += new KeyPressEventHandler(this.strt_KeyPress);
      this.label52.AutoSize = true;
      this.label52.Location = new System.Drawing.Point(6, 77);
      this.label52.Name = "label52";
      this.label52.Size = new Size(31, 13);
      this.label52.TabIndex = 2;
      this.label52.Text = "WIS:";
      this.wist.Location = new System.Drawing.Point(46, 74);
      this.wist.MaxLength = 5;
      this.wist.Name = "wist";
      this.wist.Size = new Size(38, 20);
      this.wist.TabIndex = 7;
      this.wist.TextChanged += new EventHandler(this.strt_TextChanged);
      this.wist.KeyPress += new KeyPressEventHandler(this.strt_KeyPress);
      this.label53.AutoSize = true;
      this.label53.Location = new System.Drawing.Point(6, 105);
      this.label53.Name = "label53";
      this.label53.Size = new Size(33, 13);
      this.label53.TabIndex = 3;
      this.label53.Text = "CON:";
      this.intt.Location = new System.Drawing.Point(46, 46);
      this.intt.MaxLength = 5;
      this.intt.Name = "intt";
      this.intt.Size = new Size(38, 20);
      this.intt.TabIndex = 6;
      this.intt.TextChanged += new EventHandler(this.strt_TextChanged);
      this.intt.KeyPress += new KeyPressEventHandler(this.strt_KeyPress);
      this.label54.AutoSize = true;
      this.label54.Location = new System.Drawing.Point(6, 133);
      this.label54.Name = "label54";
      this.label54.Size = new Size(32, 13);
      this.label54.TabIndex = 4;
      this.label54.Text = "DEX:";
      this.strt.Location = new System.Drawing.Point(46, 20);
      this.strt.MaxLength = 3;
      this.strt.Name = "strt";
      this.strt.Size = new Size(38, 20);
      this.strt.TabIndex = 5;
      this.strt.TextChanged += new EventHandler(this.strt_TextChanged);
      this.strt.KeyPress += new KeyPressEventHandler(this.strt_KeyPress);
      this.groupBox23.Controls.Add((Control) this.currentbasemp);
      this.groupBox23.Controls.Add((Control) this.buytoexpreqlab);
      this.groupBox23.Controls.Add((Control) this.currentbasehp);
      this.groupBox23.Controls.Add((Control) this.label6);
      this.groupBox23.Controls.Add((Control) this.label3);
      this.groupBox23.Controls.Add((Control) this.label5);
      this.groupBox23.Controls.Add((Control) this.label2);
      this.groupBox23.Controls.Add((Control) this.label4);
      this.groupBox23.Controls.Add((Control) this.instantascend);
      this.groupBox23.Controls.Add((Control) this.ascendbutton);
      this.groupBox23.Controls.Add((Control) this.label28);
      this.groupBox23.Controls.Add((Control) this.buytompvalue);
      this.groupBox23.Controls.Add((Control) this.buytohpvalue);
      this.groupBox23.Controls.Add((Control) this.buyto);
      this.groupBox23.Controls.Add((Control) this.ascendmp);
      this.groupBox23.Controls.Add((Control) this.ascendhp);
      this.groupBox23.Location = new System.Drawing.Point(376, 12);
      this.groupBox23.Name = "groupBox23";
      this.groupBox23.Size = new Size(183, 269);
      this.groupBox23.TabIndex = 9;
      this.groupBox23.TabStop = false;
      this.groupBox23.Text = "Ascend";
      this.currentbasemp.AutoSize = true;
      this.currentbasemp.Location = new System.Drawing.Point(62, 243);
      this.currentbasemp.Name = "currentbasemp";
      this.currentbasemp.Size = new Size(13, 13);
      this.currentbasemp.TabIndex = 16;
      this.currentbasemp.Text = "0";
      this.buytoexpreqlab.AutoSize = true;
      this.buytoexpreqlab.Location = new System.Drawing.Point(62, 199);
      this.buytoexpreqlab.Name = "buytoexpreqlab";
      this.buytoexpreqlab.Size = new Size(13, 13);
      this.buytoexpreqlab.TabIndex = 17;
      this.buytoexpreqlab.Text = "0";
      this.currentbasehp.AutoSize = true;
      this.currentbasehp.Location = new System.Drawing.Point(62, 220);
      this.currentbasehp.Name = "currentbasehp";
      this.currentbasehp.Size = new Size(13, 13);
      this.currentbasehp.TabIndex = 15;
      this.currentbasehp.Text = "0";
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(8, 199);
      this.label6.Name = "label6";
      this.label6.Size = new Size(46, 13);
      this.label6.TabIndex = 16;
      this.label6.Text = "Exp req:";
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(8, 243);
      this.label3.Name = "label3";
      this.label3.Size = new Size(49, 13);
      this.label3.TabIndex = 14;
      this.label3.Text = "Max MP:";
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(8, 164);
      this.label5.Name = "label5";
      this.label5.Size = new Size(60, 26);
      this.label5.TabIndex = 15;
      this.label5.Text = "(full disrobe\r\nsuggested)";
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(8, 220);
      this.label2.Name = "label2";
      this.label2.Size = new Size(48, 13);
      this.label2.TabIndex = 13;
      this.label2.Text = "Max HP:";
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(73, 144);
      this.label4.Name = "label4";
      this.label4.Size = new Size(25, 13);
      this.label4.TabIndex = 14;
      this.label4.Text = "HP:";
      this.instantascend.AutoSize = true;
      this.instantascend.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.instantascend.Location = new System.Drawing.Point(6, 63);
      this.instantascend.Name = "instantascend";
      this.instantascend.Size = new Size(111, 17);
      this.instantascend.TabIndex = 13;
      this.instantascend.Text = "Instant Ascend";
      this.instantascend.UseVisualStyleBackColor = true;
      this.ascendbutton.Location = new System.Drawing.Point(38, 20);
      this.ascendbutton.Name = "ascendbutton";
      this.ascendbutton.Size = new Size(94, 27);
      this.ascendbutton.TabIndex = 6;
      this.ascendbutton.Text = "Start";
      this.ascendbutton.UseVisualStyleBackColor = true;
      this.ascendbutton.TextChanged += new EventHandler(this.ascendbutton_TextChanged);
      this.ascendbutton.Click += new EventHandler(this.ascendbutton_Click);
      this.label28.AutoSize = true;
      this.label28.Location = new System.Drawing.Point(73, 170);
      this.label28.Name = "label28";
      this.label28.Size = new Size(26, 13);
      this.label28.TabIndex = 5;
      this.label28.Text = "MP:";
      this.buytompvalue.Increment = new Decimal(new int[4]
      {
        200,
        0,
        0,
        0
      });
      this.buytompvalue.Location = new System.Drawing.Point(102, 168);
      this.buytompvalue.Maximum = new Decimal(new int[4]
      {
        1000000,
        0,
        0,
        0
      });
      this.buytompvalue.Name = "buytompvalue";
      this.buytompvalue.Size = new Size(65, 20);
      this.buytompvalue.TabIndex = 4;
      this.buytompvalue.ValueChanged += new EventHandler(this.buytohpvalue_ValueChanged);
      this.buytohpvalue.Increment = new Decimal(new int[4]
      {
        200,
        0,
        0,
        0
      });
      this.buytohpvalue.Location = new System.Drawing.Point(102, 142);
      this.buytohpvalue.Maximum = new Decimal(new int[4]
      {
        1000000,
        0,
        0,
        0
      });
      this.buytohpvalue.Name = "buytohpvalue";
      this.buytohpvalue.Size = new Size(65, 20);
      this.buytohpvalue.TabIndex = 3;
      this.buytohpvalue.ValueChanged += new EventHandler(this.buytohpvalue_ValueChanged);
      this.buyto.AutoSize = true;
      this.buyto.Location = new System.Drawing.Point(6, 144);
      this.buyto.Name = "buyto";
      this.buyto.Size = new Size(58, 17);
      this.buyto.TabIndex = 2;
      this.buyto.TabStop = true;
      this.buyto.Text = "Buy to:";
      this.buyto.UseVisualStyleBackColor = true;
      this.ascendmp.AutoSize = true;
      this.ascendmp.Location = new System.Drawing.Point(6, 109);
      this.ascendmp.Name = "ascendmp";
      this.ascendmp.Size = new Size(86, 17);
      this.ascendmp.TabIndex = 1;
      this.ascendmp.TabStop = true;
      this.ascendmp.Text = "All into Mana";
      this.ascendmp.UseVisualStyleBackColor = true;
      this.ascendmp.CheckedChanged += new EventHandler(this.ascendmp_CheckedChanged);
      this.ascendhp.AutoSize = true;
      this.ascendhp.Location = new System.Drawing.Point(6, 86);
      this.ascendhp.Name = "ascendhp";
      this.ascendhp.Size = new Size(90, 17);
      this.ascendhp.TabIndex = 0;
      this.ascendhp.TabStop = true;
      this.ascendhp.Text = "All into Health";
      this.ascendhp.UseVisualStyleBackColor = true;
      this.ascendhp.CheckedChanged += new EventHandler(this.ascendhp_CheckedChanged);
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(407, 316);
      this.label1.Name = "label1";
      this.label1.Size = new Size(101, 13);
      this.label1.TabIndex = 11;
      this.label1.Text = "Current EXP Boxed:";
      this.currentexpboxed.AutoSize = true;
      this.currentexpboxed.Location = new System.Drawing.Point(411, 329);
      this.currentexpboxed.Name = "currentexpboxed";
      this.currentexpboxed.Size = new Size(13, 13);
      this.currentexpboxed.TabIndex = 12;
      this.currentexpboxed.Text = "0";
      this.powermonk.AutoSize = true;
      this.powermonk.Location = new System.Drawing.Point(233, 169);
      this.powermonk.Name = "powermonk";
      this.powermonk.Size = new Size(102, 17);
      this.powermonk.TabIndex = 29;
      this.powermonk.Text = "POWER MONK";
      this.powermonk.UseVisualStyleBackColor = true;
      this.powermonk.CheckedChanged += new EventHandler(this.powermonk_CheckedChanged);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(575, 391);
      this.Controls.Add((Control) this.currentexpboxed);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.groupBox49);
      this.Controls.Add((Control) this.groupBox23);
      this.Name =  "AscendOptions";
      this.Text =  "AscendOptions";
      this.FormClosing += new FormClosingEventHandler(this.AscendOptions_FormClosing);
      this.groupBox49.ResumeLayout(false);
      this.groupBox49.PerformLayout();
      this.buynum.EndInit();
      this.groupBox51.ResumeLayout(false);
      this.groupBox51.PerformLayout();
      this.groupBox50.ResumeLayout(false);
      this.groupBox50.PerformLayout();
      this.groupBox23.ResumeLayout(false);
      this.groupBox23.PerformLayout();
      this.buytompvalue.EndInit();
      this.buytohpvalue.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
