using CluedIn.Crawling.AdventureWorks.Core;

namespace CluedIn.Crawling.AdventureWorks
{
    public class AdventureWorksCrawlerJobProcessor : GenericCrawlerTemplateJobProcessor<AdventureWorksCrawlJobData>
    {
        public AdventureWorksCrawlerJobProcessor(AdventureWorksCrawlerComponent component) : base(component)
        {
        }
    }
}
