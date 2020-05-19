using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Helpers;
using CluedIn.Crawling.AdventureWorks.Vocabularies;
using CluedIn.Crawling.AdventureWorks.Core.Models;
using CluedIn.Core;
using RuleConstants = CluedIn.Core.Constants.Validation.Rules;
using System.Linq;
using System;

namespace CluedIn.Crawling.AdventureWorks.ClueProducers
{
public class PersonStateProvinceClueProducer : BaseClueProducer<PersonStateProvince>
{
private readonly IClueFactory _factory;

public PersonStateProvinceClueProducer(IClueFactory factory)
							{
								_factory = factory;
							}

protected override Clue MakeClueImpl(PersonStateProvince input, Guid id)
{

var clue = _factory.Create("/PersonStateProvince", $"{input.StateProvinceID}", id);

							var data = clue.Data.EntityData;

							

//add edges

if(input.CountryRegionCode != null && !string.IsNullOrEmpty(input.CountryRegionCode.ToString()))
{
_factory.CreateOutgoingEntityReference(clue, "/PersonCountryRegion", EntityEdgeType.AttachedTo, input.CountryRegionCode, input.CountryRegionCode.ToString());
}
if(input.TerritoryID != null && !string.IsNullOrEmpty(input.TerritoryID.ToString()))
{
_factory.CreateOutgoingEntityReference(clue, "/SalesSalesTerritory", EntityEdgeType.AttachedTo, input.TerritoryID, input.TerritoryID.ToString());
}

if (!data.OutgoingEdges.Any())
			                _factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);
							

var vocab = new PersonStateProvinceVocabulary();

data.Properties[vocab.StateProvinceID]           = input.StateProvinceID.PrintIfAvailable();
data.Properties[vocab.StateProvinceCode]         = input.StateProvinceCode.PrintIfAvailable();
data.Properties[vocab.CountryRegionCode]         = input.CountryRegionCode.PrintIfAvailable();
data.Properties[vocab.IsOnlyStateProvinceFlag]   = input.IsOnlyStateProvinceFlag.PrintIfAvailable();
data.Properties[vocab.Name]                      = input.Name.PrintIfAvailable();
data.Properties[vocab.TerritoryID]               = input.TerritoryID.PrintIfAvailable();
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


