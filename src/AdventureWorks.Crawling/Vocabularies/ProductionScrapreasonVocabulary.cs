using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.AdventureWorks.Vocabularies
{
public class ProductionScrapReasonVocabulary : SimpleVocabulary
{
public ProductionScrapReasonVocabulary()
{
VocabularyName = "ProductionScrapReason"; // TODO: Set value
KeyPrefix = "adventureWorks.ProductionScrapReason"; // TODO: Set value
KeySeparator = ".";
Grouping = "ProductionScrapReason"; // TODO: Set value

AddGroup("ProductionScrapReason Details", group =>
{
ScrapReasonID             = group.Add(new VocabularyKey("scrapReasonID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Scrap Reason ID").WithDescription("Primary key for ScrapReason records."));
Name                      = group.Add(new VocabularyKey("name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Name").WithDescription("Failure description."));
ModifiedDate              = group.Add(new VocabularyKey("modifiedDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Modified Date").WithDescription("Date and time the record was last updated."));
});
}

public VocabularyKey ScrapReasonID { get; private set; }
public VocabularyKey Name { get; private set; }
public VocabularyKey ModifiedDate { get; private set; }
}
}
