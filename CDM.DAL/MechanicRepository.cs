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
    public class MechanicRepository : IMechanicRepository
    {
        private readonly Database.DotNetAssignmentDBEntities _dbContext;

        public MechanicRepository()
        {
            _dbContext = new Database.DotNetAssignmentDBEntities();
        }

        public List<MechanicDTO> GetAllMechanic()
        {
            var config = new MapperConfiguration(c => c.CreateMap<Database.tblAppointment, MechanicDTO>());
            var mapper = config.CreateMapper();

            var Mechanicentity = _dbContext.tblMechanics.ToList();
            List<MechanicDTO> listMechanic = new List<MechanicDTO>();

            if (Mechanicentity != null)
            {
                foreach (var item in Mechanicentity)
                {
                    MechanicDTO ex = mapper.Map<MechanicDTO>(item);
                    listMechanic.Add(ex);
                };
            }
            return listMechanic;
        }
    }
}
