using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroMEMSApp.Entities
{
    internal class AppDbContext : DbContext
    {
        public AppDbContext() //: base("name=AppDbContext")
        {
            this.Database.Connection.ConnectionString = "Data Source=.\\sqlexpress;Initial Catalog=TBYTDb;Integrated Security=True"; 
        }

        #region Thiet Bi Y Te

        public DbSet<TBYT> TBYTs { get; set; }
        public DbSet<TBYT_LK> TBYT_LKs { get; set; }
        #endregion

        
    }
}
