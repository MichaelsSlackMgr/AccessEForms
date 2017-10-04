using System;
using System.Collections.Generic;
using System.Text;
using Acs.Common.Domain.Models;

namespace Acs.Common.Services.AuthServices
{
    public class ESigAuthService : IESigAuthService
    {

        string un = "u";
        string pw = "p";


        // REST service calls encapsulated for us
        // https://github.com/paulcbetts/refit


        private bool _isAuthenticated = false;
        //public bool IsAuthenticated
        //{
        //    get { return _isAuthenticated; }
        //    set => _isAuthenticated = value;
        //}

        public ESigAuthService() { }


        public bool ValidateLogin(Domain.Models.User user)
        {
            // Call service on server
            var passesAuth = (user.UserName.Substring(0, 1).ToLower() == un &&
                user.Password.Substring(0, 1).ToLower() == pw) ? true : false;

            return passesAuth;
        }

        public bool AuthenticateUser(Domain.Models.User user)
        {
            // TODO: Authenticate user via current 
            /*
                POST - Content-Type: application/x-www-form-urlencoded
                        URL:    https://passport-lab.accessefm.com
                        
                        /Account/ValidateLogin


                        Response Example
                        {
                            "success": true,
                            "returnValue": "",
                            "returnUrl": "/Home?id=3",
                            "pwdSetDate": "",
                            "subtractDate": ""
                        }
            */

            return _isAuthenticated = true;
        }

        public bool CheckUserIsAuthenticated()
        {
            return _isAuthenticated;

            /*
            API Call info
                    CheckUserIsAuthenticated method
                    Account / CheckUserIsAuthenticated
            */
        }
    }
}