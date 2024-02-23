using SelfCheckinWebApp.Interfaces;
using System;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace SelfCheckinWebApp.Principal
{
    public class GuestCheckInPrincipal : IGuestCheckInPrincipal
    {
        public IIdentity Identity { get; private set; }

        public bool IsInRole(string role) { return false; }

        public GuestCheckInPrincipal(string bookingId)
        {
            Identity = new GenericIdentity(bookingId);
        }

        public int BookingId { get; set; }

        public string Surname { get; set; }

        public DateTime ArrivalDate { get; set; }

        public string SiteName { get; set; }
    }
}