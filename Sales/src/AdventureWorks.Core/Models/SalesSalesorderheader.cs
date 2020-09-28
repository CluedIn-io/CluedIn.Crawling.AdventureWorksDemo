namespace CluedIn.Crawling.AdventureWorksSales.Core.Models
{
using System;
using System.ComponentModel;
using System.Data;

[DisplayName("Sales.SalesOrderHeader")]
public class SalesSalesOrderHeader : BaseSqlEntity
{
public SalesSalesOrderHeader (IDataReader reader) : base (reader)
{
if (reader == null)
{
throw new ArgumentNullException(nameof(reader));
}
SalesOrderID              = reader["SalesOrderID"].ToString();
RevisionNumber            = reader.GetNullableValue<byte?>("RevisionNumber");
OrderDate                 = reader.GetStringValue("OrderDate");
DueDate                   = reader.GetStringValue("DueDate");
ShipDate                  = reader.GetStringValue("ShipDate");
Status                    = reader.GetNullableValue<byte?>("Status");
OnlineOrderFlag           = reader.GetStringValue("OnlineOrderFlag");
SalesOrderNumber          = reader.GetStringValue("SalesOrderNumber");
PurchaseOrderNumber       = reader.GetStringValue("PurchaseOrderNumber");
AccountNumber             = reader.GetStringValue("AccountNumber");
CustomerID                = reader.GetNullableValue<int?>("CustomerID");
SalesPersonID             = reader.GetNullableValue<int?>("SalesPersonID");
TerritoryID               = reader.GetNullableValue<int?>("TerritoryID");
BillToAddressID           = reader.GetNullableValue<int?>("BillToAddressID");
ShipToAddressID           = reader.GetNullableValue<int?>("ShipToAddressID");
ShipMethodID              = reader.GetNullableValue<int?>("ShipMethodID");
CreditCardID              = reader.GetNullableValue<int?>("CreditCardID");
CreditCardApprovalCode    = reader.GetStringValue("CreditCardApprovalCode");
CurrencyRateID            = reader.GetNullableValue<int?>("CurrencyRateID");
SubTotal                  = reader.GetNullableValue<decimal?>("SubTotal");
TaxAmt                    = reader.GetNullableValue<decimal?>("TaxAmt");
Freight                   = reader.GetNullableValue<decimal?>("Freight");
TotalDue                  = reader.GetNullableValue<decimal?>("TotalDue");
Comment                   = reader.GetStringValue("Comment");
Rowguid                   = reader.GetStringValue("rowguid");
ModifiedDate              = reader.GetStringValue("ModifiedDate");
}

public string SalesOrderID { get; private set; }
public byte? RevisionNumber { get; private set; }
public string OrderDate { get; private set; }
public string DueDate { get; private set; }
public string ShipDate { get; private set; }
public byte? Status { get; private set; }
public string OnlineOrderFlag { get; private set; }
public string SalesOrderNumber { get; private set; }
public string PurchaseOrderNumber { get; private set; }
public string AccountNumber { get; private set; }
public int? CustomerID { get; private set; }
public int? SalesPersonID { get; private set; }
public int? TerritoryID { get; private set; }
public int? BillToAddressID { get; private set; }
public int? ShipToAddressID { get; private set; }
public int? ShipMethodID { get; private set; }
public int? CreditCardID { get; private set; }
public string CreditCardApprovalCode { get; private set; }
public int? CurrencyRateID { get; private set; }
public decimal? SubTotal { get; private set; }
public decimal? TaxAmt { get; private set; }
public decimal? Freight { get; private set; }
public decimal? TotalDue { get; private set; }
public string Comment { get; private set; }
public string Rowguid { get; private set; }
public string ModifiedDate { get; private set; }
}

}
