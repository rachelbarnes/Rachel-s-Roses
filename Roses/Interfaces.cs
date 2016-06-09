using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roses
{
    public interface IGetVolume
    {
        int GetVolume();
    }

    public interface IConvert
    {
        string ConvertMeasurementToTablespoons(string Measurement); 
    }
}
