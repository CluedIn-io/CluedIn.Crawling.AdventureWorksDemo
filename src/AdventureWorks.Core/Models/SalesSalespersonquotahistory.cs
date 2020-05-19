namespace CluedIn.Crawling.AdventureWorks.Core.Models
{
using System;
using System.ComponentModel;
using System.Data;

[DisplayName("Sales.SalesPersonQuotaHistory")]
public class SalesSalesPersonQuotaHistory : BaseSqlEntity
{
public SalesSalesPersonQuotaHistory (IDataReader reader) : base (reader)
{
if (reader == null)
{
throw new ArgumentNullException(nameof(reader));
}
BusinessEntityID          = reader["BusinessEntityID"].ToString();
QuotaDate                 = reader["QuotaDate"].ToString();
SalesQuota                = reader.GetNullableValue<decimal?>("SalesQuota");
Rowguid                   = reader.GetStringValue("rowguid");
ModifiedDate              = reader.GetStringValue("ModifiedDate");
}

public string BusinessEntityID { get; private set; }
public string QuotaDate { get; private set; }
public decimal? SalesQuota { get; private set; }
public string Rowguid { get; private set; }
public string ModifiedDate { get; private set; }
}

}
