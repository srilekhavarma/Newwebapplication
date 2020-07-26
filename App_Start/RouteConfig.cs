using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Newwebapplication
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
           // routes.IgnoreRoute("Home/Aboutus");--- to ignore the url 

            /// Parameteres in Maproute
            /// (Name="Default",
            /// url="{Controller}/{action}/{id}",
            /// default:)


            /// conventional based routing --old MVC5
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "index", id = UrlParameter.Optional }
            );

            /// attribute based routing --to access this write above the conventional based routing
           // routes.MapRoute(
           //    name: "Default1",
           //    url: "srilekha/mvc",
           //    defaults: new { controller = "Home", action = "index", id = UrlParameter.Optional }
           //);
        }
    }
}
