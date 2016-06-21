using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roses
{
    public class VolumeToWeightLogic
    {
        public Func<decimal, decimal> PoundsToOunces = Pounds => Pounds * 16;

        public Func<decimal, decimal> OuncesToPounds = Ounces => Ounces / 16; 

        public decimal Flour(decimal MeasurementInCups)
        {
            var CupRatio = 1m;
            var OunceRatio = 4.5m;
            var NewMeasurementInOunces = (MeasurementInCups / CupRatio) * OunceRatio;
            return NewMeasurementInOunces; 
        }

        public decimal CakeFlour(decimal MeasurementInCups)
        {
            var CupRatio = 1m;
            var OunceRatio = 4m;
            var NewMeasurementInOunces = (MeasurementInCups / CupRatio) * OunceRatio;
            return NewMeasurementInOunces; 
        }
    }
}
