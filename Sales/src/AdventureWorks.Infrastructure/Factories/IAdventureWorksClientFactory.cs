using CluedIn.Crawling.AdventureWorksSales.Core;

namespace CluedIn.Crawling.AdventureWorksSales.Infrastructure.Factories
{
    public interface IAdventureWorksSalesClientFactory
    {
        AdventureWorksSalesClient CreateNew(AdventureWorksSalesCrawlJobData AdventureWorksSalesCrawlJobData);
    }
}
