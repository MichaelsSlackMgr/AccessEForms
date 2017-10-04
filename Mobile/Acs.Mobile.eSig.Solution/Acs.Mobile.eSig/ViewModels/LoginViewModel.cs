
using Acs.Common.Services.AuthServices;
using Acs.Mobile.ESig.ViewModels.Base;
using Acs.Common.Domain.Models;

namespace Acs.Mobile.ESig.ViewModels
{
    // TODO: Async - Ensure services are both Async and sync. Add Async methods


    // TODO:  VM should NOT have callbacks that are event handlers for controls on the view:
    // Instead, commands should be exposed from the VM to the View:
    // https://developer.xamarin.com/guides/xamarin-forms/xaml/xaml-basics/data_bindings_to_mvvm/

    // https://app.pluralsight.com/player?course=mobile-application-xamarin-forms-visual-studio-2017&author=jesse-liberty&name=mobile-application-xamarin-forms-visual-studio-2017-m4&clip=5&mode=live


    public class LoginViewModel : ViewModelBase, IViewModel
    {
        private IESigAuthService _authService;

        public LoginViewModel() { }


        public LoginViewModel(IESigAuthService authService)
        {
            // TODO, get user and pass in User type to the auth Service for authenticaiton.
            _authService = authService;
        }

        public bool IsAuth { get; set; }

        public string UserName { get; set; }


        public string Password
        {
            get; set; // Implement both get & Setting and add RaisePropertyChanged(); ToString setter.

        }

        public string SelectedDomain { get; set; }


        //public async void OnLoginButtonClicked(object sender, EventArgs e)
        //{

        public bool AreCredentialsCorrect(Mobile.ESig.User user)
        {
            user.SelectedDomain = "accessefm";

            var isValid = ValidateUser(user);
            if ( ! isValid ) { return false; }


            Common.Domain.Models.User domainUser = ConvertUserToDomain(user);

            IsAuth = _authService.ValidateLogin(domainUser);
            return IsAuth;
        }


        private bool ValidateUser(Mobile.ESig.User user)
        {
            if (null == user) { return false; }
            if ( string.IsNullOrEmpty(user.Username)) { return false; }
            if (string.IsNullOrEmpty(user.Password)) { return false; }
            if (string.IsNullOrEmpty(user.SelectedDomain)) { return false; }

            return true;
        }

        private Acs.Common.Domain.Models.User ConvertUserToDomain(Mobile.ESig.User user)
        {
            Common.Domain.Models.User domainUser = new Common.Domain.Models.User(
                user.Username,
                user.Password,
                user.SelectedDomain
                );

            return domainUser;
        }
    }
}