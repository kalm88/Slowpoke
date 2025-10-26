//SlowPoke
// Type: Flintstones.Updates
//SlowPoke
//SlowPoke
//SlowPoke

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Flintstones
{
  public class Updates : Form
  {
    private IContainer components;
    private RichTextBox richTextBox1;

    public Updates() => this.InitializeComponent();

    private void Updates_FormClosing(object sender, FormClosingEventArgs e)
    {
      e.Cancel = true;
      this.Hide();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Updates));
      this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
      this.richTextBox1 = new RichTextBox();
      this.SuspendLayout();
      this.richTextBox1.Location = new System.Drawing.Point(-1, 1);
      this.richTextBox1.Name = "richTextBox1";
      this.richTextBox1.ReadOnly = true;
      this.richTextBox1.ScrollBars = RichTextBoxScrollBars.Vertical;
      this.richTextBox1.Size = new Size(407, 502);
      this.richTextBox1.TabIndex = 0;
      this.richTextBox1.Text = ("richTextBox1.Text");
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(408, 505);
      this.Controls.Add((Control) this.richTextBox1);
      this.Name =  "Updates";
      this.Text =  "Updates";
      this.FormClosing += new FormClosingEventHandler(this.Updates_FormClosing);
      this.ResumeLayout(false);
    }
  }
}
