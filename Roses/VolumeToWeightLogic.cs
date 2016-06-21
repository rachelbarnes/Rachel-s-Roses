using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roses
{
    public class VolumeToWeightLogic
    {
        public Func<decimal, decimal> PoundsToOunces = Pounds => Pounds * 16;

        public Func<decimal, decimal> OuncesToPounds = Ounces => Ounces / 16;

        public Func<decimal, decimal> OuncesToGrams = Ounces => Ounces * 28;

        public Func<decimal, decimal> GramsToOunces = Grams => Grams / 28;

        public Func<decimal, decimal> GramsToPounds = Grams => (Grams / 28) / 16; 

        //This method is using the dictionary keys and values in the IngredientWeightToVolume Dictionary. The key is the ingredient, and the value is the ounces in one measuring cup of the ingredient
        //OuncesToCups takes the ounces that are provided and converts those ounces to cups for the particular ingredient
        //CupsToOunces takes the cups provided and converts those cups to ounces for the particular ingredient        

        public decimal GetDictionaryValue()
        {
            var Dictionary = new VolumeToWeightDictionary();
            return Dictionary.IngredientVolumeToWeightRatio["this key is not in my dictionary but you're going to tell me there's already a key named this anyway"]; 
        } 
        public string OuncesToCups(string Ingredient, int Ounces)
        {
            var CupsToOuncesRatio = new VolumeToWeightDictionary();
            var Value = CupsToOuncesRatio.IngredientVolumeToWeightRatio[Ingredient]; 
            if (CupsToOuncesRatio.IngredientVolumeToWeightRatio.ContainsKey(Ingredient))
            {
                return (Ounces / Value).ToString() + " cups"; 
            }
            else
            {
                return "Please try typing the ingredient again with no uppercase letters, the dictionary does not contain that specific ingredient.";
            }
        }
        public string CupsToOunces(string Ingredient, int Cups)
        {
            var CupsToOuncesRatio = new VolumeToWeightDictionary();
            var Value = CupsToOuncesRatio.IngredientVolumeToWeightRatio[Ingredient];
            try
            {
                return (Cups * Value).ToString() + " ounces"; 
            }
            catch (KeyNotFoundException)
            {
                return "Please try typing the ingredient again with no uppercase letters, the dictionary does not contain that specific ingredient.";             
            }
        }





        //this is the alternative to the dictionary... and this, while arguably logical, is not what I want to do. Have a method for each and every ingredient... no ma'am. 
        public decimal Flour(decimal MeasurementInCups)
        {
            var CupRatio = 1m;
            var OunceRatio = 4.5m;
            var NewMeasurementInOunces = (MeasurementInCups / CupRatio) * OunceRatio;
            return NewMeasurementInOunces; 
        }

        public decimal CakeFlour(decimal MeasurementInCups)
        {
            var CupRatio = 1m;
            var OunceRatio = 4m;
            var NewMeasurementInOunces = (MeasurementInCups / CupRatio) * OunceRatio;
            return NewMeasurementInOunces; 
        }
    }
}
