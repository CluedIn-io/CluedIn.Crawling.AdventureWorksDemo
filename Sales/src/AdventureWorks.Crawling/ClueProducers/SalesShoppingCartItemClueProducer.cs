using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Helpers;
using CluedIn.Crawling.AdventureWorksSales.Vocabularies;
using CluedIn.Crawling.AdventureWorksSales.Core.Models;
using CluedIn.Crawling.AdventureWorksSales.Core;
using CluedIn.Core;
using RuleConstants = CluedIn.Core.Constants.Validation.Rules;
using System.Linq;
using System;

namespace CluedIn.Crawling.AdventureWorksSales.ClueProducers
{
    public class SalesShoppingCartItemClueProducer : BaseClueProducer<SalesShoppingCartItem>
    {
        private readonly IClueFactory _factory;

        public SalesShoppingCartItemClueProducer(IClueFactory factory)
        {
            _factory = factory;
        }

        protected override Clue MakeClueImpl(SalesShoppingCartItem input, Guid id)
        {

            var clue = _factory.Create("/SalesShoppingCartItem", $"{input.ShoppingCartItemID}", id);

            var data = clue.Data.EntityData;



            data.Name = $"Cart Item {input.ShoppingCartItemID}";



            data.ModifiedDate = input.ModifiedDate.ParseAsDateTimeOffset(); 
            //add edges

            if (input.ProductID != null && !string.IsNullOrEmpty(input.ProductID.ToString()))
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Product, EntityEdgeType.Has, input.ProductID, input.ProductID.ToString());
            }

            if (!data.OutgoingEdges.Any())
            {
                _factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);
            }


            var vocab = new SalesShoppingCartItemVocabulary();

            data.Properties[vocab.ShoppingCartItemID] = input.ShoppingCartItemID.PrintIfAvailable();
            data.Properties[vocab.ShoppingCartID] = input.ShoppingCartID.PrintIfAvailable();
            data.Properties[vocab.Quantity] = input.Quantity.PrintIfAvailable();
            data.Properties[vocab.ProductID] = input.ProductID.PrintIfAvailable();
            data.Properties[vocab.DateCreated] = input.DateCreated.PrintIfAvailable();
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


