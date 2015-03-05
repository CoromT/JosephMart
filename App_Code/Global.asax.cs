using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Mvc;


public class Global : Nop.Web.MvcApplication
{
	public Global()
	{
        if (RouteTable.Routes["ProductById"] == null)
        {
            RouteTable.Routes.MapRoute
            (
                "ProductById",
                "ProductById/{productId}",
                 new { controller = "Product", action = "ProductDetails" },
                 new string[] { "Nop.Web.Controllers" }
            );
        }
	}
}