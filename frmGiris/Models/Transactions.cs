using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmGiris.Models
{
    class Meeting
    {
        public int MeetingId { get; set; }
        public string MeetingName { get; set; }


    }
    class Reservation
    {
        public int ReservationID { get; set; }
        public DateTime StarDate { get; set; }
        public DateTime FinishDate { get; set; }
        public string sure { get; set; }
        public int MeetingId { get; set; }
       
            
      

    }
}
