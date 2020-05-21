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
    public class SalesSalesPersonQuotaHistoryClueProducer : BaseClueProducer<SalesSalesPersonQuotaHistory>
    {
        private readonly IClueFactory _factory;

        public SalesSalesPersonQuotaHistoryClueProducer(IClueFactory factory)
        {
            _factory = factory;
        }

        protected override Clue MakeClueImpl(SalesSalesPersonQuotaHistory input, Guid id)
        {

            var clue = _factory.Create("/SalesSalesPersonQuotaHistory", $"{input.Rowguid}", id);

            var data = clue.Data.EntityData;



            data.Name = $"Quota History {input.BusinessEntityID}.{input.QuotaDate}";

            data.Codes.Add(new EntityCode("/SalesSalesPersonQuotaHistory", AdventureWorksConstants.CodeOrigin, $"{input.BusinessEntityID}.{input.QuotaDate}"));

            //add edges

            if (input.BusinessEntityID != null && !string.IsNullOrEmpty(input.BusinessEntityID.ToString()))
            {
                _factory.CreateOutgoingEntityReference(clue, "/SalesSalesPerson", EntityEdgeType.For, input.BusinessEntityID, input.BusinessEntityID.ToString());
            }

            if (!data.OutgoingEdges.Any())
            {
                _factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);
            }


            var vocab = new SalesSalesPersonQuotaHistoryVocabulary();

            data.Properties[vocab.BusinessEntityID] = input.BusinessEntityID.PrintIfAvailable();
            data.Properties[vocab.QuotaDate] = input.QuotaDate.PrintIfAvailable();
            data.Properties[vocab.SalesQuota] = input.SalesQuota.PrintIfAvailable();
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


