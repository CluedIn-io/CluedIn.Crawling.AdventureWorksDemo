namespace CluedIn.Crawling.AdventureWorksSales.Core.Models
{
using System;
using System.ComponentModel;
using System.Data;

[DisplayName("Sales.Customer")]
public class SalesCustomer : BaseSqlEntity
{
public SalesCustomer (IDataReader reader) : base (reader)
{
if (reader == null)
{
throw new ArgumentNullException(nameof(reader));
}
CustomerID                = reader["CustomerID"].ToString();
PersonID                  = reader.GetNullableValue<int?>("PersonID");
StoreID                   = reader.GetNullableValue<int?>("StoreID");
TerritoryID               = reader.GetNullableValue<int?>("TerritoryID");
AccountNumber             = reader.GetStringValue("AccountNumber");
Rowguid                   = reader.GetStringValue("rowguid");
ModifiedDate              = reader.GetStringValue("ModifiedDate");
}

public string CustomerID { get; private set; }
public int? PersonID { get; private set; }
public int? StoreID { get; private set; }
public int? TerritoryID { get; private set; }
public string AccountNumber { get; private set; }
public string Rowguid { get; private set; }
public string ModifiedDate { get; private set; }
}

}
