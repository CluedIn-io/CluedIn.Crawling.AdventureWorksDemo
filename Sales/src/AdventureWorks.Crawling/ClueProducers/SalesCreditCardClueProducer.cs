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
    public class SalesCreditCardClueProducer : BaseClueProducer<SalesCreditCard>
    {
        private readonly IClueFactory _factory;

        public SalesCreditCardClueProducer(IClueFactory factory)
        {
            _factory = factory;
        }

        protected override Clue MakeClueImpl(SalesCreditCard input, Guid id)
        {

            var clue = _factory.Create(EntityType.Payment.Card.CreditCard, $"{input.CreditCardID}", id);

            var data = clue.Data.EntityData;



            data.Name = $"{input.CardNumber}";


            data.ModifiedDate = input.ModifiedDate.ParseAsDateTimeOffset(); 
            //add edges


            if (!data.OutgoingEdges.Any())
            {
                _factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);
            }


            var vocab = new SalesCreditCardVocabulary();

            data.Properties[vocab.CreditCardID] = input.CreditCardID.PrintIfAvailable();
            data.Properties[vocab.CardType] = input.CardType.PrintIfAvailable();
            data.Properties[vocab.CardNumber] = input.CardNumber.PrintIfAvailable();
            data.Properties[vocab.ExpMonth] = input.ExpMonth.PrintIfAvailable();
            data.Properties[vocab.ExpYear] = input.ExpYear.PrintIfAvailable();
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


