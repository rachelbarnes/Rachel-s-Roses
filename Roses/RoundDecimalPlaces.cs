using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roses
{
    public class RoundDecimalPlaces
    {
        public string RoundToHundrethDecimalPlace(decimal number)
        {
            var numberString = number.ToString();
            var outputDecimal = String.Format("{0:0.00}", number);
            var outputDecimalChars = outputDecimal.ToCharArray();
            var lastPlace = outputDecimalChars[outputDecimal.Length - 1];
            var secondtoLastPlace = outputDecimalChars[outputDecimal.Length - 2];  
            if ((lastPlace == '0') && (secondtoLastPlace == '0'))
            {
                outputDecimal = String.Format("{0}", number); 
            }
            return outputDecimal; 
        }
    }
}
