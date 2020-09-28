using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.AdventureWorksSales.Vocabularies
{
public class SalesSalesTerritoryHistoryVocabulary : SimpleVocabulary
{
public SalesSalesTerritoryHistoryVocabulary()
{
VocabularyName = "SalesSalesTerritoryHistory"; // TODO: Set value
KeyPrefix = "AdventureWorksSales.SalesSalesTerritoryHistory"; // TODO: Set value
KeySeparator = ".";
Grouping = "SalesSalesTerritoryHistory"; // TODO: Set value

AddGroup("SalesSalesTerritoryHistory Details", group =>
{
BusinessEntityID          = group.Add(new VocabularyKey("businessEntityID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Business Entity ID").WithDescription("Primary key. The sales rep.  Foreign key to SalesPerson.BusinessEntityID."));
TerritoryID               = group.Add(new VocabularyKey("territoryID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Territory ID").WithDescription("Primary key. Territory identification number. Foreign key to SalesTerritory.SalesTerritoryID."));
StartDate                 = group.Add(new VocabularyKey("startDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Start Date").WithDescription("Primary key. Date the sales representive started work in the territory."));
EndDate                   = group.Add(new VocabularyKey("endDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("End Date").WithDescription("Date the sales representative left work in the territory."));
Rowguid                   = group.Add(new VocabularyKey("rowguid", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("rowguid").WithDescription("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample."));
ModifiedDate              = group.Add(new VocabularyKey("modifiedDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Modified Date").WithDescription("Date and time the record was last updated."));
});
}

public VocabularyKey BusinessEntityID { get; private set; }
public VocabularyKey TerritoryID { get; private set; }
public VocabularyKey StartDate { get; private set; }
public VocabularyKey EndDate { get; private set; }
public VocabularyKey Rowguid { get; private set; }
public VocabularyKey ModifiedDate { get; private set; }
}
}
