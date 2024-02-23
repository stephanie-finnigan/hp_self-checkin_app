using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SelfCheckinWebApp.ViewModels
{
    public class ContactProfileViewModel
    {
        public int ProfileID { get; set; }

        public int ContactID { get; set; }

        public virtual AddressViewModel Address { get; set; }

        [Display(Name = "Is this a business address?")]
        public bool IsBusinessAddr { get; set; }

        [Display(Name = "Tel Number")]
        public string Telephone { get; set; }

        [Display(Name = "Tel Mobile")]
        public string Mobile { get; set; }

        [Display(Name = "Tel Other")]
        public string TelephoneOther { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "*Email address is required.")]
        public string Email1 { get; set; }

        [Display(Name = "Email 2")]
        public string Email2 { get; set; }
    }
}