using BECMS.Entity.EntityDbContext;
using BECMS.Entity.PatientRecords;
using BECMS.Models.PatientRecords;
using FerPROJ.DBHelper.Base;
using FerPROJ.DBHelper.DBExtensions;
using FerPROJ.Design.Class;
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

        public async Task<IEnumerable<PatientRecordModel>> GetViewAsync(string searchText = "", DateTime? dateFrom = null, DateTime? dateTo = null, int dataLimit = 100) {
            
            var query = await GetAllWithSearchAsync(searchText, dateFrom, dateTo, dataLimit);

            var result = await query.SelectListAsync(async c => {
                
                var model = c.ToDestination<PatientRecordModel>();
                
                await Task.CompletedTask;
                
                return model;

            });

            return result;

        }
    }
}
