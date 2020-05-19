using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.AdventureWorks.Vocabularies
{
public class ProductionIllustrationVocabulary : SimpleVocabulary
{
public ProductionIllustrationVocabulary()
{
VocabularyName = "Sql ProductionIllustration"; // TODO: Set value
KeyPrefix = "sql.ProductionIllustration"; // TODO: Set value
KeySeparator = ".";
Grouping = "ProductionIllustration"; // TODO: Set value

AddGroup("ProductionIllustration Details", group =>
{
IllustrationID            = group.Add(new VocabularyKey("illustrationID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Illustration ID").WithDescription("Primary key for Illustration records."));
Diagram                   = group.Add(new VocabularyKey("diagram", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Diagram").WithDescription("Illustrations used in manufacturing instructions. Stored as XML."));
ModifiedDate              = group.Add(new VocabularyKey("modifiedDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Modified Date").WithDescription("Date and time the record was last updated."));
});
}

public VocabularyKey IllustrationID { get; private set; }
public VocabularyKey Diagram { get; private set; }
public VocabularyKey ModifiedDate { get; private set; }
}
}
