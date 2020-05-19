namespace CluedIn.Crawling.AdventureWorks.Core.Models
{
using System;
using System.ComponentModel;
using System.Data;

[DisplayName("Production.ProductCategory")]
public class ProductionProductCategory : BaseSqlEntity
{
public ProductionProductCategory (IDataReader reader) : base (reader)
{
if (reader == null)
{
throw new ArgumentNullException(nameof(reader));
}
ProductCategoryID         = reader["ProductCategoryID"].ToString();
Name                      = reader.GetStringValue("Name");
Rowguid                   = reader.GetStringValue("rowguid");
ModifiedDate              = reader.GetStringValue("ModifiedDate");
}

public string ProductCategoryID { get; private set; }
public string Name { get; private set; }
public string Rowguid { get; private set; }
public string ModifiedDate { get; private set; }
}

}
