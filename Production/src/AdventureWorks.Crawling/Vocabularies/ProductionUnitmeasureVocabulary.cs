using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.AdventureWorksProduction.Vocabularies
{
public class ProductionUnitMeasureVocabulary : SimpleVocabulary
{
public ProductionUnitMeasureVocabulary()
{
VocabularyName = "ProductionUnitMeasure"; // TODO: Set value
KeyPrefix = "AdventureWorksProduction.ProductionUnitMeasure"; // TODO: Set value
KeySeparator = ".";
Grouping = "ProductionUnitMeasure"; // TODO: Set value

AddGroup("ProductionUnitMeasure Details", group =>
{
UnitMeasureCode           = group.Add(new VocabularyKey("unitMeasureCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Unit Measure Code").WithDescription("Primary key."));
Name                      = group.Add(new VocabularyKey("name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Name").WithDescription("Unit of measure description."));
ModifiedDate              = group.Add(new VocabularyKey("modifiedDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Modified Date").WithDescription("Date and time the record was last updated."));
});
}

public VocabularyKey UnitMeasureCode { get; private set; }
public VocabularyKey Name { get; private set; }
public VocabularyKey ModifiedDate { get; private set; }
}
}
