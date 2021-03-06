using System.Web.Http;
using System.Web.Mvc;
using MDB.Data.EF.Repos;
using MDB.Domain.Model.Abstract;
using Microsoft.Practices.Unity;
using Unity.Mvc4;

namespace MDB.WebUi
{
    public static class Bootstrapper
    {
        public static void Initialise()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            GlobalConfiguration.Configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // e.g. container.RegisterType<ITestService, TestService>();            
            RegisterTypes(container);

            return container;
        }

        public static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<IUserProfilesRepository, EFUserProfilesRepository>();
        }
    }
}