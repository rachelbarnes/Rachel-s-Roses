using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roses
{
    public class ConvertCandtToTablespoons
    {
        public string ConvertCupsToTablespoons(string MeasurementInCups)
        {
            var Round = new RoundDecimalPlaces();
            var ToTablespoons = new GeneralFunctionality();
            var Split = new SplitLines();
            string RoundedTablespoonMeasurement = "";
            string[] IngredientLine = Split.SplitLineAtSpaces(MeasurementInCups);
            //there's something about CupsToTablespoonMeasurement - this is where I am getting the error in the stack trace in all of my failing tests that use this method 
            decimal CupsToTablespoonMeasurement = ToTablespoons.CupsToTablespoons(Convert.ToDecimal(IngredientLine[0]));
            if (CupsToTablespoonMeasurement == 1m)
            {
                RoundedTablespoonMeasurement = CupsToTablespoonMeasurement + " tablespoon";
            }
            else
            {
                RoundedTablespoonMeasurement = Round.RoundToHundrethDecimalPlace(CupsToTablespoonMeasurement) + " tablespoons";
            }
            return RoundedTablespoonMeasurement;
        }

        public string ConvertTeaspoonsToTablespoons(string MeasurementInTeaspoons)
        {
            var Round = new RoundDecimalPlaces();
            var ToTablespoons = new GeneralFunctionality();
            var split = new SplitLines();
            var TeaspoonsToTablespoons = 0m;
            var RoundedTablespoonMeasurement = "";
            var IngredientLine = split.SplitLineAtSpaces(MeasurementInTeaspoons);

            TeaspoonsToTablespoons = ToTablespoons.TeaspoonsToTablespoons(Convert.ToDecimal(IngredientLine[0]));
            if (TeaspoonsToTablespoons == 1m)
            {
                RoundedTablespoonMeasurement = Round.RoundToHundrethDecimalPlace(TeaspoonsToTablespoons) + " tablespoon";
            }
            else
            {
                RoundedTablespoonMeasurement = Round.RoundToHundrethDecimalPlace(TeaspoonsToTablespoons) + " tablespoons"; 
            }
            return RoundedTablespoonMeasurement; 
        }

        public string RoundTablespoonMeasurement(string Measurement)
        {
            var Round = new RoundDecimalPlaces();
            var split = new SplitLines();
            var TablespoonsMeasurement = 0m;
            var RoundedTablespoonMeasurement = "";
            var IngredientLine = split.SplitLineAtSpaces(Measurement);

            TablespoonsMeasurement = Convert.ToDecimal(IngredientLine[0]);
            if (TablespoonsMeasurement == 1m)
            {
                RoundedTablespoonMeasurement = Round.RoundToHundrethDecimalPlace(TablespoonsMeasurement) + " tablespoon"; 
            }
            else
            {
                RoundedTablespoonMeasurement = Round.RoundToHundrethDecimalPlace(TablespoonsMeasurement) + " tablespoons"; 
            }
            return RoundedTablespoonMeasurement; 
        }
    }
}
