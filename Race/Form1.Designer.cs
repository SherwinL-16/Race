using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Race
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnStart = new Button();
            btnRestart = new Button();
            btnQuit = new Button();
            label1 = new Label();
            panel4 = new Panel();
            lblCountdown = new Label();
            lblRunner1 = new Label();
            lblRunner2 = new Label();
            lblRunner3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.AutoSize = true;
            btnStart.BackColor = SystemColors.ActiveBorder;
            btnStart.BackgroundImage = Properties.Resources.OIP__1_;
            btnStart.BackgroundImageLayout = ImageLayout.Center;
            btnStart.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnStart.ForeColor = Color.FromArgb(192, 0, 0);
            btnStart.Location = new Point(12, 391);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(115, 47);
            btnStart.TabIndex = 0;
            btnStart.Text = "START";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // btnRestart
            // 
            btnRestart.BackgroundImage = Properties.Resources.OIP__1_;
            btnRestart.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnRestart.Location = new Point(133, 391);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(115, 47);
            btnRestart.TabIndex = 4;
            btnRestart.Text = "Restart";
            btnRestart.UseVisualStyleBackColor = true;
            btnRestart.Click += btnRestart_Click;
            // 
            // btnQuit
            // 
            btnQuit.BackgroundImage = Properties.Resources.OIP__1_;
            btnQuit.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnQuit.ForeColor = SystemColors.AppWorkspace;
            btnQuit.Location = new Point(254, 391);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(115, 47);
            btnQuit.TabIndex = 5;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(291, 144);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.AutoSize = true;
            panel4.BackColor = Color.FromArgb(255, 128, 128);
            panel4.BackgroundImage = Properties.Resources.race_flag_10;
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Controls.Add(lblCountdown);
            panel4.ForeColor = SystemColors.ActiveCaptionText;
            panel4.Location = new Point(365, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(203, 84);
            panel4.TabIndex = 7;
            // 
            // lblCountdown
            // 
            lblCountdown.AutoSize = true;
            lblCountdown.BackColor = Color.DimGray;
            lblCountdown.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCountdown.ForeColor = SystemColors.ButtonHighlight;
            lblCountdown.Location = new Point(38, 32);
            lblCountdown.Name = "lblCountdown";
            lblCountdown.Size = new Size(115, 18);
            lblCountdown.TabIndex = 0;
            lblCountdown.Text = "Countdown";
            lblCountdown.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblRunner1
            // 
            lblRunner1.AutoSize = true;
            lblRunner1.BackColor = SystemColors.ActiveCaption;
            lblRunner1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblRunner1.Location = new Point(17, 118);
            lblRunner1.Name = "lblRunner1";
            lblRunner1.Size = new Size(85, 24);
            lblRunner1.TabIndex = 0;
            lblRunner1.Text = "CAR 1#";
            // 
            // lblRunner2
            // 
            lblRunner2.AutoSize = true;
            lblRunner2.BackColor = Color.FromArgb(128, 255, 128);
            lblRunner2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblRunner2.Location = new Point(17, 231);
            lblRunner2.Name = "lblRunner2";
            lblRunner2.Size = new Size(85, 24);
            lblRunner2.TabIndex = 0;
            lblRunner2.Text = "CAR 2#";
            lblRunner2.Click += lblRunner2_Click;
            // 
            // lblRunner3
            // 
            lblRunner3.AutoSize = true;
            lblRunner3.BackColor = Color.FromArgb(255, 128, 255);
            lblRunner3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblRunner3.Location = new Point(17, 328);
            lblRunner3.Name = "lblRunner3";
            lblRunner3.Size = new Size(85, 24);
            lblRunner3.TabIndex = 0;
            lblRunner3.Text = "CAR 3#";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(128, 27);
            label2.TabIndex = 14;
            label2.Text = "CAR RACING";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveBorder;
            pictureBox1.Image = Properties.Resources._8c637c76d068d6125eaf11b6a9a46455;
            pictureBox1.Location = new Point(187, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1324, 509);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._7e375c6c1e81af9e4ce25b4bc43461af;
            ClientSize = new Size(922, 470);
            Controls.Add(lblRunner3);
            Controls.Add(lblRunner2);
            Controls.Add(lblRunner1);
            Controls.Add(label2);
            Controls.Add(panel4);
            Controls.Add(label1);
            Controls.Add(btnQuit);
            Controls.Add(btnRestart);
            Controls.Add(btnStart);
            Controls.Add(pictureBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private Button btnRestart;
        private Button btnQuit;
        private Label label1;
        private Panel panel4;
        private Label lblCountdown;
        public Label lblRunner1;
        public Label lblRunner2;
        public Label lblRunner3;
        private Label label2;
        private PictureBox pictureBox1;
    }
}
