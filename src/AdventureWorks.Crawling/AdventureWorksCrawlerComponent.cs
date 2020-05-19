using CluedIn.Core;
using CluedIn.Crawling.AdventureWorks.Core;

using ComponentHost;

namespace CluedIn.Crawling.AdventureWorks
{
    [Component(AdventureWorksConstants.CrawlerComponentName, "Crawlers", ComponentType.Service, Components.Server, Components.ContentExtractors, Isolation = ComponentIsolation.NotIsolated)]
    public class AdventureWorksCrawlerComponent : CrawlerComponentBase
    {
        public AdventureWorksCrawlerComponent([NotNull] ComponentInfo componentInfo)
            : base(componentInfo)
        {
        }
    }
}

