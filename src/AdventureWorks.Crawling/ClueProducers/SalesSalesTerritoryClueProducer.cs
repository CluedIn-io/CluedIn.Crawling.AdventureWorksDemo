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
public class SalesSalesTerritoryClueProducer : BaseClueProducer<SalesSalesTerritory>
{
private readonly IClueFactory _factory;

public SalesSalesTerritoryClueProducer(IClueFactory factory)
							{
								_factory = factory;
							}

protected override Clue MakeClueImpl(SalesSalesTerritory input, Guid id)
{

var clue = _factory.Create("/SalesSalesTerritory", $"{input.Rowguid}", id);

							var data = clue.Data.EntityData;

							

data.Name = input.Name;

data.Codes.Add(new EntityCode("/SalesSalesTerritory", AdventureWorksConstants.CodeOrigin, $"{input.TerritoryID}"));

//add edges

if(input.CountryRegionCode != null && !string.IsNullOrEmpty(input.CountryRegionCode.ToString()))
{
_factory.CreateOutgoingEntityReference(clue, "/PersonCountryRegion", EntityEdgeType.LocatedIn, input.CountryRegionCode, input.CountryRegionCode.ToString());
}

if (!data.OutgoingEdges.Any())
                          {
			                _factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);
                          }
							

var vocab = new SalesSalesTerritoryVocabulary();

data.Properties[vocab.TerritoryID]               = input.TerritoryID.PrintIfAvailable();
data.Properties[vocab.Name]                      = input.Name.PrintIfAvailable();
data.Properties[vocab.CountryRegionCode]         = input.CountryRegionCode.PrintIfAvailable();
data.Properties[vocab.Group]                     = input.Group.PrintIfAvailable();
data.Properties[vocab.SalesYTD]                  = input.SalesYTD.PrintIfAvailable();
data.Properties[vocab.SalesLastYear]             = input.SalesLastYear.PrintIfAvailable();
data.Properties[vocab.CostYTD]                   = input.CostYTD.PrintIfAvailable();
data.Properties[vocab.CostLastYear]              = input.CostLastYear.PrintIfAvailable();
data.Properties[vocab.Rowguid]                   = input.Rowguid.PrintIfAvailable();
data.Properties[vocab.ModifiedDate]              = input.ModifiedDate.PrintIfAvailable();

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


