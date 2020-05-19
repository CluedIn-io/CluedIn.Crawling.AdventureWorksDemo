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
public class PurchasingProductVendorClueProducer : BaseClueProducer<PurchasingProductVendor>
{
private readonly IClueFactory _factory;

public PurchasingProductVendorClueProducer(IClueFactory factory)
							{
								_factory = factory;
							}

protected override Clue MakeClueImpl(PurchasingProductVendor input, Guid id)
{

var clue = _factory.Create("/PurchasingProductVendor", $"{input.ProductID}.{input.BusinessEntityID}", id);

							var data = clue.Data.EntityData;

							

//add edges

if(input.ProductID != null && !string.IsNullOrEmpty(input.ProductID.ToString()))
{
_factory.CreateOutgoingEntityReference(clue, "/ProductionProduct", EntityEdgeType.AttachedTo, input.ProductID, input.ProductID.ToString());
}
if(input.BusinessEntityID != null && !string.IsNullOrEmpty(input.BusinessEntityID.ToString()))
{
_factory.CreateOutgoingEntityReference(clue, "/PersonBusinessEntity", EntityEdgeType.AttachedTo, input.BusinessEntityID, input.BusinessEntityID.ToString());
}
if(input.UnitMeasureCode != null && !string.IsNullOrEmpty(input.UnitMeasureCode.ToString()))
{
_factory.CreateOutgoingEntityReference(clue, "/ProductionUnitMeasure", EntityEdgeType.AttachedTo, input.UnitMeasureCode, input.UnitMeasureCode.ToString());
}

if (!data.OutgoingEdges.Any())
			                _factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);
							

var vocab = new PurchasingProductVendorVocabulary();

data.Properties[vocab.ProductID]                 = input.ProductID.PrintIfAvailable();
data.Properties[vocab.BusinessEntityID]          = input.BusinessEntityID.PrintIfAvailable();
data.Properties[vocab.AverageLeadTime]           = input.AverageLeadTime.PrintIfAvailable();
data.Properties[vocab.StandardPrice]             = input.StandardPrice.PrintIfAvailable();
data.Properties[vocab.LastReceiptCost]           = input.LastReceiptCost.PrintIfAvailable();
data.Properties[vocab.LastReceiptDate]           = input.LastReceiptDate.PrintIfAvailable();
data.Properties[vocab.MinOrderQty]               = input.MinOrderQty.PrintIfAvailable();
data.Properties[vocab.MaxOrderQty]               = input.MaxOrderQty.PrintIfAvailable();
data.Properties[vocab.OnOrderQty]                = input.OnOrderQty.PrintIfAvailable();
data.Properties[vocab.UnitMeasureCode]           = input.UnitMeasureCode.PrintIfAvailable();
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


