﻿using System;
using CH6_EssentialTools.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CH6_EssentialToolsTest
{
    [TestClass]
    public class UnitTest1
    {
        private IDiscountHelper getTestObject()
        {
            return new MinimumDiscountHelper();
        }

        [TestMethod]
        public void Discount_Above_100()
        {
            // arrange
            IDiscountHelper target = getTestObject();
            decimal total = 200;
            // act
            var discountedTotal = target.ApplyDiscount(total);
            // assert
            Assert.AreEqual(total * 0.9M, discountedTotal);

        }
    }
}
