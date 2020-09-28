namespace CluedIn.Crawling.AdventureWorksPurchasing.Core.Models
{
using System;
using System.ComponentModel;
using System.Data;

[DisplayName("Purchasing.PurchaseOrderDetail")]
public class PurchasingPurchaseOrderDetail : BaseSqlEntity
{
public PurchasingPurchaseOrderDetail (IDataReader reader) : base (reader)
{
if (reader == null)
{
throw new ArgumentNullException(nameof(reader));
}
PurchaseOrderID           = reader["PurchaseOrderID"].ToString();
PurchaseOrderDetailID     = reader["PurchaseOrderDetailID"].ToString();
DueDate                   = reader.GetStringValue("DueDate");
OrderQty                  = reader.GetNullableValue<int?>("OrderQty");
ProductID                 = reader.GetNullableValue<int?>("ProductID");
UnitPrice                 = reader.GetNullableValue<decimal?>("UnitPrice");
LineTotal                 = reader.GetNullableValue<decimal?>("LineTotal");
ReceivedQty               = reader.GetNullableValue<decimal?>("ReceivedQty");
RejectedQty               = reader.GetNullableValue<decimal?>("RejectedQty");
StockedQty                = reader.GetNullableValue<decimal?>("StockedQty");
ModifiedDate              = reader.GetStringValue("ModifiedDate");
}

public string PurchaseOrderID { get; private set; }
public string PurchaseOrderDetailID { get; private set; }
public string DueDate { get; private set; }
public int? OrderQty { get; private set; }
public int? ProductID { get; private set; }
public decimal? UnitPrice { get; private set; }
public decimal? LineTotal { get; private set; }
public decimal? ReceivedQty { get; private set; }
public decimal? RejectedQty { get; private set; }
public decimal? StockedQty { get; private set; }
public string ModifiedDate { get; private set; }
}

}
