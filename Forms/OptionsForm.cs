//SlowPoke
// Type: Flintstones.OptionsForm
//SlowPoke
//SlowPoke
//SlowPoke

using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Flintstones
{
  public class OptionsForm : Form
  {
    private IContainer components;
    private Button btnOK;
    private Button btnCancel;
    private Label label1;
    private Button btnBrowse;
    public TextBox txtDarkAgesPath;

    public OptionsForm()
    {
      this.InitializeComponent();
      this.txtDarkAgesPath.Text = Options.DarkAgesDirectoryName + "\\" + Options.DarkAgesFileName;
      this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
    }

    private void btnBrowse_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Filter = "Executable (*.exe)|*.exe";
      if (openFileDialog.ShowDialog() == DialogResult.OK)
        this.txtDarkAgesPath.Text = openFileDialog.FileName;
      Directory.SetCurrentDirectory(Program.StartupPath);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.btnOK = new Button();
      this.btnCancel = new Button();
      this.label1 = new Label();
      this.txtDarkAgesPath = new TextBox();
      this.btnBrowse = new Button();
      this.SuspendLayout();
      this.btnOK.BackColor = SystemColors.ButtonHighlight;
      this.btnOK.DialogResult = DialogResult.OK;
      this.btnOK.ForeColor = SystemColors.ActiveCaptionText;
      this.btnOK.Location = new System.Drawing.Point(393, 53);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new Size(75, 23);
      this.btnOK.TabIndex = 1;
      this.btnOK.Text = "OK";
      this.btnOK.UseVisualStyleBackColor = false;
      this.btnCancel.BackColor = SystemColors.ButtonHighlight;
      this.btnCancel.DialogResult = DialogResult.Cancel;
      this.btnCancel.ForeColor = SystemColors.ActiveCaptionText;
      this.btnCancel.Location = new System.Drawing.Point(312, 53);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new Size(75, 23);
      this.btnCancel.TabIndex = 2;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = false;
      this.label1.AutoSize = true;
      this.label1.ForeColor = Color.Black;
      this.label1.Location = new System.Drawing.Point(12, 15);
      this.label1.Name = "label1";
      this.label1.Size = new Size(90, 15);
      this.label1.TabIndex = 3;
      this.label1.Text = "Dark Ages path";
      this.txtDarkAgesPath.BackColor = SystemColors.Window;
      this.txtDarkAgesPath.ForeColor = Color.Black;
      this.txtDarkAgesPath.Location = new System.Drawing.Point(105, 12);
      this.txtDarkAgesPath.Name = "txtDarkAgesPath";
      this.txtDarkAgesPath.ReadOnly = true;
      this.txtDarkAgesPath.Size = new Size(282, 21);
      this.txtDarkAgesPath.TabIndex = 4;
      this.btnBrowse.BackColor = SystemColors.ButtonHighlight;
      this.btnBrowse.ForeColor = SystemColors.ActiveCaptionText;
      this.btnBrowse.Location = new System.Drawing.Point(393, 12);
      this.btnBrowse.Name = "btnBrowse";
      this.btnBrowse.Size = new Size(75, 23);
      this.btnBrowse.TabIndex = 5;
      this.btnBrowse.Text = "Browse";
      this.btnBrowse.UseVisualStyleBackColor = false;
      this.btnBrowse.Click += new EventHandler(this.btnBrowse_Click);
      this.AcceptButton = (IButtonControl) this.btnOK;
      this.AutoScaleDimensions = new SizeF(7f, 15f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.ButtonHighlight;
      this.CancelButton = (IButtonControl) this.btnCancel;
      this.ClientSize = new Size(480, 98);
      this.Controls.Add((Control) this.btnBrowse);
      this.Controls.Add((Control) this.txtDarkAgesPath);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.btnCancel);
      this.Controls.Add((Control) this.btnOK);
      this.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.ForeColor = Color.White;
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name =  "OptionsForm";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Options";
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
