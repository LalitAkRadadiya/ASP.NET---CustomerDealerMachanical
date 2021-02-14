using CDM.BAL.Manager;
using CDM.DAL.Repository;
using CDM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDM.BAL
{
    public class ServiceManager : IServiceManager
    {
        private readonly IServiceRepository _ServiceRepo;
        public ServiceManager(IServiceRepository serviceRepo)
        {

            _ServiceRepo = serviceRepo;
        }
        public List<ServiceDTO> GetAllService()
        {
            return _ServiceRepo.GetAllService();
        }
    }
}
