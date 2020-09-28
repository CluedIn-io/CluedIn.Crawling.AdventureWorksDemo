namespace CluedIn.Crawling.AdventureWorksProduction.Core.Models
{
using System;
using System.ComponentModel;
using System.Data;

[DisplayName("Production.ProductModelProductDescriptionCulture")]
public class ProductionProductModelProductDescriptionCulture : BaseSqlEntity
{
public ProductionProductModelProductDescriptionCulture (IDataReader reader) : base (reader)
{
if (reader == null)
{
throw new ArgumentNullException(nameof(reader));
}
ProductModelID            = reader["ProductModelID"].ToString();
ProductDescriptionID      = reader["ProductDescriptionID"].ToString();
CultureID                 = reader["CultureID"].ToString();
ModifiedDate              = reader.GetStringValue("ModifiedDate");
}

public string ProductModelID { get; private set; }
public string ProductDescriptionID { get; private set; }
public string CultureID { get; private set; }
public string ModifiedDate { get; private set; }
}

}
