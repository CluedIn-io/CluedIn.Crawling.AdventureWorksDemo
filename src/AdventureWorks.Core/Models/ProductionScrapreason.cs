namespace CluedIn.Crawling.AdventureWorks.Core.Models
{
using System;
using System.ComponentModel;
using System.Data;

[DisplayName("Production.ScrapReason")]
public class ProductionScrapReason : BaseSqlEntity
{
public ProductionScrapReason (IDataReader reader) : base (reader)
{
if (reader == null)
{
throw new ArgumentNullException(nameof(reader));
}
ScrapReasonID             = reader["ScrapReasonID"].ToString();
Name                      = reader.GetStringValue("Name");
ModifiedDate              = reader.GetStringValue("ModifiedDate");
}

public string ScrapReasonID { get; private set; }
public string Name { get; private set; }
public string ModifiedDate { get; private set; }
}

}
