using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.AdventureWorks.Vocabularies
{
public class PurchasingVendorVocabulary : SimpleVocabulary
{
public PurchasingVendorVocabulary()
{
VocabularyName = "PurchasingVendor"; // TODO: Set value
KeyPrefix = "adventureWorks.PurchasingVendor"; // TODO: Set value
KeySeparator = ".";
Grouping = EntityType.Organization; // TODO: Set value

AddGroup("PurchasingVendor Details", group =>
{
BusinessEntityID          = group.Add(new VocabularyKey("businessEntityID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Business Entity ID").WithDescription("Primary key for Vendor records.  Foreign key to BusinessEntity.BusinessEntityID"));
AccountNumber             = group.Add(new VocabularyKey("accountNumber", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Account Number").WithDescription("Vendor account (identification) number."));
Name                      = group.Add(new VocabularyKey("name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Name").WithDescription("Company name."));
CreditRating              = group.Add(new VocabularyKey("creditRating", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Credit Rating").WithDescription("1 = Superior, 2 = Excellent, 3 = Above average, 4 = Average, 5 = Below average"));
PreferredVendorStatus     = group.Add(new VocabularyKey("preferredVendorStatus", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Preferred Vendor Status").WithDescription("0 = Do not use if another vendor is available. 1 = Preferred over other vendors supplying the same product."));
ActiveFlag                = group.Add(new VocabularyKey("activeFlag", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Active Flag").WithDescription("0 = Vendor no longer used. 1 = Vendor is actively used."));
PurchasingWebServiceURL   = group.Add(new VocabularyKey("purchasingWebServiceURL", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Purchasing Web Service URL").WithDescription("Vendor URL."));
ModifiedDate              = group.Add(new VocabularyKey("modifiedDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Modified Date").WithDescription("Date and time the record was last updated."));
});
}

public VocabularyKey BusinessEntityID { get; private set; }
public VocabularyKey AccountNumber { get; private set; }
public VocabularyKey Name { get; private set; }
public VocabularyKey CreditRating { get; private set; }
public VocabularyKey PreferredVendorStatus { get; private set; }
public VocabularyKey ActiveFlag { get; private set; }
public VocabularyKey PurchasingWebServiceURL { get; private set; }
public VocabularyKey ModifiedDate { get; private set; }
}
}
