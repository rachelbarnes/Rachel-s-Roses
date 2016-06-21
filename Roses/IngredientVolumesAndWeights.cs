using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roses
{
    public class IngredientMeasurement
    {
        public string IngredientName { get; set; }
        public decimal IngredientVolume { get; set; }
        public decimal IngredientWeightInOunces { get; set; }

        public IngredientMeasurement(string _IngredientName, decimal _IngredientWeightOrOunces)
        {
            this.IngredientName = _IngredientName;
            this.IngredientWeightInOunces = _IngredientWeightOrOunces;
        }
        //public IngredientMeasurement(string _IngredientName, decimal _IngredientVolume) 
        //{
        //    this.IngredientName = _IngredientName;
        //    this.IngredientVolume = _IngredientVolume;
        //}
    }

    public class VolumeToWeight
    {
        public Func<decimal, decimal> PoundsToOunces = Pounds => Pounds * 16;

        public Func<decimal, decimal> OuncesToPounds = Ounces => Ounces / 16;

        public Func<decimal, decimal> OuncesToGrams = Ounces => Ounces * 28;

        public Func<decimal, decimal> GramsToOunces = Grams => Grams / 28;

        public Func<decimal, decimal> GramsToPounds = Grams => (Grams / 28) / 16;

        public string OuncesToCups(string ingredient, decimal ounces)
        {
            var Ingredient = new IngredientMeasurement(ingredient, ounces);
            var RatioDictionary = new VolumeToWeightDictionary();
            var value = RatioDictionary.IngredientVolumeToWeightRatio[ingredient]; 

            return (ounces / value).ToString() + " cups";
        }



        public string CupsToOunces(string ingredient, decimal cups)
        {
            var Ingredient = new IngredientMeasurement(ingredient, cups);
            var RatioDictionary = new VolumeToWeightDictionary();
            var value = RatioDictionary.IngredientVolumeToWeightRatio[ingredient];

            return (cups * value).ToString() + " ounces"; 
        }
    }
}
