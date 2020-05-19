using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.AdventureWorks.Vocabularies
{
public class ProductionCultureVocabulary : SimpleVocabulary
{
public ProductionCultureVocabulary()
{
VocabularyName = "Sql ProductionCulture"; // TODO: Set value
KeyPrefix = "sql.ProductionCulture"; // TODO: Set value
KeySeparator = ".";
Grouping = "ProductionCulture"; // TODO: Set value

AddGroup("ProductionCulture Details", group =>
{
CultureID                 = group.Add(new VocabularyKey("cultureID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Culture ID").WithDescription("Primary key for Culture records."));
Name                      = group.Add(new VocabularyKey("name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Name").WithDescription("Culture description."));
ModifiedDate              = group.Add(new VocabularyKey("modifiedDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Modified Date").WithDescription("Date and time the record was last updated."));
});
}

public VocabularyKey CultureID { get; private set; }
public VocabularyKey Name { get; private set; }
public VocabularyKey ModifiedDate { get; private set; }
}
}
