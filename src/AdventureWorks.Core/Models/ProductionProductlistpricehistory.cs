namespace CluedIn.Crawling.AdventureWorks.Core.Models
{
using System;
using System.ComponentModel;
using System.Data;

[DisplayName("Production.ProductListPriceHistory")]
public class ProductionProductListPriceHistory : BaseSqlEntity
{
public ProductionProductListPriceHistory (IDataReader reader) : base (reader)
{
if (reader == null)
{
throw new ArgumentNullException(nameof(reader));
}
ProductID                 = reader["ProductID"].ToString();
StartDate                 = reader["StartDate"].ToString();
EndDate                   = reader.GetStringValue("EndDate");
ListPrice                 = reader.GetNullableValue<decimal?>("ListPrice");
ModifiedDate              = reader.GetStringValue("ModifiedDate");
}

public string ProductID { get; private set; }
public string StartDate { get; private set; }
public string EndDate { get; private set; }
public decimal? ListPrice { get; private set; }
public string ModifiedDate { get; private set; }
}

}
