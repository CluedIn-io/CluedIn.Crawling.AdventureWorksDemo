namespace CluedIn.Crawling.AdventureWorksPurchasing.Core.Models
{
using System;
using System.ComponentModel;
using System.Data;

[DisplayName("Purchasing.ShipMethod")]
public class PurchasingShipMethod : BaseSqlEntity
{
public PurchasingShipMethod (IDataReader reader) : base (reader)
{
if (reader == null)
{
throw new ArgumentNullException(nameof(reader));
}
ShipMethodID              = reader["ShipMethodID"].ToString();
Name                      = reader.GetStringValue("Name");
ShipBase                  = reader.GetNullableValue<decimal?>("ShipBase");
ShipRate                  = reader.GetNullableValue<decimal?>("ShipRate");
Rowguid                   = reader.GetStringValue("rowguid");
ModifiedDate              = reader.GetStringValue("ModifiedDate");
}

public string ShipMethodID { get; private set; }
public string Name { get; private set; }
public decimal? ShipBase { get; private set; }
public decimal? ShipRate { get; private set; }
public string Rowguid { get; private set; }
public string ModifiedDate { get; private set; }
}

}
