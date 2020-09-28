namespace CluedIn.Crawling.AdventureWorksSales.Core.Models
{
using System;
using System.ComponentModel;
using System.Data;

[DisplayName("Sales.CountryRegionCurrency")]
public class SalesCountryRegionCurrency : BaseSqlEntity
{
public SalesCountryRegionCurrency (IDataReader reader) : base (reader)
{
if (reader == null)
{
throw new ArgumentNullException(nameof(reader));
}
CountryRegionCode         = reader["CountryRegionCode"].ToString();
CurrencyCode              = reader["CurrencyCode"].ToString();
ModifiedDate              = reader.GetStringValue("ModifiedDate");
}

public string CountryRegionCode { get; private set; }
public string CurrencyCode { get; private set; }
public string ModifiedDate { get; private set; }
}

}
