using CDM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDM.BAL.Manager
{
    public interface IServiceManager
    {
        List<ServiceDTO> GetAllService();
    }
}
