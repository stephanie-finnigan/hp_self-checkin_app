using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SelfCheckinWebApp.ViewModels
{
    public class GuestReminderViewModel
    {
        public enum eReminderType : int
        {
            AlarmCall = 1,
            MorningTea = 2
        }

        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:HH:mm}")]
        public DateTime Time { get; set; }

        public eReminderType ReminderType { get; set; }

        public string Note { get; set; }

        public int BookingID { get; set; }
    }
}