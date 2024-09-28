namespace CourseWork
{
    partial class GenerateWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.countNum = new System.Windows.Forms.NumericUpDown();
            this.countBox = new System.Windows.Forms.GroupBox();
            this.rangeBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maxValue = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.minValue = new System.Windows.Forms.NumericUpDown();
            this.btnRandom = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBtnDescending = new System.Windows.Forms.RadioButton();
            this.radioBtnAscending = new System.Windows.Forms.RadioButton();
            this.radioBtnRandom = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.countNum)).BeginInit();
            this.countBox.SuspendLayout();
            this.rangeBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minValue)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Від minNumElem до maxNumElem чисел";
            // 
            // countNum
            // 
            this.countNum.Location = new System.Drawing.Point(9, 38);
            this.countNum.Margin = new System.Windows.Forms.Padding(3, 50, 3, 3);
            this.countNum.Name = "countNum";
            this.countNum.Size = new System.Drawing.Size(168, 20);
            this.countNum.TabIndex = 1;
            // 
            // countBox
            // 
            this.countBox.Controls.Add(this.label1);
            this.countBox.Controls.Add(this.countNum);
            this.countBox.Location = new System.Drawing.Point(48, 8);
            this.countBox.Name = "countBox";
            this.countBox.Size = new System.Drawing.Size(188, 67);
            this.countBox.TabIndex = 3;
            this.countBox.TabStop = false;
            this.countBox.Text = "Кількість чисел для генерації";
            // 
            // rangeBox
            // 
            this.rangeBox.Controls.Add(this.label4);
            this.rangeBox.Controls.Add(this.label3);
            this.rangeBox.Controls.Add(this.maxValue);
            this.rangeBox.Controls.Add(this.label2);
            this.rangeBox.Controls.Add(this.minValue);
            this.rangeBox.Location = new System.Drawing.Point(48, 81);
            this.rangeBox.Name = "rangeBox";
            this.rangeBox.Size = new System.Drawing.Size(188, 133);
            this.rangeBox.TabIndex = 4;
            this.rangeBox.TabStop = false;
            this.rangeBox.Text = "Діапазон генерації";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Максимальне значення";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Мінімальне значення";
            // 
            // maxValue
            // 
            this.maxValue.Location = new System.Drawing.Point(9, 105);
            this.maxValue.Margin = new System.Windows.Forms.Padding(3, 50, 3, 3);
            this.maxValue.Name = "maxValue";
            this.maxValue.Size = new System.Drawing.Size(168, 20);
            this.maxValue.TabIndex = 2;
            this.maxValue.ValueChanged += new System.EventHandler(this.maxValue_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Максимальний діапазон генерації\nвід minNum до maxNum";
            // 
            // minValue
            // 
            this.minValue.Location = new System.Drawing.Point(9, 66);
            this.minValue.Margin = new System.Windows.Forms.Padding(3, 50, 3, 3);
            this.minValue.Name = "minValue";
            this.minValue.Size = new System.Drawing.Size(168, 20);
            this.minValue.TabIndex = 1;
            this.minValue.ValueChanged += new System.EventHandler(this.minValue_ValueChanged);
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(57, 321);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(168, 23);
            this.btnRandom.TabIndex = 5;
            this.btnRandom.Text = "Згенерувати";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtnDescending);
            this.groupBox1.Controls.Add(this.radioBtnAscending);
            this.groupBox1.Controls.Add(this.radioBtnRandom);
            this.groupBox1.Location = new System.Drawing.Point(48, 221);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 94);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип генерації";
            // 
            // radioBtnDescending
            // 
            this.radioBtnDescending.AutoSize = true;
            this.radioBtnDescending.Location = new System.Drawing.Point(9, 67);
            this.radioBtnDescending.Name = "radioBtnDescending";
            this.radioBtnDescending.Size = new System.Drawing.Size(154, 17);
            this.radioBtnDescending.TabIndex = 2;
            this.radioBtnDescending.TabStop = true;
            this.radioBtnDescending.Text = "Зворотно впорядкований";
            this.radioBtnDescending.UseVisualStyleBackColor = true;
            // 
            // radioBtnAscending
            // 
            this.radioBtnAscending.AutoSize = true;
            this.radioBtnAscending.Location = new System.Drawing.Point(9, 43);
            this.radioBtnAscending.Name = "radioBtnAscending";
            this.radioBtnAscending.Size = new System.Drawing.Size(104, 17);
            this.radioBtnAscending.TabIndex = 1;
            this.radioBtnAscending.TabStop = true;
            this.radioBtnAscending.Text = "Впорядкований";
            this.radioBtnAscending.UseVisualStyleBackColor = true;
            // 
            // radioBtnRandom
            // 
            this.radioBtnRandom.AutoSize = true;
            this.radioBtnRandom.Checked = true;
            this.radioBtnRandom.Location = new System.Drawing.Point(9, 20);
            this.radioBtnRandom.Name = "radioBtnRandom";
            this.radioBtnRandom.Size = new System.Drawing.Size(86, 17);
            this.radioBtnRandom.TabIndex = 0;
            this.radioBtnRandom.TabStop = true;
            this.radioBtnRandom.Text = "Випадковий";
            this.radioBtnRandom.UseVisualStyleBackColor = true;
            // 
            // GenerateWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 351);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rangeBox);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.countBox);
            this.MinimumSize = new System.Drawing.Size(300, 290);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GenerateWindow";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Згенерувати масив";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GenerateWindow_FormClosing);
            this.Load += new System.EventHandler(this.GenerateWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.countNum)).EndInit();
            this.countBox.ResumeLayout(false);
            this.countBox.PerformLayout();
            this.rangeBox.ResumeLayout(false);
            this.rangeBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minValue)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown countNum;
        private System.Windows.Forms.GroupBox countBox;
        private System.Windows.Forms.GroupBox rangeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown minValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown maxValue;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioBtnDescending;
        private System.Windows.Forms.RadioButton radioBtnAscending;
        private System.Windows.Forms.RadioButton radioBtnRandom;
    }
}