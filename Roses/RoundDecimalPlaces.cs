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
            var intBeforeDecimalPoint = outputDecimalChars[outputDecimalChars.Length - 4]; 
            var lastPlace = outputDecimalChars[outputDecimalChars.Length - 1];
            var secondtoLastPlace = outputDecimalChars[outputDecimalChars.Length - 2];

            //i need to rewrite this... 


            //if (lastPlace == '0')
            //{
            //    outputDecimal = String.Format("{0:0.0}", number); 
            //}
            if (intBeforeDecimalPoint == '0')
            {
                outputDecimal = String.Format("{0:.00}", number);
            }
            return outputDecimal; 
        }
    }
}