using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.AdventureWorks.Vocabularies
{
public class PersonPasswordVocabulary : SimpleVocabulary
{
public PersonPasswordVocabulary()
{
VocabularyName = "Sql PersonPassword"; // TODO: Set value
KeyPrefix = "sql.PersonPassword"; // TODO: Set value
KeySeparator = ".";
Grouping = "PersonPassword"; // TODO: Set value

AddGroup("PersonPassword Details", group =>
{
BusinessEntityID          = group.Add(new VocabularyKey("businessEntityID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Business Entity ID").WithDescription(""));
PasswordHash              = group.Add(new VocabularyKey("passwordHash", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Password Hash").WithDescription("Password for the e-mail account."));
PasswordSalt              = group.Add(new VocabularyKey("passwordSalt", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Password Salt").WithDescription("Random value concatenated with the password string before the password is hashed."));
Rowguid                   = group.Add(new VocabularyKey("rowguid", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("rowguid").WithDescription("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample."));
ModifiedDate              = group.Add(new VocabularyKey("modifiedDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Modified Date").WithDescription("Date and time the record was last updated."));
});
}

public VocabularyKey BusinessEntityID { get; private set; }
public VocabularyKey PasswordHash { get; private set; }
public VocabularyKey PasswordSalt { get; private set; }
public VocabularyKey Rowguid { get; private set; }
public VocabularyKey ModifiedDate { get; private set; }
}
}
