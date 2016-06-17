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
        public void TestDecimalPlaces2()
        {
            var round = new RoundDecimalPlaces();
            var actual = round.RoundToHundrethDecimalPlace(135.60m);
            var expected = "135.6";
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestingDecimalsWithOneSpace()
        {
            var round = new RoundDecimalPlaces();
            var actual = round.RoundToHundrethDecimalPlace(2.5m);
            var expected = "2.5";
            Assert.AreEqual(expected, actual); 
        }
        [Test]
        public void TestSingleDecimalPlace()
        {
            var round = new RoundDecimalPlaces();
            var actual = round.RoundToHundrethDecimalPlace(5.06m);
            var expected = "5";
            Assert.AreEqual(expected, actual); 
        }
        [Test]
        public void TestSingleDecimalPlace2()
        {
            
            var round = new RoundDecimalPlaces();
            var actual = round.RoundToHundrethDecimalPlace(5.06m);
            var expected = "5";
            Assert.AreEqual(expected, actual); 
        }
        [Test]
        public void TestingSingleDecimalPlacesAgain()
        {
            var round = new RoundDecimalPlaces(); 
            var actual = round.RoundToHundrethDecimalPlace(145.04723432m);
            var expected = "145";
            Assert.AreEqual(expected, actual); 
        }
        [Test]
        public void TestingSingleDecimalPlacesAgainAgain()
        {
            var round = new RoundDecimalPlaces();
            var actual = round.RoundToHundrethDecimalPlace(135);
            var expected = "135";
            Assert.AreEqual(actual, expected); 
        }
        [Test]
        public void TestingMathRound()
        {
            var actual = Math.Round(4.56734m);
            var expected = 5;
            Assert.AreEqual(expected, actual); 
        }
        [Test]
        public void TestingInts()
        {
            var round = new RoundDecimalPlaces();
            var actual = round.RoundToHundrethDecimalPlace(4.000345m);
            var expected = "4";
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestingDecimalsUnder1()
        {
            var round = new RoundDecimalPlaces();
            var actual = round.RoundToHundrethDecimalPlace(0.5678m);
            var expected = ".57";
            Assert.AreEqual(expected, actual);
        }
         [Test]
        public void DoubleRecipe()
        {
            var doubleRecipe = new AdjustRecipe();
            var expected = doubleRecipe.AdjustRecipeTablespoonMeasurements("1", 2);
            var actual = 2;
            Assert.AreEqual(expected, actual);
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

