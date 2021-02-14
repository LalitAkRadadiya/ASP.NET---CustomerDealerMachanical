using CDM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDM.DAL.Repository
{
    public interface IRecordRepository
    {
        List<RecordDTO> GetAllRecord();
    }
}
