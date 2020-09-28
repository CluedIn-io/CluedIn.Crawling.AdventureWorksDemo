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
    public class SalesSpecialOfferProductClueProducer : BaseClueProducer<SalesSpecialOfferProduct>
    {
        private readonly IClueFactory _factory;

        public SalesSpecialOfferProductClueProducer(IClueFactory factory)
        {
            _factory = factory;
        }

        protected override Clue MakeClueImpl(SalesSpecialOfferProduct input, Guid id)
        {

            var clue = _factory.Create("/SalesSpecialOfferProduct", $"{input.Rowguid}", id);

            var data = clue.Data.EntityData;



            data.Name = $"Special Offer {input.SpecialOfferID} for {input.ProductID}";

            data.Codes.Add(new EntityCode("/SalesSpecialOfferProduct", AdventureWorksSalesConstants.CodeOrigin, $"{input.SpecialOfferID}.{input.ProductID}"));

            data.ModifiedDate = input.ModifiedDate.ParseAsDateTimeOffset(); 
            //add edges

            if (input.SpecialOfferID != null && !string.IsNullOrEmpty(input.SpecialOfferID.ToString()))
            {
                _factory.CreateOutgoingEntityReference(clue, "/SalesSpecialOffer", EntityEdgeType.For, input.SpecialOfferID, input.SpecialOfferID.ToString());
            }
            if (input.ProductID != null && !string.IsNullOrEmpty(input.ProductID.ToString()))
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Product, EntityEdgeType.For, input.ProductID, input.ProductID.ToString());
            }

            if (!data.OutgoingEdges.Any())
            {
                _factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);
            }


            var vocab = new SalesSpecialOfferProductVocabulary();

            data.Properties[vocab.SpecialOfferID] = input.SpecialOfferID.PrintIfAvailable();
            data.Properties[vocab.ProductID] = input.ProductID.PrintIfAvailable();
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

