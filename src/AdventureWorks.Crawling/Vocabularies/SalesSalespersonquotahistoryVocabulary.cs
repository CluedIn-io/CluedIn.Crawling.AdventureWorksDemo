using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.AdventureWorks.Vocabularies
{
public class SalesSalesPersonQuotaHistoryVocabulary : SimpleVocabulary
{
public SalesSalesPersonQuotaHistoryVocabulary()
{
VocabularyName = "SalesSalesPersonQuotaHistory"; // TODO: Set value
KeyPrefix = "adventureWorks.SalesSalesPersonQuotaHistory"; // TODO: Set value
KeySeparator = ".";
Grouping = "SalesSalesPersonQuotaHistory"; // TODO: Set value

AddGroup("SalesSalesPersonQuotaHistory Details", group =>
{
BusinessEntityID          = group.Add(new VocabularyKey("businessEntityID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Business Entity ID").WithDescription("Sales person identification number. Foreign key to SalesPerson.BusinessEntityID."));
QuotaDate                 = group.Add(new VocabularyKey("quotaDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Quota Date").WithDescription("Sales quota date."));
SalesQuota                = group.Add(new VocabularyKey("salesQuota", VocabularyKeyDataType.Money, VocabularyKeyVisibility.Visible).WithDisplayName("Sales Quota").WithDescription("Sales quota amount."));
Rowguid                   = group.Add(new VocabularyKey("rowguid", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("rowguid").WithDescription("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample."));
ModifiedDate              = group.Add(new VocabularyKey("modifiedDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Modified Date").WithDescription("Date and time the record was last updated."));
});
}

public VocabularyKey BusinessEntityID { get; private set; }
public VocabularyKey QuotaDate { get; private set; }
public VocabularyKey SalesQuota { get; private set; }
public VocabularyKey Rowguid { get; private set; }
public VocabularyKey ModifiedDate { get; private set; }
}
}
