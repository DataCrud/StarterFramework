﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using Project.Server.Session;

namespace Project.Server
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //#region Web API Routes


            //// Web API Session Enabled Route Configurations
            //routes.MapHttpRoute(
            //    name: "SessionsRoute",
            //    routeTemplate: "api/sessions/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //).RouteHandler = new SessionHttpControllerRouteHandler();

            
            //// Web API Stateless Route Configurations
            //routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new {id = RouteParameter.Optional}
            //);
            //#endregion


            #region MVC Routes
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            #endregion
        }
    }
}
