using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.AdventureWorks.Vocabularies
{
public class SalesSalesTerritoryVocabulary : SimpleVocabulary
{
public SalesSalesTerritoryVocabulary()
{
VocabularyName = "SalesSalesTerritory"; // TODO: Set value
KeyPrefix = "adventureWorks.SalesSalesTerritory"; // TODO: Set value
KeySeparator = ".";
Grouping = "SalesSalesTerritory"; // TODO: Set value

AddGroup("SalesSalesTerritory Details", group =>
{
TerritoryID               = group.Add(new VocabularyKey("territoryID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Territory ID").WithDescription("Primary key for SalesTerritory records."));
Name                      = group.Add(new VocabularyKey("name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Name").WithDescription("Sales territory description"));
CountryRegionCode         = group.Add(new VocabularyKey("countryRegionCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Country Region Code").WithDescription("ISO standard country or region code. Foreign key to CountryRegion.CountryRegionCode. "));
Group                     = group.Add(new VocabularyKey("group", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Group").WithDescription("Geographic area to which the sales territory belong."));
SalesYTD                  = group.Add(new VocabularyKey("salesYTD", VocabularyKeyDataType.Money, VocabularyKeyVisibility.Visible).WithDisplayName("Sales YTD").WithDescription("Sales in the territory year to date."));
SalesLastYear             = group.Add(new VocabularyKey("salesLastYear", VocabularyKeyDataType.Money, VocabularyKeyVisibility.Visible).WithDisplayName("Sales Last Year").WithDescription("Sales in the territory the previous year."));
CostYTD                   = group.Add(new VocabularyKey("costYTD", VocabularyKeyDataType.Money, VocabularyKeyVisibility.Visible).WithDisplayName("Cost YTD").WithDescription("Business costs in the territory year to date."));
CostLastYear              = group.Add(new VocabularyKey("costLastYear", VocabularyKeyDataType.Money, VocabularyKeyVisibility.Visible).WithDisplayName("Cost Last Year").WithDescription("Business costs in the territory the previous year."));
Rowguid                   = group.Add(new VocabularyKey("rowguid", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("rowguid").WithDescription("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample."));
ModifiedDate              = group.Add(new VocabularyKey("modifiedDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Modified Date").WithDescription("Date and time the record was last updated."));
});
}

public VocabularyKey TerritoryID { get; private set; }
public VocabularyKey Name { get; private set; }
public VocabularyKey CountryRegionCode { get; private set; }
public VocabularyKey Group { get; private set; }
public VocabularyKey SalesYTD { get; private set; }
public VocabularyKey SalesLastYear { get; private set; }
public VocabularyKey CostYTD { get; private set; }
public VocabularyKey CostLastYear { get; private set; }
public VocabularyKey Rowguid { get; private set; }
public VocabularyKey ModifiedDate { get; private set; }
}
}
