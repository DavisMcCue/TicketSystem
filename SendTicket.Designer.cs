namespace TicketMessenger
{
    partial class SendTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendTicket));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.sendticketUsernameDisplay = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textOtherBox = new System.Windows.Forms.TextBox();
            this.bttnTicketSend = new System.Windows.Forms.Button();
            this.labelOther = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.descriptiontxtbox = new System.Windows.Forms.TextBox();
            this.SubjectBoxOptions = new System.Windows.Forms.ComboBox();
            this.locationlistBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.textOtherBox);
            this.panel1.Controls.Add(this.bttnTicketSend);
            this.panel1.Controls.Add(this.labelOther);
            this.panel1.Controls.Add(this.description);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelLocation);
            this.panel1.Controls.Add(this.descriptiontxtbox);
            this.panel1.Controls.Add(this.SubjectBoxOptions);
            this.panel1.Controls.Add(this.locationlistBox);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 447);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.buttonBack);
            this.panel2.Controls.Add(this.sendticketUsernameDisplay);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, -6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 463);
            this.panel2.TabIndex = 15;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 86);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(63, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(12, 413);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 31);
            this.buttonBack.TabIndex = 9;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // sendticketUsernameDisplay
            // 
            this.sendticketUsernameDisplay.AutoSize = true;
            this.sendticketUsernameDisplay.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendticketUsernameDisplay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sendticketUsernameDisplay.Location = new System.Drawing.Point(81, 102);
            this.sendticketUsernameDisplay.Name = "sendticketUsernameDisplay";
            this.sendticketUsernameDisplay.Size = new System.Drawing.Size(98, 19);
            this.sendticketUsernameDisplay.TabIndex = 3;
            this.sendticketUsernameDisplay.Text = "User Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 77);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textOtherBox
            // 
            this.textOtherBox.Location = new System.Drawing.Point(270, 248);
            this.textOtherBox.Multiline = true;
            this.textOtherBox.Name = "textOtherBox";
            this.textOtherBox.Size = new System.Drawing.Size(456, 141);
            this.textOtherBox.TabIndex = 4;
            // 
            // bttnTicketSend
            // 
            this.bttnTicketSend.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnTicketSend.Location = new System.Drawing.Point(680, 408);
            this.bttnTicketSend.Name = "bttnTicketSend";
            this.bttnTicketSend.Size = new System.Drawing.Size(108, 30);
            this.bttnTicketSend.TabIndex = 10;
            this.bttnTicketSend.Text = "Send Ticket";
            this.bttnTicketSend.UseVisualStyleBackColor = true;
            this.bttnTicketSend.Click += new System.EventHandler(this.bttnTicketSend_Click);
            // 
            // labelOther
            // 
            this.labelOther.AutoSize = true;
            this.labelOther.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOther.Location = new System.Drawing.Point(267, 214);
            this.labelOther.Name = "labelOther";
            this.labelOther.Size = new System.Drawing.Size(460, 16);
            this.labelOther.TabIndex = 3;
            this.labelOther.Text = "You have choosen \"Other\". Please Explain the problem you are having";
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.BackColor = System.Drawing.Color.Transparent;
            this.description.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(580, 26);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(99, 18);
            this.description.TabIndex = 14;
            this.description.Text = "Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(430, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject:";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocation.Location = new System.Drawing.Point(266, 25);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(84, 19);
            this.labelLocation.TabIndex = 5;
            this.labelLocation.Text = "Location:";
            // 
            // descriptiontxtbox
            // 
            this.descriptiontxtbox.Location = new System.Drawing.Point(556, 53);
            this.descriptiontxtbox.Multiline = true;
            this.descriptiontxtbox.Name = "descriptiontxtbox";
            this.descriptiontxtbox.Size = new System.Drawing.Size(149, 21);
            this.descriptiontxtbox.TabIndex = 13;
            // 
            // SubjectBoxOptions
            // 
            this.SubjectBoxOptions.FormattingEnabled = true;
            this.SubjectBoxOptions.Items.AddRange(new object[] {
            "Expungment",
            "Computer Lockout",
            "Hardware",
            "Civil Cases",
            "Missing Certified Mail",
            "Other"});
            this.SubjectBoxOptions.Location = new System.Drawing.Point(401, 53);
            this.SubjectBoxOptions.Name = "SubjectBoxOptions";
            this.SubjectBoxOptions.Size = new System.Drawing.Size(121, 21);
            this.SubjectBoxOptions.TabIndex = 11;
            this.SubjectBoxOptions.SelectedIndexChanged += new System.EventHandler(this.SubjectBoxOptions_SelectedIndexChanged);
            // 
            // locationlistBox
            // 
            this.locationlistBox.FormattingEnabled = true;
            this.locationlistBox.Items.AddRange(new object[] {
            "C.O.B",
            "Suite 690",
            "Title",
            "Finance",
            "Court House (Criminal)",
            "Court House (Civil)"});
            this.locationlistBox.Location = new System.Drawing.Point(246, 53);
            this.locationlistBox.Name = "locationlistBox";
            this.locationlistBox.Size = new System.Drawing.Size(121, 21);
            this.locationlistBox.TabIndex = 12;
            // 
            // SendTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "SendTicket";
            this.Text = "SendTicket";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textOtherBox;
        private System.Windows.Forms.Label labelOther;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button bttnTicketSend;
        private System.Windows.Forms.ComboBox locationlistBox;
        private System.Windows.Forms.ComboBox SubjectBoxOptions;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.TextBox descriptiontxtbox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label sendticketUsernameDisplay;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}