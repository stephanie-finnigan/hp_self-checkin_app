using NLog;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SelfCheckinWebApp.App_Start
{
    public class LoggingFilterAttribute : ActionFilterAttribute
    {
        private static readonly Logger log = LogManager.GetCurrentClassLogger();

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);

            
            if (log.IsDebugEnabled)
            {
                log.Debug("BEGIN Action - {0}::{1}", GetControllerName(filterContext), GetActionName(filterContext));
            }
            GetStopwatch(filterContext, "action").Start();
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            GetStopwatch(filterContext, "action").Stop();

            if (filterContext.Exception != null) log.Error(filterContext.Exception);

            base.OnActionExecuted(filterContext);
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            GetStopwatch(filterContext, "render").Start();
            base.OnResultExecuting(filterContext);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            base.OnResultExecuted(filterContext);

            var renderTimer = GetStopwatch(filterContext, "render");
            renderTimer.Stop();

            var controller = GetControllerName(filterContext);
            var action = GetActionName(filterContext);
            var actionTimer = GetStopwatch(filterContext, "action");

            if (log.IsDebugEnabled)
            {
                log.Debug("END Action - {0}::{1}, Execute: {2}ms, Render: {3}ms",
                          controller,
                          action,
                          actionTimer.ElapsedMilliseconds,
                          renderTimer.ElapsedMilliseconds);
            }
        }

        private static string GetActionName(ControllerContext context)
        {
            return context.RouteData.Values["action"] as string;
        }

        private static string GetControllerName(ControllerContext filterContext)
        {
            return filterContext.RouteData.Values["controller"] as string;
        }

        private static Stopwatch GetStopwatch(ControllerContext context, string name)
        {
            var key = "__timer__" + name + "__" + GetControllerName(context) + "__" + GetActionName(context); // Split stopwatches between requests and ajax requests
            if (context.HttpContext.Items.Contains(key)) return (Stopwatch)context.HttpContext.Items[key];

            var result = new Stopwatch();
            context.HttpContext.Items[key] = result;
            return result;
        }
    }

}