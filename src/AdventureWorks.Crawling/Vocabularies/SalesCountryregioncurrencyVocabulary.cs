using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.AdventureWorks.Vocabularies
{
public class SalesCountryRegionCurrencyVocabulary : SimpleVocabulary
{
public SalesCountryRegionCurrencyVocabulary()
{
VocabularyName = "Sql SalesCountryRegionCurrency"; // TODO: Set value
KeyPrefix = "sql.SalesCountryRegionCurrency"; // TODO: Set value
KeySeparator = ".";
Grouping = "SalesCountryRegionCurrency"; // TODO: Set value

AddGroup("SalesCountryRegionCurrency Details", group =>
{
CountryRegionCode         = group.Add(new VocabularyKey("countryRegionCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Country Region Code").WithDescription("ISO code for countries and regions. Foreign key to CountryRegion.CountryRegionCode."));
CurrencyCode              = group.Add(new VocabularyKey("currencyCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Currency Code").WithDescription("ISO standard currency code. Foreign key to Currency.CurrencyCode."));
ModifiedDate              = group.Add(new VocabularyKey("modifiedDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Modified Date").WithDescription("Date and time the record was last updated."));
});
}

public VocabularyKey CountryRegionCode { get; private set; }
public VocabularyKey CurrencyCode { get; private set; }
public VocabularyKey ModifiedDate { get; private set; }
}
}
