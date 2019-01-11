using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmGiris.Models
{
    public enum Time
    {
        sekizOn,
        OnOniki,
        OnucOndort,
        OndortOnBes,
        OnbesOnalti,
        OnaltiOnyedi  
    }
    class Meeting
    {
        public int MeetingId { get; set; }
        public string MeetingName { get; set; }
        public List<Reservation> Reservation { get; set; }

    }
    class Reservation
    {
        public int ReservationID { get; set; }
        public string ReservationName { get; set; }    
        public DateTime Day { get; set; }
        public int time { get; set; }
        public int MeetingId { get; set; }
          
    }
}
