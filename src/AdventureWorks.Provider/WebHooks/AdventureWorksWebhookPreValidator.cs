using CluedIn.Core.Webhooks;
using CluedIn.Crawling.AdventureWorks.Core;

namespace CluedIn.Provider.AdventureWorks.WebHooks
{
    public class Name_WebhookPreValidator : BaseWebhookPrevalidator
    {
        public Name_WebhookPreValidator()
            : base(AdventureWorksConstants.ProviderId, AdventureWorksConstants.ProviderName)
        {
        }
    }
}
