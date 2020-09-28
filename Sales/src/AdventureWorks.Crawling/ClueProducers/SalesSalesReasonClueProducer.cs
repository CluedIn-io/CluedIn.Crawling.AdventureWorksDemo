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
public class SalesSalesReasonClueProducer : BaseClueProducer<SalesSalesReason>
{
private readonly IClueFactory _factory;

public SalesSalesReasonClueProducer(IClueFactory factory)
							{
								_factory = factory;
							}

protected override Clue MakeClueImpl(SalesSalesReason input, Guid id)
{

var clue = _factory.Create("/SalesSalesReason", $"{input.SalesReasonID}", id);

							var data = clue.Data.EntityData;

							

data.Name = input.Name;



data.ModifiedDate = input.ModifiedDate.ParseAsDateTimeOffset(); 
            //add edges


if (!data.OutgoingEdges.Any())
                          {
			                _factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);
                          }
							

var vocab = new SalesSalesReasonVocabulary();

data.Properties[vocab.SalesReasonID]             = input.SalesReasonID.PrintIfAvailable();
data.Properties[vocab.Name]                      = input.Name.PrintIfAvailable();
data.Properties[vocab.ReasonType]                = input.ReasonType.PrintIfAvailable();
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


