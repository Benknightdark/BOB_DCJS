using System.Web.Mvc;
using System.Web.Routing;

namespace Demo0805
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Bookstores", action = "Index", id = UrlParameter.Optional }
               //namespaces: new string[] { "Demo0805.Areas.LinqTest.Controllers" }
            );
        }
    }
}