using System;
using System.Linq;
using System.Collections;
using System.Reflection;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Perfectial.EntityFramework.Sample.DataAccess
{
    public class DataContext : DbContext
    {
        #region Constructors
        public DataContext() : base("DataContext") { }
        public DataContext(string connectionString)
            : base(connectionString)
        { }
        #endregion

        #region Model Building
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            ModelConfig.BuildModel(modelBuilder);
        }
        #endregion
    }
}
