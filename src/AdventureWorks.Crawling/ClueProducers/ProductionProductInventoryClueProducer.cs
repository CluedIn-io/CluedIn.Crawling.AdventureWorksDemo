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
    public class ProductionProductInventoryClueProducer : BaseClueProducer<ProductionProductInventory>
    {
        private readonly IClueFactory _factory;

        public ProductionProductInventoryClueProducer(IClueFactory factory)
        {
            _factory = factory;
        }

        protected override Clue MakeClueImpl(ProductionProductInventory input, Guid id)
        {

            var clue = _factory.Create("/ProductionProductInventory", $"{input.Rowguid}", id);

            var data = clue.Data.EntityData;



            data.Name = $"Product Inventory {input.ProductID}";

            data.Codes.Add(new EntityCode("/ProductionProductInventory", AdventureWorksConstants.CodeOrigin, $"{input.ProductID}.{input.LocationID}"));

            //add edges

            if (input.ProductID != null && !string.IsNullOrEmpty(input.ProductID.ToString()))
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Product, EntityEdgeType.For, input.ProductID, input.ProductID.ToString());
            }
            if (input.LocationID != null && !string.IsNullOrEmpty(input.LocationID.ToString()))
            {
                _factory.CreateOutgoingEntityReference(clue, "/ProductionLocation", EntityEdgeType.LocatedIn, input.LocationID, input.LocationID.ToString());
            }

            if (!data.OutgoingEdges.Any())
            {
                _factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);
            }


            var vocab = new ProductionProductInventoryVocabulary();

            data.Properties[vocab.ProductID] = input.ProductID.PrintIfAvailable();
            data.Properties[vocab.LocationID] = input.LocationID.PrintIfAvailable();
            data.Properties[vocab.Shelf] = input.Shelf.PrintIfAvailable();
            data.Properties[vocab.Bin] = input.Bin.PrintIfAvailable();
            data.Properties[vocab.Quantity] = input.Quantity.PrintIfAvailable();
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


