//SlowPoke
// Type: Flintstones.SpellPriority
//SlowPoke
//SlowPoke
//SlowPoke

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Flintstones
{
  public class SpellPriority : Form
  {
    private IContainer components;
    public CheckBox aopuinsein;
    public CheckBox aocradhs;
    public CheckBox beagcradh;
    private Label label1;
    public CheckBox wakescroll;
    public CheckBox disenchanter;
    public CheckBox lootitems;
    public CheckBox dropitems;

    public Client Client { get; private set; }

    public SpellPriority(Client client)
    {
      this.Client = client;
      this.InitializeComponent();
    }

    private void aopuinsin_CheckedChanged(object sender, EventArgs e)
    {
      if (this.aopuinsein.Checked)
        this.Client.aopuinseinbefore = false;
      else
        this.Client.aopuinseinbefore = true;
    }

    private void aocradhs_CheckedChanged(object sender, EventArgs e)
    {
      if (this.aocradhs.Checked)
        this.Client.aocradhsbefore = false;
      else
        this.Client.aocradhsbefore = true;
    }

    private void beagcradh_CheckedChanged(object sender, EventArgs e)
    {
      if (this.beagcradh.Checked)
        this.Client.beagcradhbefore = false;
      else
        this.Client.beagcradhbefore = true;
    }

    private void SpellPriority_FormClosing(object sender, FormClosingEventArgs e)
    {
      e.Cancel = true;
      this.Hide();
      this.Client.Tab.openpriorityform.Enabled = true;
    }

    private void wakescroll_CheckedChanged(object sender, EventArgs e)
    {
      if (this.wakescroll.Checked)
        this.Client.wakescrollbefore = false;
      else
        this.Client.wakescrollbefore = true;
    }

    private void disenchanter_CheckedChanged(object sender, EventArgs e)
    {
      if (this.disenchanter.Checked)
        this.Client.disbefore = false;
      else
        this.Client.disbefore = true;
    }

    private void lootitems_CheckedChanged(object sender, EventArgs e)
    {
      if (this.lootitems.Checked)
        this.Client.lootbefore = false;
      else
        this.Client.lootbefore = true;
    }

    private void dropitems_CheckedChanged(object sender, EventArgs e)
    {
      if (this.dropitems.Checked)
        this.Client.dropbefore = false;
      else
        this.Client.dropbefore = true;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.aopuinsein = new CheckBox();
      this.aocradhs = new CheckBox();
      this.beagcradh = new CheckBox();
      this.label1 = new Label();
      this.wakescroll = new CheckBox();
      this.disenchanter = new CheckBox();
      this.lootitems = new CheckBox();
      this.dropitems = new CheckBox();
      this.SuspendLayout();
      this.aopuinsein.AutoSize = true;
      this.aopuinsein.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.aopuinsein.Location = new System.Drawing.Point(29, 75);
      this.aopuinsein.Name = "aopuinsein";
      this.aopuinsein.Size = new Size(166, 19);
      this.aopuinsein.TabIndex = 0;
      this.aopuinsein.Text = "ao puinsein/beetle extract";
      this.aopuinsein.UseVisualStyleBackColor = true;
      this.aopuinsein.CheckedChanged += new EventHandler(this.aopuinsin_CheckedChanged);
      this.aocradhs.AutoSize = true;
      this.aocradhs.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.aocradhs.Location = new System.Drawing.Point(29, 100);
      this.aocradhs.Name = "aocradhs";
      this.aocradhs.Size = new Size(81, 19);
      this.aocradhs.TabIndex = 1;
      this.aocradhs.Text = "ao cradhs";
      this.aocradhs.UseVisualStyleBackColor = true;
      this.aocradhs.CheckedChanged += new EventHandler(this.aocradhs_CheckedChanged);
      this.beagcradh.AutoSize = true;
      this.beagcradh.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.beagcradh.Location = new System.Drawing.Point(29, 125);
      this.beagcradh.Name = "beagcradh";
      this.beagcradh.Size = new Size(88, 19);
      this.beagcradh.TabIndex = 2;
      this.beagcradh.Text = "beag cradh";
      this.beagcradh.UseVisualStyleBackColor = true;
      this.beagcradh.CheckedChanged += new EventHandler(this.beagcradh_CheckedChanged);
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(26, 29);
      this.label1.Name = "label1";
      this.label1.Size = new Size(199, 26);
      this.label1.TabIndex = 3;
      this.label1.Text = "Cast these spells after finished attacking:\r\n(instead of before)";
      this.wakescroll.AutoSize = true;
      this.wakescroll.Location = new System.Drawing.Point(29, 150);
      this.wakescroll.Name = "wakescroll";
      this.wakescroll.Size = new Size(84, 17);
      this.wakescroll.TabIndex = 4;
      this.wakescroll.Text = "Wake Scroll";
      this.wakescroll.UseVisualStyleBackColor = true;
      this.wakescroll.CheckedChanged += new EventHandler(this.wakescroll_CheckedChanged);
      this.disenchanter.AutoSize = true;
      this.disenchanter.Location = new System.Drawing.Point(29, 173);
      this.disenchanter.Name = "disenchanter";
      this.disenchanter.Size = new Size(89, 17);
      this.disenchanter.TabIndex = 5;
      this.disenchanter.Text = "Disenchanter";
      this.disenchanter.UseVisualStyleBackColor = true;
      this.disenchanter.CheckedChanged += new EventHandler(this.disenchanter_CheckedChanged);
      this.lootitems.AutoSize = true;
      this.lootitems.Location = new System.Drawing.Point(29, 213);
      this.lootitems.Name = "lootitems";
      this.lootitems.Size = new Size(75, 17);
      this.lootitems.TabIndex = 6;
      this.lootitems.Text = "Loot Items";
      this.lootitems.UseVisualStyleBackColor = true;
      this.lootitems.CheckedChanged += new EventHandler(this.lootitems_CheckedChanged);
      this.dropitems.AutoSize = true;
      this.dropitems.Location = new System.Drawing.Point(29, 236);
      this.dropitems.Name = "dropitems";
      this.dropitems.Size = new Size(77, 17);
      this.dropitems.TabIndex = 7;
      this.dropitems.Text = "Drop Items";
      this.dropitems.UseVisualStyleBackColor = true;
      this.dropitems.CheckedChanged += new EventHandler(this.dropitems_CheckedChanged);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.ButtonHighlight;
      this.ClientSize = new Size(284, 282);
      this.Controls.Add((Control) this.dropitems);
      this.Controls.Add((Control) this.lootitems);
      this.Controls.Add((Control) this.disenchanter);
      this.Controls.Add((Control) this.wakescroll);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.beagcradh);
      this.Controls.Add((Control) this.aocradhs);
      this.Controls.Add((Control) this.aopuinsein);
      this.Name =  "SpellPriority";
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Priority";
      this.FormClosing += new FormClosingEventHandler(this.SpellPriority_FormClosing);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
