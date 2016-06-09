using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roses
{
    public class ConvertIngredientMeasurementToTablespoons
    {
        public string ConvertIngredientWCupMeasurementToTablespoons(string MeasurementInCups)
        {
            var Round = new RoundDecimalPlaces();
            var ToTablespoons = new ConvertToTablespoons();
            var Split = new SplitLines();
            var CupsToTablespoonMeasurement = 0m;
            var RoundedTablespoonMeasurement = "";
            var IngredientLine = Split.SplitIngredientLineAtSpaces(MeasurementInCups);

            CupsToTablespoonMeasurement = ToTablespoons.CupsToTablespoons(Convert.ToDecimal(IngredientLine[0]));
            if (CupsToTablespoonMeasurement == 1)
            {
                RoundedTablespoonMeasurement = Round.RoundToHundrethDecimalPlace(CupsToTablespoonMeasurement) + " tablespoon";
            }
            else
            {
                RoundedTablespoonMeasurement = Round.RoundToHundrethDecimalPlace(CupsToTablespoonMeasurement) + " tablespoons";
            }
            return RoundedTablespoonMeasurement;
        }

        public string ConvertIngredientWTeaspoonsMeasurementToTablespoons(string MeasurementInTeaspoons)
        {
            var Round = new RoundDecimalPlaces();
            var ToTablespoons = new ConvertToTablespoons();
            var split = new SplitLines();
            var TeaspoonsToTablespoons = 0m;
            var RoundedTablespoonMeasurement = "";
            var IngredientLine = split.SplitIngredientLineAtSpaces(MeasurementInTeaspoons);

            TeaspoonsToTablespoons = ToTablespoons.TeaspoonsToTablespoons(Convert.ToDecimal(IngredientLine[0]));
            if (TeaspoonsToTablespoons == 1)
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
            var IngredientLine = split.SplitIngredientLineAtSpaces(Measurement);

            TablespoonsMeasurement = Convert.ToDecimal(IngredientLine[0]);
            if (TablespoonsMeasurement == 1)
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
