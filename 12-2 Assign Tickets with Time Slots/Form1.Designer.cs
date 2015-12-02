namespace _12_2_Assign_Tickets_with_Time_Slots
{
    partial class frmMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textTicketNumbers = new System.Windows.Forms.TextBox();
            this.txtOutstandingTickets = new System.Windows.Forms.TextBox();
            this.txtNextEntry = new System.Windows.Forms.TextBox();
            this.btnIssueTicket = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textTicketNumbers);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 48);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Guests with the following tickets may now enter:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnIssueTicket);
            this.groupBox2.Controls.Add(this.txtNextEntry);
            this.groupBox2.Controls.Add(this.txtOutstandingTickets);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(12, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 162);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ticket Availability";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(15, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total Tickets Outstanding:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(15, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Next Available Entry:";
            // 
            // textTicketNumbers
            // 
            this.textTicketNumbers.Location = new System.Drawing.Point(18, 22);
            this.textTicketNumbers.Name = "textTicketNumbers";
            this.textTicketNumbers.ReadOnly = true;
            this.textTicketNumbers.Size = new System.Drawing.Size(100, 20);
            this.textTicketNumbers.TabIndex = 4;
            this.textTicketNumbers.TabStop = false;
            // 
            // txtOutstandingTickets
            // 
            this.txtOutstandingTickets.Location = new System.Drawing.Point(176, 36);
            this.txtOutstandingTickets.Name = "txtOutstandingTickets";
            this.txtOutstandingTickets.ReadOnly = true;
            this.txtOutstandingTickets.Size = new System.Drawing.Size(100, 20);
            this.txtOutstandingTickets.TabIndex = 5;
            this.txtOutstandingTickets.TabStop = false;
            // 
            // txtNextEntry
            // 
            this.txtNextEntry.Location = new System.Drawing.Point(176, 72);
            this.txtNextEntry.Name = "txtNextEntry";
            this.txtNextEntry.ReadOnly = true;
            this.txtNextEntry.Size = new System.Drawing.Size(100, 20);
            this.txtNextEntry.TabIndex = 6;
            this.txtNextEntry.TabStop = false;
            // 
            // btnIssueTicket
            // 
            this.btnIssueTicket.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIssueTicket.Location = new System.Drawing.Point(18, 115);
            this.btnIssueTicket.Name = "btnIssueTicket";
            this.btnIssueTicket.Size = new System.Drawing.Size(129, 23);
            this.btnIssueTicket.TabIndex = 1;
            this.btnIssueTicket.Text = "&Issue Ticket";
            this.btnIssueTicket.UseVisualStyleBackColor = true;
            this.btnIssueTicket.Click += new System.EventHandler(this.btnIssueTicket_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.Location = new System.Drawing.Point(12, 395);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(75, 23);
            this.btnOptions.TabIndex = 2;
            this.btnOptions.Text = "&Options";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(219, 395);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 234);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(282, 147);
            this.listBox1.TabIndex = 10;
            this.listBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 430);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textTicketNumbers;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNextEntry;
        private System.Windows.Forms.TextBox txtOutstandingTickets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIssueTicket;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox listBox1;
    }
}

