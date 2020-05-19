namespace CluedIn.Crawling.AdventureWorks.Core.Models
{
using System;
using System.ComponentModel;
using System.Data;

[DisplayName("Production.ProductDocument")]
public class ProductionProductDocument : BaseSqlEntity
{
public ProductionProductDocument (IDataReader reader) : base (reader)
{
if (reader == null)
{
throw new ArgumentNullException(nameof(reader));
}
ProductID                 = reader["ProductID"].ToString();
DocumentNode              = reader["DocumentNode"].ToString();
ModifiedDate              = reader.GetStringValue("ModifiedDate");
}

public string ProductID { get; private set; }
public string DocumentNode { get; private set; }
public string ModifiedDate { get; private set; }
}

}
