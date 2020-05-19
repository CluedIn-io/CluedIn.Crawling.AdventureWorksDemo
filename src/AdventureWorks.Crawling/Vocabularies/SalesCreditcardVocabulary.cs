using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.AdventureWorks.Vocabularies
{
public class SalesCreditCardVocabulary : SimpleVocabulary
{
public SalesCreditCardVocabulary()
{
VocabularyName = "Sql SalesCreditCard"; // TODO: Set value
KeyPrefix = "sql.SalesCreditCard"; // TODO: Set value
KeySeparator = ".";
Grouping = "SalesCreditCard"; // TODO: Set value

AddGroup("SalesCreditCard Details", group =>
{
CreditCardID              = group.Add(new VocabularyKey("creditCardID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Credit Card ID").WithDescription("Primary key for CreditCard records."));
CardType                  = group.Add(new VocabularyKey("cardType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Card Type").WithDescription("Credit card name."));
CardNumber                = group.Add(new VocabularyKey("cardNumber", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Card Number").WithDescription("Credit card number."));
ExpMonth                  = group.Add(new VocabularyKey("expMonth", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Exp Month").WithDescription("Credit card expiration month."));
ExpYear                   = group.Add(new VocabularyKey("expYear", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible).WithDisplayName("Exp Year").WithDescription("Credit card expiration year."));
ModifiedDate              = group.Add(new VocabularyKey("modifiedDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Modified Date").WithDescription("Date and time the record was last updated."));
});
}

public VocabularyKey CreditCardID { get; private set; }
public VocabularyKey CardType { get; private set; }
public VocabularyKey CardNumber { get; private set; }
public VocabularyKey ExpMonth { get; private set; }
public VocabularyKey ExpYear { get; private set; }
public VocabularyKey ModifiedDate { get; private set; }
}
}
