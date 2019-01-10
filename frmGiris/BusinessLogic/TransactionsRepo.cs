using frmGiris.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmGiris.BusinessLogic
{
    class TransactionsRepo
    {
        public void InsertMeeting(Meeting newMeeting)
        {
            
            SqlParameter p1 = new SqlParameter("MeetingName",newMeeting.MeetingName);
            Program.sqlHelper.ExecuteProc("InsertMeeting",p1);
        }
        public List<Meeting> GetMeeting()
        {
            List<Meeting> liste = new List<Meeting>();
            DataTable dt = Program.sqlHelper.GetTable("Select *From tblMeeting");
            foreach (DataRow item in dt.Rows)
            {
                Meeting m = new Meeting();
                m.MeetingId = (int) item["MeetingID"];
                m.MeetingName = item["MeetingName"].ToString();
                liste.Add(m);
            }
            return liste;
        }
        public void InsertReservation(Reservation newReservation)
        {
            SqlParameter p1 = new SqlParameter("starDate", newReservation.StarDate);
            SqlParameter p2 = new SqlParameter("finishDate", newReservation.FinishDate);
                
            SqlParameter p3 = new SqlParameter("time", newReservation.sure);
            SqlParameter p4 = new SqlParameter("meetingId", newReservation.MeetingId);
            Program.sqlHelper.ExecuteProc("Reservation", p1, p2, p3, p4);
        }
        public List<Reservation> GetReservation()
        {
            List<Reservation> liste = new List<Reservation>();
            DataTable dt = Program.sqlHelper.GetTable("Select *From tblReservation");
            foreach (DataRow item in dt.Rows)
            {
                Reservation r= new Reservation();
                r.FinishDate =Convert.ToDateTime( item["FinishDate"]);
                r.StarDate= Convert.ToDateTime(item["StarDate"]);
                r.sure = item["Time"].ToString();
                
                liste.Add(r);
            }
            return liste;
        }

    }
}
