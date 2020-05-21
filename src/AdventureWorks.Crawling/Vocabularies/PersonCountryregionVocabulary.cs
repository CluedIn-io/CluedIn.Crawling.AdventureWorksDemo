using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.AdventureWorks.Vocabularies
{
public class PersonCountryRegionVocabulary : SimpleVocabulary
{
public PersonCountryRegionVocabulary()
{
VocabularyName = "PersonCountryRegion"; // TODO: Set value
KeyPrefix = "adventureWorks.PersonCountryRegion"; // TODO: Set value
KeySeparator = ".";
Grouping = EntityType.Geography.Country; // TODO: Set value

AddGroup("PersonCountryRegion Details", group =>
{
CountryRegionCode         = group.Add(new VocabularyKey("countryRegionCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Country Region Code").WithDescription("ISO standard code for countries and regions."));
Name                      = group.Add(new VocabularyKey("name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Name").WithDescription("Country or region name."));
ModifiedDate              = group.Add(new VocabularyKey("modifiedDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Modified Date").WithDescription("Date and time the record was last updated."));
});
}

public VocabularyKey CountryRegionCode { get; private set; }
public VocabularyKey Name { get; private set; }
public VocabularyKey ModifiedDate { get; private set; }
}
}
