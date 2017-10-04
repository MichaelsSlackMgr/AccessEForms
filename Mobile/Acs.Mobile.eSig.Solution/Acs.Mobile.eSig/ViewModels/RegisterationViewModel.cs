using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acs.Mobile.ESig.ViewModels.Base;

namespace Acs.Mobile.ESig.ViewModels
{
    public class RegisterationViewModel : IViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string EmailAddress { get; set; }

    }
}