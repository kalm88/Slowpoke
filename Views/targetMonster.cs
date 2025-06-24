//SlowPoke
// Type: Flintstones.targetMonster
//SlowPoke
//SlowPoke
//SlowPoke

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Flintstones
{
  public class targetMonster : TabPage
  {
    public SpellData attackwith;
    public SpellData secattackwith;
    public SpellData cursewith;
    public SpellData faswith;
    public SpellData pramhwith;
    private IContainer components;
    private Label label1;
    private Button removemonster;
    private GroupBox groupBox4;
    public CheckBox spampramh;
    public ComboBox pramhtype;
    public CheckBox pramh;
    public CheckBox attackafterpramh;
    private GroupBox groupBox3;
    public CheckBox spellsilenced;
    public ComboBox attack2type;
    public ComboBox attack1type;
    public CheckBox attack2;
    public CheckBox attack1;
    private GroupBox groupBox2;
    public CheckBox spamfascurse;
    public CheckBox fasamancrystals;
    public ComboBox fastype;
    public ComboBox cradhtype;
    public CheckBox fas;
    public CheckBox cradh;
    private GroupBox groupBox1;
    public ComboBox fascursetargettype;
    public GroupBox groupBox6;
    public CheckBox pramhedonly;
    public CheckBox fasedonly;
    public CheckBox ardedonly;
    private Label label2;
    private Label label3;
    public ComboBox targettype;
    public TextBox monstername;
    public NumericUpDown groupedmembersrange;
    public CheckBox groupedmembers;
    public CheckBox heal;
    public CheckBox aite;
    public NumericUpDown healnum;
    public CheckBox multi;
    public CheckBox ctd;
    public CheckBox diondonly;

    public ClientTab ClientTab { get; private set; }

    public targetMonster(string title, ClientTab clienttab)
    {
      this.InitializeComponent();
      this.Text = title;
      this.monstername.Text = title;
      this.ClientTab = clienttab;
      this.ClientTab.spellMonsters.TabPages.Add((TabPage) this);
      this.ClientTab.spellMonsters.SelectedTab = (TabPage) this;
      this.targettype.SelectedIndex = 0;
      this.fascursetargettype.SelectedIndex = 0;
      this.BestFases();
      this.BestCradhs();
      this.BestPramhs();
      this.BestAttacks1();
      this.BestAttacks2();
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
        this.fas.Checked = false;
        this.fas.Enabled = false;
        this.fastype.Enabled = false;
      }
    }

    public void BestCradhs()
    {
      int num = 0;
      if (this.ClientTab.Client.YourCradhs.Contains("Demon Seal"))
      {
        this.cradhtype.Items.Add((object) "Demon Seal");
        ++num;
      }
      if (this.ClientTab.Client.YourCradhs.Contains("Demise"))
      {
        this.cradhtype.Items.Add((object) "Demise");
        ++num;
      }
      if (this.ClientTab.Client.YourCradhs.Contains("Darker Seal"))
      {
        this.cradhtype.Items.Add((object) "Darker Seal");
        ++num;
      }
      if (this.ClientTab.Client.YourCradhs.Contains("Dark Seal"))
      {
        this.cradhtype.Items.Add((object) "Dark Seal");
        ++num;
      }
      if (this.ClientTab.Client.YourCradhs.Contains("ard cradh"))
      {
        this.cradhtype.Items.Add((object) "ard cradh");
        ++num;
      }
      if (this.ClientTab.Client.YourCradhs.Contains("mor cradh"))
      {
        this.cradhtype.Items.Add((object) "mor cradh");
        ++num;
      }
      if (this.ClientTab.Client.YourCradhs.Contains("cradh"))
      {
        this.cradhtype.Items.Add((object) "cradh");
        ++num;
      }
      if (this.ClientTab.Client.YourCradhs.Contains("beag cradh"))
      {
        this.cradhtype.Items.Add((object) "beag cradh");
        ++num;
      }
      if (num > 0)
      {
        this.cradhtype.SelectedIndex = 0;
      }
      else
      {
        this.cradh.Checked = false;
        this.cradh.Enabled = false;
        this.cradhtype.Enabled = false;
      }
    }

    public void BestPramhs()
    {
      int num = 0;
      if (this.ClientTab.Client.YourPramhs.Contains("Mesmerize"))
      {
        this.pramhtype.Items.Add((object) "Mesmerize");
        ++num;
      }
      if (this.ClientTab.Client.YourPramhs.Contains("pramh"))
      {
        this.pramhtype.Items.Add((object) "pramh");
        ++num;
      }
      if (this.ClientTab.Client.YourPramhs.Contains("beag pramh"))
      {
        this.pramhtype.Items.Add((object) "beag pramh");
        ++num;
      }
      if (this.ClientTab.Client.YourPramhs.Contains("suain"))
      {
        this.pramhtype.Items.Add((object) "suain");
        ++num;
      }
      if (this.ClientTab.Client.YourPramhs.Contains("dall"))
      {
        this.pramhtype.Items.Add((object) "dall");
        ++num;
      }
      if (num > 0)
      {
        this.pramhtype.SelectedIndex = 0;
      }
      else
      {
        this.pramh.Checked = false;
        this.pramh.Enabled = false;
        this.pramhtype.Enabled = false;
      }
    }

    public void BestAttacks1()
    {
      int num = 0;
      if (this.ClientTab.Client.YourAttacks1.Contains("Wraith Touch"))
      {
        this.attack1type.Items.Add((object) "Wraith Touch");
        ++num;
      }
      if (this.ClientTab.Client.YourAttacks1.Contains("beag athar lamh"))
      {
        this.attack1type.Items.Add((object) "beag athar lamh");
        ++num;
      }
      if (this.ClientTab.Client.YourAttacks1.Contains("athar lamh"))
      {
        this.attack1type.Items.Add((object) "athar lamh");
        ++num;
      }
      if (this.ClientTab.Client.YourAttacks1.Contains("beag srad lamh"))
      {
        this.attack1type.Items.Add((object) "beag srad lamh");
        ++num;
      }
      if (this.ClientTab.Client.YourAttacks1.Contains("srad lamh"))
      {
        this.attack1type.Items.Add((object) "srad lamh");
        ++num;
      }
      if (this.ClientTab.Client.YourAttacks1.Contains("Keeter"))
      {
        this.attack1type.Items.Add((object) "Keeter");
        ++num;
      }
      if (this.ClientTab.Client.YourAttacks1.Contains("Mermaid"))
      {
        this.attack1type.Items.Add((object) "Mermaid");
        ++num;
      }
      if (this.ClientTab.Client.YourAttacks1.Contains("Torch"))
      {
        this.attack1type.Items.Add((object) "Torch");
        ++num;
      }
      if (this.ClientTab.Client.YourAttacks1.Contains("Groo"))
      {
        this.attack1type.Items.Add((object) "Groo");
        ++num;
      }
      if (this.ClientTab.Client.YourAttacks1.Contains("Unholy Explosion"))
      {
        this.attack1type.Items.Add((object) "Unholy Explosion");
        ++num;
      }
      if (this.ClientTab.Client.YourAttacks1.Contains("Dragon Blast"))
      {
        this.attack1type.Items.Add((object) "Dragon Blast");
        ++num;
      }
      if (this.ClientTab.Client.YourAttacks1.Contains("mor strioch pian gar"))
      {
        this.attack1type.Items.Add((object) "mor strioch pian gar");
        ++num;
      }
      if (this.ClientTab.Client.YourAttacks1.Contains("ard pian na dion"))
      {
        this.attack1type.Items.Add((object) "ard pian na dion");
        ++num;
      }
      if (this.ClientTab.Client.YourAttacks1.Contains("mor pian na dion"))
      {
        this.attack1type.Items.Add((object) "mor pian na dion");
        ++num;
      }
      if (this.ClientTab.Client.YourAttacks1.Contains("pian na dion"))
      {
        this.attack1type.Items.Add((object) "pian na dion");
        ++num;
      }
      if (this.ClientTab.Client.YourAttacks1.Contains("mor deo searg gar"))
      {
        this.attack1type.Items.Add((object) "mor deo searg gar");
        ++num;
      }
      if (this.ClientTab.Client.YourAttacks1.Contains("deo searg gar"))
      {
        this.attack1type.Items.Add((object) "deo searg gar");
        ++num;
      }
      if (this.ClientTab.Client.YourAttacks1.Contains("ard deo searg"))
      {
        this.attack1type.Items.Add((object) "ard deo searg");
        ++num;
      }
      if (this.ClientTab.Client.YourAttacks1.Contains("Deception of Life"))
      {
        this.attack1type.Items.Add((object) "Deception of Life");
        ++num;
      }
      if (this.ClientTab.Client.YourAttacks1.Contains("deo searg"))
      {
        this.attack1type.Items.Add((object) "deo searg");
        ++num;
      }
      if (this.ClientTab.Client.YourAttacks1.Contains("Star Arrow"))
      {
        this.attack1type.Items.Add((object) "Star Arrow");
        ++num;
      }
      if (this.ClientTab.Client.YourAttacks1.Contains("Shock Arrow"))
      {
        this.attack1type.Items.Add((object) "Shock Arrow");
        ++num;
      }
      if (this.ClientTab.Client.YourAttacks1.Contains("Frost Arrow"))
      {
        this.attack1type.Items.Add((object) "Frost Arrow");
        ++num;
      }
      if (this.ClientTab.Client.YourAttacks1.Contains("Frost + 3 Shocks"))
      {
        this.attack1type.Items.Add((object) "Frost + 3 Shocks");
        ++num;
      }
      if (this.ClientTab.Client.YourAttacks1.Contains("Hail of Feathers"))
      {
        this.attack1type.Items.Add((object) "Hail of Feathers");
        ++num;
      }
      if (num > 0)
      {
        this.attack1type.SelectedIndex = 0;
      }
      else
      {
        this.attack1.Checked = false;
        this.attack1.Enabled = false;
        this.attack1type.Enabled = false;
      }
    }

    public void BestAttacks2()
    {
      int num = 0;
      if (this.ClientTab.Client.YourAttacks2.Contains("Cursed Tune"))
      {
        this.attack2type.Items.Add((object) "Cursed Tune");
        ++num;
      }
      if (this.ClientTab.Client.YourAttacks2.Contains("Chadul's Shot"))
      {
        this.attack2type.Items.Add((object) "Chadul's Shot");
        ++num;
      }
            if (this.ClientTab.Client.YourAttacks2.Contains("Hypernova Shot"))
      {
        this.attack2type.Items.Add((object) "Hypernova Shot");
        ++num;
      }
      if (this.ClientTab.Client.YourAttacks2.Contains("Supernova Shot"))
      {
        this.attack2type.Items.Add((object)"Supernova Shot");
        ++num;
      }
      if (num > 0)
      {
        this.attack2type.SelectedIndex = 0;
      }
      else
      {
        this.attack2.Checked = false;
        this.attack2.Enabled = false;
        this.attack2type.Enabled = false;
      }
    }

    private void removemonster_Click(object sender, EventArgs e)
    {
      --this.ClientTab.spellMonsters.SelectedIndex;
      this.ClientTab.spellMonsters.TabPages.Remove((TabPage) this);
      this.ClientTab.Client.targetmonster.Remove(this);
      if (this.ClientTab.spellMonsters.TabCount != 1)
        return;
      this.ClientTab.Monsters = (targetMonster) null;
    }

    private void monstername_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
      {
        e.Handled = true;
      }
      else
      {
        if (e.KeyChar != '\r')
          return;
        this.ClientTab.spellMonsters.Focus();
      }
    }

    private void monstername_LostFocus(object sender, EventArgs e) => this.Text = this.monstername.Text;

    private void pramhtype_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.pramh.Checked)
        this.pramhwith = Server.SpellList[this.pramhtype.Text];
      else
        this.pramhwith = (SpellData) null;
    }

    private void cradhtype_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.cradh.Checked)
        this.cursewith = Server.SpellList[this.cradhtype.Text];
      else
        this.cursewith = (SpellData) null;
    }

    private void fastype_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.fas.Checked)
        this.faswith = Server.SpellList[this.fastype.Text];
      else
        this.faswith = (SpellData) null;
    }

    private void attack1type_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.attack1.Checked)
      {
        if (this.attack1type.Text.Equals("Keeter"))
        {
          foreach (Spell spell in this.ClientTab.Client.SpellBook)
          {
            if (spell != null && spell.Name.Contains("Keeter"))
            {
              this.attackwith = Server.SpellList[spell.Name];
              break;
            }
          }
        }
        else if (this.attack1type.Text.Equals("Mermaid"))
        {
          foreach (Spell spell in this.ClientTab.Client.SpellBook)
          {
            if (spell != null && spell.Name.Contains("Mermaid"))
            {
              this.attackwith = Server.SpellList[spell.Name];
              break;
            }
          }
        }
        else if (this.attack1type.Text.Equals("Torch"))
        {
          foreach (Spell spell in this.ClientTab.Client.SpellBook)
          {
            if (spell != null && spell.Name.Contains("Torch"))
            {
              this.attackwith = Server.SpellList[spell.Name];
              break;
            }
          }
        }
        else if (this.attack1type.Text.Equals("Groo"))
        {
          foreach (Spell spell in this.ClientTab.Client.SpellBook)
          {
            if (spell != null && spell.Name.Contains("Groo"))
            {
              this.attackwith = Server.SpellList[spell.Name];
              break;
            }
          }
        }
        else if (this.attack1type.Text.Equals("Frost + 3 Shocks"))
        {
          foreach (Spell spell in this.ClientTab.Client.SpellBook)
          {
            if (spell != null && spell.Name.Contains("Frost Arrow"))
            {
              this.attackwith = Server.SpellList[spell.Name];
              break;
            }
          }
        }
        else if (this.attack1type.Text.Equals("Frost Arrow"))
        {
          foreach (Spell spell in this.ClientTab.Client.SpellBook)
          {
            if (spell != null && spell.Name.Contains("Frost Arrow"))
            {
              this.attackwith = Server.SpellList[spell.Name];
              break;
            }
          }
        }
        else if (this.attack1type.Text.Equals("Star Arrow"))
        {
          foreach (Spell spell in this.ClientTab.Client.SpellBook)
          {
            if (spell != null && spell.Name.Contains("Star Arrow") && spell.Name != "Star Arrow 11")
            {
              this.attackwith = Server.SpellList[spell.Name];
              break;
            }
          }
        }
        else if (this.attack1type.Text.Equals("Hail of Feathers"))
        {
          foreach (Spell spell in this.ClientTab.Client.SpellBook)
          {
            if (spell != null && spell.Name.Contains("Hail of Feathers"))
            {
              this.attackwith = Server.SpellList[spell.Name];
              break;
            }
          }
        }
        else
          this.attackwith = Server.SpellList[this.attack1type.Text];
      }
      else
        this.attackwith = (SpellData) null;
    }

    private void attack2type_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.attack2.Checked)
      {
        if (this.attack2type.Text.Equals("Cursed Tune"))
        {
          foreach (Spell spell in this.ClientTab.Client.SpellBook)
          {
            if (spell != null && spell.Name.Contains("Cursed Tune"))
            {
              this.secattackwith = Server.SpellList[spell.Name];
              break;
            }
          }
        }
        else
          this.secattackwith = Server.SpellList[this.attack2type.Text];
      }
      else
        this.secattackwith = (SpellData) null;
    }

    private void fas_CheckedChanged(object sender, EventArgs e)
    {
      if (this.fas.Checked)
        this.faswith = Server.SpellList[this.fastype.Text];
      else
        this.faswith = (SpellData) null;
    }

    private void pramh_CheckedChanged(object sender, EventArgs e)
    {
      if (this.pramh.Checked)
      {
        this.attackafterpramh.Enabled = true;
        this.pramhwith = Server.SpellList[this.pramhtype.Text];
      }
      else
      {
        this.attackafterpramh.Enabled = false;
        this.attackafterpramh.Checked = false;
        this.pramhwith = (SpellData) null;
      }
    }

    private void cradh_CheckedChanged(object sender, EventArgs e)
    {
      if (this.cradh.Checked)
        this.cursewith = Server.SpellList[this.cradhtype.Text];
      else
        this.cursewith = (SpellData) null;
    }

    private void attack1_CheckedChanged(object sender, EventArgs e)
    {
      if (this.attack1.Checked)
      {
        if (this.attack1type.Text.Equals("Keeter"))
        {
          foreach (Spell spell in this.ClientTab.Client.SpellBook)
          {
            if (spell != null && spell.Name.Contains("Keeter"))
            {
              this.attackwith = Server.SpellList[spell.Name];
              break;
            }
          }
        }
        else if (this.attack1type.Text.Equals("Mermaid"))
        {
          foreach (Spell spell in this.ClientTab.Client.SpellBook)
          {
            if (spell != null && spell.Name.Contains("Mermaid"))
            {
              this.attackwith = Server.SpellList[spell.Name];
              break;
            }
          }
        }
        else if (this.attack1type.Text.Equals("Torch"))
        {
          foreach (Spell spell in this.ClientTab.Client.SpellBook)
          {
            if (spell != null && spell.Name.Contains("Torch"))
            {
              this.attackwith = Server.SpellList[spell.Name];
              break;
            }
          }
        }
        else if (this.attack1type.Text.Equals("Groo"))
        {
          foreach (Spell spell in this.ClientTab.Client.SpellBook)
          {
            if (spell != null && spell.Name.Contains("Groo"))
            {
              this.attackwith = Server.SpellList[spell.Name];
              break;
            }
          }
        }
        else if (this.attack1type.Text.Equals("Frost + 3 Shocks"))
        {
          foreach (Spell spell in this.ClientTab.Client.SpellBook)
          {
            if (spell != null && spell.Name.Contains("Frost Arrow"))
            {
              this.attackwith = Server.SpellList[spell.Name];
              break;
            }
          }
        }
        else if (this.attack1type.Text.Equals("Frost Arrow"))
        {
          foreach (Spell spell in this.ClientTab.Client.SpellBook)
          {
            if (spell != null && spell.Name.Contains("Frost Arrow"))
            {
              this.attackwith = Server.SpellList[spell.Name];
              break;
            }
          }
        }
        else if (this.attack1type.Text.Equals("Star Arrow"))
        {
          foreach (Spell spell in this.ClientTab.Client.SpellBook)
          {
            if (spell != null && spell.Name.Contains("Star Arrow") && spell.Name != "Star Arrow 11")
            {
              this.attackwith = Server.SpellList[spell.Name];
              break;
            }
          }
        }
        else if (this.attack1type.Text.Equals("Hail of Feathers"))
        {
          foreach (Spell spell in this.ClientTab.Client.SpellBook)
          {
            if (spell != null && spell.Name.Contains("Hail of Feathers"))
            {
              this.attackwith = Server.SpellList[spell.Name];
              break;
            }
          }
        }
        else
          this.attackwith = Server.SpellList[this.attack1type.Text];
      }
      else
        this.attackwith = (SpellData) null;
    }

    private void attack2_CheckedChanged(object sender, EventArgs e)
    {
      if (this.attack2.Checked)
      {
        if (this.attack2type.Text.Equals("Cursed Tune"))
        {
          foreach (Spell spell in this.ClientTab.Client.SpellBook)
          {
            if (spell != null && spell.Name.Contains("Cursed Tune"))
            {
              this.secattackwith = Server.SpellList[spell.Name];
              break;
            }
          }
        }
        else
          this.secattackwith = Server.SpellList[this.attack2type.Text];
      }
      else
        this.secattackwith = (SpellData) null;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.label1 = new Label();
      this.monstername = new TextBox();
      this.removemonster = new Button();
      this.groupBox4 = new GroupBox();
      this.spampramh = new CheckBox();
      this.pramhtype = new ComboBox();
      this.pramh = new CheckBox();
      this.attackafterpramh = new CheckBox();
      this.groupBox3 = new GroupBox();
      this.multi = new CheckBox();
      this.spellsilenced = new CheckBox();
      this.attack2type = new ComboBox();
      this.attack1type = new ComboBox();
      this.attack2 = new CheckBox();
      this.attack1 = new CheckBox();
      this.groupBox2 = new GroupBox();
      this.spamfascurse = new CheckBox();
      this.fasamancrystals = new CheckBox();
      this.fastype = new ComboBox();
      this.cradhtype = new ComboBox();
      this.fas = new CheckBox();
      this.cradh = new CheckBox();
      this.groupBox1 = new GroupBox();
      this.fascursetargettype = new ComboBox();
      this.groupBox6 = new GroupBox();
      this.ctd = new CheckBox();
      this.groupedmembersrange = new NumericUpDown();
      this.groupedmembers = new CheckBox();
      this.pramhedonly = new CheckBox();
      this.fasedonly = new CheckBox();
      this.ardedonly = new CheckBox();
      this.label2 = new Label();
      this.label3 = new Label();
      this.targettype = new ComboBox();
      this.heal = new CheckBox();
      this.aite = new CheckBox();
      this.healnum = new NumericUpDown();
      this.diondonly = new CheckBox();
      this.groupBox4.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.groupBox6.SuspendLayout();
      this.groupedmembersrange.BeginInit();
      this.healnum.BeginInit();
      this.SuspendLayout();
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(20, 15);
      this.label1.Name = "label1";
      this.label1.Size = new Size(42, 15);
      this.label1.TabIndex = 26;
      this.label1.Text = "Image";
      this.monstername.Location = new System.Drawing.Point(69, 12);
      this.monstername.MaxLength = 25;
      this.monstername.Name = "monstername";
      this.monstername.ReadOnly = true;
      this.monstername.Size = new Size(65, 21);
      this.monstername.TabIndex = 27;
      this.monstername.KeyPress += new KeyPressEventHandler(this.monstername_KeyPress);
      this.monstername.Leave += new EventHandler(this.monstername_LostFocus);
      this.monstername.LostFocus += new EventHandler(this.monstername_LostFocus);
      this.removemonster.Location = new System.Drawing.Point(452, 260);
      this.removemonster.Name = "removemonster";
      this.removemonster.Size = new Size(134, 33);
      this.removemonster.TabIndex = 28;
      this.removemonster.Text = "Remove This Target";
      this.removemonster.UseVisualStyleBackColor = true;
      this.removemonster.Click += new EventHandler(this.removemonster_Click);
      this.groupBox4.Controls.Add((Control) this.spampramh);
      this.groupBox4.Controls.Add((Control) this.pramhtype);
      this.groupBox4.Controls.Add((Control) this.pramh);
      this.groupBox4.Controls.Add((Control) this.attackafterpramh);
      this.groupBox4.Location = new System.Drawing.Point(3, 219);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new Size(247, 74);
      this.groupBox4.TabIndex = 41;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = "Pramh Settings";
      this.spampramh.AutoSize = true;
      this.spampramh.Location = new System.Drawing.Point(167, 23);
      this.spampramh.Name = "spampramh";
      this.spampramh.Size = new Size(53, 17);
      this.spampramh.TabIndex = 15;
      this.spampramh.Text = "Spam";
      this.spampramh.UseVisualStyleBackColor = true;
      this.pramhtype.DropDownStyle = ComboBoxStyle.DropDownList;
      this.pramhtype.Font = new Font("Arial", 9f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.pramhtype.FormattingEnabled = true;
      this.pramhtype.Location = new System.Drawing.Point(36, 21);
      this.pramhtype.Name = "pramhtype";
      this.pramhtype.Size = new Size(125, 23);
      this.pramhtype.TabIndex = 1;
      this.pramhtype.SelectedIndexChanged += new EventHandler(this.pramhtype_SelectedIndexChanged);
      this.pramh.AutoSize = true;
      this.pramh.Location = new System.Drawing.Point(15, 25);
      this.pramh.Name = "pramh";
      this.pramh.Size = new Size(15, 14);
      this.pramh.TabIndex = 0;
      this.pramh.UseVisualStyleBackColor = true;
      this.pramh.CheckedChanged += new EventHandler(this.pramh_CheckedChanged);
      this.attackafterpramh.AutoSize = true;
      this.attackafterpramh.Enabled = false;
      this.attackafterpramh.Location = new System.Drawing.Point(36, 50);
      this.attackafterpramh.Name = "attackafterpramh";
      this.attackafterpramh.Size = new Size(136, 17);
      this.attackafterpramh.TabIndex = 14;
      this.attackafterpramh.Text = "pramh before fas/curse";
      this.attackafterpramh.UseVisualStyleBackColor = true;
      this.groupBox3.Controls.Add((Control) this.multi);
      this.groupBox3.Controls.Add((Control) this.spellsilenced);
      this.groupBox3.Controls.Add((Control) this.attack2type);
      this.groupBox3.Controls.Add((Control) this.attack1type);
      this.groupBox3.Controls.Add((Control) this.attack2);
      this.groupBox3.Controls.Add((Control) this.attack1);
      this.groupBox3.Location = new System.Drawing.Point(256, 131);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new Size(330, 117);
      this.groupBox3.TabIndex = 40;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Attack With";
      this.multi.AutoSize = true;
      this.multi.Location = new System.Drawing.Point(212, 50);
      this.multi.Name = "multi";
      this.multi.Size = new Size(101, 17);
      this.multi.TabIndex = 5;
      this.multi.Text = "Multiple Targets";
      this.multi.UseVisualStyleBackColor = true;
      this.spellsilenced.AutoSize = true;
      this.spellsilenced.Location = new System.Drawing.Point(42, 50);
      this.spellsilenced.Name = "spellsilenced";
      this.spellsilenced.Size = new Size(125, 17);
      this.spellsilenced.TabIndex = 4;
      this.spellsilenced.Text = "Mspg whilst Silenced";
      this.spellsilenced.UseVisualStyleBackColor = true;
      this.attack2type.DropDownStyle = ComboBoxStyle.DropDownList;
      this.attack2type.Font = new Font("Arial", 9f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.attack2type.FormattingEnabled = true;
      this.attack2type.Location = new System.Drawing.Point(42, 75);
      this.attack2type.Name = "attack2type";
      this.attack2type.Size = new Size(179, 23);
      this.attack2type.TabIndex = 3;
      this.attack2type.SelectedIndexChanged += new EventHandler(this.attack2type_SelectedIndexChanged);
      this.attack1type.DropDownStyle = ComboBoxStyle.DropDownList;
      this.attack1type.Font = new Font("Arial", 9f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.attack1type.FormattingEnabled = true;
      this.attack1type.Location = new System.Drawing.Point(42, 20);
      this.attack1type.Name = "attack1type";
      this.attack1type.Size = new Size(179, 23);
      this.attack1type.TabIndex = 2;
      this.attack1type.SelectedIndexChanged += new EventHandler(this.attack1type_SelectedIndexChanged);
      this.attack2.AutoSize = true;
      this.attack2.Location = new System.Drawing.Point(21, 79);
      this.attack2.Name = "attack2";
      this.attack2.Size = new Size(15, 14);
      this.attack2.TabIndex = 1;
      this.attack2.UseVisualStyleBackColor = true;
      this.attack2.CheckedChanged += new EventHandler(this.attack2_CheckedChanged);
      this.attack1.AutoSize = true;
      this.attack1.Location = new System.Drawing.Point(21, 24);
      this.attack1.Name = "attack1";
      this.attack1.Size = new Size(15, 14);
      this.attack1.TabIndex = 0;
      this.attack1.UseVisualStyleBackColor = true;
      this.attack1.CheckedChanged += new EventHandler(this.attack1_CheckedChanged);
      this.groupBox2.Controls.Add((Control) this.spamfascurse);
      this.groupBox2.Controls.Add((Control) this.fasamancrystals);
      this.groupBox2.Controls.Add((Control) this.fastype);
      this.groupBox2.Controls.Add((Control) this.cradhtype);
      this.groupBox2.Controls.Add((Control) this.fas);
      this.groupBox2.Controls.Add((Control) this.cradh);
      this.groupBox2.Location = new System.Drawing.Point(3, 112);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new Size(247, 107);
      this.groupBox2.TabIndex = 39;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Curse, Fas Settings";
      this.spamfascurse.AutoSize = true;
      this.spamfascurse.Location = new System.Drawing.Point(167, 44);
      this.spamfascurse.Name = "spamfascurse";
      this.spamfascurse.Size = new Size(53, 17);
      this.spamfascurse.TabIndex = 7;
      this.spamfascurse.Text = "Spam";
      this.spamfascurse.UseVisualStyleBackColor = true;
      this.fasamancrystals.AutoSize = true;
      this.fasamancrystals.Location = new System.Drawing.Point(36, 84);
      this.fasamancrystals.Name = "fasamancrystals";
      this.fasamancrystals.Size = new Size(112, 17);
      this.fasamancrystals.TabIndex = 15;
      this.fasamancrystals.Text = "Fas Aman Crystals";
      this.fasamancrystals.UseVisualStyleBackColor = true;
      this.fastype.DropDownStyle = ComboBoxStyle.DropDownList;
      this.fastype.Font = new Font("Arial", 9f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.fastype.FormattingEnabled = true;
      this.fastype.Location = new System.Drawing.Point(36, 55);
      this.fastype.Name = "fastype";
      this.fastype.Size = new Size(125, 23);
      this.fastype.TabIndex = 14;
      this.fastype.SelectedIndexChanged += new EventHandler(this.fastype_SelectedIndexChanged);
      this.cradhtype.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cradhtype.Font = new Font("Arial", 9f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.cradhtype.FormattingEnabled = true;
      this.cradhtype.Location = new System.Drawing.Point(36, 26);
      this.cradhtype.Name = "cradhtype";
      this.cradhtype.Size = new Size(125, 23);
      this.cradhtype.TabIndex = 13;
      this.cradhtype.SelectedIndexChanged += new EventHandler(this.cradhtype_SelectedIndexChanged);
      this.fas.AutoSize = true;
      this.fas.Location = new System.Drawing.Point(15, 59);
      this.fas.Name = "fas";
      this.fas.Size = new Size(15, 14);
      this.fas.TabIndex = 12;
      this.fas.UseVisualStyleBackColor = true;
      this.fas.CheckedChanged += new EventHandler(this.fas_CheckedChanged);
      this.cradh.AutoSize = true;
      this.cradh.Location = new System.Drawing.Point(15, 30);
      this.cradh.Name = "cradh";
      this.cradh.Size = new Size(15, 14);
      this.cradh.TabIndex = 11;
      this.cradh.UseVisualStyleBackColor = true;
      this.cradh.CheckedChanged += new EventHandler(this.cradh_CheckedChanged);
      this.groupBox1.Controls.Add((Control) this.fascursetargettype);
      this.groupBox1.Location = new System.Drawing.Point(3, 49);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(247, 57);
      this.groupBox1.TabIndex = 38;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Curse, Fas Targeting";
      this.fascursetargettype.DropDownStyle = ComboBoxStyle.DropDownList;
      this.fascursetargettype.Font = new Font("Arial", 9f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.fascursetargettype.FormattingEnabled = true;
      this.fascursetargettype.Items.AddRange(new object[3]
      {
        (object) "Fas all, then curse all",
        (object) "Spell 1 only",
        (object) "Fas/curse 1, then the next"
      });
      this.fascursetargettype.Location = new System.Drawing.Point(15, 25);
      this.fascursetargettype.Name = "fascursetargettype";
      this.fascursetargettype.Size = new Size(182, 23);
      this.fascursetargettype.TabIndex = 6;
      this.groupBox6.Controls.Add((Control) this.diondonly);
      this.groupBox6.Controls.Add((Control) this.ctd);
      this.groupBox6.Controls.Add((Control) this.groupedmembersrange);
      this.groupBox6.Controls.Add((Control) this.groupedmembers);
      this.groupBox6.Controls.Add((Control) this.pramhedonly);
      this.groupBox6.Controls.Add((Control) this.fasedonly);
      this.groupBox6.Controls.Add((Control) this.ardedonly);
      this.groupBox6.Location = new System.Drawing.Point(256, 49);
      this.groupBox6.Name = "groupBox6";
      this.groupBox6.Size = new Size(330, 76);
      this.groupBox6.TabIndex = 36;
      this.groupBox6.TabStop = false;
      this.groupBox6.Text = "Only attack monsters that have";
      this.ctd.AutoSize = true;
      this.ctd.Location = new System.Drawing.Point(209, 21);
      this.ctd.Name = "ctd";
      this.ctd.Size = new Size(42, 19);
      this.ctd.TabIndex = 31;
      this.ctd.Text = "CT";
      this.ctd.UseVisualStyleBackColor = true;
      this.groupedmembersrange.Location = new System.Drawing.Point(278, 45);
      this.groupedmembersrange.Name = "groupedmembersrange";
      this.groupedmembersrange.Size = new Size(46, 21);
      this.groupedmembersrange.TabIndex = 30;
      this.groupedmembersrange.Value = new Decimal(new int[4]
      {
        7,
        0,
        0,
        0
      });
      this.groupedmembers.AutoSize = true;
      this.groupedmembers.Location = new System.Drawing.Point(21, 46);
      this.groupedmembers.Name = "groupedmembers";
      this.groupedmembers.Size = new Size(257, 19);
      this.groupedmembers.TabIndex = 29;
      this.groupedmembers.Text = "Only attack if Group members are in range";
      this.groupedmembers.UseVisualStyleBackColor = true;
      this.pramhedonly.AutoSize = true;
      this.pramhedonly.Location = new System.Drawing.Point(140, 21);
      this.pramhedonly.Name = "pramhedonly";
      this.pramhedonly.Size = new Size(63, 19);
      this.pramhedonly.TabIndex = 22;
      this.pramhedonly.Text = "Pramh";
      this.pramhedonly.UseVisualStyleBackColor = true;
      this.fasedonly.AutoSize = true;
      this.fasedonly.Location = new System.Drawing.Point(87, 21);
      this.fasedonly.Name = "fasedonly";
      this.fasedonly.Size = new Size(47, 19);
      this.fasedonly.TabIndex = 21;
      this.fasedonly.Text = "Fas";
      this.fasedonly.UseVisualStyleBackColor = true;
      this.ardedonly.AutoSize = true;
      this.ardedonly.Location = new System.Drawing.Point(21, 21);
      this.ardedonly.Name = "ardedonly";
      this.ardedonly.Size = new Size(60, 19);
      this.ardedonly.TabIndex = 20;
      this.ardedonly.Text = "Curse";
      this.ardedonly.UseVisualStyleBackColor = true;
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(396, 15);
      this.label2.Name = "label2";
      this.label2.Size = new Size(140, 15);
      this.label2.TabIndex = 44;
      this.label2.Text = "(curse/fas/attack/pramh)";
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(169, 15);
      this.label3.Name = "label3";
      this.label3.Size = new Size(92, 15);
      this.label3.TabIndex = 43;
      this.label3.Text = "Main target type";
      this.targettype.DropDownStyle = ComboBoxStyle.DropDownList;
      this.targettype.Font = new Font("Arial", 9f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.targettype.FormattingEnabled = true;
      this.targettype.Items.AddRange(new object[5]
      {
        (object) "Nearest",
        (object) "Farthest",
        (object) "Largest group",
        (object) "Highest Hp",
        (object) "Lowest Hp"
      });
      this.targettype.Location = new System.Drawing.Point(269, 12);
      this.targettype.Name = "targettype";
      this.targettype.Size = new Size(121, 23);
      this.targettype.TabIndex = 42;
      this.heal.AutoSize = true;
      this.heal.Location = new System.Drawing.Point(256, 260);
      this.heal.Name = "heal";
      this.heal.Size = new Size(52, 19);
      this.heal.TabIndex = 45;
      this.heal.Text = "Heal";
      this.heal.UseVisualStyleBackColor = true;
      this.aite.AutoSize = true;
      this.aite.Location = new System.Drawing.Point(377, 260);
      this.aite.Name = "aite";
      this.aite.Size = new Size(46, 19);
      this.aite.TabIndex = 46;
      this.aite.Text = "Aite";
      this.aite.UseVisualStyleBackColor = true;
      this.healnum.Increment = new Decimal(new int[4]
      {
        20,
        0,
        0,
        0
      });
      this.healnum.Location = new System.Drawing.Point(314, 259);
      this.healnum.Name = "healnum";
      this.healnum.Size = new Size(45, 21);
      this.healnum.TabIndex = 47;
      this.healnum.Value = new Decimal(new int[4]
      {
        60,
        0,
        0,
        0
      });
      this.diondonly.AutoSize = true;
      this.diondonly.Location = new System.Drawing.Point(257, 21);
      this.diondonly.Name = "diondonly";
      this.diondonly.Size = new Size(50, 19);
      this.diondonly.TabIndex = 32;
      this.diondonly.Text = "dion";
      this.diondonly.UseVisualStyleBackColor = true;
      this.BackColor = Color.White;
      this.ClientSize = new Size(598, 299);
      this.Controls.Add((Control) this.healnum);
      this.Controls.Add((Control) this.aite);
      this.Controls.Add((Control) this.heal);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.targettype);
      this.Controls.Add((Control) this.groupBox4);
      this.Controls.Add((Control) this.groupBox3);
      this.Controls.Add((Control) this.groupBox2);
      this.Controls.Add((Control) this.groupBox1);
      this.Controls.Add((Control) this.groupBox6);
      this.Controls.Add((Control) this.removemonster);
      this.Controls.Add((Control) this.monstername);
      this.Controls.Add((Control) this.label1);
      this.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Name =  "targetMonster";
      this.groupBox4.ResumeLayout(false);
      this.groupBox4.PerformLayout();
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      this.groupBox6.ResumeLayout(false);
      this.groupBox6.PerformLayout();
      this.groupedmembersrange.EndInit();
      this.healnum.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
