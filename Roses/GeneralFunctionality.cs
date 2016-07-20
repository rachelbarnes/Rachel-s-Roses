using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roses
{
    public class GeneralFunctionality
    {
        public Func<int, int> sqaure = x => x * x;
        public Func<double, double, int> percent = (x, y) => (int)((x / y) * 100);
        public Func<decimal, decimal> CupsToTablespoons = cups => cups * 16;
        public Func<decimal, decimal> TeaspoonsToTablespoons = teaspoons => teaspoons / 3;
        public Func<decimal, decimal> TablespoonsToCup = tablespoons => tablespoons / 16;
        public Func<decimal, decimal> TablespoonsToTeaspoons = tablespoons => tablespoons * 3;
        public Func<decimal, decimal> PoundsToOunces = Pounds => Pounds * 16;
        public Func<decimal, decimal> OuncesToPounds = Ounces => Ounces / 16;
        public Func<decimal, decimal> OuncesToGrams = Ounces => Ounces * 28;
        public Func<decimal, decimal> GramsToOunces = Grams => Grams / 28;
        public Func<decimal, decimal> GramsToPounds = Grams => (Grams / 28) / 16;
        //GallonstoOz

        public Func<decimal, decimal, decimal> SimpleDivision = (a, b) => a / b;

        public bool IsStringNumericValue(string IsNumber)
        {
            int output;
            bool isStringNumeric = int.TryParse(IsNumber, out output);
            if (isStringNumeric == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public decimal CalculateProperFraction(string fraction)
        {
            var split = new SplitLines();
            var SplitFractionAtSlash = split.SplitLineAtSpecifiedCharacter(fraction, '/');
            var NumeratorString = SplitFractionAtSlash[0];
            var DenominatorString = SplitFractionAtSlash[1];
            var CalculatedDecimal = 0m;
            if ((IsStringNumericValue(NumeratorString) && IsStringNumericValue(DenominatorString)) == true)
            {
                var Numerator = Convert.ToDecimal(NumeratorString);
                var Denominator = Convert.ToDecimal(DenominatorString);
                CalculatedDecimal = Numerator / Denominator;
            }
            return CalculatedDecimal;
        }
        public decimal CalculateImproperFraction(string fraction)
        {
            var split = new SplitLines();
            var SplitWholeNumberInFraction = split.SplitLineAtSpace(fraction);
            var SplitFractionAtSlash = split.SplitLineAtSpecifiedCharacter(SplitWholeNumberInFraction[1], '/'); 
            var CalculatedDecimal = 0m;
            var WholeNumberString = SplitWholeNumberInFraction[0];
            var NumeratorString = SplitFractionAtSlash[0];
            var DenominatorString =SplitFractionAtSlash[1];
            if ((IsStringNumericValue(WholeNumberString) && IsStringNumericValue(NumeratorString) && IsStringNumericValue(DenominatorString)) == true)
            {
                var WholeNumber = Convert.ToDecimal(WholeNumberString);
                var Numerator = Convert.ToDecimal(NumeratorString);
                var Denominator = Convert.ToDecimal(DenominatorString);
                var ProperFractionNumerator = (WholeNumber * Denominator) + Numerator;
                CalculatedDecimal = (decimal)ProperFractionNumerator / (decimal)Denominator;
            }
            return CalculatedDecimal;
        }

        public decimal CalculateDecimalFromFraction(string fraction)
        {
            var CalculatedDecimal = 0m;
            if (fraction.Contains(' '))
            {
                CalculatedDecimal = CalculateImproperFraction(fraction);//what happens if the fraction is not convertible to numbers? 
            }
            if (!fraction.Contains(' '))
            {
                CalculatedDecimal = CalculateProperFraction(fraction);
            }
            return CalculatedDecimal;
        }
    }
}

