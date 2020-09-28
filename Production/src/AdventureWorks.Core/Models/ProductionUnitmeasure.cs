namespace CluedIn.Crawling.AdventureWorksProduction.Core.Models
{
using System;
using System.ComponentModel;
using System.Data;

[DisplayName("Production.UnitMeasure")]
public class ProductionUnitMeasure : BaseSqlEntity
{
public ProductionUnitMeasure (IDataReader reader) : base (reader)
{
if (reader == null)
{
throw new ArgumentNullException(nameof(reader));
}
UnitMeasureCode           = reader["UnitMeasureCode"].ToString();
Name                      = reader.GetStringValue("Name");
ModifiedDate              = reader.GetStringValue("ModifiedDate");
}

public string UnitMeasureCode { get; private set; }
public string Name { get; private set; }
public string ModifiedDate { get; private set; }
}

}
