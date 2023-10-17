namespace TicketMessenger
{
    partial class TicketInventory
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TicketSolution = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WasTicketResolved = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketLocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resolveBttn = new System.Windows.Forms.Button();
            this.backBttn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ticketMessengerDataSet1 = new TicketMessenger.TicketMessengerDataSet1();
            this.ticketInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketInfoTableAdapter = new TicketMessenger.TicketMessengerDataSet1TableAdapters.TicketInfoTableAdapter();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketMessengerDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(801, 36);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(318, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ticket Inventory";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ticketIDDataGridViewTextBoxColumn,
            this.ticketNumberDataGridViewTextBoxColumn,
            this.ticketNameDataGridViewTextBoxColumn,
            this.ticketTimeDataGridViewTextBoxColumn,
            this.ticketDateDataGridViewTextBoxColumn,
            this.ticketLocationDataGridViewTextBoxColumn,
            this.ticketDescriptionDataGridViewTextBoxColumn,
            this.WasTicketResolved,
            this.TicketSolution});
            this.dataGridView1.DataSource = this.ticketInfoBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(0, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(801, 385);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TicketSolution
            // 
            this.TicketSolution.DataPropertyName = "TicketSolution";
            this.TicketSolution.HeaderText = "TicketSolution";
            this.TicketSolution.Name = "TicketSolution";
            this.TicketSolution.ReadOnly = true;
            // 
            // WasTicketResolved
            // 
            this.WasTicketResolved.DataPropertyName = "WasTicketResolved";
            this.WasTicketResolved.HeaderText = "WasTicketResolved";
            this.WasTicketResolved.Name = "WasTicketResolved";
            this.WasTicketResolved.ReadOnly = true;
            // 
            // ticketDescriptionDataGridViewTextBoxColumn
            // 
            this.ticketDescriptionDataGridViewTextBoxColumn.DataPropertyName = "TicketDescription";
            this.ticketDescriptionDataGridViewTextBoxColumn.HeaderText = "TicketDescription";
            this.ticketDescriptionDataGridViewTextBoxColumn.Name = "ticketDescriptionDataGridViewTextBoxColumn";
            this.ticketDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ticketLocationDataGridViewTextBoxColumn
            // 
            this.ticketLocationDataGridViewTextBoxColumn.DataPropertyName = "TicketLocation";
            this.ticketLocationDataGridViewTextBoxColumn.HeaderText = "TicketLocation";
            this.ticketLocationDataGridViewTextBoxColumn.Name = "ticketLocationDataGridViewTextBoxColumn";
            this.ticketLocationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ticketDateDataGridViewTextBoxColumn
            // 
            this.ticketDateDataGridViewTextBoxColumn.DataPropertyName = "TicketDate";
            this.ticketDateDataGridViewTextBoxColumn.HeaderText = "TicketDate";
            this.ticketDateDataGridViewTextBoxColumn.Name = "ticketDateDataGridViewTextBoxColumn";
            this.ticketDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ticketTimeDataGridViewTextBoxColumn
            // 
            this.ticketTimeDataGridViewTextBoxColumn.DataPropertyName = "TicketTime";
            this.ticketTimeDataGridViewTextBoxColumn.HeaderText = "TicketTime";
            this.ticketTimeDataGridViewTextBoxColumn.Name = "ticketTimeDataGridViewTextBoxColumn";
            this.ticketTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ticketNameDataGridViewTextBoxColumn
            // 
            this.ticketNameDataGridViewTextBoxColumn.DataPropertyName = "TicketName";
            this.ticketNameDataGridViewTextBoxColumn.HeaderText = "TicketName";
            this.ticketNameDataGridViewTextBoxColumn.Name = "ticketNameDataGridViewTextBoxColumn";
            this.ticketNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ticketNumberDataGridViewTextBoxColumn
            // 
            this.ticketNumberDataGridViewTextBoxColumn.DataPropertyName = "TicketNumber";
            this.ticketNumberDataGridViewTextBoxColumn.HeaderText = "TicketNumber";
            this.ticketNumberDataGridViewTextBoxColumn.Name = "ticketNumberDataGridViewTextBoxColumn";
            this.ticketNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ticketIDDataGridViewTextBoxColumn
            // 
            this.ticketIDDataGridViewTextBoxColumn.DataPropertyName = "TicketID";
            this.ticketIDDataGridViewTextBoxColumn.HeaderText = "TicketID";
            this.ticketIDDataGridViewTextBoxColumn.Name = "ticketIDDataGridViewTextBoxColumn";
            this.ticketIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // resolveBttn
            // 
            this.resolveBttn.Location = new System.Drawing.Point(476, 426);
            this.resolveBttn.Name = "resolveBttn";
            this.resolveBttn.Size = new System.Drawing.Size(123, 23);
            this.resolveBttn.TabIndex = 4;
            this.resolveBttn.Text = "Resolve a Ticket";
            this.resolveBttn.UseVisualStyleBackColor = true;
            this.resolveBttn.Click += new System.EventHandler(this.button1_Click);
            // 
            // backBttn
            // 
            this.backBttn.Location = new System.Drawing.Point(12, 426);
            this.backBttn.Name = "backBttn";
            this.backBttn.Size = new System.Drawing.Size(75, 23);
            this.backBttn.TabIndex = 5;
            this.backBttn.Text = "Back";
            this.backBttn.UseVisualStyleBackColor = true;
            this.backBttn.Click += new System.EventHandler(this.backBttn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.backBttn);
            this.panel1.Controls.Add(this.resolveBttn);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 454);
            this.panel1.TabIndex = 0;
            // 
            // ticketMessengerDataSet1
            // 
            this.ticketMessengerDataSet1.DataSetName = "TicketMessengerDataSet1";
            this.ticketMessengerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ticketInfoBindingSource
            // 
            this.ticketInfoBindingSource.DataMember = "TicketInfo";
            this.ticketInfoBindingSource.DataSource = this.ticketMessengerDataSet1;
            // 
            // ticketInfoTableAdapter
            // 
            this.ticketInfoTableAdapter.ClearBeforeFill = true;
            // 
            // TicketInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TicketInventory";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TicketInventory_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ticketMessengerDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketInfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketLocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn WasTicketResolved;
        private System.Windows.Forms.DataGridViewTextBoxColumn TicketSolution;
        private System.Windows.Forms.Button resolveBttn;
        private System.Windows.Forms.Button backBttn;
        private System.Windows.Forms.Panel panel1;
        private TicketMessengerDataSet1 ticketMessengerDataSet1;
        private System.Windows.Forms.BindingSource ticketInfoBindingSource;
        private TicketMessengerDataSet1TableAdapters.TicketInfoTableAdapter ticketInfoTableAdapter;
    }
}