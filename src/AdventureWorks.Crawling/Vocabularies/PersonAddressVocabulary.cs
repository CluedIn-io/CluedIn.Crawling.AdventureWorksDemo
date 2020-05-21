using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.AdventureWorks.Vocabularies
{
public class PersonAddressVocabulary : SimpleVocabulary
{
public PersonAddressVocabulary()
{
VocabularyName = "PersonAddress"; // TODO: Set value
KeyPrefix = "adventureWorks.PersonAddress"; // TODO: Set value
KeySeparator = ".";
Grouping = "PersonAddress"; // TODO: Set value

AddGroup("PersonAddress Details", group =>
{
AddressID                 = group.Add(new VocabularyKey("addressID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Address ID").WithDescription("Primary key for Address records."));
AddressLine1              = group.Add(new VocabularyKey("addressLine1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Address Line1").WithDescription("First street address line."));
AddressLine2              = group.Add(new VocabularyKey("addressLine2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Address Line2").WithDescription("Second street address line."));
City                      = group.Add(new VocabularyKey("city", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("City").WithDescription("Name of the city."));
StateProvinceID           = group.Add(new VocabularyKey("stateProvinceID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible).WithDisplayName("State Province ID").WithDescription("Unique identification number for the state or province. Foreign key to StateProvince table."));
PostalCode                = group.Add(new VocabularyKey("postalCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Postal Code").WithDescription("Postal code for the street address."));
//SpatialLocation           = group.Add(new VocabularyKey("spatialLocation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Spatial Location").WithDescription("Latitude and longitude of this address."));
Rowguid                   = group.Add(new VocabularyKey("rowguid", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("rowguid").WithDescription("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample."));
ModifiedDate              = group.Add(new VocabularyKey("modifiedDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Modified Date").WithDescription("Date and time the record was last updated."));
});
}

public VocabularyKey AddressID { get; private set; }
public VocabularyKey AddressLine1 { get; private set; }
public VocabularyKey AddressLine2 { get; private set; }
public VocabularyKey City { get; private set; }
public VocabularyKey StateProvinceID { get; private set; }
public VocabularyKey PostalCode { get; private set; }
//public VocabularyKey SpatialLocation { get; private set; }
public VocabularyKey Rowguid { get; private set; }
public VocabularyKey ModifiedDate { get; private set; }
}
}
