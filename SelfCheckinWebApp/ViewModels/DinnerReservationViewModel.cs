using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SelfCheckinWebApp.ViewModels
{
    public class DinnerReservationViewModel
    {
        public int BookingID { get; set; }

        public string Restaurant { get; set; }

        public int NumPersons { get; set; }

        public DateTime DinnerDate { get; set; }

        public DateTime DinnerTime { get; set; }
    }
}