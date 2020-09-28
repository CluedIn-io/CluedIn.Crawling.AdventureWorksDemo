namespace CluedIn.Crawling.AdventureWorksProduction.Core.Models
{
using System;
using System.ComponentModel;
using System.Data;

[DisplayName("Production.Illustration")]
public class ProductionIllustration : BaseSqlEntity
{
public ProductionIllustration (IDataReader reader) : base (reader)
{
if (reader == null)
{
throw new ArgumentNullException(nameof(reader));
}
IllustrationID            = reader["IllustrationID"].ToString();
Diagram                   = reader.GetStringValue("Diagram");
ModifiedDate              = reader.GetStringValue("ModifiedDate");
}

public string IllustrationID { get; private set; }
public string Diagram { get; private set; }
public string ModifiedDate { get; private set; }
}

}
