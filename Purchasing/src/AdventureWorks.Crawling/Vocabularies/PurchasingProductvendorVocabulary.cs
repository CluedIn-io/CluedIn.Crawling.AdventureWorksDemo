using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.AdventureWorksPurchasing.Vocabularies
{
public class PurchasingProductVendorVocabulary : SimpleVocabulary
{
public PurchasingProductVendorVocabulary()
{
VocabularyName = "PurchasingProductVendor"; // TODO: Set value
KeyPrefix = "AdventureWorksPurchasing.PurchasingProductVendor"; // TODO: Set value
KeySeparator = ".";
Grouping = "PurchasingProductVendor"; // TODO: Set value

AddGroup("PurchasingProductVendor Details", group =>
{
ProductID                 = group.Add(new VocabularyKey("productID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Product ID").WithDescription("Primary key. Foreign key to Product.ProductID."));
BusinessEntityID          = group.Add(new VocabularyKey("businessEntityID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Business Entity ID").WithDescription("Primary key. Foreign key to Vendor.BusinessEntityID."));
AverageLeadTime           = group.Add(new VocabularyKey("averageLeadTime", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible).WithDisplayName("Average Lead Time").WithDescription("The average span of time (in days) between placing an order with the vendor and receiving the purchased product."));
StandardPrice             = group.Add(new VocabularyKey("standardPrice", VocabularyKeyDataType.Money, VocabularyKeyVisibility.Visible).WithDisplayName("Standard Price").WithDescription("The vendor's usual selling price."));
LastReceiptCost           = group.Add(new VocabularyKey("lastReceiptCost", VocabularyKeyDataType.Money, VocabularyKeyVisibility.Visible).WithDisplayName("Last Receipt Cost").WithDescription("The selling price when last purchased."));
LastReceiptDate           = group.Add(new VocabularyKey("lastReceiptDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Last Receipt Date").WithDescription("Date the product was last received by the vendor."));
MinOrderQty               = group.Add(new VocabularyKey("minOrderQty", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible).WithDisplayName("Min Order Qty").WithDescription("The maximum quantity that should be ordered."));
MaxOrderQty               = group.Add(new VocabularyKey("maxOrderQty", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible).WithDisplayName("Max Order Qty").WithDescription("The minimum quantity that should be ordered."));
OnOrderQty                = group.Add(new VocabularyKey("onOrderQty", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible).WithDisplayName("On Order Qty").WithDescription("The quantity currently on order."));
UnitMeasureCode           = group.Add(new VocabularyKey("unitMeasureCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Unit Measure Code").WithDescription("The product's unit of measure."));
ModifiedDate              = group.Add(new VocabularyKey("modifiedDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Modified Date").WithDescription("Date and time the record was last updated."));
});
}

public VocabularyKey ProductID { get; private set; }
public VocabularyKey BusinessEntityID { get; private set; }
public VocabularyKey AverageLeadTime { get; private set; }
public VocabularyKey StandardPrice { get; private set; }
public VocabularyKey LastReceiptCost { get; private set; }
public VocabularyKey LastReceiptDate { get; private set; }
public VocabularyKey MinOrderQty { get; private set; }
public VocabularyKey MaxOrderQty { get; private set; }
public VocabularyKey OnOrderQty { get; private set; }
public VocabularyKey UnitMeasureCode { get; private set; }
public VocabularyKey ModifiedDate { get; private set; }
}
}
