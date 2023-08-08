//SlowPoke
// Type: Flintstones.HideTrinketOptions
//SlowPoke
//SlowPoke
//SlowPoke

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Flintstones
{
  public class HideTrinketOptions : Form
  {
    public MainForm parent;
    private IContainer components;
    public CheckBox vanishingelixir;
    public ListBox namelist;
    public TextBox nametextbox;
    public Button add;
    public Button remove;
    public CheckBox hideallgroup;

    public Client Client { get; private set; }

    public HideTrinketOptions(Client client)
    {
      this.parent = Program.MainForm;
      this.Client = client;
      this.InitializeComponent();
    }

    private void remove_Click(object sender, EventArgs e)
    {
      if (this.namelist.Items.Count <= 0)
        return;
      this.namelist.Items.Remove(this.namelist.SelectedItem);
    }

    private void add_Click(object sender, EventArgs e) => this.Add();

    private void nametextbox_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar != '\r')
        return;
      this.Add();
    }

    private void Add()
    {
      if (!(this.nametextbox.Text != string.Empty) || this.namelist.Items.Contains((object) this.nametextbox.Text))
        return;
      this.namelist.Items.Add((object) this.nametextbox.Text.ToLower());
      this.nametextbox.Text = string.Empty;
    }

    private void HideTrinketOptions_FormClosing(object sender, FormClosingEventArgs e)
    {
      e.Cancel = true;
      this.Hide();
      this.Client.Tab.vanishingelixir.Enabled = true;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.vanishingelixir = new CheckBox();
      this.namelist = new ListBox();
      this.nametextbox = new TextBox();
      this.add = new Button();
      this.remove = new Button();
      this.hideallgroup = new CheckBox();
      this.SuspendLayout();
      this.vanishingelixir.AutoSize = true;
      this.vanishingelixir.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.vanishingelixir.Location = new System.Drawing.Point(22, 25);
      this.vanishingelixir.Name = "vanishingelixir";
      this.vanishingelixir.Size = new Size(138, 17);
      this.vanishingelixir.TabIndex = 0;
      this.vanishingelixir.Text = "Use Vanishing Elixir";
      this.vanishingelixir.UseVisualStyleBackColor = true;
      this.namelist.FormattingEnabled = true;
      this.namelist.Location = new System.Drawing.Point(22, 61);
      this.namelist.Name = "namelist";
      this.namelist.Size = new Size(120, 173);
      this.namelist.TabIndex = 1;
      this.nametextbox.Location = new System.Drawing.Point(22, 251);
      this.nametextbox.Name = "nametextbox";
      this.nametextbox.Size = new Size(120, 20);
      this.nametextbox.TabIndex = 2;
      this.nametextbox.KeyPress += new KeyPressEventHandler(this.nametextbox_KeyPress);
      this.add.Location = new System.Drawing.Point(148, 249);
      this.add.Name = "add";
      this.add.Size = new Size(75, 23);
      this.add.TabIndex = 3;
      this.add.Text = "Add";
      this.add.UseVisualStyleBackColor = true;
      this.add.Click += new EventHandler(this.add_Click);
      this.remove.Location = new System.Drawing.Point(148, 141);
      this.remove.Name = "remove";
      this.remove.Size = new Size(75, 23);
      this.remove.TabIndex = 4;
      this.remove.Text = "Remove";
      this.remove.UseVisualStyleBackColor = true;
      this.remove.Click += new EventHandler(this.remove_Click);
      this.hideallgroup.AutoSize = true;
      this.hideallgroup.Location = new System.Drawing.Point(148, 61);
      this.hideallgroup.Name = "hideallgroup";
      this.hideallgroup.Size = new Size(81, 17);
      this.hideallgroup.TabIndex = 5;
      this.hideallgroup.Text = "All Grouped";
      this.hideallgroup.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(240, 292);
      this.Controls.Add((Control) this.hideallgroup);
      this.Controls.Add((Control) this.remove);
      this.Controls.Add((Control) this.add);
      this.Controls.Add((Control) this.nametextbox);
      this.Controls.Add((Control) this.namelist);
      this.Controls.Add((Control) this.vanishingelixir);
      this.Name =  "HideTrinketOptions";
      this.Text =  "HideTrinketOptions";
      this.FormClosing += new FormClosingEventHandler(this.HideTrinketOptions_FormClosing);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
