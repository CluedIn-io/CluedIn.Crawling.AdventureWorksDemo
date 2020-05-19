namespace CluedIn.Crawling.AdventureWorks.Core.Models
{
using System;
using System.ComponentModel;
using System.Data;

[DisplayName("Production.Culture")]
public class ProductionCulture : BaseSqlEntity
{
public ProductionCulture (IDataReader reader) : base (reader)
{
if (reader == null)
{
throw new ArgumentNullException(nameof(reader));
}
CultureID                 = reader["CultureID"].ToString();
Name                      = reader.GetStringValue("Name");
ModifiedDate              = reader.GetStringValue("ModifiedDate");
}

public string CultureID { get; private set; }
public string Name { get; private set; }
public string ModifiedDate { get; private set; }
}

}
