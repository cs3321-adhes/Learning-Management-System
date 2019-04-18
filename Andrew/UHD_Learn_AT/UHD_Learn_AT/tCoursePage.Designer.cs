namespace UHD_Learn
{
    partial class tCoursePage
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.syllabusLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 70);
            this.button1.TabIndex = 1;
            this.button1.Text = "Syllabus";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.syllabusLabel);
            this.panel1.Location = new System.Drawing.Point(346, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 315);
            this.panel1.TabIndex = 2;
            // 
            // syllabusLabel
            // 
            this.syllabusLabel.AutoSize = true;
            this.syllabusLabel.Location = new System.Drawing.Point(52, 33);
            this.syllabusLabel.Name = "syllabusLabel";
            this.syllabusLabel.Size = new System.Drawing.Size(61, 17);
            this.syllabusLabel.TabIndex = 0;
            this.syllabusLabel.Text = "Syllabus";
            this.syllabusLabel.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 202);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 70);
            this.button2.TabIndex = 3;
            this.button2.Text = "Assignments";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tCoursePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Name = "tCoursePage";
            this.Text = "tCoursePage";
            this.Load += new System.EventHandler(this.tCoursePage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label syllabusLabel;
        private System.Windows.Forms.Button button2;
    }
}