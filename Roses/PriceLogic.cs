using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roses
{
    public class PriceLogic
    {
        Reader ReadDatabase = new Reader();
        public Func<decimal, decimal, decimal> PricePerPound = (price, weightInLbs) => Decimal.Round((price / weightInLbs), 3);
        public Func<decimal, decimal, decimal> PricePerOunce = (price, weightInOz) => Decimal.Round((price / weightInOz), 3); 
        public Func<decimal, decimal, decimal> PricePerOunceFromPound = (price, weightInLbs) => Decimal.Round(price / (weightInLbs / 16), 3);


        //public static Func<string, string, decimal, decimal, decimal> DeterminePriceForStandardMeasuredIngredient
        //    = (name, sizeBoughtInPounds, ouncesPerStandard, price) => (ouncesPerStandard / (Convert.ToDecimal(sizeBoughtInPounds) * 16)) * price;

        ///*
        // To do next:
        //    get price per ounce
        //        will have to know if item is sold in pounds/gallons/ounces, and do logic to determine price per ounce
        //    multiply price per ounce by how many ounces of an ingredient i used

        //*/
        //public decimal ConvertToOunces(string ProductName)
        //{
        //    var convertToOunces = new GeneralFunctionality(); 
        //    if ((ProductName.ToLower()).Contains("lb") || (ProductName.ToLower().Contains("pound")))
        //       {

        //        }        
        //    "oz"
        //        "gallons"
        //        "pint"
        //        "egg"

        //public void DetermineIfNameHasLbs(string Ingredient)
        //{
        //    //Pillsbury Flour 10 lb
        //}






        //public static decimal PricePerOunceUsed(string Ingredient, string MeasuredCups, string filename)
        //{
        //    var CalculateOunces = new VolumeToWeightLogic();
        //    var response = new ItemResponse();
        //    var priceForItem = response.SalePrice;
        //    var standardOunceForIngredient = CalculateOunces.ReadOuncesForIngredient(Ingredient, filename);
        //    var measuredOunces = CalculateOunces.GetAmountOfOuncesUsed(Ingredient, MeasuredCups, filename);
        //}





        //print response database and work off that
        //get price for 1 cup of ingredient
        //determine percent of standard based on how many cups (just multiply the ounces by the measured cups)
        public  decimal DeterminePriceForOuncesUsed(string Ingredient, string MeasuredCups, string filename)
        {

            //this is just a super long way of saying when I use 2 1/2 c of flour, i use 2.5x the standard amount... 
            var GetOunces = new VolumeToWeightLogic(); 
            var response = new ItemResponse();
            var price = response.SalePrice;
            var standardOuncesForIngredient = GetOunces.ReadOuncesForIngredient(Ingredient, filename);
            var MeasuredOunces = GetOunces.GetAmountOfOuncesUsed(Ingredient, MeasuredCups, filename);
            var Percentage = MeasuredOunces / standardOuncesForIngredient;
            return Percentage; 
        } 
        
        
         

        //make the request, get the price,
        //public decimal DeterminePriceForSpecifiedIngredient(string IngredientName, decimal AmountofIngredientsUsedInCups, string SizeBoughtInPounds, string filename)
        //{
        //    var ConvertFromCupsToOunces = new VolumeToWeightLogic(); 
        //   var ConvertedCupsUsedToOunces = ConvertFromCupsToOunces.ConvertReadMeasuredCupsToOunces(IngredientName, AmountofIngredientsUsedInCups, filename);
        //    var getresponse = new GetIngredientResponse();
        //    var GetPrice = GetIngredientResponse.MakeRequest<ItemResponse>(GetIngredientResponse.buildItemIDRequest(IngredientName));
        //    var ouncesForStandardIngredientMeasurement = GetOunceForStandardIngredientMeasurement(IngredientName, filename);


        //    var percentageOuncesUsedFromStandardOunces = 
                
        //        AmountofIngredientsUsedInCups / ouncesForStandardIngredientMeasurement; 
        //    return Decimal.Round((DeterminePriceForStandardMeasuredIngredient(IngredientName, SizeBoughtInPounds, ouncesForStandardIngredientMeasurement, GetPrice.SalePrice) * percentageOuncesUsedFromStandardOunces), 3); 
        //}
    
        






        //public decimal PriceForUsedIngredients(string IngredientName, decimal MeasuredCupsUsed, string sizeOfIngredientBoughtInLbs, string filename) //size refers to the size of the bag, ie a 25lb bag sugar, 10lb bag flour)
        //{
        //    var determinePrice = new PriceLogic();
        //    var IngredientData = new ItemResponse();
        //    var volumeToWeightConversion = new VolumeToWeightLogic();
        //    var IngredientResponse = new GetIngredientResponse(); 
        //    var ouncesPerCup = GetOunceForStandardIngredientMeasurement(IngredientName, filename);
        //    var price = 3m; //IngredientData.SalePrice;
        //    //i don't like that this is manually entered and automatically entered...
        //    var weightInOunces = Convert.ToDecimal(sizeOfIngredientBoughtInLbs) * 16;

        //    var OuncesUsed = MeasuredCupsUsed * ouncesPerCup;
        //    var PercentageOfIngredientUsedFromBought = OuncesUsed / weightInOunces;
        //    var PriceForUsedIngredients = PercentageOfIngredientUsedFromBought * price;
        //    return PriceForUsedIngredients; 
        //    //i have these ounces, so i need to 

        //    //what do i need to do in the end: 
        //    //multiply the price per ounce by the number of ounces in the amount of cups I sed
        //}
    }
}
