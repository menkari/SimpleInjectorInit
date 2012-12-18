using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using SimpleInjector;
using SimpleInjectorInit.Interfaces;
using SimpleInjectorInit.Repositories;

namespace SimpleInjectorInit
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            // Dependancy Injectior Initialisation..

            // 1. Create a new Simple Injector Container
            var container = new Container();

            // 2. Configure the container..
            container.Register<IBasicRepository, ApiBasicRepository>();
            //container.Register<IBasicRepository, TextBasicRepository>();

            //container.RegisterSingle<ILogger>(() => new CompositeLogger(
            //    container.GetInstance<DatabaseLogger>(),
            //    container.GetInstance<MailLogger>()
            //    ));

            // 3. Optionally verify the continaer's confguration.
            container.Verify();

            // 4. Store the container for use the MVC application..

        }
    }
}