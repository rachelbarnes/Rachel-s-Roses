using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roses
{
    [TestFixture]
    class ConversionTests
    {
        [Test]
        public void ConvertCToT()
        {
            var convert = new ConvertToTablespoons();
            var actual = 16;
            Assert.AreEqual(convert.CupsToTablespoons(1), actual);
        }
        [Test]
        public void TestForCups()
        {
            var convert = new ConvertToTablespoons();
            var actual = 32;
            Assert.AreEqual(convert.CupsToTablespoons(2), actual);
        }
        [Test]

        public void ConvertCtoT2()
        {
            var convert = new ConvertToTablespoons();
            var actual = 8;
            Assert.AreEqual(convert.CupsToTablespoons(.5m), actual);
        }
        [Test]
        public void ConverttToT()
        {
            var convert = new ConvertToTablespoons();
            var actual = 1;
            Assert.AreEqual(convert.TeaspoonsToTablespoons(3), actual);
        }
    
    }
}
