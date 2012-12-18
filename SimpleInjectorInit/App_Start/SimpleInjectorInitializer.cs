using SimpleInjectorInit.Interfaces;
using SimpleInjectorInit.Repositories;

[assembly: WebActivator.PreApplicationStartMethod(typeof(SimpleInjectorInit.App_Start.SimpleInjectorInitializer), "Initialize")]

namespace SimpleInjectorInit.App_Start
{
    using System.Reflection;
    using System.Web.Mvc;

    using SimpleInjector;
    using SimpleInjector.Integration.Web.Mvc;
    
    public static class SimpleInjectorInitializer
    {
        /// <summary>Initialize the container and register it as MVC3 Dependency Resolver.</summary>
        public static void Initialize()
        {
            var container = new Container();
            
            InitializeContainer(container);

            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());
            
            container.RegisterMvcAttributeFilterProvider();
       
            // Using Entity Framework? Please read this: http://simpleinjector.codeplex.com/discussions/363935
            container.Verify();
            
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }
     
        private static void InitializeContainer(Container container)
        {
            // Please note that if you updated the SimpleInjector.MVC3 package from a previous version, this
            // SimpleInjectorInitializer class replaces the previous SimpleInjectorMVC3 class. You should
            // move the registrations from the old SimpleInjectorMVC3.InitializeContainer to this method,
            // and remove the SimpleInjectorMVC3 and SimpleInjectorMVC3Extensions class from the App_Start
            // folder.

            // Registration of Services....

            // For instance:
            // container.Register<IUserRepository, SqlUserRepository>();

            // For the purpose of testing the application, there are two different implementations
            // Below, one is calling a repository from a REST API webservice (ApiBasicRepository)  and the 
            // other is pulling text directly from the file system (TextBasicRepository).
            // As both implement the same interface, we simply need to build our Concrete classes 
            // In line with the interface, and declare a mapping in the container (see below).

            //container.Register<IBasicRepository, ApiBasicRepository>();
            container.Register<IBasicRepository, TextBasicRepository>();
        }
    }
}