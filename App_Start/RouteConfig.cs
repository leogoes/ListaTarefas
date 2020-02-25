using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ListaDeTarefas
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            //Rota para visualiar tarefas
            //routes.MapRoute(
            //    name: "ListaTarefas",
            //    url: "tarefas/{name}",
            //    new { controller = "Tarefa", action="Index" , name=UrlParameter.Optional}
            //    );

            //Rota padrao para home
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Tarefas", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
