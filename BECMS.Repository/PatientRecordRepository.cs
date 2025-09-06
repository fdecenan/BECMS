using BECMS.Entity.EntityDbContext;
using BECMS.Entity.PatientRecords;
using BECMS.Models.PatientRecords;
using FerPROJ.DBHelper.Base;
using FerPROJ.Design.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BECMS.Repository {
    public class PatientRecordRepository : BaseItemRepository<BECMSDbContext, PatientRecordModel, PatientRecordItemModel, PatientRecord, PatientRecordItem>, IModelViewAsync<PatientRecordModel> {
        public PatientRecordRepository() {
        }

        public PatientRecordRepository(BECMSDbContext ts) : base(ts) {
        }

        public async Task<IEnumerable<PatientRecordModel>> GetViewAsync(string searchText = "", int dataLimit = 100, DateTime? dateFrom = null, DateTime? dateTo = null) {
            return await GetAllModelWithSearchAsync(searchText, dateFrom, dateTo);
        }
    }
}
