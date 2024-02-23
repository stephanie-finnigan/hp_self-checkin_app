using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SelfCheckinWebApp.ViewModels
{
    public class PassportInformation
    {
        public string PassportNum { get; set; }

        public string IssuingAuthority { get; set; }

        public string Nationality { get; set; }
    }
}