using System;
using System.Collections.Generic;
using System.Text;

namespace CRFR_Automation_SpecFlow.TestData
{
    public class EnvironmentData
    {
        public string CreativeUrl { get; private set; }
        public string TaxonomyUrl { get; private set; }
        public string CampaignUrl { get; private set; }

        public User ClientUserObj = new User();
       
        public User AdminUserObj = new User();

        public Dictionary<string, int> CrRoles = new Dictionary<string, int>();



        public EnvironmentData(string testEnvironment)
        {

            ClientUserObj.UserName = "ZOAppDevTest4-tst";
            //AdminUserObj.UserName = "ZOAppDevTest1-tst";
            AdminUserObj.UserName = "maucasas";
            switch (testEnvironment.ToLower())
            {
                case "qa":
                    TaxonomyUrl = "https://qa-taxonomy.publicismedia.com/";
                    //API_URL = "https://qa-admin-api.publicismedia.com/";
                    CampaignUrl = "https://qa-campaign.publicismedia.com/";
                    CreativeUrl = "https://qa-creativeframework.publicismedia.com/";
                    CrRoles.Add("Regular User", 190);
                    CrRoles.Add("Global Admin", 191);
                    ClientUserObj.Password = Environment.GetEnvironmentVariable("QA_CLIENT_PASSWORD");
                    AdminUserObj.Password = Environment.GetEnvironmentVariable("QA_GA_PASSWORD");
                    break;
                case "pp":
                    TaxonomyUrl = "https://preprod-taxonomy.publicismedia.com/";
                    //API_URL = "https://preprod-admin-api.publicismedia.com/";
                    CampaignUrl = "https://preprod-campaign.publicismedia.com/";
                    CreativeUrl = "http://preprod-creativeframework.publicismedia.com/";
                    CrRoles.Add("Regular User", 0);
                    CrRoles.Add("Global Admin", 0);
                    ClientUserObj.Password = Environment.GetEnvironmentVariable("PP_CLIENT_PASSWORD");
                    AdminUserObj.Password = Environment.GetEnvironmentVariable("PP_GA_PASSWORD");
                    break;
                case "dev":
                    TaxonomyUrl = "https://dev-taxonomy.cloud.vivaki.com/";
                    //API_URL = "https://dev-admin-api.cloud.vivaki.com/";
                    CampaignUrl = "https://dev-campaign.cloud.vivaki.com";
                    CreativeUrl = "https://dev-creativeframework.cloud.vivaki.com/";
                    CrRoles.Add("Regular User", 0);
                    CrRoles.Add("Global Admin", 0);
                    ClientUserObj.Password = Environment.GetEnvironmentVariable("DEV_CLIENT_PASSWORD");
                    AdminUserObj.Password = Environment.GetEnvironmentVariable("DEV_GA_PASSWORD");
                    break;
            }
        }
    }
}
