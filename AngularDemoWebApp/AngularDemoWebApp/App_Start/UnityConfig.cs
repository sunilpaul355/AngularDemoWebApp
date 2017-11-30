using AngularDemoWebApp.DAL.IRepository;
using AngularDemoWebApp.DAL.Repository;
using AngularDemoWebApp.Service.IService;
using AngularDemoWebApp.Service.Service;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace AngularDemoWebApp
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            RegisterTypes(container);
        }

        public static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<IAccountRepository, AccountRepository>();
            container.RegisterType<IAccountService, AccountService>();
        }
    }
}