namespace UHD_Learn
{
    partial class TeacherPage
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
            this.logoutButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.courseLabel4 = new System.Windows.Forms.LinkLabel();
            this.courseLabel3 = new System.Windows.Forms.LinkLabel();
            this.courseLabel2 = new System.Windows.Forms.LinkLabel();
            this.courseLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(839, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(731, 59);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(100, 28);
            this.logoutButton.TabIndex = 1;
            this.logoutButton.Text = "LOG OUT";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Courses";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.courseLabel4);
            this.groupBox1.Controls.Add(this.courseLabel3);
            this.groupBox1.Controls.Add(this.courseLabel2);
            this.groupBox1.Controls.Add(this.courseLabel1);
            this.groupBox1.Location = new System.Drawing.Point(32, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBox1.Size = new System.Drawing.Size(385, 450);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // courseLabel4
            // 
            this.courseLabel4.AutoSize = true;
            this.courseLabel4.Location = new System.Drawing.Point(17, 228);
            this.courseLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.courseLabel4.Name = "courseLabel4";
            this.courseLabel4.Size = new System.Drawing.Size(72, 17);
            this.courseLabel4.TabIndex = 3;
            this.courseLabel4.TabStop = true;
            this.courseLabel4.Text = "linkLabel4";
            this.courseLabel4.Visible = false;
            // 
            // courseLabel3
            // 
            this.courseLabel3.AutoSize = true;
            this.courseLabel3.Location = new System.Drawing.Point(17, 171);
            this.courseLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.courseLabel3.Name = "courseLabel3";
            this.courseLabel3.Size = new System.Drawing.Size(72, 17);
            this.courseLabel3.TabIndex = 2;
            this.courseLabel3.TabStop = true;
            this.courseLabel3.Text = "linkLabel3";
            this.courseLabel3.Visible = false;
            // 
            // courseLabel2
            // 
            this.courseLabel2.AutoSize = true;
            this.courseLabel2.Location = new System.Drawing.Point(17, 116);
            this.courseLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.courseLabel2.Name = "courseLabel2";
            this.courseLabel2.Size = new System.Drawing.Size(72, 17);
            this.courseLabel2.TabIndex = 1;
            this.courseLabel2.TabStop = true;
            this.courseLabel2.Text = "linkLabel2";
            this.courseLabel2.Visible = false;
            // 
            // courseLabel1
            // 
            this.courseLabel1.AutoSize = true;
            this.courseLabel1.Location = new System.Drawing.Point(17, 63);
            this.courseLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.courseLabel1.Name = "courseLabel1";
            this.courseLabel1.Size = new System.Drawing.Size(72, 17);
            this.courseLabel1.TabIndex = 0;
            this.courseLabel1.TabStop = true;
            this.courseLabel1.Text = "linkLabel1";
            this.courseLabel1.Visible = false;
            this.courseLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.courseLabel1_LinkClicked);
            // 
            // TeacherPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TeacherPage";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TeacherPage_FormClosed);
            this.Load += new System.EventHandler(this.TeacherPage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel courseLabel4;
        private System.Windows.Forms.LinkLabel courseLabel3;
        private System.Windows.Forms.LinkLabel courseLabel2;
        private System.Windows.Forms.LinkLabel courseLabel1;
    }
}