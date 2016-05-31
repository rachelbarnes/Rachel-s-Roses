using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roses
{
    class MeasurementCalculation
    {
        public void IngredientMeasurementCalculator(string filename)
        {
            var convert = new IngredientConversion(); 
            var recipe = new List<string>();
            recipe = convert.ConvertToTablespoons(filename); 
            //because the return type for ConvertToTablespoons is void, having it equal a list doens't work... need to change the return type to be able to use this functionality. 
        }
    }
}
