using NLog;
using SelfCheckinWebApp.DBModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace SelfCheckinWebApp.Helpers
{
    public static class UserLogins
    {
        private static Logger log = LogManager.GetCurrentClassLogger();

        private static int minLoginFailuresForLockout = Convert.ToInt32(ConfigurationManager.AppSettings["MinLoginFailuresForLockout"]);

        private static int minutesUntilUserLockoutExpires = Convert.ToInt32(ConfigurationManager.AppSettings["MinutesUntilUserLockoutExpires"]);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        public static void AddLoginFail(string username)
        {
            if (username == null) throw new ArgumentNullException(nameof(username));

            using (var context = new GuestCheckInDBContext())
            {
                var userLogin = context.UserLogins.FirstOrDefault(ul => ul.Username == username);

                if (userLogin != null)
                {
                    userLogin.LoginFailCount++;

                    userLogin.LastFail = DateTime.UtcNow;
                }
                else
                {
                    userLogin = new UserLogin();
                    userLogin.Username = username;
                    userLogin.Application = "CHK";
                    userLogin.LoginFailCount = 1;
                    userLogin.LastFail = DateTime.UtcNow;

                    context.UserLogins.Add(userLogin);
                }
                context.SaveChanges();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        
        public static bool IsUserLockedOut(string username)
        {
            if (username == null) throw new ArgumentNullException(nameof(username));

            using (var context = new GuestCheckInDBContext())
            {
                try
                {
                    var userLogin = context.UserLogins.FirstOrDefault(ul => ul.Username == username);
                    var isLockedOut = userLogin != null
                                        && userLogin.LoginFailCount >= minLoginFailuresForLockout
                                        && userLogin.LastFail != null
                                        && (DateTime.UtcNow - userLogin.LastFail).TotalMinutes < minutesUntilUserLockoutExpires;

                    return isLockedOut;
                }
                catch (Exception e)
                {
                    log.Error(e);
                    throw;
                }
            }
        }

        public static void ResetUserLoginCount(string username)
        {
            if (username == null) throw new ArgumentNullException(nameof(username));

            using (var context = new GuestCheckInDBContext())
            {
                var userLogin = context.UserLogins.FirstOrDefault(ul => ul.Username == username);

                if (userLogin != null)
                {
                    userLogin.LoginFailCount = 0;
                }
                context.SaveChanges();
            }
        }
    }
}