using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.AdventureWorks.Vocabularies
{
public class SalesPersonCreditCardVocabulary : SimpleVocabulary
{
public SalesPersonCreditCardVocabulary()
{
VocabularyName = "Sql SalesPersonCreditCard"; // TODO: Set value
KeyPrefix = "sql.SalesPersonCreditCard"; // TODO: Set value
KeySeparator = ".";
Grouping = "SalesPersonCreditCard"; // TODO: Set value

AddGroup("SalesPersonCreditCard Details", group =>
{
BusinessEntityID          = group.Add(new VocabularyKey("businessEntityID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Business Entity ID").WithDescription("Business entity identification number. Foreign key to Person.BusinessEntityID."));
CreditCardID              = group.Add(new VocabularyKey("creditCardID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Credit Card ID").WithDescription("Credit card identification number. Foreign key to CreditCard.CreditCardID."));
ModifiedDate              = group.Add(new VocabularyKey("modifiedDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Modified Date").WithDescription("Date and time the record was last updated."));
});
}

public VocabularyKey BusinessEntityID { get; private set; }
public VocabularyKey CreditCardID { get; private set; }
public VocabularyKey ModifiedDate { get; private set; }
}
}
