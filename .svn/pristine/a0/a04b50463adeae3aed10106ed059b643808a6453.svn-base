using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SelfCheckinWebApp.ViewModels
{
    public class DinnerReservationsViewModel
    {
        public BookingViewModel Booking { get; set; }

        public DinnerReservationViewModel DinnerReservation { get; set; }

        [Display(Name = "Choose a restaurant")]
        public string Restaurant { get; set; }

        public List<SelectListItem> Restaurants { get; set; }

        public List<SelectListItem> Times { get; set; }

        [Display(Name = "Number of persons")]
        [Required(ErrorMessage = "*Number of persons must be selected.")]
        public int NumPersons { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yy}")]
        public DateTime DinnerDate { get; set; }

        [Display(Name = "Select a date")]
        [Required(ErrorMessage = "*A date must be selected.")]
        public string SelectedDate { get; set; }

        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:t}")]
        public DateTime DinnerTime { get; set; }

        [Display(Name = "Select a time")]
        [Required(ErrorMessage = "*A time must be selected.")]
        public string SelectedTime { get; set; }

        public List<SelectListItem> StayDatesSelect { get; set; }
    }
}