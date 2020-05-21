using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.AdventureWorks.Vocabularies
{
public class PersonContactTypeVocabulary : SimpleVocabulary
{
public PersonContactTypeVocabulary()
{
VocabularyName = "PersonContactType"; // TODO: Set value
KeyPrefix = "adventureWorks.PersonContactType"; // TODO: Set value
KeySeparator = ".";
Grouping = "PersonContactType"; // TODO: Set value

AddGroup("PersonContactType Details", group =>
{
ContactTypeID             = group.Add(new VocabularyKey("contactTypeID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Contact Type ID").WithDescription("Primary key for ContactType records."));
Name                      = group.Add(new VocabularyKey("name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Name").WithDescription("Contact type description."));
ModifiedDate              = group.Add(new VocabularyKey("modifiedDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Modified Date").WithDescription("Date and time the record was last updated."));
});
}

public VocabularyKey ContactTypeID { get; private set; }
public VocabularyKey Name { get; private set; }
public VocabularyKey ModifiedDate { get; private set; }
}
}
