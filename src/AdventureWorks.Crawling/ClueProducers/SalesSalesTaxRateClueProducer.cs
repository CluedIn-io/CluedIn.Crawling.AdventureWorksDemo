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
public class SalesSalesTaxRateClueProducer : BaseClueProducer<SalesSalesTaxRate>
{
private readonly IClueFactory _factory;

public SalesSalesTaxRateClueProducer(IClueFactory factory)
							{
								_factory = factory;
							}

protected override Clue MakeClueImpl(SalesSalesTaxRate input, Guid id)
{

var clue = _factory.Create("/SalesSalesTaxRate", $"{input.Rowguid}", id);

							var data = clue.Data.EntityData;

							

data.Name = input.Name;

data.Codes.Add(new EntityCode("/SalesSalesTaxRate", AdventureWorksConstants.CodeOrigin, $"{input.SalesTaxRateID}"));

//add edges

if(input.StateProvinceID != null && !string.IsNullOrEmpty(input.StateProvinceID.ToString()))
{
_factory.CreateOutgoingEntityReference(clue, EntityType.Geography.State, EntityEdgeType.LocatedIn, input.StateProvinceID, input.StateProvinceID.ToString());
}

if (!data.OutgoingEdges.Any())
                          {
			                _factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);
                          }
							

var vocab = new SalesSalesTaxRateVocabulary();

data.Properties[vocab.SalesTaxRateID]            = input.SalesTaxRateID.PrintIfAvailable();
data.Properties[vocab.StateProvinceID]           = input.StateProvinceID.PrintIfAvailable();
data.Properties[vocab.TaxType]                   = input.TaxType.PrintIfAvailable();
data.Properties[vocab.TaxRate]                   = input.TaxRate.PrintIfAvailable();
data.Properties[vocab.Name]                      = input.Name.PrintIfAvailable();
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


