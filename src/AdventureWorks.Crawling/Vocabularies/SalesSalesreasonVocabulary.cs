using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.AdventureWorks.Vocabularies
{
public class SalesSalesReasonVocabulary : SimpleVocabulary
{
public SalesSalesReasonVocabulary()
{
VocabularyName = "Sql SalesSalesReason"; // TODO: Set value
KeyPrefix = "sql.SalesSalesReason"; // TODO: Set value
KeySeparator = ".";
Grouping = "SalesSalesReason"; // TODO: Set value

AddGroup("SalesSalesReason Details", group =>
{
SalesReasonID             = group.Add(new VocabularyKey("salesReasonID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Sales Reason ID").WithDescription("Primary key for SalesReason records."));
Name                      = group.Add(new VocabularyKey("name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Name").WithDescription("Sales reason description."));
ReasonType                = group.Add(new VocabularyKey("reasonType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Reason Type").WithDescription("Category the sales reason belongs to."));
ModifiedDate              = group.Add(new VocabularyKey("modifiedDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Modified Date").WithDescription("Date and time the record was last updated."));
});
}

public VocabularyKey SalesReasonID { get; private set; }
public VocabularyKey Name { get; private set; }
public VocabularyKey ReasonType { get; private set; }
public VocabularyKey ModifiedDate { get; private set; }
}
}
