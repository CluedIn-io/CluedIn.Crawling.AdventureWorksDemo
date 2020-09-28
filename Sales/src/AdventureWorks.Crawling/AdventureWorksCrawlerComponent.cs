using CluedIn.Core;
using CluedIn.Crawling.AdventureWorksSales.Core;

using ComponentHost;

namespace CluedIn.Crawling.AdventureWorksSales
{
    [Component(AdventureWorksSalesConstants.CrawlerComponentName, "Crawlers", ComponentType.Service, Components.Server, Components.ContentExtractors, Isolation = ComponentIsolation.NotIsolated)]
    public class AdventureWorksSalesCrawlerComponent : CrawlerComponentBase
    {
        public AdventureWorksSalesCrawlerComponent([NotNull] ComponentInfo componentInfo)
            : base(componentInfo)
        {
        }
    }
}

