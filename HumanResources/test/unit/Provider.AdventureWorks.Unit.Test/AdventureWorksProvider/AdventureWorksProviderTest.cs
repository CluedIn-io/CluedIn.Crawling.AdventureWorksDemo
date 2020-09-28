using Castle.Windsor;
using CluedIn.Core;
using CluedIn.Core.Providers;
using CluedIn.Crawling.AdventureWorks.Infrastructure.Factories;
using Moq;

namespace CluedIn.Provider.AdventureWorks.Unit.Test.AdventureWorksProvider
{
    public abstract class AdventureWorksProviderTest
    {
        protected readonly ProviderBase Sut;

        protected Mock<IAdventureWorksClientFactory> NameClientFactory;
        protected Mock<IWindsorContainer> Container;

        protected AdventureWorksProviderTest()
        {
            Container = new Mock<IWindsorContainer>();
            NameClientFactory = new Mock<IAdventureWorksClientFactory>();
            var applicationContext = new ApplicationContext(Container.Object);
            Sut = new AdventureWorks.AdventureWorksProvider(applicationContext, NameClientFactory.Object);
        }
    }
}
