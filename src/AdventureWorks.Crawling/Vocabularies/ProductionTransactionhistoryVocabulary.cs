using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.AdventureWorks.Vocabularies
{
public class ProductionTransactionHistoryVocabulary : SimpleVocabulary
{
public ProductionTransactionHistoryVocabulary()
{
VocabularyName = "ProductionTransactionHistory"; // TODO: Set value
KeyPrefix = "adventureWorks.ProductionTransactionHistory"; // TODO: Set value
KeySeparator = ".";
Grouping = "ProductionTransactionHistory"; // TODO: Set value

AddGroup("ProductionTransactionHistory Details", group =>
{
TransactionID             = group.Add(new VocabularyKey("transactionID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Transaction ID").WithDescription("Primary key for TransactionHistory records."));
ProductID                 = group.Add(new VocabularyKey("productID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible).WithDisplayName("Product ID").WithDescription("Product identification number. Foreign key to Product.ProductID."));
ReferenceOrderID          = group.Add(new VocabularyKey("referenceOrderID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible).WithDisplayName("Reference Order ID").WithDescription("Purchase order, sales order, or work order identification number."));
ReferenceOrderLineID      = group.Add(new VocabularyKey("referenceOrderLineID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible).WithDisplayName("Reference Order Line ID").WithDescription("Line number associated with the purchase order, sales order, or work order."));
TransactionDate           = group.Add(new VocabularyKey("transactionDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Transaction Date").WithDescription("Date and time of the transaction."));
TransactionType           = group.Add(new VocabularyKey("transactionType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Transaction Type").WithDescription("W = WorkOrder, S = SalesOrder, P = PurchaseOrder"));
Quantity                  = group.Add(new VocabularyKey("quantity", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible).WithDisplayName("Quantity").WithDescription("Product quantity."));
ActualCost                = group.Add(new VocabularyKey("actualCost", VocabularyKeyDataType.Money, VocabularyKeyVisibility.Visible).WithDisplayName("Actual Cost").WithDescription("Product cost."));
ModifiedDate              = group.Add(new VocabularyKey("modifiedDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Modified Date").WithDescription("Date and time the record was last updated."));
});
}

public VocabularyKey TransactionID { get; private set; }
public VocabularyKey ProductID { get; private set; }
public VocabularyKey ReferenceOrderID { get; private set; }
public VocabularyKey ReferenceOrderLineID { get; private set; }
public VocabularyKey TransactionDate { get; private set; }
public VocabularyKey TransactionType { get; private set; }
public VocabularyKey Quantity { get; private set; }
public VocabularyKey ActualCost { get; private set; }
public VocabularyKey ModifiedDate { get; private set; }
}
}
