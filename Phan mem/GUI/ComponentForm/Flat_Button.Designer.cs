﻿namespace GUI.ComponentForm
{
    partial class Flat_Button
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
            this.SuspendLayout();
            // 
            // Flat_Button
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "Flat_Button";
            this.Size = new System.Drawing.Size(75, 23);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Flat_Button_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Flat_Button_MouseDown);
            this.MouseLeave += new System.EventHandler(this.Flat_Button_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Flat_Button_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Flat_Button_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
