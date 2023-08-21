using CatalogAPI.Application.Repositories;
using CatalogAPI.Domain.Entities;
using Persistance.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories
{
    internal class ProductReadRepository : ReadRepository<Product>, IProductReadRepository
    {
        public ProductReadRepository(CatalogAPIDbContext context) : base(context)
        {
        }
    }
}
