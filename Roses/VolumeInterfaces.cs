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
    public interface IInputMeasurements
    {
        string InputMessage(); 
    }
}
//i was going to do this for the percent calcular as well, however that would really only be helpful if there are multiple classes that can implement a get percent method and function. 
