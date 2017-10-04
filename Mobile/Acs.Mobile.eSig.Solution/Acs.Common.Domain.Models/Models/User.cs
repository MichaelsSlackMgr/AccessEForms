using System;
using System.Collections.Generic;
using System.Text;

namespace Acs.Common.Domain.Models
{
    public class User
    {
        public User( string userName, string password, bool isAuthenticated = false )
        {
            // TODO validate arguments in constructor.

            UserName = userName;
            Password = password;
            IsAuthenticated = isAuthenticated;
        }


        public User(string userName, string password, string selectedDomain, bool isAuthenticated = false)
        {
            // TODO validate arguments in constructor.

            UserName = userName;
            Password = password;
            SelectedDomain = selectedDomain;
            IsAuthenticated = isAuthenticated;
        }


        public int UserId { get; set; }


        public string UserName { get; set; }

        public string Password { get; set; }

        public string SelectedDomain { get; set; }


        public string FirstName { get; set; }

        public string LastName { get; set; }


        public string EmailAddress { get; set; }

        public bool IsAuthenticated { get; set; }
    }
}