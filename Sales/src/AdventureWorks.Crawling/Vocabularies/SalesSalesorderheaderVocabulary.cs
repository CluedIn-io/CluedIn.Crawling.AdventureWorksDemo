using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.AdventureWorksSales.Vocabularies
{
public class SalesSalesOrderHeaderVocabulary : SimpleVocabulary
{
public SalesSalesOrderHeaderVocabulary()
{
VocabularyName = "SalesSalesOrderHeader"; // TODO: Set value
KeyPrefix = "AdventureWorksSales.SalesSalesOrderHeader"; // TODO: Set value
KeySeparator = ".";
Grouping = EntityType.Sales.Sale; // TODO: Set value

AddGroup("SalesSalesOrderHeader Details", group =>
{
SalesOrderID              = group.Add(new VocabularyKey("salesOrderID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Sales Order ID").WithDescription("Primary key."));
RevisionNumber            = group.Add(new VocabularyKey("revisionNumber", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Revision Number").WithDescription("Incremental number to track changes to the sales order over time."));
OrderDate                 = group.Add(new VocabularyKey("orderDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Order Date").WithDescription("Dates the sales order was created."));
DueDate                   = group.Add(new VocabularyKey("dueDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Due Date").WithDescription("Date the order is due to the customer."));
ShipDate                  = group.Add(new VocabularyKey("shipDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Ship Date").WithDescription("Date the order was shipped to the customer."));
Status                    = group.Add(new VocabularyKey("status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Status").WithDescription("Order current status. 1 = In process; 2 = Approved; 3 = Backordered; 4 = Rejected; 5 = Shipped; 6 = Cancelled"));
OnlineOrderFlag           = group.Add(new VocabularyKey("onlineOrderFlag", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Online Order Flag").WithDescription("0 = Order placed by sales person. 1 = Order placed online by customer."));
SalesOrderNumber          = group.Add(new VocabularyKey("salesOrderNumber", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Sales Order Number").WithDescription("Unique sales order identification number."));
PurchaseOrderNumber       = group.Add(new VocabularyKey("purchaseOrderNumber", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Purchase Order Number").WithDescription("Customer purchase order number reference. "));
AccountNumber             = group.Add(new VocabularyKey("accountNumber", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Account Number").WithDescription("Financial accounting number reference."));
CustomerID                = group.Add(new VocabularyKey("customerID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible).WithDisplayName("Customer ID").WithDescription("Customer identification number. Foreign key to Customer.BusinessEntityID."));
SalesPersonID             = group.Add(new VocabularyKey("salesPersonID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible).WithDisplayName("Sales Person ID").WithDescription("Sales person who created the sales order. Foreign key to SalesPerson.BusinessEntityID."));
TerritoryID               = group.Add(new VocabularyKey("territoryID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible).WithDisplayName("Territory ID").WithDescription("Territory in which the sale was made. Foreign key to SalesTerritory.SalesTerritoryID."));
BillToAddressID           = group.Add(new VocabularyKey("billToAddressID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible).WithDisplayName("Bill To Address ID").WithDescription("Customer billing address. Foreign key to Address.AddressID."));
ShipToAddressID           = group.Add(new VocabularyKey("shipToAddressID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible).WithDisplayName("Ship To Address ID").WithDescription("Customer shipping address. Foreign key to Address.AddressID."));
ShipMethodID              = group.Add(new VocabularyKey("shipMethodID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible).WithDisplayName("Ship Method ID").WithDescription("Shipping method. Foreign key to ShipMethod.ShipMethodID."));
CreditCardID              = group.Add(new VocabularyKey("creditCardID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible).WithDisplayName("Credit Card ID").WithDescription("Credit card identification number. Foreign key to CreditCard.CreditCardID."));
CreditCardApprovalCode    = group.Add(new VocabularyKey("creditCardApprovalCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Credit Card Approval Code").WithDescription("Approval code provided by the credit card company."));
CurrencyRateID            = group.Add(new VocabularyKey("currencyRateID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible).WithDisplayName("Currency Rate ID").WithDescription("Currency exchange rate used. Foreign key to CurrencyRate.CurrencyRateID."));
SubTotal                  = group.Add(new VocabularyKey("subTotal", VocabularyKeyDataType.Money, VocabularyKeyVisibility.Visible).WithDisplayName("Sub Total").WithDescription("Sales subtotal. Computed as SUM(SalesOrderDetail.LineTotal)for the appropriate SalesOrderID."));
TaxAmt                    = group.Add(new VocabularyKey("taxAmt", VocabularyKeyDataType.Money, VocabularyKeyVisibility.Visible).WithDisplayName("Tax Amt").WithDescription("Tax amount."));
Freight                   = group.Add(new VocabularyKey("freight", VocabularyKeyDataType.Money, VocabularyKeyVisibility.Visible).WithDisplayName("Freight").WithDescription("Shipping cost."));
TotalDue                  = group.Add(new VocabularyKey("totalDue", VocabularyKeyDataType.Money, VocabularyKeyVisibility.Visible).WithDisplayName("Total Due").WithDescription("Total due from customer. Computed as Subtotal + TaxAmt + Freight."));
Comment                   = group.Add(new VocabularyKey("comment", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Comment").WithDescription("Sales representative comments."));
Rowguid                   = group.Add(new VocabularyKey("rowguid", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("rowguid").WithDescription("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample."));
ModifiedDate              = group.Add(new VocabularyKey("modifiedDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Modified Date").WithDescription("Date and time the record was last updated."));
});
}

public VocabularyKey SalesOrderID { get; private set; }
public VocabularyKey RevisionNumber { get; private set; }
public VocabularyKey OrderDate { get; private set; }
public VocabularyKey DueDate { get; private set; }
public VocabularyKey ShipDate { get; private set; }
public VocabularyKey Status { get; private set; }
public VocabularyKey OnlineOrderFlag { get; private set; }
public VocabularyKey SalesOrderNumber { get; private set; }
public VocabularyKey PurchaseOrderNumber { get; private set; }
public VocabularyKey AccountNumber { get; private set; }
public VocabularyKey CustomerID { get; private set; }
public VocabularyKey SalesPersonID { get; private set; }
public VocabularyKey TerritoryID { get; private set; }
public VocabularyKey BillToAddressID { get; private set; }
public VocabularyKey ShipToAddressID { get; private set; }
public VocabularyKey ShipMethodID { get; private set; }
public VocabularyKey CreditCardID { get; private set; }
public VocabularyKey CreditCardApprovalCode { get; private set; }
public VocabularyKey CurrencyRateID { get; private set; }
public VocabularyKey SubTotal { get; private set; }
public VocabularyKey TaxAmt { get; private set; }
public VocabularyKey Freight { get; private set; }
public VocabularyKey TotalDue { get; private set; }
public VocabularyKey Comment { get; private set; }
public VocabularyKey Rowguid { get; private set; }
public VocabularyKey ModifiedDate { get; private set; }
}
}
