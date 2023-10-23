using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ComicBookGallery
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            // Routes are defined by creating a series of rules. 
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}"); // first rule: requests for files that have an extension of .axd should be ignored by routing engine

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "ComicBooks", action = "Index", id = UrlParameter.Optional }
            ); //Order of the rule is important
        }
    }
}
