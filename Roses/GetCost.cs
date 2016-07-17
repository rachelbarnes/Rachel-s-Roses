using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;

namespace Roses
{
    public class GetIngredientData
    {
        public string IngredientName { get; set; }
        public decimal PricePerOunce { get; set; }
        public decimal SellingOunces { get; set; }

    }
    public class GetRequestWalmartAPI
    {
        public async void GetJSONResponse()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://api/walmartlabs.com");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            
            HttpResponseMessage response = await client.GetAsync("api/products/1");
            if (response.IsSuccessStatusCode)
                {
                    GetIngredientData ingredient = await response.Content.ReadAsStringAsync > GetIngredientPrices >; 
                }
        }


        
        public void GetRequest()
        {
            //this is obviously not working...

            string baseURI = 
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

            //Console.ReadLine();
        }
    }
}


