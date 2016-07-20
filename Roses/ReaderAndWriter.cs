using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roses
{
    public class Reader
    {
        public void OpenFile(string filename)
        {
            try
            {
                if (File.Exists(filename) == true)
                    File.Open(filename, FileMode.Open);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e);
                Console.ReadLine();
            }
        }
        public List<string> ReadRecipe(string filename)
        {
            string lineOfText = "";
            var TextLines = new List<string>();
            using (StreamReader ReadMyFile = new StreamReader(filename))
            {
                while ((lineOfText = ReadMyFile.ReadLine()) != null)
                {
                    if (lineOfText.Contains("Instruction"))
                    {
                        break;
                    }
                    TextLines.Add(lineOfText);
                }
            }
            return TextLines;
        }

        public List<string> ReadDatabase(string filename)
        {
            string CurrentLine = "";
            var CompiledDatabase = new List<string>();
            using (StreamReader ReadMyFile = new StreamReader(filename))
            {
                while ((CurrentLine = ReadMyFile.ReadLine()) != null)
                {
                    if (CurrentLine.Contains(':'))
                    {
                        CompiledDatabase.Add(CurrentLine);
                    }
                }
            }
            return CompiledDatabase;
        }
    }

    public class Writer
    {
        public Func<ItemResponse, string> FormatString = response => String.Format("{0}: ITEM PRICE: ${1}: ITEM ID: {2}", response.Name, response.SalePrice, response.ItemId);

        public void WriteLineToFile(string ResponseDatabase)//, ItemResponse response)
        {
            var ListOfResponses = ListOfItemResponseRequests();
            using (StreamWriter MyDatabase = new StreamWriter(ResponseDatabase))
            {
                if (!File.Exists(ResponseDatabase))
                {
                    var CreatedFile = File.Create(ResponseDatabase);
                    MyDatabase.WriteLine(ListOfResponses);
                }
                else if (File.Exists(ResponseDatabase))
                {
                    foreach (var formattedResponse in ListOfResponses)
                    {

                        if (!ResponseDatabase.Contains(formattedResponse))
                        {
                            MyDatabase.WriteLine(formattedResponse);
                        }
                    }
                }
            }
        }

        public List<string> ListOfItemResponseRequests()
        {
            var read = new Reader();
            var split = new SplitLines();
            var GetItemResponseData = new GetIngredientResponse();
            var response = new ItemResponse();
            var ListOfResponses = new List<string>();
            ListOfResponses.Add(GetItemResponseData.GetItemResponseAndFormatIntoString("flour", "10 lb"));
            ListOfResponses.Add(GetItemResponseData.GetItemResponseAndFormatIntoString("whole wheat flour", "5 lb"));
            ListOfResponses.Add(GetItemResponseData.GetItemResponseAndFormatIntoString("bread flour", "5 lb"));
            ListOfResponses.Add(GetItemResponseData.GetItemResponseAndFormatIntoString("Pillsbury Softasilk", "32 oz"));
            ListOfResponses.Add(GetItemResponseData.GetItemResponseAndFormatIntoString("pastry flour", "5 lb"));
            ListOfResponses.Add(GetItemResponseData.GetItemResponseAndFormatIntoString("coarse grind cornmeal", "24 oz"));
            ListOfResponses.Add(GetItemResponseData.GetItemResponseAndFormatIntoString("granulated sugar", "4 lb"));
            ListOfResponses.Add(GetItemResponseData.GetItemResponseAndFormatIntoString("brown sugar", "2 lb"));
            ListOfResponses.Add(GetItemResponseData.GetItemResponseAndFormatIntoString("powdered sugar", "2 lb"));
            ListOfResponses.Add(GetItemResponseData.GetItemResponseAndFormatIntoString("milk powder", "64 oz"));
            ListOfResponses.Add(GetItemResponseData.GetItemResponseAndFormatIntoString("cocoa powder", "16 oz"));
            ListOfResponses.Add(GetItemResponseData.GetItemResponseAndFormatIntoString("baking soda", "4 lb"));
            ListOfResponses.Add(GetItemResponseData.GetItemResponseAndFormatIntoString("baking powder", "10 oz"));
            ListOfResponses.Add(GetItemResponseData.GetItemResponseAndFormatIntoString("salt", "26 oz"));
            ListOfResponses.Add(GetItemResponseData.GetItemResponseAndFormatIntoString("cinnamon", "8.75 oz"));
            ListOfResponses.Add(GetItemResponseData.GetItemResponseAndFormatIntoString("red star: active dry yeast", "4 oz"));
            ListOfResponses.Add(GetItemResponseData.GetItemResponseAndFormatIntoString("vegetable oil", "10 lb"));
            //ListOfResponses.Add(GetItemResponseData.GetItemResponsesAndFormatIntoString("milk", "10 lb")); 
            //ListOfResponses.Add(GetItemResponseData.GetItemResponsesAndFormatIntoString("eggs", "10 lb")); 
            //ListOfResponses.Add(GetItemResponseData.GetItemResponseAndFormatIntoString("butter", "10 lb"));
            ListOfResponses.Add(GetItemResponseData.GetItemResponseAndFormatIntoString("coconut flakes", "14 oz"));
            ListOfResponses.Add(GetItemResponseData.GetItemResponseAndFormatIntoString("shortening", "48 oz"));
            ListOfResponses.Add(GetItemResponseData.GetItemResponseAndFormatIntoString("vanilla extract", "8 fl oz"));
            ListOfResponses.Add(GetItemResponseData.GetItemResponseAndFormatIntoString("peppermint extract", "2 oz"));
            //ListOfResponses.Add(//GetItemResponseData.GetItemResponseAndFormatIntoString("buttermListOfResponses.Add(ilk", "10 lb"); 
            //ListOfResponses.Add(//GetItemResponseData.GetItemResponseAndFormatIntoString("cream cheese", "10 lb"); 
            //ListOfResponses.Add(//GetItemResponseData.GetItemResponseAndFormatIntoString("sour cream", "10 lb"); 
            ListOfResponses.Add(GetItemResponseData.GetItemResponseAndFormatIntoString("honey", "32 oz"));
            //ListOfResponses.Add(//GetItemResponseData.GetItemResponseAndFormatIntoString("vanilla greek yogurt", "10 lb"); 
            ListOfResponses.Add(GetItemResponseData.GetItemResponseAndFormatIntoString("carnation sweetened condensed milk", "14 oz"));
            ListOfResponses.Add(GetItemResponseData.GetItemResponseAndFormatIntoString("evaporated milk", "12 lb"));
            //ListOfResponses.Add(//GetItemResponseData.GetItemResponseAndFormatIntoString("heavy whipping cream", "10 lb"); 
            //ListOfResponses.Add(//GetItemResponseData.GetItemResponseAndFormatIntoString("half and half", "10 lb"); 
            ListOfResponses.Add(GetItemResponseData.GetItemResponseAndFormatIntoString("raisins", "20 oz"));
            ListOfResponses.Add(GetItemResponseData.GetItemResponseAndFormatIntoString("ocean spray craisins original dried cranberries", "24 oz"));
            ListOfResponses.Add(GetItemResponseData.GetItemResponseAndFormatIntoString("old fashioned oats", "42 oz"));
            ListOfResponses.Add(GetItemResponseData.GetItemResponseAndFormatIntoString("semi-sweet chocolate chips", "24 oz"));
            ListOfResponses.Add(GetItemResponseData.GetItemResponseAndFormatIntoString("semi-sweet chocolate mini", "12 oz"));
            ListOfResponses.Add(GetItemResponseData.GetItemResponseAndFormatIntoString("milk chocolate chips", "23 oz"));
            ListOfResponses.Add(GetItemResponseData.GetItemResponseAndFormatIntoString("white chocolate chips", "24 oz"));
            ListOfResponses.Add(GetItemResponseData.GetItemResponseAndFormatIntoString("bittersweet chocolate baking chips", "10 oz"));
            //ListOfResponses.Add(//GetItemResponseData.GetItemResponseAndFormatIntoString("marshmallows", "10 lb"); 
            ListOfResponses.Add(GetItemResponseData.GetItemResponseAndFormatIntoString("chopped pecans", "24 oz"));
            ListOfResponses.Add(GetItemResponseData.GetItemResponseAndFormatIntoString("chopped walnuts", "8 oz"));
            return ListOfResponses;
        }
    }
}


//if (!File.Exists(ResponseDatabase))
//{
//    var CreatedFile = File.Create(ResponseDatabase);
//    MyDatabase.WriteLine(FormatString(response));
//    //MyDatabase.Close();
//}
//else if (File.Exists(ResponseDatabase))
//{
//    if (!ResponseDatabase.Contains(response.Name))
//    {
//        MyDatabase.WriteLine(FormatString(response));
//    }
//MyDatabase.();
//}

