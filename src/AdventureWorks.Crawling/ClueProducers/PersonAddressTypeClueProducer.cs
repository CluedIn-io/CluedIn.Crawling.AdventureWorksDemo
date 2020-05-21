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
public class PersonAddressTypeClueProducer : BaseClueProducer<PersonAddressType>
{
private readonly IClueFactory _factory;

public PersonAddressTypeClueProducer(IClueFactory factory)
							{
								_factory = factory;
							}

protected override Clue MakeClueImpl(PersonAddressType input, Guid id)
{

var clue = _factory.Create("/PersonAddressType", $"{input.Rowguid}", id);

							var data = clue.Data.EntityData;

							

data.Name = input.Name;

data.Codes.Add(new EntityCode("/PersonAddressType", AdventureWorksConstants.CodeOrigin, $"{input.AddressTypeID}"));

//add edges


if (!data.OutgoingEdges.Any())
                          {
			                _factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);
                          }
							

var vocab = new PersonAddressTypeVocabulary();

data.Properties[vocab.AddressTypeID]             = input.AddressTypeID.PrintIfAvailable();
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


