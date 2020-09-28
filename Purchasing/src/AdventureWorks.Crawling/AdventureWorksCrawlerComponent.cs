using CluedIn.Core;
using CluedIn.Crawling.AdventureWorksPurchasing.Core;

using ComponentHost;

namespace CluedIn.Crawling.AdventureWorksPurchasing
{
    [Component(AdventureWorksPurchasingConstants.CrawlerComponentName, "Crawlers", ComponentType.Service, Components.Server, Components.ContentExtractors, Isolation = ComponentIsolation.NotIsolated)]
    public class AdventureWorksPurchasingCrawlerComponent : CrawlerComponentBase
    {
        public AdventureWorksPurchasingCrawlerComponent([NotNull] ComponentInfo componentInfo)
            : base(componentInfo)
        {
        }
    }
}

