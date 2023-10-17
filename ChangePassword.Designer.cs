namespace TicketMessenger
{
    partial class ChangePassword
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
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.comfirmpasswordTxtBox = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.ComfirmPassword = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.Location = new System.Drawing.Point(186, 36);
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTxtBox.TabIndex = 0;
            // 
            // comfirmpasswordTxtBox
            // 
            this.comfirmpasswordTxtBox.Location = new System.Drawing.Point(186, 89);
            this.comfirmpasswordTxtBox.Name = "comfirmpasswordTxtBox";
            this.comfirmpasswordTxtBox.PasswordChar = '*';
            this.comfirmpasswordTxtBox.Size = new System.Drawing.Size(100, 20);
            this.comfirmpasswordTxtBox.TabIndex = 1;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(73, 40);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(75, 16);
            this.Password.TabIndex = 2;
            this.Password.Text = "Password:";
            // 
            // ComfirmPassword
            // 
            this.ComfirmPassword.AutoSize = true;
            this.ComfirmPassword.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComfirmPassword.Location = new System.Drawing.Point(53, 93);
            this.ComfirmPassword.Name = "ComfirmPassword";
            this.ComfirmPassword.Size = new System.Drawing.Size(131, 16);
            this.ComfirmPassword.TabIndex = 3;
            this.ComfirmPassword.Text = "Comfirm Password:";
            // 
            // btnAccept
            // 
            this.btnAccept.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.Location = new System.Drawing.Point(296, 124);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(79, 23);
            this.btnAccept.TabIndex = 4;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 159);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.ComfirmPassword);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.comfirmpasswordTxtBox);
            this.Controls.Add(this.passwordTxtBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passwordTxtBox;
        private System.Windows.Forms.TextBox comfirmpasswordTxtBox;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label ComfirmPassword;
        private System.Windows.Forms.Button btnAccept;
    }
}