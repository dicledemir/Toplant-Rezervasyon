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

            SqlParameter p1 = new SqlParameter("MeetingName", newMeeting.MeetingName);
            Program.sqlHelper.ExecuteProc("InsertMeeting", p1);
        }
        public List<Meeting> GetMeeting(string id)
        {
            List<Meeting> liste = new List<Meeting>();
            DataTable dt = Program.sqlHelper.GetTable(@"Select *from tblReservation r
Inner join tblTime t
On t.ID = r.TimeID
WHERE MeetingID ="+ id+"; ");
            foreach (DataRow item in dt.Rows)
            {
                Meeting m = new Meeting();
                m.MeetingId = (int)item["MeetingID"];
                m.MeetingName = item["MeetingName"].ToString();
                liste.Add(m);
            }
            return liste;
        }
        public List<Meeting> GetMeeting()
        {
            List<Meeting> liste = new List<Meeting>();
            DataTable dt = Program.sqlHelper.GetTable(@"Select *from tblMeeting");
            foreach (DataRow item in dt.Rows)
            {
                Meeting m = new Meeting();
                m.MeetingId = (int)item["MeetingID"];
                m.MeetingName = item["MeetingName"].ToString();
                liste.Add(m);
            }
            return liste;
        }
        public void InsertReservation(Reservation newReservation)
        {
            SqlParameter p1 = new SqlParameter("Day", newReservation.Day);
            SqlParameter p2 = new SqlParameter("ReservationName", newReservation.ReservationName);
            SqlParameter p3 = new SqlParameter("TimeID", newReservation.time);
            SqlParameter p4 = new SqlParameter("meetingId", newReservation.MeetingId);
            Program.sqlHelper.ExecuteProc("InsertReservation", p1, p2, p3, p4);
        }
        public List<Reservation> GetReservation(string id)
        {
            List<Reservation> liste = new List<Reservation>();
            DataTable dt = Program.sqlHelper.GetTable(@"Select *from tblReservation r
Inner join tblTime t
On t.ID = r.TimeID
WHERE MeetingID =" + id + "; ");
            foreach (DataRow item in dt.Rows)
            {
                Reservation r = new Reservation();
                r.Day = Convert.ToDateTime(item["Day"]);
                r.ReservationName = item["ReservationName"].ToString();
                r.time =(int) item["TimeID"];   
                liste.Add(r);
            }
            return liste;
        }
        public List<Reservation> GetReservation(DateTime day,int id )
        {
            List<Reservation> liste = new List<Reservation>();
            DataTable dt = Program.sqlHelper.GetTable(@"Select *from tblReservation r
Inner join tblTime t
On t.ID = r.TimeID
Where DAY='"+day+" ' and MeetingID=' "+id+ "'");

            foreach (DataRow item in dt.Rows)
            {
                Reservation r = new Reservation();
                r.Day = Convert.ToDateTime(item["Day"]);
                r.ReservationName = item["ReservationName"].ToString();
                r.time = (int)item["TimeID"];
              
                liste.Add(r);
            }
            return liste;
        }

    }
}
