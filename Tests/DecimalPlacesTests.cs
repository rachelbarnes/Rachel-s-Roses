using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace Roses
{
    [TestFixture]
    class DecimalPlacesTests
    {
        [Test]
        public void TestDecimalPlaces()
        {
            var decimalized = new RoundDecimalPlaces();
            var actual = decimalized.RoundDecimals(125.65239845m);
            var expected = 126m;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestDecimalPlaces2()
        {
            var round = new RoundDecimalPlaces();
            var actual = round.RoundDecimals(135.60m);
            var expected = 136m;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestingDecimalsWithOneSpace()
        {
            var round = new RoundDecimalPlaces();
            var actual = round.RoundDecimals(2.5m);
            var expected = 2m;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestingSingleDecimalPlacesAgainAgain()
        {
            var round = new RoundDecimalPlaces();
            var actual = round.RoundDecimals(135);
            var expected = 135m;
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void TestingInts()
        {
            var round = new RoundDecimalPlaces();
            var actual = round.RoundDecimals(4.000345m);
            var expected = 4.00m;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestingDecimalsUnder1()
        {
            var round = new RoundDecimalPlaces();
            var actual = round.RoundDecimals(0.5678m);
            var expected = 1m;
            Assert.AreEqual(expected, actual);
        }
    }
}
