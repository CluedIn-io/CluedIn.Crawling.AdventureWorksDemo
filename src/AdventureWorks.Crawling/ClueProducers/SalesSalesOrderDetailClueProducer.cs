using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Helpers;
using CluedIn.Crawling.AdventureWorks.Vocabularies;
using CluedIn.Crawling.AdventureWorks.Core.Models;
using CluedIn.Crawling.AdventureWorks.Core;
using CluedIn.Core;
using RuleConstants = CluedIn.Core.Constants.Validation.Rules;
using System.Linq;
using System;

namespace CluedIn.Crawling.AdventureWorks.ClueProducers
{
    public class SalesSalesOrderDetailClueProducer : BaseClueProducer<SalesSalesOrderDetail>
    {
        private readonly IClueFactory _factory;

        public SalesSalesOrderDetailClueProducer(IClueFactory factory)
        {
            _factory = factory;
        }

        protected override Clue MakeClueImpl(SalesSalesOrderDetail input, Guid id)
        {

            var clue = _factory.Create("/SalesSalesOrderDetail", $"{input.Rowguid}", id);

            var data = clue.Data.EntityData;



            data.Name = $"Sales Order Details {input.SalesOrderID}.{input.SalesOrderDetailID}";

            data.Codes.Add(new EntityCode("/SalesSalesOrderDetail", AdventureWorksConstants.CodeOrigin, $"{input.SalesOrderID}.{input.SalesOrderDetailID}"));

            //add edges

            if (input.SalesOrderID != null && !string.IsNullOrEmpty(input.SalesOrderID.ToString()))
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Sales.Sale, EntityEdgeType.AttachedTo, input.SalesOrderID, input.SalesOrderID.ToString());
            }
            if (input.ProductID != null && !string.IsNullOrEmpty(input.ProductID.ToString()))
            {
                _factory.CreateOutgoingEntityReference(clue, "/SalesSpecialOfferProduct", EntityEdgeType.AttachedTo, input.ProductID, input.ProductID.ToString());
            }
            if (input.SpecialOfferID != null && !string.IsNullOrEmpty(input.SpecialOfferID.ToString()))
            {
                _factory.CreateOutgoingEntityReference(clue, "/SalesSpecialOfferProduct", EntityEdgeType.AttachedTo, input.SpecialOfferID, input.SpecialOfferID.ToString());
            }

            if (!data.OutgoingEdges.Any())
            {
                _factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);
            }


            var vocab = new SalesSalesOrderDetailVocabulary();

            data.Properties[vocab.SalesOrderID] = input.SalesOrderID.PrintIfAvailable();
            data.Properties[vocab.SalesOrderDetailID] = input.SalesOrderDetailID.PrintIfAvailable();
            data.Properties[vocab.CarrierTrackingNumber] = input.CarrierTrackingNumber.PrintIfAvailable();
            data.Properties[vocab.OrderQty] = input.OrderQty.PrintIfAvailable();
            data.Properties[vocab.ProductID] = input.ProductID.PrintIfAvailable();
            data.Properties[vocab.SpecialOfferID] = input.SpecialOfferID.PrintIfAvailable();
            data.Properties[vocab.UnitPrice] = input.UnitPrice.PrintIfAvailable();
            data.Properties[vocab.UnitPriceDiscount] = input.UnitPriceDiscount.PrintIfAvailable();
            data.Properties[vocab.LineTotal] = input.LineTotal.PrintIfAvailable();
            data.Properties[vocab.Rowguid] = input.Rowguid.PrintIfAvailable();
            data.Properties[vocab.ModifiedDate] = input.ModifiedDate.PrintIfAvailable();

            clue.ValidationRuleSuppressions.AddRange(new[]
                                        {
                                RuleConstants.METADATA_001_Name_MustBeSet,
                                RuleConstants.PROPERTIES_001_MustExist,
                                RuleConstants.METADATA_002_Uri_MustBeSet,
                                RuleConstants.METADATA_003_Author_Name_MustBeSet,
                                RuleConstants.METADATA_005_PreviewImage_RawData_MustBeSet
                            });

            return clue;
        }
    }
}


