using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.AdventureWorks.Vocabularies
{
public class PersonEmailAddressVocabulary : SimpleVocabulary
{
public PersonEmailAddressVocabulary()
{
VocabularyName = "Sql PersonEmailAddress"; // TODO: Set value
KeyPrefix = "sql.PersonEmailAddress"; // TODO: Set value
KeySeparator = ".";
Grouping = "PersonEmailAddress"; // TODO: Set value

AddGroup("PersonEmailAddress Details", group =>
{
BusinessEntityID          = group.Add(new VocabularyKey("businessEntityID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Business Entity ID").WithDescription("Primary key. Person associated with this email address.  Foreign key to Person.BusinessEntityID"));
EmailAddressID            = group.Add(new VocabularyKey("emailAddressID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Email Address ID").WithDescription("Primary key. ID of this email address."));
EmailAddress              = group.Add(new VocabularyKey("emailAddress", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Email Address").WithDescription("E-mail address for the person."));
Rowguid                   = group.Add(new VocabularyKey("rowguid", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("rowguid").WithDescription("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample."));
ModifiedDate              = group.Add(new VocabularyKey("modifiedDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Modified Date").WithDescription("Date and time the record was last updated."));
});
}

public VocabularyKey BusinessEntityID { get; private set; }
public VocabularyKey EmailAddressID { get; private set; }
public VocabularyKey EmailAddress { get; private set; }
public VocabularyKey Rowguid { get; private set; }
public VocabularyKey ModifiedDate { get; private set; }
}
}
