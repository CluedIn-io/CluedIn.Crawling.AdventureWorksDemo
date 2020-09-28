using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.AdventureWorksProduction.Vocabularies
{
public class ProductionProductPhotoVocabulary : SimpleVocabulary
{
public ProductionProductPhotoVocabulary()
{
VocabularyName = "ProductionProductPhoto"; // TODO: Set value
KeyPrefix = "AdventureWorksProduction.ProductionProductPhoto"; // TODO: Set value
KeySeparator = ".";
Grouping = EntityType.Images.Image; // TODO: Set value

AddGroup("ProductionProductPhoto Details", group =>
{
ProductPhotoID            = group.Add(new VocabularyKey("productPhotoID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Product Photo ID").WithDescription("Primary key for ProductPhoto records."));
ThumbNailPhoto            = group.Add(new VocabularyKey("thumbNailPhoto", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Thumb Nail Photo").WithDescription("Small image of the product."));
ThumbnailPhotoFileName    = group.Add(new VocabularyKey("thumbnailPhotoFileName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Thumbnail Photo File Name").WithDescription("Small image file name."));
LargePhoto                = group.Add(new VocabularyKey("largePhoto", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Large Photo").WithDescription("Large image of the product."));
LargePhotoFileName        = group.Add(new VocabularyKey("largePhotoFileName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Large Photo File Name").WithDescription("Large image file name."));
ModifiedDate              = group.Add(new VocabularyKey("modifiedDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Modified Date").WithDescription("Date and time the record was last updated."));
});
}

public VocabularyKey ProductPhotoID { get; private set; }
public VocabularyKey ThumbNailPhoto { get; private set; }
public VocabularyKey ThumbnailPhotoFileName { get; private set; }
public VocabularyKey LargePhoto { get; private set; }
public VocabularyKey LargePhotoFileName { get; private set; }
public VocabularyKey ModifiedDate { get; private set; }
}
}
