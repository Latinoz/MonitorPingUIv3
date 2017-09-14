﻿namespace MonitorPingUI
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
            this.IPadressBox = new System.Windows.Forms.TextBox();
            this.IPOutputAnswer = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.DataTextFromIP = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
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
            this.IPOutputAnswer.Location = new System.Drawing.Point(199, 27);
            this.IPOutputAnswer.Name = "IPOutputAnswer";
            this.IPOutputAnswer.Size = new System.Drawing.Size(0, 13);
            this.IPOutputAnswer.TabIndex = 1;
            this.IPOutputAnswer.Tag = "";
            this.IPOutputAnswer.Click += new System.EventHandler(this.IPOutputAnswer_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(352, 23);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(94, 21);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(452, 23);
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
            this.DataTextFromIP.Location = new System.Drawing.Point(15, 51);
            this.DataTextFromIP.Name = "DataTextFromIP";
            this.DataTextFromIP.Size = new System.Drawing.Size(0, 13);
            this.DataTextFromIP.TabIndex = 4;
            this.DataTextFromIP.Click += new System.EventHandler(this.DataTextFromIP_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(452, 225);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(94, 21);
            this.buttonReset.TabIndex = 5;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 261);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.DataTextFromIP);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.IPOutputAnswer);
            this.Controls.Add(this.IPadressBox);
            this.Name = "MainForm";
            this.Text = "MonitorPingUI";
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
    }
}