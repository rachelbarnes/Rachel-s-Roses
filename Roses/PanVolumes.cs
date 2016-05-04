using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roses
{
    public class SqaureFN
    {
        public Func<int, int> sqaure = x => x * x;
    }
    public class Percent
    {
        public Func<double, double, int> percent = (x, y) => Convert.ToInt32((x / y) * 100);
        //need to have these be doubles or floats, otherwise you'll get an int of 2/10, which is 0 * 100, which is 0. 
    }
    public class RoundPan : IGetVolume
    {
        private int _diameter;
        private int _depth;
        public RoundPan(int diameter, int depth)
        {
            this._diameter = diameter;
            this._depth = depth;
        }
        int IGetVolume.GetVolume()
        {
            var square = new SqaureFN();
            return Convert.ToInt32(Math.PI * (square.sqaure(_diameter / 2)) * _depth);
        }
    }
    public class SquarePan : IGetVolume
    {
        private int _width;
        private int _depth;
        public SquarePan(int width, int depth)
        {
            this._width = width;
            this._depth = depth;
        }
        int IGetVolume.GetVolume()
        {
            return Convert.ToInt32(_width * _width * _depth);
        }
    }
    public class RectangularPan : IGetVolume
    {
        private int _width;
        private int _length;
        private int _depth;
        public RectangularPan(int width, int length, int depth)
        {
            this._width = width;
            this._length = length;
            this._depth = depth;
        }
        int IGetVolume.GetVolume()
        {
            return Convert.ToInt32(_width * _length * _depth);
        }
    }
    public class Aggregater 
    {
        public int GetAggregatedArea(List<IGetVolume> Pans)
        {
            var total = 0;
            return Pans.Aggregate(total, (accumulatingVolume, pan) => accumulatingVolume + pan.GetVolume());
        }
    }
}

