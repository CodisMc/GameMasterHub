namespace CSC236_cmcmurray_Final
{
    partial class frmSplash
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
            this.lblSplashWelcome = new System.Windows.Forms.Label();
            this.lblSplashLogin = new System.Windows.Forms.Label();
            this.tboxUsername = new System.Windows.Forms.TextBox();
            this.tboxPassword = new System.Windows.Forms.TextBox();
            this.btnSplashLogin = new System.Windows.Forms.Button();
            this.btnSplashNewUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSplashWelcome
            // 
            this.lblSplashWelcome.AutoSize = true;
            this.lblSplashWelcome.Font = new System.Drawing.Font("Gabriola", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSplashWelcome.Location = new System.Drawing.Point(118, 41);
            this.lblSplashWelcome.Name = "lblSplashWelcome";
            this.lblSplashWelcome.Size = new System.Drawing.Size(210, 79);
            this.lblSplashWelcome.TabIndex = 0;
            this.lblSplashWelcome.Text = "Welcome GM";
            // 
            // lblSplashLogin
            // 
            this.lblSplashLogin.AutoSize = true;
            this.lblSplashLogin.Font = new System.Drawing.Font("Leelawadee", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSplashLogin.Location = new System.Drawing.Point(30, 120);
            this.lblSplashLogin.Name = "lblSplashLogin";
            this.lblSplashLogin.Size = new System.Drawing.Size(389, 26);
            this.lblSplashLogin.TabIndex = 1;
            this.lblSplashLogin.Text = "Please enter your name and campaign:";
            // 
            // tboxUsername
            // 
            this.tboxUsername.Location = new System.Drawing.Point(170, 177);
            this.tboxUsername.Name = "tboxUsername";
            this.tboxUsername.Size = new System.Drawing.Size(100, 20);
            this.tboxUsername.TabIndex = 2;
            this.tboxUsername.Text = "Username";
            // 
            // tboxPassword
            // 
            this.tboxPassword.Location = new System.Drawing.Point(170, 214);
            this.tboxPassword.Name = "tboxPassword";
            this.tboxPassword.Size = new System.Drawing.Size(100, 20);
            this.tboxPassword.TabIndex = 3;
            this.tboxPassword.Text = "Password";
            this.tboxPassword.Enter += new System.EventHandler(this.TboxPassword_Enter);
            // 
            // btnSplashLogin
            // 
            this.btnSplashLogin.Location = new System.Drawing.Point(180, 252);
            this.btnSplashLogin.Name = "btnSplashLogin";
            this.btnSplashLogin.Size = new System.Drawing.Size(75, 23);
            this.btnSplashLogin.TabIndex = 4;
            this.btnSplashLogin.Text = "Login";
            this.btnSplashLogin.UseVisualStyleBackColor = true;
            // 
            // btnSplashNewUser
            // 
            this.btnSplashNewUser.Location = new System.Drawing.Point(164, 288);
            this.btnSplashNewUser.Name = "btnSplashNewUser";
            this.btnSplashNewUser.Size = new System.Drawing.Size(111, 23);
            this.btnSplashNewUser.TabIndex = 5;
            this.btnSplashNewUser.Text = "Create New User";
            this.btnSplashNewUser.UseVisualStyleBackColor = true;
            this.btnSplashNewUser.Click += new System.EventHandler(this.BtnSplashNewUser_Click);
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(457, 336);
            this.Controls.Add(this.btnSplashNewUser);
            this.Controls.Add(this.btnSplashLogin);
            this.Controls.Add(this.tboxPassword);
            this.Controls.Add(this.tboxUsername);
            this.Controls.Add(this.lblSplashLogin);
            this.Controls.Add(this.lblSplashWelcome);
            this.Name = "frmSplash";
            this.Text = "Welcome Game Master";
            this.Load += new System.EventHandler(this.FrmSplash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSplashWelcome;
        private System.Windows.Forms.Label lblSplashLogin;
        private System.Windows.Forms.TextBox tboxUsername;
        private System.Windows.Forms.TextBox tboxPassword;
        private System.Windows.Forms.Button btnSplashLogin;
        private System.Windows.Forms.Button btnSplashNewUser;
    }
}

