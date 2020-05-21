using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.AdventureWorks.Vocabularies
{
public class ProductionProductModelVocabulary : SimpleVocabulary
{
public ProductionProductModelVocabulary()
{
VocabularyName = "ProductionProductModel"; // TODO: Set value
KeyPrefix = "adventureWorks.ProductionProductModel"; // TODO: Set value
KeySeparator = ".";
Grouping = "ProductionProductModel"; // TODO: Set value

AddGroup("ProductionProductModel Details", group =>
{
ProductModelID            = group.Add(new VocabularyKey("productModelID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Product Model ID").WithDescription("Primary key for ProductModel records."));
Name                      = group.Add(new VocabularyKey("name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Name").WithDescription("Product model description."));
CatalogDescription        = group.Add(new VocabularyKey("catalogDescription", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Catalog Description").WithDescription("Detailed product catalog information in xml format."));
Instructions              = group.Add(new VocabularyKey("instructions", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Instructions").WithDescription("Manufacturing instructions in xml format."));
Rowguid                   = group.Add(new VocabularyKey("rowguid", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("rowguid").WithDescription("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample."));
ModifiedDate              = group.Add(new VocabularyKey("modifiedDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Modified Date").WithDescription("Date and time the record was last updated."));
});
}

public VocabularyKey ProductModelID { get; private set; }
public VocabularyKey Name { get; private set; }
public VocabularyKey CatalogDescription { get; private set; }
public VocabularyKey Instructions { get; private set; }
public VocabularyKey Rowguid { get; private set; }
public VocabularyKey ModifiedDate { get; private set; }
}
}
