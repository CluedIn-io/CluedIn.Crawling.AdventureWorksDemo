using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.AdventureWorks.Vocabularies
{
public class ProductionProductProductPhotoVocabulary : SimpleVocabulary
{
public ProductionProductProductPhotoVocabulary()
{
VocabularyName = "ProductionProductProductPhoto"; // TODO: Set value
KeyPrefix = "adventureWorks.ProductionProductProductPhoto"; // TODO: Set value
KeySeparator = ".";
Grouping = "ProductionProductProductPhoto"; // TODO: Set value

AddGroup("ProductionProductProductPhoto Details", group =>
{
ProductID                 = group.Add(new VocabularyKey("productID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Product ID").WithDescription("Product identification number. Foreign key to Product.ProductID."));
ProductPhotoID            = group.Add(new VocabularyKey("productPhotoID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Product Photo ID").WithDescription("Product photo identification number. Foreign key to ProductPhoto.ProductPhotoID."));
Primary                   = group.Add(new VocabularyKey("primary", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Primary").WithDescription("0 = Photo is not the principal image. 1 = Photo is the principal image."));
ModifiedDate              = group.Add(new VocabularyKey("modifiedDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Modified Date").WithDescription("Date and time the record was last updated."));
});
}

public VocabularyKey ProductID { get; private set; }
public VocabularyKey ProductPhotoID { get; private set; }
public VocabularyKey Primary { get; private set; }
public VocabularyKey ModifiedDate { get; private set; }
}
}
