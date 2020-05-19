using Castle.MicroKernel.Registration;

using CluedIn.Core;
using CluedIn.Core.Providers;
// 
using CluedIn.Core.Webhooks;
// 
using CluedIn.Crawling.AdventureWorks.Core;
using CluedIn.Crawling.AdventureWorks.Infrastructure.Installers;
// 
using CluedIn.Server;
using ComponentHost;

namespace CluedIn.Provider.AdventureWorks
{
    [Component(AdventureWorksConstants.ProviderName, "Providers", ComponentType.Service, ServerComponents.ProviderWebApi, Components.Server, Components.DataStores, Isolation = ComponentIsolation.NotIsolated)]
    public sealed class AdventureWorksProviderComponent : ServiceApplicationComponent<EmbeddedServer>
    {
        public AdventureWorksProviderComponent(ComponentInfo componentInfo)
            : base(componentInfo)
        {
            // Dev. Note: Potential for compiler warning here ... CA2214: Do not call overridable methods in constructors
            //   this class has been sealed to prevent the CA2214 waring being raised by the compiler
            Container.Register(Component.For<AdventureWorksProviderComponent>().Instance(this));  
        }

        public override void Start()
        {
            Container.Install(new InstallComponents());

            Container.Register(Types.FromThisAssembly().BasedOn<IProvider>().WithServiceFromInterface().If(t => !t.IsAbstract).LifestyleSingleton());
            Container.Register(Types.FromThisAssembly().BasedOn<IEntityActionBuilder>().WithServiceFromInterface().If(t => !t.IsAbstract).LifestyleSingleton());

            Container.Register(Types.FromThisAssembly().BasedOn<IWebhookProcessor>().WithServiceFromInterface().If(t => !t.IsAbstract).LifestyleSingleton());
            Container.Register(Types.FromThisAssembly().BasedOn<IWebhookPrevalidator>().WithServiceFromInterface().If(t => !t.IsAbstract).LifestyleSingleton());



            State = ServiceState.Started;
        }

        public override void Stop()
        {
            if (State == ServiceState.Stopped)
                return;

            State = ServiceState.Stopped;
        }
    }
}
