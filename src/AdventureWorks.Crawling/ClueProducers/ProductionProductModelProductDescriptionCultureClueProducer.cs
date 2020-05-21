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
    public class ProductionProductModelProductDescriptionCultureClueProducer : BaseClueProducer<ProductionProductModelProductDescriptionCulture>
    {
        private readonly IClueFactory _factory;

        public ProductionProductModelProductDescriptionCultureClueProducer(IClueFactory factory)
        {
            _factory = factory;
        }

        protected override Clue MakeClueImpl(ProductionProductModelProductDescriptionCulture input, Guid id)
        {

            var clue = _factory.Create("/ProductionProductModelProductDescriptionCulture", $"{input.ProductModelID}.{input.ProductDescriptionID}.{input.CultureID}", id);

            var data = clue.Data.EntityData;



            data.Name = $"Product Model Product Description Culture {input.ProductModelID}";



            //add edges

            if (input.ProductModelID != null && !string.IsNullOrEmpty(input.ProductModelID.ToString()))
            {
                _factory.CreateOutgoingEntityReference(clue, "/ProductionProductModel", EntityEdgeType.AttachedTo, input.ProductModelID, input.ProductModelID.ToString());
            }
            if (input.ProductDescriptionID != null && !string.IsNullOrEmpty(input.ProductDescriptionID.ToString()))
            {
                _factory.CreateOutgoingEntityReference(clue, "/ProductionProductDescription", EntityEdgeType.AttachedTo, input.ProductDescriptionID, input.ProductDescriptionID.ToString());
            }
            if (input.CultureID != null && !string.IsNullOrEmpty(input.CultureID.ToString()))
            {
                _factory.CreateOutgoingEntityReference(clue, "/ProductionCulture", EntityEdgeType.AttachedTo, input.CultureID, input.CultureID.ToString());
            }

            if (!data.OutgoingEdges.Any())
            {
                _factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);
            }


            var vocab = new ProductionProductModelProductDescriptionCultureVocabulary();

            data.Properties[vocab.ProductModelID] = input.ProductModelID.PrintIfAvailable();
            data.Properties[vocab.ProductDescriptionID] = input.ProductDescriptionID.PrintIfAvailable();
            data.Properties[vocab.CultureID] = input.CultureID.PrintIfAvailable();
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


