using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roses
{
    public class CombineArrays
    {
        public string CombineArray(string[] IngredientLine)
        {
            return string.Join(" ", IngredientLine, 1, (IngredientLine.Length - 1));
        }
        public string CombineArrayWithoutOriginalUnitofMeasurement(string[] IngredientLine)
        {
            var returnstring = "";
            if (IngredientLine.Count() >= 2)
            {
                returnstring = string.Join(" ", IngredientLine, 2, (IngredientLine.Length - 2));
            }
            else
            {
                returnstring = CombineArray(IngredientLine);  
            }
            return returnstring; 
        }

        public string CombineArrayWithStartingPoint(string[] IngredientLine, int StartingPoint)
        {
            return string.Join(" ", IngredientLine, StartingPoint, (IngredientLine.Length - StartingPoint));
        }
    }
}
