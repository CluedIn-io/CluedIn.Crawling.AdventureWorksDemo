using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.AdventureWorksPerson.Vocabularies
{
public class PersonBusinessEntityContactVocabulary : SimpleVocabulary
{
public PersonBusinessEntityContactVocabulary()
{
VocabularyName = "PersonBusinessEntityContact"; // TODO: Set value
KeyPrefix = "AdventureWorksPerson.PersonBusinessEntityContact"; // TODO: Set value
KeySeparator = ".";
Grouping = "PersonBusinessEntityContact"; // TODO: Set value

AddGroup("PersonBusinessEntityContact Details", group =>
{
BusinessEntityID          = group.Add(new VocabularyKey("businessEntityID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Business Entity ID").WithDescription("Primary key. Foreign key to BusinessEntity.BusinessEntityID."));
PersonID                  = group.Add(new VocabularyKey("personID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Person ID").WithDescription("Primary key. Foreign key to Person.BusinessEntityID."));
ContactTypeID             = group.Add(new VocabularyKey("contactTypeID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Contact Type ID").WithDescription("Primary key.  Foreign key to ContactType.ContactTypeID."));
Rowguid                   = group.Add(new VocabularyKey("rowguid", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("rowguid").WithDescription("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample."));
ModifiedDate              = group.Add(new VocabularyKey("modifiedDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Modified Date").WithDescription("Date and time the record was last updated."));
});
}

public VocabularyKey BusinessEntityID { get; private set; }
public VocabularyKey PersonID { get; private set; }
public VocabularyKey ContactTypeID { get; private set; }
public VocabularyKey Rowguid { get; private set; }
public VocabularyKey ModifiedDate { get; private set; }
}
}
