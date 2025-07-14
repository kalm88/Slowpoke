//SlowPoke
// Type: Flintstones.targetGroup
//SlowPoke
//SlowPoke
//SlowPoke

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Flintstones
{
  public class targetGroup : TabPage
  {
    private IContainer components;
    public CheckBox lifearrowgroup;
    public CheckBox iocgroup;
    public CheckBox mdcspam;
    public CheckBox micgroup;
    public CheckBox creagneartgroup;
    public CheckBox beagcradhgroup;
    public CheckBox aocursesgroup;
    public CheckBox aopuinseingroup;
    public CheckBox aosuaingroup;
    public CheckBox aodallgroup;
    public CheckBox armachdgroup;
    public CheckBox fasdeireasgroup;
    public CheckBox beanngroup;
    public CheckBox fasplayergroup;
    public CheckBox aitegroup;
    private Button removeallgroup;
    private Label label17;
    public CheckBox ignorebardogroup;
    public NumericUpDown iocgroupcond;
    private Label label2;
    private Label label3;
    public TextBox micgroupdelay;
    public CheckBox vineyard;
    public ComboBox aitetype;
    public ComboBox fastype;
    public CheckBox mdcperfect;
    public ComboBox ioctype;
    public CheckBox healanim;
    public CheckBox reflection;
    public CheckBox backupmic;
    private Label label1;
    public TextBox backupmicname;
    public CheckBox vinebeforespiorad;

    public ClientTab ClientTab { get; private set; }

    public targetGroup(ClientTab clienttab)
    {
      this.InitializeComponent();
      this.Text = "All Grouped";
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
        this.aitegroup.Checked = false;
        this.aitegroup.Enabled = false;
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
        this.fasplayergroup.Checked = false;
        this.fasplayergroup.Enabled = false;
        this.fastype.Enabled = false;
      }
    }

    public void BestIocs()
    {
      int num = 0;
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
      if (num > 0)
      {
        this.ioctype.SelectedIndex = 0;
      }
      else
      {
        this.iocgroup.Checked = false;
        this.iocgroup.Enabled = false;
        this.ioctype.Enabled = false;
      }
    }

    private void removeallgroup_Click(object sender, EventArgs e)
    {
      --this.ClientTab.spellTargets.SelectedIndex;
      this.ClientTab.spellTargets.TabPages.Remove((TabPage) this);
      this.ClientTab.newallgrouped.Enabled = true;
      this.ClientTab.targetgroup = (targetGroup) null;
    }

    private void iocgroup_CheckedChanged(object sender, EventArgs e)
    {
      if (this.iocgroup.Checked)
        this.iocgroupcond.Enabled = true;
      else
        this.iocgroupcond.Enabled = false;
    }

    private void aocursesgroup_CheckedChanged(object sender, EventArgs e)
    {
      if (this.aocursesgroup.Checked)
        this.ignorebardogroup.Enabled = true;
      else
        this.ignorebardogroup.Enabled = false;
    }

    private void targetGroup_Load(object sender, EventArgs e)
    {
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.lifearrowgroup = new CheckBox();
      this.iocgroup = new CheckBox();
      this.mdcspam = new CheckBox();
      this.micgroup = new CheckBox();
      this.creagneartgroup = new CheckBox();
      this.beagcradhgroup = new CheckBox();
      this.aocursesgroup = new CheckBox();
      this.aopuinseingroup = new CheckBox();
      this.aosuaingroup = new CheckBox();
      this.aodallgroup = new CheckBox();
      this.armachdgroup = new CheckBox();
      this.fasdeireasgroup = new CheckBox();
      this.beanngroup = new CheckBox();
      this.fasplayergroup = new CheckBox();
      this.aitegroup = new CheckBox();
      this.removeallgroup = new Button();
      this.iocgroupcond = new NumericUpDown();
      this.label17 = new Label();
      this.ignorebardogroup = new CheckBox();
      this.label2 = new Label();
      this.label3 = new Label();
      this.micgroupdelay = new TextBox();
      this.vineyard = new CheckBox();
      this.aitetype = new ComboBox();
      this.fastype = new ComboBox();
      this.mdcperfect = new CheckBox();
      this.ioctype = new ComboBox();
      this.healanim = new CheckBox();
      this.reflection = new CheckBox();
      this.backupmic = new CheckBox();
      this.label1 = new Label();
      this.backupmicname = new TextBox();
      this.vinebeforespiorad = new CheckBox();
      this.iocgroupcond.BeginInit();
      this.SuspendLayout();
      this.lifearrowgroup.AutoSize = true;
      this.lifearrowgroup.Location = new System.Drawing.Point(88, 223);
      this.lifearrowgroup.Name = "lifearrowgroup";
      this.lifearrowgroup.Size = new Size(143, 19);
      this.lifearrowgroup.TabIndex = 76;
      this.lifearrowgroup.Text = "Revive with Life Arrow";
      this.lifearrowgroup.UseVisualStyleBackColor = true;
      this.iocgroup.AutoSize = true;
      this.iocgroup.Location = new System.Drawing.Point(294, 73);
      this.iocgroup.Name = "iocgroup";
      this.iocgroup.Size = new Size(15, 14);
      this.iocgroup.TabIndex = 74;
      this.iocgroup.UseVisualStyleBackColor = true;
      this.iocgroup.CheckedChanged += new EventHandler(this.iocgroup_CheckedChanged);
      this.mdcspam.AutoSize = true;
      this.mdcspam.Location = new System.Drawing.Point(88, 22);
      this.mdcspam.Name = "mdcspam";
      this.mdcspam.Size = new Size(83, 19);
      this.mdcspam.TabIndex = 69;
      this.mdcspam.Text = "Mdc spam";
      this.mdcspam.UseVisualStyleBackColor = true;
      this.micgroup.AutoSize = true;
      this.micgroup.Location = new System.Drawing.Point(294, 44);
      this.micgroup.Name = "micgroup";
      this.micgroup.Size = new Size(79, 19);
      this.micgroup.TabIndex = 68;
      this.micgroup.Text = "Aic/Mic spam";
      this.micgroup.UseVisualStyleBackColor = true;
      this.creagneartgroup.AutoSize = true;
      this.creagneartgroup.Location = new System.Drawing.Point(88, 198);
      this.creagneartgroup.Name = "creagneartgroup";
      this.creagneartgroup.Size = new Size(88, 19);
      this.creagneartgroup.TabIndex = 67;
      this.creagneartgroup.Text = "creag neart";
      this.creagneartgroup.UseVisualStyleBackColor = true;
      this.beagcradhgroup.AutoSize = true;
      this.beagcradhgroup.Location = new System.Drawing.Point(294, 244);
      this.beagcradhgroup.Name = "beagcradhgroup";
      this.beagcradhgroup.Size = new Size(88, 19);
      this.beagcradhgroup.TabIndex = 66;
      this.beagcradhgroup.Text = "beag cradh";
      this.beagcradhgroup.UseVisualStyleBackColor = true;
      this.aocursesgroup.AutoSize = true;
      this.aocursesgroup.Location = new System.Drawing.Point(294, 194);
      this.aocursesgroup.Name = "aocursesgroup";
      this.aocursesgroup.Size = new Size(81, 19);
      this.aocursesgroup.TabIndex = 65;
      this.aocursesgroup.Text = "ao curses";
      this.aocursesgroup.UseVisualStyleBackColor = true;
      this.aocursesgroup.CheckedChanged += new EventHandler(this.aocursesgroup_CheckedChanged);
      this.aopuinseingroup.AutoSize = true;
      this.aopuinseingroup.Location = new System.Drawing.Point(294, 169);
      this.aopuinseingroup.Name = "aopuinseingroup";
      this.aopuinseingroup.Size = new Size(91, 19);
      this.aopuinseingroup.TabIndex = 64;
      this.aopuinseingroup.Text = "ao puinsein";
      this.aopuinseingroup.UseVisualStyleBackColor = true;
      this.aosuaingroup.AutoSize = true;
      this.aosuaingroup.Location = new System.Drawing.Point(294, 144);
      this.aosuaingroup.Name = "aosuaingroup";
      this.aosuaingroup.Size = new Size(74, 19);
      this.aosuaingroup.TabIndex = 63;
      this.aosuaingroup.Text = "ao suain";
      this.aosuaingroup.UseVisualStyleBackColor = true;
      this.aodallgroup.AutoSize = true;
      this.aodallgroup.Location = new System.Drawing.Point(294, 119);
      this.aodallgroup.Name = "aodallgroup";
      this.aodallgroup.Size = new Size(63, 19);
      this.aodallgroup.TabIndex = 62;
      this.aodallgroup.Text = "ao dall";
      this.aodallgroup.UseVisualStyleBackColor = true;
      this.armachdgroup.AutoSize = true;
      this.armachdgroup.Location = new System.Drawing.Point(88, 173);
      this.armachdgroup.Name = "armachdgroup";
      this.armachdgroup.Size = new Size(75, 19);
      this.armachdgroup.TabIndex = 61;
      this.armachdgroup.Text = "armachd";
      this.armachdgroup.UseVisualStyleBackColor = true;
      this.fasdeireasgroup.AutoSize = true;
      this.fasdeireasgroup.Location = new System.Drawing.Point(88, 148);
      this.fasdeireasgroup.Name = "fasdeireasgroup";
      this.fasdeireasgroup.Size = new Size(88, 19);
      this.fasdeireasgroup.TabIndex = 60;
      this.fasdeireasgroup.Text = "fas deireas";
      this.fasdeireasgroup.UseVisualStyleBackColor = true;
      this.beanngroup.AutoSize = true;
      this.beanngroup.Location = new System.Drawing.Point(88, 123);
      this.beanngroup.Name = "beanngroup";
      this.beanngroup.Size = new Size(84, 19);
      this.beanngroup.TabIndex = 59;
      this.beanngroup.Text = "beannaich";
      this.beanngroup.UseVisualStyleBackColor = true;
      this.fasplayergroup.AutoSize = true;
      this.fasplayergroup.Location = new System.Drawing.Point(88, 98);
      this.fasplayergroup.Name = "fasplayergroup";
      this.fasplayergroup.Size = new Size(15, 14);
      this.fasplayergroup.TabIndex = 58;
      this.fasplayergroup.UseVisualStyleBackColor = true;
      this.aitegroup.AutoSize = true;
      this.aitegroup.Location = new System.Drawing.Point(88, 69);
      this.aitegroup.Name = "aitegroup";
      this.aitegroup.Size = new Size(15, 14);
      this.aitegroup.TabIndex = 57;
      this.aitegroup.UseVisualStyleBackColor = true;
      this.removeallgroup.Location = new System.Drawing.Point(457, 254);
      this.removeallgroup.Name = "removeallgroup";
      this.removeallgroup.Size = new Size(129, 33);
      this.removeallgroup.TabIndex = 77;
      this.removeallgroup.Text = "remove this target";
      this.removeallgroup.UseVisualStyleBackColor = true;
      this.removeallgroup.Click += new EventHandler(this.removeallgroup_Click);
      this.iocgroupcond.Enabled = false;
      this.iocgroupcond.Location = new System.Drawing.Point(441, 70);
      this.iocgroupcond.Name = "iocgroupcond";
      this.iocgroupcond.Size = new Size(46, 21);
      this.iocgroupcond.TabIndex = 89;
      this.iocgroupcond.Value = new Decimal(new int[4]
      {
        80,
        0,
        0,
        0
      });
      this.label17.AutoSize = true;
      this.label17.Location = new System.Drawing.Point(493, 74);
      this.label17.Name = "label17";
      this.label17.Size = new Size(18, 15);
      this.label17.TabIndex = 88;
      this.label17.Text = "%";
      this.ignorebardogroup.AutoSize = true;
      this.ignorebardogroup.Enabled = false;
      this.ignorebardogroup.Location = new System.Drawing.Point(294, 219);
      this.ignorebardogroup.Name = "ignorebardogroup";
      this.ignorebardogroup.Size = new Size(97, 19);
      this.ignorebardogroup.TabIndex = 92;
      this.ignorebardogroup.Text = "Ignore Bardo";
      this.ignorebardogroup.UseVisualStyleBackColor = true;
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(390, 45);
      this.label2.Name = "label2";
      this.label2.Size = new Size(38, 15);
      this.label2.TabIndex = 93;
      this.label2.Text = "Delay";
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(493, 45);
      this.label3.Name = "label3";
      this.label3.Size = new Size(25, 15);
      this.label3.TabIndex = 94;
      this.label3.Text = "ms";
      this.micgroupdelay.Location = new System.Drawing.Point(432, 42);
      this.micgroupdelay.Name = "micgroupdelay";
      this.micgroupdelay.Size = new Size(55, 21);
      this.micgroupdelay.TabIndex = 95;
      this.micgroupdelay.Text = "300";
      this.vineyard.AutoSize = true;
      this.vineyard.Location = new System.Drawing.Point(88, 273);
      this.vineyard.Name = "vineyard";
      this.vineyard.Size = new Size(107, 19);
      this.vineyard.TabIndex = 96;
      this.vineyard.Text = "Lyliac Vineyard";
      this.vineyard.UseVisualStyleBackColor = true;
      this.aitetype.DropDownStyle = ComboBoxStyle.DropDownList;
      this.aitetype.Font = new Font("Arial", 9f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.aitetype.FormattingEnabled = true;
      this.aitetype.Location = new System.Drawing.Point(109, 65);
      this.aitetype.Name = "aitetype";
      this.aitetype.Size = new Size(121, 23);
      this.aitetype.TabIndex = 97;
      this.fastype.DropDownStyle = ComboBoxStyle.DropDownList;
      this.fastype.Font = new Font("Arial", 9f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.fastype.FormattingEnabled = true;
      this.fastype.Location = new System.Drawing.Point(109, 94);
      this.fastype.Name = "fastype";
      this.fastype.Size = new Size(121, 23);
      this.fastype.TabIndex = 98;
      this.mdcperfect.AutoSize = true;
      this.mdcperfect.Location = new System.Drawing.Point(88, 44);
      this.mdcperfect.Name = "mdcperfect";
      this.mdcperfect.Size = new Size(88, 19);
      this.mdcperfect.TabIndex = 99;
      this.mdcperfect.Text = "Mdc perfect";
      this.mdcperfect.UseVisualStyleBackColor = true;
      this.ioctype.DropDownStyle = ComboBoxStyle.DropDownList;
      this.ioctype.Font = new Font("Arial", 9f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.ioctype.FormattingEnabled = true;
      this.ioctype.Location = new System.Drawing.Point(315, 69);
      this.ioctype.Name = "ioctype";
      this.ioctype.Size = new Size(120, 23);
      this.ioctype.TabIndex = 100;
      this.healanim.AutoSize = true;
      this.healanim.Checked = true;
      this.healanim.CheckState = CheckState.Checked;
      this.healanim.Location = new System.Drawing.Point(294, 22);
      this.healanim.Name = "healanim";
      this.healanim.Size = new Size(186, 19);
      this.healanim.TabIndex = 102;
      this.healanim.Text = "Heal after 'strong' animations";
      this.healanim.UseVisualStyleBackColor = true;
      this.reflection.AutoSize = true;
      this.reflection.Location = new System.Drawing.Point(88, 248);
      this.reflection.Name = "reflection";
      this.reflection.Size = new Size(81, 19);
      this.reflection.TabIndex = 103;
      this.reflection.Text = "Reflection";
      this.reflection.UseVisualStyleBackColor = true;
      this.backupmic.AutoSize = true;
      this.backupmic.Location = new System.Drawing.Point(315, 96);
      this.backupmic.Name = "backupmic";
      this.backupmic.Size = new Size(61, 19);
      this.backupmic.TabIndex = 104;
      this.backupmic.Text = "Heal if";
      this.backupmic.UseVisualStyleBackColor = true;
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(482, 97);
      this.label1.Name = "label1";
      this.label1.Size = new Size(60, 15);
      this.label1.TabIndex = 105;
      this.label1.Text = "ungroups";
      this.backupmicname.Location = new System.Drawing.Point(376, 94);
      this.backupmicname.Name = "backupmicname";
      this.backupmicname.Size = new Size(100, 21);
      this.backupmicname.TabIndex = 106;
      this.vinebeforespiorad.AutoSize = true;
      this.vinebeforespiorad.Location = new System.Drawing.Point(201, 273);
      this.vinebeforespiorad.Name = "vinebeforespiorad";
      this.vinebeforespiorad.Size = new Size(106, 19);
      this.vinebeforespiorad.TabIndex = 107;
      this.vinebeforespiorad.Text = "before spiorad";
      this.vinebeforespiorad.UseVisualStyleBackColor = true;
      this.BackColor = Color.White;
      this.ClientSize = new Size(598, 299);
      this.Controls.Add((Control) this.vinebeforespiorad);
      this.Controls.Add((Control) this.backupmicname);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.backupmic);
      this.Controls.Add((Control) this.reflection);
      this.Controls.Add((Control) this.healanim);
      this.Controls.Add((Control) this.ioctype);
      this.Controls.Add((Control) this.mdcperfect);
      this.Controls.Add((Control) this.fastype);
      this.Controls.Add((Control) this.aitetype);
      this.Controls.Add((Control) this.vineyard);
      this.Controls.Add((Control) this.micgroupdelay);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.ignorebardogroup);
      this.Controls.Add((Control) this.iocgroupcond);
      this.Controls.Add((Control) this.label17);
      this.Controls.Add((Control) this.removeallgroup);
      this.Controls.Add((Control) this.lifearrowgroup);
      this.Controls.Add((Control) this.iocgroup);
      this.Controls.Add((Control) this.mdcspam);
      this.Controls.Add((Control) this.micgroup);
      this.Controls.Add((Control) this.creagneartgroup);
      this.Controls.Add((Control) this.beagcradhgroup);
      this.Controls.Add((Control) this.aocursesgroup);
      this.Controls.Add((Control) this.aopuinseingroup);
      this.Controls.Add((Control) this.aosuaingroup);
      this.Controls.Add((Control) this.aodallgroup);
      this.Controls.Add((Control) this.armachdgroup);
      this.Controls.Add((Control) this.fasdeireasgroup);
      this.Controls.Add((Control) this.beanngroup);
      this.Controls.Add((Control) this.fasplayergroup);
      this.Controls.Add((Control) this.aitegroup);
      this.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Name =  "targetGroup";
      this.iocgroupcond.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
