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
public class SalesSalesOrderHeaderClueProducer : BaseClueProducer<SalesSalesOrderHeader>
{
private readonly IClueFactory _factory;

public SalesSalesOrderHeaderClueProducer(IClueFactory factory)
							{
								_factory = factory;
							}

protected override Clue MakeClueImpl(SalesSalesOrderHeader input, Guid id)
{

var clue = _factory.Create("/SalesSalesOrderHeader", $"{input.SalesOrderID}", id);

							var data = clue.Data.EntityData;

							

//add edges

if(input.CustomerID != null && !string.IsNullOrEmpty(input.CustomerID.ToString()))
{
_factory.CreateOutgoingEntityReference(clue, "/SalesCustomer", EntityEdgeType.AttachedTo, input.CustomerID, input.CustomerID.ToString());
}
if(input.SalesPersonID != null && !string.IsNullOrEmpty(input.SalesPersonID.ToString()))
{
_factory.CreateOutgoingEntityReference(clue, "/PersonBusinessEntity", EntityEdgeType.AttachedTo, input.SalesPersonID, input.SalesPersonID.ToString());
}
if(input.TerritoryID != null && !string.IsNullOrEmpty(input.TerritoryID.ToString()))
{
_factory.CreateOutgoingEntityReference(clue, "/SalesSalesTerritory", EntityEdgeType.AttachedTo, input.TerritoryID, input.TerritoryID.ToString());
}
if(input.BillToAddressID != null && !string.IsNullOrEmpty(input.BillToAddressID.ToString()))
{
_factory.CreateOutgoingEntityReference(clue, "/PersonAddress", EntityEdgeType.AttachedTo, input.BillToAddressID, input.BillToAddressID.ToString());
}
if(input.ShipToAddressID != null && !string.IsNullOrEmpty(input.ShipToAddressID.ToString()))
{
_factory.CreateOutgoingEntityReference(clue, "/PersonAddress", EntityEdgeType.AttachedTo, input.ShipToAddressID, input.ShipToAddressID.ToString());
}
if(input.ShipMethodID != null && !string.IsNullOrEmpty(input.ShipMethodID.ToString()))
{
_factory.CreateOutgoingEntityReference(clue, "/PurchasingShipMethod", EntityEdgeType.AttachedTo, input.ShipMethodID, input.ShipMethodID.ToString());
}
if(input.CreditCardID != null && !string.IsNullOrEmpty(input.CreditCardID.ToString()))
{
_factory.CreateOutgoingEntityReference(clue, "/SalesCreditCard", EntityEdgeType.AttachedTo, input.CreditCardID, input.CreditCardID.ToString());
}
if(input.CurrencyRateID != null && !string.IsNullOrEmpty(input.CurrencyRateID.ToString()))
{
_factory.CreateOutgoingEntityReference(clue, "/SalesCurrencyRate", EntityEdgeType.AttachedTo, input.CurrencyRateID, input.CurrencyRateID.ToString());
}

if (!data.OutgoingEdges.Any())
			                _factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);
							

var vocab = new SalesSalesOrderHeaderVocabulary();

data.Properties[vocab.SalesOrderID]              = input.SalesOrderID.PrintIfAvailable();
data.Properties[vocab.RevisionNumber]            = input.RevisionNumber.PrintIfAvailable();
data.Properties[vocab.OrderDate]                 = input.OrderDate.PrintIfAvailable();
data.Properties[vocab.DueDate]                   = input.DueDate.PrintIfAvailable();
data.Properties[vocab.ShipDate]                  = input.ShipDate.PrintIfAvailable();
data.Properties[vocab.Status]                    = input.Status.PrintIfAvailable();
data.Properties[vocab.OnlineOrderFlag]           = input.OnlineOrderFlag.PrintIfAvailable();
data.Properties[vocab.SalesOrderNumber]          = input.SalesOrderNumber.PrintIfAvailable();
data.Properties[vocab.PurchaseOrderNumber]       = input.PurchaseOrderNumber.PrintIfAvailable();
data.Properties[vocab.AccountNumber]             = input.AccountNumber.PrintIfAvailable();
data.Properties[vocab.CustomerID]                = input.CustomerID.PrintIfAvailable();
data.Properties[vocab.SalesPersonID]             = input.SalesPersonID.PrintIfAvailable();
data.Properties[vocab.TerritoryID]               = input.TerritoryID.PrintIfAvailable();
data.Properties[vocab.BillToAddressID]           = input.BillToAddressID.PrintIfAvailable();
data.Properties[vocab.ShipToAddressID]           = input.ShipToAddressID.PrintIfAvailable();
data.Properties[vocab.ShipMethodID]              = input.ShipMethodID.PrintIfAvailable();
data.Properties[vocab.CreditCardID]              = input.CreditCardID.PrintIfAvailable();
data.Properties[vocab.CreditCardApprovalCode]    = input.CreditCardApprovalCode.PrintIfAvailable();
data.Properties[vocab.CurrencyRateID]            = input.CurrencyRateID.PrintIfAvailable();
data.Properties[vocab.SubTotal]                  = input.SubTotal.PrintIfAvailable();
data.Properties[vocab.TaxAmt]                    = input.TaxAmt.PrintIfAvailable();
data.Properties[vocab.Freight]                   = input.Freight.PrintIfAvailable();
data.Properties[vocab.TotalDue]                  = input.TotalDue.PrintIfAvailable();
data.Properties[vocab.Comment]                   = input.Comment.PrintIfAvailable();
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


