
using CatalogAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogAPI.Domain.Entities
{
    public class Product : BaseEntitiy
    {
        public string Description { get; set; }
        public double Price { get; set; }
        public string StockStatus { get; set; }
    }
}
