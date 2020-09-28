namespace CluedIn.Crawling.AdventureWorksProduction.Core.Models
{
using System;
using System.ComponentModel;
using System.Data;

[DisplayName("Production.Location")]
public class ProductionLocation : BaseSqlEntity
{
public ProductionLocation (IDataReader reader) : base (reader)
{
if (reader == null)
{
throw new ArgumentNullException(nameof(reader));
}
LocationID                = reader["LocationID"].ToString();
Name                      = reader.GetStringValue("Name");
CostRate                  = reader.GetNullableValue<decimal?>("CostRate");
Availability              = reader.GetNullableValue<decimal?>("Availability");
ModifiedDate              = reader.GetStringValue("ModifiedDate");
}

public string LocationID { get; private set; }
public string Name { get; private set; }
public decimal? CostRate { get; private set; }
public decimal? Availability { get; private set; }
public string ModifiedDate { get; private set; }
}

}
