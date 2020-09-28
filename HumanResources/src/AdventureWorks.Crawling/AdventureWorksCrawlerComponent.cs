using CluedIn.Core;
using CluedIn.Crawling.AdventureWorksHumanResources.Core;

using ComponentHost;

namespace CluedIn.Crawling.AdventureWorksHumanResources
{
    [Component(AdventureWorksHumanResourcesConstants.CrawlerComponentName, "Crawlers", ComponentType.Service, Components.Server, Components.ContentExtractors, Isolation = ComponentIsolation.NotIsolated)]
    public class AdventureWorksHumanResourcesCrawlerComponent : CrawlerComponentBase
    {
        public AdventureWorksHumanResourcesCrawlerComponent([NotNull] ComponentInfo componentInfo)
            : base(componentInfo)
        {
        }
    }
}

