using CDM.BAL;
using CDM.BAL.Helper;
using CDM.BAL.Manager;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace CDM.WebAPI
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<ICustomerManager, CustomerManager>();

            container.RegisterType<IAppoinmentManager, AppoinmentManager>();

            container.RegisterType<IJobCardManager, JobCardManager>();
            container.RegisterType<IMechanicManager, MechanicManager>();
            container.RegisterType<IRecordManager, RecordManager>();
            container.RegisterType<IServiceManager, ServiceManager>();
            container.RegisterType<IVehicleManager, VehicleManager>();

            container.RegisterType<IDealerManager, DealerManager>();
            container.AddNewExtension<UnityRepoHelper>();
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);

        }
    }
}