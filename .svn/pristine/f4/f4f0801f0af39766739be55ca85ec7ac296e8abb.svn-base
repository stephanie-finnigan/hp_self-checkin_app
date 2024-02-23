using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SelfCheckinWebApp.ViewModels
{
    public class NewspaperViewModel
    {
        public int NewspaperID { get; set; }

        [Display(Name = "Newspapers")]
        public string Description { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yy}")]
        public DateTime NewspaperDate { get; set; }

        public int BookingID { get; set; }
    }
}