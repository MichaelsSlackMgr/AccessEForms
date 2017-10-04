
using Autofac;
using Acs.Common.Services.AuthServices;
using Acs.Mobile.ESig.Configuration;

namespace Acs.Mobile.ESig.Droid
{
    public class Setup : AppSetup
    {
        /// <summary>Setup dependencies using DI.</summary>
        /// <param name="cb"></param>
        protected override void RegisterDependencies(ContainerBuilder cb)
        {
            base.RegisterDependencies(cb);

            cb.RegisterType<ESigAuthService>().As<IESigAuthService>();
        }
    }
}