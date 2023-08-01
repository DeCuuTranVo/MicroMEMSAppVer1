using System;
using System.Collections.Generic;
using System.Configuration;
//using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;

namespace MicroMEMSApp.Entities
{
    internal class AppDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public AppDbContext() //: base("name=AppDbContext")
        {
            this.Database.Connection.ConnectionString = "Data Source=.\\sqlexpress;Initial Catalog=TBYTDb;Integrated Security=True"; 
        }

        #region Thiet Bi Y Te

        public Microsoft.EntityFrameworkCore.DbSet<TBYT> TBYTs { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<TBYT_LK> TBYT_LKs { get; set; }
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["ThietBiYTeDatabase"].ConnectionString);
        }

        
    }
}
