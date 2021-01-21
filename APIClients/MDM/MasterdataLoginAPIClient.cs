using MDM_Automation_SpecFlow.BaseClasses;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace MDM_Automation_SpecFlow.APIClients.MDM
{
    public class MasterdataLoginAPIClient
    {
        public string BaseURL;
        public string Username;
        public string Password;

        private string Payload = @"{}";

        public MasterdataLoginAPIClient(string url, string username, string password)
        {
            BaseURL = url;
            Username = username;
            Password = password;
        }


        public IRestResponse UserAuth_GetBearerToken_POST()
        {
            string URI = "/auth/token   ?userName=" + Username + "&password=" + Password + "&applicationName=Taxonomy%20Config";
            APIClient APIClientObject = new APIClient();
            IRestResponse ResponseObject = APIClientObject.ExecutePOSTCallNoAuthentication(BaseURL, URI, Payload, Username, Password);
            return ResponseObject;
        }


        public string RetrieveBearerToken()
        {
            string bearerToken = null;
            IRestResponse Response = UserAuth_GetBearerToken_POST();
            int statusCode = (int)Response.StatusCode;
            dynamic DataObject;
            try
            {
                DataObject = JsonConvert.DeserializeObject(Response.Content);
            }
            catch
            {
                DataObject = Response.Content;
            }
            if (statusCode == 200)
            {
                bearerToken = DataObject["Token"];
            }
            return bearerToken;
        }
    }
}
