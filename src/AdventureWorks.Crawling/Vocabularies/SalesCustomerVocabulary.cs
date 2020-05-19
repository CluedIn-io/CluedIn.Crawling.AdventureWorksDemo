using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.AdventureWorks.Vocabularies
{
public class SalesCustomerVocabulary : SimpleVocabulary
{
public SalesCustomerVocabulary()
{
VocabularyName = "Sql SalesCustomer"; // TODO: Set value
KeyPrefix = "sql.SalesCustomer"; // TODO: Set value
KeySeparator = ".";
Grouping = "SalesCustomer"; // TODO: Set value

AddGroup("SalesCustomer Details", group =>
{
CustomerID                = group.Add(new VocabularyKey("customerID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Customer ID").WithDescription("Primary key."));
PersonID                  = group.Add(new VocabularyKey("personID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible).WithDisplayName("Person ID").WithDescription("Foreign key to Person.BusinessEntityID"));
StoreID                   = group.Add(new VocabularyKey("storeID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible).WithDisplayName("Store ID").WithDescription("Foreign key to Store.BusinessEntityID"));
TerritoryID               = group.Add(new VocabularyKey("territoryID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible).WithDisplayName("Territory ID").WithDescription("ID of the territory in which the customer is located. Foreign key to SalesTerritory.SalesTerritoryID."));
AccountNumber             = group.Add(new VocabularyKey("accountNumber", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Account Number").WithDescription("Unique number identifying the customer assigned by the accounting system."));
Rowguid                   = group.Add(new VocabularyKey("rowguid", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("rowguid").WithDescription("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample."));
ModifiedDate              = group.Add(new VocabularyKey("modifiedDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Modified Date").WithDescription("Date and time the record was last updated."));
});
}

public VocabularyKey CustomerID { get; private set; }
public VocabularyKey PersonID { get; private set; }
public VocabularyKey StoreID { get; private set; }
public VocabularyKey TerritoryID { get; private set; }
public VocabularyKey AccountNumber { get; private set; }
public VocabularyKey Rowguid { get; private set; }
public VocabularyKey ModifiedDate { get; private set; }
}
}
