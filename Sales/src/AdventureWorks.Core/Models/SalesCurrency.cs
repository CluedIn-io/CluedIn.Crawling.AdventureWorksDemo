namespace CluedIn.Crawling.AdventureWorksSales.Core.Models
{
using System;
using System.ComponentModel;
using System.Data;

[DisplayName("Sales.Currency")]
public class SalesCurrency : BaseSqlEntity
{
public SalesCurrency (IDataReader reader) : base (reader)
{
if (reader == null)
{
throw new ArgumentNullException(nameof(reader));
}
CurrencyCode              = reader["CurrencyCode"].ToString();
Name                      = reader.GetStringValue("Name");
ModifiedDate              = reader.GetStringValue("ModifiedDate");
}

public string CurrencyCode { get; private set; }
public string Name { get; private set; }
public string ModifiedDate { get; private set; }
}

}
