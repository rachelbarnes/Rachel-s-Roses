using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace Roses
{
    public class GetRequestWalmartAPI
    {
        public void GetRequest()
        {

            string baseURI = "http://api/walmartlabs.com";
            string responderURI = "/{ProductId}/{ProductName}/";//i assume this is the routing api url... api/{controller}/{id} 
            //string responderParameters...

            //open HttpWeb Request and pass the credentials to the Logon.ashx page
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(baseURI + "/Logon.ashx");
            request.Method = "GET"; //i dont know what this is that it's a string... 
            byte[] byteArray = Encoding.UTF8.GetBytes("{'username': '**','passowrd':'**'}");
            request.ContentLength = byteArray.Length;
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();

            //read the HttpWeb Response
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string Response = reader.ReadToEnd();
            response.Close();

            HttpWebRequest ApiResponder = (HttpWebRequest)WebRequest.Create(baseURI + responderURI);
            //ApiResponder.ContentType = 
            //...https://www.aais.com/Help/75/c_api_call_example.htm











            //for what I'm doing right now, I do not think I need to make a web proxy object right now. 


            //WebRequest GetWalmartURI = WebRequest.Create(URI);
            //Stream objectStream = GetWalmartURI.GetResponse().GetResponseStream();
            //StreamReader objectReader = new StreamReader(objectStream); 

            //string Line = "";
            //int i = 0; 
            //while (Line != null)
            //{
            //    i++;
            //    Line = objectReader.ReadLine(); 
            //    if (Line != null)
            //    {
            //        Console.WriteLine("{0}:{1}",i, Line);
            //    }


            //i was using this and copying it from online...if we are considering the condition of the line !being null, why do we have an if here giving another condition in the while statement saying that if the line is null to write int i and the line? 
            Console.ReadLine();
        }
    }
}


