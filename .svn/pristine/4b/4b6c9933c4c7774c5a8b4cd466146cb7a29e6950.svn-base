using SelfCheckinWebApp.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SelfCheckinWebApp.ViewModels
{
    public class AddressViewModel : IAddress
    {
        public int AddressID { get; set; }

        [Display(Name = "Addr Line 1")]
        [Required(ErrorMessage = "*First line of address is required.")]
        public string AddressLine1 { get; set; }

        [Display(Name = "Addr Line 2")]
        public string AddressLine2 { get; set; }

        [Display(Name = "Addr Line 3")]
        public string AddressLine3 { get; set; }

        public string Town { get; set; }

        [Display(Name = "County/State")]
        public string County { get; set; }

        [Display(Name = "Post Code")]
        [Required(ErrorMessage = "*Post Code is required.")]
        public string PostCode { get; set; }

        [Display(Name = "Country")]
        public string Country { get; set; }

        public bool IsActive { get; set; }

        [Display(Name = "Address")]
        [DataType(DataType.MultilineText)]
        public string GetDisplayAddress
        {
            get
            {
                return this.ToDisplayString();
            }
        }
    }
}