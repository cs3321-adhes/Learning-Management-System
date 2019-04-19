namespace WindowsFormsApp1
{
    partial class grades
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
            this.ReToMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReToMain
            // 
            this.ReToMain.Location = new System.Drawing.Point(298, 171);
            this.ReToMain.Name = "ReToMain";
            this.ReToMain.Size = new System.Drawing.Size(187, 52);
            this.ReToMain.TabIndex = 0;
            this.ReToMain.Text = "Return To Main";
            this.ReToMain.UseVisualStyleBackColor = true;
            this.ReToMain.Click += new System.EventHandler(this.ReToMain_Click);
            // 
            // grades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReToMain);
            this.Name = "grades";
            this.Text = "grades";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ReToMain;
    }
}