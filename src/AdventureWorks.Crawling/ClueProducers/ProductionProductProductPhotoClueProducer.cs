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
    public class ProductionProductProductPhotoClueProducer : BaseClueProducer<ProductionProductProductPhoto>
    {
        private readonly IClueFactory _factory;

        public ProductionProductProductPhotoClueProducer(IClueFactory factory)
        {
            _factory = factory;
        }

        protected override Clue MakeClueImpl(ProductionProductProductPhoto input, Guid id)
        {

            var clue = _factory.Create("/ProductionProductProductPhoto", $"{input.ProductID}.{input.ProductPhotoID}", id);

            var data = clue.Data.EntityData;



            data.Name = $"Product Photo {input.ProductID} - {input.ProductPhotoID}";



            //add edges

            if (input.ProductID != null && !string.IsNullOrEmpty(input.ProductID.ToString()))
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Product, EntityEdgeType.AttachedTo, input.ProductID, input.ProductID.ToString());
            }
            if (input.ProductPhotoID != null && !string.IsNullOrEmpty(input.ProductPhotoID.ToString()))
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Images.Image, EntityEdgeType.AttachedTo, input.ProductPhotoID, input.ProductPhotoID.ToString());
            }

            if (!data.OutgoingEdges.Any())
            {
                _factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);
            }


            var vocab = new ProductionProductProductPhotoVocabulary();

            data.Properties[vocab.ProductID] = input.ProductID.PrintIfAvailable();
            data.Properties[vocab.ProductPhotoID] = input.ProductPhotoID.PrintIfAvailable();
            data.Properties[vocab.Primary] = input.Primary.PrintIfAvailable();
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


