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
public class PersonBusinessEntityContactClueProducer : BaseClueProducer<PersonBusinessEntityContact>
{
private readonly IClueFactory _factory;

public PersonBusinessEntityContactClueProducer(IClueFactory factory)
							{
								_factory = factory;
							}

protected override Clue MakeClueImpl(PersonBusinessEntityContact input, Guid id)
{

var clue = _factory.Create("/PersonBusinessEntityContact", $"{input.BusinessEntityID}.{input.PersonID}.{input.ContactTypeID}", id);

							var data = clue.Data.EntityData;

							

//add edges

if(input.BusinessEntityID != null && !string.IsNullOrEmpty(input.BusinessEntityID.ToString()))
{
_factory.CreateOutgoingEntityReference(clue, "/PersonBusinessEntity", EntityEdgeType.AttachedTo, input.BusinessEntityID, input.BusinessEntityID.ToString());
}
if(input.PersonID != null && !string.IsNullOrEmpty(input.PersonID.ToString()))
{
_factory.CreateOutgoingEntityReference(clue, "/PersonBusinessEntity", EntityEdgeType.AttachedTo, input.PersonID, input.PersonID.ToString());
}
if(input.ContactTypeID != null && !string.IsNullOrEmpty(input.ContactTypeID.ToString()))
{
_factory.CreateOutgoingEntityReference(clue, "/PersonContactType", EntityEdgeType.AttachedTo, input.ContactTypeID, input.ContactTypeID.ToString());
}

if (!data.OutgoingEdges.Any())
			                _factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);
							

var vocab = new PersonBusinessEntityContactVocabulary();

data.Properties[vocab.BusinessEntityID]          = input.BusinessEntityID.PrintIfAvailable();
data.Properties[vocab.PersonID]                  = input.PersonID.PrintIfAvailable();
data.Properties[vocab.ContactTypeID]             = input.ContactTypeID.PrintIfAvailable();
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


