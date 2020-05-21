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
    public class ProductionWorkOrderClueProducer : BaseClueProducer<ProductionWorkOrder>
    {
        private readonly IClueFactory _factory;

        public ProductionWorkOrderClueProducer(IClueFactory factory)
        {
            _factory = factory;
        }

        protected override Clue MakeClueImpl(ProductionWorkOrder input, Guid id)
        {

            var clue = _factory.Create("/ProductionWorkOrder", $"{input.WorkOrderID}", id);

            var data = clue.Data.EntityData;



            data.Name = $"Work Order {input.WorkOrderID}";



            //add edges

            if (input.ProductID != null && !string.IsNullOrEmpty(input.ProductID.ToString()))
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Product, EntityEdgeType.AttachedTo, input.ProductID, input.ProductID.ToString());
            }
            if (input.ScrapReasonID != null && !string.IsNullOrEmpty(input.ScrapReasonID.ToString()))
            {
                _factory.CreateOutgoingEntityReference(clue, "/ProductionScrapReason", EntityEdgeType.AttachedTo, input.ScrapReasonID, input.ScrapReasonID.ToString());
            }

            if (!data.OutgoingEdges.Any())
            {
                _factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);
            }


            var vocab = new ProductionWorkOrderVocabulary();

            data.Properties[vocab.WorkOrderID] = input.WorkOrderID.PrintIfAvailable();
            data.Properties[vocab.ProductID] = input.ProductID.PrintIfAvailable();
            data.Properties[vocab.OrderQty] = input.OrderQty.PrintIfAvailable();
            data.Properties[vocab.StockedQty] = input.StockedQty.PrintIfAvailable();
            data.Properties[vocab.ScrappedQty] = input.ScrappedQty.PrintIfAvailable();
            data.Properties[vocab.StartDate] = input.StartDate.PrintIfAvailable();
            data.Properties[vocab.EndDate] = input.EndDate.PrintIfAvailable();
            data.Properties[vocab.DueDate] = input.DueDate.PrintIfAvailable();
            data.Properties[vocab.ScrapReasonID] = input.ScrapReasonID.PrintIfAvailable();
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


