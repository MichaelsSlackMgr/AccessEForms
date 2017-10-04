using Xamarin.Forms;
using Acs.Mobile.ESig.ViewModels;

namespace Acs.Mobile.ESig.Views
{
    public class HomeView : ViewPage<AuthViewModel>
    {
        public HomeView()
        {
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Children =
                {
                    new Label
                    {
                        HorizontalOptions = LayoutOptions.CenterAndExpand,
                        Text = $"User is authenticated {ViewModel.IsAuth.ToString()}"
                    }
                }
            };
        }
    }
}