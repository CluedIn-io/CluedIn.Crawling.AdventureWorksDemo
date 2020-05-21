using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.AdventureWorks.Vocabularies
{
public class ProductionProductInventoryVocabulary : SimpleVocabulary
{
public ProductionProductInventoryVocabulary()
{
VocabularyName = "ProductionProductInventory"; // TODO: Set value
KeyPrefix = "adventureWorks.ProductionProductInventory"; // TODO: Set value
KeySeparator = ".";
Grouping = "ProductionProductInventory"; // TODO: Set value

AddGroup("ProductionProductInventory Details", group =>
{
ProductID                 = group.Add(new VocabularyKey("productID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Product ID").WithDescription("Product identification number. Foreign key to Product.ProductID."));
LocationID                = group.Add(new VocabularyKey("locationID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Location ID").WithDescription("Inventory location identification number. Foreign key to Location.LocationID. "));
Shelf                     = group.Add(new VocabularyKey("shelf", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Shelf").WithDescription("Storage compartment within an inventory location."));
Bin                       = group.Add(new VocabularyKey("bin", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Bin").WithDescription("Storage container on a shelf in an inventory location."));
Quantity                  = group.Add(new VocabularyKey("quantity", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible).WithDisplayName("Quantity").WithDescription("Quantity of products in the inventory location."));
Rowguid                   = group.Add(new VocabularyKey("rowguid", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("rowguid").WithDescription("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample."));
ModifiedDate              = group.Add(new VocabularyKey("modifiedDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Modified Date").WithDescription("Date and time the record was last updated."));
});
}

public VocabularyKey ProductID { get; private set; }
public VocabularyKey LocationID { get; private set; }
public VocabularyKey Shelf { get; private set; }
public VocabularyKey Bin { get; private set; }
public VocabularyKey Quantity { get; private set; }
public VocabularyKey Rowguid { get; private set; }
public VocabularyKey ModifiedDate { get; private set; }
}
}
