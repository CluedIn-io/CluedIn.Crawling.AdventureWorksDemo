using CluedIn.Crawling.AdventureWorksHumanResources.Core;

namespace CluedIn.Crawling.AdventureWorksHumanResources.Infrastructure.Factories
{
    public interface IAdventureWorksHumanResourcesClientFactory
    {
        AdventureWorksHumanResourcesClient CreateNew(AdventureWorksHumanResourcesCrawlJobData AdventureWorksHumanResourcesCrawlJobData);
    }
}
