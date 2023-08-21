using CatalogAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogAPI.Domain.Entities
{
    public class Category : BaseEntitiy
    { 
    public string Description { get; set; }
    public List<Category> SubCategories { get; set; }
    public List<Product> Products { get; set; }

}
}
