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

            if (intBeforeDecimalPoint == '0')
            {
                outputDecimal = String.Format("{0:.00}", number);
            }
            return outputDecimal;
        }

        public string _RoundDecimals(decimal number)
        {
            var numberString = number.ToString();
            var output = String.Format("{0:0.00}", numberString);
            var outputDecimalCharacterArray = output.ToCharArray();
            var IntBeforeDecimalPoint = outputDecimalCharacterArray[outputDecimalCharacterArray.Length - 4];
            var LastPlace = outputDecimalCharacterArray[outputDecimalCharacterArray.Length - 1];
            var SecondToLastPlace = outputDecimalCharacterArray[outputDecimalCharacterArray.Length - 2];

            if (IntBeforeDecimalPoint == '0')
            {
                output = String.Format("{0:.00}", numberString);
            }
            if (LastPlace == '0')
            {
                output = String.Format("{0:0.0}", numberString);
            }
            if (LastPlace == '0' && SecondToLastPlace == '0')
            {
                output = String.Format("{0:0}", numberString);
            }
            return output;
        }

        public string _RoundDecimalsAgain(decimal number)
        {
            var Output = String.Format("{0:0.00}", number.ToString());
            return Output;
        }

        //I've been trying to get the String.Format to work, which it did before, but doing what I did before didn't work. I must be missing something. Look at this again.
        /*
         I do really want to get this working... I can't have a cup measuremnet be 2/3 and it round up to 1. Rounding to the nearest integer is not an option that I can take unfortunatley. 

            I'm definitely still getting some errors here... For functionalities such as if the number is less than 1, have no number before the ., or if it's an int to be able to do Math.Round instead of Decimal.Round, etc. does not need to be there, but it would be nice. 
         */
        public decimal RoundDecimals(decimal number)
        {
            //var Output = Decimal.Round(number, 2); 
            //if (Output < 1)
            //{
            //    Output = Convert.ToDecimal(String.Format("{0:.00}", Output));  ; 
            //}
            //Output = Math.Round(number); 
            return Decimal.Round(number);
        }
    }
}