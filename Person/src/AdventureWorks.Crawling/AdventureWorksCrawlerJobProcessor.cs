using CluedIn.Crawling.AdventureWorksPerson.Core;

namespace CluedIn.Crawling.AdventureWorksPerson
{
    public class AdventureWorksPersonCrawlerJobProcessor : GenericCrawlerTemplateJobProcessor<AdventureWorksPersonCrawlJobData>
    {
        public AdventureWorksPersonCrawlerJobProcessor(AdventureWorksPersonCrawlerComponent component) : base(component)
        {
        }
    }
}
