using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.AdventureWorksPerson.Vocabularies
{
public class PersonAddressTypeVocabulary : SimpleVocabulary
{
public PersonAddressTypeVocabulary()
{
VocabularyName = "PersonAddressType"; // TODO: Set value
KeyPrefix = "AdventureWorksPerson.PersonAddressType"; // TODO: Set value
KeySeparator = ".";
Grouping = "PersonAddressType"; // TODO: Set value

AddGroup("PersonAddressType Details", group =>
{
AddressTypeID             = group.Add(new VocabularyKey("addressTypeID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Address Type ID").WithDescription("Primary key for AddressType records."));
Name                      = group.Add(new VocabularyKey("name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Name").WithDescription("Address type description. For example, Billing, Home, or Shipping."));
Rowguid                   = group.Add(new VocabularyKey("rowguid", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("rowguid").WithDescription("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample."));
ModifiedDate              = group.Add(new VocabularyKey("modifiedDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Modified Date").WithDescription("Date and time the record was last updated."));
});
}

public VocabularyKey AddressTypeID { get; private set; }
public VocabularyKey Name { get; private set; }
public VocabularyKey Rowguid { get; private set; }
public VocabularyKey ModifiedDate { get; private set; }
}
}
