using SelfCheckinWebApp.Helpers;
using SelfCheckinWebApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SelfCheckinWebApp.Models
{
    public class Address : IAddress
    {
        public int AddressID { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string AddressLine3 { get; set; }

        public string Town { get; set; }

        public string County { get; set; }

        public string PostCode { get; set; }

        public string Country { get; set; }

        public bool IsActive { get; set; }

        public string GetDisplayAddress
        {
            get
            {
                return this.ToDisplayString();
            }
        }
    }

    public class CopyOfAddress
    {
        public int AddressID { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string AddressLine3 { get; set; }

        public string Town { get; set; }

        public string County { get; set; }

        public string PostCode { get; set; }

        public string Country { get; set; }

        public bool IsActive { get; set; }

        public string GetDisplayAddress
        {
            get
            {
                string addr = "";
                if (AddressLine1 != null && AddressLine1.Length > 0)
                {
                    addr += AddressLine1 + Environment.NewLine;
                }
                if (AddressLine2 != null && AddressLine2.Length > 0)
                {
                    addr += AddressLine2 + Environment.NewLine;
                }
                if (AddressLine3 != null && AddressLine3.Length > 0)
                {
                    addr += AddressLine3 + Environment.NewLine;
                }
                if (Town != null && Town.Length > 0)
                {
                    addr += Town + Environment.NewLine;
                }
                if (County != null && County.Length > 0)
                {
                    addr += County + Environment.NewLine;
                }
                if (PostCode != null && PostCode.Length > 0)
                {
                    addr += PostCode + Environment.NewLine;
                }
                if (Country != null && Country.Length > 0)
                {
                    addr += Country + Environment.NewLine;
                }
                return addr.Trim();
            }
        }
    }
}