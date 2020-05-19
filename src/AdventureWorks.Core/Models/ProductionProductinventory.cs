namespace CluedIn.Crawling.AdventureWorks.Core.Models
{
using System;
using System.ComponentModel;
using System.Data;

[DisplayName("Production.ProductInventory")]
public class ProductionProductInventory : BaseSqlEntity
{
public ProductionProductInventory (IDataReader reader) : base (reader)
{
if (reader == null)
{
throw new ArgumentNullException(nameof(reader));
}
ProductID                 = reader["ProductID"].ToString();
LocationID                = reader["LocationID"].ToString();
Shelf                     = reader.GetStringValue("Shelf");
Bin                       = reader.GetNullableValue<byte?>("Bin");
Quantity                  = reader.GetNullableValue<int?>("Quantity");
Rowguid                   = reader.GetStringValue("rowguid");
ModifiedDate              = reader.GetStringValue("ModifiedDate");
}

public string ProductID { get; private set; }
public string LocationID { get; private set; }
public string Shelf { get; private set; }
public byte? Bin { get; private set; }
public int? Quantity { get; private set; }
public string Rowguid { get; private set; }
public string ModifiedDate { get; private set; }
}

}
