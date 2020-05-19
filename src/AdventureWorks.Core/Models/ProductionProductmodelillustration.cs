namespace CluedIn.Crawling.AdventureWorks.Core.Models
{
using System;
using System.ComponentModel;
using System.Data;

[DisplayName("Production.ProductModelIllustration")]
public class ProductionProductModelIllustration : BaseSqlEntity
{
public ProductionProductModelIllustration (IDataReader reader) : base (reader)
{
if (reader == null)
{
throw new ArgumentNullException(nameof(reader));
}
ProductModelID            = reader["ProductModelID"].ToString();
IllustrationID            = reader["IllustrationID"].ToString();
ModifiedDate              = reader.GetStringValue("ModifiedDate");
}

public string ProductModelID { get; private set; }
public string IllustrationID { get; private set; }
public string ModifiedDate { get; private set; }
}

}
