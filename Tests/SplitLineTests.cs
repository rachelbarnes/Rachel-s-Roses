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
            Assert.AreEqual(expected, split.SplitLineAtSpaces(StringToSplit)); 
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
        //this test is failing, but oddly enough it's the expected that's causing it to fail. It says the expdcted is 'V', but the actual is "Volume To Weight Data Sheet" which is what I was expecting... 
        public void SplitRatiosAtColonInFileTest()
        {
            var split = new SplitLines();
            var ColonSplit = split.SplitVolumeToWeightDatabaseLines(@"C:\Users\Rachel\Documents\Visual Studio 2015\Projects\RachelsRoses\Rachel-s-Roses\TestingSplittingDataLines.txt");
            var expected = "VolumeToWeight Data Sheet";
            Assert.AreEqual(expected, ColonSplit[0]); 
        }
        }
    }

