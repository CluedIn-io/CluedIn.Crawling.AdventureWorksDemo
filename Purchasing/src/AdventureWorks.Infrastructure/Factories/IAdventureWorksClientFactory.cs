using CluedIn.Crawling.AdventureWorksPurchasing.Core;

namespace CluedIn.Crawling.AdventureWorksPurchasing.Infrastructure.Factories
{
    public interface IAdventureWorksPurchasingClientFactory
    {
        AdventureWorksPurchasingClient CreateNew(AdventureWorksPurchasingCrawlJobData AdventureWorksPurchasingCrawlJobData);
    }
}
