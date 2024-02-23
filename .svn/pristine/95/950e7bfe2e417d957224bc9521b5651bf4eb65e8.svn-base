using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SelfCheckinWebApp.ViewModels
{
    public class AddNewspapersViewModel
    {
        public int BookingID { get; set; }

        [Display(Name = "Select a date")]
        [Required(ErrorMessage = "*Please select a date.")]
        public string DateSelected { get; set; }

        public List<SelectListItem> StayDatesSelect { get; set; }

        public List<DateTime> StayDates { get; set; }

        [Display(Name = "Select papers")]
        [Required(ErrorMessage = "*Please select at least 1 newspaper.")]
        public int[] SelectedPapers { get; set; }

        public List<NewspaperViewModel> Newspapers { get; set; }

        [Display(Name = "Same for all weekdays")]
        public bool SameDaily { get; set; }
    }
}