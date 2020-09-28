namespace CluedIn.Crawling.AdventureWorksSales.Core.Models
{
using System;
using System.ComponentModel;
using System.Data;

[DisplayName("Sales.CurrencyRate")]
public class SalesCurrencyRate : BaseSqlEntity
{
public SalesCurrencyRate (IDataReader reader) : base (reader)
{
if (reader == null)
{
throw new ArgumentNullException(nameof(reader));
}
CurrencyRateID            = reader["CurrencyRateID"].ToString();
CurrencyRateDate          = reader.GetStringValue("CurrencyRateDate");
FromCurrencyCode          = reader.GetStringValue("FromCurrencyCode");
ToCurrencyCode            = reader.GetStringValue("ToCurrencyCode");
AverageRate               = reader.GetNullableValue<decimal?>("AverageRate");
EndOfDayRate              = reader.GetNullableValue<decimal?>("EndOfDayRate");
ModifiedDate              = reader.GetStringValue("ModifiedDate");
}

public string CurrencyRateID { get; private set; }
public string CurrencyRateDate { get; private set; }
public string FromCurrencyCode { get; private set; }
public string ToCurrencyCode { get; private set; }
public decimal? AverageRate { get; private set; }
public decimal? EndOfDayRate { get; private set; }
public string ModifiedDate { get; private set; }
}

}
