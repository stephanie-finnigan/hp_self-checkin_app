using SelfCheckinWebApp.Models;
using SelfCheckinWebApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SelfCheckinWebApp.App_Start
{
    public static class AutoMapperConfig
    {
        public static void Configure()
        {
            AutoMapper.Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Address, AddressViewModel>();

                cfg.CreateMap<Booking, BookingViewModel>();

                cfg.CreateMap<Contact, ContactViewModel>();

                cfg.CreateMap<ContactProfile, ContactProfileViewModel>();

                cfg.CreateMap<GuestReminder, GuestReminderViewModel>();

                cfg.CreateMap<Newspaper, NewspaperViewModel>();

                cfg.CreateMap<RestaurantTime, RestaurantTimeViewModel>();

                // Reversed Mapped back to API
                cfg.CreateMap<BookingViewModel, Booking>();

                cfg.CreateMap<ContactViewModel, Contact>();

                cfg.CreateMap<ContactProfileViewModel, ContactProfile>();

                cfg.CreateMap<EditContactProfilePostParam, ContactProfile>()
                    .ForMember(dest => dest.Address,
                               opt => opt.MapFrom(src => new Address
                               {
                                   AddressLine1 = src.AddressLine1,
                                   AddressLine2 = src.AddressLine2,
                                   AddressLine3 = src.AddressLine3,
                                   Town = src.Town,
                                   County = src.County,
                                   PostCode = src.PostCode,
                                   Country = src.Country,
                                   IsActive = true
                               }));
            });
        }
    }
}