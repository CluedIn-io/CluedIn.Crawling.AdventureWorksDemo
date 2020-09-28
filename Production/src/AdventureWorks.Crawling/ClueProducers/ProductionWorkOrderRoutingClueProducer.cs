using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Helpers;
using CluedIn.Crawling.AdventureWorksProduction.Vocabularies;
using CluedIn.Crawling.AdventureWorksProduction.Core.Models;
using CluedIn.Crawling.AdventureWorksProduction.Core;
using CluedIn.Core;
using RuleConstants = CluedIn.Core.Constants.Validation.Rules;
using System.Linq;
using System;

namespace CluedIn.Crawling.AdventureWorksProduction.ClueProducers
{
    public class ProductionWorkOrderRoutingClueProducer : BaseClueProducer<ProductionWorkOrderRouting>
    {
        private readonly IClueFactory _factory;

        public ProductionWorkOrderRoutingClueProducer(IClueFactory factory)
        {
            _factory = factory;
        }

        protected override Clue MakeClueImpl(ProductionWorkOrderRouting input, Guid id)
        {

            var clue = _factory.Create("/ProductionWorkOrderRouting", $"{input.WorkOrderID}.{input.ProductID}.{input.OperationSequence}", id);

            var data = clue.Data.EntityData;



            data.Name = $"Work Order Routing for {input.WorkOrderID} {input.ProductID}";



            data.ModifiedDate = input.ModifiedDate.ParseAsDateTimeOffset(); 
            //add edges

            if (input.WorkOrderID != null && !string.IsNullOrEmpty(input.WorkOrderID.ToString()))
            {
                _factory.CreateOutgoingEntityReference(clue, "/ProductionWorkOrder", EntityEdgeType.AttachedTo, input.WorkOrderID, input.WorkOrderID.ToString());
            }
            if (input.LocationID != null && !string.IsNullOrEmpty(input.LocationID.ToString()))
            {
                _factory.CreateOutgoingEntityReference(clue, "/ProductionLocation", EntityEdgeType.LocatedIn, input.LocationID, input.LocationID.ToString());
            }

            if (!data.OutgoingEdges.Any())
            {
                _factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);
            }


            var vocab = new ProductionWorkOrderRoutingVocabulary();

            data.Properties[vocab.WorkOrderID] = input.WorkOrderID.PrintIfAvailable();
            data.Properties[vocab.ProductID] = input.ProductID.PrintIfAvailable();
            data.Properties[vocab.OperationSequence] = input.OperationSequence.PrintIfAvailable();
            data.Properties[vocab.LocationID] = input.LocationID.PrintIfAvailable();
            data.Properties[vocab.ScheduledStartDate] = input.ScheduledStartDate.PrintIfAvailable();
            data.Properties[vocab.ScheduledEndDate] = input.ScheduledEndDate.PrintIfAvailable();
            data.Properties[vocab.ActualStartDate] = input.ActualStartDate.PrintIfAvailable();
            data.Properties[vocab.ActualEndDate] = input.ActualEndDate.PrintIfAvailable();
            data.Properties[vocab.ActualResourceHrs] = input.ActualResourceHrs.PrintIfAvailable();
            data.Properties[vocab.PlannedCost] = input.PlannedCost.PrintIfAvailable();
            data.Properties[vocab.ActualCost] = input.ActualCost.PrintIfAvailable();
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


