using System;
using System.Collections.Generic;
using System.Text;

namespace MDM_Automation_SpecFlow.TestData
{
    public class EnvironmentData
    {
        public string MDMUrl { get; private set; }
        public string MDMUrlAPI { get; private set; }

        public User MetadataUserObj = new User();
       
        public User ReadOnlyUserObj = new User();
        
        public User WriteUserObj = new User();
       
        public Dictionary<string, int> MDMPermissions = new Dictionary<string, int>();



        public EnvironmentData(string testEnvironment)
        {

            ReadOnlyUserObj.UserName = "ZOAppDevTest2-tst"; //read
            WriteUserObj.UserName = "ZOAppDevTest3-tst";// write
            MetadataUserObj.UserName = "ZOAppDevTest4-tst";// metadata
            MetadataUserObj.UserName = "maucasas";

            switch (testEnvironment.ToLower())
            {
                case "qa":
                    MDMUrlAPI = "https://qa-masterdata-api.publicismedia.com";
                    MDMUrl = "https://qa-masterdata.publicismedia.com/";
                    MDMPermissions.Add("ReadOnly", 0);
                    MDMPermissions.Add("Write", 1);
                    MDMPermissions.Add("Metadata", 2);
                    ReadOnlyUserObj.Password = Environment.GetEnvironmentVariable("QA_MDM_READ_USER_PASSWORD");
                    WriteUserObj.Password = Environment.GetEnvironmentVariable("QA_MDM_WRITE_USER_PASSWORD");
                    MetadataUserObj.Password = Environment.GetEnvironmentVariable("QA_MDM_METADATA_USER_PASSWORD");
                    break;
                case "pp":
                    MDMUrlAPI = "https://qa-masterdata-api.publicismedia.com";
                    MDMUrl = "http://masterdata.publicismedia.com/";
                    MDMPermissions.Add("ReadOnly", 0);
                    MDMPermissions.Add("Write", 1);
                    MDMPermissions.Add("Metadata", 2);
                    ReadOnlyUserObj.Password = Environment.GetEnvironmentVariable("PP_MDM_READ_USER_PASSWORD");
                    WriteUserObj.Password = Environment.GetEnvironmentVariable("PP_MDM_WRITE_USER_PASSWORD");
                    MetadataUserObj.Password = Environment.GetEnvironmentVariable("PP_MDM_METADATA_USER_PASSWORD");
                    break;
                case "dev":
                    MDMUrlAPI = "https://dev-masterdata.cloud.vivaki.com:8001";
                    MDMUrl = "https://dev-masterdata.cloud.vivaki.com/";
                    MDMPermissions.Add("ReadOnly", 0);
                    MDMPermissions.Add("Write", 1);
                    MDMPermissions.Add("Metadata", 2);
                    ReadOnlyUserObj.Password = Environment.GetEnvironmentVariable("DEV_MDM_READ_USER_PASSWORD");
                    WriteUserObj.Password = Environment.GetEnvironmentVariable("DEV_MDM_WRITE_USER_PASSWORD");
                    MetadataUserObj.Password = Environment.GetEnvironmentVariable("DEV_MDM_METADATA_USER_PASSWORD");
                    break;
            }
        }
    }
}
