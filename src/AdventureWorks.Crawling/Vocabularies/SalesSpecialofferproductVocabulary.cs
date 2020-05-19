using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.AdventureWorks.Vocabularies
{
public class SalesSpecialOfferProductVocabulary : SimpleVocabulary
{
public SalesSpecialOfferProductVocabulary()
{
VocabularyName = "Sql SalesSpecialOfferProduct"; // TODO: Set value
KeyPrefix = "sql.SalesSpecialOfferProduct"; // TODO: Set value
KeySeparator = ".";
Grouping = "SalesSpecialOfferProduct"; // TODO: Set value

AddGroup("SalesSpecialOfferProduct Details", group =>
{
SpecialOfferID            = group.Add(new VocabularyKey("specialOfferID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Special Offer ID").WithDescription("Primary key for SpecialOfferProduct records."));
ProductID                 = group.Add(new VocabularyKey("productID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Product ID").WithDescription("Product identification number. Foreign key to Product.ProductID."));
Rowguid                   = group.Add(new VocabularyKey("rowguid", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("rowguid").WithDescription("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample."));
ModifiedDate              = group.Add(new VocabularyKey("modifiedDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Modified Date").WithDescription("Date and time the record was last updated."));
});
}

public VocabularyKey SpecialOfferID { get; private set; }
public VocabularyKey ProductID { get; private set; }
public VocabularyKey Rowguid { get; private set; }
public VocabularyKey ModifiedDate { get; private set; }
}
}
