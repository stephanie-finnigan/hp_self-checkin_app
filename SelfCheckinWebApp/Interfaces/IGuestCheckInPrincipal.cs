using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace SelfCheckinWebApp.Interfaces
{
    interface IGuestCheckInPrincipal : IPrincipal
    {
        int BookingId { get; set; }

        string Surname { get; set; }

        DateTime ArrivalDate { get; set; }

        string SiteName { get; set; }
    }
}