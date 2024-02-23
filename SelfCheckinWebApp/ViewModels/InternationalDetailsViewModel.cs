using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SelfCheckinWebApp.ViewModels
{
    public class InternationalDetailsViewModel : IValidatableObject
    {
        [Display(Name = "Booking Ref:")]
        public int BookingId { get; set; }

        [Display(Name = "Room No:")]
        public string BookingRmNo { get; set; }

        [Display(Name = "Passport Number")]
        public string PassportNum { get; set; }

        [Display(Name = "Issuing Authority")]
        public string IssuingAuthority { get; set; }

        [Display(Name = "Nationality")]
        public string Nationality { get; set; }

        public string Answer { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (!string.IsNullOrEmpty(PassportNum) && string.IsNullOrEmpty(IssuingAuthority) && string.IsNullOrEmpty(Nationality))
            {
                yield return new ValidationResult("*Please enter Issuing Authority.", new List<string> { "IssuingAuthority" });
                yield return new ValidationResult("*Please enter Nationality.", new List<string> { "Nationality" });
            }
            else if (!string.IsNullOrEmpty(PassportNum) && !string.IsNullOrEmpty(IssuingAuthority) && string.IsNullOrEmpty(Nationality))
            {
                yield return new ValidationResult("*Please enter Nationality.", new List<string> { "Nationality" });
            }
            else if (!string.IsNullOrEmpty(PassportNum) && string.IsNullOrEmpty(IssuingAuthority) && !string.IsNullOrEmpty(Nationality))
            {
                yield return new ValidationResult("*Please enter Issuing Authority.", new List<string> { "IssuingAuthority" });
            }
            else if (string.IsNullOrEmpty(PassportNum) && string.IsNullOrEmpty(IssuingAuthority) && string.IsNullOrEmpty(Nationality) && Answer == "Yes")
            {
                yield return new ValidationResult("*Please enter Passport Number.", new List<string> { "PassportNum" });
                yield return new ValidationResult("*Please enter Issuing Authority.", new List<string> { "IssuingAuthority" });
                yield return new ValidationResult("*Please enter Nationality.", new List<string> { "Nationality" });
            }
        }
    }
}