﻿using CatalogAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogAPI.Domain.Entities
{
    public class Order : BaseEntitiy
    { 
        public string Description { get; set; }
        public string Address { get; set; }

        public ICollection<Product> Products { get; set;}
        public Customer Customer { get; set; }
    }
}
