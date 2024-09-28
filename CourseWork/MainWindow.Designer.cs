namespace CourseWork
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.btnGenerateArray = new System.Windows.Forms.Button();
            this.btnReadArray = new System.Windows.Forms.Button();
            this.btnInputArray = new System.Windows.Forms.Button();
            this.selectMethod = new System.Windows.Forms.GroupBox();
            this.radioBtnIntroSort = new System.Windows.Forms.RadioButton();
            this.radioBtnQuickSort = new System.Windows.Forms.RadioButton();
            this.radioBtnMergeSort = new System.Windows.Forms.RadioButton();
            this.selectOrder = new System.Windows.Forms.GroupBox();
            this.radioBtnDescending = new System.Windows.Forms.RadioButton();
            this.radioBtnAscending = new System.Windows.Forms.RadioButton();
            this.btnOutputSortedArray = new System.Windows.Forms.Button();
            this.btnAnimateArray = new System.Windows.Forms.Button();
            this.btnSaveArray = new System.Windows.Forms.Button();
            this.btnSortArray = new System.Windows.Forms.Button();
            this.btnClearArray = new System.Windows.Forms.Button();
            this.btnOutputUnsortedArray = new System.Windows.Forms.Button();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.selectMethod.SuspendLayout();
            this.selectOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerateArray
            // 
            this.btnGenerateArray.Location = new System.Drawing.Point(12, 12);
            this.btnGenerateArray.Name = "btnGenerateArray";
            this.btnGenerateArray.Size = new System.Drawing.Size(217, 23);
            this.btnGenerateArray.TabIndex = 0;
            this.btnGenerateArray.Text = "Згенерувати масив";
            this.btnGenerateArray.UseVisualStyleBackColor = true;
            this.btnGenerateArray.Click += new System.EventHandler(this.btnGenerateArray_Click);
            // 
            // btnReadArray
            // 
            this.btnReadArray.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReadArray.Location = new System.Drawing.Point(12, 41);
            this.btnReadArray.Name = "btnReadArray";
            this.btnReadArray.Size = new System.Drawing.Size(217, 23);
            this.btnReadArray.TabIndex = 1;
            this.btnReadArray.Text = "Зчитати масив з файлу";
            this.toolTip1.SetToolTip(this.btnReadArray, resources.GetString("btnReadArray.ToolTip"));
            this.btnReadArray.UseVisualStyleBackColor = true;
            this.btnReadArray.Click += new System.EventHandler(this.btnReadArray_Click);
            // 
            // btnInputArray
            // 
            this.btnInputArray.Location = new System.Drawing.Point(12, 70);
            this.btnInputArray.Name = "btnInputArray";
            this.btnInputArray.Size = new System.Drawing.Size(217, 23);
            this.btnInputArray.TabIndex = 2;
            this.btnInputArray.Text = "Ввести масив";
            this.btnInputArray.UseVisualStyleBackColor = true;
            this.btnInputArray.Click += new System.EventHandler(this.btnInputArray_Click);
            // 
            // selectMethod
            // 
            this.selectMethod.Controls.Add(this.radioBtnIntroSort);
            this.selectMethod.Controls.Add(this.radioBtnQuickSort);
            this.selectMethod.Controls.Add(this.radioBtnMergeSort);
            this.selectMethod.Enabled = false;
            this.selectMethod.Location = new System.Drawing.Point(235, 12);
            this.selectMethod.Name = "selectMethod";
            this.selectMethod.Size = new System.Drawing.Size(217, 95);
            this.selectMethod.TabIndex = 5;
            this.selectMethod.TabStop = false;
            this.selectMethod.Text = "Метод сортування";
            // 
            // radioBtnIntroSort
            // 
            this.radioBtnIntroSort.AutoSize = true;
            this.radioBtnIntroSort.Location = new System.Drawing.Point(7, 68);
            this.radioBtnIntroSort.Name = "radioBtnIntroSort";
            this.radioBtnIntroSort.Size = new System.Drawing.Size(210, 17);
            this.radioBtnIntroSort.TabIndex = 8;
            this.radioBtnIntroSort.TabStop = true;
            this.radioBtnIntroSort.Text = "Метод інтроспективного сортування";
            this.radioBtnIntroSort.UseVisualStyleBackColor = true;
            this.radioBtnIntroSort.CheckedChanged += new System.EventHandler(this.radioBtnIntroSort_CheckedChanged);
            // 
            // radioBtnQuickSort
            // 
            this.radioBtnQuickSort.AutoSize = true;
            this.radioBtnQuickSort.Location = new System.Drawing.Point(7, 44);
            this.radioBtnQuickSort.Name = "radioBtnQuickSort";
            this.radioBtnQuickSort.Size = new System.Drawing.Size(170, 17);
            this.radioBtnQuickSort.TabIndex = 7;
            this.radioBtnQuickSort.TabStop = true;
            this.radioBtnQuickSort.Text = "Метод швидкого сортування";
            this.radioBtnQuickSort.UseVisualStyleBackColor = true;
            this.radioBtnQuickSort.CheckedChanged += new System.EventHandler(this.radioBtnQuickSort_CheckedChanged);
            // 
            // radioBtnMergeSort
            // 
            this.radioBtnMergeSort.AutoSize = true;
            this.radioBtnMergeSort.Checked = true;
            this.radioBtnMergeSort.Location = new System.Drawing.Point(7, 20);
            this.radioBtnMergeSort.Name = "radioBtnMergeSort";
            this.radioBtnMergeSort.Size = new System.Drawing.Size(163, 17);
            this.radioBtnMergeSort.TabIndex = 6;
            this.radioBtnMergeSort.TabStop = true;
            this.radioBtnMergeSort.Text = "Метод сортування злиттям";
            this.radioBtnMergeSort.UseVisualStyleBackColor = true;
            this.radioBtnMergeSort.CheckedChanged += new System.EventHandler(this.radioBtnMergeSort_CheckedChanged);
            // 
            // selectOrder
            // 
            this.selectOrder.Controls.Add(this.radioBtnDescending);
            this.selectOrder.Controls.Add(this.radioBtnAscending);
            this.selectOrder.Enabled = false;
            this.selectOrder.Location = new System.Drawing.Point(235, 113);
            this.selectOrder.Name = "selectOrder";
            this.selectOrder.Size = new System.Drawing.Size(217, 68);
            this.selectOrder.TabIndex = 9;
            this.selectOrder.TabStop = false;
            this.selectOrder.Text = "Порядок сортування";
            // 
            // radioBtnDescending
            // 
            this.radioBtnDescending.AutoSize = true;
            this.radioBtnDescending.Location = new System.Drawing.Point(7, 44);
            this.radioBtnDescending.Name = "radioBtnDescending";
            this.radioBtnDescending.Size = new System.Drawing.Size(97, 17);
            this.radioBtnDescending.TabIndex = 11;
            this.radioBtnDescending.TabStop = true;
            this.radioBtnDescending.Text = "За спаданням";
            this.radioBtnDescending.UseVisualStyleBackColor = true;
            this.radioBtnDescending.CheckedChanged += new System.EventHandler(this.radioBtnDescending_CheckedChanged);
            // 
            // radioBtnAscending
            // 
            this.radioBtnAscending.AutoSize = true;
            this.radioBtnAscending.Checked = true;
            this.radioBtnAscending.Location = new System.Drawing.Point(7, 20);
            this.radioBtnAscending.Name = "radioBtnAscending";
            this.radioBtnAscending.Size = new System.Drawing.Size(102, 17);
            this.radioBtnAscending.TabIndex = 10;
            this.radioBtnAscending.TabStop = true;
            this.radioBtnAscending.Text = "За зростанням";
            this.radioBtnAscending.UseVisualStyleBackColor = true;
            this.radioBtnAscending.CheckedChanged += new System.EventHandler(this.radioBtnAscending_CheckedChanged);
            // 
            // btnOutputSortedArray
            // 
            this.btnOutputSortedArray.Enabled = false;
            this.btnOutputSortedArray.Location = new System.Drawing.Point(458, 12);
            this.btnOutputSortedArray.Name = "btnOutputSortedArray";
            this.btnOutputSortedArray.Size = new System.Drawing.Size(217, 23);
            this.btnOutputSortedArray.TabIndex = 13;
            this.btnOutputSortedArray.Text = "Вивести відсортований масив";
            this.btnOutputSortedArray.UseVisualStyleBackColor = true;
            this.btnOutputSortedArray.Click += new System.EventHandler(this.btnOutputSortedArray_Click);
            // 
            // btnAnimateArray
            // 
            this.btnAnimateArray.Enabled = false;
            this.btnAnimateArray.Location = new System.Drawing.Point(458, 41);
            this.btnAnimateArray.Name = "btnAnimateArray";
            this.btnAnimateArray.Size = new System.Drawing.Size(217, 23);
            this.btnAnimateArray.TabIndex = 14;
            this.btnAnimateArray.Text = "Показати анімацію сортування";
            this.btnAnimateArray.UseVisualStyleBackColor = true;
            this.btnAnimateArray.Click += new System.EventHandler(this.btnAnimateArray_Click);
            // 
            // btnSaveArray
            // 
            this.btnSaveArray.Enabled = false;
            this.btnSaveArray.Location = new System.Drawing.Point(458, 70);
            this.btnSaveArray.Name = "btnSaveArray";
            this.btnSaveArray.Size = new System.Drawing.Size(217, 23);
            this.btnSaveArray.TabIndex = 15;
            this.btnSaveArray.Text = "Зберегти відсортований масив";
            this.btnSaveArray.UseVisualStyleBackColor = true;
            this.btnSaveArray.Click += new System.EventHandler(this.btnSaveArray_Click);
            // 
            // btnSortArray
            // 
            this.btnSortArray.Enabled = false;
            this.btnSortArray.Location = new System.Drawing.Point(235, 188);
            this.btnSortArray.Name = "btnSortArray";
            this.btnSortArray.Size = new System.Drawing.Size(217, 23);
            this.btnSortArray.TabIndex = 12;
            this.btnSortArray.Text = "Відсортувати масив";
            this.btnSortArray.UseVisualStyleBackColor = true;
            this.btnSortArray.Click += new System.EventHandler(this.btnSortArray_Click);
            // 
            // btnClearArray
            // 
            this.btnClearArray.Enabled = false;
            this.btnClearArray.Location = new System.Drawing.Point(12, 128);
            this.btnClearArray.Name = "btnClearArray";
            this.btnClearArray.Size = new System.Drawing.Size(217, 23);
            this.btnClearArray.TabIndex = 4;
            this.btnClearArray.Text = "Очистити масив";
            this.btnClearArray.UseVisualStyleBackColor = true;
            this.btnClearArray.Click += new System.EventHandler(this.btnClearArray_Click);
            // 
            // btnOutputUnsortedArray
            // 
            this.btnOutputUnsortedArray.Enabled = false;
            this.btnOutputUnsortedArray.Location = new System.Drawing.Point(12, 99);
            this.btnOutputUnsortedArray.Name = "btnOutputUnsortedArray";
            this.btnOutputUnsortedArray.Size = new System.Drawing.Size(217, 23);
            this.btnOutputUnsortedArray.TabIndex = 3;
            this.btnOutputUnsortedArray.Text = "Вивести невідсортований масив";
            this.btnOutputUnsortedArray.UseVisualStyleBackColor = true;
            this.btnOutputUnsortedArray.Click += new System.EventHandler(this.btnOutputUnsortedArray_Click);
            // 
            // saveFile
            // 
            this.saveFile.Filter = "Text files (*.txt)|*.txt";
            // 
            // openFile
            // 
            this.openFile.Filter = "Text files (*.txt)|*.txt";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(458, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 34);
            this.label1.TabIndex = 16;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Вимоги до файлу";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 221);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOutputUnsortedArray);
            this.Controls.Add(this.btnClearArray);
            this.Controls.Add(this.btnSortArray);
            this.Controls.Add(this.btnSaveArray);
            this.Controls.Add(this.btnAnimateArray);
            this.Controls.Add(this.btnOutputSortedArray);
            this.Controls.Add(this.selectOrder);
            this.Controls.Add(this.selectMethod);
            this.Controls.Add(this.btnInputArray);
            this.Controls.Add(this.btnReadArray);
            this.Controls.Add(this.btnGenerateArray);
            this.MinimumSize = new System.Drawing.Size(700, 260);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Упорядкування масивів";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.selectMethod.ResumeLayout(false);
            this.selectMethod.PerformLayout();
            this.selectOrder.ResumeLayout(false);
            this.selectOrder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerateArray;
        private System.Windows.Forms.Button btnReadArray;
        private System.Windows.Forms.Button btnInputArray;
        private System.Windows.Forms.GroupBox selectMethod;
        private System.Windows.Forms.RadioButton radioBtnIntroSort;
        private System.Windows.Forms.RadioButton radioBtnQuickSort;
        private System.Windows.Forms.RadioButton radioBtnMergeSort;
        private System.Windows.Forms.GroupBox selectOrder;
        private System.Windows.Forms.RadioButton radioBtnDescending;
        private System.Windows.Forms.RadioButton radioBtnAscending;
        private System.Windows.Forms.Button btnOutputSortedArray;
        private System.Windows.Forms.Button btnAnimateArray;
        private System.Windows.Forms.Button btnSaveArray;
        private System.Windows.Forms.Button btnSortArray;
        private System.Windows.Forms.Button btnClearArray;
        private System.Windows.Forms.Button btnOutputUnsortedArray;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

