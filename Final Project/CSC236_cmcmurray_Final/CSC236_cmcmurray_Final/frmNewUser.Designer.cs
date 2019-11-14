namespace CSC236_cmcmurray_Final
{
    partial class frmNewUser
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
            this.tboxNewUserName = new System.Windows.Forms.TextBox();
            this.tboxNewUserCampaign = new System.Windows.Forms.TextBox();
            this.btnNewUserCreate = new System.Windows.Forms.Button();
            this.btnNewUserCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tboxNewUserName
            // 
            this.tboxNewUserName.Location = new System.Drawing.Point(64, 37);
            this.tboxNewUserName.Name = "tboxNewUserName";
            this.tboxNewUserName.Size = new System.Drawing.Size(100, 20);
            this.tboxNewUserName.TabIndex = 0;
            this.tboxNewUserName.Text = "Name";
            // 
            // tboxNewUserCampaign
            // 
            this.tboxNewUserCampaign.Location = new System.Drawing.Point(64, 79);
            this.tboxNewUserCampaign.Name = "tboxNewUserCampaign";
            this.tboxNewUserCampaign.Size = new System.Drawing.Size(100, 20);
            this.tboxNewUserCampaign.TabIndex = 1;
            this.tboxNewUserCampaign.Text = "Campaign Name";
            // 
            // btnNewUserCreate
            // 
            this.btnNewUserCreate.Location = new System.Drawing.Point(75, 124);
            this.btnNewUserCreate.Name = "btnNewUserCreate";
            this.btnNewUserCreate.Size = new System.Drawing.Size(75, 23);
            this.btnNewUserCreate.TabIndex = 2;
            this.btnNewUserCreate.Text = "Create";
            this.btnNewUserCreate.UseVisualStyleBackColor = true;
            // 
            // btnNewUserCancel
            // 
            this.btnNewUserCancel.Location = new System.Drawing.Point(75, 167);
            this.btnNewUserCancel.Name = "btnNewUserCancel";
            this.btnNewUserCancel.Size = new System.Drawing.Size(75, 23);
            this.btnNewUserCancel.TabIndex = 3;
            this.btnNewUserCancel.Text = "Cancel";
            this.btnNewUserCancel.UseVisualStyleBackColor = true;
            this.btnNewUserCancel.Click += new System.EventHandler(this.BtnNewUserCancel_Click);
            // 
            // frmNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 215);
            this.Controls.Add(this.btnNewUserCancel);
            this.Controls.Add(this.btnNewUserCreate);
            this.Controls.Add(this.tboxNewUserCampaign);
            this.Controls.Add(this.tboxNewUserName);
            this.Name = "frmNewUser";
            this.Text = "Create New User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxNewUserName;
        private System.Windows.Forms.TextBox tboxNewUserCampaign;
        private System.Windows.Forms.Button btnNewUserCreate;
        private System.Windows.Forms.Button btnNewUserCancel;
    }
}