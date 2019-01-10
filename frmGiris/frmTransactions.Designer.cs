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
            this.dgwMeeting = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInsertMeeting = new System.Windows.Forms.Button();
            this.tbMeeting = new System.Windows.Forms.TextBox();
            this.tpReservation = new System.Windows.Forms.TabPage();
            this.btnDeleteReservation = new System.Windows.Forms.Button();
            this.btnInsertReservation = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.cbMeeting = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFinishDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tpMeeting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMeeting)).BeginInit();
            this.tpReservation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(559, 462);
            this.tabControl1.TabIndex = 0;
            // 
            // tpMeeting
            // 
            this.tpMeeting.Controls.Add(this.dgwMeeting);
            this.tpMeeting.Controls.Add(this.label1);
            this.tpMeeting.Controls.Add(this.btnInsertMeeting);
            this.tpMeeting.Controls.Add(this.tbMeeting);
            this.tpMeeting.Location = new System.Drawing.Point(4, 25);
            this.tpMeeting.Name = "tpMeeting";
            this.tpMeeting.Padding = new System.Windows.Forms.Padding(3);
            this.tpMeeting.Size = new System.Drawing.Size(551, 357);
            this.tpMeeting.TabIndex = 0;
            this.tpMeeting.Text = "Toplantı Salon";
            this.tpMeeting.UseVisualStyleBackColor = true;
            // 
            // dgwMeeting
            // 
            this.dgwMeeting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMeeting.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgwMeeting.Location = new System.Drawing.Point(3, 204);
            this.dgwMeeting.Name = "dgwMeeting";
            this.dgwMeeting.RowTemplate.Height = 24;
            this.dgwMeeting.Size = new System.Drawing.Size(545, 150);
            this.dgwMeeting.TabIndex = 3;
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
            // btnInsertMeeting
            // 
            this.btnInsertMeeting.Location = new System.Drawing.Point(11, 102);
            this.btnInsertMeeting.Name = "btnInsertMeeting";
            this.btnInsertMeeting.Size = new System.Drawing.Size(194, 42);
            this.btnInsertMeeting.TabIndex = 1;
            this.btnInsertMeeting.Text = "Ekle";
            this.btnInsertMeeting.UseVisualStyleBackColor = true;
            this.btnInsertMeeting.Click += new System.EventHandler(this.btnInsertMeeting_Click);
            // 
            // tbMeeting
            // 
            this.tbMeeting.Location = new System.Drawing.Point(105, 45);
            this.tbMeeting.Name = "tbMeeting";
            this.tbMeeting.Size = new System.Drawing.Size(100, 22);
            this.tbMeeting.TabIndex = 0;
            // 
            // tpReservation
            // 
            this.tpReservation.Controls.Add(this.btnDeleteReservation);
            this.tpReservation.Controls.Add(this.btnInsertReservation);
            this.tpReservation.Controls.Add(this.dataGridView2);
            this.tpReservation.Controls.Add(this.label4);
            this.tpReservation.Controls.Add(this.cbMeeting);
            this.tpReservation.Controls.Add(this.label3);
            this.tpReservation.Controls.Add(this.label2);
            this.tpReservation.Controls.Add(this.dtpFinishDate);
            this.tpReservation.Controls.Add(this.dtpStartTime);
            this.tpReservation.Location = new System.Drawing.Point(4, 25);
            this.tpReservation.Name = "tpReservation";
            this.tpReservation.Padding = new System.Windows.Forms.Padding(3);
            this.tpReservation.Size = new System.Drawing.Size(551, 433);
            this.tpReservation.TabIndex = 1;
            this.tpReservation.Text = "Rezervasyon";
            this.tpReservation.UseVisualStyleBackColor = true;
            // 
            // btnDeleteReservation
            // 
            this.btnDeleteReservation.Location = new System.Drawing.Point(230, 154);
            this.btnDeleteReservation.Name = "btnDeleteReservation";
            this.btnDeleteReservation.Size = new System.Drawing.Size(163, 23);
            this.btnDeleteReservation.TabIndex = 8;
            this.btnDeleteReservation.Text = "İptal Et";
            this.btnDeleteReservation.UseVisualStyleBackColor = true;
            // 
            // btnInsertReservation
            // 
            this.btnInsertReservation.Location = new System.Drawing.Point(14, 154);
            this.btnInsertReservation.Name = "btnInsertReservation";
            this.btnInsertReservation.Size = new System.Drawing.Size(196, 23);
            this.btnInsertReservation.TabIndex = 7;
            this.btnInsertReservation.Text = "Ekle";
            this.btnInsertReservation.UseVisualStyleBackColor = true;
            this.btnInsertReservation.Click += new System.EventHandler(this.btnInsertReservation_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView2.Location = new System.Drawing.Point(3, 230);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(545, 200);
            this.dataGridView2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Salon İsim";
            // 
            // cbMeeting
            // 
            this.cbMeeting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMeeting.FormattingEnabled = true;
            this.cbMeeting.Location = new System.Drawing.Point(193, 109);
            this.cbMeeting.Name = "cbMeeting";
            this.cbMeeting.Size = new System.Drawing.Size(200, 24);
            this.cbMeeting.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bitiş Saati";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Başlangıç Saati";
            // 
            // dtpFinishDate
            // 
            this.dtpFinishDate.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpFinishDate.Location = new System.Drawing.Point(193, 55);
            this.dtpFinishDate.Name = "dtpFinishDate";
            this.dtpFinishDate.Size = new System.Drawing.Size(200, 22);
            this.dtpFinishDate.TabIndex = 1;
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpStartTime.Location = new System.Drawing.Point(193, 11);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.Size = new System.Drawing.Size(200, 22);
            this.dtpStartTime.TabIndex = 0;
            // 
            // frmTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 462);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmTransactions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTransactions";
            this.Load += new System.EventHandler(this.frmTransactions_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpMeeting.ResumeLayout(false);
            this.tpMeeting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMeeting)).EndInit();
            this.tpReservation.ResumeLayout(false);
            this.tpReservation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpMeeting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsertMeeting;
        private System.Windows.Forms.TextBox tbMeeting;
        private System.Windows.Forms.TabPage tpReservation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFinishDate;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.DataGridView dgwMeeting;
        private System.Windows.Forms.Button btnDeleteReservation;
        private System.Windows.Forms.Button btnInsertReservation;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbMeeting;
    }
}