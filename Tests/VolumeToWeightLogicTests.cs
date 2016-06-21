﻿using System;
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
        public void FlourCupsToOunces()
        {
            var convert = new VolumeToWeightLogic();
            var actual = convert.Flour(3);
            var expected = 13.5m;
            Assert.AreEqual(expected, actual); 
        }
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
        public void CakeFlourConversionTests()
        {
            var convert = new VolumeToWeightLogic();
            var actual = convert.CakeFlour(6m);
            var expected = 24m;
            Assert.AreEqual(expected, actual); 
        }
        [Test]
        public void TestingCupsToOuncesConversionViaDictionary() {
            var AnalyzeVolumeAndWeight = new VolumeToWeightLogic();
            //analyze how many ounces are in 2 cups ap flour
            var actual = AnalyzeVolumeAndWeight.CupsToOunces("flour", 2);
            var expected = "10 ounces";
            Assert.AreEqual(expected, actual); 
        }

        [Test]
        public void TestingSomeDictionaryStuff()
        {
            var AnalyzeVolumeAndWeight = new VolumeToWeightLogic();
            var actual = AnalyzeVolumeAndWeight.GetDictionaryValue();
            var expected = 4.5m;
            Assert.AreEqual(expected, actual);
        }
    }
}
