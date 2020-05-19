using System.Collections.Generic;

using CluedIn.Core.Crawling;
using CluedIn.Crawling.AdventureWorks.Core;
using CluedIn.Crawling.AdventureWorks.Core.Models;
using CluedIn.Crawling.AdventureWorks.Infrastructure.Factories;

namespace CluedIn.Crawling.AdventureWorks
{
    public class AdventureWorksCrawler : ICrawlerDataGenerator
    {
        private readonly IAdventureWorksClientFactory clientFactory;
        public AdventureWorksCrawler(IAdventureWorksClientFactory clientFactory)
        {
            this.clientFactory = clientFactory;
        }

        public IEnumerable<object> GetData(CrawlJobData jobData)
        {
            if (!(jobData is AdventureWorksCrawlJobData adventureworkscrawlJobData))
            {
                yield break;
            }

            var client = clientFactory.CreateNew(adventureworkscrawlJobData);

            //retrieve data from provider and yield objects

            foreach (var obj in client.GetObject<HumanResourcesDepartment>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<HumanResourcesEmployee>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<HumanResourcesEmployeeDepartmentHistory>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<HumanResourcesEmployeePayHistory>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<HumanResourcesJobCandidate>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<HumanResourcesShift>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<PersonAddress>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<PersonAddressType>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<PersonBusinessEntity>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<PersonBusinessEntityAddress>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<PersonBusinessEntityContact>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<PersonContactType>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<PersonCountryRegion>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<PersonEmailAddress>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<PersonPassword>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<PersonPerson>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<PersonPersonPhone>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<PersonPhoneNumberType>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<PersonStateProvince>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<ProductionBillOfMaterials>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<ProductionCulture>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<ProductionDocument>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<ProductionIllustration>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<ProductionLocation>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<ProductionProduct>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<ProductionProductCategory>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<ProductionProductCostHistory>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<ProductionProductDescription>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<ProductionProductDocument>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<ProductionProductInventory>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<ProductionProductListPriceHistory>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<ProductionProductModel>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<ProductionProductModelIllustration>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<ProductionProductModelProductDescriptionCulture>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<ProductionProductPhoto>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<ProductionProductProductPhoto>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<ProductionProductReview>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<ProductionProductSubcategory>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<ProductionScrapReason>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<ProductionTransactionHistory>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<ProductionTransactionHistoryArchive>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<ProductionUnitMeasure>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<ProductionWorkOrder>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<ProductionWorkOrderRouting>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<PurchasingProductVendor>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<PurchasingPurchaseOrderDetail>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<PurchasingPurchaseOrderHeader>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<PurchasingShipMethod>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<PurchasingVendor>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<SalesCountryRegionCurrency>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<SalesCreditCard>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<SalesCurrency>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<SalesCurrencyRate>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<SalesCustomer>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<SalesPersonCreditCard>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<SalesSalesOrderDetail>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<SalesSalesOrderHeader>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<SalesSalesOrderHeaderSalesReason>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<SalesSalesPerson>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<SalesSalesPersonQuotaHistory>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<SalesSalesReason>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<SalesSalesTaxRate>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<SalesSalesTerritory>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<SalesSalesTerritoryHistory>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<SalesShoppingCartItem>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<SalesSpecialOffer>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<SalesSpecialOfferProduct>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<SalesStore>())
            {
                yield return obj;
            }
        }
    }
}
