using CluedIn.Crawling.AdventureWorksProduction.Core;

namespace CluedIn.Crawling.AdventureWorksProduction
{
    public class AdventureWorksProductionCrawlerJobProcessor : GenericCrawlerTemplateJobProcessor<AdventureWorksProductionCrawlJobData>
    {
        public AdventureWorksProductionCrawlerJobProcessor(AdventureWorksProductionCrawlerComponent component) : base(component)
        {
        }
    }
}
