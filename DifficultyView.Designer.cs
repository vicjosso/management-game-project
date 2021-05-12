﻿
namespace BaseSim2021
{
    partial class DifficultyView
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
            this.easyButton = new System.Windows.Forms.Button();
            this.midButton = new System.Windows.Forms.Button();
            this.hardButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // easyButton
            // 
            this.easyButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.easyButton.Location = new System.Drawing.Point(60, 84);
            this.easyButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.easyButton.Name = "easyButton";
            this.easyButton.Size = new System.Drawing.Size(58, 27);
            this.easyButton.TabIndex = 0;
            this.easyButton.Text = "Facile";
            this.easyButton.UseVisualStyleBackColor = true;
            this.easyButton.Click += new System.EventHandler(this.EasyButton_Click);
            // 
            // midButton
            // 
            this.midButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.midButton.Location = new System.Drawing.Point(146, 84);
            this.midButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.midButton.Name = "midButton";
            this.midButton.Size = new System.Drawing.Size(58, 27);
            this.midButton.TabIndex = 1;
            this.midButton.Text = "Moyen";
            this.midButton.UseVisualStyleBackColor = true;
            this.midButton.Click += new System.EventHandler(this.MidButton_Click);
            // 
            // hardButton
            // 
            this.hardButton.DialogResult = System.Windows.Forms.DialogResult.OK; //ligne rajouté
            this.hardButton.Location = new System.Drawing.Point(238, 84);
            this.hardButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hardButton.Name = "hardButton";
            this.hardButton.Size = new System.Drawing.Size(58, 27);
            this.hardButton.TabIndex = 2;
            this.hardButton.Text = "Difficile";
            this.hardButton.UseVisualStyleBackColor = true;
            this.hardButton.Click += new System.EventHandler(this.HardButton_Click); //ligne rajouté
            // 
            // DifficultyView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 234);
            this.Controls.Add(this.hardButton);
            this.Controls.Add(this.midButton);
            this.Controls.Add(this.easyButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DifficultyView";
            this.Text = "Choix de la difficulté";
            this.Load += new System.EventHandler(this.DifficultyView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button easyButton;
        private System.Windows.Forms.Button midButton;
        private System.Windows.Forms.Button hardButton;
    }
}