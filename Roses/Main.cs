using System;
using System.IO; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roses
{
    public class Program
    {
        static void Main(string[] args)
        {
            var read = new Reader();
            var RatioDatabaseList = (read.ReadDatabase(@"C:\Users\Rachel\Documents\Visual Studio 2015\Projects\RachelsRoses\Rachel-s-Roses\VolumeToWeightIngredientData.txt"));
            var ResponseDatabase = @"C:\Users\Rachel\Documents\Visual Studio 2015\Projects\RachelsRoses\Rachel-s-Roses\ItemResponseDatabase.txt"; 
            foreach (var ratio in RatioDatabaseList)
            {
                Console.WriteLine(ratio); 
            }
            Console.WriteLine(RatioDatabaseList.Count());

            var write = new Writer();
            write.WriteLineToFile(ResponseDatabase);
            Console.ReadLine(); 




            //var WriteToDatabase = new Writer();
            //var TestResponse = new ItemResponse();
            //TestResponse.Name = "Whole Wheat Flour"; 
            //TestResponse.SalePrice = 4.24m; 
            //TestResponse.ItemId = 27; 
            //Console.WriteLine(WriteToDatabase.FormatString(TestResponse)); 
            //WriteToDatabase.WriteLineToFile(@"C:\Users\Rachel\Documents\Visual Studio 2015\Projects\RachelsRoses\Rachel-s-Roses\ResponseDatabase", TestResponse);
            //Console.ReadLine();

            //var vol2weight = new VolumeToWeightLogic();
            //var filename = @"C:\Users\Rachel\Documents\Visual Studio 2015\Projects\RachelsRoses\Rachel-s-Roses\VolumeToWeightIngredientData.txt"; 
            //Console.WriteLine(vol2weight.ConvertReadMeasuredCupsToOunces("flour", 6.125m, filename));
            //Console.ReadLine(); 
        }
    }
}
            //var GetIngredientData = new GetIngredientResponse();
            //try
            //{
            //    GetIngredientData.FindAndPrint("flour", "10 lb", 160);
            //    GetIngredientData.FindAndPrint("yeast", "4 oz", 4);
            //    Console.ReadLine();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //    Console.Read();
            //}
