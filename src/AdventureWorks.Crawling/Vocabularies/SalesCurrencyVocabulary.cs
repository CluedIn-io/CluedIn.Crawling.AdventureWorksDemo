using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.AdventureWorks.Vocabularies
{
public class SalesCurrencyVocabulary : SimpleVocabulary
{
public SalesCurrencyVocabulary()
{
VocabularyName = "SalesCurrency"; // TODO: Set value
KeyPrefix = "adventureWorks.SalesCurrency"; // TODO: Set value
KeySeparator = ".";
Grouping = "SalesCurrency"; // TODO: Set value

AddGroup("SalesCurrency Details", group =>
{
CurrencyCode              = group.Add(new VocabularyKey("currencyCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Currency Code").WithDescription("The ISO code for the Currency."));
Name                      = group.Add(new VocabularyKey("name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Name").WithDescription("Currency name."));
ModifiedDate              = group.Add(new VocabularyKey("modifiedDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Modified Date").WithDescription("Date and time the record was last updated."));
});
}

public VocabularyKey CurrencyCode { get; private set; }
public VocabularyKey Name { get; private set; }
public VocabularyKey ModifiedDate { get; private set; }
}
}
