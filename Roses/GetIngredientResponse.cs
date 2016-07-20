using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace Roses
{
    [DataContract]
    public class SearchResponse
    {
        [DataMember(Name = "items")]
        public List<ItemResponse> Items { get; set; }
    }

    [DataContract]
    public class ItemResponse
    {
        [DataMember(Name = "salePrice")]
        public decimal SalePrice { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "itemId")]
        public int ItemId { get; set; }
    }

    //need to rewrite this! Need to understand this!
    /*
      needed componenets: 
      HttpWebRequest
      HttpWebResponse
      DataContracts
      Search Request
      Search Response
    */
    public class GetIngredientResponse
    {
        public string GetItemResponseAndFormatIntoString(string IngredientName, string IngredientSellingSize)
        {
            var format = new Writer(); 
            var write = new Writer(); 
            //var ResponseDatabaseFile = @"C:\Users\Rachel\Documents\Visual Studio 2015\Projects\RachelsRoses\Rachel-s-Roses\ItemResponseDatabase.txt"; 
            var items = MakeRequest<SearchResponse>(buildSearchRequest(IngredientName)).Items;
            var certainSize = items.Where(item => item.Name.ToLower().Contains(IngredientSellingSize));
            var firstItem = items.First();
            var response = format.FormatString(firstItem);
            return response; 
            //write.WriteLineToFile(ResponseDatabaseFile, firstItem);
        }
   

        public static void PrintItem(ItemResponse response, int divisorPricePerOunce)
        {
            Console.WriteLine("ITEM ID: " + response.ItemId);
            Console.WriteLine("NAME: " + response.Name);
            Console.WriteLine("PRICE: " + response.SalePrice);
            Console.WriteLine("PRICE/OZ: " + response.SalePrice / divisorPricePerOunce);
        }

        public static Func<string, string> buildSearchRequest = IngredientName => String.Format("http://api.walmartlabs.com/v1/search?query={0}&format=json&apiKey={1}", IngredientName, WalmartApiLogKey.Key);

        public static Func<string, string> buildItemIDRequest = productID => String.Format("http://api.walmartlabs.com/v1/items/{0}?apiKey={1}&format=json", productID, WalmartApiLogKey.Key);

        public static T MakeRequest<T>(string requestUrl)
        {
            try
            {
                HttpWebRequest request = WebRequest.Create(requestUrl) as HttpWebRequest;
                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                        throw new Exception(String.Format("Server error (HTTP {0}: {1}).", response.StatusCode, response.StatusDescription));
                    DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(T));
                    return (T)jsonSerializer.ReadObject(response.GetResponseStream());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return default(T);
            }
        }
    }
}


///*the casting with the generic type:
//        casting it into the method signature allows it to be the return type. you have to cast it for hte jsonSerializer above, which also casts it for the return type to match the return type in the signature. 
//        That's what's happening wit hthe MakeRequest<ItemResponse> = casting it to the ItemResponse type
//*/

/* MakeRequest: 
        the WebRequest class makes a request to a URI, which is passed a parameter of the requestUrl that is placed as the parameter for MakeRequest, this is the HttpWebRequest (i assume a HttpWebRequest and Response need to be identified for a Rest call)
        the response is an instance of the HttpWebResponse class,. It calls a method, GetResponse which is the HttpWebResponse
        using this response, if the status code returns anything other than a 200, throw a new exception with the error and its explanation
        The DataContractJsonSerializer serializes the data to json, then deserializes them into objects. The typeof(T) is casting the type of object, aka the data structure which is defined by an object. It's cast into the type specified.
        If the request and response don't work, then we get an exception. 

 */

/* FindAndPrint
 reading thru the code: 
 items is equal to the value of the response from MakeRequest, which will return T (MakeRequest: try making a web request and return  a web response. If the web response is good (comes back with a 200), then serialize the data into json and deserialize it into the object specified, which is one of the data constructs that's defined below with either the SearchResponse, or the ItemResponse).
 The MakeRequest's parameter is the return of hte buildSearchRequest method. 
 */

/* Finds a list of items from the object SearchResponse defined below. 
   items is assigned to the value of the return from MakeRequets, with the type SearchResponse. SearchResponse is a struct of data that returns a list of items with the type of ItemResponse, which has the salePrice, name and itemID. The MakeRequest method takes a parameter of a string. The parameter is filled by the return of buildSearchRequest, which takes the passed parameter of FindItems' name. 
           the datacontract of SearchRequest has a List<ItemResponses> (salePrice, name, itemID). It is calling the field from the SearchResponse that is received. 
                    it is returning a list based off of the MakeRequest<T>(uri). 
   specifySize looks at items, a list of returned items, and returns a new list of Items that contains a specific text, in this case, a specific size (such as 10 lb). 
   It then prints the data of the first response that it's given.

*/
