namespace CluedIn.Crawling.AdventureWorksSales.Core.Models
{
using System;
using System.ComponentModel;
using System.Data;

[DisplayName("Sales.SalesTaxRate")]
public class SalesSalesTaxRate : BaseSqlEntity
{
public SalesSalesTaxRate (IDataReader reader) : base (reader)
{
if (reader == null)
{
throw new ArgumentNullException(nameof(reader));
}
SalesTaxRateID            = reader["SalesTaxRateID"].ToString();
StateProvinceID           = reader.GetNullableValue<int?>("StateProvinceID");
TaxType                   = reader.GetNullableValue<byte?>("TaxType");
TaxRate                   = reader.GetNullableValue<decimal?>("TaxRate");
Name                      = reader.GetStringValue("Name");
Rowguid                   = reader.GetStringValue("rowguid");
ModifiedDate              = reader.GetStringValue("ModifiedDate");
}

public string SalesTaxRateID { get; private set; }
public int? StateProvinceID { get; private set; }
public byte? TaxType { get; private set; }
public decimal? TaxRate { get; private set; }
public string Name { get; private set; }
public string Rowguid { get; private set; }
public string ModifiedDate { get; private set; }
}

}
