using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.AdventureWorks.Vocabularies
{
public class SalesSalesPersonVocabulary : SimpleVocabulary
{
public SalesSalesPersonVocabulary()
{
VocabularyName = "Sql SalesSalesPerson"; // TODO: Set value
KeyPrefix = "sql.SalesSalesPerson"; // TODO: Set value
KeySeparator = ".";
Grouping = "SalesSalesPerson"; // TODO: Set value

AddGroup("SalesSalesPerson Details", group =>
{
BusinessEntityID          = group.Add(new VocabularyKey("businessEntityID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Business Entity ID").WithDescription("Primary key for SalesPerson records. Foreign key to Employee.BusinessEntityID"));
TerritoryID               = group.Add(new VocabularyKey("territoryID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible).WithDisplayName("Territory ID").WithDescription("Territory currently assigned to. Foreign key to SalesTerritory.SalesTerritoryID."));
SalesQuota                = group.Add(new VocabularyKey("salesQuota", VocabularyKeyDataType.Money, VocabularyKeyVisibility.Visible).WithDisplayName("Sales Quota").WithDescription("Projected yearly sales."));
Bonus                     = group.Add(new VocabularyKey("bonus", VocabularyKeyDataType.Money, VocabularyKeyVisibility.Visible).WithDisplayName("Bonus").WithDescription("Bonus due if quota is met."));
CommissionPct             = group.Add(new VocabularyKey("commissionPct", VocabularyKeyDataType.Money, VocabularyKeyVisibility.Visible).WithDisplayName("Commission Pct").WithDescription("Commision percent received per sale."));
SalesYTD                  = group.Add(new VocabularyKey("salesYTD", VocabularyKeyDataType.Money, VocabularyKeyVisibility.Visible).WithDisplayName("Sales YTD").WithDescription("Sales total year to date."));
SalesLastYear             = group.Add(new VocabularyKey("salesLastYear", VocabularyKeyDataType.Money, VocabularyKeyVisibility.Visible).WithDisplayName("Sales Last Year").WithDescription("Sales total of previous year."));
Rowguid                   = group.Add(new VocabularyKey("rowguid", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("rowguid").WithDescription("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample."));
ModifiedDate              = group.Add(new VocabularyKey("modifiedDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Modified Date").WithDescription("Date and time the record was last updated."));
});
}

public VocabularyKey BusinessEntityID { get; private set; }
public VocabularyKey TerritoryID { get; private set; }
public VocabularyKey SalesQuota { get; private set; }
public VocabularyKey Bonus { get; private set; }
public VocabularyKey CommissionPct { get; private set; }
public VocabularyKey SalesYTD { get; private set; }
public VocabularyKey SalesLastYear { get; private set; }
public VocabularyKey Rowguid { get; private set; }
public VocabularyKey ModifiedDate { get; private set; }
}
}
