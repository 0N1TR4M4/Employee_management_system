namespace Employee_management_system.View
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnLOGIN = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblWelcomeScreen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(168, 99);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 23);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(168, 180);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(184, 23);
            this.textBox2.TabIndex = 1;
            // 
            // btnLOGIN
            // 
            this.btnLOGIN.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLOGIN.Location = new System.Drawing.Point(341, 270);
            this.btnLOGIN.Name = "btnLOGIN";
            this.btnLOGIN.Size = new System.Drawing.Size(126, 43);
            this.btnLOGIN.TabIndex = 2;
            this.btnLOGIN.Text = "LOG IN ";
            this.btnLOGIN.UseVisualStyleBackColor = true;
            this.btnLOGIN.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUserName.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblUserName.Location = new System.Drawing.Point(12, 99);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(146, 32);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "User Name:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.Location = new System.Drawing.Point(29, 169);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(129, 32);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password:";
            // 
            // lblWelcomeScreen
            // 
            this.lblWelcomeScreen.AutoSize = true;
            this.lblWelcomeScreen.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWelcomeScreen.Location = new System.Drawing.Point(132, 9);
            this.lblWelcomeScreen.Name = "lblWelcomeScreen";
            this.lblWelcomeScreen.Size = new System.Drawing.Size(263, 65);
            this.lblWelcomeScreen.TabIndex = 6;
            this.lblWelcomeScreen.Text = "WELCOME";
            this.lblWelcomeScreen.Click += new System.EventHandler(this.lblWelcomeScreen_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(539, 450);
            this.Controls.Add(this.lblWelcomeScreen);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.btnLOGIN);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnLOGIN;
        private Label lblUserName;
        private Label lblPassword;
        private Label lblWelcomeScreen;
    }
}