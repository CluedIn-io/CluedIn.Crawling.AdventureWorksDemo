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
    public class ProductionProductListPriceHistoryClueProducer : BaseClueProducer<ProductionProductListPriceHistory>
    {
        private readonly IClueFactory _factory;

        public ProductionProductListPriceHistoryClueProducer(IClueFactory factory)
        {
            _factory = factory;
        }

        protected override Clue MakeClueImpl(ProductionProductListPriceHistory input, Guid id)
        {

            var clue = _factory.Create("/ProductionProductListPriceHistory", $"{input.ProductID}.{input.StartDate}", id);

            var data = clue.Data.EntityData;



            data.Name = $"Product List Price History {input.ProductID}";



            //add edges

            if (input.ProductID != null && !string.IsNullOrEmpty(input.ProductID.ToString()))
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Product, EntityEdgeType.For, input.ProductID, input.ProductID.ToString());
            }

            if (!data.OutgoingEdges.Any())
            {
                _factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);
            }


            var vocab = new ProductionProductListPriceHistoryVocabulary();

            data.Properties[vocab.ProductID] = input.ProductID.PrintIfAvailable();
            data.Properties[vocab.StartDate] = input.StartDate.PrintIfAvailable();
            data.Properties[vocab.EndDate] = input.EndDate.PrintIfAvailable();
            data.Properties[vocab.ListPrice] = input.ListPrice.PrintIfAvailable();
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


