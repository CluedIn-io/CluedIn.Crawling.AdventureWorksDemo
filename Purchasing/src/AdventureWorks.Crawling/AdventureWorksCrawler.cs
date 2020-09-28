using System.Collections.Generic;

using CluedIn.Core.Crawling;
using CluedIn.Crawling.AdventureWorksPurchasing.Core;
using CluedIn.Crawling.AdventureWorksPurchasing.Core.Models;
using CluedIn.Crawling.AdventureWorksPurchasing.Infrastructure.Factories;

namespace CluedIn.Crawling.AdventureWorksPurchasing
{
    public class AdventureWorksPurchasingCrawler : ICrawlerDataGenerator
    {
        private readonly IAdventureWorksPurchasingClientFactory clientFactory;
        public AdventureWorksPurchasingCrawler(IAdventureWorksPurchasingClientFactory clientFactory)
        {
            this.clientFactory = clientFactory;
        }

        public IEnumerable<object> GetData(CrawlJobData jobData)
        {
            if (!(jobData is AdventureWorksPurchasingCrawlJobData AdventureWorksPurchasingcrawlJobData))
            {
                yield break;
            }

            var client = clientFactory.CreateNew(AdventureWorksPurchasingcrawlJobData);

            foreach (var obj in client.GetObject<PurchasingProductVendor>(500))
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<PurchasingPurchaseOrderDetail>(500))
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<PurchasingPurchaseOrderHeader>(500))
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<PurchasingShipMethod>(500))
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<PurchasingVendor>(500))
            {
                yield return obj;
            }

        }
    }
}
