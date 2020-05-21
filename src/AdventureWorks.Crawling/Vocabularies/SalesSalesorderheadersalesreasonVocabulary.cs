using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.AdventureWorks.Vocabularies
{
public class SalesSalesOrderHeaderSalesReasonVocabulary : SimpleVocabulary
{
public SalesSalesOrderHeaderSalesReasonVocabulary()
{
VocabularyName = "SalesSalesOrderHeaderSalesReason"; // TODO: Set value
KeyPrefix = "adventureWorks.SalesSalesOrderHeaderSalesReason"; // TODO: Set value
KeySeparator = ".";
Grouping = "SalesSalesOrderHeaderSalesReason"; // TODO: Set value

AddGroup("SalesSalesOrderHeaderSalesReason Details", group =>
{
SalesOrderID              = group.Add(new VocabularyKey("salesOrderID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Sales Order ID").WithDescription("Primary key. Foreign key to SalesOrderHeader.SalesOrderID."));
SalesReasonID             = group.Add(new VocabularyKey("salesReasonID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Sales Reason ID").WithDescription("Primary key. Foreign key to SalesReason.SalesReasonID."));
ModifiedDate              = group.Add(new VocabularyKey("modifiedDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Modified Date").WithDescription("Date and time the record was last updated."));
});
}

public VocabularyKey SalesOrderID { get; private set; }
public VocabularyKey SalesReasonID { get; private set; }
public VocabularyKey ModifiedDate { get; private set; }
}
}
