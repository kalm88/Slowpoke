//SlowPoke
// Type: Flintstones.targetPlayer
//SlowPoke
//SlowPoke
//SlowPoke

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Flintstones
{
  public class targetPlayer : TabPage
  {
    public bool Typeof;
    private IContainer components;
    public CheckBox iocplayer;
    public CheckBox creagneartplayer;
    public CheckBox aocursesplayer;
    public CheckBox aopuinseinplayer;
    public CheckBox aosuainplayer;
    public CheckBox armachdplayer;
    public CheckBox fasdeireasplayer;
    public CheckBox beannplayer;
    public CheckBox aiteplayer;
    private Label label1;
    private Button removetargetplayer;
    private Label label17;
    public NumericUpDown iocplayercond;
    public CheckBox fasplayer;
    public CheckBox beagcradhplayer;
    public Label status;
    public CheckBox dionplayer;
    public CheckBox regenplayer;
    public CheckBox caplayer;
    public CheckBox lyliacplayer;
    public TextBox lyliacplayercond;
    private Label label2;
    public ComboBox ioctype;
    public ComboBox fastype;
    public ComboBox aitetype;
    public TextBox playername;
    public TextBox vineyardcond;
    private Label label4;
    public CheckBox vineyard;
    public CheckBox mdclowmp;
    public TextBox mdclowmpNum;

    public ClientTab ClientTab { get; private set; }

    public targetPlayer(string title, ClientTab clienttab, bool type)
    {
      this.InitializeComponent();
      this.Text = title;
      this.ClientTab = clienttab;
      this.Typeof = type;
      this.playername.Text = title;
      if (this.Typeof)
      {
        this.status.Text = "You are logged in as this player.";
        this.status.ForeColor = Color.RoyalBlue;
        this.fasdeireasplayer.Enabled = true;
        this.label2.Text = "when Mp <";
        this.label4.Text = "when Mp <";
        this.lyliacplayercond.Text = "10000";
        this.vineyardcond.Text = "10000";
        this.mdclowmp.Visible = true;
        this.mdclowmpNum.Visible = true;
      }
      else
      {
        this.status.Text = "You are not logged in as this player.";
        this.status.ForeColor = SystemColors.WindowFrame;
        this.label2.Text = "delay in ms";
        this.label4.Text = "delay in ms";
        this.lyliacplayercond.Text = "5000";
        this.vineyardcond.Text = "5000";
        this.mdclowmp.Visible = false;
        this.mdclowmpNum.Visible = false;
      }
      this.ClientTab.spellTargets.TabPages.Add((TabPage) this);
      this.ClientTab.spellTargets.SelectedTab = (TabPage) this;
      this.BestAites();
      this.BestFases();
      this.BestIocs();
    }

    public void BestAites()
    {
      int num = 0;
      if (this.ClientTab.Client.YourAites.Contains("ard naomh aite"))
      {
        this.aitetype.Items.Add((object) "ard naomh aite");
        ++num;
      }
      if (this.ClientTab.Client.YourAites.Contains("mor naomh aite"))
      {
        this.aitetype.Items.Add((object) "mor naomh aite");
        ++num;
      }
      if (this.ClientTab.Client.YourAites.Contains("naomh aite"))
      {
        this.aitetype.Items.Add((object) "naomh aite");
        ++num;
      }
      if (this.ClientTab.Client.YourAites.Contains("beag naomh aite"))
      {
        this.aitetype.Items.Add((object) "beag naomh aite");
        ++num;
      }
      if (num > 0)
      {
        this.aitetype.SelectedIndex = 0;
      }
      else
      {
        this.aiteplayer.Checked = false;
        this.aiteplayer.Enabled = false;
        this.aitetype.Enabled = false;
      }
    }

    public void BestFases()
    {
      int num = 0;
      if (this.ClientTab.Client.YourFases.Contains("ard fas nadur"))
      {
        this.fastype.Items.Add((object) "ard fas nadur");
        ++num;
      }
      if (this.ClientTab.Client.YourFases.Contains("mor fas nadur"))
      {
        this.fastype.Items.Add((object) "mor fas nadur");
        ++num;
      }
      if (this.ClientTab.Client.YourFases.Contains("fas nadur"))
      {
        this.fastype.Items.Add((object) "fas nadur");
        ++num;
      }
      if (this.ClientTab.Client.YourFases.Contains("beag fas nadur"))
      {
        this.fastype.Items.Add((object) "beag fas nadur");
        ++num;
      }
      if (num > 0)
      {
        this.fastype.SelectedIndex = 0;
      }
      else
      {
        this.fasplayer.Checked = false;
        this.fasplayer.Enabled = false;
        this.fastype.Enabled = false;
      }
    }

    public void BestIocs()
    {
      int num = 0;
      if (this.ClientTab.Client.YourIocs.Contains("Spirit Essence"))
      {
        this.ioctype.Items.Add((object) "Spirit Essence");
        ++num;
      }
      if (this.ClientTab.Client.YourIocs.Contains("nuadhaich"))
      {
        this.ioctype.Items.Add((object) "nuadhaich");
        ++num;
      }
      if (this.ClientTab.Client.YourIocs.Contains("ard ioc"))
      {
        this.ioctype.Items.Add((object) "ard ioc");
        ++num;
      }
      if (this.ClientTab.Client.YourIocs.Contains("mor ioc"))
      {
        this.ioctype.Items.Add((object) "mor ioc");
        ++num;
      }
      if (this.ClientTab.Client.YourIocs.Contains("ioc"))
      {
        this.ioctype.Items.Add((object) "ioc");
        ++num;
      }
      if (this.ClientTab.Client.YourIocs.Contains("beag ioc"))
      {
        this.ioctype.Items.Add((object) "beag ioc");
        ++num;
      }
      if (num > 0)
      {
        this.ioctype.SelectedIndex = 0;
      }
      else
      {
        this.iocplayer.Checked = false;
        this.iocplayer.Enabled = false;
        this.ioctype.Enabled = false;
      }
    }

    private void playername_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
      {
        e.Handled = true;
      }
      else
      {
        if (e.KeyChar != '\r')
          return;
        this.ClientTab.spellTargets.Focus();
      }
    }

    private void playername_LostFocus(object sender, EventArgs e)
    {
      bool match = false;
      this.Text = this.playername.Text;
      this.ClientTab.Client.targetplayer.ForEach((Action<targetPlayer>) (player =>
      {
        if (player != this && player.Text.Equals(this.Text, StringComparison.OrdinalIgnoreCase))
        {
          match = true;
        }
        else
        {
          if (!this.Text.Equals(this.ClientTab.Client.Name, StringComparison.OrdinalIgnoreCase))
            return;
          match = true;
        }
      }));
      if (match)
      {
        this.Text = "--";
        this.status.Text = "This target already exists.";
        this.status.ForeColor = Color.Maroon;
      }
      else
        this.updatePlayerTargets();
    }

    public void updatePlayerTargets()
    {
      foreach (string key in Server.Alts.Keys)
      {
        if (this.Text.Equals(key, StringComparison.CurrentCultureIgnoreCase))
        {
          this.status.Text = "You are logged in as this player.";
          this.status.ForeColor = Color.RoyalBlue;
          if (!this.ClientTab.Client.alts.Contains((object) this.Text.ToLower()))
            this.ClientTab.Client.alts.Add((object) this.Text.ToLower());
          this.fasdeireasplayer.Enabled = true;
          this.label2.Text = "when Mp <";
          this.label4.Text = "when Mp <";
          this.mdclowmp.Visible = true;
          this.mdclowmpNum.Visible = true;
          return;
        }
      }
      this.status.Text = "You are not logged in as this player.";
      this.status.ForeColor = SystemColors.WindowFrame;
      if (this.ClientTab.Client.alts.Contains((object) this.Text.ToLower()))
        this.ClientTab.Client.alts.Remove((object) this.Text.ToLower());
      this.fasdeireasplayer.Enabled = false;
      this.label2.Text = "delay in ms";
      this.label4.Text = "delay in ms";
      this.mdclowmp.Visible = false;
      this.mdclowmpNum.Visible = false;
    }

    private void removetargetplayer_Click(object sender, EventArgs e)
    {
      --this.ClientTab.spellTargets.SelectedIndex;
      this.ClientTab.spellTargets.TabPages.Remove((TabPage) this);
      this.ClientTab.Client.targetplayer.Remove(this);
      this.ClientTab.Client.alts.Remove((object) this);
    }

    private void iocplayer_CheckedChanged(object sender, EventArgs e)
    {
      if (this.iocplayer.Checked)
        this.iocplayercond.Enabled = true;
      else
        this.iocplayercond.Enabled = false;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.iocplayer = new CheckBox();
      this.creagneartplayer = new CheckBox();
      this.aocursesplayer = new CheckBox();
      this.aopuinseinplayer = new CheckBox();
      this.aosuainplayer = new CheckBox();
      this.armachdplayer = new CheckBox();
      this.fasdeireasplayer = new CheckBox();
      this.beannplayer = new CheckBox();
      this.aiteplayer = new CheckBox();
      this.label1 = new Label();
      this.playername = new TextBox();
      this.removetargetplayer = new Button();
      this.status = new Label();
      this.iocplayercond = new NumericUpDown();
      this.label17 = new Label();
      this.fasplayer = new CheckBox();
      this.beagcradhplayer = new CheckBox();
      this.dionplayer = new CheckBox();
      this.regenplayer = new CheckBox();
      this.caplayer = new CheckBox();
      this.lyliacplayer = new CheckBox();
      this.lyliacplayercond = new TextBox();
      this.label2 = new Label();
      this.ioctype = new ComboBox();
      this.fastype = new ComboBox();
      this.aitetype = new ComboBox();
      this.vineyardcond = new TextBox();
      this.label4 = new Label();
      this.vineyard = new CheckBox();
      this.mdclowmp = new CheckBox();
      this.mdclowmpNum = new TextBox();
      this.iocplayercond.BeginInit();
      this.SuspendLayout();
      this.iocplayer.AutoSize = true;
      this.iocplayer.Location = new System.Drawing.Point(283, 53);
      this.iocplayer.Name = "iocplayer";
      this.iocplayer.Size = new Size(15, 14);
      this.iocplayer.TabIndex = 111;
      this.iocplayer.UseVisualStyleBackColor = true;
      this.iocplayer.CheckedChanged += new EventHandler(this.iocplayer_CheckedChanged);
      this.creagneartplayer.AutoSize = true;
      this.creagneartplayer.Location = new System.Drawing.Point(71, 181);
      this.creagneartplayer.Name = "creagneartplayer";
      this.creagneartplayer.Size = new Size(88, 19);
      this.creagneartplayer.TabIndex = 106;
      this.creagneartplayer.Text = "creag neart";
      this.creagneartplayer.UseVisualStyleBackColor = true;
      this.aocursesplayer.AutoSize = true;
      this.aocursesplayer.Location = new System.Drawing.Point(283, 130);
      this.aocursesplayer.Name = "aocursesplayer";
      this.aocursesplayer.Size = new Size(81, 19);
      this.aocursesplayer.TabIndex = 104;
      this.aocursesplayer.Text = "ao curses";
      this.aocursesplayer.UseVisualStyleBackColor = true;
      this.aopuinseinplayer.AutoSize = true;
      this.aopuinseinplayer.Location = new System.Drawing.Point(283, 105);
      this.aopuinseinplayer.Name = "aopuinseinplayer";
      this.aopuinseinplayer.Size = new Size(91, 19);
      this.aopuinseinplayer.TabIndex = 103;
      this.aopuinseinplayer.Text = "ao puinsein";
      this.aopuinseinplayer.UseVisualStyleBackColor = true;
      this.aosuainplayer.AutoSize = true;
      this.aosuainplayer.Location = new System.Drawing.Point(283, 80);
      this.aosuainplayer.Name = "aosuainplayer";
      this.aosuainplayer.Size = new Size(74, 19);
      this.aosuainplayer.TabIndex = 102;
      this.aosuainplayer.Text = "ao suain";
      this.aosuainplayer.UseVisualStyleBackColor = true;
      this.armachdplayer.AutoSize = true;
      this.armachdplayer.Location = new System.Drawing.Point(71, 156);
      this.armachdplayer.Name = "armachdplayer";
      this.armachdplayer.Size = new Size(75, 19);
      this.armachdplayer.TabIndex = 100;
      this.armachdplayer.Text = "armachd";
      this.armachdplayer.UseVisualStyleBackColor = true;
      this.fasdeireasplayer.AutoSize = true;
      this.fasdeireasplayer.Enabled = false;
      this.fasdeireasplayer.Location = new System.Drawing.Point(71, 131);
      this.fasdeireasplayer.Name = "fasdeireasplayer";
      this.fasdeireasplayer.Size = new Size(88, 19);
      this.fasdeireasplayer.TabIndex = 99;
      this.fasdeireasplayer.Text = "fas deireas";
      this.fasdeireasplayer.UseVisualStyleBackColor = true;
      this.beannplayer.AutoSize = true;
      this.beannplayer.Location = new System.Drawing.Point(71, 104);
      this.beannplayer.Name = "beannplayer";
      this.beannplayer.Size = new Size(84, 19);
      this.beannplayer.TabIndex = 98;
      this.beannplayer.Text = "beannaich";
      this.beannplayer.UseVisualStyleBackColor = true;
      this.aiteplayer.AutoSize = true;
      this.aiteplayer.Location = new System.Drawing.Point(71, 53);
      this.aiteplayer.Name = "aiteplayer";
      this.aiteplayer.Size = new Size(15, 14);
      this.aiteplayer.TabIndex = 97;
      this.aiteplayer.UseVisualStyleBackColor = true;
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(89, 18);
      this.label1.Name = "label1";
      this.label1.Size = new Size(41, 15);
      this.label1.TabIndex = 117;
      this.label1.Text = "Name";
      this.playername.Location = new System.Drawing.Point(132, 13);
      this.playername.MaxLength = 12;
      this.playername.Name = "playername";
      this.playername.Size = new Size(100, 21);
      this.playername.TabIndex = 118;
      this.playername.KeyPress += new KeyPressEventHandler(this.playername_KeyPress);
      this.playername.Leave += new EventHandler(this.playername_LostFocus);
      this.removetargetplayer.Location = new System.Drawing.Point(456, 256);
      this.removetargetplayer.Name = "removetargetplayer";
      this.removetargetplayer.Size = new Size(135, 33);
      this.removetargetplayer.TabIndex = 119;
      this.removetargetplayer.Text = "Remove This Target";
      this.removetargetplayer.UseVisualStyleBackColor = true;
      this.removetargetplayer.Click += new EventHandler(this.removetargetplayer_Click);
      this.status.AutoSize = true;
      this.status.ForeColor = Color.RoyalBlue;
      this.status.Location = new System.Drawing.Point(288, 18);
      this.status.Name = "status";
      this.status.Size = new Size(102, 15);
      this.status.TabIndex = 120;
      this.status.Text = "Logged in status.";
      this.iocplayercond.Enabled = false;
      this.iocplayercond.Location = new System.Drawing.Point(411, 52);
      this.iocplayercond.Name = "iocplayercond";
      this.iocplayercond.Size = new Size(46, 21);
      this.iocplayercond.TabIndex = 123;
      this.iocplayercond.Value = new Decimal(new int[4]
      {
        80,
        0,
        0,
        0
      });
      this.label17.AutoSize = true;
      this.label17.Location = new System.Drawing.Point(463, 56);
      this.label17.Name = "label17";
      this.label17.Size = new Size(18, 15);
      this.label17.TabIndex = 122;
      this.label17.Text = "%";
      this.fasplayer.AutoSize = true;
      this.fasplayer.Location = new System.Drawing.Point(71, 82);
      this.fasplayer.Name = "fasplayer";
      this.fasplayer.Size = new Size(15, 14);
      this.fasplayer.TabIndex = 126;
      this.fasplayer.UseVisualStyleBackColor = true;
      this.beagcradhplayer.AutoSize = true;
      this.beagcradhplayer.Location = new System.Drawing.Point(283, 155);
      this.beagcradhplayer.Name = "beagcradhplayer";
      this.beagcradhplayer.Size = new Size(88, 19);
      this.beagcradhplayer.TabIndex = (int) sbyte.MaxValue;
      this.beagcradhplayer.Text = "beag cradh";
      this.beagcradhplayer.UseVisualStyleBackColor = true;
      this.dionplayer.AutoSize = true;
      this.dionplayer.Location = new System.Drawing.Point(71, 256);
      this.dionplayer.Name = "dionplayer";
      this.dionplayer.Size = new Size(119, 19);
      this.dionplayer.TabIndex = 128;
      this.dionplayer.Text = "mor dion comlha";
      this.dionplayer.UseVisualStyleBackColor = true;
      this.regenplayer.AutoSize = true;
      this.regenplayer.Location = new System.Drawing.Point(71, 206);
      this.regenplayer.Name = "regenplayer";
      this.regenplayer.Size = new Size(101, 19);
      this.regenplayer.TabIndex = 129;
      this.regenplayer.Text = "Regeneration";
      this.regenplayer.UseVisualStyleBackColor = true;
      this.caplayer.AutoSize = true;
      this.caplayer.Location = new System.Drawing.Point(71, 231);
      this.caplayer.Name = "caplayer";
      this.caplayer.Size = new Size(104, 19);
      this.caplayer.TabIndex = 130;
      this.caplayer.Text = "Counter Attack";
      this.caplayer.UseVisualStyleBackColor = true;
      this.lyliacplayer.AutoSize = true;
      this.lyliacplayer.Location = new System.Drawing.Point(283, 182);
      this.lyliacplayer.Name = "lyliacplayer";
      this.lyliacplayer.Size = new Size(88, 19);
      this.lyliacplayer.TabIndex = 131;
      this.lyliacplayer.Text = "Lyliac Plant";
      this.lyliacplayer.UseVisualStyleBackColor = true;
      this.lyliacplayercond.Location = new System.Drawing.Point(446, 180);
      this.lyliacplayercond.Name = "lyliacplayercond";
      this.lyliacplayercond.Size = new Size(63, 21);
      this.lyliacplayercond.TabIndex = 132;
      this.lyliacplayercond.Text = "10000";
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(372, 183);
      this.label2.Name = "label2";
      this.label2.Size = new Size(66, 15);
      this.label2.TabIndex = 133;
      this.label2.Text = "          delay";
      this.ioctype.DropDownStyle = ComboBoxStyle.DropDownList;
      this.ioctype.Font = new Font("Arial", 9f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.ioctype.FormattingEnabled = true;
      this.ioctype.Location = new System.Drawing.Point(304, 49);
      this.ioctype.Name = "ioctype";
      this.ioctype.Size = new Size(94, 23);
      this.ioctype.TabIndex = 138;
      this.fastype.DropDownStyle = ComboBoxStyle.DropDownList;
      this.fastype.Font = new Font("Arial", 9f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.fastype.FormattingEnabled = true;
      this.fastype.Location = new System.Drawing.Point(92, 78);
      this.fastype.Name = "fastype";
      this.fastype.Size = new Size(121, 23);
      this.fastype.TabIndex = 137;
      this.aitetype.DropDownStyle = ComboBoxStyle.DropDownList;
      this.aitetype.Font = new Font("Arial", 9f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.aitetype.FormattingEnabled = true;
      this.aitetype.Location = new System.Drawing.Point(92, 49);
      this.aitetype.Name = "aitetype";
      this.aitetype.Size = new Size(121, 23);
      this.aitetype.TabIndex = 136;
      this.vineyardcond.Location = new System.Drawing.Point(466, 205);
      this.vineyardcond.Name = "vineyardcond";
      this.vineyardcond.Size = new Size(63, 21);
      this.vineyardcond.TabIndex = 163;
      this.vineyardcond.Text = "10000";
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(394, 208);
      this.label4.Name = "label4";
      this.label4.Size = new Size(66, 15);
      this.label4.TabIndex = 162;
      this.label4.Text = "when Mp <";
      this.vineyard.AutoSize = true;
      this.vineyard.Location = new System.Drawing.Point(283, 207);
      this.vineyard.Name = "vineyard";
      this.vineyard.Size = new Size(107, 19);
      this.vineyard.TabIndex = 161;
      this.vineyard.Text = "Lyliac Vineyard";
      this.vineyard.UseVisualStyleBackColor = true;
      this.mdclowmp.AutoSize = true;
      this.mdclowmp.Location = new System.Drawing.Point(71, 281);
      this.mdclowmp.Name = "mdclowmp";
      this.mdclowmp.Size = new Size(112, 19);
      this.mdclowmp.TabIndex = 164;
      this.mdclowmp.Text = "mdc when Mp <";
      this.mdclowmp.UseVisualStyleBackColor = true;
      this.mdclowmp.Visible = false;
      this.mdclowmpNum.Location = new System.Drawing.Point(189, 279);
      this.mdclowmpNum.Name = "mdclowmpNum";
      this.mdclowmpNum.Size = new Size(51, 21);
      this.mdclowmpNum.TabIndex = 165;
      this.mdclowmpNum.Text = "1200";
      this.mdclowmpNum.Visible = false;
      this.BackColor = Color.White;
      this.ClientSize = new Size(598, 299);
      this.Controls.Add((Control) this.mdclowmpNum);
      this.Controls.Add((Control) this.mdclowmp);
      this.Controls.Add((Control) this.vineyardcond);
      this.Controls.Add((Control) this.label4);
      this.Controls.Add((Control) this.vineyard);
      this.Controls.Add((Control) this.ioctype);
      this.Controls.Add((Control) this.fastype);
      this.Controls.Add((Control) this.aitetype);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.lyliacplayercond);
      this.Controls.Add((Control) this.lyliacplayer);
      this.Controls.Add((Control) this.caplayer);
      this.Controls.Add((Control) this.regenplayer);
      this.Controls.Add((Control) this.dionplayer);
      this.Controls.Add((Control) this.beagcradhplayer);
      this.Controls.Add((Control) this.fasplayer);
      this.Controls.Add((Control) this.iocplayercond);
      this.Controls.Add((Control) this.label17);
      this.Controls.Add((Control) this.status);
      this.Controls.Add((Control) this.removetargetplayer);
      this.Controls.Add((Control) this.playername);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.iocplayer);
      this.Controls.Add((Control) this.creagneartplayer);
      this.Controls.Add((Control) this.aocursesplayer);
      this.Controls.Add((Control) this.aopuinseinplayer);
      this.Controls.Add((Control) this.aosuainplayer);
      this.Controls.Add((Control) this.armachdplayer);
      this.Controls.Add((Control) this.fasdeireasplayer);
      this.Controls.Add((Control) this.beannplayer);
      this.Controls.Add((Control) this.aiteplayer);
      this.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Name =  "targetPlayer";
      this.iocplayercond.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
