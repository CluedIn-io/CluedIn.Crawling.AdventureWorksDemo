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
    public class PurchasingPurchaseOrderHeaderClueProducer : BaseClueProducer<PurchasingPurchaseOrderHeader>
    {
        private readonly IClueFactory _factory;

        public PurchasingPurchaseOrderHeaderClueProducer(IClueFactory factory)
        {
            _factory = factory;
        }

        protected override Clue MakeClueImpl(PurchasingPurchaseOrderHeader input, Guid id)
        {

            var clue = _factory.Create(EntityType.Sales.Order, $"{input.PurchaseOrderID}", id);

            var data = clue.Data.EntityData;



            data.Name = $"Purchase Order {input.PurchaseOrderID}";



            data.ModifiedDate = input.ModifiedDate.ParseAsDateTimeOffset(); 
            //add edges

            if (input.EmployeeID != null && !string.IsNullOrEmpty(input.EmployeeID.ToString()))
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.Author, input.EmployeeID, input.EmployeeID.ToString());
            }
            if (input.VendorID != null && !string.IsNullOrEmpty(input.VendorID.ToString()))
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Organization, "From", input.VendorID, input.VendorID.ToString());
            }
            if (input.ShipMethodID != null && !string.IsNullOrEmpty(input.ShipMethodID.ToString()))
            {
                _factory.CreateOutgoingEntityReference(clue, "/PurchasingShipMethod", "With", input.ShipMethodID, input.ShipMethodID.ToString());
            }

            if (!data.OutgoingEdges.Any())
            {
                _factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);
            }


            var vocab = new PurchasingPurchaseOrderHeaderVocabulary();

            data.Properties[vocab.PurchaseOrderID] = input.PurchaseOrderID.PrintIfAvailable();
            data.Properties[vocab.RevisionNumber] = input.RevisionNumber.PrintIfAvailable();
            data.Properties[vocab.Status] = input.Status.PrintIfAvailable();
            data.Properties[vocab.EmployeeID] = input.EmployeeID.PrintIfAvailable();
            data.Properties[vocab.VendorID] = input.VendorID.PrintIfAvailable();
            data.Properties[vocab.ShipMethodID] = input.ShipMethodID.PrintIfAvailable();
            data.Properties[vocab.OrderDate] = input.OrderDate.PrintIfAvailable();
            data.Properties[vocab.ShipDate] = input.ShipDate.PrintIfAvailable();
            data.Properties[vocab.SubTotal] = input.SubTotal.PrintIfAvailable();
            data.Properties[vocab.TaxAmt] = input.TaxAmt.PrintIfAvailable();
            data.Properties[vocab.Freight] = input.Freight.PrintIfAvailable();
            data.Properties[vocab.TotalDue] = input.TotalDue.PrintIfAvailable();
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


