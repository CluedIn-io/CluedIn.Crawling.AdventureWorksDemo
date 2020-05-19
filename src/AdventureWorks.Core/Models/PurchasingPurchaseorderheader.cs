namespace CluedIn.Crawling.AdventureWorks.Core.Models
{
using System;
using System.ComponentModel;
using System.Data;

[DisplayName("Purchasing.PurchaseOrderHeader")]
public class PurchasingPurchaseOrderHeader : BaseSqlEntity
{
public PurchasingPurchaseOrderHeader (IDataReader reader) : base (reader)
{
if (reader == null)
{
throw new ArgumentNullException(nameof(reader));
}
PurchaseOrderID           = reader["PurchaseOrderID"].ToString();
RevisionNumber            = reader.GetNullableValue<byte?>("RevisionNumber");
Status                    = reader.GetNullableValue<byte?>("Status");
EmployeeID                = reader.GetNullableValue<int?>("EmployeeID");
VendorID                  = reader.GetNullableValue<int?>("VendorID");
ShipMethodID              = reader.GetNullableValue<int?>("ShipMethodID");
OrderDate                 = reader.GetStringValue("OrderDate");
ShipDate                  = reader.GetStringValue("ShipDate");
SubTotal                  = reader.GetNullableValue<decimal?>("SubTotal");
TaxAmt                    = reader.GetNullableValue<decimal?>("TaxAmt");
Freight                   = reader.GetNullableValue<decimal?>("Freight");
TotalDue                  = reader.GetNullableValue<decimal?>("TotalDue");
ModifiedDate              = reader.GetStringValue("ModifiedDate");
}

public string PurchaseOrderID { get; private set; }
public byte? RevisionNumber { get; private set; }
public byte? Status { get; private set; }
public int? EmployeeID { get; private set; }
public int? VendorID { get; private set; }
public int? ShipMethodID { get; private set; }
public string OrderDate { get; private set; }
public string ShipDate { get; private set; }
public decimal? SubTotal { get; private set; }
public decimal? TaxAmt { get; private set; }
public decimal? Freight { get; private set; }
public decimal? TotalDue { get; private set; }
public string ModifiedDate { get; private set; }
}

}
