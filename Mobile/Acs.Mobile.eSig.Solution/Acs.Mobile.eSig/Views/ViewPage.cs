using Acs.Mobile.ESig.Configuration;

using Acs.Mobile.ESig.ViewModels.Base;
using Autofac;
using Xamarin.Forms;

namespace Acs.Mobile.ESig.Views
{
    public class ViewPage<T> : ContentPage where T : IViewModel
    {
        readonly T _viewModel;
        public T ViewModel { get { return _viewModel; } }

        public ViewPage()
        {
            using (var scope = AppContainer.Container.BeginLifetimeScope())
            {
                _viewModel = AppContainer.Container.Resolve<T>();
            }

            BindingContext = _viewModel;
        }
    }
}