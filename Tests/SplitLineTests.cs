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
    }
}
