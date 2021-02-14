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
    public class DealerRepository : IDealerRepository
    {
        private readonly Database.DotNetAssignmentDBEntities _dbContext;

        public DealerRepository()
        {
            _dbContext = new Database.DotNetAssignmentDBEntities();
        }

        public List<DealerDTO> GetAllDealer()
        {
            var config = new MapperConfiguration(c => c.CreateMap<Database.tblAppointment, DealerDTO>());
            var mapper = config.CreateMapper();

            var Dealerentity = _dbContext.tblDealers.ToList();
            List<DealerDTO> listDealer = new List<DealerDTO>();

            if (Dealerentity != null)
            {
                foreach (var item in Dealerentity)
                {
                    DealerDTO ex = mapper.Map<DealerDTO>(item);
                    listDealer.Add(ex);
                };
            }
            return listDealer;
        }
        //public Dealer GetDealer(int Id)
        //{
        //    var entity = _dbContext.Dealers.Find(Id);


        //    Dealer dealer = new Dealer();

        //    if (entity != null)
        //    {
        //        ///TODO: Problem why manually?                     
        //        dealer.Id = entity.Id;
        //        dealer.DealerName = entity.DealerName;
        //        dealer.City = entity.City;
        //        dealer.Country = entity.Country;
        //        dealer.DealerContact = entity.DealerContact;
        //        dealer.CreatedDate = entity.CreatedDate;
        //        dealer.UpdateDate = entity.UpdatedDate;
        //    }

        //    return dealer;
        //}
    }
}
