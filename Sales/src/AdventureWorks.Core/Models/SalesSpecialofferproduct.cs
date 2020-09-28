namespace CluedIn.Crawling.AdventureWorksSales.Core.Models
{
using System;
using System.ComponentModel;
using System.Data;

[DisplayName("Sales.SpecialOfferProduct")]
public class SalesSpecialOfferProduct : BaseSqlEntity
{
public SalesSpecialOfferProduct (IDataReader reader) : base (reader)
{
if (reader == null)
{
throw new ArgumentNullException(nameof(reader));
}
SpecialOfferID            = reader["SpecialOfferID"].ToString();
ProductID                 = reader["ProductID"].ToString();
Rowguid                   = reader.GetStringValue("rowguid");
ModifiedDate              = reader.GetStringValue("ModifiedDate");
}

public string SpecialOfferID { get; private set; }
public string ProductID { get; private set; }
public string Rowguid { get; private set; }
public string ModifiedDate { get; private set; }
}

}
