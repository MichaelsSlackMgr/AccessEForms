using Xamarin.Forms;
using Autofac;
using Acs.Mobile.ESig.Configuration;
using Acs.Mobile.ESig.ViewModels.Base;

namespace Acs.Mobile.ESig.Views.Base
{
    public class ViewBase<T> : ContentPage where T : ViewModelBase
    {
        protected readonly T _viewModelToBindTo;

        public T ViewModel { get { return _viewModelToBindTo; }}

        public ViewBase()
        {
            using (var scope = AppContainer.Container.BeginLifetimeScope())
            {
                _viewModelToBindTo = AppContainer.Container.Resolve<T>();
            }
            BindingContext = _viewModelToBindTo;
        }

        // TODO: Remove dead code
        //ViewModelBase vm;
        //public ViewBase(ViewModelBase viewModelBase)
        //{
        //    vm = viewModelBase;

        //    //using (var scope = AppContainer.Container.BeginLifetimeScope())
        //    //{
        //    //    _viewModel = AppContainer.Container.Resolve<T>();
        //    //}

        //    BindingContext = vm;
        //}
    }
}