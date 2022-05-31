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
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogIN = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblWelcomeScreen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(184, 116);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(184, 23);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(184, 203);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(184, 23);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // btnLogIN
            // 
            this.btnLogIN.BackColor = System.Drawing.Color.Transparent;
            this.btnLogIN.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogIN.Location = new System.Drawing.Point(389, 286);
            this.btnLogIN.Name = "btnLogIN";
            this.btnLogIN.Size = new System.Drawing.Size(126, 43);
            this.btnLogIN.TabIndex = 2;
            this.btnLogIN.Text = "LOG IN ";
            this.btnLogIN.UseVisualStyleBackColor = false;
            this.btnLogIN.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUserName.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblUserName.Location = new System.Drawing.Point(12, 99);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(177, 40);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "User Name:";
            this.lblUserName.Click += new System.EventHandler(this.lblUserName_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.Location = new System.Drawing.Point(23, 186);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(155, 40);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password:";
            // 
            // lblWelcomeScreen
            // 
            this.lblWelcomeScreen.AutoSize = true;
            this.lblWelcomeScreen.BackColor = System.Drawing.Color.Transparent;
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
            this.Controls.Add(this.btnLogIN);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Login";
            this.Text = "LoginView";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtUserName;
        private TextBox txtPassword;
        private Button btnLogIN;
        private Label lblUserName;
        private Label lblPassword;
        private Label lblWelcomeScreen;
    }
}