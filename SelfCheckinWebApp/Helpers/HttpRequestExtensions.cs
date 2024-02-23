using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace SelfCheckinWebApp.Helpers
{
    public static class HttpRequestExtensions
    {
        public static string GetRequestSiteName(this HttpRequestBase request)
        {
            return request.RequestContext.GetRequestSiteName();
        }

        public static string GetRequestSiteName(this HttpRequest request)
        {
            return request.RequestContext.GetRequestSiteName();
        }

        public static string GetRequestSiteName(this RequestContext requestContext)
        {
            return Convert.ToString(requestContext.RouteData.Values["siteName"]);
        }
    }
}