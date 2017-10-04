
using Xamarin.Forms;
using Acs.Mobile.ESig.Views;
using Acs.Mobile.ESig.Configuration;


namespace Acs.Mobile.ESig
{
    public partial class App : Application
    {
        public static bool IsUserLoggedIn { get; set; }


        public App(AppSetup appSetup)
        {
            // TODO: Dispose of AppSetup

            AppContainer.Container = appSetup.CreateContainer();

            if (!IsUserLoggedIn)
            {
                MainPage = new NavigationPage(new LoginView())
                {
                    // TODO: refactor colors out to style resources in shared.
                    // Just as planned
                    BarBackgroundColor = Color.FromHex("#3072a7"),
                    BarTextColor = Color.White
                };
            }
            else
            {
                MainPage = new NavigationPage(new MainView());
            }

            // TODO -- Uncomment this

            //// TODO: should we call init component here?
            //InitializeComponent();

            //AppContainer.Container = appSetup.CreateContainer();
            //MainPage = new NavigationPage(new HomeView());
        }

        //public App()
        //{

        //    AppContainer.Container = setup.CreateContainer();

        //    if (!IsUserLoggedIn)
        //    {
        //        MainPage = new NavigationPage(new LoginView())
        //        {
        //            // TODO: Move temporary colors to the .NET Standard library for 
        //            // styles. Need to move the project to this solutions as well.
        //            BarBackgroundColor = Color.FromHex("#3072a7"),
        //            BarTextColor = Color.White // Color.LightBlue
        //        };
        //    }
        //    else
        //    {
        //        MainPage = new NavigationPage(new Acs.Mobile.ESig.Views.MainView());
        //    }

        //    //InitializeComponent();
        //    //MainPage = new Acs.Mobile.ESig.MainPage();
        //}

        protected override void OnStart() { }

        protected override void OnSleep() { }

        protected override void OnResume() { }
    }
}