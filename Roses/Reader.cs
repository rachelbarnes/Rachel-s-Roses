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
        //open the file
        //this wasn't working last time... look at it again. 
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
        //read the file
        public void ReadFile(string filename)
        {
            string lineOfText = "";
            var TextLines = new List<string>();
            var Text = "";
            using (StreamReader ReadMyFile = new StreamReader(filename))
            {
                while ((lineOfText = ReadMyFile.ReadLine()) != null)
                {
                    TextLines.Add(lineOfText);
                    Console.WriteLine(lineOfText);
                }
            }
        }
    }
}
