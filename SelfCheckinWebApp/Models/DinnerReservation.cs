using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SelfCheckinWebApp.Models
{
    public class DinnerReservation
    {
        public int BookingID { get; set; }

        public string Restaurant { get; set; }

        public int NumPersons { get; set; }

        public DateTime DinnerDate { get; set; }

        public DateTime DinnerTime { get; set; }
    }
}