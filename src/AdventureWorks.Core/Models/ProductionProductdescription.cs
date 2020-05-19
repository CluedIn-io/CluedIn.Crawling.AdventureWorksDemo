namespace CluedIn.Crawling.AdventureWorks.Core.Models
{
using System;
using System.ComponentModel;
using System.Data;

[DisplayName("Production.ProductDescription")]
public class ProductionProductDescription : BaseSqlEntity
{
public ProductionProductDescription (IDataReader reader) : base (reader)
{
if (reader == null)
{
throw new ArgumentNullException(nameof(reader));
}
ProductDescriptionID      = reader["ProductDescriptionID"].ToString();
Description               = reader.GetStringValue("Description");
Rowguid                   = reader.GetStringValue("rowguid");
ModifiedDate              = reader.GetStringValue("ModifiedDate");
}

public string ProductDescriptionID { get; private set; }
public string Description { get; private set; }
public string Rowguid { get; private set; }
public string ModifiedDate { get; private set; }
}

}
