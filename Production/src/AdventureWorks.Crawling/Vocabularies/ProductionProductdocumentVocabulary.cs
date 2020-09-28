using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.AdventureWorksProduction.Vocabularies
{
public class ProductionProductDocumentVocabulary : SimpleVocabulary
{
public ProductionProductDocumentVocabulary()
{
VocabularyName = "ProductionProductDocument"; // TODO: Set value
KeyPrefix = "AdventureWorksProduction.ProductionProductDocument"; // TODO: Set value
KeySeparator = ".";
Grouping = "ProductionProductDocument"; // TODO: Set value

AddGroup("ProductionProductDocument Details", group =>
{
ProductID                 = group.Add(new VocabularyKey("productID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Product ID").WithDescription("Product identification number. Foreign key to Product.ProductID."));
DocumentNode              = group.Add(new VocabularyKey("documentNode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Document Node").WithDescription("Document identification number. Foreign key to Document.DocumentNode."));
ModifiedDate              = group.Add(new VocabularyKey("modifiedDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Modified Date").WithDescription("Date and time the record was last updated."));
});
}

public VocabularyKey ProductID { get; private set; }
public VocabularyKey DocumentNode { get; private set; }
public VocabularyKey ModifiedDate { get; private set; }
}
}
