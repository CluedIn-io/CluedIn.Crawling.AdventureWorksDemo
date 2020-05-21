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
    public class ProductionProductSubcategoryClueProducer : BaseClueProducer<ProductionProductSubcategory>
    {
        private readonly IClueFactory _factory;

        public ProductionProductSubcategoryClueProducer(IClueFactory factory)
        {
            _factory = factory;
        }

        protected override Clue MakeClueImpl(ProductionProductSubcategory input, Guid id)
        {

            var clue = _factory.Create("/ProductionProductSubcategory", $"{input.Rowguid}", id);

            var data = clue.Data.EntityData;



            data.Name = input.Name;

            data.Codes.Add(new EntityCode("/ProductionProductSubcategory", AdventureWorksConstants.CodeOrigin, $"{input.ProductSubcategoryID}"));

            //add edges

            if (input.ProductCategoryID != null && !string.IsNullOrEmpty(input.ProductCategoryID.ToString()))
            {
                _factory.CreateOutgoingEntityReference(clue, "/ProductionProductCategory", EntityEdgeType.AttachedTo, input.ProductCategoryID, input.ProductCategoryID.ToString());
            }

            if (!data.OutgoingEdges.Any())
            {
                _factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);
            }


            var vocab = new ProductionProductSubcategoryVocabulary();

            data.Properties[vocab.ProductSubcategoryID] = input.ProductSubcategoryID.PrintIfAvailable();
            data.Properties[vocab.ProductCategoryID] = input.ProductCategoryID.PrintIfAvailable();
            data.Properties[vocab.Name] = input.Name.PrintIfAvailable();
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


