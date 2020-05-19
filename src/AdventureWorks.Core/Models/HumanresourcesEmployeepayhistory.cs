namespace CluedIn.Crawling.AdventureWorks.Core.Models
{
using System;
using System.ComponentModel;
using System.Data;

[DisplayName("HumanResources.EmployeePayHistory")]
public class HumanResourcesEmployeePayHistory : BaseSqlEntity
{
public HumanResourcesEmployeePayHistory (IDataReader reader) : base (reader)
{
if (reader == null)
{
throw new ArgumentNullException(nameof(reader));
}
BusinessEntityID          = reader["BusinessEntityID"].ToString();
RateChangeDate            = reader["RateChangeDate"].ToString();
Rate                      = reader.GetNullableValue<decimal?>("Rate");
PayFrequency              = reader.GetNullableValue<byte?>("PayFrequency");
ModifiedDate              = reader.GetStringValue("ModifiedDate");
}

public string BusinessEntityID { get; private set; }
public string RateChangeDate { get; private set; }
public decimal? Rate { get; private set; }
public byte? PayFrequency { get; private set; }
public string ModifiedDate { get; private set; }
}

}
