using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.AdventureWorksProduction.Vocabularies
{
public class ProductionProductModelProductDescriptionCultureVocabulary : SimpleVocabulary
{
public ProductionProductModelProductDescriptionCultureVocabulary()
{
VocabularyName = "ProductionProductModelProductDescriptionCulture"; // TODO: Set value
KeyPrefix = "AdventureWorksProduction.ProductionProductModelProductDescriptionCulture"; // TODO: Set value
KeySeparator = ".";
Grouping = "ProductionProductModelProductDescriptionCulture"; // TODO: Set value

AddGroup("ProductionProductModelProductDescriptionCulture Details", group =>
{
ProductModelID            = group.Add(new VocabularyKey("productModelID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Product Model ID").WithDescription("Primary key. Foreign key to ProductModel.ProductModelID."));
ProductDescriptionID      = group.Add(new VocabularyKey("productDescriptionID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Product Description ID").WithDescription("Primary key. Foreign key to ProductDescription.ProductDescriptionID."));
CultureID                 = group.Add(new VocabularyKey("cultureID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Culture ID").WithDescription("Culture identification number. Foreign key to Culture.CultureID."));
ModifiedDate              = group.Add(new VocabularyKey("modifiedDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Modified Date").WithDescription("Date and time the record was last updated."));
});
}

public VocabularyKey ProductModelID { get; private set; }
public VocabularyKey ProductDescriptionID { get; private set; }
public VocabularyKey CultureID { get; private set; }
public VocabularyKey ModifiedDate { get; private set; }
}
}
