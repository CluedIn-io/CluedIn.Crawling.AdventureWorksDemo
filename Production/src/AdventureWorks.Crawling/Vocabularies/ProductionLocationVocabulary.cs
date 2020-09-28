using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.AdventureWorksProduction.Vocabularies
{
public class ProductionLocationVocabulary : SimpleVocabulary
{
public ProductionLocationVocabulary()
{
VocabularyName = "ProductionLocation"; // TODO: Set value
KeyPrefix = "AdventureWorksProduction.ProductionLocation"; // TODO: Set value
KeySeparator = ".";
Grouping = "ProductionLocation"; // TODO: Set value

AddGroup("ProductionLocation Details", group =>
{
LocationID                = group.Add(new VocabularyKey("locationID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Location ID").WithDescription("Primary key for Location records."));
Name                      = group.Add(new VocabularyKey("name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Name").WithDescription("Location description."));
CostRate                  = group.Add(new VocabularyKey("costRate", VocabularyKeyDataType.Money, VocabularyKeyVisibility.Visible).WithDisplayName("Cost Rate").WithDescription("Standard hourly cost of the manufacturing location."));
Availability              = group.Add(new VocabularyKey("availability", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible).WithDisplayName("Availability").WithDescription("Work capacity (in hours) of the manufacturing location."));
ModifiedDate              = group.Add(new VocabularyKey("modifiedDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Modified Date").WithDescription("Date and time the record was last updated."));
});
}

public VocabularyKey LocationID { get; private set; }
public VocabularyKey Name { get; private set; }
public VocabularyKey CostRate { get; private set; }
public VocabularyKey Availability { get; private set; }
public VocabularyKey ModifiedDate { get; private set; }
}
}
