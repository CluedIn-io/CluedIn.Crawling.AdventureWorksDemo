using CluedIn.Crawling.AdventureWorksPerson.Core;

namespace CluedIn.Crawling.AdventureWorksPerson.Infrastructure.Factories
{
    public interface IAdventureWorksPersonClientFactory
    {
        AdventureWorksPersonClient CreateNew(AdventureWorksPersonCrawlJobData AdventureWorksPersonCrawlJobData);
    }
}
