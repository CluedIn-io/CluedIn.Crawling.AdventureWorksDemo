namespace CluedIn.Crawling.AdventureWorksSales.Core.Models
{
using System;
using System.ComponentModel;
using System.Data;

[DisplayName("Sales.SalesOrderHeaderSalesReason")]
public class SalesSalesOrderHeaderSalesReason : BaseSqlEntity
{
public SalesSalesOrderHeaderSalesReason (IDataReader reader) : base (reader)
{
if (reader == null)
{
throw new ArgumentNullException(nameof(reader));
}
SalesOrderID              = reader["SalesOrderID"].ToString();
SalesReasonID             = reader["SalesReasonID"].ToString();
ModifiedDate              = reader.GetStringValue("ModifiedDate");
}

public string SalesOrderID { get; private set; }
public string SalesReasonID { get; private set; }
public string ModifiedDate { get; private set; }
}

}
