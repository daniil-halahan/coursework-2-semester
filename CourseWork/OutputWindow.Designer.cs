﻿namespace CourseWork
{
    partial class OutputWindow
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lableNumElem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 30);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(180, 329);
            this.listBox1.TabIndex = 0;
            // 
            // lableNumElem
            // 
            this.lableNumElem.AutoSize = true;
            this.lableNumElem.Location = new System.Drawing.Point(12, 9);
            this.lableNumElem.Name = "lableNumElem";
            this.lableNumElem.Size = new System.Drawing.Size(91, 13);
            this.lableNumElem.TabIndex = 1;
            this.lableNumElem.Text = "Кількість чисел: ";
            // 
            // OutputWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 361);
            this.Controls.Add(this.lableNumElem);
            this.Controls.Add(this.listBox1);
            this.MinimumSize = new System.Drawing.Size(220, 400);
            this.Name = "OutputWindow";
            this.Text = "Масив";
            this.Load += new System.EventHandler(this.OutputWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lableNumElem;
    }
}