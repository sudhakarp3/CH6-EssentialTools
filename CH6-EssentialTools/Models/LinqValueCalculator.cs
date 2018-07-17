﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CH6_EssentialTools.Models
{
    public class LinqValueCalculator
    {
        public decimal ValueProducts(IEnumerable<Product> products)
        {
            return products.Sum(p => p.Price);
        }

    }
}