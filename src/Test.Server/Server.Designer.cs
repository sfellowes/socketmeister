﻿namespace Test.Server
{
    partial class Server
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LabelSessionCount = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LabelStatus = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.StatusIndicator = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LabelPort = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(2);
            this.panel1.Size = new System.Drawing.Size(448, 30);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.LabelSessionCount);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.LabelStatus);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(300, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(2);
            this.panel3.Size = new System.Drawing.Size(146, 26);
            this.panel3.TabIndex = 1;
            // 
            // LabelSessionCount
            // 
            this.LabelSessionCount.Dock = System.Windows.Forms.DockStyle.Right;
            this.LabelSessionCount.Location = new System.Drawing.Point(5, 2);
            this.LabelSessionCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelSessionCount.Name = "LabelSessionCount";
            this.LabelSessionCount.Size = new System.Drawing.Size(30, 22);
            this.LabelSessionCount.TabIndex = 4;
            this.LabelSessionCount.Text = "0";
            this.LabelSessionCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Test.Server.Properties.Resources.person_24;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Location = new System.Drawing.Point(35, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 22);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // LabelStatus
            // 
            this.LabelStatus.Dock = System.Windows.Forms.DockStyle.Right;
            this.LabelStatus.Location = new System.Drawing.Point(58, 2);
            this.LabelStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(64, 22);
            this.LabelStatus.TabIndex = 2;
            this.LabelStatus.Text = "Stopped";
            this.LabelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.StatusIndicator);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(122, 2);
            this.panel4.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(2);
            this.panel4.Size = new System.Drawing.Size(22, 22);
            this.panel4.TabIndex = 1;
            // 
            // StatusIndicator
            // 
            this.StatusIndicator.BackColor = System.Drawing.Color.Red;
            this.StatusIndicator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StatusIndicator.Dock = System.Windows.Forms.DockStyle.Right;
            this.StatusIndicator.Location = new System.Drawing.Point(2, 2);
            this.StatusIndicator.Margin = new System.Windows.Forms.Padding(2);
            this.StatusIndicator.Name = "StatusIndicator";
            this.StatusIndicator.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StatusIndicator.Size = new System.Drawing.Size(16, 16);
            this.StatusIndicator.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LabelPort);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(2);
            this.panel2.Size = new System.Drawing.Size(157, 26);
            this.panel2.TabIndex = 0;
            // 
            // LabelPort
            // 
            this.LabelPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelPort.Location = new System.Drawing.Point(2, 2);
            this.LabelPort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelPort.Name = "LabelPort";
            this.LabelPort.Size = new System.Drawing.Size(153, 22);
            this.LabelPort.TabIndex = 0;
            this.LabelPort.Text = "Socket Server on Port 65000";
            this.LabelPort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Server";
            this.Size = new System.Drawing.Size(448, 136);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LabelStatus;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel StatusIndicator;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LabelPort;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LabelSessionCount;
    }
}
