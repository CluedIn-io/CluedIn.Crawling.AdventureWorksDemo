using CluedIn.Core;
using CluedIn.Crawling.AdventureWorksProduction.Core;

using ComponentHost;

namespace CluedIn.Crawling.AdventureWorksProduction
{
    [Component(AdventureWorksProductionConstants.CrawlerComponentName, "Crawlers", ComponentType.Service, Components.Server, Components.ContentExtractors, Isolation = ComponentIsolation.NotIsolated)]
    public class AdventureWorksProductionCrawlerComponent : CrawlerComponentBase
    {
        public AdventureWorksProductionCrawlerComponent([NotNull] ComponentInfo componentInfo)
            : base(componentInfo)
        {
        }
    }
}

