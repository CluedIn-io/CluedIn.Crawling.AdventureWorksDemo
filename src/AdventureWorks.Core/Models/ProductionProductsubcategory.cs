namespace CluedIn.Crawling.AdventureWorks.Core.Models
{
using System;
using System.ComponentModel;
using System.Data;

[DisplayName("Production.ProductSubcategory")]
public class ProductionProductSubcategory : BaseSqlEntity
{
public ProductionProductSubcategory (IDataReader reader) : base (reader)
{
if (reader == null)
{
throw new ArgumentNullException(nameof(reader));
}
ProductSubcategoryID      = reader["ProductSubcategoryID"].ToString();
ProductCategoryID         = reader.GetNullableValue<int?>("ProductCategoryID");
Name                      = reader.GetStringValue("Name");
Rowguid                   = reader.GetStringValue("rowguid");
ModifiedDate              = reader.GetStringValue("ModifiedDate");
}

public string ProductSubcategoryID { get; private set; }
public int? ProductCategoryID { get; private set; }
public string Name { get; private set; }
public string Rowguid { get; private set; }
public string ModifiedDate { get; private set; }
}

}
