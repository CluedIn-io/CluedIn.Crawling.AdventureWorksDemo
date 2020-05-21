using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.AdventureWorks.Vocabularies
{
public class ProductionProductCategoryVocabulary : SimpleVocabulary
{
public ProductionProductCategoryVocabulary()
{
VocabularyName = "ProductionProductCategory"; // TODO: Set value
KeyPrefix = "adventureWorks.ProductionProductCategory"; // TODO: Set value
KeySeparator = ".";
Grouping = "ProductionProductCategory"; // TODO: Set value

AddGroup("ProductionProductCategory Details", group =>
{
ProductCategoryID         = group.Add(new VocabularyKey("productCategoryID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Product Category ID").WithDescription("Primary key for ProductCategory records."));
Name                      = group.Add(new VocabularyKey("name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Name").WithDescription("Category description."));
Rowguid                   = group.Add(new VocabularyKey("rowguid", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("rowguid").WithDescription("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample."));
ModifiedDate              = group.Add(new VocabularyKey("modifiedDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Modified Date").WithDescription("Date and time the record was last updated."));
});
}

public VocabularyKey ProductCategoryID { get; private set; }
public VocabularyKey Name { get; private set; }
public VocabularyKey Rowguid { get; private set; }
public VocabularyKey ModifiedDate { get; private set; }
}
}
