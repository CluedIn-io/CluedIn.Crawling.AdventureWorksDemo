namespace CluedIn.Crawling.AdventureWorks.Core.Models
{
using System;
using System.ComponentModel;
using System.Data;

[DisplayName("Sales.SalesPerson")]
public class SalesSalesPerson : BaseSqlEntity
{
public SalesSalesPerson (IDataReader reader) : base (reader)
{
if (reader == null)
{
throw new ArgumentNullException(nameof(reader));
}
BusinessEntityID          = reader["BusinessEntityID"].ToString();
TerritoryID               = reader.GetNullableValue<int?>("TerritoryID");
SalesQuota                = reader.GetNullableValue<decimal?>("SalesQuota");
Bonus                     = reader.GetNullableValue<decimal?>("Bonus");
CommissionPct             = reader.GetNullableValue<decimal?>("CommissionPct");
SalesYTD                  = reader.GetNullableValue<decimal?>("SalesYTD");
SalesLastYear             = reader.GetNullableValue<decimal?>("SalesLastYear");
Rowguid                   = reader.GetStringValue("rowguid");
ModifiedDate              = reader.GetStringValue("ModifiedDate");
}

public string BusinessEntityID { get; private set; }
public int? TerritoryID { get; private set; }
public decimal? SalesQuota { get; private set; }
public decimal? Bonus { get; private set; }
public decimal? CommissionPct { get; private set; }
public decimal? SalesYTD { get; private set; }
public decimal? SalesLastYear { get; private set; }
public string Rowguid { get; private set; }
public string ModifiedDate { get; private set; }
}

}
