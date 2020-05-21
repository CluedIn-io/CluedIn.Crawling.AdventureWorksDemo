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
    public class SalesSalesOrderHeaderSalesReasonClueProducer : BaseClueProducer<SalesSalesOrderHeaderSalesReason>
    {
        private readonly IClueFactory _factory;

        public SalesSalesOrderHeaderSalesReasonClueProducer(IClueFactory factory)
        {
            _factory = factory;
        }

        protected override Clue MakeClueImpl(SalesSalesOrderHeaderSalesReason input, Guid id)
        {

            var clue = _factory.Create("/SalesSalesOrderHeaderSalesReason", $"{input.SalesOrderID}.{input.SalesReasonID}", id);

            var data = clue.Data.EntityData;



            data.Name = $"Sales Reason {input.SalesOrderID}.{input.SalesReasonID}";



            data.ModifiedDate = input.ModifiedDate.ParseAsDateTimeOffset(); 
            //add edges

            if (input.SalesOrderID != null && !string.IsNullOrEmpty(input.SalesOrderID.ToString()))
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Sales.Sale, EntityEdgeType.For, input.SalesOrderID, input.SalesOrderID.ToString());
            }
            if (input.SalesReasonID != null && !string.IsNullOrEmpty(input.SalesReasonID.ToString()))
            {
                _factory.CreateOutgoingEntityReference(clue, "/SalesSalesReason", EntityEdgeType.For, input.SalesReasonID, input.SalesReasonID.ToString());
            }

            if (!data.OutgoingEdges.Any())
            {
                _factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);
            }


            var vocab = new SalesSalesOrderHeaderSalesReasonVocabulary();

            data.Properties[vocab.SalesOrderID] = input.SalesOrderID.PrintIfAvailable();
            data.Properties[vocab.SalesReasonID] = input.SalesReasonID.PrintIfAvailable();
            data.Properties[vocab.ModifiedDate] = input.ModifiedDate.PrintIfAvailable();

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


