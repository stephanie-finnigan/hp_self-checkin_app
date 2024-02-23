using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SelfCheckinWebApp.Models
{
    public class ContactProfile
    {
        public int ProfileID { get; set; }

        public int ContactID { get; set; }

        public virtual Address Address { get; set; }

        public string Telephone { get; set; }

        public string Mobile { get; set; }

        public string TelephoneOther { get; set; }

        public string Email1 { get; set; }

        public string Email2 { get; set; }

        //public bool IsDefault { get; set; }
    }
}