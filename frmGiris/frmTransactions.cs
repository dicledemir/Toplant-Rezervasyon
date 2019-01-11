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
        Reservation r = new Reservation();
        TransactionsRepo tr = new TransactionsRepo();
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
            var a = cbMeeting.ValueMember = "MeetingID";
          
            dgwMeeting.DataSource = null;
            dgwMeeting.DataSource = tr.GetMeeting();
           
            cbMeeting.DisplayMember = "MeetingName";
            cbMeeting.DataSource = null;
            cbMeeting.DataSource = tr.GetMeeting();
            dataGridView2.DataSource = tr.GetReservation(a);
            dgwMeeting.Columns[0].Visible = false;
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[4].Visible = false;
        }
        public int TimeReservation()
        {
            if (rbsekizOn.Checked)
            {
                return 1;
            }
            else if (rbOnOniki.Checked)
            {
                return 2;
            }
            else if (rbOnucOndort.Checked)
            {
                return 3;
            }
            else if (rbOndortOnbes.Checked)
            {
                return 4;
            }
            else if (rbOndortOnbes.Checked)
            {
                return 5;
            }
            else
                return 6;
        }
        private void btnInsertReservation_Click(object sender, EventArgs e)
        {

            var liste =  tr.GetReservation(Convert.ToDateTime(dtpDay.Value.ToShortDateString()), (int)cbMeeting.SelectedValue);
            bool Cakisma = false;
            foreach (var item in liste)
            {
                if(item.time== TimeReservation())
                {
                    MessageBox.Show("Sectiğininz saat Dolu");                    
                }
                Cakisma = true;
            }
            if (Cakisma == false)
            {
                r.Day = Convert.ToDateTime(dtpDay.Value.ToShortDateString());
                var a = (int)cbMeeting.SelectedValue;
                r.MeetingId = a;
                r.time = TimeReservation();
                r.ReservationName = tbReservationName.Text;

                tr.InsertReservation(r);
                MessageBox.Show("Kayıt Yapıldı");
            }

        }
    }
}
