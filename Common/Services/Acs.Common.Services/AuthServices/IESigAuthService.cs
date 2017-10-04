using System;
using System.Collections.Generic;
using System.Text;
using Acs.Common.Domain.Models;

// TODO Create Models or Entities namespace and classes.
// using Acs.Common.Models;

namespace Acs.Common.Services.AuthServices
{
    public interface IESigAuthService
    {
        bool AuthenticateUser(Domain.Models.User user);
        

        bool ValidateLogin(Domain.Models.User user);

        //bool CheckUserIsAuthenticated();
    }
}