using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Roses
{
    [TestFixture]
    public class VolumeToWeightLogicTests
    {
        [Test]
        public void OuncesToLbs()
        {
            var convert = new VolumeToWeightLogic();
            var actual = convert.OuncesToPounds(23);
            var expected = 1.4375m;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void LbsToOunces()
        {
            var convert = new VolumeToWeightLogic();
            var actual = convert.PoundsToOunces(5.5m);
            var expected = 88m;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void SplitLinesAtColon()
        {
            var Split = new SplitLines();
            var actual = Split.SplitLineAtColon("this:that");
            var SplitArray = new string[] { "this", "that" };
            var expected = SplitArray;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ConcatStringsWithColon()
        {
            var vol2weight = new VolumeToWeightLogic();
            var array = new string[] { };
            var expected = "Something" + " : " + 4m;
            var actual = vol2weight.ConcatRatioArray("Something", 4m.ToString());
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ConvertTestOuncesToCups()
        {
            var vol2weight = new VolumeToWeightLogic();
            var filename = @"C:\Users\Rachel\Documents\Visual Studio 2015\Projects\RachelsRoses\Rachel-s-Roses\TestingConversionFromCupsToOunces.txt";
            var actual = vol2weight.ConvertReadMeasuredOuncesToCups("flour", 25m, filename);
            var expected = "flour : 5 cups";
            Assert.AreEqual(expected, actual); 
        }
        [Test]
        public void ConvertTestCupsToOunces()
        {
            var vol2weight = new VolumeToWeightLogic(); 
            var filename = @"C:\Users\Rachel\Documents\Visual Studio 2015\Projects\RachelsRoses\Rachel-s-Roses\TestingConversionFromCupsToOunces.txt";
            var actual = vol2weight.ConvertReadMeasuredCupsToOunces("flour", 3.5m, filename);
            var expected = "flour : 17.5 ounces";
            Assert.AreEqual(expected, actual); 
        }
    }
}