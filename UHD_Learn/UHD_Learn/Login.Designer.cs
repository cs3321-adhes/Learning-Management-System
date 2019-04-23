namespace UHD_Learn
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.userBox = new System.Windows.Forms.TextBox();
            this.pwBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.forgetPW = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(219, 247);
            this.username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(105, 23);
            this.username.TabIndex = 0;
            this.username.Text = "USERNAME";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(219, 297);
            this.password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(107, 23);
            this.password.TabIndex = 1;
            this.password.Text = "PASSWORD";
            // 
            // userBox
            // 
            this.userBox.Location = new System.Drawing.Point(351, 247);
            this.userBox.Margin = new System.Windows.Forms.Padding(4);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(293, 22);
            this.userBox.TabIndex = 2;
            // 
            // pwBox
            // 
            this.pwBox.Location = new System.Drawing.Point(351, 297);
            this.pwBox.Margin = new System.Windows.Forms.Padding(4);
            this.pwBox.Name = "pwBox";
            this.pwBox.PasswordChar = '*';
            this.pwBox.Size = new System.Drawing.Size(293, 22);
            this.pwBox.TabIndex = 3;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(351, 329);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(100, 28);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "LOG IN";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // forgetPW
            // 
            this.forgetPW.AutoSize = true;
            this.forgetPW.Location = new System.Drawing.Point(489, 329);
            this.forgetPW.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.forgetPW.Name = "forgetPW";
            this.forgetPW.Size = new System.Drawing.Size(156, 17);
            this.forgetPW.TabIndex = 6;
            this.forgetPW.TabStop = true;
            this.forgetPW.Text = "Forget Your Password?";
            this.forgetPW.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgetPW_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(295, 108);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(350, 150);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // Login
            // 
            this.AcceptButton = this.loginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.forgetPW);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.pwBox);
            this.Controls.Add(this.userBox);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.pictureBox2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.Text = "UHD Learn";
            this.Load += new System.EventHandler(this.Login_Load);
            this.Shown += new System.EventHandler(this.formShown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.TextBox pwBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.LinkLabel forgetPW;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

