//SlowPoke
// Type: Flintstones.ExternalChat
//SlowPoke
//SlowPoke
//SlowPoke

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Flintstones
{
  public class ExternalChat : Form
  {
    public MainForm parent;
    private IContainer components;
    public TextBox chatbox;
    public TextBox speakbox;
    private Label label1;
    private Label label2;
    public TextBox textBox1;
    public TextBox textBox2;

    public Client Client { get; private set; }

    public ExternalChat(Client client)
    {
      this.parent = Program.MainForm;
      this.Client = client;
      this.InitializeComponent();
    }

    private void speakbox_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar != '\r')
        return;
      this.Client.Speak(this.speakbox.Text);
      this.speakbox.Text = string.Empty;
    }

    private void ExternalChat_FormClosing(object sender, FormClosingEventArgs e)
    {
      e.Cancel = true;
      this.Visible = false;
    }

    private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar != '\r')
        return;
      this.textBox2.Focus();
    }

    private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar != '\r')
        return;
      this.Client.Whisper(this.textBox1.Text, this.textBox2.Text);
      this.textBox2.Text = string.Empty;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.chatbox = new TextBox();
      this.speakbox = new TextBox();
      this.label1 = new Label();
      this.textBox1 = new TextBox();
      this.label2 = new Label();
      this.textBox2 = new TextBox();
      this.SuspendLayout();
      this.chatbox.BackColor = SystemColors.Window;
      this.chatbox.Location = new System.Drawing.Point(0, 0);
      this.chatbox.Multiline = true;
      this.chatbox.Name = "chatbox";
      this.chatbox.ReadOnly = true;
      this.chatbox.ScrollBars = ScrollBars.Vertical;
      this.chatbox.Size = new Size(443, 112);
      this.chatbox.TabIndex = 0;
      this.speakbox.Location = new System.Drawing.Point(0, 113);
      this.speakbox.Name = "speakbox";
      this.speakbox.Size = new Size(443, 20);
      this.speakbox.TabIndex = 1;
      this.speakbox.KeyPress += new KeyPressEventHandler(this.speakbox_KeyPress);
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label1.Location = new System.Drawing.Point(-3, 136);
      this.label1.Name = "label1";
      this.label1.Size = new Size(46, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Whisper";
      this.textBox1.BorderStyle = BorderStyle.None;
      this.textBox1.Location = new System.Drawing.Point(49, 136);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new Size(100, 13);
      this.textBox1.TabIndex = 3;
      this.textBox1.KeyPress += new KeyPressEventHandler(this.textBox1_KeyPress);
      this.label2.AutoSize = true;
      this.label2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label2.Location = new System.Drawing.Point(155, 136);
      this.label2.Name = "label2";
      this.label2.Size = new Size(10, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "|";
      this.textBox2.BorderStyle = BorderStyle.None;
      this.textBox2.Location = new System.Drawing.Point(171, 136);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new Size(272, 13);
      this.textBox2.TabIndex = 5;
      this.textBox2.KeyPress += new KeyPressEventHandler(this.textBox2_KeyPress);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackgroundImageLayout = ImageLayout.None;
      this.ClientSize = new Size(444, 151);
      this.Controls.Add((Control) this.textBox2);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.textBox1);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.speakbox);
      this.Controls.Add((Control) this.chatbox);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Name = "ExternalChat";
      this.FormClosing += new FormClosingEventHandler(this.ExternalChat_FormClosing);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
