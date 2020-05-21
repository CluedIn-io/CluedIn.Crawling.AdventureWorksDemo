using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.AdventureWorks.Vocabularies
{
public class PersonPersonPhoneVocabulary : SimpleVocabulary
{
public PersonPersonPhoneVocabulary()
{
VocabularyName = "PersonPersonPhone"; // TODO: Set value
KeyPrefix = "adventureWorks.PersonPersonPhone"; // TODO: Set value
KeySeparator = ".";
Grouping = EntityType.PhoneNumber; // TODO: Set value

AddGroup("PersonPersonPhone Details", group =>
{
BusinessEntityID          = group.Add(new VocabularyKey("businessEntityID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Business Entity ID").WithDescription("Business entity identification number. Foreign key to Person.BusinessEntityID."));
PhoneNumber               = group.Add(new VocabularyKey("phoneNumber", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Phone Number").WithDescription("Telephone number identification number."));
PhoneNumberTypeID         = group.Add(new VocabularyKey("phoneNumberTypeID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Phone Number Type ID").WithDescription("Kind of phone number. Foreign key to PhoneNumberType.PhoneNumberTypeID."));
ModifiedDate              = group.Add(new VocabularyKey("modifiedDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Modified Date").WithDescription("Date and time the record was last updated."));
});
}

public VocabularyKey BusinessEntityID { get; private set; }
public VocabularyKey PhoneNumber { get; private set; }
public VocabularyKey PhoneNumberTypeID { get; private set; }
public VocabularyKey ModifiedDate { get; private set; }
}
}
