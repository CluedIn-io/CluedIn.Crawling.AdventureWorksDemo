using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.AdventureWorks.Vocabularies
{
public class SalesSalesOrderDetailVocabulary : SimpleVocabulary
{
public SalesSalesOrderDetailVocabulary()
{
VocabularyName = "SalesSalesOrderDetail"; // TODO: Set value
KeyPrefix = "adventureWorks.SalesSalesOrderDetail"; // TODO: Set value
KeySeparator = ".";
Grouping = "SalesSalesOrderDetail"; // TODO: Set value

AddGroup("SalesSalesOrderDetail Details", group =>
{
SalesOrderID              = group.Add(new VocabularyKey("salesOrderID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Sales Order ID").WithDescription("Primary key. Foreign key to SalesOrderHeader.SalesOrderID."));
SalesOrderDetailID        = group.Add(new VocabularyKey("salesOrderDetailID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Sales Order Detail ID").WithDescription("Primary key. One incremental unique number per product sold."));
CarrierTrackingNumber     = group.Add(new VocabularyKey("carrierTrackingNumber", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Carrier Tracking Number").WithDescription("Shipment tracking number supplied by the shipper."));
OrderQty                  = group.Add(new VocabularyKey("orderQty", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible).WithDisplayName("Order Qty").WithDescription("Quantity ordered per product."));
ProductID                 = group.Add(new VocabularyKey("productID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible).WithDisplayName("Product ID").WithDescription("Product sold to customer. Foreign key to Product.ProductID."));
SpecialOfferID            = group.Add(new VocabularyKey("specialOfferID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible).WithDisplayName("Special Offer ID").WithDescription("Promotional code. Foreign key to SpecialOffer.SpecialOfferID."));
UnitPrice                 = group.Add(new VocabularyKey("unitPrice", VocabularyKeyDataType.Money, VocabularyKeyVisibility.Visible).WithDisplayName("Unit Price").WithDescription("Selling price of a single product."));
UnitPriceDiscount         = group.Add(new VocabularyKey("unitPriceDiscount", VocabularyKeyDataType.Money, VocabularyKeyVisibility.Visible).WithDisplayName("Unit Price Discount").WithDescription("Discount amount."));
LineTotal                 = group.Add(new VocabularyKey("lineTotal", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible).WithDisplayName("Line Total").WithDescription("Per product subtotal. Computed as UnitPrice * (1 - UnitPriceDiscount) * OrderQty."));
Rowguid                   = group.Add(new VocabularyKey("rowguid", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("rowguid").WithDescription("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample."));
ModifiedDate              = group.Add(new VocabularyKey("modifiedDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Modified Date").WithDescription("Date and time the record was last updated."));
});
}

public VocabularyKey SalesOrderID { get; private set; }
public VocabularyKey SalesOrderDetailID { get; private set; }
public VocabularyKey CarrierTrackingNumber { get; private set; }
public VocabularyKey OrderQty { get; private set; }
public VocabularyKey ProductID { get; private set; }
public VocabularyKey SpecialOfferID { get; private set; }
public VocabularyKey UnitPrice { get; private set; }
public VocabularyKey UnitPriceDiscount { get; private set; }
public VocabularyKey LineTotal { get; private set; }
public VocabularyKey Rowguid { get; private set; }
public VocabularyKey ModifiedDate { get; private set; }
}
}
