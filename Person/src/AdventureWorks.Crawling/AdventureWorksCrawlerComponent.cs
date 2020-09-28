using CluedIn.Core;
using CluedIn.Crawling.AdventureWorksPerson.Core;

using ComponentHost;

namespace CluedIn.Crawling.AdventureWorksPerson
{
    [Component(AdventureWorksPersonConstants.CrawlerComponentName, "Crawlers", ComponentType.Service, Components.Server, Components.ContentExtractors, Isolation = ComponentIsolation.NotIsolated)]
    public class AdventureWorksPersonCrawlerComponent : CrawlerComponentBase
    {
        public AdventureWorksPersonCrawlerComponent([NotNull] ComponentInfo componentInfo)
            : base(componentInfo)
        {
        }
    }
}

