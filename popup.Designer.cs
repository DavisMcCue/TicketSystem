namespace TicketMessenger
{
    partial class popup
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
            this.label2 = new System.Windows.Forms.Label();
            this.textboxID = new System.Windows.Forms.TextBox();
            this.solutionTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.popUpBackBttn = new System.Windows.Forms.Button();
            this.submitBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(190, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ticket ID:";
            // 
            // textboxID
            // 
            this.textboxID.Location = new System.Drawing.Point(277, 10);
            this.textboxID.Name = "textboxID";
            this.textboxID.Size = new System.Drawing.Size(28, 20);
            this.textboxID.TabIndex = 4;
            // 
            // solutionTxtBox
            // 
            this.solutionTxtBox.Location = new System.Drawing.Point(47, 71);
            this.solutionTxtBox.Multiline = true;
            this.solutionTxtBox.Name = "solutionTxtBox";
            this.solutionTxtBox.Size = new System.Drawing.Size(446, 106);
            this.solutionTxtBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "How Was Ticket Resolved?";
            // 
            // popUpBackBttn
            // 
            this.popUpBackBttn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.popUpBackBttn.Location = new System.Drawing.Point(13, 198);
            this.popUpBackBttn.Name = "popUpBackBttn";
            this.popUpBackBttn.Size = new System.Drawing.Size(96, 25);
            this.popUpBackBttn.TabIndex = 8;
            this.popUpBackBttn.Text = "back";
            this.popUpBackBttn.UseVisualStyleBackColor = true;
            this.popUpBackBttn.Click += new System.EventHandler(this.popUpBackBttn_Click);
            // 
            // submitBttn
            // 
            this.submitBttn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBttn.Location = new System.Drawing.Point(436, 198);
            this.submitBttn.Name = "submitBttn";
            this.submitBttn.Size = new System.Drawing.Size(96, 25);
            this.submitBttn.TabIndex = 9;
            this.submitBttn.Text = "Submit";
            this.submitBttn.UseVisualStyleBackColor = true;
            this.submitBttn.Click += new System.EventHandler(this.submitBttn_Click);
            // 
            // popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 235);
            this.Controls.Add(this.submitBttn);
            this.Controls.Add(this.popUpBackBttn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.solutionTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textboxID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "popup";
            this.Text = "popup";
            this.Load += new System.EventHandler(this.popup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textboxID;
        private System.Windows.Forms.TextBox solutionTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button popUpBackBttn;
        private System.Windows.Forms.Button submitBttn;
    }
}