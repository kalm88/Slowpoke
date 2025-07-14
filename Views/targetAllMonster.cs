//SlowPoke
// Type: Flintstones.targetAllMonster
//SlowPoke
//SlowPoke
//SlowPoke

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Flintstones
{
  public class targetAllMonster : TabPage
  {
    public SpellData attackwith;
    public SpellData secattackwith;
    public SpellData cursewith = Server.SpellList["ard cradh"];
    public SpellData faswith = Server.SpellList["mor fas nadur"];
    public SpellData pramhwith;
    private IContainer components;
    private Label label1;
    public ComboBox targettype;
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
    private Button removeallmonsters;
    public GroupBox groupBox6;
    public CheckBox pramhedonly;
    public CheckBox fasedonly;
    public CheckBox ardedonly;
    public NumericUpDown spelllargestgroupnumber;
    public CheckBox spelllargestgroup;
    public NumericUpDown groupedmembersrange;
    public CheckBox groupedmembers;
    public CheckBox pndlowhp;
    public TextBox onlyattackwithmpamount;
    public CheckBox onlyattackwithmp;
    public CheckBox ctd;
    public CheckBox multi;
    public CheckBox diondonly;
    public CheckBox ignoredistant;
    public CheckBox pramhbasherstarget;
    public CheckBox pndbeforecurse;
    public CheckBox pndiond;

    public ClientTab ClientTab { get; private set; }

    public targetAllMonster(ClientTab clienttab)
    {
      this.InitializeComponent();
      this.Text = "All Monsters";
      this.ClientTab = clienttab;
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
      if (this.ClientTab.Client.YourAttacks1.Contains("Star + 3 Shocks"))
      {
        this.attack1type.Items.Add((object) "Star + 3 Shocks");
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

    private void removeallmonsters_Click(object sender, EventArgs e)
    {
      --this.ClientTab.spellMonsters.SelectedIndex;
      this.ClientTab.spellMonsters.TabPages.Remove((TabPage) this);
      this.ClientTab.allMonsters = (targetAllMonster) null;
      this.ClientTab.newmonster.Enabled = true;
      this.ClientTab.newallmonsters.Enabled = true;
      this.ClientTab.newmonsterbyplayer.Enabled = true;
      this.ClientTab.createnewmonster.Enabled = true;
    }

    private void pramh_CheckedChanged(object sender, EventArgs e)
    {
      if (this.pramh.Checked)
      {
        this.pramhbasherstarget.Checked = false;
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
            if (spell != null && spell.Name.Contains("Star Arrow"))
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

    private void cradh_CheckedChanged(object sender, EventArgs e)
    {
      if (this.cradh.Checked)
        this.cursewith = Server.SpellList[this.cradhtype.Text];
      else
        this.cursewith = (SpellData) null;
    }

    private void fas_CheckedChanged(object sender, EventArgs e)
    {
      if (this.fas.Checked)
        this.faswith = Server.SpellList[this.fastype.Text];
      else
        this.faswith = (SpellData) null;
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
        else if (this.attack1type.Text.Equals("Star + 3 Shocks"))
        {
          foreach (Spell spell in this.ClientTab.Client.SpellBook)
          {
            if (spell != null && spell.Name.Contains("Star Arrow"))
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
            if (spell != null && spell.Name.Contains("Star Arrow"))
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
      if (this.attack2.Checked && this.attack2type.Text != string.Empty)
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

    private void pramhbasherstarget_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.pramhbasherstarget.Checked)
        return;
      this.pramh.Checked = false;
      this.attackafterpramh.Checked = false;
    }

    private void attackafterpramh_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.attackafterpramh.Checked)
        return;
      this.pramhbasherstarget.Checked = false;
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
      this.targettype = new ComboBox();
      this.groupBox4 = new GroupBox();
      this.spampramh = new CheckBox();
      this.pramhtype = new ComboBox();
      this.pramh = new CheckBox();
      this.attackafterpramh = new CheckBox();
      this.groupBox3 = new GroupBox();
      this.pndbeforecurse = new CheckBox();
      this.multi = new CheckBox();
      this.onlyattackwithmpamount = new TextBox();
      this.onlyattackwithmp = new CheckBox();
      this.pndlowhp = new CheckBox();
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
      this.ignoredistant = new CheckBox();
      this.spelllargestgroupnumber = new NumericUpDown();
      this.spelllargestgroup = new CheckBox();
      this.fascursetargettype = new ComboBox();
      this.removeallmonsters = new Button();
      this.groupBox6 = new GroupBox();
      this.diondonly = new CheckBox();
      this.ctd = new CheckBox();
      this.groupedmembersrange = new NumericUpDown();
      this.groupedmembers = new CheckBox();
      this.pramhedonly = new CheckBox();
      this.fasedonly = new CheckBox();
      this.ardedonly = new CheckBox();
      this.pramhbasherstarget = new CheckBox();
      this.pndiond = new CheckBox();
      this.groupBox4.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.spelllargestgroupnumber.BeginInit();
      this.groupBox6.SuspendLayout();
      this.groupedmembersrange.BeginInit();
      this.SuspendLayout();
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(256, 9);
      this.label1.Name = "label1";
      this.label1.Size = new Size(210, 15);
      this.label1.TabIndex = 37;
      this.label1.Text = "Main target type (applies to all spells)";
      this.targettype.DropDownStyle = ComboBoxStyle.DropDownList;
      this.targettype.Font = new Font("Arial", 9f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.targettype.FormattingEnabled = true;
      this.targettype.Items.AddRange(new object[4]
      {
        (object) "Nearest",
        (object) "Farthest",
        (object) "Highest Hp",
        (object) "Lowest Hp"
      });
      this.targettype.Location = new System.Drawing.Point(472, 6);
      this.targettype.Name = "targettype";
      this.targettype.Size = new Size(121, 23);
      this.targettype.TabIndex = 34;
      this.groupBox4.Controls.Add((Control) this.spampramh);
      this.groupBox4.Controls.Add((Control) this.pramhtype);
      this.groupBox4.Controls.Add((Control) this.pramh);
      this.groupBox4.Location = new System.Drawing.Point(2, 239);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new Size(247, 52);
      this.groupBox4.TabIndex = 36;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = "Pramh Settings";
      this.spampramh.AutoSize = true;
      this.spampramh.Location = new System.Drawing.Point(167, 23);
      this.spampramh.Name = "spampramh";
      this.spampramh.Size = new Size(59, 19);
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
      this.attackafterpramh.Location = new System.Drawing.Point((int) byte.MaxValue, 254);
      this.attackafterpramh.Name = "attackafterpramh";
      this.attackafterpramh.Size = new Size(154, 19);
      this.attackafterpramh.TabIndex = 14;
      this.attackafterpramh.Text = "pramh before fas/curse";
      this.attackafterpramh.UseVisualStyleBackColor = true;
      this.attackafterpramh.CheckedChanged += new EventHandler(this.attackafterpramh_CheckedChanged);
      this.groupBox3.Controls.Add((Control) this.pndiond);
      this.groupBox3.Controls.Add((Control) this.pndbeforecurse);
      this.groupBox3.Controls.Add((Control) this.multi);
      this.groupBox3.Controls.Add((Control) this.onlyattackwithmpamount);
      this.groupBox3.Controls.Add((Control) this.onlyattackwithmp);
      this.groupBox3.Controls.Add((Control) this.pndlowhp);
      this.groupBox3.Controls.Add((Control) this.spellsilenced);
      this.groupBox3.Controls.Add((Control) this.attack2type);
      this.groupBox3.Controls.Add((Control) this.attack1type);
      this.groupBox3.Controls.Add((Control) this.attack2);
      this.groupBox3.Controls.Add((Control) this.attack1);
      this.groupBox3.Location = new System.Drawing.Point((int) byte.MaxValue, 115);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new Size(338, 137);
      this.groupBox3.TabIndex = 35;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Attack With";
      this.pndbeforecurse.AutoSize = true;
      this.pndbeforecurse.Location = new System.Drawing.Point(232, 77);
      this.pndbeforecurse.Name = "pndbeforecurse";
      this.pndbeforecurse.Size = new Size(103, 19);
      this.pndbeforecurse.TabIndex = 42;
      this.pndbeforecurse.Text = "PND b4 curse";
      this.pndbeforecurse.UseVisualStyleBackColor = true;
      this.multi.AutoSize = true;
      this.multi.Location = new System.Drawing.Point(232, 24);
      this.multi.Name = "multi";
      this.multi.Size = new Size(95, 19);
      this.multi.TabIndex = 41;
      this.multi.Text = "Multi Targets";
      this.multi.UseVisualStyleBackColor = true;
      this.onlyattackwithmpamount.Location = new System.Drawing.Point(150, 48);
      this.onlyattackwithmpamount.Name = "onlyattackwithmpamount";
      this.onlyattackwithmpamount.Size = new Size(49, 21);
      this.onlyattackwithmpamount.TabIndex = 40;
      this.onlyattackwithmpamount.Text = "10000";
      this.onlyattackwithmp.AutoSize = true;
      this.onlyattackwithmp.Location = new System.Drawing.Point(21, 50);
      this.onlyattackwithmp.Name = "onlyattackwithmp";
      this.onlyattackwithmp.Size = new Size(123, 19);
      this.onlyattackwithmp.TabIndex = 39;
      this.onlyattackwithmp.Text = "Only Attack if MP >";
      this.onlyattackwithmp.UseVisualStyleBackColor = true;
      this.pndlowhp.AutoSize = true;
      this.pndlowhp.Location = new System.Drawing.Point(232, 104);
      this.pndlowhp.Name = "pndlowhp";
      this.pndlowhp.Size = new Size(94, 19);
      this.pndlowhp.TabIndex = 39;
      this.pndlowhp.Text = "PND low HP";
      this.pndlowhp.UseVisualStyleBackColor = true;
      this.spellsilenced.AutoSize = true;
      this.spellsilenced.Location = new System.Drawing.Point(21, 104);
      this.spellsilenced.Name = "spellsilenced";
      this.spellsilenced.Size = new Size(142, 19);
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
      this.groupBox2.Location = new System.Drawing.Point(2, 125);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new Size(247, 108);
      this.groupBox2.TabIndex = 33;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Curse, Fas Settings";
      this.spamfascurse.AutoSize = true;
      this.spamfascurse.Location = new System.Drawing.Point(167, 41);
      this.spamfascurse.Name = "spamfascurse";
      this.spamfascurse.Size = new Size(59, 19);
      this.spamfascurse.TabIndex = 7;
      this.spamfascurse.Text = "Spam";
      this.spamfascurse.UseVisualStyleBackColor = true;
      this.fasamancrystals.AutoSize = true;
      this.fasamancrystals.Location = new System.Drawing.Point(27, 83);
      this.fasamancrystals.Name = "fasamancrystals";
      this.fasamancrystals.Size = new Size(214, 19);
      this.fasamancrystals.TabIndex = 15;
      this.fasamancrystals.Text = "Fas Aman Crystals (Ignore Monks)";
      this.fasamancrystals.UseVisualStyleBackColor = true;
      this.fastype.DropDownStyle = ComboBoxStyle.DropDownList;
      this.fastype.Font = new Font("Arial", 9f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.fastype.FormattingEnabled = true;
      this.fastype.Location = new System.Drawing.Point(36, 55);
      this.fastype.Name = "fastype";
      this.fastype.Size = new Size(126, 23);
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
      this.groupBox1.Controls.Add((Control) this.ignoredistant);
      this.groupBox1.Controls.Add((Control) this.spelllargestgroupnumber);
      this.groupBox1.Controls.Add((Control) this.spelllargestgroup);
      this.groupBox1.Controls.Add((Control) this.fascursetargettype);
      this.groupBox1.Location = new System.Drawing.Point(2, 9);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(247, 110);
      this.groupBox1.TabIndex = 32;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Curse, Fas Targeting";
      this.ignoredistant.AutoSize = true;
      this.ignoredistant.Location = new System.Drawing.Point(10, 80);
      this.ignoredistant.Name = "ignoredistant";
      this.ignoredistant.Size = new Size(231, 19);
      this.ignoredistant.TabIndex = 9;
      this.ignoredistant.Text = "Ignore distant monsters (for bashers)";
      this.ignoredistant.UseVisualStyleBackColor = true;
      this.spelllargestgroupnumber.Location = new System.Drawing.Point(206, 53);
      this.spelllargestgroupnumber.Name = "spelllargestgroupnumber";
      this.spelllargestgroupnumber.Size = new Size(35, 21);
      this.spelllargestgroupnumber.TabIndex = 8;
      this.spelllargestgroupnumber.Value = new Decimal(new int[4]
      {
        3,
        0,
        0,
        0
      });
      this.spelllargestgroup.AutoSize = true;
      this.spelllargestgroup.Location = new System.Drawing.Point(10, 54);
      this.spelllargestgroup.Name = "spelllargestgroup";
      this.spelllargestgroup.Size = new Size(193, 19);
      this.spelllargestgroup.TabIndex = 7;
      this.spelllargestgroup.Text = "Spell for SA/Summons (range)";
      this.spelllargestgroup.UseVisualStyleBackColor = true;
      this.fascursetargettype.DropDownStyle = ComboBoxStyle.DropDownList;
      this.fascursetargettype.Font = new Font("Arial", 9f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.fascursetargettype.FormattingEnabled = true;
      this.fascursetargettype.Items.AddRange(new object[3]
      {
        (object) "Fas all, then curse all",
        (object) "Spell 1 only",
        (object) "Fas/curse 1, then the next"
      });
      this.fascursetargettype.Location = new System.Drawing.Point(15, 20);
      this.fascursetargettype.Name = "fascursetargettype";
      this.fascursetargettype.Size = new Size(182, 23);
      this.fascursetargettype.TabIndex = 6;
      this.removeallmonsters.Location = new System.Drawing.Point(442, 258);
      this.removeallmonsters.Name = "removeallmonsters";
      this.removeallmonsters.Size = new Size(144, 33);
      this.removeallmonsters.TabIndex = 31;
      this.removeallmonsters.Text = "Remove This Target";
      this.removeallmonsters.UseVisualStyleBackColor = true;
      this.removeallmonsters.Click += new EventHandler(this.removeallmonsters_Click);
      this.groupBox6.Controls.Add((Control) this.diondonly);
      this.groupBox6.Controls.Add((Control) this.ctd);
      this.groupBox6.Controls.Add((Control) this.groupedmembersrange);
      this.groupBox6.Controls.Add((Control) this.groupedmembers);
      this.groupBox6.Controls.Add((Control) this.pramhedonly);
      this.groupBox6.Controls.Add((Control) this.fasedonly);
      this.groupBox6.Controls.Add((Control) this.ardedonly);
      this.groupBox6.Location = new System.Drawing.Point((int) byte.MaxValue, 35);
      this.groupBox6.Name = "groupBox6";
      this.groupBox6.Size = new Size(338, 74);
      this.groupBox6.TabIndex = 29;
      this.groupBox6.TabStop = false;
      this.groupBox6.Text = "Only attack monsters that have";
      this.diondonly.AutoSize = true;
      this.diondonly.Location = new System.Drawing.Point(257, 20);
      this.diondonly.Name = "diondonly";
      this.diondonly.Size = new Size(50, 19);
      this.diondonly.TabIndex = 29;
      this.diondonly.Text = "dion";
      this.diondonly.UseVisualStyleBackColor = true;
      this.ctd.AutoSize = true;
      this.ctd.Location = new System.Drawing.Point(209, 20);
      this.ctd.Name = "ctd";
      this.ctd.Size = new Size(42, 19);
      this.ctd.TabIndex = 28;
      this.ctd.Text = "CT";
      this.ctd.UseVisualStyleBackColor = true;
      this.groupedmembersrange.Location = new System.Drawing.Point(281, 44);
      this.groupedmembersrange.Name = "groupedmembersrange";
      this.groupedmembersrange.Size = new Size(46, 21);
      this.groupedmembersrange.TabIndex = 27;
      this.groupedmembersrange.Value = new Decimal(new int[4]
      {
        7,
        0,
        0,
        0
      });
      this.groupedmembers.AutoSize = true;
      this.groupedmembers.Location = new System.Drawing.Point(21, 45);
      this.groupedmembers.Name = "groupedmembers";
      this.groupedmembers.Size = new Size(257, 19);
      this.groupedmembers.TabIndex = 26;
      this.groupedmembers.Text = "Only attack if Group members are in range";
      this.groupedmembers.UseVisualStyleBackColor = true;
      this.pramhedonly.AutoSize = true;
      this.pramhedonly.Location = new System.Drawing.Point(140, 20);
      this.pramhedonly.Name = "pramhedonly";
      this.pramhedonly.Size = new Size(63, 19);
      this.pramhedonly.TabIndex = 22;
      this.pramhedonly.Text = "Pramh";
      this.pramhedonly.UseVisualStyleBackColor = true;
      this.fasedonly.AutoSize = true;
      this.fasedonly.Location = new System.Drawing.Point(87, 20);
      this.fasedonly.Name = "fasedonly";
      this.fasedonly.Size = new Size(47, 19);
      this.fasedonly.TabIndex = 21;
      this.fasedonly.Text = "Fas";
      this.fasedonly.UseVisualStyleBackColor = true;
      this.ardedonly.AutoSize = true;
      this.ardedonly.Location = new System.Drawing.Point(21, 20);
      this.ardedonly.Name = "ardedonly";
      this.ardedonly.Size = new Size(60, 19);
      this.ardedonly.TabIndex = 20;
      this.ardedonly.Text = "Curse";
      this.ardedonly.UseVisualStyleBackColor = true;
      this.pramhbasherstarget.AutoSize = true;
      this.pramhbasherstarget.Location = new System.Drawing.Point((int) byte.MaxValue, 272);
      this.pramhbasherstarget.Name = "pramhbasherstarget";
      this.pramhbasherstarget.Size = new Size(187, 19);
      this.pramhbasherstarget.TabIndex = 38;
      this.pramhbasherstarget.Text = "pramh bashers target until hit";
      this.pramhbasherstarget.UseVisualStyleBackColor = true;
      this.pramhbasherstarget.CheckedChanged += new EventHandler(this.pramhbasherstarget_CheckedChanged);
      this.pndiond.AutoSize = true;
      this.pndiond.Location = new System.Drawing.Point(232, 50);
      this.pndiond.Name = "pndiond";
      this.pndiond.Size = new Size(86, 19);
      this.pndiond.TabIndex = 43;
      this.pndiond.Text = "PND diond";
      this.pndiond.UseVisualStyleBackColor = true;
      this.BackColor = Color.White;
      this.ClientSize = new Size(598, 299);
      this.Controls.Add((Control) this.pramhbasherstarget);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.targettype);
      this.Controls.Add((Control) this.attackafterpramh);
      this.Controls.Add((Control) this.groupBox4);
      this.Controls.Add((Control) this.groupBox3);
      this.Controls.Add((Control) this.groupBox2);
      this.Controls.Add((Control) this.groupBox1);
      this.Controls.Add((Control) this.removeallmonsters);
      this.Controls.Add((Control) this.groupBox6);
      this.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Name =  "targetAllMonster";
      this.Text = "Form1";
      this.groupBox4.ResumeLayout(false);
      this.groupBox4.PerformLayout();
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.spelllargestgroupnumber.EndInit();
      this.groupBox6.ResumeLayout(false);
      this.groupBox6.PerformLayout();
      this.groupedmembersrange.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
