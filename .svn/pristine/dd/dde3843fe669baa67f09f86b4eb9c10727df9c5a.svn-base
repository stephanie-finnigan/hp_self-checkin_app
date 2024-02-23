using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SelfCheckinWebApp.ViewModels
{
    public class AddAlarmCallViewModel
    {
        [Required(ErrorMessage = "*Please select a time.")]
        public string SelectedTime { get; set; }

        [Required(ErrorMessage = "*Please select a date.")]
        public string SelectedDate { get; set; }

        public int BookingID { get; set; }

        public List<SelectListItem> StayDatesSelect { get; set; }
    }
}