using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Castle.Facilities.TypedFactory;

using CluedIn.Core;
using CluedIn.Crawling.AdventureWorks.Infrastructure.Factories;
using RestSharp;

namespace CluedIn.Crawling.AdventureWorks.Infrastructure.Installers
{
    public class InstallComponents : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container
                .AddFacilityIfNotExists<TypedFactoryFacility>()
                .Register(Component.For<IAdventureWorksClientFactory>().AsFactory().OnlyNewServices())
                .Register(Component.For<AdventureWorksClient>().LifestyleTransient().OnlyNewServices());

            if (!container.Kernel.HasComponent(typeof(IRestClient)) && !container.Kernel.HasComponent(typeof(RestClient)))
                container.Register(Component.For<IRestClient, RestClient>());
        }
    }
}
