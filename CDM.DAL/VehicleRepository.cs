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
    public class VehicleRepository : IVehicleRepository
    {
        private readonly Database.DotNetAssignmentDBEntities _dbContext;

        public VehicleRepository()
        {
            _dbContext = new Database.DotNetAssignmentDBEntities();
        }

        public List<VehicleDTO> GetAllVehicle()
        {
            var config = new MapperConfiguration(c => c.CreateMap<Database.tblAppointment, VehicleDTO>());
            var mapper = config.CreateMapper();

            var Vehicleentity = _dbContext.tblVehicles.ToList();
            List<VehicleDTO> listVehicle = new List<VehicleDTO>();

            if (Vehicleentity != null)
            {
                foreach (var item in Vehicleentity)
                {
                    VehicleDTO ex = mapper.Map<VehicleDTO>(item);
                    listVehicle.Add(ex);
                };
            }
            return listVehicle;
        }
    }
}
