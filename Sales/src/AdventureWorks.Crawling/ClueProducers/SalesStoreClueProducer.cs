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
public class SalesStoreClueProducer : BaseClueProducer<SalesStore>
{
private readonly IClueFactory _factory;

public SalesStoreClueProducer(IClueFactory factory)
							{
								_factory = factory;
							}

protected override Clue MakeClueImpl(SalesStore input, Guid id)
{

var clue = _factory.Create("/SalesStore", $"{input.Rowguid}", id);

							var data = clue.Data.EntityData;

							

data.Name = input.Name;

data.Codes.Add(new EntityCode("/SalesStore", AdventureWorksSalesConstants.CodeOrigin, $"{input.BusinessEntityID}"));

data.ModifiedDate = input.ModifiedDate.ParseAsDateTimeOffset(); 
            //add edges

if(input.BusinessEntityID != null && !string.IsNullOrEmpty(input.BusinessEntityID.ToString()))
{
_factory.CreateOutgoingEntityReference(clue, "/PersonBusinessEntity", EntityEdgeType.Has, input.BusinessEntityID, input.BusinessEntityID.ToString());
}
if(input.SalesPersonID != null && !string.IsNullOrEmpty(input.SalesPersonID.ToString()))
{
_factory.CreateOutgoingEntityReference(clue, "/SalesSalesPerson", EntityEdgeType.Has, input.SalesPersonID, input.SalesPersonID.ToString());
}

if (!data.OutgoingEdges.Any())
                          {
			                _factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);
                          }
							

var vocab = new SalesStoreVocabulary();

data.Properties[vocab.BusinessEntityID]          = input.BusinessEntityID.PrintIfAvailable();
data.Properties[vocab.Name]                      = input.Name.PrintIfAvailable();
data.Properties[vocab.SalesPersonID]             = input.SalesPersonID.PrintIfAvailable();
data.Properties[vocab.Demographics]              = input.Demographics.PrintIfAvailable();
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


