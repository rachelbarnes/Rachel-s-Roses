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
        public Func<decimal, decimal, decimal> SimpleDivision = (a, b) => a / b; 


        public decimal CalculateDecimalFromFraction(string fraction)
        {
            var split = new SplitLines();
            var SplitFractionAtSlash = split.SplitLineAtSpecifiedCharacter(fraction, '/');
            var numerator = Convert.ToDecimal(SplitFractionAtSlash[0]);
            var denominator = Convert.ToDecimal(SplitFractionAtSlash[1]);
            var calculatedDecimal = numerator / denominator;
            if (calculatedDecimal.ToString().Count() > 3)
            {
                return Decimal.Round((numerator / denominator), 3);
            }
            else
                return calculatedDecimal; 
        }

    }
}

