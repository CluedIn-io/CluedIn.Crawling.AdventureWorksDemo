namespace CluedIn.Crawling.AdventureWorks.Core.Models
{
using System;
using System.ComponentModel;
using System.Data;

[DisplayName("Production.ProductProductPhoto")]
public class ProductionProductProductPhoto : BaseSqlEntity
{
public ProductionProductProductPhoto (IDataReader reader) : base (reader)
{
if (reader == null)
{
throw new ArgumentNullException(nameof(reader));
}
ProductID                 = reader["ProductID"].ToString();
ProductPhotoID            = reader["ProductPhotoID"].ToString();
Primary                   = reader.GetStringValue("Primary");
ModifiedDate              = reader.GetStringValue("ModifiedDate");
}

public string ProductID { get; private set; }
public string ProductPhotoID { get; private set; }
public string Primary { get; private set; }
public string ModifiedDate { get; private set; }
}

}
