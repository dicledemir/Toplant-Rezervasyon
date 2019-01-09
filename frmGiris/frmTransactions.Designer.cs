namespace frmGiris
{
    partial class frmTransactions
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpMeeting = new System.Windows.Forms.TabPage();
            this.tpReservation = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnInsertMeeting = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tpMeeting.SuspendLayout();
            this.tpReservation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpMeeting);
            this.tabControl1.Controls.Add(this.tpReservation);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(559, 386);
            this.tabControl1.TabIndex = 0;
            // 
            // tpMeeting
            // 
            this.tpMeeting.Controls.Add(this.label1);
            this.tpMeeting.Controls.Add(this.btnInsertMeeting);
            this.tpMeeting.Controls.Add(this.textBox1);
            this.tpMeeting.Location = new System.Drawing.Point(4, 25);
            this.tpMeeting.Name = "tpMeeting";
            this.tpMeeting.Padding = new System.Windows.Forms.Padding(3);
            this.tpMeeting.Size = new System.Drawing.Size(551, 357);
            this.tpMeeting.TabIndex = 0;
            this.tpMeeting.Text = "Toplantı Salon";
            this.tpMeeting.UseVisualStyleBackColor = true;
            // 
            // tpReservation
            // 
            this.tpReservation.Controls.Add(this.label3);
            this.tpReservation.Controls.Add(this.label2);
            this.tpReservation.Controls.Add(this.dateTimePicker2);
            this.tpReservation.Controls.Add(this.dateTimePicker1);
            this.tpReservation.Location = new System.Drawing.Point(4, 25);
            this.tpReservation.Name = "tpReservation";
            this.tpReservation.Padding = new System.Windows.Forms.Padding(3);
            this.tpReservation.Size = new System.Drawing.Size(551, 357);
            this.tpReservation.TabIndex = 1;
            this.tpReservation.Text = "Rezervasyon";
            this.tpReservation.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            // 
            // btnInsertMeeting
            // 
            this.btnInsertMeeting.Location = new System.Drawing.Point(11, 102);
            this.btnInsertMeeting.Name = "btnInsertMeeting";
            this.btnInsertMeeting.Size = new System.Drawing.Size(194, 42);
            this.btnInsertMeeting.TabIndex = 1;
            this.btnInsertMeeting.Text = "Ekle";
            this.btnInsertMeeting.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Salon İsim:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(202, 53);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(202, 107);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // frmTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 386);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmTransactions";
            this.Text = "frmTransactions";
            this.tabControl1.ResumeLayout(false);
            this.tpMeeting.ResumeLayout(false);
            this.tpMeeting.PerformLayout();
            this.tpReservation.ResumeLayout(false);
            this.tpReservation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpMeeting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsertMeeting;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tpReservation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}