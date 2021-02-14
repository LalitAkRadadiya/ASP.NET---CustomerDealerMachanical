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
    public class JobCardRepository : IJobCardRepository
    {
        private readonly Database.DotNetAssignmentDBEntities _dbContext;

        public JobCardRepository()
        {
            _dbContext = new Database.DotNetAssignmentDBEntities();
        }

        public List<JobCardDTO> GetAllJobCard()
        {
            var config = new MapperConfiguration(c => c.CreateMap<Database.tblAppointment, JobCardDTO>());
            var mapper = config.CreateMapper();

            var JobCardentity = _dbContext.tblJobCards.ToList();
            List<JobCardDTO> listJobCard = new List<JobCardDTO>();

            if (JobCardentity != null)
            {
                foreach (var item in JobCardentity)
                {
                    JobCardDTO ex = mapper.Map<JobCardDTO>(item);
                    listJobCard.Add(ex);
                };
            }
            return listJobCard;
        }
    }
}
