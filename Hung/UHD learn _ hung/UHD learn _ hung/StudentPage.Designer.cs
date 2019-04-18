namespace UHD_Learn
{
    partial class StudentPage
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.courseLabel4 = new System.Windows.Forms.LinkLabel();
            this.courseLabel3 = new System.Windows.Forms.LinkLabel();
            this.courseLabel2 = new System.Windows.Forms.LinkLabel();
            this.courseLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.courseLabel4);
            this.groupBox1.Controls.Add(this.courseLabel3);
            this.groupBox1.Controls.Add(this.courseLabel2);
            this.groupBox1.Controls.Add(this.courseLabel1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 250);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // courseLabel4
            // 
            this.courseLabel4.AutoSize = true;
            this.courseLabel4.Location = new System.Drawing.Point(18, 171);
            this.courseLabel4.Name = "courseLabel4";
            this.courseLabel4.Size = new System.Drawing.Size(55, 13);
            this.courseLabel4.TabIndex = 4;
            this.courseLabel4.TabStop = true;
            this.courseLabel4.Text = "linkLabel4";
            this.courseLabel4.Visible = false;
            // 
            // courseLabel3
            // 
            this.courseLabel3.AutoSize = true;
            this.courseLabel3.Location = new System.Drawing.Point(18, 132);
            this.courseLabel3.Name = "courseLabel3";
            this.courseLabel3.Size = new System.Drawing.Size(55, 13);
            this.courseLabel3.TabIndex = 3;
            this.courseLabel3.TabStop = true;
            this.courseLabel3.Text = "linkLabel3";
            this.courseLabel3.Visible = false;
            // 
            // courseLabel2
            // 
            this.courseLabel2.AutoSize = true;
            this.courseLabel2.Location = new System.Drawing.Point(18, 91);
            this.courseLabel2.Name = "courseLabel2";
            this.courseLabel2.Size = new System.Drawing.Size(55, 13);
            this.courseLabel2.TabIndex = 2;
            this.courseLabel2.TabStop = true;
            this.courseLabel2.Text = "linkLabel2";
            this.courseLabel2.Visible = false;
            // 
            // courseLabel1
            // 
            this.courseLabel1.AutoSize = true;
            this.courseLabel1.Location = new System.Drawing.Point(18, 50);
            this.courseLabel1.Name = "courseLabel1";
            this.courseLabel1.Size = new System.Drawing.Size(55, 13);
            this.courseLabel1.TabIndex = 1;
            this.courseLabel1.TabStop = true;
            this.courseLabel1.Text = "linkLabel1";
            this.courseLabel1.Visible = false;
            this.courseLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Courses";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(524, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "LOGOUT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(450, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(453, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 52);
            this.button2.TabIndex = 3;
            this.button2.Text = "Estimate GPA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(453, 184);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 52);
            this.button3.TabIndex = 4;
            this.button3.Text = "Calendar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(453, 126);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(146, 52);
            this.button4.TabIndex = 5;
            this.button4.Text = "My Grades";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(453, 70);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(146, 52);
            this.button5.TabIndex = 6;
            this.button5.Text = "Announcements";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // StudentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 329);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "StudentPage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.StudentPage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel courseLabel4;
        private System.Windows.Forms.LinkLabel courseLabel3;
        private System.Windows.Forms.LinkLabel courseLabel2;
        private System.Windows.Forms.LinkLabel courseLabel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

