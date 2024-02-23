using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SelfCheckinWebApp.ViewModels
{
    public class ContactViewModel
    {
        public int ContactID { get; set; }

        public int BookingID { get; set; }

        public string Title { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "*First name is required")]
        public string FirstName { get; set; }

        [Display(Name = "Surname")]
        [Required(ErrorMessage = "*Surname is required")]
        public string LastName { get; set; }

        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }

        public List<ContactProfileViewModel> Profiles { get; set; }

        public bool IsPrimaryContact { get; set; }

        public bool MarketingPermissionSought { get; set; }

        public List<LookupItemViewModel> Interests { get; set; }

        // Create New Contact Partial Properties
        public List<SelectListItem> Titles { get; set; }

        public ContactProfileViewModel AdditionalProfile { get; set; }

        public List<LookupItemViewModel> MarketingPreferences { get; set; }
    }
}