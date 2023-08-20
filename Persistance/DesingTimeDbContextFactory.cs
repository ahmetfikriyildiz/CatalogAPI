using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Persistance.Contexts;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance
{
    public class DesingTimeDbContextFactory : IDesignTimeDbContextFactory<CatalogAPIDbContext>
    {
        
        public CatalogAPIDbContext CreateDbContext(string[] args)
        {
        
            DbContextOptionsBuilder<CatalogAPIDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseSqlServer(Configuration.ConnectionString);

            return new (dbContextOptionsBuilder.Options);
        }
    }
}
