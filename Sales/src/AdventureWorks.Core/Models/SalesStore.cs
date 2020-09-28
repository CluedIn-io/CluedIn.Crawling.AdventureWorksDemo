namespace CluedIn.Crawling.AdventureWorksSales.Core.Models
{
using System;
using System.ComponentModel;
using System.Data;

[DisplayName("Sales.Store")]
public class SalesStore : BaseSqlEntity
{
public SalesStore (IDataReader reader) : base (reader)
{
if (reader == null)
{
throw new ArgumentNullException(nameof(reader));
}
BusinessEntityID          = reader["BusinessEntityID"].ToString();
Name                      = reader.GetStringValue("Name");
SalesPersonID             = reader.GetNullableValue<int?>("SalesPersonID");
Demographics              = reader.GetStringValue("Demographics");
Rowguid                   = reader.GetStringValue("rowguid");
ModifiedDate              = reader.GetStringValue("ModifiedDate");
}

public string BusinessEntityID { get; private set; }
public string Name { get; private set; }
public int? SalesPersonID { get; private set; }
public string Demographics { get; private set; }
public string Rowguid { get; private set; }
public string ModifiedDate { get; private set; }
}

}
