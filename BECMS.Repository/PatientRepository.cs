using BECMS.Entity.EntityDbContext;
using BECMS.Entity.Patients;
using BECMS.Models.Patients;
using FerPROJ.DBHelper.Base;
using FerPROJ.Design.Controls;
using FerPROJ.Design.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BECMS.Repository {
    public class PatientRepository : BaseRepository<BECMSDbContext, PatientModel, Patient, Guid>, IEntityDataAsync<Patient> {
        public PatientRepository() {
        }

        public PatientRepository(BECMSDbContext ts) : base(ts) {
        }

        public async Task<IEnumerable<Patient>> GetAllAsync(string searchText, DateTime? dateFrom, DateTime? dateTo) {
            return await GetAllWithSearchAsync(searchText, dateFrom, dateTo);
        }

        public Task<string> GetNewIDAsync() {
            throw new NotImplementedException();
        }

        public Task LoadComboBoxAsync(CComboBoxKrypton cmb) {
            throw new NotImplementedException();
        }
    }
}
