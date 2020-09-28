using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.AdventureWorksProduction.Vocabularies
{
public class ProductionProductCostHistoryVocabulary : SimpleVocabulary
{
public ProductionProductCostHistoryVocabulary()
{
VocabularyName = "ProductionProductCostHistory"; // TODO: Set value
KeyPrefix = "AdventureWorksProduction.ProductionProductCostHistory"; // TODO: Set value
KeySeparator = ".";
Grouping = "ProductionProductCostHistory"; // TODO: Set value

AddGroup("ProductionProductCostHistory Details", group =>
{
ProductID                 = group.Add(new VocabularyKey("productID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Product ID").WithDescription("Product identification number. Foreign key to Product.ProductID"));
StartDate                 = group.Add(new VocabularyKey("startDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Start Date").WithDescription("Product cost start date."));
EndDate                   = group.Add(new VocabularyKey("endDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("End Date").WithDescription("Product cost end date."));
StandardCost              = group.Add(new VocabularyKey("standardCost", VocabularyKeyDataType.Money, VocabularyKeyVisibility.Visible).WithDisplayName("Standard Cost").WithDescription("Standard cost of the product."));
ModifiedDate              = group.Add(new VocabularyKey("modifiedDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Modified Date").WithDescription("Date and time the record was last updated."));
});
}

public VocabularyKey ProductID { get; private set; }
public VocabularyKey StartDate { get; private set; }
public VocabularyKey EndDate { get; private set; }
public VocabularyKey StandardCost { get; private set; }
public VocabularyKey ModifiedDate { get; private set; }
}
}
