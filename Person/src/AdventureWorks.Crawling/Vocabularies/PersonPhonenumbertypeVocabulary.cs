using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.AdventureWorksPerson.Vocabularies
{
public class PersonPhoneNumberTypeVocabulary : SimpleVocabulary
{
public PersonPhoneNumberTypeVocabulary()
{
VocabularyName = "PersonPhoneNumberType"; // TODO: Set value
KeyPrefix = "AdventureWorksPerson.PersonPhoneNumberType"; // TODO: Set value
KeySeparator = ".";
Grouping = "PersonPhoneNumberType"; // TODO: Set value

AddGroup("PersonPhoneNumberType Details", group =>
{
PhoneNumberTypeID         = group.Add(new VocabularyKey("phoneNumberTypeID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Phone Number Type ID").WithDescription("Primary key for telephone number type records."));
Name                      = group.Add(new VocabularyKey("name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Name").WithDescription("Name of the telephone number type"));
ModifiedDate              = group.Add(new VocabularyKey("modifiedDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Modified Date").WithDescription("Date and time the record was last updated."));
});
}

public VocabularyKey PhoneNumberTypeID { get; private set; }
public VocabularyKey Name { get; private set; }
public VocabularyKey ModifiedDate { get; private set; }
}
}
