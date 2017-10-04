using System;
using Xamarin.Forms;


namespace Acs.Mobile.ESig.Views
{
	public class MainView : ContentPage
	{
		public MainView ()
		{

            // Search
			var toolbarItemSearch = new ToolbarItem("\uf002", null, () => { });

			//toolbarItemSearch.Clicked += OnSearchButtonClicked;
			ToolbarItems.Add(toolbarItemSearch);
			

            // Scan
            var toolbarItemScan = new ToolbarItem("\uf02a", null, () => { });

			//toolbarItemScan.Clicked += OnScanButtonClicked;
			ToolbarItems.Add(toolbarItemScan);

            // Add
			var toolbarItemAdd = new ToolbarItem("\uf055", null, () => { });

			//toolbarItemAdd.Clicked += OnAddButtonClicked;
			ToolbarItems.Add(toolbarItemAdd);

            // Process 
			var toolbarItemProcess = new ToolbarItem("\uf0a9", null, () => { });

			//toolbarItemProcess.Clicked += OnProcessButtonClicked;
			ToolbarItems.Add(toolbarItemProcess);

            // Reload
			var toolbarItemReload = new ToolbarItem("\uf021", null, () => { });

			//toolbarItemReload.Clicked += OnReloadButtonClicked;
			ToolbarItems.Add(toolbarItemReload);

            // Logout
			var toolbarItemLogout = new ToolbarItem {
				Text = "Logout"
			};

			toolbarItemLogout.Clicked += OnLogoutButtonClicked;
			ToolbarItems.Add (toolbarItemLogout);

			Content = new StackLayout { 
                Padding = 10,
				Children = {
					new Label {
						Text = "Patient"
					}
				}
			};
		}

		async void OnLogoutButtonClicked (object sender, EventArgs e)
		{
			App.IsUserLoggedIn = false;
			Navigation.InsertPageBefore (new LoginView (), this);
            await Navigation.PopAsync().ConfigureAwait(false);
        }
	}
}
