using frmGiris.BusinessLogic;
using frmGiris.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmGiris
{
    public partial class frmTransactions : Form
    {
        public frmTransactions()
        {
            InitializeComponent();
        }

        private void btnInsertMeeting_Click(object sender, EventArgs e)
        {
            Meeting m = new Meeting();
            m.MeetingName = tbMeeting.Text;
            TransactionsRepo tr = new TransactionsRepo();
            tr.InsertMeeting(m);
            MessageBox.Show("Test");
        }

        private void frmTransactions_Load(object sender, EventArgs e)
        {
            TransactionsRepo tr = new TransactionsRepo();
            dgwMeeting.DataSource = null;
            dgwMeeting.DataSource = tr.GetMeeting();
            var a = cbMeeting.ValueMember = "MeetingID";
            cbMeeting.DisplayMember = "MeetingName";
            cbMeeting.DataSource = null;
            cbMeeting.DataSource = tr.GetMeeting();
            dataGridView2.DataSource = tr.GetReservation();
            dgwMeeting.Columns[0].Visible = false;
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[4].Visible = false;
        }

        private void btnInsertReservation_Click(object sender, EventArgs e)
        {
            Reservation r = new Reservation();
            r.StarDate = Convert.ToDateTime(dtpStartTime.Value.ToLongTimeString());
            r.FinishDate = Convert.ToDateTime(dtpFinishDate.Value.ToLongTimeString());

            TimeSpan time = Convert.ToDateTime(dtpFinishDate.Value.ToLongTimeString())- Convert.ToDateTime(dtpStartTime.Value.ToLongTimeString());
            var a = (int)cbMeeting.SelectedValue;
            r.MeetingId = a;
              r.sure =   time.ToString() ;
            TransactionsRepo tr = new TransactionsRepo();
            tr.InsertReservation(r);
            MessageBox.Show("Test");

        }
    }
}
