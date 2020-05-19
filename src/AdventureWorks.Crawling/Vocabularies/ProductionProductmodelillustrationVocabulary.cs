using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.AdventureWorks.Vocabularies
{
public class ProductionProductModelIllustrationVocabulary : SimpleVocabulary
{
public ProductionProductModelIllustrationVocabulary()
{
VocabularyName = "Sql ProductionProductModelIllustration"; // TODO: Set value
KeyPrefix = "sql.ProductionProductModelIllustration"; // TODO: Set value
KeySeparator = ".";
Grouping = "ProductionProductModelIllustration"; // TODO: Set value

AddGroup("ProductionProductModelIllustration Details", group =>
{
ProductModelID            = group.Add(new VocabularyKey("productModelID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Product Model ID").WithDescription("Primary key. Foreign key to ProductModel.ProductModelID."));
IllustrationID            = group.Add(new VocabularyKey("illustrationID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Illustration ID").WithDescription("Primary key. Foreign key to Illustration.IllustrationID."));
ModifiedDate              = group.Add(new VocabularyKey("modifiedDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Modified Date").WithDescription("Date and time the record was last updated."));
});
}

public VocabularyKey ProductModelID { get; private set; }
public VocabularyKey IllustrationID { get; private set; }
public VocabularyKey ModifiedDate { get; private set; }
}
}
