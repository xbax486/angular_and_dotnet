﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AngularAndMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "customer",
                url: "customer/{*catchall}",
                defaults: new { controller = "Home", action = "Customer" });

            routes.MapRoute(
                name: "product",
                url: "product/{*catchall}",
                defaults: new { controller = "Home", action = "Product" });

            routes.MapRoute(
                name: "order",
                url: "order/{*catchall}",
                defaults: new { controller = "Home", action = "Order" });

            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
