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

            #region crawling tables one after another

            //foreach (var obj in client.GetObject<HumanResourcesDepartment>())
            //{
            //    yield return obj;
            //}

            //foreach (var obj in client.GetObject<HumanResourcesEmployee>())
            //{
            //    yield return obj;
            //}

            //foreach (var obj in client.GetObject<HumanResourcesEmployeeDepartmentHistory>())
            //{
            //    yield return obj;
            //}

            //foreach (var obj in client.GetObject<HumanResourcesEmployeePayHistory>())
            //{
            //    yield return obj;
            //}

            //foreach (var obj in client.GetObject<HumanResourcesJobCandidate>())
            //{
            //    yield return obj;
            //}

            //foreach (var obj in client.GetObject<HumanResourcesShift>())
            //{
            //    yield return obj;
            //}

            //foreach (var obj in client.GetObject<PersonAddress>())
            //{
            //    yield return obj;
            //}

            //foreach (var obj in client.GetObject<PersonAddressType>())
            //{
            //    yield return obj;
            //}

            //foreach (var obj in client.GetObject<PersonBusinessEntity>())
            //{
            //    yield return obj;
            //}

            //foreach (var obj in client.GetObject<PersonBusinessEntityAddress>())
            //{
            //    yield return obj;
            //}

            //foreach (var obj in client.GetObject<PersonBusinessEntityContact>())
            //{
            //    yield return obj;
            //}

            //foreach (var obj in client.GetObject<PersonContactType>())
            //{
            //    yield return obj;
            //}

            //foreach (var obj in client.GetObject<PersonCountryRegion>())
            //{
            //    yield return obj;
            //}

            //foreach (var obj in client.GetObject<PersonEmailAddress>())
            //{
            //    yield return obj;
            //}

            //foreach (var obj in client.GetObject<PersonPerson>())
            //{
            //    yield return obj;
            //}

            //foreach (var obj in client.GetObject<PersonPersonPhone>())
            //{
            //    yield return obj;
            //}

            //foreach (var obj in client.GetObject<PersonPhoneNumberType>())
            //{
            //    yield return obj;
            //}

            //foreach (var obj in client.GetObject<PersonStateProvince>())
            //{
            //    yield return obj;
            //}

            //foreach (var obj in client.GetObject<ProductionBillOfMaterials>())
            //{
            //    yield return obj;
            //}

            //foreach (var obj in client.GetObject<ProductionCulture>())
            //{
            //    yield return obj;
            //}

            ////foreach (var obj in client.GetObject<ProductionDocument>())
            ////{
            ////    yield return obj;
            ////}

            //foreach (var obj in client.GetObject<ProductionIllustration>())
            //{
            //    yield return obj;
            //}

            //foreach (var obj in client.GetObject<ProductionLocation>())
            //{
            //    yield return obj;
            //}

            //foreach (var obj in client.GetObject<ProductionProduct>())
            //{
            //    yield return obj;
            //}

            //foreach (var obj in client.GetObject<ProductionProductCategory>())
            //{
            //    yield return obj;
            //}

            //foreach (var obj in client.GetObject<ProductionProductCostHistory>())
            //{
            //    yield return obj;
            //}

            //foreach (var obj in client.GetObject<ProductionProductDescription>())
            //{
            //    yield return obj;
            //}

            ////foreach (var obj in client.GetObject<ProductionProductDocument>())
            ////{
            ////    yield return obj;
            ////}

            //foreach (var obj in client.GetObject<ProductionProductInventory>())
            //{
            //    yield return obj;
            //}

            //foreach (var obj in client.GetObject<ProductionProductListPriceHistory>())
            //{
            //    yield return obj;
            //}

            //foreach (var obj in client.GetObject<ProductionProductModel>())
            //{
            //    yield return obj;
            //}

            //foreach (var obj in client.GetObject<ProductionProductModelIllustration>())
            //{
            //    yield return obj;
            //}

            //foreach (var obj in client.GetObject<ProductionProductModelProductDescriptionCulture>())
            //{
            //    yield return obj;
            //}

            ////foreach (var obj in client.GetObject<ProductionProductPhoto>())
            ////{
            ////    yield return obj;
            ////}

            //foreach (var obj in client.GetObject<ProductionProductProductPhoto>())
            //{
            //    yield return obj;
            //}

            //foreach (var obj in client.GetObject<ProductionProductReview>())
            //{
            //    yield return obj;
            //}

            //foreach (var obj in client.GetObject<ProductionProductSubcategory>())
            //{
            //    yield return obj;
            //}

            //foreach (var obj in client.GetObject<ProductionScrapReason>())
            //{
            //    yield return obj;
            //}

            //foreach (var obj in client.GetObject<ProductionTransactionHistory>())
            //{
            //    yield return obj;
            //}

            //foreach (var obj in client.GetObject<ProductionTransactionHistoryArchive>())
            //{
            //    yield return obj;
            //}

            //foreach (var obj in client.GetObject<ProductionUnitMeasure>())
            //{
            //    yield return obj;
            //}

            //foreach (var obj in client.GetObject<ProductionWorkOrder>())
            //{
            //    yield return obj;
            //}

            //foreach (var obj in client.GetObject<ProductionWorkOrderRouting>())
            //{
            //    yield return obj;
            //}

            //foreach (var obj in client.GetObject<PurchasingProductVendor>())
            //{
            //    yield return obj;
            //}

            //foreach (var obj in client.GetObject<PurchasingPurchaseOrderDetail>())
            //{
            //    yield return obj;
            //}

            //foreach (var obj in client.GetObject<PurchasingPurchaseOrderHeader>())
            //{
            //    yield return obj;
            //}

            //foreach (var obj in client.GetObject<PurchasingShipMethod>())
            //{
            //    yield return obj;
            //}

            //foreach (var obj in client.GetObject<PurchasingVendor>())
            //{
            //    yield return obj;
            //}

            //foreach (var obj in client.GetObject<SalesCountryRegionCurrency>())
            //{
            //    yield return obj;
            //}

            //foreach (var obj in client.GetObject<SalesCreditCard>())
            //{
            //    yield return obj;
            //}

            //foreach (var obj in client.GetObject<SalesCurrency>())
            //{
            //    yield return obj;
            //}

            //foreach (var obj in client.GetObject<SalesCurrencyRate>())
            //{
            //    yield return obj;
            //}

            //foreach (var obj in client.GetObject<SalesCustomer>())
            //{
            //    yield return obj;
            //}

            //foreach (var obj in client.GetObject<SalesPersonCreditCard>())
            //{
            //    yield return obj;
            //}

            //foreach (var obj in client.GetObject<SalesSalesOrderDetail>())
            //{
            //    yield return obj;
            //}

            //foreach (var obj in client.GetObject<SalesSalesOrderHeader>())
            //{
            //    yield return obj;
            //}

            //foreach (var obj in client.GetObject<SalesSalesOrderHeaderSalesReason>())
            //{
            //    yield return obj;
            //}

            //foreach (var obj in client.GetObject<SalesSalesPerson>())
            //{
            //    yield return obj;
            //}

            //foreach (var obj in client.GetObject<SalesSalesPersonQuotaHistory>())
            //{
            //    yield return obj;
            //}

            //foreach (var obj in client.GetObject<SalesSalesReason>())
            //{
            //    yield return obj;
            //}

            //foreach (var obj in client.GetObject<SalesSalesTaxRate>())
            //{
            //    yield return obj;
            //}

            //foreach (var obj in client.GetObject<SalesSalesTerritory>())
            //{
            //    yield return obj;
            //}

            //foreach (var obj in client.GetObject<SalesSalesTerritoryHistory>())
            //{
            //    yield return obj;
            //}

            //foreach (var obj in client.GetObject<SalesShoppingCartItem>())
            //{
            //    yield return obj;
            //}

            //foreach (var obj in client.GetObject<SalesSpecialOffer>())
            //{
            //    yield return obj;
            //}

            //foreach (var obj in client.GetObject<SalesSpecialOfferProduct>())
            //{
            //    yield return obj;
            //}

            //foreach (var obj in client.GetObject<SalesStore>())
            //{
            //    yield return obj;
            //}

            #endregion

            foreach (var obj in client.GetObject<HumanResourcesDepartment>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<HumanResourcesEmployee>())
            {
                if (!string.IsNullOrEmpty(obj.BusinessEntityID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<PersonBusinessEntity>($"WHERE BusinessEntityID = {obj.BusinessEntityID}"))
                    {
                        yield return subObj;
                    }
                }

                yield return obj;
            }

            foreach (var obj in client.GetObject<HumanResourcesEmployeeDepartmentHistory>())
            {
                if (!string.IsNullOrEmpty(obj.BusinessEntityID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<PersonBusinessEntity>($"WHERE BusinessEntityID = {obj.BusinessEntityID}"))
                    {
                        yield return subObj;
                    }
                }

                if (!string.IsNullOrEmpty(obj.DepartmentID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<HumanResourcesDepartment>($"WHERE DepartmentID = {obj.DepartmentID}"))
                    {
                        yield return subObj;
                    }
                }

                if (!string.IsNullOrEmpty(obj.ShiftID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<HumanResourcesShift>($"WHERE ShiftID = {obj.ShiftID}"))
                    {
                        yield return subObj;
                    }
                }

                yield return obj;
            }

            foreach (var obj in client.GetObject<HumanResourcesEmployeePayHistory>())
            {
                if (!string.IsNullOrEmpty(obj.BusinessEntityID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<PersonBusinessEntity>($"WHERE BusinessEntityID = {obj.BusinessEntityID}"))
                    {
                        yield return subObj;
                    }
                }

                yield return obj;
            }

            foreach (var obj in client.GetObject<HumanResourcesJobCandidate>())
            {
                if (!string.IsNullOrEmpty(obj.BusinessEntityID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<PersonBusinessEntity>($"WHERE BusinessEntityID = {obj.BusinessEntityID}"))
                    {
                        yield return subObj;
                    }
                }

                yield return obj;
            }

            foreach (var obj in client.GetObject<HumanResourcesShift>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<PersonAddress>())
            {
                if (!string.IsNullOrEmpty(obj.StateProvinceID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<PersonStateProvince>($"WHERE StateProvinceID = {obj.StateProvinceID}"))
                    {
                        yield return subObj;
                    }
                }

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
                if (!string.IsNullOrEmpty(obj.BusinessEntityID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<PersonBusinessEntity>($"WHERE BusinessEntityID = {obj.BusinessEntityID}"))
                    {
                        yield return subObj;
                    }
                }

                if (!string.IsNullOrEmpty(obj.AddressID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<PersonAddress>($"WHERE AddressID = {obj.AddressID}"))
                    {
                        yield return subObj;
                    }
                }

                if (!string.IsNullOrEmpty(obj.AddressTypeID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<PersonAddressType>($"WHERE AddressTypeID = {obj.AddressTypeID}"))
                    {
                        yield return subObj;
                    }
                }

                yield return obj;
            }

            foreach (var obj in client.GetObject<PersonBusinessEntityContact>())
            {
                if (!string.IsNullOrEmpty(obj.BusinessEntityID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<PersonBusinessEntity>($"WHERE BusinessEntityID = {obj.BusinessEntityID}"))
                    {
                        yield return subObj;
                    }
                }

                if (!string.IsNullOrEmpty(obj.PersonID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<PersonBusinessEntity>($"WHERE BusinessEntityID = {obj.PersonID}"))
                    {
                        yield return subObj;
                    }
                }

                if (!string.IsNullOrEmpty(obj.ContactTypeID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<PersonContactType>($"WHERE ContactTypeID = {obj.ContactTypeID}"))
                    {
                        yield return subObj;
                    }
                }

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
                if (!string.IsNullOrEmpty(obj.BusinessEntityID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<PersonBusinessEntity>($"WHERE BusinessEntityID = {obj.BusinessEntityID}"))
                    {
                        yield return subObj;
                    }
                }

                yield return obj;
            }

            foreach (var obj in client.GetObject<PersonPerson>())
            {
                if (!string.IsNullOrEmpty(obj.BusinessEntityID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<PersonBusinessEntity>($"WHERE BusinessEntityID = {obj.BusinessEntityID}"))
                    {
                        yield return subObj;
                    }
                }

                yield return obj;
            }

            foreach (var obj in client.GetObject<PersonPersonPhone>())
            {
                if (!string.IsNullOrEmpty(obj.BusinessEntityID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<PersonBusinessEntity>($"WHERE BusinessEntityID = {obj.BusinessEntityID}"))
                    {
                        yield return subObj;
                    }
                }

                if (!string.IsNullOrEmpty(obj.PhoneNumberTypeID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<PersonPhoneNumberType>($"WHERE PhoneNumberTypeID = {obj.PhoneNumberTypeID}"))
                    {
                        yield return subObj;
                    }
                }

                yield return obj;
            }

            foreach (var obj in client.GetObject<PersonPhoneNumberType>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<PersonStateProvince>())
            {
                if (!string.IsNullOrEmpty(obj.CountryRegionCode?.ToString()))
                {
                    foreach (var subObj in client.GetObject<PersonCountryRegion>($"WHERE CountryRegionCode = '{obj.CountryRegionCode}'"))
                    {
                        yield return subObj;
                    }
                }

                if (!string.IsNullOrEmpty(obj.TerritoryID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<SalesSalesTerritory>($"WHERE TerritoryID = {obj.TerritoryID}"))
                    {
                        yield return subObj;
                    }
                }

                yield return obj;
            }

            foreach (var obj in client.GetObject<ProductionBillOfMaterials>())
            {
                if (!string.IsNullOrEmpty(obj.ProductAssemblyID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<ProductionProduct>($"WHERE ProductID = {obj.ProductAssemblyID}"))
                    {
                        yield return subObj;
                    }
                }

                if (!string.IsNullOrEmpty(obj.ComponentID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<ProductionProduct>($"WHERE ProductID = {obj.ComponentID}"))
                    {
                        yield return subObj;
                    }
                }

                if (!string.IsNullOrEmpty(obj.UnitMeasureCode?.ToString()))
                {
                    foreach (var subObj in client.GetObject<ProductionUnitMeasure>($"WHERE UnitMeasureCode = '{obj.UnitMeasureCode}'"))
                    {
                        yield return subObj;
                    }
                }

                yield return obj;
            }

            foreach (var obj in client.GetObject<ProductionCulture>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<ProductionDocument>())
            {
                if (!string.IsNullOrEmpty(obj.Owner?.ToString()))
                {
                    foreach (var subObj in client.GetObject<PersonBusinessEntity>($"WHERE BusinessEntityID = {obj.Owner}"))
                    {
                        yield return subObj;
                    }
                }

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
                if (!string.IsNullOrEmpty(obj.SizeUnitMeasureCode?.ToString()))
                {
                    foreach (var subObj in client.GetObject<ProductionUnitMeasure>($"WHERE UnitMeasureCode = '{obj.SizeUnitMeasureCode}'"))
                    {
                        yield return subObj;
                    }
                }

                if (!string.IsNullOrEmpty(obj.WeightUnitMeasureCode?.ToString()))
                {
                    foreach (var subObj in client.GetObject<ProductionUnitMeasure>($"WHERE UnitMeasureCode = '{obj.WeightUnitMeasureCode}'"))
                    {
                        yield return subObj;
                    }
                }

                if (!string.IsNullOrEmpty(obj.ProductSubcategoryID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<ProductionProductSubcategory>($"WHERE ProductSubcategoryID = {obj.ProductSubcategoryID}"))
                    {
                        yield return subObj;
                    }
                }

                if (!string.IsNullOrEmpty(obj.ProductModelID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<ProductionProductModel>($"WHERE ProductModelID = {obj.ProductModelID}"))
                    {
                        yield return subObj;
                    }
                }

                yield return obj;
            }

            foreach (var obj in client.GetObject<ProductionProductCategory>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<ProductionProductCostHistory>())
            {
                if (!string.IsNullOrEmpty(obj.ProductID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<ProductionProduct>($"WHERE ProductID = {obj.ProductID}"))
                    {
                        yield return subObj;
                    }
                }

                yield return obj;
            }

            foreach (var obj in client.GetObject<ProductionProductDescription>())
            {
                yield return obj;
            }

            //foreach (var obj in client.GetObject<ProductionProductDocument>())
            //{
            //    if (!string.IsNullOrEmpty(obj.ProductID?.ToString()))
            //    {
            //        foreach (var subObj in client.GetObject<ProductionProduct>($"WHERE ProductID = {obj.ProductID}"))
            //        {
            //            yield return subObj;
            //        }
            //    }

            //    if (!string.IsNullOrEmpty(obj.DocumentNode?.ToString()))
            //    {
            //        foreach (var subObj in client.GetObject<ProductionDocument>($"WHERE DocumentNode = {obj.DocumentNode}"))
            //        {
            //            yield return subObj;
            //        }
            //    }

            //    yield return obj;
            //}

            foreach (var obj in client.GetObject<ProductionProductInventory>())
            {
                if (!string.IsNullOrEmpty(obj.ProductID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<ProductionProduct>($"WHERE ProductID = {obj.ProductID}"))
                    {
                        yield return subObj;
                    }
                }

                if (!string.IsNullOrEmpty(obj.LocationID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<ProductionLocation>($"WHERE LocationID = {obj.LocationID}"))
                    {
                        yield return subObj;
                    }
                }

                yield return obj;
            }

            foreach (var obj in client.GetObject<ProductionProductListPriceHistory>())
            {
                if (!string.IsNullOrEmpty(obj.ProductID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<ProductionProduct>($"WHERE ProductID = {obj.ProductID}"))
                    {
                        yield return subObj;
                    }
                }

                yield return obj;
            }

            foreach (var obj in client.GetObject<ProductionProductModel>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<ProductionProductModelIllustration>())
            {
                if (!string.IsNullOrEmpty(obj.ProductModelID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<ProductionProductModel>($"WHERE ProductModelID = {obj.ProductModelID}"))
                    {
                        yield return subObj;
                    }
                }

                if (!string.IsNullOrEmpty(obj.IllustrationID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<ProductionIllustration>($"WHERE IllustrationID = {obj.IllustrationID}"))
                    {
                        yield return subObj;
                    }
                }

                yield return obj;
            }

            foreach (var obj in client.GetObject<ProductionProductModelProductDescriptionCulture>())
            {
                if (!string.IsNullOrEmpty(obj.ProductModelID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<ProductionProductModel>($"WHERE ProductModelID = {obj.ProductModelID}"))
                    {
                        yield return subObj;
                    }
                }

                if (!string.IsNullOrEmpty(obj.ProductDescriptionID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<ProductionProductDescription>($"WHERE ProductDescriptionID = {obj.ProductDescriptionID}"))
                    {
                        yield return subObj;
                    }
                }

                if (!string.IsNullOrEmpty(obj.CultureID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<ProductionCulture>($"WHERE CultureID = '{obj.CultureID}'"))
                    {
                        yield return subObj;
                    }
                }

                yield return obj;
            }

            //foreach (var obj in client.GetObject<ProductionProductPhoto>())
            //{
            //    yield return obj;
            //}

            foreach (var obj in client.GetObject<ProductionProductProductPhoto>())
            {
                if (!string.IsNullOrEmpty(obj.ProductID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<ProductionProduct>($"WHERE ProductID = {obj.ProductID}"))
                    {
                        yield return subObj;
                    }
                }

                if (!string.IsNullOrEmpty(obj.ProductPhotoID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<ProductionProductPhoto>($"WHERE ProductPhotoID = {obj.ProductPhotoID}"))
                    {
                        yield return subObj;
                    }
                }

                yield return obj;
            }

            foreach (var obj in client.GetObject<ProductionProductReview>())
            {
                if (!string.IsNullOrEmpty(obj.ProductID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<ProductionProduct>($"WHERE ProductID = {obj.ProductID}"))
                    {
                        yield return subObj;
                    }
                }

                yield return obj;
            }

            foreach (var obj in client.GetObject<ProductionProductSubcategory>())
            {
                if (!string.IsNullOrEmpty(obj.ProductCategoryID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<ProductionProductCategory>($"WHERE ProductCategoryID = {obj.ProductCategoryID}"))
                    {
                        yield return subObj;
                    }
                }

                yield return obj;
            }

            foreach (var obj in client.GetObject<ProductionScrapReason>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<ProductionTransactionHistory>())
            {
                if (!string.IsNullOrEmpty(obj.ProductID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<ProductionProduct>($"WHERE ProductID = {obj.ProductID}"))
                    {
                        yield return subObj;
                    }
                }

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
                if (!string.IsNullOrEmpty(obj.ProductID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<ProductionProduct>($"WHERE ProductID = {obj.ProductID}"))
                    {
                        yield return subObj;
                    }
                }

                if (!string.IsNullOrEmpty(obj.ScrapReasonID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<ProductionScrapReason>($"WHERE ScrapReasonID = {obj.ScrapReasonID}"))
                    {
                        yield return subObj;
                    }
                }

                yield return obj;
            }

            foreach (var obj in client.GetObject<ProductionWorkOrderRouting>())
            {
                if (!string.IsNullOrEmpty(obj.WorkOrderID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<ProductionWorkOrder>($"WHERE WorkOrderID = {obj.WorkOrderID}"))
                    {
                        yield return subObj;
                    }
                }

                if (!string.IsNullOrEmpty(obj.LocationID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<ProductionLocation>($"WHERE LocationID = {obj.LocationID}"))
                    {
                        yield return subObj;
                    }
                }

                yield return obj;
            }

            foreach (var obj in client.GetObject<PurchasingProductVendor>())
            {
                if (!string.IsNullOrEmpty(obj.ProductID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<ProductionProduct>($"WHERE ProductID = {obj.ProductID}"))
                    {
                        yield return subObj;
                    }
                }

                if (!string.IsNullOrEmpty(obj.BusinessEntityID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<PersonBusinessEntity>($"WHERE BusinessEntityID = {obj.BusinessEntityID}"))
                    {
                        yield return subObj;
                    }
                }

                if (!string.IsNullOrEmpty(obj.UnitMeasureCode?.ToString()))
                {
                    foreach (var subObj in client.GetObject<ProductionUnitMeasure>($"WHERE UnitMeasureCode = '{obj.UnitMeasureCode}'"))
                    {
                        yield return subObj;
                    }
                }

                yield return obj;
            }

            foreach (var obj in client.GetObject<PurchasingPurchaseOrderDetail>())
            {
                if (!string.IsNullOrEmpty(obj.PurchaseOrderID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<PurchasingPurchaseOrderHeader>($"WHERE PurchaseOrderID = {obj.PurchaseOrderID}"))
                    {
                        yield return subObj;
                    }
                }

                if (!string.IsNullOrEmpty(obj.ProductID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<ProductionProduct>($"WHERE ProductID = {obj.ProductID}"))
                    {
                        yield return subObj;
                    }
                }

                yield return obj;
            }

            foreach (var obj in client.GetObject<PurchasingPurchaseOrderHeader>())
            {
                if (!string.IsNullOrEmpty(obj.EmployeeID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<PersonBusinessEntity>($"WHERE BusinessEntityID = {obj.EmployeeID}"))
                    {
                        yield return subObj;
                    }
                }

                if (!string.IsNullOrEmpty(obj.VendorID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<PersonBusinessEntity>($"WHERE BusinessEntityID = {obj.VendorID}"))
                    {
                        yield return subObj;
                    }
                }

                if (!string.IsNullOrEmpty(obj.ShipMethodID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<PurchasingShipMethod>($"WHERE ShipMethodID = {obj.ShipMethodID}"))
                    {
                        yield return subObj;
                    }
                }

                yield return obj;
            }

            foreach (var obj in client.GetObject<PurchasingShipMethod>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<PurchasingVendor>())
            {
                if (!string.IsNullOrEmpty(obj.BusinessEntityID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<PersonBusinessEntity>($"WHERE BusinessEntityID = {obj.BusinessEntityID}"))
                    {
                        yield return subObj;
                    }
                }

                yield return obj;
            }

            foreach (var obj in client.GetObject<SalesCountryRegionCurrency>())
            {
                if (!string.IsNullOrEmpty(obj.CountryRegionCode?.ToString()))
                {
                    foreach (var subObj in client.GetObject<PersonCountryRegion>($"WHERE CountryRegionCode = '{obj.CountryRegionCode}'"))
                    {
                        yield return subObj;
                    }
                }

                if (!string.IsNullOrEmpty(obj.CurrencyCode?.ToString()))
                {
                    foreach (var subObj in client.GetObject<SalesCurrency>($"WHERE CurrencyCode = '{obj.CurrencyCode}'"))
                    {
                        yield return subObj;
                    }
                }

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
                if (!string.IsNullOrEmpty(obj.FromCurrencyCode?.ToString()))
                {
                    foreach (var subObj in client.GetObject<SalesCurrency>($"WHERE CurrencyCode = '{obj.FromCurrencyCode}'"))
                    {
                        yield return subObj;
                    }
                }

                if (!string.IsNullOrEmpty(obj.ToCurrencyCode?.ToString()))
                {
                    foreach (var subObj in client.GetObject<SalesCurrency>($"WHERE CurrencyCode = '{obj.ToCurrencyCode}'"))
                    {
                        yield return subObj;
                    }
                }

                yield return obj;
            }

            foreach (var obj in client.GetObject<SalesCustomer>())
            {
                if (!string.IsNullOrEmpty(obj.PersonID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<PersonBusinessEntity>($"WHERE BusinessEntityID = {obj.PersonID}"))
                    {
                        yield return subObj;
                    }
                }

                if (!string.IsNullOrEmpty(obj.StoreID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<PersonBusinessEntity>($"WHERE BusinessEntityID = {obj.StoreID}"))
                    {
                        yield return subObj;
                    }
                }

                if (!string.IsNullOrEmpty(obj.TerritoryID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<SalesSalesTerritory>($"WHERE TerritoryID = {obj.TerritoryID}"))
                    {
                        yield return subObj;
                    }
                }

                yield return obj;
            }

            foreach (var obj in client.GetObject<SalesPersonCreditCard>())
            {
                if (!string.IsNullOrEmpty(obj.BusinessEntityID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<PersonBusinessEntity>($"WHERE BusinessEntityID = {obj.BusinessEntityID}"))
                    {
                        yield return subObj;
                    }
                }

                if (!string.IsNullOrEmpty(obj.CreditCardID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<SalesCreditCard>($"WHERE CreditCardID = {obj.CreditCardID}"))
                    {
                        yield return subObj;
                    }
                }

                yield return obj;
            }

            foreach (var obj in client.GetObject<SalesSalesOrderDetail>())
            {
                if (!string.IsNullOrEmpty(obj.SalesOrderID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<SalesSalesOrderHeader>($"WHERE SalesOrderID = {obj.SalesOrderID}"))
                    {
                        yield return subObj;
                    }
                }

                if (!string.IsNullOrEmpty(obj.ProductID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<ProductionProduct>($"WHERE ProductID = {obj.ProductID}"))
                    {
                        yield return subObj;
                    }
                }

                if (!string.IsNullOrEmpty(obj.SpecialOfferID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<SalesSpecialOffer>($"WHERE SpecialOfferID = {obj.SpecialOfferID}"))
                    {
                        yield return subObj;
                    }
                }

                yield return obj;
            }

            foreach (var obj in client.GetObject<SalesSalesOrderHeader>())
            {
                if (!string.IsNullOrEmpty(obj.CustomerID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<SalesCustomer>($"WHERE CustomerID = {obj.CustomerID}"))
                    {
                        yield return subObj;
                    }
                }

                if (!string.IsNullOrEmpty(obj.SalesPersonID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<PersonBusinessEntity>($"WHERE BusinessEntityID = {obj.SalesPersonID}"))
                    {
                        yield return subObj;
                    }
                }

                if (!string.IsNullOrEmpty(obj.TerritoryID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<SalesSalesTerritory>($"WHERE TerritoryID = {obj.TerritoryID}"))
                    {
                        yield return subObj;
                    }
                }

                if (!string.IsNullOrEmpty(obj.BillToAddressID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<PersonAddress>($"WHERE AddressID = {obj.BillToAddressID}"))
                    {
                        yield return subObj;
                    }
                }

                if (!string.IsNullOrEmpty(obj.ShipToAddressID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<PersonAddress>($"WHERE AddressID = {obj.ShipToAddressID}"))
                    {
                        yield return subObj;
                    }
                }

                if (!string.IsNullOrEmpty(obj.ShipMethodID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<PurchasingShipMethod>($"WHERE ShipMethodID = {obj.ShipMethodID}"))
                    {
                        yield return subObj;
                    }
                }

                if (!string.IsNullOrEmpty(obj.CreditCardID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<SalesCreditCard>($"WHERE CreditCardID = {obj.CreditCardID}"))
                    {
                        yield return subObj;
                    }
                }

                if (!string.IsNullOrEmpty(obj.CurrencyRateID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<SalesCurrencyRate>($"WHERE CurrencyRateID = {obj.CurrencyRateID}"))
                    {
                        yield return subObj;
                    }
                }

                yield return obj;
            }

            foreach (var obj in client.GetObject<SalesSalesOrderHeaderSalesReason>())
            {
                if (!string.IsNullOrEmpty(obj.SalesOrderID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<SalesSalesOrderHeader>($"WHERE SalesOrderID = {obj.SalesOrderID}"))
                    {
                        yield return subObj;
                    }
                }

                if (!string.IsNullOrEmpty(obj.SalesReasonID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<SalesSalesReason>($"WHERE SalesReasonID = {obj.SalesReasonID}"))
                    {
                        yield return subObj;
                    }
                }

                yield return obj;
            }

            foreach (var obj in client.GetObject<SalesSalesPerson>())
            {
                if (!string.IsNullOrEmpty(obj.BusinessEntityID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<PersonBusinessEntity>($"WHERE BusinessEntityID = {obj.BusinessEntityID}"))
                    {
                        yield return subObj;
                    }
                }

                if (!string.IsNullOrEmpty(obj.TerritoryID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<SalesSalesTerritory>($"WHERE TerritoryID = {obj.TerritoryID}"))
                    {
                        yield return subObj;
                    }
                }

                yield return obj;
            }

            foreach (var obj in client.GetObject<SalesSalesPersonQuotaHistory>())
            {
                if (!string.IsNullOrEmpty(obj.BusinessEntityID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<PersonBusinessEntity>($"WHERE BusinessEntityID = {obj.BusinessEntityID}"))
                    {
                        yield return subObj;
                    }
                }

                yield return obj;
            }

            foreach (var obj in client.GetObject<SalesSalesReason>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<SalesSalesTaxRate>())
            {
                if (!string.IsNullOrEmpty(obj.StateProvinceID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<PersonStateProvince>($"WHERE StateProvinceID = {obj.StateProvinceID}"))
                    {
                        yield return subObj;
                    }
                }

                yield return obj;
            }

            foreach (var obj in client.GetObject<SalesSalesTerritory>())
            {
                if (!string.IsNullOrEmpty(obj.CountryRegionCode?.ToString()))
                {
                    foreach (var subObj in client.GetObject<PersonCountryRegion>($"WHERE CountryRegionCode = '{obj.CountryRegionCode}'"))
                    {
                        yield return subObj;
                    }
                }

                yield return obj;
            }

            foreach (var obj in client.GetObject<SalesSalesTerritoryHistory>())
            {
                if (!string.IsNullOrEmpty(obj.BusinessEntityID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<PersonBusinessEntity>($"WHERE BusinessEntityID = {obj.BusinessEntityID}"))
                    {
                        yield return subObj;
                    }
                }

                if (!string.IsNullOrEmpty(obj.TerritoryID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<SalesSalesTerritory>($"WHERE TerritoryID = {obj.TerritoryID}"))
                    {
                        yield return subObj;
                    }
                }

                yield return obj;
            }

            foreach (var obj in client.GetObject<SalesShoppingCartItem>())
            {
                if (!string.IsNullOrEmpty(obj.ProductID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<ProductionProduct>($"WHERE ProductID = {obj.ProductID}"))
                    {
                        yield return subObj;
                    }
                }

                yield return obj;
            }

            foreach (var obj in client.GetObject<SalesSpecialOffer>())
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<SalesSpecialOfferProduct>())
            {
                if (!string.IsNullOrEmpty(obj.SpecialOfferID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<SalesSpecialOffer>($"WHERE SpecialOfferID = {obj.SpecialOfferID}"))
                    {
                        yield return subObj;
                    }
                }

                if (!string.IsNullOrEmpty(obj.ProductID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<ProductionProduct>($"WHERE ProductID = {obj.ProductID}"))
                    {
                        yield return subObj;
                    }
                }

                yield return obj;
            }

            foreach (var obj in client.GetObject<SalesStore>())
            {
                if (!string.IsNullOrEmpty(obj.BusinessEntityID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<PersonBusinessEntity>($"WHERE BusinessEntityID = {obj.BusinessEntityID}"))
                    {
                        yield return subObj;
                    }
                }

                if (!string.IsNullOrEmpty(obj.SalesPersonID?.ToString()))
                {
                    foreach (var subObj in client.GetObject<PersonBusinessEntity>($"WHERE BusinessEntityID = {obj.SalesPersonID}"))
                    {
                        yield return subObj;
                    }
                }

                yield return obj;
            }


        }
    }
}
