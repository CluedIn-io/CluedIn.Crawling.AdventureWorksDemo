namespace CluedIn.Crawling.AdventureWorks.Core.Models
{
using System;
using System.ComponentModel;
using System.Data;

[DisplayName("Purchasing.Vendor")]
public class PurchasingVendor : BaseSqlEntity
{
public PurchasingVendor (IDataReader reader) : base (reader)
{
if (reader == null)
{
throw new ArgumentNullException(nameof(reader));
}
BusinessEntityID          = reader["BusinessEntityID"].ToString();
AccountNumber             = reader.GetStringValue("AccountNumber");
Name                      = reader.GetStringValue("Name");
CreditRating              = reader.GetNullableValue<byte?>("CreditRating");
PreferredVendorStatus     = reader.GetStringValue("PreferredVendorStatus");
ActiveFlag                = reader.GetStringValue("ActiveFlag");
PurchasingWebServiceURL   = reader.GetStringValue("PurchasingWebServiceURL");
ModifiedDate              = reader.GetStringValue("ModifiedDate");
}

public string BusinessEntityID { get; private set; }
public string AccountNumber { get; private set; }
public string Name { get; private set; }
public byte? CreditRating { get; private set; }
public string PreferredVendorStatus { get; private set; }
public string ActiveFlag { get; private set; }
public string PurchasingWebServiceURL { get; private set; }
public string ModifiedDate { get; private set; }
}

}
