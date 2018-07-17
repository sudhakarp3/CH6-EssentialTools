﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CH6_EssentialTools.Models
{
    public class ShoppingCart
    {
        private ILinqValueCalculator calc;
        public ShoppingCart(ILinqValueCalculator calcParam)
        {
            calc = calcParam;
        }
        public IEnumerable<Product> Products { get; set; }
        public decimal CalculateProductTotal()
        {
            return calc.ValueProducts(Products);
        }

    }
}