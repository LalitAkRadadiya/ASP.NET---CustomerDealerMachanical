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
    public class DealerManager : IDealerManager
    {
        private readonly IDealerRepository _DealerRepo;
        public DealerManager(IDealerRepository DealerRepo)
        {

            _DealerRepo = DealerRepo; 
        }
        public List<DealerDTO> GetAllDealer()
        {
            return _DealerRepo.GetAllDealer();
        }
        //public Dealer GetDealer(int Id)
        //{
        //    return _DealerRepo.GetDealer(Id);
        //}
    }
}
