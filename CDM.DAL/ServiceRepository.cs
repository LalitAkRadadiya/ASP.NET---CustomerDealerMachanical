using CDM.DAL.Repository;
using CDM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
namespace CDM.DAL
{
    public class ServiceRepository : IServiceRepository
    {
        private readonly Database.DotNetAssignmentDBEntities _dbContext;

        public ServiceRepository()
        {
            _dbContext = new Database.DotNetAssignmentDBEntities();
        }

        public List<ServiceDTO> GetAllService()
        {
            var config = new MapperConfiguration(c => c.CreateMap<Database.tblAppointment, ServiceDTO>());
            var mapper = config.CreateMapper();

            var Serviceentity = _dbContext.tblServices.ToList();
            List<ServiceDTO> listService = new List<ServiceDTO>();

            if (Serviceentity != null)
            {
                foreach (var item in Serviceentity)
                {
                    ServiceDTO ex = mapper.Map<ServiceDTO>(item);
                    listService.Add(ex);
                };
            }
            return listService;
        }
    }
}
