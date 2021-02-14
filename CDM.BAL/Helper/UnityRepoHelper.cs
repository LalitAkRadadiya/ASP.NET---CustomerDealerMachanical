using CDM.DAL;
using CDM.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Extension;

namespace CDM.BAL.Helper
{
    public class UnityRepoHelper : UnityContainerExtension
    {
        protected override void Initialize()
        {
            Container.RegisterType<IVehicleRepository, VehicleRepository>();
            Container.RegisterType<IServiceRepository, ServiceRepository>();
            Container.RegisterType<IRecordRepository, RecordRepository>();
            Container.RegisterType<IMechanicRepository, MechanicRepository>();
            Container.RegisterType<IJobCardRepository, JobCardRepository>();
            Container.RegisterType<IDealerRepository, DealerRepository>();
            Container.RegisterType<ICustomerRepository, CustomerRepository>();
            Container.RegisterType<IAppoinmentRepository, AppoinmentRepository>();
        }
    }
}
