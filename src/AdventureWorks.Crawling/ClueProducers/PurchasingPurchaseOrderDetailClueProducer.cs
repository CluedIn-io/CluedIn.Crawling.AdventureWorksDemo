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
    public class PurchasingPurchaseOrderDetailClueProducer : BaseClueProducer<PurchasingPurchaseOrderDetail>
    {
        private readonly IClueFactory _factory;

        public PurchasingPurchaseOrderDetailClueProducer(IClueFactory factory)
        {
            _factory = factory;
        }

        protected override Clue MakeClueImpl(PurchasingPurchaseOrderDetail input, Guid id)
        {

            var clue = _factory.Create("/PurchasingPurchaseOrderDetail", $"{input.PurchaseOrderID}.{input.PurchaseOrderDetailID}", id);

            var data = clue.Data.EntityData;



            data.Name = $"Purchase Order Detail: {input.ProductID} - Quantity {input.OrderQty}";


            //add edges

            if (input.PurchaseOrderID != null && !string.IsNullOrEmpty(input.PurchaseOrderID.ToString()))
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Sales.Order, EntityEdgeType.AttachedTo, input.PurchaseOrderID, input.PurchaseOrderID.ToString());
            }
            if (input.ProductID != null && !string.IsNullOrEmpty(input.ProductID.ToString()))
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Product, EntityEdgeType.AttachedTo, input.ProductID, input.ProductID.ToString());
            }

            if (!data.OutgoingEdges.Any())
            {
                _factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);
            }


            var vocab = new PurchasingPurchaseOrderDetailVocabulary();

            data.Properties[vocab.PurchaseOrderID] = input.PurchaseOrderID.PrintIfAvailable();
            data.Properties[vocab.PurchaseOrderDetailID] = input.PurchaseOrderDetailID.PrintIfAvailable();
            data.Properties[vocab.DueDate] = input.DueDate.PrintIfAvailable();
            data.Properties[vocab.OrderQty] = input.OrderQty.PrintIfAvailable();
            data.Properties[vocab.ProductID] = input.ProductID.PrintIfAvailable();
            data.Properties[vocab.UnitPrice] = input.UnitPrice.PrintIfAvailable();
            data.Properties[vocab.LineTotal] = input.LineTotal.PrintIfAvailable();
            data.Properties[vocab.ReceivedQty] = input.ReceivedQty.PrintIfAvailable();
            data.Properties[vocab.RejectedQty] = input.RejectedQty.PrintIfAvailable();
            data.Properties[vocab.StockedQty] = input.StockedQty.PrintIfAvailable();
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


