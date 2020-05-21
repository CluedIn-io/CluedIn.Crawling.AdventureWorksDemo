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
public class PersonBusinessEntityClueProducer : BaseClueProducer<PersonBusinessEntity>
{
private readonly IClueFactory _factory;

public PersonBusinessEntityClueProducer(IClueFactory factory)
							{
								_factory = factory;
							}

protected override Clue MakeClueImpl(PersonBusinessEntity input, Guid id)
{

var clue = _factory.Create("/PersonBusinessEntity", $"{input.Rowguid}", id);

							var data = clue.Data.EntityData;

							

data.Name = $"BusinessEntity {input.BusinessEntityID}";

data.Codes.Add(new EntityCode("/PersonBusinessEntity", AdventureWorksConstants.CodeOrigin, $"{input.BusinessEntityID}"));

//add edges


if (!data.OutgoingEdges.Any())
                          {
			                _factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);
                          }
							

var vocab = new PersonBusinessEntityVocabulary();

data.Properties[vocab.BusinessEntityID]          = input.BusinessEntityID.PrintIfAvailable();
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


