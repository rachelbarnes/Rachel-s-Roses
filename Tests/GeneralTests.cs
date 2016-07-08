using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Roses
{
    [TestFixture]
    class GeneralTests
    {
        public void WhatABunchOfSquares()
        {
            var sqaure = new GeneralFunctionality();
            Assert.AreEqual(16, sqaure.sqaure(4));
        }
        [Test]
        public void HalfRecipe()
        {
            var halfRecipe = new AdjustRecipe();
            var expected = halfRecipe.AdjustSingleIngredient(3, .5m);
            var actual = 1.5;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void QuarterRecipe()
        {
            var quarterRecipe = new AdjustRecipe();
            var expected = quarterRecipe.AdjustSingleIngredient(6, .25m);
            var actual = 1.5;
            Assert.AreEqual(expected, actual);
        }
    }
}

