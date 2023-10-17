namespace TicketMessenger
{
    partial class Settings
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
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Countdownlbl = new System.Windows.Forms.Label();
            this.backbttn = new System.Windows.Forms.Button();
            this.CheckDateAndTime = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Testbttn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel2.Controls.Add(this.Testbttn);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Countdownlbl);
            this.panel2.Controls.Add(this.backbttn);
            this.panel2.Location = new System.Drawing.Point(-1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(802, 448);
            this.panel2.TabIndex = 3;
            // 
            // Countdownlbl
            // 
            this.Countdownlbl.AutoSize = true;
            this.Countdownlbl.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Countdownlbl.Location = new System.Drawing.Point(24, 29);
            this.Countdownlbl.Name = "Countdownlbl";
            this.Countdownlbl.Size = new System.Drawing.Size(120, 23);
            this.Countdownlbl.TabIndex = 3;
            this.Countdownlbl.Text = "Countdown";
            // 
            // backbttn
            // 
            this.backbttn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbttn.Location = new System.Drawing.Point(28, 398);
            this.backbttn.Name = "backbttn";
            this.backbttn.Size = new System.Drawing.Size(75, 25);
            this.backbttn.TabIndex = 0;
            this.backbttn.Text = "Back";
            this.backbttn.UseVisualStyleBackColor = true;
            this.backbttn.Click += new System.EventHandler(this.backbttn_Click);
            // 
            // CheckDateAndTime
            // 
            this.CheckDateAndTime.Interval = 1000;
            this.CheckDateAndTime.Tick += new System.EventHandler(this.CheckDateAndTime_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = ":Next Email";
            // 
            // Testbttn
            // 
            this.Testbttn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Testbttn.Location = new System.Drawing.Point(689, 400);
            this.Testbttn.Name = "Testbttn";
            this.Testbttn.Size = new System.Drawing.Size(77, 23);
            this.Testbttn.TabIndex = 5;
            this.Testbttn.Text = "Test";
            this.Testbttn.UseVisualStyleBackColor = true;
            this.Testbttn.Click += new System.EventHandler(this.Testbttn_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Settings";
            this.Text = "Settings";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button backbttn;
        private System.Windows.Forms.Label Countdownlbl;
        private System.Windows.Forms.Timer CheckDateAndTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Testbttn;
    }
}