using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.AdventureWorksPurchasing.Vocabularies
{
public class PurchasingPurchaseOrderDetailVocabulary : SimpleVocabulary
{
public PurchasingPurchaseOrderDetailVocabulary()
{
VocabularyName = "PurchasingPurchaseOrderDetail"; // TODO: Set value
KeyPrefix = "AdventureWorksPurchasing.PurchasingPurchaseOrderDetail"; // TODO: Set value
KeySeparator = ".";
Grouping = "PurchasingPurchaseOrderDetail"; // TODO: Set value

AddGroup("PurchasingPurchaseOrderDetail Details", group =>
{
PurchaseOrderID           = group.Add(new VocabularyKey("purchaseOrderID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Purchase Order ID").WithDescription("Primary key. Foreign key to PurchaseOrderHeader.PurchaseOrderID."));
PurchaseOrderDetailID     = group.Add(new VocabularyKey("purchaseOrderDetailID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Purchase Order Detail ID").WithDescription("Primary key. One line number per purchased product."));
DueDate                   = group.Add(new VocabularyKey("dueDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Due Date").WithDescription("Date the product is expected to be received."));
OrderQty                  = group.Add(new VocabularyKey("orderQty", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible).WithDisplayName("Order Qty").WithDescription("Quantity ordered."));
ProductID                 = group.Add(new VocabularyKey("productID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible).WithDisplayName("Product ID").WithDescription("Product identification number. Foreign key to Product.ProductID."));
UnitPrice                 = group.Add(new VocabularyKey("unitPrice", VocabularyKeyDataType.Money, VocabularyKeyVisibility.Visible).WithDisplayName("Unit Price").WithDescription("Vendor's selling price of a single product."));
LineTotal                 = group.Add(new VocabularyKey("lineTotal", VocabularyKeyDataType.Money, VocabularyKeyVisibility.Visible).WithDisplayName("Line Total").WithDescription("Per product subtotal. Computed as OrderQty * UnitPrice."));
ReceivedQty               = group.Add(new VocabularyKey("receivedQty", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible).WithDisplayName("Received Qty").WithDescription("Quantity actually received from the vendor."));
RejectedQty               = group.Add(new VocabularyKey("rejectedQty", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible).WithDisplayName("Rejected Qty").WithDescription("Quantity rejected during inspection."));
StockedQty                = group.Add(new VocabularyKey("stockedQty", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible).WithDisplayName("Stocked Qty").WithDescription("Quantity accepted into inventory. Computed as ReceivedQty - RejectedQty."));
ModifiedDate              = group.Add(new VocabularyKey("modifiedDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Modified Date").WithDescription("Date and time the record was last updated."));
});
}

public VocabularyKey PurchaseOrderID { get; private set; }
public VocabularyKey PurchaseOrderDetailID { get; private set; }
public VocabularyKey DueDate { get; private set; }
public VocabularyKey OrderQty { get; private set; }
public VocabularyKey ProductID { get; private set; }
public VocabularyKey UnitPrice { get; private set; }
public VocabularyKey LineTotal { get; private set; }
public VocabularyKey ReceivedQty { get; private set; }
public VocabularyKey RejectedQty { get; private set; }
public VocabularyKey StockedQty { get; private set; }
public VocabularyKey ModifiedDate { get; private set; }
}
}
