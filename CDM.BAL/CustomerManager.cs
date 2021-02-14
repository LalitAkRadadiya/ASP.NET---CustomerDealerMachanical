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
    public class CustomerManager : ICustomerManager
    {
        private readonly ICustomerRepository _customerRepo;
        public CustomerManager(ICustomerRepository customerRepo)
        {

            _customerRepo = customerRepo; 
        }
        public List<CustomerDTO> GetAllCustomer()
        {
            return _customerRepo.GetAllCustomer();
        }
    }
}
