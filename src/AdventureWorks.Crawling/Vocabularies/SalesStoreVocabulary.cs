using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.AdventureWorks.Vocabularies
{
public class SalesStoreVocabulary : SimpleVocabulary
{
public SalesStoreVocabulary()
{
VocabularyName = "SalesStore"; // TODO: Set value
KeyPrefix = "adventureWorks.SalesStore"; // TODO: Set value
KeySeparator = ".";
Grouping = "SalesStore"; // TODO: Set value

AddGroup("SalesStore Details", group =>
{
BusinessEntityID          = group.Add(new VocabularyKey("businessEntityID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Business Entity ID").WithDescription("Primary key. Foreign key to Customer.BusinessEntityID."));
Name                      = group.Add(new VocabularyKey("name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Name").WithDescription("Name of the store."));
SalesPersonID             = group.Add(new VocabularyKey("salesPersonID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible).WithDisplayName("Sales Person ID").WithDescription("ID of the sales person assigned to the customer. Foreign key to SalesPerson.BusinessEntityID."));
Demographics              = group.Add(new VocabularyKey("demographics", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Demographics").WithDescription("Demographic informationg about the store such as the number of employees, annual sales and store type."));
Rowguid                   = group.Add(new VocabularyKey("rowguid", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("rowguid").WithDescription("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample."));
ModifiedDate              = group.Add(new VocabularyKey("modifiedDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Modified Date").WithDescription("Date and time the record was last updated."));
});
}

public VocabularyKey BusinessEntityID { get; private set; }
public VocabularyKey Name { get; private set; }
public VocabularyKey SalesPersonID { get; private set; }
public VocabularyKey Demographics { get; private set; }
public VocabularyKey Rowguid { get; private set; }
public VocabularyKey ModifiedDate { get; private set; }
}
}
