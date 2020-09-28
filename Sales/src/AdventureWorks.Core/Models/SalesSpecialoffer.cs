namespace CluedIn.Crawling.AdventureWorksSales.Core.Models
{
using System;
using System.ComponentModel;
using System.Data;

[DisplayName("Sales.SpecialOffer")]
public class SalesSpecialOffer : BaseSqlEntity
{
public SalesSpecialOffer (IDataReader reader) : base (reader)
{
if (reader == null)
{
throw new ArgumentNullException(nameof(reader));
}
SpecialOfferID            = reader["SpecialOfferID"].ToString();
Description               = reader.GetStringValue("Description");
DiscountPct               = reader.GetNullableValue<decimal?>("DiscountPct");
Type                      = reader.GetStringValue("Type");
Category                  = reader.GetStringValue("Category");
StartDate                 = reader.GetStringValue("StartDate");
EndDate                   = reader.GetStringValue("EndDate");
MinQty                    = reader.GetNullableValue<int?>("MinQty");
MaxQty                    = reader.GetNullableValue<int?>("MaxQty");
Rowguid                   = reader.GetStringValue("rowguid");
ModifiedDate              = reader.GetStringValue("ModifiedDate");
}

public string SpecialOfferID { get; private set; }
public string Description { get; private set; }
public decimal? DiscountPct { get; private set; }
public string Type { get; private set; }
public string Category { get; private set; }
public string StartDate { get; private set; }
public string EndDate { get; private set; }
public int? MinQty { get; private set; }
public int? MaxQty { get; private set; }
public string Rowguid { get; private set; }
public string ModifiedDate { get; private set; }
}

}
