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
    public class CustomerRepository : ICustomerRepository
    {
        private readonly Database.DotNetAssignmentDBEntities _dbContext;

        public CustomerRepository()
        {
            _dbContext = new Database.DotNetAssignmentDBEntities();
        }

        public List<CustomerDTO> GetAllCustomer()
        {
            var config = new MapperConfiguration(c=> c.CreateMap<Database.tblCustomer, CustomerDTO>());
            var mapper = config.CreateMapper();

            var customerentity = _dbContext.tblCustomers.ToList();
            List<CustomerDTO> listCustomer = new List<CustomerDTO>();
            
            if(customerentity!= null)
            {
                foreach (var item in customerentity) {
                    CustomerDTO ex = mapper.Map<CustomerDTO>(item);
                    listCustomer.Add(ex);
                } ;
            }
            return listCustomer;
        }
    }
}
