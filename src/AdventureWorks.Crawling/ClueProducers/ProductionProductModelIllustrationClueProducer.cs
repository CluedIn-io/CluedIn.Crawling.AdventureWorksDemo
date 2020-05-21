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
    public class ProductionProductModelIllustrationClueProducer : BaseClueProducer<ProductionProductModelIllustration>
    {
        private readonly IClueFactory _factory;

        public ProductionProductModelIllustrationClueProducer(IClueFactory factory)
        {
            _factory = factory;
        }

        protected override Clue MakeClueImpl(ProductionProductModelIllustration input, Guid id)
        {

            var clue = _factory.Create("/ProductionProductModelIllustration", $"{input.ProductModelID}.{input.IllustrationID}", id);

            var data = clue.Data.EntityData;



            data.Name = $"Product Model Illustration {input.ProductModelID}";



            //add edges

            if (input.ProductModelID != null && !string.IsNullOrEmpty(input.ProductModelID.ToString()))
            {
                _factory.CreateOutgoingEntityReference(clue, "/ProductionProductModel", EntityEdgeType.AttachedTo, input.ProductModelID, input.ProductModelID.ToString());
            }
            if (input.IllustrationID != null && !string.IsNullOrEmpty(input.IllustrationID.ToString()))
            {
                _factory.CreateOutgoingEntityReference(clue, "/ProductionIllustration", EntityEdgeType.AttachedTo, input.IllustrationID, input.IllustrationID.ToString());
            }

            if (!data.OutgoingEdges.Any())
            {
                _factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);
            }


            var vocab = new ProductionProductModelIllustrationVocabulary();

            data.Properties[vocab.ProductModelID] = input.ProductModelID.PrintIfAvailable();
            data.Properties[vocab.IllustrationID] = input.IllustrationID.PrintIfAvailable();
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


