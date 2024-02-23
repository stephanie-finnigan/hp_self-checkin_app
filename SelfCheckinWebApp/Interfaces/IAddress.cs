using System;

namespace SelfCheckinWebApp.Interfaces
{
    public interface IAddress
    {
        int AddressID { get; set; }
        string AddressLine1 { get; set; }
        string AddressLine2 { get; set; }
        string AddressLine3 { get; set; }
        string Country { get; set; }
        string County { get; set; }
        string GetDisplayAddress { get; }
        bool IsActive { get; set; }
        string PostCode { get; set; }
        string Town { get; set; }
    }

    public static class AddressExt
    {
        public static string ToDisplayString(this IAddress address)
        {
            string addr = "";
            if (address.AddressLine1 != null && address.AddressLine1.Length > 0)
            {
                addr += address.AddressLine1 + "<br>";
            }
            if (address.AddressLine2 != null && address.AddressLine2.Length > 0)
            {
                addr += address.AddressLine2 + "<br>";
            }
            if (address.AddressLine3 != null && address.AddressLine3.Length > 0)
            {
                addr += address.AddressLine3 + "<br>";
            }
            if (address.Town != null && address.Town.Length > 0)
            {
                addr += address.Town + "<br>";
            }
            if (address.County != null && address.County.Length > 0)
            {
                addr += address.County + "<br>";
            }
            if (address.PostCode != null && address.PostCode.Length > 0)
            {
                addr += address.PostCode + "<br>";
            }
            if (address.Country != null && address.Country.Length > 0)
            {
                addr += address.Country + "<br>";
            }
            return addr.Trim();
        }
    }
}