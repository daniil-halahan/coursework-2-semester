namespace CourseWork
{
    partial class AnimationWindow
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
            this.animArea = new System.Windows.Forms.Panel();
            this.btnStartAnim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // animArea
            // 
            this.animArea.Location = new System.Drawing.Point(12, 12);
            this.animArea.Name = "animArea";
            this.animArea.Size = new System.Drawing.Size(960, 337);
            this.animArea.TabIndex = 0;
            // 
            // btnStartAnim
            // 
            this.btnStartAnim.Location = new System.Drawing.Point(431, 355);
            this.btnStartAnim.Name = "btnStartAnim";
            this.btnStartAnim.Size = new System.Drawing.Size(138, 23);
            this.btnStartAnim.TabIndex = 1;
            this.btnStartAnim.Text = "Почати анімацію";
            this.btnStartAnim.UseVisualStyleBackColor = true;
            this.btnStartAnim.Click += new System.EventHandler(this.btnStartAnim_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(858, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Анімація завершена";
            this.label1.Visible = false;
            // 
            // AnimationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 387);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStartAnim);
            this.Controls.Add(this.animArea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AnimationWindow";
            this.Text = "Анімація сортування";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnimationWindow_FormClosing);
            this.Load += new System.EventHandler(this.AnimationWindow_Load);
            this.Shown += new System.EventHandler(this.AnimationWindow_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel animArea;
        private System.Windows.Forms.Button btnStartAnim;
        private System.Windows.Forms.Label label1;
    }
}