using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Helpers;
using CluedIn.Crawling.AdventureWorksProduction.Vocabularies;
using CluedIn.Crawling.AdventureWorksProduction.Core.Models;
using CluedIn.Crawling.AdventureWorksProduction.Core;
using CluedIn.Core;
using RuleConstants = CluedIn.Core.Constants.Validation.Rules;
using System.Linq;
using System;

namespace CluedIn.Crawling.AdventureWorksProduction.ClueProducers
{
public class ProductionProductClueProducer : BaseClueProducer<ProductionProduct>
{
private readonly IClueFactory _factory;

public ProductionProductClueProducer(IClueFactory factory)
							{
								_factory = factory;
							}

protected override Clue MakeClueImpl(ProductionProduct input, Guid id)
{

var clue = _factory.Create(EntityType.Product, $"{input.Rowguid}", id);

							var data = clue.Data.EntityData;

							

data.Name = input.Name;

data.Codes.Add(new EntityCode(EntityType.Product, AdventureWorksProductionConstants.CodeOrigin, $"{input.ProductID}"));

data.ModifiedDate = input.ModifiedDate.ParseAsDateTimeOffset(); 
            //add edges

if(input.SizeUnitMeasureCode != null && !string.IsNullOrEmpty(input.SizeUnitMeasureCode.ToString()))
{
_factory.CreateOutgoingEntityReference(clue, "/ProductionUnitMeasure", EntityEdgeType.Has, input.SizeUnitMeasureCode, input.SizeUnitMeasureCode.ToString());
}
if(input.WeightUnitMeasureCode != null && !string.IsNullOrEmpty(input.WeightUnitMeasureCode.ToString()))
{
_factory.CreateOutgoingEntityReference(clue, "/ProductionUnitMeasure", EntityEdgeType.Has, input.WeightUnitMeasureCode, input.WeightUnitMeasureCode.ToString());
}
if(input.ProductSubcategoryID != null && !string.IsNullOrEmpty(input.ProductSubcategoryID.ToString()))
{
_factory.CreateOutgoingEntityReference(clue, "/ProductionProductSubcategory", EntityEdgeType.PartOf, input.ProductSubcategoryID, input.ProductSubcategoryID.ToString());
}
if(input.ProductModelID != null && !string.IsNullOrEmpty(input.ProductModelID.ToString()))
{
_factory.CreateOutgoingEntityReference(clue, "/ProductionProductModel", EntityEdgeType.IsType, input.ProductModelID, input.ProductModelID.ToString());
}

if (!data.OutgoingEdges.Any())
                          {
			                _factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);
                          }
							

var vocab = new ProductionProductVocabulary();

data.Properties[vocab.ProductID]                 = input.ProductID.PrintIfAvailable();
data.Properties[vocab.Name]                      = input.Name.PrintIfAvailable();
data.Properties[vocab.ProductNumber]             = input.ProductNumber.PrintIfAvailable();
data.Properties[vocab.MakeFlag]                  = input.MakeFlag.PrintIfAvailable();
data.Properties[vocab.FinishedGoodsFlag]         = input.FinishedGoodsFlag.PrintIfAvailable();
data.Properties[vocab.Color]                     = input.Color.PrintIfAvailable();
data.Properties[vocab.SafetyStockLevel]          = input.SafetyStockLevel.PrintIfAvailable();
data.Properties[vocab.ReorderPoint]              = input.ReorderPoint.PrintIfAvailable();
data.Properties[vocab.StandardCost]              = input.StandardCost.PrintIfAvailable();
data.Properties[vocab.ListPrice]                 = input.ListPrice.PrintIfAvailable();
data.Properties[vocab.Size]                      = input.Size.PrintIfAvailable();
data.Properties[vocab.SizeUnitMeasureCode]       = input.SizeUnitMeasureCode.PrintIfAvailable();
data.Properties[vocab.WeightUnitMeasureCode]     = input.WeightUnitMeasureCode.PrintIfAvailable();
data.Properties[vocab.Weight]                    = input.Weight.PrintIfAvailable();
data.Properties[vocab.DaysToManufacture]         = input.DaysToManufacture.PrintIfAvailable();
data.Properties[vocab.ProductLine]               = input.ProductLine.PrintIfAvailable();
data.Properties[vocab.Class]                     = input.Class.PrintIfAvailable();
data.Properties[vocab.Style]                     = input.Style.PrintIfAvailable();
data.Properties[vocab.ProductSubcategoryID]      = input.ProductSubcategoryID.PrintIfAvailable();
data.Properties[vocab.ProductModelID]            = input.ProductModelID.PrintIfAvailable();
data.Properties[vocab.SellStartDate]             = input.SellStartDate.PrintIfAvailable();
data.Properties[vocab.SellEndDate]               = input.SellEndDate.PrintIfAvailable();
data.Properties[vocab.DiscontinuedDate]          = input.DiscontinuedDate.PrintIfAvailable();
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


