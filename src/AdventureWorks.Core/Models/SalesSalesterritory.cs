namespace CluedIn.Crawling.AdventureWorks.Core.Models
{
using System;
using System.ComponentModel;
using System.Data;

[DisplayName("Sales.SalesTerritory")]
public class SalesSalesTerritory : BaseSqlEntity
{
public SalesSalesTerritory (IDataReader reader) : base (reader)
{
if (reader == null)
{
throw new ArgumentNullException(nameof(reader));
}
TerritoryID               = reader["TerritoryID"].ToString();
Name                      = reader.GetStringValue("Name");
CountryRegionCode         = reader.GetStringValue("CountryRegionCode");
Group                     = reader.GetStringValue("Group");
SalesYTD                  = reader.GetNullableValue<decimal?>("SalesYTD");
SalesLastYear             = reader.GetNullableValue<decimal?>("SalesLastYear");
CostYTD                   = reader.GetNullableValue<decimal?>("CostYTD");
CostLastYear              = reader.GetNullableValue<decimal?>("CostLastYear");
Rowguid                   = reader.GetStringValue("rowguid");
ModifiedDate              = reader.GetStringValue("ModifiedDate");
}

public string TerritoryID { get; private set; }
public string Name { get; private set; }
public string CountryRegionCode { get; private set; }
public string Group { get; private set; }
public decimal? SalesYTD { get; private set; }
public decimal? SalesLastYear { get; private set; }
public decimal? CostYTD { get; private set; }
public decimal? CostLastYear { get; private set; }
public string Rowguid { get; private set; }
public string ModifiedDate { get; private set; }
}

}
