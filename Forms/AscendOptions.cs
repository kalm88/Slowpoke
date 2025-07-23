

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
    public bool vsuchairascend;
    public bool vascendhp;
    public bool vascendmp;
    public bool vbuystatsbtn;
    public bool vwithdrawhem = true;
    public bool vwithdrawwine = true;
    private IContainer components;
    private GroupBox groupBoxBuyStats;
    public CheckBox withdrawwine;
    public CheckBox withdrawhem;
    public TextBox killername;
    private Label killerlabel;
    public TextBox rescuername;
    private Label rescuerlabel;
    public Button fillDex;
    public Button fillCon;
    public Button fillWis;
    public Button fillInt;
    public Button fillStr;
    public Label xStatYstatLabel;
    public Label xpNeededLabel;
    public Button buystatsbtn;
    public NumericUpDown buynum;
    private Label statsPerAscendLabel;
    public Label numstatl;
    private GroupBox currStatGroupBox;
    public Label currDex;
    public Label currCon;
    public Label currWis;
    public Label currInt;
    public Label currStr;
    private GroupBox statInputGroupBox;
    private Label currStrabel;
    public TextBox dext;
    private Label currIntabel;
    public TextBox cont;
    private Label currWisabel;
    public TextBox wist;
    private Label currConabel;
    public TextBox intt;
    private Label currDexabel;
    public TextBox strt;
    private GroupBox groupBoxAscend;
    public Button ascendbutton;
    private Label MPLabel;
    public RadioButton ascendmp;
    public RadioButton ascendhp;
    private Label currXPBoxLabel;
    public Label currentexpboxed;
    public CheckBox instantascend;
    public CheckBox suchairascend;
    private Label maxHPLabel;
    private Label maxMPLabel;
    public Label currentbasehp;
    public Label currentbasemp;
    private Label HPLabel;
    private Label buyToLabel;
    private Label expReqLabel;
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
    private void suchairascend_CheckChanged(object sender, EventArgs e) => this.vsuchairascend = this.suchairascend.Checked;

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
      int strength = 0;
      int intelligence = 0;
      int wisdom = 0;
      int constitution = 0;
      int dexterity = 0;
      if (this.strt.Text != string.Empty)
        strength = int.Parse(this.strt.Text);
      if (this.intt.Text != string.Empty)
        intelligence = int.Parse(this.intt.Text);
      if (this.wist.Text != string.Empty)
        wisdom = int.Parse(this.wist.Text);
      if (this.cont.Text != string.Empty)
        constitution = int.Parse(this.cont.Text);
      if (this.dext.Text != string.Empty)
        dexterity = int.Parse(this.dext.Text);
      if ((this.strt.Text == string.Empty || strength == 0) && (this.intt.Text == string.Empty || intelligence == 0) && (this.wist.Text == string.Empty || wisdom == 0) && (this.cont.Text == string.Empty || constitution == 0) && (this.dext.Text == string.Empty || dexterity == 0))
      {
        this.Client.SendMessage("Set amount of stats first.");
        return true;
      }
      if ((long) (this.Client.Statistics.Str + strength) > (long) this.Client.pathstr)
      {
        this.Client.SendMessage("Str cannot exceed " + this.Client.pathstr.ToString());
        return true;
      }
      if ((long) (this.Client.Statistics.Int + intelligence) > (long) this.Client.pathint)
      {
        this.Client.SendMessage("Int cannot exceed " + this.Client.pathint.ToString());
        return true;
      }
      if ((long) (this.Client.Statistics.Wis + wisdom) > (long) this.Client.pathwis)
      {
        this.Client.SendMessage("Wis cannot exceed " + this.Client.pathwis.ToString());
        return true;
      }
      if ((long) (this.Client.Statistics.Con + constitution) > (long) this.Client.pathcon)
      {
        this.Client.SendMessage("Con cannot exceed " + this.Client.pathcon.ToString());
        return true;
      }
      if ((long) (this.Client.Statistics.Dex + dexterity) > (long) this.Client.pathdex)
      {
        this.Client.SendMessage("Dex cannot exceed " + this.Client.pathdex.ToString());
        return true;
      }
      if (!(this.rescuername.Text == string.Empty)) // && !(this.killername.Text == string.Empty) maybe
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
        this.xpNeededLabel.Text = "0 Exp needed for";
        this.xStatYstatLabel.Text = num6.ToString() + " stats at " + this.buynum.Value.ToString() + " stats per ascension.";
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
        this.xpNeededLabel.Text = ((long) num15 + (long) num14).ToString("#,##0") + " Exp needed for";
        this.xStatYstatLabel.Text = num13.ToString() + " stats at " + this.buynum.Value.ToString() + " stats per ascension.";
      }
      double num19 = Math.Floor(num12 * (double) this.buynum.Value) + Math.Floor(d) - (double) num6;
      this.currStr.Text = (this.Client.Statistics.Str + num1).ToString();
      this.currInt.Text = (this.Client.Statistics.Int + num2).ToString();
      this.currWis.Text = (this.Client.Statistics.Wis + num3).ToString();
      this.currCon.Text = (this.Client.Statistics.Con + num4).ToString();
      this.currDex.Text = (this.Client.Statistics.Dex + num5).ToString();
      if ((long) int.Parse(this.currStr.Text) > (long) this.Client.pathstr)
        this.currStr.ForeColor = Color.Red;
      else
        this.currStr.ForeColor = Color.Black;
      if ((long) int.Parse(this.currInt.Text) > (long) this.Client.pathint)
        this.currInt.ForeColor = Color.Red;
      else
        this.currInt.ForeColor = Color.Black;
      if ((long) int.Parse(this.currWis.Text) > (long) this.Client.pathwis)
        this.currWis.ForeColor = Color.Red;
      else
        this.currWis.ForeColor = Color.Black;
      if ((long) int.Parse(this.currCon.Text) > (long) this.Client.pathcon)
        this.currCon.ForeColor = Color.Red;
      else
        this.currCon.ForeColor = Color.Black;
      if ((long) int.Parse(this.currDex.Text) > (long) this.Client.pathdex)
        this.currDex.ForeColor = Color.Red;
      else
        this.currDex.ForeColor = Color.Black;
      this.numstatl.Text = "# of stats available: " + num19.ToString();
      if (num19 > 0.0)
        this.numstatl.ForeColor = Color.Blue;
      else
        this.numstatl.ForeColor = Color.Black;
    }

    private void maxstr_Click(object sender, EventArgs e)
    {
      int strength = 0;
      if (this.strt.Text != string.Empty)
        strength = int.Parse(this.strt.Text);
      this.strt.Text = (strength + (int) this.Client.pathstr - int.Parse(this.currStr.Text)).ToString();
    }

    private void maxint_Click(object sender, EventArgs e)
    {
      int intelligence = 0;
      if (this.intt.Text != string.Empty)
        intelligence = int.Parse(this.intt.Text);
      this.intt.Text = (intelligence + (int) this.Client.pathint - int.Parse(this.currInt.Text)).ToString();
    }

    private void maxwis_Click(object sender, EventArgs e)
    {
      int wisdom = 0;
      if (this.wist.Text != string.Empty)
        wisdom = int.Parse(this.wist.Text);
      this.wist.Text = (wisdom + (int) this.Client.pathwis - int.Parse(this.currWis.Text)).ToString();
    }

    private void maxcon_Click(object sender, EventArgs e)
    {
      int constitution = 0;
      if (this.cont.Text != string.Empty)
        constitution = int.Parse(this.cont.Text);
      this.cont.Text = (constitution + (int) this.Client.pathcon - int.Parse(this.currCon.Text)).ToString();
    }

    private void maxdex_Click(object sender, EventArgs e)
    {
      int dexterity = 0;
      if (this.dext.Text != string.Empty)
        dexterity = int.Parse(this.dext.Text);
      this.dext.Text = (dexterity + (int) this.Client.pathdex - int.Parse(this.currDex.Text)).ToString();
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
            this.groupBoxBuyStats = new System.Windows.Forms.GroupBox();
            this.powermonk = new System.Windows.Forms.CheckBox();
            this.withdrawwine = new System.Windows.Forms.CheckBox();
            this.withdrawhem = new System.Windows.Forms.CheckBox();
            this.killername = new System.Windows.Forms.TextBox();
            this.killerlabel = new System.Windows.Forms.Label();
            this.rescuername = new System.Windows.Forms.TextBox();
            this.rescuerlabel = new System.Windows.Forms.Label();
            this.fillDex = new System.Windows.Forms.Button();
            this.fillCon = new System.Windows.Forms.Button();
            this.fillWis = new System.Windows.Forms.Button();
            this.fillInt = new System.Windows.Forms.Button();
            this.fillStr = new System.Windows.Forms.Button();
            this.xStatYstatLabel = new System.Windows.Forms.Label();
            this.xpNeededLabel = new System.Windows.Forms.Label();
            this.buystatsbtn = new System.Windows.Forms.Button();
            this.buynum = new System.Windows.Forms.NumericUpDown();
            this.statsPerAscendLabel = new System.Windows.Forms.Label();
            this.numstatl = new System.Windows.Forms.Label();
            this.currStatGroupBox = new System.Windows.Forms.GroupBox();
            this.currDex = new System.Windows.Forms.Label();
            this.currCon = new System.Windows.Forms.Label();
            this.currWis = new System.Windows.Forms.Label();
            this.currInt = new System.Windows.Forms.Label();
            this.currStr = new System.Windows.Forms.Label();
            this.statInputGroupBox = new System.Windows.Forms.GroupBox();
            this.currStrabel = new System.Windows.Forms.Label();
            this.dext = new System.Windows.Forms.TextBox();
            this.currIntabel = new System.Windows.Forms.Label();
            this.cont = new System.Windows.Forms.TextBox();
            this.currWisabel = new System.Windows.Forms.Label();
            this.wist = new System.Windows.Forms.TextBox();
            this.currConabel = new System.Windows.Forms.Label();
            this.intt = new System.Windows.Forms.TextBox();
            this.currDexabel = new System.Windows.Forms.Label();
            this.strt = new System.Windows.Forms.TextBox();
            this.groupBoxAscend = new System.Windows.Forms.GroupBox();
            this.currentbasemp = new System.Windows.Forms.Label();
            this.buytoexpreqlab = new System.Windows.Forms.Label();
            this.currentbasehp = new System.Windows.Forms.Label();
            this.expReqLabel = new System.Windows.Forms.Label();
            this.maxMPLabel = new System.Windows.Forms.Label();
            this.buyToLabel = new System.Windows.Forms.Label();
            this.maxHPLabel = new System.Windows.Forms.Label();
            this.HPLabel = new System.Windows.Forms.Label();
            this.instantascend = new System.Windows.Forms.CheckBox();
            this.suchairascend = new System.Windows.Forms.CheckBox();
            this.ascendbutton = new System.Windows.Forms.Button();
            this.MPLabel = new System.Windows.Forms.Label();
            this.buytompvalue = new System.Windows.Forms.NumericUpDown();
            this.buytohpvalue = new System.Windows.Forms.NumericUpDown();
            this.buyto = new System.Windows.Forms.RadioButton();
            this.ascendmp = new System.Windows.Forms.RadioButton();
            this.ascendhp = new System.Windows.Forms.RadioButton();
            this.currXPBoxLabel = new System.Windows.Forms.Label();
            this.currentexpboxed = new System.Windows.Forms.Label();
            this.groupBoxBuyStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buynum)).BeginInit();
            this.currStatGroupBox.SuspendLayout();
            this.statInputGroupBox.SuspendLayout();
            this.groupBoxAscend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buytompvalue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buytohpvalue)).BeginInit();
            this.SuspendLayout();

            /* groupBoxBuyStats */
            this.groupBoxBuyStats.Controls.Add(this.powermonk);
            this.groupBoxBuyStats.Controls.Add(this.withdrawwine);
            this.groupBoxBuyStats.Controls.Add(this.withdrawhem);
            this.groupBoxBuyStats.Controls.Add(this.killername);
            this.groupBoxBuyStats.Controls.Add(this.killerlabel);
            this.groupBoxBuyStats.Controls.Add(this.rescuername);
            this.groupBoxBuyStats.Controls.Add(this.rescuerlabel);
            this.groupBoxBuyStats.Controls.Add(this.fillDex);
            this.groupBoxBuyStats.Controls.Add(this.fillCon);
            this.groupBoxBuyStats.Controls.Add(this.fillWis);
            this.groupBoxBuyStats.Controls.Add(this.fillInt);
            this.groupBoxBuyStats.Controls.Add(this.fillStr);
            this.groupBoxBuyStats.Controls.Add(this.xStatYstatLabel);
            this.groupBoxBuyStats.Controls.Add(this.xpNeededLabel);
            this.groupBoxBuyStats.Controls.Add(this.buystatsbtn);
            this.groupBoxBuyStats.Controls.Add(this.buynum);
            this.groupBoxBuyStats.Controls.Add(this.statsPerAscendLabel);
            this.groupBoxBuyStats.Controls.Add(this.numstatl);
            this.groupBoxBuyStats.Controls.Add(this.currStatGroupBox);
            this.groupBoxBuyStats.Controls.Add(this.statInputGroupBox);
            this.groupBoxBuyStats.Location = new System.Drawing.Point(12, 12);
            this.groupBoxBuyStats.Name = "groupBoxBuyStats";
            this.groupBoxBuyStats.Size = new System.Drawing.Size(343, 369);
            this.groupBoxBuyStats.TabIndex = 10;
            this.groupBoxBuyStats.TabStop = false;
            this.groupBoxBuyStats.Text = "Buy Stats";

            /* powermonk */
            this.powermonk.AutoSize = true;
            this.powermonk.Location = new System.Drawing.Point(233, 177);
            this.powermonk.Name = "powermonk";
            this.powermonk.Size = new System.Drawing.Size(102, 17);
            this.powermonk.TabIndex = 29;
            this.powermonk.Text = "POWER MONK";
            this.powermonk.UseVisualStyleBackColor = true;
            this.powermonk.CheckedChanged += new System.EventHandler(this.powermonk_CheckedChanged);

            /* withdrawwine */
            this.withdrawwine.AutoSize = true;
            this.withdrawwine.Checked = true;
            this.withdrawwine.CheckState = System.Windows.Forms.CheckState.Checked;
            this.withdrawwine.Location = new System.Drawing.Point(233, 144);
            this.withdrawwine.Name = "withdrawwine";
            this.withdrawwine.Size = new System.Drawing.Size(99, 17);
            this.withdrawwine.TabIndex = 28;
            this.withdrawwine.Text = "Withdraw Wine";
            this.withdrawwine.UseVisualStyleBackColor = true;
            this.withdrawwine.CheckedChanged += new System.EventHandler(this.withdrawwine_CheckedChanged);

            /* withdrawhem */
            this.withdrawhem.AutoSize = true;
            this.withdrawhem.Checked = true;
            this.withdrawhem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.withdrawhem.Location = new System.Drawing.Point(233, 119);
            this.withdrawhem.Name = "withdrawhem";
            this.withdrawhem.Size = new System.Drawing.Size(96, 17);
            this.withdrawhem.TabIndex = 27;
            this.withdrawhem.Text = "Withdraw Hem";
            this.withdrawhem.UseVisualStyleBackColor = true;
            this.withdrawhem.CheckedChanged += new System.EventHandler(this.withdrawhem_CheckedChanged);

            /* killername */
            this.killername.Location = new System.Drawing.Point(233, 42);
            this.killername.Name = "killername";
            this.killername.Size = new System.Drawing.Size(100, 20);
            this.killername.TabIndex = 25;

            /* killerlabel */
            this.killerlabel.AutoSize = true;
            this.killerlabel.Location = new System.Drawing.Point(249, 22);
            this.killerlabel.Name = "killerlabel";
            this.killerlabel.Size = new System.Drawing.Size(32, 13);
            this.killerlabel.TabIndex = 24;
            this.killerlabel.Text = "Killer:";

            /* rescuername */
            this.rescuername.Location = new System.Drawing.Point(233, 90);
            this.rescuername.Name = "rescuername";
            this.rescuername.Size = new System.Drawing.Size(100, 20);
            this.rescuername.TabIndex = 25;

            /* rescuerlabel */
            this.rescuerlabel.AutoSize = true;
            this.rescuerlabel.Location = new System.Drawing.Point(249, 70);
            this.rescuerlabel.Name = "rescuerlabel";
            this.rescuerlabel.Size = new System.Drawing.Size(50, 13);
            this.rescuerlabel.TabIndex = 24;
            this.rescuerlabel.Text = "Rescuer:";

            /* fillDex */
            this.fillDex.Location = new System.Drawing.Point(161, 149);
            this.fillDex.Name = "fillDex";
            this.fillDex.Size = new System.Drawing.Size(45, 23);
            this.fillDex.TabIndex = 23;
            this.fillDex.Text = "fill";
            this.fillDex.UseVisualStyleBackColor = true;
            this.fillDex.Click += new System.EventHandler(this.maxdex_Click);

            /* fillCon */
            this.fillCon.Location = new System.Drawing.Point(161, 121);
            this.fillCon.Name = "fillCon";
            this.fillCon.Size = new System.Drawing.Size(45, 23);
            this.fillCon.TabIndex = 22;
            this.fillCon.Text = "fill";
            this.fillCon.UseVisualStyleBackColor = true;
            this.fillCon.Click += new System.EventHandler(this.maxcon_Click);

            /* fillWis */
            this.fillWis.Location = new System.Drawing.Point(161, 93);
            this.fillWis.Name = "fillWis";
            this.fillWis.Size = new System.Drawing.Size(45, 23);
            this.fillWis.TabIndex = 21;
            this.fillWis.Text = "fill";
            this.fillWis.UseVisualStyleBackColor = true;
            this.fillWis.Click += new System.EventHandler(this.maxwis_Click);

            /* fillInt */
            this.fillInt.Location = new System.Drawing.Point(161, 65);
            this.fillInt.Name = "fillInt";
            this.fillInt.Size = new System.Drawing.Size(45, 23);
            this.fillInt.TabIndex = 20;
            this.fillInt.Text = "fill";
            this.fillInt.UseVisualStyleBackColor = true;
            this.fillInt.Click += new System.EventHandler(this.maxint_Click);

            /* fillStr */
            this.fillStr.Location = new System.Drawing.Point(161, 39);
            this.fillStr.Name = "fillStr";
            this.fillStr.Size = new System.Drawing.Size(45, 23);
            this.fillStr.TabIndex = 19;
            this.fillStr.Text = "fill";
            this.fillStr.UseVisualStyleBackColor = true;
            this.fillStr.Click += new System.EventHandler(this.maxstr_Click);

            /* xStatYstatLabel */
            this.xStatYstatLabel.AutoSize = true;
            this.xStatYstatLabel.Location = new System.Drawing.Point(6, 292);
            this.xStatYstatLabel.Name = "xStatYstatLabel";
            this.xStatYstatLabel.Size = new System.Drawing.Size(156, 13);
            this.xStatYstatLabel.TabIndex = 18;
            this.xStatYstatLabel.Text = "0 stats at 0 stats per ascension.";

            /* xpNeededLabel */
            this.xpNeededLabel.AutoSize = true;
            this.xpNeededLabel.Location = new System.Drawing.Point(6, 268);
            this.xpNeededLabel.Name = "xpNeededLabel";
            this.xpNeededLabel.Size = new System.Drawing.Size(88, 13);
            this.xpNeededLabel.TabIndex = 17;
            this.xpNeededLabel.Text = "0 Exp needed for";

            /* buystatsbtn */
            this.buystatsbtn.Location = new System.Drawing.Point(224, 316);
            this.buystatsbtn.Name = "buystatsbtn";
            this.buystatsbtn.Size = new System.Drawing.Size(95, 36);
            this.buystatsbtn.TabIndex = 16;
            this.buystatsbtn.Text = "Start";
            this.buystatsbtn.UseVisualStyleBackColor = true;
            this.buystatsbtn.TextChanged += new System.EventHandler(this.buystatsbtn_TextChanged);
            this.buystatsbtn.Click += new System.EventHandler(this.buystatsbtn_Click);

            /* buynum */
            this.buynum.Location = new System.Drawing.Point(172, 231);
            this.buynum.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.buynum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.buynum.Name = "buynum";
            this.buynum.Size = new System.Drawing.Size(34, 20);
            this.buynum.TabIndex = 15;
            this.buynum.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.buynum.ValueChanged += new System.EventHandler(this.buynum_ValueChanged);

            /* statsPerAscendLabel */
            this.statsPerAscendLabel.AutoSize = true;
            this.statsPerAscendLabel.Location = new System.Drawing.Point(6, 233);
            this.statsPerAscendLabel.Name = "statsPerAscendLabel";
            this.statsPerAscendLabel.Size = new System.Drawing.Size(142, 13);
            this.statsPerAscendLabel.TabIndex = 14;
            this.statsPerAscendLabel.Text = "# of stats to buy per ascend:";

            /* numstatl */
            this.numstatl.AutoSize = true;
            this.numstatl.Location = new System.Drawing.Point(6, 199);
            this.numstatl.Name = "numstatl";
            this.numstatl.Size = new System.Drawing.Size(99, 13);
            this.numstatl.TabIndex = 12;
            this.numstatl.Text = "# of stats available:";

            /* currStatGroupBox */
            this.currStatGroupBox.Controls.Add(this.currDex);
            this.currStatGroupBox.Controls.Add(this.currCon);
            this.currStatGroupBox.Controls.Add(this.currWis);
            this.currStatGroupBox.Controls.Add(this.currInt);
            this.currStatGroupBox.Controls.Add(this.currStr);
            this.currStatGroupBox.Location = new System.Drawing.Point(106, 20);
            this.currStatGroupBox.Name = "currStatGroupBox";
            this.currStatGroupBox.Size = new System.Drawing.Size(49, 161);
            this.currStatGroupBox.TabIndex = 11;
            this.currStatGroupBox.TabStop = false;

            /* currDex */
            this.currDex.AutoSize = true;
            this.currDex.Location = new System.Drawing.Point(15, 133);
            this.currDex.Name = "currDex";
            this.currDex.Size = new System.Drawing.Size(13, 13);
            this.currDex.TabIndex = 4;
            this.currDex.Text = "0";

            /* currCon */
            this.currCon.AutoSize = true;
            this.currCon.Location = new System.Drawing.Point(15, 105);
            this.currCon.Name = "currCon";
            this.currCon.Size = new System.Drawing.Size(13, 13);
            this.currCon.TabIndex = 3;
            this.currCon.Text = "0";

            /* currWis */
            this.currWis.AutoSize = true;
            this.currWis.Location = new System.Drawing.Point(15, 77);
            this.currWis.Name = "currWis";
            this.currWis.Size = new System.Drawing.Size(13, 13);
            this.currWis.TabIndex = 2;
            this.currWis.Text = "0";

            /* currInt */
            this.currInt.AutoSize = true;
            this.currInt.Location = new System.Drawing.Point(15, 49);
            this.currInt.Name = "currInt";
            this.currInt.Size = new System.Drawing.Size(13, 13);
            this.currInt.TabIndex = 1;
            this.currInt.Text = "0";

            /* currStr */
            this.currStr.AutoSize = true;
            this.currStr.Location = new System.Drawing.Point(15, 23);
            this.currStr.Name = "currStr";
            this.currStr.Size = new System.Drawing.Size(13, 13);
            this.currStr.TabIndex = 0;
            this.currStr.Text = "0";

            /* statInputGroupBox */
            this.statInputGroupBox.Controls.Add(this.currStrabel);
            this.statInputGroupBox.Controls.Add(this.dext);
            this.statInputGroupBox.Controls.Add(this.currIntabel);
            this.statInputGroupBox.Controls.Add(this.cont);
            this.statInputGroupBox.Controls.Add(this.currWisabel);
            this.statInputGroupBox.Controls.Add(this.wist);
            this.statInputGroupBox.Controls.Add(this.currConabel);
            this.statInputGroupBox.Controls.Add(this.intt);
            this.statInputGroupBox.Controls.Add(this.currDexabel);
            this.statInputGroupBox.Controls.Add(this.strt);
            this.statInputGroupBox.Location = new System.Drawing.Point(6, 20);
            this.statInputGroupBox.Name = "statInputGroupBox";
            this.statInputGroupBox.Size = new System.Drawing.Size(94, 161);
            this.statInputGroupBox.TabIndex = 10;
            this.statInputGroupBox.TabStop = false;

            /* currStrabel */
            this.currStrabel.AutoSize = true;
            this.currStrabel.Location = new System.Drawing.Point(6, 23);
            this.currStrabel.Name = "currStrabel";
            this.currStrabel.Size = new System.Drawing.Size(32, 13);
            this.currStrabel.TabIndex = 0;
            this.currStrabel.Text = "STR:";

            /* strt value */
            this.strt.Location = new System.Drawing.Point(46, 20);
            this.strt.MaxLength = 3;
            this.strt.Name = "strt";
            this.strt.Size = new System.Drawing.Size(38, 20);
            this.strt.TabIndex = 5;
            this.strt.TextChanged += new System.EventHandler(this.strt_TextChanged);
            this.strt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.strt_KeyPress);

            /* currIntabel */
            this.currIntabel.AutoSize = true;
            this.currIntabel.Location = new System.Drawing.Point(6, 49);
            this.currIntabel.Name = "currIntabel";
            this.currIntabel.Size = new System.Drawing.Size(28, 13);
            this.currIntabel.TabIndex = 1;
            this.currIntabel.Text = "INT:";

            /* intt value */
            this.intt.Location = new System.Drawing.Point(46, 46);
            this.intt.MaxLength = 5;
            this.intt.Name = "intt";
            this.intt.Size = new System.Drawing.Size(38, 20);
            this.intt.TabIndex = 6;
            this.intt.TextChanged += new System.EventHandler(this.strt_TextChanged);
            this.intt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.strt_KeyPress);

            /* currWisabel */
            this.currWisabel.AutoSize = true;
            this.currWisabel.Location = new System.Drawing.Point(6, 77);
            this.currWisabel.Name = "currWisabel";
            this.currWisabel.Size = new System.Drawing.Size(31, 13);
            this.currWisabel.TabIndex = 2;
            this.currWisabel.Text = "WIS:";

            /* wist value */
            this.wist.Location = new System.Drawing.Point(46, 74);
            this.wist.MaxLength = 5;
            this.wist.Name = "wist";
            this.wist.Size = new System.Drawing.Size(38, 20);
            this.wist.TabIndex = 7;
            this.wist.TextChanged += new System.EventHandler(this.strt_TextChanged);
            this.wist.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.strt_KeyPress);

            /* currConabel */
            this.currConabel.AutoSize = true;
            this.currConabel.Location = new System.Drawing.Point(6, 105);
            this.currConabel.Name = "currConabel";
            this.currConabel.Size = new System.Drawing.Size(33, 13);
            this.currConabel.TabIndex = 3;
            this.currConabel.Text = "CON:";

            /* cont value */
            this.cont.Location = new System.Drawing.Point(46, 102);
            this.cont.MaxLength = 5;
            this.cont.Name = "cont";
            this.cont.Size = new System.Drawing.Size(38, 20);
            this.cont.TabIndex = 8;
            this.cont.TextChanged += new System.EventHandler(this.strt_TextChanged);
            this.cont.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.strt_KeyPress);

            /* currDexabel */
            this.currDexabel.AutoSize = true;
            this.currDexabel.Location = new System.Drawing.Point(6, 133);
            this.currDexabel.Name = "currDexabel";
            this.currDexabel.Size = new System.Drawing.Size(32, 13);
            this.currDexabel.TabIndex = 4;
            this.currDexabel.Text = "DEX:";

            /* dext value */
            this.dext.Location = new System.Drawing.Point(46, 130);
            this.dext.MaxLength = 5;
            this.dext.Name = "dext";
            this.dext.Size = new System.Drawing.Size(38, 20);
            this.dext.TabIndex = 9;
            this.dext.TextChanged += new System.EventHandler(this.strt_TextChanged);
            this.dext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.strt_KeyPress);

            /* groupBoxAscend */
            this.groupBoxAscend.Controls.Add(this.currentbasemp);
            this.groupBoxAscend.Controls.Add(this.buytoexpreqlab);
            this.groupBoxAscend.Controls.Add(this.currentbasehp);
            this.groupBoxAscend.Controls.Add(this.expReqLabel);
            this.groupBoxAscend.Controls.Add(this.maxMPLabel);
            this.groupBoxAscend.Controls.Add(this.buyToLabel);
            this.groupBoxAscend.Controls.Add(this.maxHPLabel);
            this.groupBoxAscend.Controls.Add(this.HPLabel);
            this.groupBoxAscend.Controls.Add(this.instantascend);
            this.groupBoxAscend.Controls.Add(this.suchairascend);
            this.groupBoxAscend.Controls.Add(this.ascendbutton);
            this.groupBoxAscend.Controls.Add(this.MPLabel);
            this.groupBoxAscend.Controls.Add(this.buytompvalue);
            this.groupBoxAscend.Controls.Add(this.buytohpvalue);
            this.groupBoxAscend.Controls.Add(this.buyto);
            this.groupBoxAscend.Controls.Add(this.ascendmp);
            this.groupBoxAscend.Controls.Add(this.ascendhp);
            this.groupBoxAscend.Location = new System.Drawing.Point(376, 12);
            this.groupBoxAscend.Name = "groupBoxAscend";
            this.groupBoxAscend.Size = new System.Drawing.Size(183, 269);
            this.groupBoxAscend.TabIndex = 9;
            this.groupBoxAscend.TabStop = false;
            this.groupBoxAscend.Text = "Ascend";

            /* currentbasemp */
            this.currentbasemp.AutoSize = true;
            this.currentbasemp.Location = new System.Drawing.Point(62, 243);
            this.currentbasemp.Name = "currentbasemp";
            this.currentbasemp.Size = new System.Drawing.Size(13, 13);
            this.currentbasemp.TabIndex = 16;
            this.currentbasemp.Text = "0";

            /* buytoexpreqlab */
            this.buytoexpreqlab.AutoSize = true;
            this.buytoexpreqlab.Location = new System.Drawing.Point(62, 199);
            this.buytoexpreqlab.Name = "buytoexpreqlab";
            this.buytoexpreqlab.Size = new System.Drawing.Size(13, 13);
            this.buytoexpreqlab.TabIndex = 17;
            this.buytoexpreqlab.Text = "0";

            /* currentbasehp */
            this.currentbasehp.AutoSize = true;
            this.currentbasehp.Location = new System.Drawing.Point(62, 220);
            this.currentbasehp.Name = "currentbasehp";
            this.currentbasehp.Size = new System.Drawing.Size(13, 13);
            this.currentbasehp.TabIndex = 15;
            this.currentbasehp.Text = "0";

            /* expReqLabel */
            this.expReqLabel.AutoSize = true;
            this.expReqLabel.Location = new System.Drawing.Point(8, 199);
            this.expReqLabel.Name = "expReqLabel";
            this.expReqLabel.Size = new System.Drawing.Size(46, 13);
            this.expReqLabel.TabIndex = 16;
            this.expReqLabel.Text = "Exp req:";

            /* maxMPLabel */
            this.maxMPLabel.AutoSize = true;
            this.maxMPLabel.Location = new System.Drawing.Point(8, 243);
            this.maxMPLabel.Name = "maxMPLabel";
            this.maxMPLabel.Size = new System.Drawing.Size(49, 13);
            this.maxMPLabel.TabIndex = 14;
            this.maxMPLabel.Text = "Max MP:";

            /* buyToLabel */
            this.buyToLabel.AutoSize = true;
            this.buyToLabel.Location = new System.Drawing.Point(8, 164);
            this.buyToLabel.Name = "buyToLabel";
            this.buyToLabel.Size = new System.Drawing.Size(60, 26);
            this.buyToLabel.TabIndex = 15;
            this.buyToLabel.Text = "(full disrobe\r\nsuggested)";

            /* maxHPLabel */
            this.maxHPLabel.AutoSize = true;
            this.maxHPLabel.Location = new System.Drawing.Point(8, 220);
            this.maxHPLabel.Name = "maxHPLabel";
            this.maxHPLabel.Size = new System.Drawing.Size(48, 13);
            this.maxHPLabel.TabIndex = 13;
            this.maxHPLabel.Text = "Max HP:";

            /* HPLabel */
            this.HPLabel.AutoSize = true;
            this.HPLabel.Location = new System.Drawing.Point(73, 144);
            this.HPLabel.Name = "HPLabel";
            this.HPLabel.Size = new System.Drawing.Size(25, 13);
            this.HPLabel.TabIndex = 14;
            this.HPLabel.Text = "HP:";

            /* instantascend */
            this.instantascend.AutoSize = true;
            this.instantascend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instantascend.Location = new System.Drawing.Point(6, 73);
            this.instantascend.Name = "instantascend";
            this.instantascend.Size = new System.Drawing.Size(111, 17);
            this.instantascend.TabIndex = 13;
            this.instantascend.Text = "Instant Ascend";
            this.instantascend.UseVisualStyleBackColor = true;

            /* suchairascend */
            this.suchairascend.AutoSize = true;
            this.suchairascend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suchairascend.Location = new System.Drawing.Point(6, 50);
            this.suchairascend.Name = "suchairascend";
            this.suchairascend.Size = new System.Drawing.Size(101, 17);
            this.suchairascend.TabIndex = 13;
            this.suchairascend.Text = "Use Suc Hair";
            this.suchairascend.UseVisualStyleBackColor = true;
            this.suchairascend.CheckedChanged += new System.EventHandler(this.suchairascend_CheckChanged);

            /* ascendbutton */
            this.ascendbutton.Location = new System.Drawing.Point(38, 20);
            this.ascendbutton.Name = "ascendbutton";
            this.ascendbutton.Size = new System.Drawing.Size(94, 27);
            this.ascendbutton.TabIndex = 6;
            this.ascendbutton.Text = "Start";
            this.ascendbutton.UseVisualStyleBackColor = true;
            this.ascendbutton.TextChanged += new System.EventHandler(this.ascendbutton_TextChanged);
            this.ascendbutton.Click += new System.EventHandler(this.ascendbutton_Click);

            /* MPLabel */
            this.MPLabel.AutoSize = true;
            this.MPLabel.Location = new System.Drawing.Point(73, 170);
            this.MPLabel.Name = "MPLabel";
            this.MPLabel.Size = new System.Drawing.Size(26, 13);
            this.MPLabel.TabIndex = 5;
            this.MPLabel.Text = "MP:";

            /* buytompvalue */
            this.buytompvalue.Increment = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.buytompvalue.Location = new System.Drawing.Point(102, 168);
            this.buytompvalue.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.buytompvalue.Name = "buytompvalue";
            this.buytompvalue.Size = new System.Drawing.Size(65, 20);
            this.buytompvalue.TabIndex = 4;
            this.buytompvalue.ValueChanged += new System.EventHandler(this.buytohpvalue_ValueChanged);

            /* buytohpvalue */
            this.buytohpvalue.Increment = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.buytohpvalue.Location = new System.Drawing.Point(102, 142);
            this.buytohpvalue.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.buytohpvalue.Name = "buytohpvalue";
            this.buytohpvalue.Size = new System.Drawing.Size(65, 20);
            this.buytohpvalue.TabIndex = 3;
            this.buytohpvalue.ValueChanged += new System.EventHandler(this.buytohpvalue_ValueChanged);

            /* buyto */
            this.buyto.AutoSize = true;
            this.buyto.Location = new System.Drawing.Point(6, 144);
            this.buyto.Name = "buyto";
            this.buyto.Size = new System.Drawing.Size(58, 17);
            this.buyto.TabIndex = 2;
            this.buyto.TabStop = true;
            this.buyto.Text = "Buy to:";
            this.buyto.UseVisualStyleBackColor = true;

            /* ascendmp */
            this.ascendmp.AutoSize = true;
            this.ascendmp.Location = new System.Drawing.Point(6, 118);
            this.ascendmp.Name = "ascendmp";
            this.ascendmp.Size = new System.Drawing.Size(86, 17);
            this.ascendmp.TabIndex = 1;
            this.ascendmp.TabStop = true;
            this.ascendmp.Text = "All into Mana";
            this.ascendmp.UseVisualStyleBackColor = true;
            this.ascendmp.CheckedChanged += new System.EventHandler(this.ascendmp_CheckedChanged);

            /* ascendhp */
            this.ascendhp.AutoSize = true;
            this.ascendhp.Location = new System.Drawing.Point(6, 95);
            this.ascendhp.Name = "ascendhp";
            this.ascendhp.Size = new System.Drawing.Size(90, 17);
            this.ascendhp.TabIndex = 0;
            this.ascendhp.TabStop = true;
            this.ascendhp.Text = "All into Health";
            this.ascendhp.UseVisualStyleBackColor = true;
            this.ascendhp.CheckedChanged += new System.EventHandler(this.ascendhp_CheckedChanged);

            /* currXPBoxLabel label */
            this.currXPBoxLabel.AutoSize = true;
            this.currXPBoxLabel.Location = new System.Drawing.Point(407, 316);
            this.currXPBoxLabel.Name = "currXPBoxLabel";
            this.currXPBoxLabel.Size = new System.Drawing.Size(101, 13);
            this.currXPBoxLabel.TabIndex = 11;
            this.currXPBoxLabel.Text = "Current EXP Boxed:";

            /* currentexpboxed value */
            this.currentexpboxed.AutoSize = true;
            this.currentexpboxed.Location = new System.Drawing.Point(411, 329);
            this.currentexpboxed.Name = "currentexpboxed";
            this.currentexpboxed.Size = new System.Drawing.Size(13, 13);
            this.currentexpboxed.TabIndex = 12;
            this.currentexpboxed.Text = "0";

            /* AscendOptions */
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 391);
            this.Controls.Add(this.currentexpboxed);
            this.Controls.Add(this.currXPBoxLabel);
            this.Controls.Add(this.groupBoxBuyStats);
            this.Controls.Add(this.groupBoxAscend);
            this.Name = "AscendOptions";
            this.Text = "AscendOptions";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AscendOptions_FormClosing);
            this.groupBoxBuyStats.ResumeLayout(false);
            this.groupBoxBuyStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buynum)).EndInit();
            this.currStatGroupBox.ResumeLayout(false);
            this.currStatGroupBox.PerformLayout();
            this.statInputGroupBox.ResumeLayout(false);
            this.statInputGroupBox.PerformLayout();
            this.groupBoxAscend.ResumeLayout(false);
            this.groupBoxAscend.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buytompvalue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buytohpvalue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }
  }
}
