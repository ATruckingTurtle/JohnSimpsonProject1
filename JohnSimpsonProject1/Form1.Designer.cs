﻿namespace JohnSimpsonProject1
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
            CarLotAccess = new Button();
            SuspendLayout();
            // 
            // CarLotAccess
            // 
            CarLotAccess.Location = new Point(365, 290);
            CarLotAccess.Name = "CarLotAccess";
            CarLotAccess.Size = new Size(147, 23);
            CarLotAccess.TabIndex = 0;
            CarLotAccess.Text = "Take me to the Car Lot!";
            CarLotAccess.UseVisualStyleBackColor = true;
            CarLotAccess.Click += CarLotAccess_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CarLotAccess);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button CarLotAccess;
    }
}
