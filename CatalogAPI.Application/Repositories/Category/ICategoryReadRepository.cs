using CatalogAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogAPI.Application.Repositories
{
    public interface ICategoryReadRepository : IReadRepository<Category>
    {
    }
}
