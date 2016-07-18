
//        static void Main(string[] args)
//        {
//            FindAndPrintItems("flour", "10 lb", 160); //develop a mthod that determines the divisor for you based on the data that i have in my database!!   
//        }
//        /* MakeRequest: 
//                the WebRequest class makes a request to a URI, which is passed a parameter of the requestUrl that is placed as the parameter for MakeRequest, this is the HttpWebRequest (i assume a HttpWebRequest and Response need to be identified for a Rest call)
//                the response is an instance of the HttpWebResponse class,. It calls a method, GetResponse which is the HttpWebResponse
//                using this response, if the status code returns anything other than a 200, throw a new exception with the error and its explanation
//                The DataContractJsonSerializer serializes the data to json, then deserializes them into objects. The typeof(T) is casting the type of object, aka the data structure which is defined by an object. It's cast into the type specified.
//                If the request and response don't work, then we get an exception. 

//         */
//        public static T MakeRequest<T>(string requestUrl)
//        {
//            try
//            {
//                HttpWebRequest request = WebRequest.Create(requestUrl) as HttpWebRequest;
//                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
//                {
//                    if (response.StatusCode != HttpStatusCode.OK)
//                    {
//                        throw new Exception(String.Format("Server error (HTTP {0}: {1}.", response.StatusCode, response.StatusDescription));
//                    }
//                    DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(T));
//                    return (T)jsonSerializer.ReadObject(response.GetResponseStream());
//                }
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine(e.Message);
//                return default(T);
//            }
//        }

//        /* Finds a list of items from the object SearchResponse defined below. 
//           items is assigned to the value of the return from MakeRequets, with the type SearchResponse. SearchResponse is a struct of data that returns a list of items with the type of ItemResponse, which has the salePrice, name and itemID. The MakeRequest method takes a parameter of a string. The parameter is filled by the return of buildSearchRequest, which takes the passed parameter of FindItems' name. 
//                   the datacontract of SearchRequest has a List<ItemResponses> (salePrice, name, itemID). It is calling the field from the SearchResponse that is received. 
//                            it is returning a list based off of the MakeRequest<T>(uri). 
//           specifySize looks at items, a list of returned items, and returns a new list of Items that contains a specific text, in this case, a specific size (such as 10 lb). 
//           It then prints the data of the first response that it's given.

//        */
//        public static void FindAndPrintItems (string name, string size, int divisorForPricePerOunce)
//        {
//            var items = MakeRequest<SearchResponse>(BuildSearchRequest(name)).Items; 
//            var specifySize = items.Where(item => item.Name.ToLower().Contains(size));
//            PrintItemData(specifySize.First(), divisorForPricePerOunce); 
//        }

//        /* Prints the specifed text. It prints 4 values, each stemming from a field of ItemResponse.         
//        */
//        public static void PrintItemData(ItemResponse response, int divisorForPricePerOunce)
//        {
//            Console.WriteLine("ITEM ID: {0}", response.ItemID);
//            Console.WriteLine("NAME: {0}", response.Name); 
//            Console.WriteLine("PRICE: {0}", response.SalePrice); 
//            Console.WriteLine("PRICE/OUNCE: {0}", response.SalePrice/divisorForPricePerOunce); 
//        }



//        [DataContract]
//        public class SearchResponse
//        {
//            [DataMember(Name = "items")]
//            public List<ItemResponse> Items { get; set; }
//        }

//        [DataContract] 
//        public class ItemResponse
//        {
//            [DataMember(Name = "salePrice")]
//            public decimal SalePrice { get; set; }

//            [DataMember(Name = "name")]
//            public string Name { get; set; }

//            [DataMember(Name = "itemId")]
//            public int ItemID { get; set; }
//        }
//    }
//}