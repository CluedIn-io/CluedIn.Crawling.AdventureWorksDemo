using CluedIn.Crawling.AdventureWorksPurchasing.Core;

namespace CluedIn.Crawling.AdventureWorksPurchasing
{
    public class AdventureWorksPurchasingCrawlerJobProcessor : GenericCrawlerTemplateJobProcessor<AdventureWorksPurchasingCrawlJobData>
    {
        public AdventureWorksPurchasingCrawlerJobProcessor(AdventureWorksPurchasingCrawlerComponent component) : base(component)
        {
        }
    }
}
