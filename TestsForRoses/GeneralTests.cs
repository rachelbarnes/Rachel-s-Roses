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
            var sqaure = new SquareANumber();
            Assert.AreEqual(16, sqaure.sqaure(4));
        }
        [Test]
        public void TestDecimalPlaces()
        {
            var decimalized = new RoundDecimalPlaces();
            var actual = decimalized.RoundToHundrethDecimalPlace(125.65239845m);
            var expected = "125.65";
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void DoubleRecipe()
        {
            var doubleRecipe = new AdjustMeasurements();
            var expected = doubleRecipe.AdjustIngredient(1, 2);
            var actual = 2;
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void HalfRecipe()
        {
            var halfRecipe = new AdjustMeasurements();
            var expected = halfRecipe.AdjustIngredient(3, .5m);
            var actual = 1.5;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void QuarterRecipe()
        {
            var quarterRecipe = new AdjustMeasurements();
            var expected = quarterRecipe.AdjustIngredient(6, .25m);
            var actual = 1.5;
            Assert.AreEqual(expected, actual);
        }
    }
}

