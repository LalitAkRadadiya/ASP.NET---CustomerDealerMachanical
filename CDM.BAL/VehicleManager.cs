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
    public class VehicleManager : IVehicleManager
    {
        private readonly IVehicleRepository _VehicleRepo;
        public VehicleManager(IVehicleRepository vehicleRepo)
        {

            _VehicleRepo = vehicleRepo;
        }
        public List<VehicleDTO> GetAllVehicle()
        {
            return _VehicleRepo.GetAllVehicle();
        }
    }
}
