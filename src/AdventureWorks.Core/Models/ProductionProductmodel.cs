namespace CluedIn.Crawling.AdventureWorks.Core.Models
{
using System;
using System.ComponentModel;
using System.Data;

[DisplayName("Production.ProductModel")]
public class ProductionProductModel : BaseSqlEntity
{
public ProductionProductModel (IDataReader reader) : base (reader)
{
if (reader == null)
{
throw new ArgumentNullException(nameof(reader));
}
ProductModelID            = reader["ProductModelID"].ToString();
Name                      = reader.GetStringValue("Name");
CatalogDescription        = reader.GetStringValue("CatalogDescription");
Instructions              = reader.GetStringValue("Instructions");
Rowguid                   = reader.GetStringValue("rowguid");
ModifiedDate              = reader.GetStringValue("ModifiedDate");
}

public string ProductModelID { get; private set; }
public string Name { get; private set; }
public string CatalogDescription { get; private set; }
public string Instructions { get; private set; }
public string Rowguid { get; private set; }
public string ModifiedDate { get; private set; }
}

}
