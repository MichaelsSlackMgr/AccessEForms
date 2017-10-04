
using Autofac;

using Acs.Common.Services.AuthServices;
using Acs.Mobile.ESig.ViewModels;
using Acs.Mobile.ESig.ViewModels.Base;


namespace Acs.Mobile.ESig.Configuration
{
    public class AppSetup
    {
        public IContainer CreateContainer()
        {
            var containerBuilder = new ContainerBuilder();
            RegisterDependencies(containerBuilder);

            return containerBuilder.Build();
        }

        protected virtual void RegisterDependencies(ContainerBuilder containerBuilder)
        {
            // Register Services
            containerBuilder.RegisterType<ESigAuthService>().As<IESigAuthService>();


            // Register View Models
            // TODO: verify should be Single Instance
            containerBuilder.RegisterType<LoginViewModel>().SingleInstance().As<ViewModelBase>().As<LoginViewModel>();
        }
    }
}