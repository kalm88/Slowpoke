//SlowPoke
// Type: Flintstones.targetAlts
//SlowPoke
//SlowPoke
//SlowPoke

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Flintstones
{
  public class targetAlts : TabPage
  {
    public string vioctype = string.Empty;
    public string vaitetype = string.Empty;
    public string vfastype = string.Empty;
    public string vlyliacplayercond = "10000";
    public string vvineyardcond = "10000";
    public int vioccond = 80;
    public int vnuadhcond = 50;
    public bool vaite;
    public bool vfasplayer;
    public bool vbeann;
    public bool vfasdeireas;
    public bool varmachd;
    public bool vcreagneart;
    public bool vregen;
    public bool vca;
    public bool vdion;
    public bool vnuadh;
    public bool vioc;
    public bool vaocurses;
    public bool vaosuain;
    public bool vaopuinsein;
    public bool vignorebardo;
    public bool vbeagcradh;
    public bool vlyliacplayer;
    public bool vvineyard;
    private IContainer components;
    public CheckBox iocalts;
    public CheckBox creagneartalts;
    public CheckBox beagcradhalts;
    public CheckBox aocursesalts;
    public CheckBox aopuinseinalts;
    public CheckBox aosuainalts;
    public CheckBox armachdalts;
    public CheckBox fasdeireasalts;
    public CheckBox beannalts;
    public CheckBox aitealts;
    private Label label17;
    private Button removeallalts;
    public CheckBox fasplayeralts;
    public CheckBox ignorebardoalts;
    public CheckBox caalts;
    public CheckBox regenalts;
    public CheckBox dionalts;
    public NumericUpDown iocaltscond;
    public ComboBox fastype;
    public ComboBox aitetype;
    public ComboBox ioctype;
    private Label label2;
    public TextBox lyliacplayercond;
    public CheckBox lyliacplayer;
    private Label label3;
    public TextBox vineyardcond;
    public CheckBox vineyard;

    public ClientTab ClientTab { get; private set; }

    public targetAlts(ClientTab clienttab)
    {
      this.InitializeComponent();
      this.Text = "all alts";
      this.ClientTab = clienttab;
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
        this.aitealts.Checked = false;
        this.aitealts.Enabled = false;
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
        this.fasplayeralts.Checked = false;
        this.fasplayeralts.Enabled = false;
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
            if (this.ClientTab.Client.YourIocs.Contains("Leigheas"))
            {
                this.ioctype.Items.Add((object)"Leigheas");
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
            if (this.ClientTab.Client.YourGIocs.Contains("Nuadhiach Le Cheile"))
            {
                this.ioctype.Items.Add((object)"Nuadhiach Le Cheile");
                ++num;
            }
            if (this.ClientTab.Client.YourGIocs.Contains("ard ioc comlha"))
      {
        this.ioctype.Items.Add((object) "ard ioc comlha");
        ++num;
      }
      if (this.ClientTab.Client.YourGIocs.Contains("mor ioc comlha"))
      {
        this.ioctype.Items.Add((object) "mor ioc comlha");
        ++num;
      }
      if (this.ClientTab.Client.YourGIocs.Contains("ioc comlha"))
      {
        this.ioctype.Items.Add((object) "ioc comlha");
        ++num;
      }
      if (this.ClientTab.Client.YourGIocs.Contains("beag ioc comlha"))
      {
        this.ioctype.Items.Add((object) "beag ioc comlha");
        ++num;
      }
      if (num > 0)
      {
        this.ioctype.SelectedIndex = 0;
      }
      else
      {
        this.iocalts.Checked = false;
        this.iocalts.Enabled = false;
        this.ioctype.Enabled = false;
      }
    }

    private void removeallalts_Click(object sender, EventArgs e)
    {
      --this.ClientTab.spellTargets.SelectedIndex;
      this.ClientTab.spellTargets.TabPages.Remove((TabPage) this);
      this.ClientTab.allalts = (targetAlts) null;
      this.ClientTab.newalts.Enabled = true;
    }

    private void iocalts_CheckedChanged(object sender, EventArgs e)
    {
      if (this.iocalts.Checked)
      {
        this.iocaltscond.Enabled = true;
        this.vioc = true;
      }
      else
      {
        this.iocaltscond.Enabled = false;
        this.vioc = false;
      }
    }

    private void aocursesalts_CheckedChanged(object sender, EventArgs e)
    {
      if (this.aocursesalts.Checked)
      {
        this.ignorebardoalts.Enabled = true;
        this.vaocurses = true;
      }
      else
      {
        this.ignorebardoalts.Enabled = false;
        this.vaocurses = false;
      }
    }

    private void aitealts_CheckedChanged(object sender, EventArgs e)
    {
      if (this.aitealts.Checked)
        this.vaite = true;
      else
        this.vaite = false;
    }

    private void fasplayeralts_CheckedChanged(object sender, EventArgs e)
    {
      if (this.fasplayeralts.Checked)
        this.vfasplayer = true;
      else
        this.vfasplayer = false;
    }

    private void beannalts_CheckedChanged(object sender, EventArgs e)
    {
      if (this.beannalts.Checked)
        this.vbeann = true;
      else
        this.vbeann = false;
    }

    private void fasdeireasalts_CheckedChanged(object sender, EventArgs e)
    {
      if (this.fasdeireasalts.Checked)
        this.vfasdeireas = true;
      else
        this.vfasdeireas = false;
    }

    private void armachdalts_CheckedChanged(object sender, EventArgs e)
    {
      if (this.armachdalts.Checked)
        this.varmachd = true;
      else
        this.varmachd = false;
    }

    private void creagneartalts_CheckedChanged(object sender, EventArgs e)
    {
      if (this.creagneartalts.Checked)
        this.vcreagneart = true;
      else
        this.vcreagneart = false;
    }

    private void regenalts_CheckedChanged(object sender, EventArgs e)
    {
      if (this.regenalts.Checked)
        this.vregen = true;
      else
        this.vregen = false;
    }

    private void caalts_CheckedChanged(object sender, EventArgs e)
    {
      if (this.caalts.Checked)
        this.vca = true;
      else
        this.vca = false;
    }

    private void dionalts_CheckedChanged(object sender, EventArgs e)
    {
      if (this.dionalts.Checked)
        this.vdion = true;
      else
        this.vdion = false;
    }

    private void aitetype_SelectedIndexChanged(object sender, EventArgs e) => this.vaitetype = this.aitetype.SelectedItem.ToString();

    private void fastype_SelectedIndexChanged(object sender, EventArgs e) => this.vfastype = this.fastype.SelectedItem.ToString();

    private void iocaltscond_ValueChanged(object sender, EventArgs e) => this.vioccond = (int) this.iocaltscond.Value;

    private void aosuainalts_CheckedChanged(object sender, EventArgs e)
    {
      if (this.aosuainalts.Checked)
        this.vaosuain = true;
      else
        this.vaosuain = false;
    }

    private void aopuinseinalts_CheckedChanged(object sender, EventArgs e)
    {
      if (this.aopuinseinalts.Checked)
        this.vaopuinsein = true;
      else
        this.vaopuinsein = false;
    }

    private void ignorebardoalts_CheckedChanged(object sender, EventArgs e)
    {
      if (this.ignorebardoalts.Checked)
        this.vignorebardo = true;
      else
        this.vignorebardo = false;
    }

    private void beagcradhalts_CheckedChanged(object sender, EventArgs e)
    {
      if (this.beagcradhalts.Checked)
        this.vbeagcradh = true;
      else
        this.vbeagcradh = false;
    }

    private void lyliacplayer_CheckedChanged(object sender, EventArgs e)
    {
      if (this.lyliacplayer.Checked)
        this.vlyliacplayer = true;
      else
        this.vlyliacplayer = false;
    }

    private void vineyard_CheckedChanged(object sender, EventArgs e)
    {
      if (this.vineyard.Checked)
        this.vvineyard = true;
      else
        this.vvineyard = false;
    }

    private void lyliacplayercond_TextChanged(object sender, EventArgs e) => this.vlyliacplayercond = this.lyliacplayercond.Text;

    private void vineyardcond_TextChanged(object sender, EventArgs e) => this.vvineyardcond = this.vineyardcond.Text;

    private void ioctype_SelectedIndexChanged(object sender, EventArgs e) => this.vioctype = this.ioctype.SelectedItem.ToString();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.iocalts = new CheckBox();
      this.creagneartalts = new CheckBox();
      this.beagcradhalts = new CheckBox();
      this.aocursesalts = new CheckBox();
      this.aopuinseinalts = new CheckBox();
      this.aosuainalts = new CheckBox();
      this.armachdalts = new CheckBox();
      this.fasdeireasalts = new CheckBox();
      this.beannalts = new CheckBox();
      this.aitealts = new CheckBox();
      this.label17 = new Label();
      this.removeallalts = new Button();
      this.iocaltscond = new NumericUpDown();
      this.ignorebardoalts = new CheckBox();
      this.fasplayeralts = new CheckBox();
      this.caalts = new CheckBox();
      this.regenalts = new CheckBox();
      this.dionalts = new CheckBox();
      this.fastype = new ComboBox();
      this.aitetype = new ComboBox();
      this.ioctype = new ComboBox();
      this.label2 = new Label();
      this.lyliacplayercond = new TextBox();
      this.lyliacplayer = new CheckBox();
      this.vineyard = new CheckBox();
      this.label3 = new Label();
      this.vineyardcond = new TextBox();
      this.iocaltscond.BeginInit();
      this.SuspendLayout();
      this.iocalts.AutoSize = true;
      this.iocalts.Location = new System.Drawing.Point(276, 16);
      this.iocalts.Name = "iocalts";
      this.iocalts.Size = new Size(15, 14);
      this.iocalts.TabIndex = 76;
      this.iocalts.UseVisualStyleBackColor = true;
      this.iocalts.CheckedChanged += new EventHandler(this.iocalts_CheckedChanged);
      this.creagneartalts.AutoSize = true;
      this.creagneartalts.Location = new System.Drawing.Point(64, 144);
      this.creagneartalts.Name = "creagneartalts";
      this.creagneartalts.Size = new Size(88, 19);
      this.creagneartalts.TabIndex = 75;
      this.creagneartalts.Text = "creag neart";
      this.creagneartalts.UseVisualStyleBackColor = true;
      this.creagneartalts.CheckedChanged += new EventHandler(this.creagneartalts_CheckedChanged);
      this.beagcradhalts.AutoSize = true;
      this.beagcradhalts.Location = new System.Drawing.Point(276, 143);
      this.beagcradhalts.Name = "beagcradhalts";
      this.beagcradhalts.Size = new Size(88, 19);
      this.beagcradhalts.TabIndex = 74;
      this.beagcradhalts.Text = "beag cradh";
      this.beagcradhalts.UseVisualStyleBackColor = true;
      this.beagcradhalts.CheckedChanged += new EventHandler(this.beagcradhalts_CheckedChanged);
      this.aocursesalts.AutoSize = true;
      this.aocursesalts.Location = new System.Drawing.Point(276, 93);
      this.aocursesalts.Name = "aocursesalts";
      this.aocursesalts.Size = new Size(81, 19);
      this.aocursesalts.TabIndex = 73;
      this.aocursesalts.Text = "ao curses";
      this.aocursesalts.UseVisualStyleBackColor = true;
      this.aocursesalts.CheckedChanged += new EventHandler(this.aocursesalts_CheckedChanged);
      this.aopuinseinalts.AutoSize = true;
      this.aopuinseinalts.Location = new System.Drawing.Point(276, 68);
      this.aopuinseinalts.Name = "aopuinseinalts";
      this.aopuinseinalts.Size = new Size(91, 19);
      this.aopuinseinalts.TabIndex = 72;
      this.aopuinseinalts.Text = "ao puinsein";
      this.aopuinseinalts.UseVisualStyleBackColor = true;
      this.aopuinseinalts.CheckedChanged += new EventHandler(this.aopuinseinalts_CheckedChanged);
      this.aosuainalts.AutoSize = true;
      this.aosuainalts.Location = new System.Drawing.Point(276, 43);
      this.aosuainalts.Name = "aosuainalts";
      this.aosuainalts.Size = new Size(74, 19);
      this.aosuainalts.TabIndex = 71;
      this.aosuainalts.Text = "ao suain";
      this.aosuainalts.UseVisualStyleBackColor = true;
      this.aosuainalts.CheckedChanged += new EventHandler(this.aosuainalts_CheckedChanged);
      this.armachdalts.AutoSize = true;
      this.armachdalts.Location = new System.Drawing.Point(64, 119);
      this.armachdalts.Name = "armachdalts";
      this.armachdalts.Size = new Size(75, 19);
      this.armachdalts.TabIndex = 69;
      this.armachdalts.Text = "armachd";
      this.armachdalts.UseVisualStyleBackColor = true;
      this.armachdalts.CheckedChanged += new EventHandler(this.armachdalts_CheckedChanged);
      this.fasdeireasalts.AutoSize = true;
      this.fasdeireasalts.Location = new System.Drawing.Point(64, 94);
      this.fasdeireasalts.Name = "fasdeireasalts";
      this.fasdeireasalts.Size = new Size(88, 19);
      this.fasdeireasalts.TabIndex = 68;
      this.fasdeireasalts.Text = "fas deireas";
      this.fasdeireasalts.UseVisualStyleBackColor = true;
      this.fasdeireasalts.CheckedChanged += new EventHandler(this.fasdeireasalts_CheckedChanged);
      this.beannalts.AutoSize = true;
      this.beannalts.Location = new System.Drawing.Point(64, 67);
      this.beannalts.Name = "beannalts";
      this.beannalts.Size = new Size(84, 19);
      this.beannalts.TabIndex = 67;
      this.beannalts.Text = "beannaich";
      this.beannalts.UseVisualStyleBackColor = true;
      this.beannalts.CheckedChanged += new EventHandler(this.beannalts_CheckedChanged);
      this.aitealts.AutoSize = true;
      this.aitealts.Location = new System.Drawing.Point(64, 16);
      this.aitealts.Name = "aitealts";
      this.aitealts.Size = new Size(15, 14);
      this.aitealts.TabIndex = 66;
      this.aitealts.UseVisualStyleBackColor = true;
      this.aitealts.CheckedChanged += new EventHandler(this.aitealts_CheckedChanged);
      this.label17.AutoSize = true;
      this.label17.Location = new System.Drawing.Point(475, 17);
      this.label17.Name = "label17";
      this.label17.Size = new Size(18, 15);
      this.label17.TabIndex = 64;
      this.label17.Text = "%";
      this.removeallalts.Location = new System.Drawing.Point(459, 254);
      this.removeallalts.Name = "removeallalts";
      this.removeallalts.Size = new Size((int) sbyte.MaxValue, 33);
      this.removeallalts.TabIndex = 84;
      this.removeallalts.Text = "remove this target";
      this.removeallalts.UseVisualStyleBackColor = true;
      this.removeallalts.Click += new EventHandler(this.removeallalts_Click);
      this.iocaltscond.Enabled = false;
      this.iocaltscond.Location = new System.Drawing.Point(423, 13);
      this.iocaltscond.Name = "iocaltscond";
      this.iocaltscond.Size = new Size(46, 21);
      this.iocaltscond.TabIndex = 85;
      this.iocaltscond.Value = new Decimal(new int[4]
      {
        80,
        0,
        0,
        0
      });
      this.iocaltscond.ValueChanged += new EventHandler(this.iocaltscond_ValueChanged);
      this.ignorebardoalts.AutoSize = true;
      this.ignorebardoalts.Enabled = false;
      this.ignorebardoalts.Location = new System.Drawing.Point(276, 118);
      this.ignorebardoalts.Name = "ignorebardoalts";
      this.ignorebardoalts.Size = new Size(97, 19);
      this.ignorebardoalts.TabIndex = 146;
      this.ignorebardoalts.Text = "Ignore Bardo";
      this.ignorebardoalts.UseVisualStyleBackColor = true;
      this.ignorebardoalts.CheckedChanged += new EventHandler(this.ignorebardoalts_CheckedChanged);
      this.fasplayeralts.AutoSize = true;
      this.fasplayeralts.Location = new System.Drawing.Point(64, 45);
      this.fasplayeralts.Name = "fasplayeralts";
      this.fasplayeralts.Size = new Size(15, 14);
      this.fasplayeralts.TabIndex = 147;
      this.fasplayeralts.UseVisualStyleBackColor = true;
      this.fasplayeralts.CheckedChanged += new EventHandler(this.fasplayeralts_CheckedChanged);
      this.caalts.AutoSize = true;
      this.caalts.Location = new System.Drawing.Point(64, 194);
      this.caalts.Name = "caalts";
      this.caalts.Size = new Size(104, 19);
      this.caalts.TabIndex = 150;
      this.caalts.Text = "Counter Attack";
      this.caalts.UseVisualStyleBackColor = true;
      this.caalts.CheckedChanged += new EventHandler(this.caalts_CheckedChanged);
      this.regenalts.AutoSize = true;
      this.regenalts.Location = new System.Drawing.Point(64, 169);
      this.regenalts.Name = "regenalts";
      this.regenalts.Size = new Size(101, 19);
      this.regenalts.TabIndex = 149;
      this.regenalts.Text = "Regeneration";
      this.regenalts.UseVisualStyleBackColor = true;
      this.regenalts.CheckedChanged += new EventHandler(this.regenalts_CheckedChanged);
      this.dionalts.AutoSize = true;
      this.dionalts.Location = new System.Drawing.Point(64, 219);
      this.dionalts.Name = "dionalts";
      this.dionalts.Size = new Size(119, 19);
      this.dionalts.TabIndex = 148;
      this.dionalts.Text = "mor dion comlha";
      this.dionalts.UseVisualStyleBackColor = true;
      this.dionalts.CheckedChanged += new EventHandler(this.dionalts_CheckedChanged);
      this.fastype.DropDownStyle = ComboBoxStyle.DropDownList;
      this.fastype.Font = new Font("Arial", 9f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.fastype.FormattingEnabled = true;
      this.fastype.Location = new System.Drawing.Point(85, 41);
      this.fastype.Name = "fastype";
      this.fastype.Size = new Size(121, 23);
      this.fastype.TabIndex = 152;
      this.fastype.SelectedIndexChanged += new EventHandler(this.fastype_SelectedIndexChanged);
      this.aitetype.DropDownStyle = ComboBoxStyle.DropDownList;
      this.aitetype.Font = new Font("Arial", 9f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.aitetype.FormattingEnabled = true;
      this.aitetype.Location = new System.Drawing.Point(85, 12);
      this.aitetype.Name = "aitetype";
      this.aitetype.Size = new Size(121, 23);
      this.aitetype.TabIndex = 151;
      this.aitetype.SelectedIndexChanged += new EventHandler(this.aitetype_SelectedIndexChanged);
      this.ioctype.DropDownStyle = ComboBoxStyle.DropDownList;
      this.ioctype.Font = new Font("Arial", 9f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.ioctype.FormattingEnabled = true;
      this.ioctype.Location = new System.Drawing.Point(297, 12);
      this.ioctype.Name = "ioctype";
      this.ioctype.Size = new Size(120, 23);
      this.ioctype.TabIndex = 154;
      this.ioctype.SelectedIndexChanged += new EventHandler(this.ioctype_SelectedIndexChanged);
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(365, 171);
      this.label2.Name = "label2";
      this.label2.Size = new Size(66, 15);
      this.label2.TabIndex = 157;
      this.label2.Text = "when Mp <";
      this.lyliacplayercond.Location = new System.Drawing.Point(439, 168);
      this.lyliacplayercond.Name = "lyliacplayercond";
      this.lyliacplayercond.Size = new Size(63, 21);
      this.lyliacplayercond.TabIndex = 156;
      this.lyliacplayercond.Text = "10000";
      this.lyliacplayercond.TextChanged += new EventHandler(this.lyliacplayercond_TextChanged);
      this.lyliacplayer.AutoSize = true;
      this.lyliacplayer.Location = new System.Drawing.Point(276, 170);
      this.lyliacplayer.Name = "lyliacplayer";
      this.lyliacplayer.Size = new Size(88, 19);
      this.lyliacplayer.TabIndex = 155;
      this.lyliacplayer.Text = "Lyliac Plant";
      this.lyliacplayer.UseVisualStyleBackColor = true;
      this.lyliacplayer.CheckedChanged += new EventHandler(this.lyliacplayer_CheckedChanged);
      this.vineyard.AutoSize = true;
      this.vineyard.Location = new System.Drawing.Point(276, 195);
      this.vineyard.Name = "vineyard";
      this.vineyard.Size = new Size(107, 19);
      this.vineyard.TabIndex = 158;
      this.vineyard.Text = "Lyliac Vineyard";
      this.vineyard.UseVisualStyleBackColor = true;
      this.vineyard.CheckedChanged += new EventHandler(this.vineyard_CheckedChanged);
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(387, 196);
      this.label3.Name = "label3";
      this.label3.Size = new Size(66, 15);
      this.label3.TabIndex = 159;
      this.label3.Text = "when Mp <";
      this.vineyardcond.Location = new System.Drawing.Point(459, 193);
      this.vineyardcond.Name = "vineyardcond";
      this.vineyardcond.Size = new Size(63, 21);
      this.vineyardcond.TabIndex = 160;
      this.vineyardcond.Text = "10000";
      this.vineyardcond.TextChanged += new EventHandler(this.vineyardcond_TextChanged);
      this.BackColor = Color.White;
      this.ClientSize = new Size(598, 299);
      this.Controls.Add((Control) this.vineyardcond);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.vineyard);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.lyliacplayercond);
      this.Controls.Add((Control) this.lyliacplayer);
      this.Controls.Add((Control) this.ioctype);
      this.Controls.Add((Control) this.fastype);
      this.Controls.Add((Control) this.aitetype);
      this.Controls.Add((Control) this.caalts);
      this.Controls.Add((Control) this.regenalts);
      this.Controls.Add((Control) this.dionalts);
      this.Controls.Add((Control) this.fasplayeralts);
      this.Controls.Add((Control) this.ignorebardoalts);
      this.Controls.Add((Control) this.iocaltscond);
      this.Controls.Add((Control) this.removeallalts);
      this.Controls.Add((Control) this.iocalts);
      this.Controls.Add((Control) this.creagneartalts);
      this.Controls.Add((Control) this.beagcradhalts);
      this.Controls.Add((Control) this.aocursesalts);
      this.Controls.Add((Control) this.aopuinseinalts);
      this.Controls.Add((Control) this.aosuainalts);
      this.Controls.Add((Control) this.armachdalts);
      this.Controls.Add((Control) this.fasdeireasalts);
      this.Controls.Add((Control) this.beannalts);
      this.Controls.Add((Control) this.aitealts);
      this.Controls.Add((Control) this.label17);
      this.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Name = "targetAlts";
      this.Text = "targetplayer";
      this.iocaltscond.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
