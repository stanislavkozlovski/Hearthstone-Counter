﻿namespace Hearthstone_Counter
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loseButton = new System.Windows.Forms.Button();
            this.winButton = new System.Windows.Forms.Button();
            this.winCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lostLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loseButton
            // 
            this.loseButton.Location = new System.Drawing.Point(407, 295);
            this.loseButton.Name = "loseButton";
            this.loseButton.Size = new System.Drawing.Size(98, 42);
            this.loseButton.TabIndex = 1;
            this.loseButton.Text = "Lost.";
            this.loseButton.UseVisualStyleBackColor = true;
            this.loseButton.Click += new System.EventHandler(this.loseButton_Click);
            // 
            // winButton
            // 
            this.winButton.Location = new System.Drawing.Point(12, 295);
            this.winButton.Name = "winButton";
            this.winButton.Size = new System.Drawing.Size(98, 42);
            this.winButton.TabIndex = 2;
            this.winButton.Text = "Won!";
            this.winButton.UseVisualStyleBackColor = true;
            this.winButton.Click += new System.EventHandler(this.winButton_Click);
            // 
            // winCount
            // 
            this.winCount.AutoSize = true;
            this.winCount.Location = new System.Drawing.Point(24, 91);
            this.winCount.Name = "winCount";
            this.winCount.Size = new System.Drawing.Size(0, 13);
            this.winCount.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Won: ";
            // 
            // lostLabel
            // 
            this.lostLabel.AutoSize = true;
            this.lostLabel.Location = new System.Drawing.Point(461, 102);
            this.lostLabel.Name = "lostLabel";
            this.lostLabel.Size = new System.Drawing.Size(33, 13);
            this.lostLabel.TabIndex = 5;
            this.lostLabel.Text = "Lost: ";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(517, 349);
            this.Controls.Add(this.lostLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.winCount);
            this.Controls.Add(this.winButton);
            this.Controls.Add(this.loseButton);
            this.Name = "Form1";
            this.Text = "Hearthstone GameCounter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.Button loseButton;
        private System.Windows.Forms.Button winButton;
        private System.Windows.Forms.Label winCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lostLabel;
    }
}

