using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CityWebSite
{
    public class FqdnFilterAttribute : AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            var fqdn = ConfigurationManager.AppSettings["FQDN"];

            if (string.IsNullOrEmpty(fqdn))
            {
                return true;
            }
            else
            {
                return fqdn.Equals(httpContext.Request.Url.Host, 
                    StringComparison.InvariantCultureIgnoreCase);
            }
        }


        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            UrlHelper urlHelper = new UrlHelper(filterContext.RequestContext);

            filterContext.Result = new RedirectResult(urlHelper.Action("Index", "Unauthorized"));
        }
    }
}