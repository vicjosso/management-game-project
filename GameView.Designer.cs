﻿
namespace BaseSim2021
{
    partial class GameView
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
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.outputListBox = new System.Windows.Forms.ListBox();
            this.diffLabel = new System.Windows.Forms.Label();
            this.turnLabel = new System.Windows.Forms.Label();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.gloryLabel = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(106, 303);
            this.inputTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(459, 20);
            this.inputTextBox.TabIndex = 0;
            this.inputTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputTextBox_KeyDown);
            // 
            // outputListBox
            // 
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.HorizontalScrollbar = true;
            this.outputListBox.Location = new System.Drawing.Point(6, 6);
            this.outputListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(1005, 277);
            this.outputListBox.TabIndex = 1;
            // 
            // diffLabel
            // 
            this.diffLabel.AutoSize = true;
            this.diffLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.diffLabel.Location = new System.Drawing.Point(42, 360);
            this.diffLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.diffLabel.Name = "diffLabel";
            this.diffLabel.Size = new System.Drawing.Size(22, 13);
            this.diffLabel.TabIndex = 2;
            this.diffLabel.Text = "     ";
            // 
            // turnLabel
            // 
            this.turnLabel.AutoSize = true;
            this.turnLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.turnLabel.Location = new System.Drawing.Point(200, 360);
            this.turnLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.turnLabel.Name = "turnLabel";
            this.turnLabel.Size = new System.Drawing.Size(19, 13);
            this.turnLabel.TabIndex = 3;
            this.turnLabel.Text = "    ";
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.moneyLabel.Location = new System.Drawing.Point(452, 360);
            this.moneyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(16, 13);
            this.moneyLabel.TabIndex = 4;
            this.moneyLabel.Text = "   ";
            // 
            // gloryLabel
            // 
            this.gloryLabel.AutoSize = true;
            this.gloryLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gloryLabel.Location = new System.Drawing.Point(682, 360);
            this.gloryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gloryLabel.Name = "gloryLabel";
            this.gloryLabel.Size = new System.Drawing.Size(16, 13);
            this.gloryLabel.TabIndex = 5;
            this.gloryLabel.Text = "   ";
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(874, 360);
            this.nextButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(80, 21);
            this.nextButton.TabIndex = 6;
            this.nextButton.Text = "Tour Suivant";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // GameView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(962, 431);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.gloryLabel);
            this.Controls.Add(this.moneyLabel);
            this.Controls.Add(this.turnLabel);
            this.Controls.Add(this.diffLabel);
            this.Controls.Add(this.outputListBox);
            this.Controls.Add(this.inputTextBox);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GameView";
            this.Text = "Fenêtre Principale";
            this.Load += new System.EventHandler(this.GameView_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameView_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.ListBox outputListBox;
        private System.Windows.Forms.Label diffLabel;
        private System.Windows.Forms.Label turnLabel;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.Label gloryLabel;
        private System.Windows.Forms.Button nextButton;
    }
}

