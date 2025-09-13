using BECMS.Entity.EntityDbContext;
using BECMS.Entity.Patients;
using BECMS.Models.Patients;
using FerPROJ.DBHelper.Base;
using FerPROJ.DBHelper.DBExtensions;
using FerPROJ.Design.Class;
using FerPROJ.Design.Controls;
using FerPROJ.Design.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BECMS.Repository {
    public class PatientRepository : BaseRepository<BECMSDbContext, PatientModel, Patient, Guid>, IModelViewAsync<PatientModel> {
        public PatientRepository() {
        }

        public PatientRepository(BECMSDbContext ts) : base(ts) {
        }

        public async Task<IEnumerable<PatientModel>> GetViewAsync(string searchText = "", DateTime? dateFrom = null, DateTime? dateTo = null, int dataLimit = 100) {
            
            var query = await GetAllWithSearchAsync(searchText, dateFrom, dateTo, dataLimit);

            var result = await query.SelectListAsync(async c => {

                var model = c.ToDestination<PatientModel>();

                await Task.CompletedTask;

                return model;

            });

            return result;

        }

        public Task<string> GetNewIDAsync() {
            throw new NotImplementedException();
        }

        public Task LoadComboBoxAsync(CComboBoxKrypton cmb) {
            throw new NotImplementedException();
        }
    }
}
