using System;
using Xamarin.Forms;

using Acs.Mobile.ESig.Models;
using Acs.Mobile.ESig.ViewModels;
using Acs.Mobile.ESig.Views.Base;

namespace Acs.Mobile.ESig.Views
{
    public class LoginView : ViewBase<LoginViewModel>
    {
        // View Controls
        Entry usernameEntry;
        Entry passwordEntry;
        Label messageLabel;

        public LoginView()
        {
            // NOTE: BindingContext is set in ViewBase
            InitViewModel();
        }

        private void InitViewModel()
        {
            var toolbarItem = new ToolbarItem("\uf013", null, () => { });

            toolbarItem.Clicked += OnSettingsButtonClicked;
            ToolbarItems.Add(toolbarItem);

            messageLabel = new Label();
            usernameEntry = new Entry { Placeholder = String.Empty }; // "username"	
            passwordEntry = new Entry
            {
                Placeholder = String.Empty, // "password",
                IsPassword = true
            };
            var loginButton = new Button
            {
                Text = "Login",
                BackgroundColor = Color.FromHex("#0D6595"),
                TextColor = Color.White,
                WidthRequest = 150
            };
            loginButton.Clicked += OnLoginButtonClicked;

            Title = "Access e-Signature";

            var loginButtonStackLayout = new StackLayout
            {
                Padding = 45,
                Children = { loginButton }
            };

            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.StartAndExpand,
                Padding = 20,
                Children =
                {
                    new Label { Text = "Username" }, usernameEntry,
                    new Label { Text = "Password" }, passwordEntry,
                    loginButtonStackLayout,
                    messageLabel
                }
            };
        }


        //
        // Navigation
        //
        async void OnSettingsButtonClicked(object sender, EventArgs e)
        {
            Navigation.InsertPageBefore(new SettingsView(), this);
            await Navigation.PopAsync().ConfigureAwait(false);
        }


        //
        // User Logging In
        // 
        async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            var user = new User
            {
                Username = usernameEntry.Text,
                Password = passwordEntry.Text
            };


            // Authenticate the user.
            var isValid = AreCredentialsCorrect(user);

            if (isValid)
            {
                App.IsUserLoggedIn = true;
                Navigation.InsertPageBefore(new MainView(), this);
                await Navigation.PopAsync().ConfigureAwait(false);
            }
            else
            {
                messageLabel.Text = "Login failed";
                passwordEntry.Text = string.Empty;
            }
        }

        private bool AreCredentialsCorrect(User user)
        {
            return ViewModel.AreCredentialsCorrect(user);
        }
    }
}