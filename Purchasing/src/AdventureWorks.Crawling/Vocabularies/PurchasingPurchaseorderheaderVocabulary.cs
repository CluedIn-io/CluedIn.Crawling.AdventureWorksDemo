using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.AdventureWorksPurchasing.Vocabularies
{
public class PurchasingPurchaseOrderHeaderVocabulary : SimpleVocabulary
{
public PurchasingPurchaseOrderHeaderVocabulary()
{
VocabularyName = "PurchasingPurchaseOrderHeader"; // TODO: Set value
KeyPrefix = "AdventureWorksPurchasing.PurchasingPurchaseOrderHeader"; // TODO: Set value
KeySeparator = ".";
Grouping = EntityType.Sales.Order; // TODO: Set value

AddGroup("PurchasingPurchaseOrderHeader Details", group =>
{
PurchaseOrderID           = group.Add(new VocabularyKey("purchaseOrderID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Purchase Order ID").WithDescription("Primary key."));
RevisionNumber            = group.Add(new VocabularyKey("revisionNumber", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Revision Number").WithDescription("Incremental number to track changes to the purchase order over time."));
Status                    = group.Add(new VocabularyKey("status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Status").WithDescription("Order current status. 1 = Pending; 2 = Approved; 3 = Rejected; 4 = Complete"));
EmployeeID                = group.Add(new VocabularyKey("employeeID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible).WithDisplayName("Employee ID").WithDescription("Employee who created the purchase order. Foreign key to Employee.BusinessEntityID."));
VendorID                  = group.Add(new VocabularyKey("vendorID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible).WithDisplayName("Vendor ID").WithDescription("Vendor with whom the purchase order is placed. Foreign key to Vendor.BusinessEntityID."));
ShipMethodID              = group.Add(new VocabularyKey("shipMethodID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible).WithDisplayName("Ship Method ID").WithDescription("Shipping method. Foreign key to ShipMethod.ShipMethodID."));
OrderDate                 = group.Add(new VocabularyKey("orderDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Order Date").WithDescription("Purchase order creation date."));
ShipDate                  = group.Add(new VocabularyKey("shipDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Ship Date").WithDescription("Estimated shipment date from the vendor."));
SubTotal                  = group.Add(new VocabularyKey("subTotal", VocabularyKeyDataType.Money, VocabularyKeyVisibility.Visible).WithDisplayName("Sub Total").WithDescription("Purchase order subtotal. Computed as SUM(PurchaseOrderDetail.LineTotal)for the appropriate PurchaseOrderID."));
TaxAmt                    = group.Add(new VocabularyKey("taxAmt", VocabularyKeyDataType.Money, VocabularyKeyVisibility.Visible).WithDisplayName("Tax Amt").WithDescription("Tax amount."));
Freight                   = group.Add(new VocabularyKey("freight", VocabularyKeyDataType.Money, VocabularyKeyVisibility.Visible).WithDisplayName("Freight").WithDescription("Shipping cost."));
TotalDue                  = group.Add(new VocabularyKey("totalDue", VocabularyKeyDataType.Money, VocabularyKeyVisibility.Visible).WithDisplayName("Total Due").WithDescription("Total due to vendor. Computed as Subtotal + TaxAmt + Freight."));
ModifiedDate              = group.Add(new VocabularyKey("modifiedDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Modified Date").WithDescription("Date and time the record was last updated."));
});
}

public VocabularyKey PurchaseOrderID { get; private set; }
public VocabularyKey RevisionNumber { get; private set; }
public VocabularyKey Status { get; private set; }
public VocabularyKey EmployeeID { get; private set; }
public VocabularyKey VendorID { get; private set; }
public VocabularyKey ShipMethodID { get; private set; }
public VocabularyKey OrderDate { get; private set; }
public VocabularyKey ShipDate { get; private set; }
public VocabularyKey SubTotal { get; private set; }
public VocabularyKey TaxAmt { get; private set; }
public VocabularyKey Freight { get; private set; }
public VocabularyKey TotalDue { get; private set; }
public VocabularyKey ModifiedDate { get; private set; }
}
}
