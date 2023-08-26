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
    public class ProductReadRepository : ReadRepository<Product>, IProductReadRepository
    {
        public ProductReadRepository(CatalogAPIDbContext context) : base(context)
        {
        }

        public Task<Product> GetByIdAsync(int ıd)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetByIdAsync(int? ıd)
        {
            throw new NotImplementedException();
        }
    }
}
