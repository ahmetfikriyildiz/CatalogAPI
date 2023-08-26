using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogAPI.Application.ViewModels.Products
{
    public class Create_Product
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Description { get; set; }
        public double? Price { get; set; }
        public string? StockStatus { get; set; }
    }
}
