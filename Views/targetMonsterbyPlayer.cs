//SlowPoke
// Type: Flintstones.targetMonsterbyPlayer
//SlowPoke
//SlowPoke
//SlowPoke

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Flintstones
{
  public class targetMonsterbyPlayer : TabPage
  {
    public SpellData secattackwith;
    public SpellData attackwith;
    public string myTarget = string.Empty;
    private IContainer components;
    private Button removemonster;
    private GroupBox groupBox3;
    public CheckBox spellsilenced;
    public ComboBox attack2type;
    public ComboBox attack1type;
    public CheckBox attack2;
    public CheckBox attack1;

    public ClientTab ClientTab { get; private set; }

    public targetMonsterbyPlayer(string title, ClientTab clienttab)
    {
      this.myTarget = title;
      this.InitializeComponent();
      this.Text = this.myTarget + "'s target";
      this.ClientTab = clienttab;
      this.BestAttacks1();
      this.BestAttacks2();
    }

    public void BestAttacks1()
    {
      int num = 0;
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

    private void removeallmonsters_Click(object sender, EventArgs e)
    {
      --this.ClientTab.spellMonsters.SelectedIndex;
      this.ClientTab.spellMonsters.TabPages.Remove((TabPage) this);
      this.ClientTab.MonstersByPlayer = (targetMonsterbyPlayer) null;
      this.ClientTab.newmonster.Enabled = true;
      this.ClientTab.newallmonsters.Enabled = true;
      this.ClientTab.newmonsterbyplayer.Enabled = true;
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
      this.removemonster = new Button();
      this.groupBox3 = new GroupBox();
      this.spellsilenced = new CheckBox();
      this.attack2type = new ComboBox();
      this.attack1type = new ComboBox();
      this.attack2 = new CheckBox();
      this.attack1 = new CheckBox();
      this.groupBox3.SuspendLayout();
      this.SuspendLayout();
      this.removemonster.Location = new System.Drawing.Point(449, 254);
      this.removemonster.Name = "removemonster";
      this.removemonster.Size = new Size(137, 33);
      this.removemonster.TabIndex = 29;
      this.removemonster.Text = "Remove This Target";
      this.removemonster.UseVisualStyleBackColor = true;
      this.removemonster.Click += new EventHandler(this.removeallmonsters_Click);
      this.groupBox3.Controls.Add((Control) this.spellsilenced);
      this.groupBox3.Controls.Add((Control) this.attack2type);
      this.groupBox3.Controls.Add((Control) this.attack1type);
      this.groupBox3.Controls.Add((Control) this.attack2);
      this.groupBox3.Controls.Add((Control) this.attack1);
      this.groupBox3.Location = new System.Drawing.Point(166, 76);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new Size(249, 117);
      this.groupBox3.TabIndex = 31;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Attack With";
      this.spellsilenced.AutoSize = true;
      this.spellsilenced.Location = new System.Drawing.Point(42, 50);
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
      this.BackColor = Color.White;
      this.ClientSize = new Size(598, 299);
      this.Controls.Add((Control) this.groupBox3);
      this.Controls.Add((Control) this.removemonster);
      this.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Name =  "targetMonsterbyPlayer";
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.ResumeLayout(false);
    }
  }
}
