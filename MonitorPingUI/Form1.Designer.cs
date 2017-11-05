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
            this.SuspendLayout();
            // 
            // IPadressBox
            // 
            this.IPadressBox.Location = new System.Drawing.Point(13, 23);
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
            this.IPOutputAnswer.Location = new System.Drawing.Point(192, 27);
            this.IPOutputAnswer.Name = "IPOutputAnswer";
            this.IPOutputAnswer.Size = new System.Drawing.Size(0, 13);
            this.IPOutputAnswer.TabIndex = 1;
            this.IPOutputAnswer.Tag = "";
            this.IPOutputAnswer.Click += new System.EventHandler(this.IPOutputAnswer_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(354, 23);
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
            this.buttonStop.Location = new System.Drawing.Point(454, 23);
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
            this.DataTextFromIP.Location = new System.Drawing.Point(16, 46);
            this.DataTextFromIP.Name = "DataTextFromIP";
            this.DataTextFromIP.Size = new System.Drawing.Size(0, 13);
            this.DataTextFromIP.TabIndex = 4;
            this.DataTextFromIP.Click += new System.EventHandler(this.DataTextFromIP_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(454, 225);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(94, 21);
            this.buttonReset.TabIndex = 5;
            this.buttonReset.Text = "Clear";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // IPadressBox1
            // 
            this.IPadressBox1.Location = new System.Drawing.Point(12, 63);
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
            this.IPOutputAnswer1.Location = new System.Drawing.Point(192, 68);
            this.IPOutputAnswer1.Name = "IPOutputAnswer1";
            this.IPOutputAnswer1.Size = new System.Drawing.Size(0, 13);
            this.IPOutputAnswer1.TabIndex = 7;
            this.IPOutputAnswer1.Tag = "";
            this.IPOutputAnswer1.Click += new System.EventHandler(this.IPOutputAnswer1_Click);
            // 
            // DataTextFromIP1
            // 
            this.DataTextFromIP1.AutoSize = true;
            this.DataTextFromIP1.Location = new System.Drawing.Point(15, 86);
            this.DataTextFromIP1.Name = "DataTextFromIP1";
            this.DataTextFromIP1.Size = new System.Drawing.Size(0, 13);
            this.DataTextFromIP1.TabIndex = 8;
            this.DataTextFromIP1.Click += new System.EventHandler(this.DataTextFromIP1_Click);
            // 
            // buttonStart1
            // 
            this.buttonStart1.Location = new System.Drawing.Point(354, 64);
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
            this.buttonStop2.Location = new System.Drawing.Point(454, 64);
            this.buttonStop2.Name = "buttonStop2";
            this.buttonStop2.Size = new System.Drawing.Size(94, 21);
            this.buttonStop2.TabIndex = 10;
            this.buttonStop2.Text = "Stop";
            this.buttonStop2.UseVisualStyleBackColor = true;
            this.buttonStop2.Click += new System.EventHandler(this.buttonStop2_Click);
            // 
            // IPadressBox2
            // 
            this.IPadressBox2.Location = new System.Drawing.Point(12, 105);
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
            this.IPOutputAnswer2.Location = new System.Drawing.Point(192, 110);
            this.IPOutputAnswer2.Name = "IPOutputAnswer2";
            this.IPOutputAnswer2.Size = new System.Drawing.Size(0, 13);
            this.IPOutputAnswer2.TabIndex = 12;
            this.IPOutputAnswer2.Tag = "";
            this.IPOutputAnswer2.Click += new System.EventHandler(this.IPOutputAnswer2_Click);
            // 
            // buttonStart2
            // 
            this.buttonStart2.Location = new System.Drawing.Point(354, 104);
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
            this.buttonStop3.Location = new System.Drawing.Point(454, 104);
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
            this.DataTextFromIP2.Location = new System.Drawing.Point(15, 129);
            this.DataTextFromIP2.Name = "DataTextFromIP2";
            this.DataTextFromIP2.Size = new System.Drawing.Size(0, 13);
            this.DataTextFromIP2.TabIndex = 15;
            this.DataTextFromIP2.Click += new System.EventHandler(this.DataTextFromIP2_Click);
            // 
            // DataTextFromIP3
            // 
            this.DataTextFromIP3.AutoSize = true;
            this.DataTextFromIP3.Location = new System.Drawing.Point(15, 170);
            this.DataTextFromIP3.Name = "DataTextFromIP3";
            this.DataTextFromIP3.Size = new System.Drawing.Size(0, 13);
            this.DataTextFromIP3.TabIndex = 20;
            this.DataTextFromIP3.Click += new System.EventHandler(this.DataTextFromIP3_Click);
            // 
            // buttonStop4
            // 
            this.buttonStop4.Enabled = false;
            this.buttonStop4.Location = new System.Drawing.Point(454, 145);
            this.buttonStop4.Name = "buttonStop4";
            this.buttonStop4.Size = new System.Drawing.Size(94, 21);
            this.buttonStop4.TabIndex = 19;
            this.buttonStop4.Text = "Stop";
            this.buttonStop4.UseVisualStyleBackColor = true;
            this.buttonStop4.Click += new System.EventHandler(this.buttonStop4_Click);
            // 
            // buttonStart3
            // 
            this.buttonStart3.Location = new System.Drawing.Point(354, 145);
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
            this.IPOutputAnswer3.Location = new System.Drawing.Point(192, 151);
            this.IPOutputAnswer3.Name = "IPOutputAnswer3";
            this.IPOutputAnswer3.Size = new System.Drawing.Size(0, 13);
            this.IPOutputAnswer3.TabIndex = 17;
            this.IPOutputAnswer3.Tag = "";
            this.IPOutputAnswer3.Click += new System.EventHandler(this.IPOutputAnswer3_Click);
            // 
            // IPadressBox3
            // 
            this.IPadressBox3.Location = new System.Drawing.Point(12, 146);
            this.IPadressBox3.Name = "IPadressBox3";
            this.IPadressBox3.Size = new System.Drawing.Size(175, 20);
            this.IPadressBox3.TabIndex = 16;
            this.IPadressBox3.Text = "127.0.0.1";
            this.IPadressBox3.TextChanged += new System.EventHandler(this.IPadressBox3_TextChanged);
            // 
            // DataTextFromIP4
            // 
            this.DataTextFromIP4.AutoSize = true;
            this.DataTextFromIP4.Location = new System.Drawing.Point(14, 212);
            this.DataTextFromIP4.Name = "DataTextFromIP4";
            this.DataTextFromIP4.Size = new System.Drawing.Size(0, 13);
            this.DataTextFromIP4.TabIndex = 25;
            this.DataTextFromIP4.Click += new System.EventHandler(this.DataTextFromIP4_Click);
            // 
            // buttonStop5
            // 
            this.buttonStop5.Enabled = false;
            this.buttonStop5.Location = new System.Drawing.Point(453, 187);
            this.buttonStop5.Name = "buttonStop5";
            this.buttonStop5.Size = new System.Drawing.Size(94, 21);
            this.buttonStop5.TabIndex = 24;
            this.buttonStop5.Text = "Stop";
            this.buttonStop5.UseVisualStyleBackColor = true;
            this.buttonStop5.Click += new System.EventHandler(this.buttonStop5_Click);
            // 
            // buttonStart4
            // 
            this.buttonStart4.Location = new System.Drawing.Point(353, 187);
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
            this.IPOutputAnswer4.Location = new System.Drawing.Point(191, 193);
            this.IPOutputAnswer4.Name = "IPOutputAnswer4";
            this.IPOutputAnswer4.Size = new System.Drawing.Size(0, 13);
            this.IPOutputAnswer4.TabIndex = 22;
            this.IPOutputAnswer4.Tag = "";
            this.IPOutputAnswer4.Click += new System.EventHandler(this.IPOutputAnswer4_Click);
            // 
            // IPadressBox4
            // 
            this.IPadressBox4.Location = new System.Drawing.Point(11, 188);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 261);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Text = "MonitorPingUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
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
    }
}