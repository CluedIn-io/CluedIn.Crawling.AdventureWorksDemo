namespace CluedIn.Crawling.AdventureWorks.Core.Models
{
using System;
using System.ComponentModel;
using System.Data;

[DisplayName("Sales.SalesOrderDetail")]
public class SalesSalesOrderDetail : BaseSqlEntity
{
public SalesSalesOrderDetail (IDataReader reader) : base (reader)
{
if (reader == null)
{
throw new ArgumentNullException(nameof(reader));
}
SalesOrderID              = reader["SalesOrderID"].ToString();
SalesOrderDetailID        = reader["SalesOrderDetailID"].ToString();
CarrierTrackingNumber     = reader.GetStringValue("CarrierTrackingNumber");
OrderQty                  = reader.GetNullableValue<int?>("OrderQty");
ProductID                 = reader.GetNullableValue<int?>("ProductID");
SpecialOfferID            = reader.GetNullableValue<int?>("SpecialOfferID");
UnitPrice                 = reader.GetNullableValue<decimal?>("UnitPrice");
UnitPriceDiscount         = reader.GetNullableValue<decimal?>("UnitPriceDiscount");
LineTotal                 = reader.GetNullableValue<decimal?>("LineTotal");
Rowguid                   = reader.GetStringValue("rowguid");
ModifiedDate              = reader.GetStringValue("ModifiedDate");
}

public string SalesOrderID { get; private set; }
public string SalesOrderDetailID { get; private set; }
public string CarrierTrackingNumber { get; private set; }
public int? OrderQty { get; private set; }
public int? ProductID { get; private set; }
public int? SpecialOfferID { get; private set; }
public decimal? UnitPrice { get; private set; }
public decimal? UnitPriceDiscount { get; private set; }
public decimal? LineTotal { get; private set; }
public string Rowguid { get; private set; }
public string ModifiedDate { get; private set; }
}

}
