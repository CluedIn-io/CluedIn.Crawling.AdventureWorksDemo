namespace CluedIn.Crawling.AdventureWorks.Core.Models
{
using System;
using System.ComponentModel;
using System.Data;

[DisplayName("Production.ProductCostHistory")]
public class ProductionProductCostHistory : BaseSqlEntity
{
public ProductionProductCostHistory (IDataReader reader) : base (reader)
{
if (reader == null)
{
throw new ArgumentNullException(nameof(reader));
}
ProductID                 = reader["ProductID"].ToString();
StartDate                 = reader["StartDate"].ToString();
EndDate                   = reader.GetStringValue("EndDate");
StandardCost              = reader.GetNullableValue<decimal?>("StandardCost");
ModifiedDate              = reader.GetStringValue("ModifiedDate");
}

public string ProductID { get; private set; }
public string StartDate { get; private set; }
public string EndDate { get; private set; }
public decimal? StandardCost { get; private set; }
public string ModifiedDate { get; private set; }
}

}
