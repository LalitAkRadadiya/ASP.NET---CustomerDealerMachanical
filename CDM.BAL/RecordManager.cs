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
    public class RecordManager : IRecordManager
    {
        private readonly IRecordRepository _RecordRepo;
        public RecordManager(IRecordRepository recordRepo)
        {

            _RecordRepo = recordRepo;
        }
        public List<RecordDTO> GetAllRecord()
        {
            return _RecordRepo.GetAllRecord();
        }
    }
}
