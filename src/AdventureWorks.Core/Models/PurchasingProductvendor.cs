namespace CluedIn.Crawling.AdventureWorks.Core.Models
{
using System;
using System.ComponentModel;
using System.Data;

[DisplayName("Purchasing.ProductVendor")]
public class PurchasingProductVendor : BaseSqlEntity
{
public PurchasingProductVendor (IDataReader reader) : base (reader)
{
if (reader == null)
{
throw new ArgumentNullException(nameof(reader));
}
ProductID                 = reader["ProductID"].ToString();
BusinessEntityID          = reader["BusinessEntityID"].ToString();
AverageLeadTime           = reader.GetNullableValue<int?>("AverageLeadTime");
StandardPrice             = reader.GetNullableValue<decimal?>("StandardPrice");
LastReceiptCost           = reader.GetNullableValue<decimal?>("LastReceiptCost");
LastReceiptDate           = reader.GetStringValue("LastReceiptDate");
MinOrderQty               = reader.GetNullableValue<int?>("MinOrderQty");
MaxOrderQty               = reader.GetNullableValue<int?>("MaxOrderQty");
OnOrderQty                = reader.GetNullableValue<int?>("OnOrderQty");
UnitMeasureCode           = reader.GetStringValue("UnitMeasureCode");
ModifiedDate              = reader.GetStringValue("ModifiedDate");
}

public string ProductID { get; private set; }
public string BusinessEntityID { get; private set; }
public int? AverageLeadTime { get; private set; }
public decimal? StandardPrice { get; private set; }
public decimal? LastReceiptCost { get; private set; }
public string LastReceiptDate { get; private set; }
public int? MinOrderQty { get; private set; }
public int? MaxOrderQty { get; private set; }
public int? OnOrderQty { get; private set; }
public string UnitMeasureCode { get; private set; }
public string ModifiedDate { get; private set; }
}

}
