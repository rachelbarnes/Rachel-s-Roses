using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Diagnostics;
using System.Net;
using System.IO;
using System.Xml;
using System.Text;
using System.Threading.Tasks;

namespace Roses
{
    /*   Application RachelsRoses
   Key:   vuartdaj5f2seuegajem8zrf
   Status:   active
   Created:   9 minutes ago

   Key Rate Limits
   5	Calls per second
   5,000	Calls per day*/

    class GetDatafromOnlineDatabase
    {
        public void LoginCredentials()
        {
            var service = "";
            var token = GetSessionToken(user, password);
            if (string.IsNullOrEmpty(token))
                {
                Debug.WriteLine("Login Failed. Check your username and password.");
            }
            else
            {
                Debug.WriteLine("Login Successful.");
            }
        }
        //i got GetSessionToken from online: https://documentation.commvault.com/commvault/v10/article?p=features/rest_api/rest_api_getting_started_csharp.htm
        private string GetSessionToken(string userName, string password)
        {
            string token = string.Empty;
            string loginService = service + "Login";
            byte[] pwd = System.Text.Encoding.UTF8.GetBytes(password);
            String encodedPassword = Convert.ToBase64String(pwd, 0, pwd.Length, Base64FormattingOptions.None);
            string loginReq = string.Format("<DM2ContentIndexing_CheckCredentialReq mode=\"Webconsole\" username=\"{0}\" password=\"{1}\" />", userName, encodedPassword);

            HttpWebResponse resp = SendRequest(loginService, "POST", null, loginReq);
            //Check response code and check if the response has an attribute "token" set
            if (resp.StatusCode == HttpStatusCode.OK)
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(resp.GetResponseStream());
                token = xmlDoc.SelectSingleNode("/DM2ContentIndexing_CheckCredentialResp/@token").Value;
            }
            else
            {
                Debug.WriteLine(string.Format("Login Failed. Status Code: {0}, Status Description: {1}", resp.StatusCode, resp.StatusDescription));
            }
            return token;
        }
    }
}

