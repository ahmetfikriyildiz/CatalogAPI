﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogAPI.Application.ViewModels.Products
{
    public class Update_Product
    {
        public int? Id { get; set; }
        public string? Description { get; set; }
        public double? Price { get; set; }
        public string? StockStatus { get; set; }
    }
}