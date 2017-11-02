using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcMusicStore
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);

            //// Attribute Routing
            routes.MapMvcAttributeRoutes();

            routes.MapRoute("blog",
                "{year}/{month}/{day}",
                new { controller = "blcg", action = "index" },
                new { year = @"\d{4}", month = @"\d{2}", day = @"\d{2}" });

            //// Traditional Routing
            routes.MapRoute("simple", 
                "{controller}/{action}/{id}", 
                new { id = UrlParameter.Optional, action = "index" });

            routes.MapRoute("simple2",
                "{controller}/{action}/{id}",
                new { controller = "home",
                    action = "index",
                    id = UrlParameter.Optional});

        }
    }
}
