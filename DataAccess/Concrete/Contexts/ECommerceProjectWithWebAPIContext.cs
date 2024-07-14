using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Contexts
{
    public class ECommerceProjectWithWebAPIContext:DbContext
    {
        public ECommerceProjectWithWebAPIContext(DbContextOptions<ECommerceProjectWithWebAPIContext>options):base(options)
        {
                
        }
        public ECommerceProjectWithWebAPIContext()
        {
                
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connString = "Data Source=GULIYEV\\MSSQLSERVER2022;Initial Catalog=ECommerceProjectWithWebAPIDb;Integrated Security=true";
            optionsBuilder.UseSqlServer(connString);
        
        }
    }
}
