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
    public class ProductionProductReviewClueProducer : BaseClueProducer<ProductionProductReview>
    {
        private readonly IClueFactory _factory;

        public ProductionProductReviewClueProducer(IClueFactory factory)
        {
            _factory = factory;
        }

        protected override Clue MakeClueImpl(ProductionProductReview input, Guid id)
        {

            var clue = _factory.Create("/ProductionProductReview", $"{input.ProductReviewID}", id);

            var data = clue.Data.EntityData;



            data.Name = $"Review for {input.ProductID} from {input.ReviewerName} on {input.ReviewDate}";



            //add edges

            if (input.ProductID != null && !string.IsNullOrEmpty(input.ProductID.ToString()))
            {
                _factory.CreateOutgoingEntityReference(clue, "/ProductionProduct", EntityEdgeType.AttachedTo, input.ProductID, input.ProductID.ToString());
            }

            if (!data.OutgoingEdges.Any())
            {
                _factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);
            }


            var vocab = new ProductionProductReviewVocabulary();

            data.Properties[vocab.ProductReviewID] = input.ProductReviewID.PrintIfAvailable();
            data.Properties[vocab.ProductID] = input.ProductID.PrintIfAvailable();
            data.Properties[vocab.ReviewerName] = input.ReviewerName.PrintIfAvailable();
            data.Properties[vocab.ReviewDate] = input.ReviewDate.PrintIfAvailable();
            data.Properties[vocab.EmailAddress] = input.EmailAddress.PrintIfAvailable();
            data.Properties[vocab.Rating] = input.Rating.PrintIfAvailable();
            data.Properties[vocab.Comments] = input.Comments.PrintIfAvailable();
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


