using CluedIn.Crawling.AdventureWorksSales.Core;

namespace CluedIn.Crawling.AdventureWorksSales
{
    public class AdventureWorksSalesCrawlerJobProcessor : GenericCrawlerTemplateJobProcessor<AdventureWorksSalesCrawlJobData>
    {
        public AdventureWorksSalesCrawlerJobProcessor(AdventureWorksSalesCrawlerComponent component) : base(component)
        {
        }
    }
}
