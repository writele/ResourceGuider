using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using ResourceGuide.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomHelpers
{
    public static class CustomHTMLHelpers
    {
        private static ApplicationDbContext db = new ApplicationDbContext();
        private static UserManager<ApplicationUser> userManager = new UserManager<ApplicationUser>(
                new UserStore<ApplicationUser>(db));

        public static IHtmlString ToUserTime(this HtmlHelper helper, DateTimeOffset ModelTime)
        {

            var user = userManager.FindById(HttpContext.Current.User.Identity.GetUserId());
            var userTimeZone = user.TimeZone;
            var timezoneId = TimeZoneInfo.FindSystemTimeZoneById(userTimeZone);
            var newTime = TimeZoneInfo.ConvertTime(ModelTime, timezoneId);
            string htmlString = newTime.ToString(); 
            return new HtmlString(htmlString); 
        }

        public static IHtmlString ToUserTime(this HtmlHelper helper, DateTimeOffset ModelTime, string ToStringFormat)
        {

            var user = userManager.FindById(System.Web.HttpContext.Current.User.Identity.GetUserId());
            var userTimeZone = user.TimeZone;
            var timezoneId = TimeZoneInfo.FindSystemTimeZoneById(userTimeZone);
            var newTime = TimeZoneInfo.ConvertTime(ModelTime, timezoneId);
            string htmlString = newTime.ToString(ToStringFormat); 
            return new HtmlString(htmlString);
        }
    }
}