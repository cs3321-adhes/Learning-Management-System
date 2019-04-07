namespace UHD_Learn_AT
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
            this.label1.Location = new System.Drawing.Point(629, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(548, 48);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 23);
            this.logoutButton.TabIndex = 1;
            this.logoutButton.Text = "LOG OUT";
            this.logoutButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Courses";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.courseLabel4);
            this.groupBox1.Controls.Add(this.courseLabel3);
            this.groupBox1.Controls.Add(this.courseLabel2);
            this.groupBox1.Controls.Add(this.courseLabel1);
            this.groupBox1.Location = new System.Drawing.Point(24, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(289, 366);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // courseLabel4
            // 
            this.courseLabel4.AutoSize = true;
            this.courseLabel4.Location = new System.Drawing.Point(13, 185);
            this.courseLabel4.Name = "courseLabel4";
            this.courseLabel4.Size = new System.Drawing.Size(55, 13);
            this.courseLabel4.TabIndex = 3;
            this.courseLabel4.TabStop = true;
            this.courseLabel4.Text = "linkLabel4";
            // 
            // courseLabel3
            // 
            this.courseLabel3.AutoSize = true;
            this.courseLabel3.Location = new System.Drawing.Point(13, 139);
            this.courseLabel3.Name = "courseLabel3";
            this.courseLabel3.Size = new System.Drawing.Size(55, 13);
            this.courseLabel3.TabIndex = 2;
            this.courseLabel3.TabStop = true;
            this.courseLabel3.Text = "linkLabel3";
            // 
            // courseLabel2
            // 
            this.courseLabel2.AutoSize = true;
            this.courseLabel2.Location = new System.Drawing.Point(13, 94);
            this.courseLabel2.Name = "courseLabel2";
            this.courseLabel2.Size = new System.Drawing.Size(55, 13);
            this.courseLabel2.TabIndex = 1;
            this.courseLabel2.TabStop = true;
            this.courseLabel2.Text = "linkLabel2";
            // 
            // courseLabel1
            // 
            this.courseLabel1.AutoSize = true;
            this.courseLabel1.Location = new System.Drawing.Point(13, 51);
            this.courseLabel1.Name = "courseLabel1";
            this.courseLabel1.Size = new System.Drawing.Size(55, 13);
            this.courseLabel1.TabIndex = 0;
            this.courseLabel1.TabStop = true;
            this.courseLabel1.Text = "linkLabel1";
            // 
            // TeacherPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
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