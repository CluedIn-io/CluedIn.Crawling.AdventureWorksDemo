using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.AdventureWorksProduction.Vocabularies
{
public class ProductionProductDescriptionVocabulary : SimpleVocabulary
{
public ProductionProductDescriptionVocabulary()
{
VocabularyName = "ProductionProductDescription"; // TODO: Set value
KeyPrefix = "AdventureWorksProduction.ProductionProductDescription"; // TODO: Set value
KeySeparator = ".";
Grouping = "ProductionProductDescription"; // TODO: Set value

AddGroup("ProductionProductDescription Details", group =>
{
ProductDescriptionID      = group.Add(new VocabularyKey("productDescriptionID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Product Description ID").WithDescription("Primary key for ProductDescription records."));
Description               = group.Add(new VocabularyKey("description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Description").WithDescription("Description of the product."));
Rowguid                   = group.Add(new VocabularyKey("rowguid", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("rowguid").WithDescription("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample."));
ModifiedDate              = group.Add(new VocabularyKey("modifiedDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Modified Date").WithDescription("Date and time the record was last updated."));
});
}

public VocabularyKey ProductDescriptionID { get; private set; }
public VocabularyKey Description { get; private set; }
public VocabularyKey Rowguid { get; private set; }
public VocabularyKey ModifiedDate { get; private set; }
}
}
