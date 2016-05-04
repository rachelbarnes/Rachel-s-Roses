using RachelsRosesPrototype;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RachelsRosesPrototype
{
    [TestFixture]
    class VolumeTests
    {
        [Test]
        public void Round8x2()
        {
            var vol = new RoundPanVolume();
            int diameter = 8;
            int height = 2;
            var volume = vol.CalcuateVolumeRoundPan(diameter, height);
            Assert.AreEqual(101, Convert.ToInt32(volume));
        }
        [Test]
        public void Round12x2()
        {
            var vol = new RoundPanVolume();
            var diameter = 12;
            int height = 2;
            var volume = vol.CalcuateVolumeRoundPan(diameter, height);
            Assert.AreEqual(226, Convert.ToInt32(volume));
        }
        [Test]
        public void Square8x2()
        {
            var vol = new SquarePanVolume();
            var length = 8;
            var depth = 2;
            var volume = vol.CalculateVolumeSquareBakingPan(length, depth);
            Assert.AreEqual(128, Math.Round((double)volume));
        }
        [Test]
        public void Sqaure6x3()
        {
            var vol = new SquarePanVolume();
            var length = 6;
            var depth = 3;
            var volume = vol.CalculateVolumeSquareBakingPan(length, depth);
            Assert.AreEqual(108, Math.Round((double)volume));
        }
        [Test]
        public void Rect13x9()
        {
            var vol = new RectangularPanVolume();
            var length = 13;
            var width = 9;
            var depth = 2;
            var volume = vol.CalculateVolumeRectangularPan(length, width, depth);
            Assert.AreEqual(234, volume);
        }
        [Test]
        public void Rect8x12()
        {
            var vol = new RectangularPanVolume();
            var length = 12;
            var width = 8;
            var depth = 2;
            var volume = vol.CalculateVolumeRectangularPan(length, width, depth);
            Assert.AreEqual(192, Math.Round((double)volume));
        }
        [Test]
        public void CentToIn()
        {
            var convert = new VolumeMethods();
            var cent = 25;
            var centtoin = convert.ConvertCentimetersToInches(cent);
            Assert.AreEqual(9.84d, Math.Round((double)centtoin));
        }
        [Test]
        public void InToCent()
        {
            var convert = new VolumeMethods();
            var inch = 12;
            var inchtocent = convert.ConvertCentimetersToInches(inch);
            Assert.AreEqual(30.48d, Math.Round((double)inchtocent));
        }
        [Test]
        public void Percent()
        {
            var percent = new CalculatePercent();
            var vol1 = 50;
            var vol2 = 100;
            Assert.AreEqual(50, Convert.ToInt32(percent.calculatePercent(vol1, vol2)));
        }
        [Test]
        public void Percent2()
        {
            var percent = new CalculatePercent();
            var vol1 = 12;
            var vol2 = 40;
            Assert.AreEqual(30, Convert.ToInt32(percent.calculatePercent(vol1, vol2)));
        }
        [Test]
        public void CheckToSeeIfAggregateWorks()
        {
            var aggregateVolumes = new Aggregate();
            var firstVol = 55;
            var secondVol = 80;
            var thirdVol = 90;
            var aggregate = aggregateVolumes.aggregate(firstVol, secondVol, thirdVol);
            Assert.AreEqual(225, aggregate); 
        }
        [Test]
        public void Aggregate2Tier()
        {
            var aggregate = new Aggregate();
            var volume = new VolumeMethods();
            var firstVol = volume.RoundPanVolume(10, 2);
            var secVol = volume.SquarePanVolume(7, 2);
            var aggregateVolumes = aggregate.aggregate(firstVol, secVol);
            Assert.AreEqual(255, aggregateVolumes); 
        }

    }
}
