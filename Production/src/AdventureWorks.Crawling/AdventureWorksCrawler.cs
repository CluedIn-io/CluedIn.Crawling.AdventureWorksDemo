using System.Collections.Generic;

using CluedIn.Core.Crawling;
using CluedIn.Crawling.AdventureWorksProduction.Core;
using CluedIn.Crawling.AdventureWorksProduction.Core.Models;
using CluedIn.Crawling.AdventureWorksProduction.Infrastructure.Factories;

namespace CluedIn.Crawling.AdventureWorksProduction
{
    public class AdventureWorksProductionCrawler : ICrawlerDataGenerator
    {
        private readonly IAdventureWorksProductionClientFactory clientFactory;
        public AdventureWorksProductionCrawler(IAdventureWorksProductionClientFactory clientFactory)
        {
            this.clientFactory = clientFactory;
        }

        public IEnumerable<object> GetData(CrawlJobData jobData)
        {
            if (!(jobData is AdventureWorksProductionCrawlJobData AdventureWorksProductioncrawlJobData))
            {
                yield break;
            }

            var client = clientFactory.CreateNew(AdventureWorksProductioncrawlJobData);

            foreach (var obj in client.GetObject<ProductionBillOfMaterials>(500))
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<ProductionCulture>(500))
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<ProductionDocument>(500))
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<ProductionIllustration>(500))
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<ProductionLocation>(500))
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<ProductionProductCategory>(500))
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<ProductionProduct>(500))
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<ProductionProductCostHistory>(500))
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<ProductionProductDescription>(500))
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<ProductionProductDocument>(500))
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<ProductionProductInventory>(500))
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<ProductionProductListPriceHistory>(500))
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<ProductionProductModel>(500))
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<ProductionProductModelIllustration>(500))
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<ProductionProductModelProductDescriptionCulture>(500))
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<ProductionProductPhoto>(500))
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<ProductionProductProductPhoto>(500))
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<ProductionProductReview>(500))
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<ProductionProductSubcategory>(500))
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<ProductionScrapReason>(500))
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<ProductionTransactionHistoryArchive>(500))
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<ProductionTransactionHistory>(500))
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<ProductionUnitMeasure>(500))
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<ProductionWorkOrder>(500))
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<ProductionWorkOrderRouting>(500))
            {
                yield return obj;
            }



        }
    }
}
