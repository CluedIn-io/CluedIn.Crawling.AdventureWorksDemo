using CluedIn.Crawling.AdventureWorks.Core;

namespace CluedIn.Crawling.AdventureWorks.Infrastructure.Factories
{
    public interface IAdventureWorksClientFactory
    {
        AdventureWorksClient CreateNew(AdventureWorksCrawlJobData adventureworksCrawlJobData);
    }
}
