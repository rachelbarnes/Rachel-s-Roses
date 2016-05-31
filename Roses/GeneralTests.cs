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
    }
}
