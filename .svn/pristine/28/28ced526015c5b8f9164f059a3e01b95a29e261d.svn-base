using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SelfCheckinWebApp.Models
{
    public class Contact
    {
        public int ContactID { get; set; }

        public int BookingID { get; set; }

        public string Title { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string CompanyName { get; set; }

        public virtual List<ContactProfile> Profiles { get; set; }

        public bool IsPrimaryContact { get; set; }

        public bool MarketingPermissionSought { get; set; }

        public List<LookupItem> Interests { get; set; }
    }
}