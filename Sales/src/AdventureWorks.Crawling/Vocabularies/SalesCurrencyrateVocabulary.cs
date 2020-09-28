using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.AdventureWorksSales.Vocabularies
{
public class SalesCurrencyRateVocabulary : SimpleVocabulary
{
public SalesCurrencyRateVocabulary()
{
VocabularyName = "SalesCurrencyRate"; // TODO: Set value
KeyPrefix = "AdventureWorksSales.SalesCurrencyRate"; // TODO: Set value
KeySeparator = ".";
Grouping = "SalesCurrencyRate"; // TODO: Set value

AddGroup("SalesCurrencyRate Details", group =>
{
CurrencyRateID            = group.Add(new VocabularyKey("currencyRateID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Currency Rate ID").WithDescription("Primary key for CurrencyRate records."));
CurrencyRateDate          = group.Add(new VocabularyKey("currencyRateDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Currency Rate Date").WithDescription("Date and time the exchange rate was obtained."));
FromCurrencyCode          = group.Add(new VocabularyKey("fromCurrencyCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("From Currency Code").WithDescription("Exchange rate was converted from this currency code."));
ToCurrencyCode            = group.Add(new VocabularyKey("toCurrencyCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("To Currency Code").WithDescription("Exchange rate was converted to this currency code."));
AverageRate               = group.Add(new VocabularyKey("averageRate", VocabularyKeyDataType.Money, VocabularyKeyVisibility.Visible).WithDisplayName("Average Rate").WithDescription("Average exchange rate for the day."));
EndOfDayRate              = group.Add(new VocabularyKey("endOfDayRate", VocabularyKeyDataType.Money, VocabularyKeyVisibility.Visible).WithDisplayName("End Of Day Rate").WithDescription("Final exchange rate for the day."));
ModifiedDate              = group.Add(new VocabularyKey("modifiedDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Modified Date").WithDescription("Date and time the record was last updated."));
});
}

public VocabularyKey CurrencyRateID { get; private set; }
public VocabularyKey CurrencyRateDate { get; private set; }
public VocabularyKey FromCurrencyCode { get; private set; }
public VocabularyKey ToCurrencyCode { get; private set; }
public VocabularyKey AverageRate { get; private set; }
public VocabularyKey EndOfDayRate { get; private set; }
public VocabularyKey ModifiedDate { get; private set; }
}
}
