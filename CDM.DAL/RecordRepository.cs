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
    public class RecordRepository : IRecordRepository
    {
        private readonly Database.DotNetAssignmentDBEntities _dbContext;

        public RecordRepository()
        {
            _dbContext = new Database.DotNetAssignmentDBEntities();
        }

        public List<RecordDTO> GetAllRecord()
        {
            var config = new MapperConfiguration(c => c.CreateMap<Database.tblAppointment, RecordDTO>());
            var mapper = config.CreateMapper();

            var Recordentity = _dbContext.tblRecords.ToList();
            List<RecordDTO> listRecord = new List<RecordDTO>();

            if (Recordentity != null)
            {
                foreach (var item in Recordentity)
                {
                    RecordDTO ex = mapper.Map<RecordDTO>(item);
                    listRecord.Add(ex);
                };
            }
            return listRecord;
        }
    }
}
