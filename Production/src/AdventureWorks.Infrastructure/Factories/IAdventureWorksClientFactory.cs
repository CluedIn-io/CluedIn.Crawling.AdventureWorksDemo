using CluedIn.Crawling.AdventureWorksProduction.Core;

namespace CluedIn.Crawling.AdventureWorksProduction.Infrastructure.Factories
{
    public interface IAdventureWorksProductionClientFactory
    {
        AdventureWorksProductionClient CreateNew(AdventureWorksProductionCrawlJobData AdventureWorksProductionCrawlJobData);
    }
}
