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
    public class ProductionProductPhotoClueProducer : BaseClueProducer<ProductionProductPhoto>
    {
        private readonly IClueFactory _factory;

        public ProductionProductPhotoClueProducer(IClueFactory factory)
        {
            _factory = factory;
        }

        protected override Clue MakeClueImpl(ProductionProductPhoto input, Guid id)
        {

            var clue = _factory.Create(EntityType.Images.Image, $"{input.ProductPhotoID}", id);

            var data = clue.Data.EntityData;



            data.Name = $"Photo for {input.ProductPhotoID} {input.ThumbNailPhoto}";



            data.ModifiedDate = input.ModifiedDate.ParseAsDateTimeOffset(); 
            //add edges


            if (!data.OutgoingEdges.Any())
            {
                _factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);
            }


            var vocab = new ProductionProductPhotoVocabulary();

            data.Properties[vocab.ProductPhotoID] = input.ProductPhotoID.PrintIfAvailable();
            data.Properties[vocab.ThumbNailPhoto] = input.ThumbNailPhoto.PrintIfAvailable();
            data.Properties[vocab.ThumbnailPhotoFileName] = input.ThumbnailPhotoFileName.PrintIfAvailable();
            data.Properties[vocab.LargePhoto] = input.LargePhoto.PrintIfAvailable();
            data.Properties[vocab.LargePhotoFileName] = input.LargePhotoFileName.PrintIfAvailable();
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


