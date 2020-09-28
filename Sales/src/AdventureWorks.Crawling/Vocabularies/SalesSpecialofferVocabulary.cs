using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.AdventureWorksSales.Vocabularies
{
public class SalesSpecialOfferVocabulary : SimpleVocabulary
{
public SalesSpecialOfferVocabulary()
{
VocabularyName = "SalesSpecialOffer"; // TODO: Set value
KeyPrefix = "AdventureWorksSales.SalesSpecialOffer"; // TODO: Set value
KeySeparator = ".";
Grouping = "SalesSpecialOffer"; // TODO: Set value

AddGroup("SalesSpecialOffer Details", group =>
{
SpecialOfferID            = group.Add(new VocabularyKey("specialOfferID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Special Offer ID").WithDescription("Primary key for SpecialOffer records."));
Description               = group.Add(new VocabularyKey("description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Description").WithDescription("Discount description."));
DiscountPct               = group.Add(new VocabularyKey("discountPct", VocabularyKeyDataType.Money, VocabularyKeyVisibility.Visible).WithDisplayName("Discount Pct").WithDescription("Discount precentage."));
Type                      = group.Add(new VocabularyKey("type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Type").WithDescription("Discount type category."));
Category                  = group.Add(new VocabularyKey("category", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Category").WithDescription("Group the discount applies to such as Reseller or Customer."));
StartDate                 = group.Add(new VocabularyKey("startDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Start Date").WithDescription("Discount start date."));
EndDate                   = group.Add(new VocabularyKey("endDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("End Date").WithDescription("Discount end date."));
MinQty                    = group.Add(new VocabularyKey("minQty", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible).WithDisplayName("Min Qty").WithDescription("Minimum discount percent allowed."));
MaxQty                    = group.Add(new VocabularyKey("maxQty", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible).WithDisplayName("Max Qty").WithDescription("Maximum discount percent allowed."));
Rowguid                   = group.Add(new VocabularyKey("rowguid", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("rowguid").WithDescription("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample."));
ModifiedDate              = group.Add(new VocabularyKey("modifiedDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Modified Date").WithDescription("Date and time the record was last updated."));
});
}

public VocabularyKey SpecialOfferID { get; private set; }
public VocabularyKey Description { get; private set; }
public VocabularyKey DiscountPct { get; private set; }
public VocabularyKey Type { get; private set; }
public VocabularyKey Category { get; private set; }
public VocabularyKey StartDate { get; private set; }
public VocabularyKey EndDate { get; private set; }
public VocabularyKey MinQty { get; private set; }
public VocabularyKey MaxQty { get; private set; }
public VocabularyKey Rowguid { get; private set; }
public VocabularyKey ModifiedDate { get; private set; }
}
}
