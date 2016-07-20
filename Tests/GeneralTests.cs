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
        [Test] 
        public void CalculateDecimalOfOneThird()
        {
            var fractionToDecimal = new GeneralFunctionality();
            var expected = .333m;
            var actual = fractionToDecimal.CalculateDecimalFromFraction("1/3");
            Assert.AreEqual(expected, actual); 
        }
        [Test]
        public void CalculateDecimalOfOneEighth()
        {
            var fractionToDecimal = new GeneralFunctionality();
            var expected = .125m;
            var actual = fractionToDecimal.CalculateDecimalFromFraction("1/8");
            Assert.AreEqual(expected, actual); 
        }
        [Test]
        public void TestSimpleDivision()
        {
            var divide = new GeneralFunctionality();
            var expected = .125m;
            var actual = divide.SimpleDivision(1, 8);
            Assert.AreEqual(expected, actual); 
        }
        [Test]
        public void TestDivisionFractions()
        {
            var divide = new GeneralFunctionality();
            var expected = .333m;
            var actual = divide.CalculateDecimalFromFraction("1/3");
            Assert.AreEqual(expected, actual); 
        }
        [Test]
        public void TestDivisionFractions2()
        {
            var divide = new GeneralFunctionality();
            var expected = .278m;
            var actual = divide.CalculateDecimalFromFraction("5/18");
            Assert.AreEqual(expected, actual); 
        }
        [Test]
        public void TestImproperFraction()
        {
            var fraction = new GeneralFunctionality();
            var expected = 2.5m;
            var actual = fraction.CalculateDecimalFromFraction("2 1/2");
            Assert.AreEqual(expected, actual); 
        }
        [Test]
        public void TestImproperFraction2()
        {
            var fraction = new GeneralFunctionality();
            var expected = 8.75m;
            var actual = fraction.CalculateDecimalFromFraction("8 3/4"); 
            Assert.AreEqual(expected, actual); 
        }
        [Test]
        public void TestImproperFraction3()
        {
            var fraction = new GeneralFunctionality();
            var expected = 2.75m;
            var actual = fraction.CalculateDecimalFromFraction("2 3/4");
            Assert.AreEqual(expected, actual); 
        }
    }
}

