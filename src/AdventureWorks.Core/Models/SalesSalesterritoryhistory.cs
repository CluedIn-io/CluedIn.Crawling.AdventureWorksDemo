namespace CluedIn.Crawling.AdventureWorks.Core.Models
{
using System;
using System.ComponentModel;
using System.Data;

[DisplayName("Sales.SalesTerritoryHistory")]
public class SalesSalesTerritoryHistory : BaseSqlEntity
{
public SalesSalesTerritoryHistory (IDataReader reader) : base (reader)
{
if (reader == null)
{
throw new ArgumentNullException(nameof(reader));
}
BusinessEntityID          = reader["BusinessEntityID"].ToString();
TerritoryID               = reader["TerritoryID"].ToString();
StartDate                 = reader["StartDate"].ToString();
EndDate                   = reader.GetStringValue("EndDate");
Rowguid                   = reader.GetStringValue("rowguid");
ModifiedDate              = reader.GetStringValue("ModifiedDate");
}

public string BusinessEntityID { get; private set; }
public string TerritoryID { get; private set; }
public string StartDate { get; private set; }
public string EndDate { get; private set; }
public string Rowguid { get; private set; }
public string ModifiedDate { get; private set; }
}

}
