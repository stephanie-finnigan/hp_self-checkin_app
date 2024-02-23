using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SelfCheckinWebApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{siteName}/{controller}/{action}/{id}/{surname}",
                // TODO before deploying to production, define a sensible defaut page here
                defaults: new { siteName = "Office", controller = "Home", action = "Index", id = UrlParameter.Optional, surname = UrlParameter.Optional }
            );
        }
    }
}
