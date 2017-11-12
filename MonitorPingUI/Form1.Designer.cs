namespace MonitorPingUI
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.IPadressBox = new System.Windows.Forms.TextBox();
            this.IPOutputAnswer = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.DataTextFromIP = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.IPadressBox1 = new System.Windows.Forms.TextBox();
            this.IPOutputAnswer1 = new System.Windows.Forms.Label();
            this.DataTextFromIP1 = new System.Windows.Forms.Label();
            this.buttonStart1 = new System.Windows.Forms.Button();
            this.buttonStop2 = new System.Windows.Forms.Button();
            this.IPadressBox2 = new System.Windows.Forms.TextBox();
            this.IPOutputAnswer2 = new System.Windows.Forms.Label();
            this.buttonStart2 = new System.Windows.Forms.Button();
            this.buttonStop3 = new System.Windows.Forms.Button();
            this.DataTextFromIP2 = new System.Windows.Forms.Label();
            this.DataTextFromIP3 = new System.Windows.Forms.Label();
            this.buttonStop4 = new System.Windows.Forms.Button();
            this.buttonStart3 = new System.Windows.Forms.Button();
            this.IPOutputAnswer3 = new System.Windows.Forms.Label();
            this.IPadressBox3 = new System.Windows.Forms.TextBox();
            this.DataTextFromIP4 = new System.Windows.Forms.Label();
            this.buttonStop5 = new System.Windows.Forms.Button();
            this.buttonStart4 = new System.Windows.Forms.Button();
            this.IPOutputAnswer4 = new System.Windows.Forms.Label();
            this.IPadressBox4 = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // IPadressBox
            // 
            this.IPadressBox.Location = new System.Drawing.Point(13, 58);
            this.IPadressBox.Name = "IPadressBox";
            this.IPadressBox.Size = new System.Drawing.Size(175, 20);
            this.IPadressBox.TabIndex = 0;
            this.IPadressBox.Text = "127.0.0.1";
            this.IPadressBox.TextChanged += new System.EventHandler(this.IPadressBox_TextChanged);
            // 
            // IPOutputAnswer
            // 
            this.IPOutputAnswer.AutoSize = true;
            this.IPOutputAnswer.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.IPOutputAnswer.Location = new System.Drawing.Point(194, 62);
            this.IPOutputAnswer.Name = "IPOutputAnswer";
            this.IPOutputAnswer.Size = new System.Drawing.Size(0, 13);
            this.IPOutputAnswer.TabIndex = 1;
            this.IPOutputAnswer.Tag = "";
            this.IPOutputAnswer.Click += new System.EventHandler(this.IPOutputAnswer_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(354, 58);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(94, 21);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Enabled = false;
            this.buttonStop.Location = new System.Drawing.Point(454, 58);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(94, 21);
            this.buttonStop.TabIndex = 3;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // DataTextFromIP
            // 
            this.DataTextFromIP.AutoSize = true;
            this.DataTextFromIP.Location = new System.Drawing.Point(16, 81);
            this.DataTextFromIP.Name = "DataTextFromIP";
            this.DataTextFromIP.Size = new System.Drawing.Size(0, 13);
            this.DataTextFromIP.TabIndex = 4;
            this.DataTextFromIP.Click += new System.EventHandler(this.DataTextFromIP_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(454, 260);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(94, 21);
            this.buttonReset.TabIndex = 5;
            this.buttonReset.Text = "Clear";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // IPadressBox1
            // 
            this.IPadressBox1.Location = new System.Drawing.Point(12, 98);
            this.IPadressBox1.Name = "IPadressBox1";
            this.IPadressBox1.Size = new System.Drawing.Size(175, 20);
            this.IPadressBox1.TabIndex = 6;
            this.IPadressBox1.Text = "127.0.0.1";
            this.IPadressBox1.TextChanged += new System.EventHandler(this.IPadressBox1_TextChanged);
            // 
            // IPOutputAnswer1
            // 
            this.IPOutputAnswer1.AutoSize = true;
            this.IPOutputAnswer1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.IPOutputAnswer1.Location = new System.Drawing.Point(194, 103);
            this.IPOutputAnswer1.Name = "IPOutputAnswer1";
            this.IPOutputAnswer1.Size = new System.Drawing.Size(0, 13);
            this.IPOutputAnswer1.TabIndex = 7;
            this.IPOutputAnswer1.Tag = "";
            this.IPOutputAnswer1.Click += new System.EventHandler(this.IPOutputAnswer1_Click);
            // 
            // DataTextFromIP1
            // 
            this.DataTextFromIP1.AutoSize = true;
            this.DataTextFromIP1.Location = new System.Drawing.Point(15, 121);
            this.DataTextFromIP1.Name = "DataTextFromIP1";
            this.DataTextFromIP1.Size = new System.Drawing.Size(0, 13);
            this.DataTextFromIP1.TabIndex = 8;
            this.DataTextFromIP1.Click += new System.EventHandler(this.DataTextFromIP1_Click);
            // 
            // buttonStart1
            // 
            this.buttonStart1.Location = new System.Drawing.Point(354, 99);
            this.buttonStart1.Name = "buttonStart1";
            this.buttonStart1.Size = new System.Drawing.Size(94, 21);
            this.buttonStart1.TabIndex = 9;
            this.buttonStart1.Text = "Start";
            this.buttonStart1.UseVisualStyleBackColor = true;
            this.buttonStart1.Click += new System.EventHandler(this.buttonStart1_Click);
            // 
            // buttonStop2
            // 
            this.buttonStop2.Enabled = false;
            this.buttonStop2.Location = new System.Drawing.Point(454, 99);
            this.buttonStop2.Name = "buttonStop2";
            this.buttonStop2.Size = new System.Drawing.Size(94, 21);
            this.buttonStop2.TabIndex = 10;
            this.buttonStop2.Text = "Stop";
            this.buttonStop2.UseVisualStyleBackColor = true;
            this.buttonStop2.Click += new System.EventHandler(this.buttonStop2_Click);
            // 
            // IPadressBox2
            // 
            this.IPadressBox2.Location = new System.Drawing.Point(12, 140);
            this.IPadressBox2.Name = "IPadressBox2";
            this.IPadressBox2.Size = new System.Drawing.Size(175, 20);
            this.IPadressBox2.TabIndex = 11;
            this.IPadressBox2.Text = "127.0.0.1";
            this.IPadressBox2.TextChanged += new System.EventHandler(this.IPadressBox2_TextChanged);
            // 
            // IPOutputAnswer2
            // 
            this.IPOutputAnswer2.AutoSize = true;
            this.IPOutputAnswer2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.IPOutputAnswer2.Location = new System.Drawing.Point(194, 145);
            this.IPOutputAnswer2.Name = "IPOutputAnswer2";
            this.IPOutputAnswer2.Size = new System.Drawing.Size(0, 13);
            this.IPOutputAnswer2.TabIndex = 12;
            this.IPOutputAnswer2.Tag = "";
            this.IPOutputAnswer2.Click += new System.EventHandler(this.IPOutputAnswer2_Click);
            // 
            // buttonStart2
            // 
            this.buttonStart2.Location = new System.Drawing.Point(354, 139);
            this.buttonStart2.Name = "buttonStart2";
            this.buttonStart2.Size = new System.Drawing.Size(94, 21);
            this.buttonStart2.TabIndex = 13;
            this.buttonStart2.Text = "Start";
            this.buttonStart2.UseVisualStyleBackColor = true;
            this.buttonStart2.Click += new System.EventHandler(this.buttonStart2_Click);
            // 
            // buttonStop3
            // 
            this.buttonStop3.Enabled = false;
            this.buttonStop3.Location = new System.Drawing.Point(454, 139);
            this.buttonStop3.Name = "buttonStop3";
            this.buttonStop3.Size = new System.Drawing.Size(94, 21);
            this.buttonStop3.TabIndex = 14;
            this.buttonStop3.Text = "Stop";
            this.buttonStop3.UseVisualStyleBackColor = true;
            this.buttonStop3.Click += new System.EventHandler(this.buttonStop3_Click);
            // 
            // DataTextFromIP2
            // 
            this.DataTextFromIP2.AutoSize = true;
            this.DataTextFromIP2.Location = new System.Drawing.Point(15, 164);
            this.DataTextFromIP2.Name = "DataTextFromIP2";
            this.DataTextFromIP2.Size = new System.Drawing.Size(0, 13);
            this.DataTextFromIP2.TabIndex = 15;
            this.DataTextFromIP2.Click += new System.EventHandler(this.DataTextFromIP2_Click);
            // 
            // DataTextFromIP3
            // 
            this.DataTextFromIP3.AutoSize = true;
            this.DataTextFromIP3.Location = new System.Drawing.Point(15, 205);
            this.DataTextFromIP3.Name = "DataTextFromIP3";
            this.DataTextFromIP3.Size = new System.Drawing.Size(0, 13);
            this.DataTextFromIP3.TabIndex = 20;
            this.DataTextFromIP3.Click += new System.EventHandler(this.DataTextFromIP3_Click);
            // 
            // buttonStop4
            // 
            this.buttonStop4.Enabled = false;
            this.buttonStop4.Location = new System.Drawing.Point(454, 180);
            this.buttonStop4.Name = "buttonStop4";
            this.buttonStop4.Size = new System.Drawing.Size(94, 21);
            this.buttonStop4.TabIndex = 19;
            this.buttonStop4.Text = "Stop";
            this.buttonStop4.UseVisualStyleBackColor = true;
            this.buttonStop4.Click += new System.EventHandler(this.buttonStop4_Click);
            // 
            // buttonStart3
            // 
            this.buttonStart3.Location = new System.Drawing.Point(354, 180);
            this.buttonStart3.Name = "buttonStart3";
            this.buttonStart3.Size = new System.Drawing.Size(94, 21);
            this.buttonStart3.TabIndex = 18;
            this.buttonStart3.Text = "Start";
            this.buttonStart3.UseVisualStyleBackColor = true;
            this.buttonStart3.Click += new System.EventHandler(this.buttonStart3_Click);
            // 
            // IPOutputAnswer3
            // 
            this.IPOutputAnswer3.AutoSize = true;
            this.IPOutputAnswer3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.IPOutputAnswer3.Location = new System.Drawing.Point(194, 186);
            this.IPOutputAnswer3.Name = "IPOutputAnswer3";
            this.IPOutputAnswer3.Size = new System.Drawing.Size(0, 13);
            this.IPOutputAnswer3.TabIndex = 17;
            this.IPOutputAnswer3.Tag = "";
            this.IPOutputAnswer3.Click += new System.EventHandler(this.IPOutputAnswer3_Click);
            // 
            // IPadressBox3
            // 
            this.IPadressBox3.Location = new System.Drawing.Point(12, 181);
            this.IPadressBox3.Name = "IPadressBox3";
            this.IPadressBox3.Size = new System.Drawing.Size(175, 20);
            this.IPadressBox3.TabIndex = 16;
            this.IPadressBox3.Text = "127.0.0.1";
            this.IPadressBox3.TextChanged += new System.EventHandler(this.IPadressBox3_TextChanged);
            // 
            // DataTextFromIP4
            // 
            this.DataTextFromIP4.AutoSize = true;
            this.DataTextFromIP4.Location = new System.Drawing.Point(14, 247);
            this.DataTextFromIP4.Name = "DataTextFromIP4";
            this.DataTextFromIP4.Size = new System.Drawing.Size(0, 13);
            this.DataTextFromIP4.TabIndex = 25;
            this.DataTextFromIP4.Click += new System.EventHandler(this.DataTextFromIP4_Click);
            // 
            // buttonStop5
            // 
            this.buttonStop5.Enabled = false;
            this.buttonStop5.Location = new System.Drawing.Point(453, 222);
            this.buttonStop5.Name = "buttonStop5";
            this.buttonStop5.Size = new System.Drawing.Size(94, 21);
            this.buttonStop5.TabIndex = 24;
            this.buttonStop5.Text = "Stop";
            this.buttonStop5.UseVisualStyleBackColor = true;
            this.buttonStop5.Click += new System.EventHandler(this.buttonStop5_Click);
            // 
            // buttonStart4
            // 
            this.buttonStart4.Location = new System.Drawing.Point(353, 222);
            this.buttonStart4.Name = "buttonStart4";
            this.buttonStart4.Size = new System.Drawing.Size(94, 21);
            this.buttonStart4.TabIndex = 23;
            this.buttonStart4.Text = "Start";
            this.buttonStart4.UseVisualStyleBackColor = true;
            this.buttonStart4.Click += new System.EventHandler(this.buttonStart4_Click);
            // 
            // IPOutputAnswer4
            // 
            this.IPOutputAnswer4.AutoSize = true;
            this.IPOutputAnswer4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.IPOutputAnswer4.Location = new System.Drawing.Point(193, 228);
            this.IPOutputAnswer4.Name = "IPOutputAnswer4";
            this.IPOutputAnswer4.Size = new System.Drawing.Size(0, 13);
            this.IPOutputAnswer4.TabIndex = 22;
            this.IPOutputAnswer4.Tag = "";
            this.IPOutputAnswer4.Click += new System.EventHandler(this.IPOutputAnswer4_Click);
            // 
            // IPadressBox4
            // 
            this.IPadressBox4.Location = new System.Drawing.Point(11, 223);
            this.IPadressBox4.Name = "IPadressBox4";
            this.IPadressBox4.Size = new System.Drawing.Size(175, 20);
            this.IPadressBox4.TabIndex = 21;
            this.IPadressBox4.Text = "127.0.0.1";
            this.IPadressBox4.TextChanged += new System.EventHandler(this.IPadressBox4_TextChanged);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "MonitorPingUI";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(326, 61);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(326, 103);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 27;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(326, 143);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 28;
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(326, 184);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(15, 14);
            this.checkBox4.TabIndex = 29;
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(326, 226);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(15, 14);
            this.checkBox5.TabIndex = 30;
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Log";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(561, 24);
            this.menuStrip1.TabIndex = 32;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.aboutToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 302);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.DataTextFromIP4);
            this.Controls.Add(this.buttonStop5);
            this.Controls.Add(this.buttonStart4);
            this.Controls.Add(this.IPOutputAnswer4);
            this.Controls.Add(this.IPadressBox4);
            this.Controls.Add(this.DataTextFromIP3);
            this.Controls.Add(this.buttonStop4);
            this.Controls.Add(this.buttonStart3);
            this.Controls.Add(this.IPOutputAnswer3);
            this.Controls.Add(this.IPadressBox3);
            this.Controls.Add(this.DataTextFromIP2);
            this.Controls.Add(this.buttonStop3);
            this.Controls.Add(this.buttonStart2);
            this.Controls.Add(this.IPOutputAnswer2);
            this.Controls.Add(this.IPadressBox2);
            this.Controls.Add(this.buttonStop2);
            this.Controls.Add(this.buttonStart1);
            this.Controls.Add(this.DataTextFromIP1);
            this.Controls.Add(this.IPOutputAnswer1);
            this.Controls.Add(this.IPadressBox1);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.DataTextFromIP);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.IPOutputAnswer);
            this.Controls.Add(this.IPadressBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MonPing";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IPadressBox;
        private System.Windows.Forms.Label IPOutputAnswer;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label DataTextFromIP;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.TextBox IPadressBox1;
        private System.Windows.Forms.Label IPOutputAnswer1;
        private System.Windows.Forms.Label DataTextFromIP1;
        private System.Windows.Forms.Button buttonStart1;
        private System.Windows.Forms.Button buttonStop2;
        private System.Windows.Forms.TextBox IPadressBox2;
        private System.Windows.Forms.Label IPOutputAnswer2;
        private System.Windows.Forms.Button buttonStart2;
        private System.Windows.Forms.Button buttonStop3;
        private System.Windows.Forms.Label DataTextFromIP2;
        private System.Windows.Forms.Label DataTextFromIP3;
        private System.Windows.Forms.Button buttonStop4;
        private System.Windows.Forms.Button buttonStart3;
        private System.Windows.Forms.Label IPOutputAnswer3;
        private System.Windows.Forms.TextBox IPadressBox3;
        private System.Windows.Forms.Label DataTextFromIP4;
        private System.Windows.Forms.Button buttonStop5;
        private System.Windows.Forms.Button buttonStart4;
        private System.Windows.Forms.Label IPOutputAnswer4;
        private System.Windows.Forms.TextBox IPadressBox4;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
    }
}