using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.AdventureWorks.Vocabularies
{
public class SalesShoppingCartItemVocabulary : SimpleVocabulary
{
public SalesShoppingCartItemVocabulary()
{
VocabularyName = "Sql SalesShoppingCartItem"; // TODO: Set value
KeyPrefix = "sql.SalesShoppingCartItem"; // TODO: Set value
KeySeparator = ".";
Grouping = "SalesShoppingCartItem"; // TODO: Set value

AddGroup("SalesShoppingCartItem Details", group =>
{
ShoppingCartItemID        = group.Add(new VocabularyKey("shoppingCartItemID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Shopping Cart Item ID").WithDescription("Primary key for ShoppingCartItem records."));
ShoppingCartID            = group.Add(new VocabularyKey("shoppingCartID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Shopping Cart ID").WithDescription("Shopping cart identification number."));
Quantity                  = group.Add(new VocabularyKey("quantity", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible).WithDisplayName("Quantity").WithDescription("Product quantity ordered."));
ProductID                 = group.Add(new VocabularyKey("productID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible).WithDisplayName("Product ID").WithDescription("Product ordered. Foreign key to Product.ProductID."));
DateCreated               = group.Add(new VocabularyKey("dateCreated", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Date Created").WithDescription("Date the time the record was created."));
ModifiedDate              = group.Add(new VocabularyKey("modifiedDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Modified Date").WithDescription("Date and time the record was last updated."));
});
}

public VocabularyKey ShoppingCartItemID { get; private set; }
public VocabularyKey ShoppingCartID { get; private set; }
public VocabularyKey Quantity { get; private set; }
public VocabularyKey ProductID { get; private set; }
public VocabularyKey DateCreated { get; private set; }
public VocabularyKey ModifiedDate { get; private set; }
}
}
