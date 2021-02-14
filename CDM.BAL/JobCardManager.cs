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
    public class JobCardManager : IJobCardManager
    {
        private readonly IJobCardRepository _JobCardRepo;
        public JobCardManager(IJobCardRepository jobCardRepo)
        {

            _JobCardRepo = jobCardRepo;
        }
        public List<JobCardDTO> GetAllJobCard()
        {
            return _JobCardRepo.GetAllJobCard();
        }
    }
}
