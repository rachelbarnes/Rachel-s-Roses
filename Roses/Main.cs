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
            var manage = new DataManager();
            manage.GetDeserializedDatabaseData(@"C:\Users\Rachel\Documents\Visual Studio 2015\Projects\RachelsRoses\Rachel-s-Roses\ItemResponseDatabase.txt"); 
            
            //var read = new Reader();
            //var ResponseDatabase = @"C:\Users\Rachel\Documents\Visual Studio 2015\Projects\RachelsRoses\Rachel-s-Roses\ItemResponseDatabase.txt"; 

            //var write = new Writer();
            //write.WriteLineToFile(ResponseDatabase);
            //Console.ReadLine(); 


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
