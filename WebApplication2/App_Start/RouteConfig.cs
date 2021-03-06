﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Action", id = UrlParameter.Optional }
            );
            routes.MapRoute(
               name: "About",
               url: "Demo/Index",
               defaults: new { controller = "Demo", action = "Index", id = UrlParameter.Optional }
           );
        }
    }
}
