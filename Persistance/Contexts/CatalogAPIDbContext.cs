using CatalogAPI.Domain.Entities;
using CatalogAPI.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Contexts
{
    public class CatalogAPIDbContext : DbContext
    {
        public CatalogAPIDbContext(DbContextOptions options):base (options) 
        { }
        public DbSet<BaseEntitiy> BaseEntities { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
