using System;
using System.Collections.Generic;
using System.Text;

namespace CRFR_Automation_SpecFlow.TestData
{
    public class User
    {

        public string UserID;
        public string UserName;
        public string UserEmail;
        public string FirstName;
        public string LastName;
        public bool? IsActive;
        public bool? IsLionLogin;
        //public dynamic UserAccess;
        //public int ResponseCode = 0;
        //public dynamic ResponseData = null;
        public string Password = null;
        public string TXBearerToken = null;
        //public List<UserAccess> ListUserAccess = new List<UserAccess>();

        public User(string username, string password)
        {
            UserName = username;
            Password = password;
        }
        public User()
        {
            UserID = null;
            UserName = null;
            UserEmail = null;
            FirstName = null;
            IsActive = null;
            UserEmail = null;
            IsActive = null;
            IsLionLogin = null;
            //UserAccess = null;
        }

    }
}
