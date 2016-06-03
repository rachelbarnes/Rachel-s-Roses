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
        [Test]
        public void TestDecimalPlaces()
        {
            var decimalized = new DecimalPlaces();
            var actual = decimalized.HundrethDecimalPlaces(125.65239845m);
            var expected = "125.65";
            Assert.AreEqual(expected, actual); 
        }
        [Test]
        public void DoubleRecipe()
        {
            var doubleRecipe = new AdjustIngredientMeasurement();
            var expected = doubleRecipe.AdjustIngredient(1, 2); 
            var actual = 2;
            Assert.AreEqual(expected, actual);          

        }
        [Test]
        public void HalfRecipe()
        {
            var halfRecipe = new AdjustIngredientMeasurement();
            var expected = halfRecipe.AdjustIngredient(3, .5m); 
            var actual = 1.5;
            Assert.AreEqual(expected, actual);  
        }
        [Test]
        public void QuarterRecipe()
        {
            var quarterRecipe = new AdjustIngredientMeasurement();
            var expected = quarterRecipe.AdjustIngredient(6, .25m);
            var actual = 1.5;
            Assert.AreEqual(expected, actual); 
        }
    }
}

