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
    public class AppoinmentManager : IAppoinmentManager
    {
        private readonly IAppoinmentRepository _AppoinmentRepo;
        public AppoinmentManager(IAppoinmentRepository AppoinmentRepo)
        {

            _AppoinmentRepo = AppoinmentRepo; 
        }
        public List<AppoinmentDTO> GetAllAppoinment()
        {
            return _AppoinmentRepo.GetAllAppoinment();
        }
    }
}
