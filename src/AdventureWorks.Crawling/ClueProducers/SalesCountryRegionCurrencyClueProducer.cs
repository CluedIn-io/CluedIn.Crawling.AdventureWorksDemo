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
    public class SalesCountryRegionCurrencyClueProducer : BaseClueProducer<SalesCountryRegionCurrency>
    {
        private readonly IClueFactory _factory;

        public SalesCountryRegionCurrencyClueProducer(IClueFactory factory)
        {
            _factory = factory;
        }

        protected override Clue MakeClueImpl(SalesCountryRegionCurrency input, Guid id)
        {

            var clue = _factory.Create("/SalesCountryRegionCurrency", $"{input.CountryRegionCode}.{input.CurrencyCode}", id);

            var data = clue.Data.EntityData;



            data.Name = $"Currency {input.CountryRegionCode} {input.CurrencyCode}";



            //add edges

            if (input.CountryRegionCode != null && !string.IsNullOrEmpty(input.CountryRegionCode.ToString()))
            {
                _factory.CreateOutgoingEntityReference(clue, "/PersonCountryRegion", EntityEdgeType.AttachedTo, input.CountryRegionCode, input.CountryRegionCode.ToString());
            }
            if (input.CurrencyCode != null && !string.IsNullOrEmpty(input.CurrencyCode.ToString()))
            {
                _factory.CreateOutgoingEntityReference(clue, "/SalesCurrency", EntityEdgeType.AttachedTo, input.CurrencyCode, input.CurrencyCode.ToString());
            }

            if (!data.OutgoingEdges.Any())
            {
                _factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);
            }


            var vocab = new SalesCountryRegionCurrencyVocabulary();

            data.Properties[vocab.CountryRegionCode] = input.CountryRegionCode.PrintIfAvailable();
            data.Properties[vocab.CurrencyCode] = input.CurrencyCode.PrintIfAvailable();
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


