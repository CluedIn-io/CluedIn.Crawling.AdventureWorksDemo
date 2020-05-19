using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.AdventureWorks.Vocabularies
{
public class PersonStateProvinceVocabulary : SimpleVocabulary
{
public PersonStateProvinceVocabulary()
{
VocabularyName = "Sql PersonStateProvince"; // TODO: Set value
KeyPrefix = "sql.PersonStateProvince"; // TODO: Set value
KeySeparator = ".";
Grouping = "PersonStateProvince"; // TODO: Set value

AddGroup("PersonStateProvince Details", group =>
{
StateProvinceID           = group.Add(new VocabularyKey("stateProvinceID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("State Province ID").WithDescription("Primary key for StateProvince records."));
StateProvinceCode         = group.Add(new VocabularyKey("stateProvinceCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("State Province Code").WithDescription("ISO standard state or province code."));
CountryRegionCode         = group.Add(new VocabularyKey("countryRegionCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Country Region Code").WithDescription("ISO standard country or region code. Foreign key to CountryRegion.CountryRegionCode. "));
IsOnlyStateProvinceFlag   = group.Add(new VocabularyKey("isOnlyStateProvinceFlag", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Is Only State Province Flag").WithDescription("0 = StateProvinceCode exists. 1 = StateProvinceCode unavailable, using CountryRegionCode."));
Name                      = group.Add(new VocabularyKey("name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Name").WithDescription("State or province description."));
TerritoryID               = group.Add(new VocabularyKey("territoryID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible).WithDisplayName("Territory ID").WithDescription("ID of the territory in which the state or province is located. Foreign key to SalesTerritory.SalesTerritoryID."));
Rowguid                   = group.Add(new VocabularyKey("rowguid", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("rowguid").WithDescription("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample."));
ModifiedDate              = group.Add(new VocabularyKey("modifiedDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Modified Date").WithDescription("Date and time the record was last updated."));
});
}

public VocabularyKey StateProvinceID { get; private set; }
public VocabularyKey StateProvinceCode { get; private set; }
public VocabularyKey CountryRegionCode { get; private set; }
public VocabularyKey IsOnlyStateProvinceFlag { get; private set; }
public VocabularyKey Name { get; private set; }
public VocabularyKey TerritoryID { get; private set; }
public VocabularyKey Rowguid { get; private set; }
public VocabularyKey ModifiedDate { get; private set; }
}
}
