using System;
using Xamarin.Forms;

namespace Acs.Mobile.ESig.Views
{
    public class SettingsView : ContentPage
    {
        public SettingsView()
        {
            var toolbarItem = new ToolbarItem("\uf015", null, () => { });

            toolbarItem.Clicked += OnBackButtonClicked;
            ToolbarItems.Add(toolbarItem);

            errorMsgLabel = new Label();
            passportServerURLEntry = new Entry { Placeholder = String.Empty };
            domainNameEntry = new Entry { Placeholder = String.Empty };

            var saveButton = new Button
            {
                Text = "Save",
                BackgroundColor = Color.FromHex("#0D6595"),
                TextColor = Color.White,
                WidthRequest = 150
            };
            saveButton.Clicked += OnSaveButtonClicked;

            var saveButtonStackLayout = new StackLayout { Padding = 45, Children = { saveButton }};

            Title = "Settings";
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.StartAndExpand,
                Padding = 20,
                Children =
                {
                    new Label { Text = "Passport Server URL" },
                    passportServerURLEntry,
                    new Label { Text = "Domain Name" },
                    domainNameEntry,
                    saveButtonStackLayout,
                    errorMsgLabel
                }
            };
        }

        async void OnBackButtonClicked(object sender, EventArgs e)
        {
            App.IsUserLoggedIn = false;
            Navigation.InsertPageBefore(new LoginView(), this);
            await Navigation.PopAsync().ConfigureAwait(false);
        }

        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var settings = new Setting()
            {
                PassportServerURL = passportServerURLEntry.Text,
                DomainName = domainNameEntry.Text
            };

            // Sign up logic goes here

            var signUpSucceeded = AreDetailsValid(settings);
            if (signUpSucceeded)
            {
                App.IsUserLoggedIn = false;
                Navigation.InsertPageBefore(new LoginView(), this);
                await Navigation.PopAsync().ConfigureAwait(false);
            }
            else
            {
                errorMsgLabel.Text = "Settings incorrect";
            }
        }

        private bool AreDetailsValid(Setting settings)
        {
            return (!string.IsNullOrWhiteSpace(settings.PassportServerURL) &&
                !string.IsNullOrWhiteSpace(settings.DomainName));
        }


        private Entry passportServerURLEntry;
        private Entry domainNameEntry;
        private Label errorMsgLabel;
    }
}