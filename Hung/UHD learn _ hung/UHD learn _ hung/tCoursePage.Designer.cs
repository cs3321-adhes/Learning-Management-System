﻿namespace UHD_Learn_AT
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.syllabusLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Home Page",
            "Assignments",
            "Grades"});
            this.listBox1.Location = new System.Drawing.Point(23, 71);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 84);
            this.listBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 73);
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
            // tCoursePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Name = "tCoursePage";
            this.Text = "tCoursePage";
            this.Load += new System.EventHandler(this.tCoursePage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label syllabusLabel;
    }
}