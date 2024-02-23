using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SelfCheckinWebApp.ViewModels
{
    public class BookingExtrasPostParam
    {
        public string VehicleRegistration { get; set; }

        public string CheckInNotes { get; set; }

        public string SelectedETA { get; set; }

        public string AnswerTD { get; set; }

        public string AnswerSI { get; set; }

        public bool FastCheckout { get; set; }
    }
}