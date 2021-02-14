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
    public class AppoinmentRepository : IAppoinmentRepository
    {
        private readonly Database.DotNetAssignmentDBEntities _dbContext;

        public AppoinmentRepository()
        {
            _dbContext = new Database.DotNetAssignmentDBEntities();
        }

        public List<AppoinmentDTO> GetAllAppoinment()
        {
            var config = new MapperConfiguration(c=> c.CreateMap<Database.tblAppointment, AppoinmentDTO>());
            var mapper = config.CreateMapper();

            var Appoinmententity = _dbContext.tblAppointments.ToList();
            List<AppoinmentDTO> listAppoinment = new List<AppoinmentDTO>();
            
            if(Appoinmententity != null)
            {
                foreach (var item in Appoinmententity) {
                    AppoinmentDTO ex = mapper.Map<AppoinmentDTO>(item);
                    listAppoinment.Add(ex);
                } ;
            }
            return listAppoinment;
        }
    }
}
