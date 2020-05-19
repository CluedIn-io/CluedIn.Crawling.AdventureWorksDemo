using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.AdventureWorks.Vocabularies
{
public class SalesSalesTaxRateVocabulary : SimpleVocabulary
{
public SalesSalesTaxRateVocabulary()
{
VocabularyName = "Sql SalesSalesTaxRate"; // TODO: Set value
KeyPrefix = "sql.SalesSalesTaxRate"; // TODO: Set value
KeySeparator = ".";
Grouping = "SalesSalesTaxRate"; // TODO: Set value

AddGroup("SalesSalesTaxRate Details", group =>
{
SalesTaxRateID            = group.Add(new VocabularyKey("salesTaxRateID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Sales Tax Rate ID").WithDescription("Primary key for SalesTaxRate records."));
StateProvinceID           = group.Add(new VocabularyKey("stateProvinceID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible).WithDisplayName("State Province ID").WithDescription("State, province, or country/region the sales tax applies to."));
TaxType                   = group.Add(new VocabularyKey("taxType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Tax Type").WithDescription("1 = Tax applied to retail transactions, 2 = Tax applied to wholesale transactions, 3 = Tax applied to all sales (retail and wholesale) transactions."));
TaxRate                   = group.Add(new VocabularyKey("taxRate", VocabularyKeyDataType.Money, VocabularyKeyVisibility.Visible).WithDisplayName("Tax Rate").WithDescription("Tax rate amount."));
Name                      = group.Add(new VocabularyKey("name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Name").WithDescription("Tax rate description."));
Rowguid                   = group.Add(new VocabularyKey("rowguid", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("rowguid").WithDescription("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample."));
ModifiedDate              = group.Add(new VocabularyKey("modifiedDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Modified Date").WithDescription("Date and time the record was last updated."));
});
}

public VocabularyKey SalesTaxRateID { get; private set; }
public VocabularyKey StateProvinceID { get; private set; }
public VocabularyKey TaxType { get; private set; }
public VocabularyKey TaxRate { get; private set; }
public VocabularyKey Name { get; private set; }
public VocabularyKey Rowguid { get; private set; }
public VocabularyKey ModifiedDate { get; private set; }
}
}
