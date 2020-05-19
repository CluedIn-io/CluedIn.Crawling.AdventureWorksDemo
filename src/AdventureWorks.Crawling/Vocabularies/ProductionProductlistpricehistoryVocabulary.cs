using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.AdventureWorks.Vocabularies
{
public class ProductionProductListPriceHistoryVocabulary : SimpleVocabulary
{
public ProductionProductListPriceHistoryVocabulary()
{
VocabularyName = "Sql ProductionProductListPriceHistory"; // TODO: Set value
KeyPrefix = "sql.ProductionProductListPriceHistory"; // TODO: Set value
KeySeparator = ".";
Grouping = "ProductionProductListPriceHistory"; // TODO: Set value

AddGroup("ProductionProductListPriceHistory Details", group =>
{
ProductID                 = group.Add(new VocabularyKey("productID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Product ID").WithDescription("Product identification number. Foreign key to Product.ProductID"));
StartDate                 = group.Add(new VocabularyKey("startDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Start Date").WithDescription("List price start date."));
EndDate                   = group.Add(new VocabularyKey("endDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("End Date").WithDescription("List price end date"));
ListPrice                 = group.Add(new VocabularyKey("listPrice", VocabularyKeyDataType.Money, VocabularyKeyVisibility.Visible).WithDisplayName("List Price").WithDescription("Product list price."));
ModifiedDate              = group.Add(new VocabularyKey("modifiedDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Modified Date").WithDescription("Date and time the record was last updated."));
});
}

public VocabularyKey ProductID { get; private set; }
public VocabularyKey StartDate { get; private set; }
public VocabularyKey EndDate { get; private set; }
public VocabularyKey ListPrice { get; private set; }
public VocabularyKey ModifiedDate { get; private set; }
}
}
