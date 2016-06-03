using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roses
{
    class DecimalPlaces
    {
        public string HundrethDecimalPlaces(decimal number)
        {
            var numberString = number.ToString();
            var outputDecimal = String.Format("{0:0.00}", number);
            var outputDecimalChars = outputDecimal.ToCharArray(); 
            if  ((outputDecimalChars[outputDecimal.Length - 1] == '0') && (outputDecimalChars[outputDecimal.Length - 2]) == '0')
            {
                outputDecimal = String.Format("{0}", number); 
            }
            return outputDecimal; 
        }
    }
}
