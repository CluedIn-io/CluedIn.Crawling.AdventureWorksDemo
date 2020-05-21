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
    public class SalesSpecialOfferClueProducer : BaseClueProducer<SalesSpecialOffer>
    {
        private readonly IClueFactory _factory;

        public SalesSpecialOfferClueProducer(IClueFactory factory)
        {
            _factory = factory;
        }

        protected override Clue MakeClueImpl(SalesSpecialOffer input, Guid id)
        {

            var clue = _factory.Create("/SalesSpecialOffer", $"{input.Rowguid}", id);

            var data = clue.Data.EntityData;



            data.Name = $"Special Offer: {input.Description}";

            data.Codes.Add(new EntityCode("/SalesSpecialOffer", AdventureWorksConstants.CodeOrigin, $"{input.SpecialOfferID}"));

            data.ModifiedDate = input.ModifiedDate.ParseAsDateTimeOffset(); 
            //add edges


            if (!data.OutgoingEdges.Any())
            {
                _factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);
            }


            var vocab = new SalesSpecialOfferVocabulary();

            data.Properties[vocab.SpecialOfferID] = input.SpecialOfferID.PrintIfAvailable();
            data.Properties[vocab.Description] = input.Description.PrintIfAvailable();
            data.Properties[vocab.DiscountPct] = input.DiscountPct.PrintIfAvailable();
            data.Properties[vocab.Type] = input.Type.PrintIfAvailable();
            data.Properties[vocab.Category] = input.Category.PrintIfAvailable();
            data.Properties[vocab.StartDate] = input.StartDate.PrintIfAvailable();
            data.Properties[vocab.EndDate] = input.EndDate.PrintIfAvailable();
            data.Properties[vocab.MinQty] = input.MinQty.PrintIfAvailable();
            data.Properties[vocab.MaxQty] = input.MaxQty.PrintIfAvailable();
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


