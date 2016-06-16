using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roses
{
    [TestFixture]
    class VolumeTests
    {
        [Test]
        public void RoundPanVolume()
        {
            var round = new RoundPan(8, 2);
            IGetVolume getVol = (IGetVolume)round;
            var actual = getVol.GetVolume();
            Assert.AreEqual(100, actual);
        }
        [Test]
        public void RoundPanVolume2()
        {
            var round = new RoundPan(12, 4);
            IGetVolume getVol = (IGetVolume)round;
            var actual = getVol.GetVolume();
            Assert.AreEqual(452, actual);
        }
        [Test]
        public void SqaurePanVolume()
        {
            var square = new SquarePan(8, 2);
            IGetVolume getVol = (IGetVolume)square;
            var actual = getVol.GetVolume();
            Assert.AreEqual(128, actual);
        }
        [Test]
        public void SquarePanVolume2()
        {
            var square = new SquarePan(6, 4);
            IGetVolume getVol = (IGetVolume)square;
            var actual = getVol.GetVolume();
            Assert.AreEqual(144, actual);
        }
        [Test]
        public void RectangularPanVolume()
        {
            var rect = new RectangularPan(9, 13, 2);
            IGetVolume getVol = (IGetVolume)rect;
            var actual = getVol.GetVolume();
            Assert.AreEqual(234, actual);
        }
        [Test]
        public void RectangularPanVolume2()
        {

            var rect = new RectangularPan(8, 11, 2);
            IGetVolume getVol = (IGetVolume)rect;
            var actual = getVol.GetVolume();
            Assert.AreEqual(176, actual);
        }
        [Test]
        public void Percent()
        {
            var percent = new Percent();
            var actual = percent.percent(20, 100); 
            Assert.AreEqual(20, actual);
        }
        [Test]
        public void Percent2()
        {
            var percent = new Percent();
            var actual = percent.percent(80, 50); 
            Assert.AreEqual(160, actual);
        }
        [Test]
        public void Aggregate()
        {
            var aggregate = new Aggregater();
            var cake = new List<IGetVolume>();
            var round = new RoundPan(6, 2);
            var square = new SquarePan(9, 2);
            var round2 = new RoundPan(12, 2);
            var square2 = new SquarePan(15, 2);
            cake.Add(round);
            cake.Add(square);
            cake.Add(round2);
            cake.Add(square2);
            var actual = aggregate.GetAggregatedArea(cake);
            Assert.AreEqual(894, actual);
            //i know there's a much better way to add items to a list... this is getting rather extensive for a test.
            //need to have the GetAggregatedArea public, but then i get the inconsistency error. 
        }
        //[Test]
        //public void ReadFile()
        //{
        //    var readFile = new Reader();
        //    var actual = "test"; 
        //    Assert.AreEqual()
        //}
    }
}
