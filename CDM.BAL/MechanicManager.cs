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
    public class MechanicManager : IMechanicManager
    {
        private readonly IMechanicRepository _MechanicRepo;
        public MechanicManager(IMechanicRepository mechanicRepo)
        {

            _MechanicRepo = mechanicRepo;
        }
        public List<MechanicDTO> GetAllMechanic()
        {
            return _MechanicRepo.GetAllMechanic();
        }
    }
}
