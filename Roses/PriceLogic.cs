﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roses
{
    public class PriceLogic
    {
        public Func<decimal, decimal, decimal> PricePerPound = (price, weightInLbs) => Decimal.Round((price / weightInLbs), 3);
        public Func<decimal, decimal, decimal> PricePerOunce = (price, weightInOz) => Decimal.Round((price / weightInOz), 3);
        public Func<decimal, decimal, decimal> PricePerOunceFromPound = (price, weightInLbs) => Decimal.Round(price / (weightInLbs / 16), 3);


        public List<string[]> GetAllIngredientNamesAndPricesFromResponseDatabase(string ResponseDatabaseFilename)
        {
            var ReadDatabase = new Reader();
            var split = new SplitLines();
            var read = new Reader();
            var ListOfFormattedItemResponses = read.ReadDatabase(ResponseDatabaseFilename);
            var SplitResponse = new string[] { };
            var ListOfNamePriceArrays = new List<string[]>();
            for (int i = 0; i < ListOfFormattedItemResponses.Count(); i++)
            {
                var NamePriceArray = new string[2] { "", "" };
                var SplitItemResponse = split.SplitLineAtColon(ListOfFormattedItemResponses[i]);
                var Name = SplitItemResponse[0];
                var Price = SplitItemResponse[2];
                NamePriceArray[0] = Name;
                NamePriceArray[1] = Price;
                ListOfNamePriceArrays.Add(NamePriceArray);
            }
            return ListOfNamePriceArrays;
        }

        public decimal GetPriceForIndividualIngredient(string Ingredient, string ResponseDatabaseFilename)
        {
            var split = new SplitLines();
            var read = new Reader();
            var numericStringToDecimal = new GeneralFunctionality();
            var ListOfFormattedItemResponses = read.ReadDatabase(ResponseDatabaseFilename);
            var ResponseDatabase = GetAllIngredientNamesAndPricesFromResponseDatabase(ResponseDatabaseFilename);
            var CurrentArray = new string[] { };
            var IngredientPriceDecimal = 0m;
            for (int i = 0; i < ResponseDatabase.Count(); i++)
            {
                var CurrentUnalteredLine = ListOfFormattedItemResponses[i];
                CurrentArray = ResponseDatabase[i];
                var CurrentIngredientName = "";
                var CurrentIngredientPrice = "";
                if (CurrentUnalteredLine.ToLower().Contains(Ingredient.ToLower()) || CurrentArray.ToString().ToLower().Contains(Ingredient.ToLower()))
                {
                    if (CurrentUnalteredLine.Count(x => x == ':') > 4)
                    {
                        CurrentArray = split.ExtraColonInString(CurrentUnalteredLine.ToString());
                        CurrentIngredientName = CurrentArray[0];
                        CurrentIngredientPrice = CurrentArray[1];
                        CurrentArray[0] = CurrentIngredientName;
                        CurrentArray[1] = CurrentIngredientPrice;
                    }
                    if (CurrentUnalteredLine.Count(x => x == ':') <= 4)
                    {
                        CurrentArray = ResponseDatabase[i];
                        CurrentIngredientName = CurrentArray[0];
                        CurrentIngredientPrice = CurrentArray[1];
                    }
                    var splitPriceArray = split.SplitLineAtSpecifiedCharacter(CurrentIngredientPrice, '$');
                    var DecimalPrice = splitPriceArray[1];
                    if (numericStringToDecimal.IsStringNumericValue(DecimalPrice) == true)
                    {
                        IngredientPriceDecimal = Convert.ToDecimal(DecimalPrice);
                    }
                }
            }
            return Decimal.Round(IngredientPriceDecimal, 3);
        }

        public decimal GetPriceForOneOunceOfIngredient(string Ingredient, string VolumeToWeightRatioDatabase, string ResponseDatabaseFilename)
        {
            var read = new Reader();
            var split = new SplitLines();
            var GetOunces = new VolumeToWeightLogic();
            var convertToNmber = new GeneralFunctionality();
            var IngredientVolumeToWeightRatios = read.ReadDatabase(VolumeToWeightRatioDatabase);
            var UnalteredResponseDatabase = read.ReadDatabase(ResponseDatabaseFilename);
            var IngredientPrice = 0m;
            //var ParsedNumberString = 0m;
            var CalculatedOunces = 0m;
            //var OuncesForStandardMeasuredIngredient = 0m;
            var PricePerOunce = 0m;
            for (int i = 0; i < UnalteredResponseDatabase.Count(); i++)
            {
                if (UnalteredResponseDatabase[i].Contains(Ingredient))
                {
                    IngredientPrice = GetPriceForIndividualIngredient(Ingredient, ResponseDatabaseFilename);
                    for (int j = 0; j < IngredientVolumeToWeightRatios.Count(); j++)
                    {
                        if (IngredientVolumeToWeightRatios[j].Contains(Ingredient))
                        {
                            if (UnalteredResponseDatabase[i].ToLower().Contains(("oz")))
                            {
                                var FindNumbers = split.SplitLineAtSpace(UnalteredResponseDatabase[i]);
                                foreach (var array in FindNumbers)
                                {
                                    decimal output;
                                    if (convertToNmber.IsStringNumericValue(array) == true)
                                    {
                                        Decimal.TryParse(array, out output);
                                        CalculatedOunces = output;
                                    }
                                }
                            }
                            //.Cgallons, lbs || pounds, oz, //)
                            //OuncesForStandardMeasuredIngredient = GetOunces.ReadOuncesForIngredient(Ingredient, VolumeToWeightRatioDatabase);
                        }//how many cups are in the bag of whatever is sold, then do the math with the ounces
                    }
                }
            }
            PricePerOunce = IngredientPrice / CalculatedOunces;
            return PricePerOunce;
        }




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

        //get price for 1 cup of ingredient
        //determine percent of standard based on how many cups (just multiply the ounces by the measured cups)
        public decimal DeterminePriceForOuncesUsed(string Ingredient, string MeasuredCups, string filename)
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
    }
}
