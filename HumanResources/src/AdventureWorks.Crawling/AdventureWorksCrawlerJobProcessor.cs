using CluedIn.Crawling.AdventureWorksHumanResources.Core;

namespace CluedIn.Crawling.AdventureWorksHumanResources
{
    public class AdventureWorksHumanResourcesCrawlerJobProcessor : GenericCrawlerTemplateJobProcessor<AdventureWorksHumanResourcesCrawlJobData>
    {
        public AdventureWorksHumanResourcesCrawlerJobProcessor(AdventureWorksHumanResourcesCrawlerComponent component) : base(component)
        {
        }
    }
}
