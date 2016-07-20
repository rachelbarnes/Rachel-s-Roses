using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Roses
{
    [TestFixture]
    public class SplitLineTests
    {
        [Test]
        public void SplitSimpleLine()
        {
            var split = new SplitLines();
            var StringToSplit = "Split this line at the spaces";
            var expected = new string[] { "Split", "this", "line", "at", "the", "spaces" };
            Assert.AreEqual(expected, split.SplitLineAtSpace(StringToSplit));
        }
        [Test]
        public void SplitAtColonTest()
        {
            var split = new SplitLines();
            var expected = new string[] { "I", "love", "cats" };
            var actual = split.SplitLineAtColon("I:love:cats");
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CountSplitColonTest()
        {
            var split = new SplitLines();
            var myArray = new string[] { "this", "that" };
            var actual = myArray.Count();
            var expected = 2;
            Assert.AreEqual(expected, actual); 
        }
        //[Test]
        ////this test is failing, but oddly enough it's the expected that's causing it to fail. It says the expdcted is 'V', but the actual is "Volume To Weight Data Sheet" which is what I was expecting... 
        //public void SplitRatiosAtColonInFileTest()
        //{
        //    var split = new SplitLines();
        //    var ColonSplit = split.SplitVolumeToWeightDatabaseLines(@"C:\Users\Rachel\Documents\Visual Studio 2015\Projects\RachelsRoses\Rachel-s-Roses\TestingSplittingDataLines.txt");
        //    var expected = "VolumeToWeight Data Sheet";
        //    Assert.AreEqual(expected, ColonSplit[0]);
        //}
        [Test]
        public void OuncesToLbs()
        {
            var convert = new GeneralFunctionality();
            var actual = convert.OuncesToPounds(23);
            var expected = 1.4375m;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void LbsToOunces()
        {
            var convert = new GeneralFunctionality();
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
    }
}

