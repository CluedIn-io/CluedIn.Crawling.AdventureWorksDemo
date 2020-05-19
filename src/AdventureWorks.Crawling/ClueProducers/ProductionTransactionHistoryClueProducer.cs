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
public class ProductionTransactionHistoryClueProducer : BaseClueProducer<ProductionTransactionHistory>
{
private readonly IClueFactory _factory;

public ProductionTransactionHistoryClueProducer(IClueFactory factory)
							{
								_factory = factory;
							}

protected override Clue MakeClueImpl(ProductionTransactionHistory input, Guid id)
{

var clue = _factory.Create("/ProductionTransactionHistory", $"{input.TransactionID}", id);

							var data = clue.Data.EntityData;

							

//add edges

if(input.ProductID != null && !string.IsNullOrEmpty(input.ProductID.ToString()))
{
_factory.CreateOutgoingEntityReference(clue, "/ProductionProduct", EntityEdgeType.AttachedTo, input.ProductID, input.ProductID.ToString());
}

if (!data.OutgoingEdges.Any())
			                _factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);
							

var vocab = new ProductionTransactionHistoryVocabulary();

data.Properties[vocab.TransactionID]             = input.TransactionID.PrintIfAvailable();
data.Properties[vocab.ProductID]                 = input.ProductID.PrintIfAvailable();
data.Properties[vocab.ReferenceOrderID]          = input.ReferenceOrderID.PrintIfAvailable();
data.Properties[vocab.ReferenceOrderLineID]      = input.ReferenceOrderLineID.PrintIfAvailable();
data.Properties[vocab.TransactionDate]           = input.TransactionDate.PrintIfAvailable();
data.Properties[vocab.TransactionType]           = input.TransactionType.PrintIfAvailable();
data.Properties[vocab.Quantity]                  = input.Quantity.PrintIfAvailable();
data.Properties[vocab.ActualCost]                = input.ActualCost.PrintIfAvailable();
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


