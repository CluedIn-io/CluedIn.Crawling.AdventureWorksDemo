using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.AdventureWorks.Vocabularies
{
public class ProductionProductSubcategoryVocabulary : SimpleVocabulary
{
public ProductionProductSubcategoryVocabulary()
{
VocabularyName = "ProductionProductSubcategory"; // TODO: Set value
KeyPrefix = "adventureWorks.ProductionProductSubcategory"; // TODO: Set value
KeySeparator = ".";
Grouping = "ProductionProductSubcategory"; // TODO: Set value

AddGroup("ProductionProductSubcategory Details", group =>
{
ProductSubcategoryID      = group.Add(new VocabularyKey("productSubcategoryID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Product Subcategory ID").WithDescription("Primary key for ProductSubcategory records."));
ProductCategoryID         = group.Add(new VocabularyKey("productCategoryID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible).WithDisplayName("Product Category ID").WithDescription("Product category identification number. Foreign key to ProductCategory.ProductCategoryID."));
Name                      = group.Add(new VocabularyKey("name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Name").WithDescription("Subcategory description."));
Rowguid                   = group.Add(new VocabularyKey("rowguid", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("rowguid").WithDescription("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample."));
ModifiedDate              = group.Add(new VocabularyKey("modifiedDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Modified Date").WithDescription("Date and time the record was last updated."));
});
}

public VocabularyKey ProductSubcategoryID { get; private set; }
public VocabularyKey ProductCategoryID { get; private set; }
public VocabularyKey Name { get; private set; }
public VocabularyKey Rowguid { get; private set; }
public VocabularyKey ModifiedDate { get; private set; }
}
}
