using System.Collections.Generic;

using CluedIn.Core.Crawling;
using CluedIn.Crawling.AdventureWorksSales.Core;
using CluedIn.Crawling.AdventureWorksSales.Core.Models;
using CluedIn.Crawling.AdventureWorksSales.Infrastructure.Factories;

namespace CluedIn.Crawling.AdventureWorksSales
{
    public class AdventureWorksSalesCrawler : ICrawlerDataGenerator
    {
        private readonly IAdventureWorksSalesClientFactory clientFactory;
        public AdventureWorksSalesCrawler(IAdventureWorksSalesClientFactory clientFactory)
        {
            this.clientFactory = clientFactory;
        }

        public IEnumerable<object> GetData(CrawlJobData jobData)
        {
            if (!(jobData is AdventureWorksSalesCrawlJobData AdventureWorksSalescrawlJobData))
            {
                yield break;
            }

            var client = clientFactory.CreateNew(AdventureWorksSalescrawlJobData);

            foreach (var obj in client.GetObject<SalesCountryRegionCurrency>(500))
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<SalesCreditCard>(500))
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<SalesCurrency>(500))
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<SalesCurrencyRate>(500))
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<SalesCustomer>(500))
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<SalesPersonCreditCard>(500))
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<SalesSalesOrderDetail>(500))
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<SalesSalesOrderHeader>(500))
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<SalesSalesOrderHeaderSalesReason>(500))
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<SalesSalesReason>(500))
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<SalesSalesTaxRate>(500))
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<SalesSalesTerritory>(500))
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<SalesSalesTerritoryHistory>(500))
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<SalesShoppingCartItem>(500))
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<SalesSpecialOffer>(500))
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<SalesSpecialOfferProduct>(500))
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<SalesStore>(500))
            {
                yield return obj;
            }

        }
    }
}
