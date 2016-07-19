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
        public Func<ItemResponse, string> FormatString = response => String.Format("{0}:{1}:{2}", response.Name, response.SalePrice, response.ItemId);

        public void WriteLineToFile(string ResponseDatabase, ItemResponse response)
        {
            var ReadResponseDatabase = new Reader();
            using (StreamWriter WriteToMyFile = new StreamWriter(ResponseDatabase))
            {
                if (File.Exists(ResponseDatabase))
                {
                    if (!ResponseDatabase.Contains(response.Name))
                    {
                        WriteToMyFile.WriteLine(FormatString(response));
                    }
                    WriteToMyFile.Close(); 
                }
                else
                {
                    var CreatedFile = File.Create(ResponseDatabase);
                    WriteToMyFile.WriteLine(FormatString(response));
                    WriteToMyFile.Close(); 
                }
            }
        }
    }
}
