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
    public class ProductionProductDescriptionClueProducer : BaseClueProducer<ProductionProductDescription>
    {
        private readonly IClueFactory _factory;

        public ProductionProductDescriptionClueProducer(IClueFactory factory)
        {
            _factory = factory;
        }

        protected override Clue MakeClueImpl(ProductionProductDescription input, Guid id)
        {

            var clue = _factory.Create("/ProductionProductDescription", $"{input.Rowguid}", id);

            var data = clue.Data.EntityData;



            data.Name = $"Product Description {input.ProductDescriptionID}";

            data.Description = input.Description;

            data.Codes.Add(new EntityCode("/ProductionProductDescription", AdventureWorksProductionConstants.CodeOrigin, $"{input.ProductDescriptionID}"));

            data.ModifiedDate = input.ModifiedDate.ParseAsDateTimeOffset(); 
            //add edges


            if (!data.OutgoingEdges.Any())
            {
                _factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);
            }


            var vocab = new ProductionProductDescriptionVocabulary();

            data.Properties[vocab.ProductDescriptionID] = input.ProductDescriptionID.PrintIfAvailable();
            data.Properties[vocab.Description] = input.Description.PrintIfAvailable();
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


