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
    public class ProductionBillOfMaterialsClueProducer : BaseClueProducer<ProductionBillOfMaterials>
    {
        private readonly IClueFactory _factory;

        public ProductionBillOfMaterialsClueProducer(IClueFactory factory)
        {
            _factory = factory;
        }

        protected override Clue MakeClueImpl(ProductionBillOfMaterials input, Guid id)
        {

            var clue = _factory.Create("/ProductionBillOfMaterials", $"{input.BillOfMaterialsID}", id);

            var data = clue.Data.EntityData;



            data.Name = $"BillOfMaterials {input.StartDate}";



            data.ModifiedDate = input.ModifiedDate.ParseAsDateTimeOffset(); 
            //add edges

            if (input.ProductAssemblyID != null && !string.IsNullOrEmpty(input.ProductAssemblyID.ToString()))
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Product, EntityEdgeType.Has, input.ProductAssemblyID, input.ProductAssemblyID.ToString());
            }
            if (input.ComponentID != null && !string.IsNullOrEmpty(input.ComponentID.ToString()))
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Product, EntityEdgeType.Has, input.ComponentID, input.ComponentID.ToString());
            }
            if (input.UnitMeasureCode != null && !string.IsNullOrEmpty(input.UnitMeasureCode.ToString()))
            {
                _factory.CreateOutgoingEntityReference(clue, "/ProductionUnitMeasure", EntityEdgeType.Has, input.UnitMeasureCode, input.UnitMeasureCode.ToString());
            }

            if (!data.OutgoingEdges.Any())
            {
                _factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);
            }


            var vocab = new ProductionBillOfMaterialsVocabulary();

            data.Properties[vocab.BillOfMaterialsID] = input.BillOfMaterialsID.PrintIfAvailable();
            data.Properties[vocab.ProductAssemblyID] = input.ProductAssemblyID.PrintIfAvailable();
            data.Properties[vocab.ComponentID] = input.ComponentID.PrintIfAvailable();
            data.Properties[vocab.StartDate] = input.StartDate.PrintIfAvailable();
            data.Properties[vocab.EndDate] = input.EndDate.PrintIfAvailable();
            data.Properties[vocab.UnitMeasureCode] = input.UnitMeasureCode.PrintIfAvailable();
            data.Properties[vocab.BOMLevel] = input.BOMLevel.PrintIfAvailable();
            data.Properties[vocab.PerAssemblyQty] = input.PerAssemblyQty.PrintIfAvailable();
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


