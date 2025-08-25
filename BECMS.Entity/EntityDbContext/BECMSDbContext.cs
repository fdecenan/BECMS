using BECMS.Entity.Patients;
using BECMS.Entity.Users;
using FerPROJ.Design.Class;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BECMS.Entity.EntityDbContext {
    public partial class BECMSDbContext : DbContext {

        public BECMSDbContext() : base("name=BECMSDbConnection") {
            Database.Connection.ConnectionString = CStaticVariable.ENTITY_CONNECTION_STRING;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Patient> Patients { get; set; }

    }
}
