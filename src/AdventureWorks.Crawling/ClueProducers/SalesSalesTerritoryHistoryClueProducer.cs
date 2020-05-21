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
    public class SalesSalesTerritoryHistoryClueProducer : BaseClueProducer<SalesSalesTerritoryHistory>
    {
        private readonly IClueFactory _factory;

        public SalesSalesTerritoryHistoryClueProducer(IClueFactory factory)
        {
            _factory = factory;
        }

        protected override Clue MakeClueImpl(SalesSalesTerritoryHistory input, Guid id)
        {

            var clue = _factory.Create("/SalesSalesTerritoryHistory", $"{input.Rowguid}", id);

            var data = clue.Data.EntityData;



            data.Name = $"Territory for {input.BusinessEntityID} in {input.TerritoryID} starting {input.StartDate}";

            data.Codes.Add(new EntityCode("/SalesSalesTerritoryHistory", AdventureWorksConstants.CodeOrigin, $"{input.BusinessEntityID}.{input.TerritoryID}.{input.StartDate}"));

            data.ModifiedDate = input.ModifiedDate.ParseAsDateTimeOffset(); 
            //add edges

            if (input.BusinessEntityID != null && !string.IsNullOrEmpty(input.BusinessEntityID.ToString()))
            {
                _factory.CreateOutgoingEntityReference(clue, "/SalesSalesPerson", EntityEdgeType.For, input.BusinessEntityID, input.BusinessEntityID.ToString());
            }
            if (input.TerritoryID != null && !string.IsNullOrEmpty(input.TerritoryID.ToString()))
            {
                _factory.CreateOutgoingEntityReference(clue, "/SalesSalesTerritory", EntityEdgeType.LocatedIn, input.TerritoryID, input.TerritoryID.ToString());
            }

            if (!data.OutgoingEdges.Any())
            {
                _factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);
            }


            var vocab = new SalesSalesTerritoryHistoryVocabulary();

            data.Properties[vocab.BusinessEntityID] = input.BusinessEntityID.PrintIfAvailable();
            data.Properties[vocab.TerritoryID] = input.TerritoryID.PrintIfAvailable();
            data.Properties[vocab.StartDate] = input.StartDate.PrintIfAvailable();
            data.Properties[vocab.EndDate] = input.EndDate.PrintIfAvailable();
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


