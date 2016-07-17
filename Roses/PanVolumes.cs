using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roses
{
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
            var square = new GeneralFunctionality();
            return (int)(Math.PI * (square.sqaure(_diameter / 2)) * _depth);
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
            return (int)(_width * _width * _depth);
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
            return (int)(_width * _length * _depth);
        }
    }
    public class Aggregater 
    {
        public int GetAggregatedArea(List<IGetVolume> Pans)
        {
            var total = 0;
            //the specified seed value, which is total here, is the starting point of for .Aggregate
            return Pans.Aggregate(total, (accumulatingVolume, pan) => accumulatingVolume + pan.GetVolume());
        }
    }
}