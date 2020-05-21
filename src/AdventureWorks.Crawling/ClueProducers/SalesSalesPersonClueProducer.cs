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
    public class SalesSalesPersonClueProducer : BaseClueProducer<SalesSalesPerson>
    {
        private readonly IClueFactory _factory;

        public SalesSalesPersonClueProducer(IClueFactory factory)
        {
            _factory = factory;
        }

        protected override Clue MakeClueImpl(SalesSalesPerson input, Guid id)
        {

            var clue = _factory.Create("/SalesSalesPerson", $"{input.Rowguid}", id);

            var data = clue.Data.EntityData;



            data.Name = $"Sales Person {input.BusinessEntityID}";

            data.Codes.Add(new EntityCode("/SalesSalesPerson", AdventureWorksConstants.CodeOrigin, $"{input.BusinessEntityID}"));

            //add edges

            if (input.BusinessEntityID != null && !string.IsNullOrEmpty(input.BusinessEntityID.ToString()))
            {
                _factory.CreateOutgoingEntityReference(clue, "/HumanResourcesEmployee", EntityEdgeType.AttachedTo, input.BusinessEntityID, input.BusinessEntityID.ToString());
            }
            if (input.TerritoryID != null && !string.IsNullOrEmpty(input.TerritoryID.ToString()))
            {
                _factory.CreateOutgoingEntityReference(clue, "/SalesSalesTerritory", EntityEdgeType.AttachedTo, input.TerritoryID, input.TerritoryID.ToString());
            }

            if (!data.OutgoingEdges.Any())
            {
                _factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);
            }


            var vocab = new SalesSalesPersonVocabulary();

            data.Properties[vocab.BusinessEntityID] = input.BusinessEntityID.PrintIfAvailable();
            data.Properties[vocab.TerritoryID] = input.TerritoryID.PrintIfAvailable();
            data.Properties[vocab.SalesQuota] = input.SalesQuota.PrintIfAvailable();
            data.Properties[vocab.Bonus] = input.Bonus.PrintIfAvailable();
            data.Properties[vocab.CommissionPct] = input.CommissionPct.PrintIfAvailable();
            data.Properties[vocab.SalesYTD] = input.SalesYTD.PrintIfAvailable();
            data.Properties[vocab.SalesLastYear] = input.SalesLastYear.PrintIfAvailable();
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


