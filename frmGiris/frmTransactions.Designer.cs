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
            this.tbReservationName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbOnaltiOnyedi = new System.Windows.Forms.RadioButton();
            this.rbsekizOn = new System.Windows.Forms.RadioButton();
            this.rbOnbesOnalti = new System.Windows.Forms.RadioButton();
            this.rbOnOniki = new System.Windows.Forms.RadioButton();
            this.rbOndortOnbes = new System.Windows.Forms.RadioButton();
            this.rbOnucOndort = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDay = new System.Windows.Forms.DateTimePicker();
            this.btnDeleteReservation = new System.Windows.Forms.Button();
            this.btnInsertReservation = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cbMeeting = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tpMeeting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMeeting)).BeginInit();
            this.tpReservation.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(721, 422);
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
            this.tpMeeting.Size = new System.Drawing.Size(713, 393);
            this.tpMeeting.TabIndex = 0;
            this.tpMeeting.Text = "Toplantı Salon";
            this.tpMeeting.UseVisualStyleBackColor = true;
            // 
            // dgwMeeting
            // 
            this.dgwMeeting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMeeting.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgwMeeting.Location = new System.Drawing.Point(3, 240);
            this.dgwMeeting.Name = "dgwMeeting";
            this.dgwMeeting.RowTemplate.Height = 24;
            this.dgwMeeting.Size = new System.Drawing.Size(707, 150);
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
            this.btnInsertMeeting.Text = "Olustur";
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
            this.tpReservation.Controls.Add(this.tbReservationName);
            this.tpReservation.Controls.Add(this.label3);
            this.tpReservation.Controls.Add(this.label2);
            this.tpReservation.Controls.Add(this.groupBox1);
            this.tpReservation.Controls.Add(this.label5);
            this.tpReservation.Controls.Add(this.dtpDay);
            this.tpReservation.Controls.Add(this.btnDeleteReservation);
            this.tpReservation.Controls.Add(this.btnInsertReservation);
            this.tpReservation.Controls.Add(this.dataGridView2);
            this.tpReservation.Controls.Add(this.cbMeeting);
            this.tpReservation.Location = new System.Drawing.Point(4, 25);
            this.tpReservation.Name = "tpReservation";
            this.tpReservation.Padding = new System.Windows.Forms.Padding(3);
            this.tpReservation.Size = new System.Drawing.Size(713, 393);
            this.tpReservation.TabIndex = 1;
            this.tpReservation.Text = "Rezervasyon";
            this.tpReservation.UseVisualStyleBackColor = true;
            // 
            // tbReservationName
            // 
            this.tbReservationName.Location = new System.Drawing.Point(171, 24);
            this.tbReservationName.Name = "tbReservationName";
            this.tbReservationName.Size = new System.Drawing.Size(185, 22);
            this.tbReservationName.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(3, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Rezervasyon adi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Salon No";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbOnaltiOnyedi);
            this.groupBox1.Controls.Add(this.rbsekizOn);
            this.groupBox1.Controls.Add(this.rbOnbesOnalti);
            this.groupBox1.Controls.Add(this.rbOnOniki);
            this.groupBox1.Controls.Add(this.rbOndortOnbes);
            this.groupBox1.Controls.Add(this.rbOnucOndort);
            this.groupBox1.Location = new System.Drawing.Point(382, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 152);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reservasyon saati";
            // 
            // rbOnaltiOnyedi
            // 
            this.rbOnaltiOnyedi.AutoSize = true;
            this.rbOnaltiOnyedi.Location = new System.Drawing.Point(183, 107);
            this.rbOnaltiOnyedi.Name = "rbOnaltiOnyedi";
            this.rbOnaltiOnyedi.Size = new System.Drawing.Size(66, 21);
            this.rbOnaltiOnyedi.TabIndex = 7;
            this.rbOnaltiOnyedi.TabStop = true;
            this.rbOnaltiOnyedi.Text = "16-17";
            this.rbOnaltiOnyedi.UseVisualStyleBackColor = true;
            // 
            // rbsekizOn
            // 
            this.rbsekizOn.AutoSize = true;
            this.rbsekizOn.Location = new System.Drawing.Point(22, 32);
            this.rbsekizOn.Name = "rbsekizOn";
            this.rbsekizOn.Size = new System.Drawing.Size(58, 21);
            this.rbsekizOn.TabIndex = 2;
            this.rbsekizOn.TabStop = true;
            this.rbsekizOn.Text = "8-10";
            this.rbsekizOn.UseVisualStyleBackColor = true;
            // 
            // rbOnbesOnalti
            // 
            this.rbOnbesOnalti.AutoSize = true;
            this.rbOnbesOnalti.Location = new System.Drawing.Point(183, 59);
            this.rbOnbesOnalti.Name = "rbOnbesOnalti";
            this.rbOnbesOnalti.Size = new System.Drawing.Size(66, 21);
            this.rbOnbesOnalti.TabIndex = 6;
            this.rbOnbesOnalti.TabStop = true;
            this.rbOnbesOnalti.Text = "15-16";
            this.rbOnbesOnalti.UseVisualStyleBackColor = true;
            // 
            // rbOnOniki
            // 
            this.rbOnOniki.AutoSize = true;
            this.rbOnOniki.Location = new System.Drawing.Point(22, 64);
            this.rbOnOniki.Name = "rbOnOniki";
            this.rbOnOniki.Size = new System.Drawing.Size(66, 21);
            this.rbOnOniki.TabIndex = 3;
            this.rbOnOniki.TabStop = true;
            this.rbOnOniki.Text = "10-12";
            this.rbOnOniki.UseVisualStyleBackColor = true;
            // 
            // rbOndortOnbes
            // 
            this.rbOndortOnbes.AutoSize = true;
            this.rbOndortOnbes.Location = new System.Drawing.Point(183, 21);
            this.rbOndortOnbes.Name = "rbOndortOnbes";
            this.rbOndortOnbes.Size = new System.Drawing.Size(66, 21);
            this.rbOndortOnbes.TabIndex = 5;
            this.rbOndortOnbes.TabStop = true;
            this.rbOndortOnbes.Text = "14-15";
            this.rbOndortOnbes.UseVisualStyleBackColor = true;
            // 
            // rbOnucOndort
            // 
            this.rbOnucOndort.AutoSize = true;
            this.rbOnucOndort.Location = new System.Drawing.Point(22, 107);
            this.rbOnucOndort.Name = "rbOnucOndort";
            this.rbOnucOndort.Size = new System.Drawing.Size(66, 21);
            this.rbOnucOndort.TabIndex = 4;
            this.rbOnucOndort.TabStop = true;
            this.rbOnucOndort.Text = "13-14";
            this.rbOnucOndort.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(8, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Gün";
            // 
            // dtpDay
            // 
            this.dtpDay.Location = new System.Drawing.Point(171, 126);
            this.dtpDay.Name = "dtpDay";
            this.dtpDay.Size = new System.Drawing.Size(185, 22);
            this.dtpDay.TabIndex = 13;
            // 
            // btnDeleteReservation
            // 
            this.btnDeleteReservation.Location = new System.Drawing.Point(203, 179);
            this.btnDeleteReservation.Name = "btnDeleteReservation";
            this.btnDeleteReservation.Size = new System.Drawing.Size(163, 33);
            this.btnDeleteReservation.TabIndex = 8;
            this.btnDeleteReservation.Text = "İptal Et";
            this.btnDeleteReservation.UseVisualStyleBackColor = true;
            // 
            // btnInsertReservation
            // 
            this.btnInsertReservation.Location = new System.Drawing.Point(0, 179);
            this.btnInsertReservation.Name = "btnInsertReservation";
            this.btnInsertReservation.Size = new System.Drawing.Size(196, 33);
            this.btnInsertReservation.TabIndex = 7;
            this.btnInsertReservation.Text = "Ekle";
            this.btnInsertReservation.UseVisualStyleBackColor = true;
            this.btnInsertReservation.Click += new System.EventHandler(this.btnInsertReservation_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView2.Location = new System.Drawing.Point(3, 236);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(707, 154);
            this.dataGridView2.TabIndex = 6;
            // 
            // cbMeeting
            // 
            this.cbMeeting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMeeting.FormattingEnabled = true;
            this.cbMeeting.Location = new System.Drawing.Point(171, 74);
            this.cbMeeting.Name = "cbMeeting";
            this.cbMeeting.Size = new System.Drawing.Size(185, 24);
            this.cbMeeting.TabIndex = 4;
            // 
            // frmTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 422);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.DataGridView dgwMeeting;
        private System.Windows.Forms.Button btnDeleteReservation;
        private System.Windows.Forms.Button btnInsertReservation;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox cbMeeting;
        private System.Windows.Forms.TextBox tbReservationName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbOnaltiOnyedi;
        private System.Windows.Forms.RadioButton rbsekizOn;
        private System.Windows.Forms.RadioButton rbOnbesOnalti;
        private System.Windows.Forms.RadioButton rbOnOniki;
        private System.Windows.Forms.RadioButton rbOndortOnbes;
        private System.Windows.Forms.RadioButton rbOnucOndort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDay;
    }
}