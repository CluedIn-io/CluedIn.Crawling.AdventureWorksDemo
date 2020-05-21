using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.AdventureWorks.Vocabularies
{
public class PersonBusinessEntityAddressVocabulary : SimpleVocabulary
{
public PersonBusinessEntityAddressVocabulary()
{
VocabularyName = "PersonBusinessEntityAddress"; // TODO: Set value
KeyPrefix = "adventureWorks.PersonBusinessEntityAddress"; // TODO: Set value
KeySeparator = ".";
Grouping = "PersonBusinessEntityAddress"; // TODO: Set value

AddGroup("PersonBusinessEntityAddress Details", group =>
{
BusinessEntityID          = group.Add(new VocabularyKey("businessEntityID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Business Entity ID").WithDescription("Primary key. Foreign key to BusinessEntity.BusinessEntityID."));
AddressID                 = group.Add(new VocabularyKey("addressID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Address ID").WithDescription("Primary key. Foreign key to Address.AddressID."));
AddressTypeID             = group.Add(new VocabularyKey("addressTypeID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Address Type ID").WithDescription("Primary key. Foreign key to AddressType.AddressTypeID."));
Rowguid                   = group.Add(new VocabularyKey("rowguid", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("rowguid").WithDescription("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample."));
ModifiedDate              = group.Add(new VocabularyKey("modifiedDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Modified Date").WithDescription("Date and time the record was last updated."));
});
}

public VocabularyKey BusinessEntityID { get; private set; }
public VocabularyKey AddressID { get; private set; }
public VocabularyKey AddressTypeID { get; private set; }
public VocabularyKey Rowguid { get; private set; }
public VocabularyKey ModifiedDate { get; private set; }
}
}
