namespace CluedIn.Crawling.AdventureWorksSales.Core.Models
{
using System;
using System.ComponentModel;
using System.Data;

[DisplayName("Sales.SalesReason")]
public class SalesSalesReason : BaseSqlEntity
{
public SalesSalesReason (IDataReader reader) : base (reader)
{
if (reader == null)
{
throw new ArgumentNullException(nameof(reader));
}
SalesReasonID             = reader["SalesReasonID"].ToString();
Name                      = reader.GetStringValue("Name");
ReasonType                = reader.GetStringValue("ReasonType");
ModifiedDate              = reader.GetStringValue("ModifiedDate");
}

public string SalesReasonID { get; private set; }
public string Name { get; private set; }
public string ReasonType { get; private set; }
public string ModifiedDate { get; private set; }
}

}
