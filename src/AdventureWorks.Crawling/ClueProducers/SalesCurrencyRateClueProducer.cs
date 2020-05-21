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
    public class SalesCurrencyRateClueProducer : BaseClueProducer<SalesCurrencyRate>
    {
        private readonly IClueFactory _factory;

        public SalesCurrencyRateClueProducer(IClueFactory factory)
        {
            _factory = factory;
        }

        protected override Clue MakeClueImpl(SalesCurrencyRate input, Guid id)
        {

            var clue = _factory.Create("/SalesCurrencyRate", $"{input.CurrencyRateID}", id);

            var data = clue.Data.EntityData;



            data.Name = $"Rate {input.FromCurrencyCode} to {input.ToCurrencyCode} on {input.CurrencyRateDate}";



            //add edges

            if (input.FromCurrencyCode != null && !string.IsNullOrEmpty(input.FromCurrencyCode.ToString()))
            {
                _factory.CreateOutgoingEntityReference(clue, "/SalesCurrency", EntityEdgeType.AttachedTo, input.FromCurrencyCode, input.FromCurrencyCode.ToString());
            }
            if (input.ToCurrencyCode != null && !string.IsNullOrEmpty(input.ToCurrencyCode.ToString()))
            {
                _factory.CreateOutgoingEntityReference(clue, "/SalesCurrency", EntityEdgeType.AttachedTo, input.ToCurrencyCode, input.ToCurrencyCode.ToString());
            }

            if (!data.OutgoingEdges.Any())
            {
                _factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);
            }


            var vocab = new SalesCurrencyRateVocabulary();

            data.Properties[vocab.CurrencyRateID] = input.CurrencyRateID.PrintIfAvailable();
            data.Properties[vocab.CurrencyRateDate] = input.CurrencyRateDate.PrintIfAvailable();
            data.Properties[vocab.FromCurrencyCode] = input.FromCurrencyCode.PrintIfAvailable();
            data.Properties[vocab.ToCurrencyCode] = input.ToCurrencyCode.PrintIfAvailable();
            data.Properties[vocab.AverageRate] = input.AverageRate.PrintIfAvailable();
            data.Properties[vocab.EndOfDayRate] = input.EndOfDayRate.PrintIfAvailable();
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


