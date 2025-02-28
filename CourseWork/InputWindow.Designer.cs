﻿namespace CourseWork
{
    partial class InputWindow
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
            this.inputBox = new System.Windows.Forms.GroupBox();
            this.btnAddElem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numValue = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numValue)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 160);
            this.listBox1.TabIndex = 0;
            // 
            // inputBox
            // 
            this.inputBox.Controls.Add(this.btnAddElem);
            this.inputBox.Controls.Add(this.label1);
            this.inputBox.Controls.Add(this.numValue);
            this.inputBox.Location = new System.Drawing.Point(153, 74);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(210, 96);
            this.inputBox.TabIndex = 4;
            this.inputBox.TabStop = false;
            this.inputBox.Text = "Ввід числа для додавання у масив";
            // 
            // btnAddElem
            // 
            this.btnAddElem.Location = new System.Drawing.Point(70, 64);
            this.btnAddElem.Name = "btnAddElem";
            this.btnAddElem.Size = new System.Drawing.Size(75, 23);
            this.btnAddElem.TabIndex = 2;
            this.btnAddElem.Text = "Додати";
            this.btnAddElem.UseVisualStyleBackColor = true;
            this.btnAddElem.Click += new System.EventHandler(this.btnAddElem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Значення від minNum до maxNum";
            // 
            // numValue
            // 
            this.numValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numValue.Location = new System.Drawing.Point(9, 38);
            this.numValue.Margin = new System.Windows.Forms.Padding(3, 50, 3, 3);
            this.numValue.Name = "numValue";
            this.numValue.Size = new System.Drawing.Size(195, 20);
            this.numValue.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Допустима кількість чисел для\r\nвводу від minNumElem до maxNumElem";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 6;
            // 
            // InputWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 186);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.listBox1);
            this.MinimumSize = new System.Drawing.Size(395, 225);
            this.MaximizeBox = false;
            this.Name = "InputWindow";
            this.Text = "Ввід маисву";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InputWindow_FormClosing);
            this.Load += new System.EventHandler(this.InputWindow_Load);
            this.inputBox.ResumeLayout(false);
            this.inputBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox inputBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numValue;
        private System.Windows.Forms.Button btnAddElem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}