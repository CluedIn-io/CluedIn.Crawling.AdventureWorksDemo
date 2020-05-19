namespace CluedIn.Crawling.AdventureWorks.Core.Models
{
using System;
using System.ComponentModel;
using System.Data;

[DisplayName("Person.BusinessEntityAddress")]
public class PersonBusinessEntityAddress : BaseSqlEntity
{
public PersonBusinessEntityAddress (IDataReader reader) : base (reader)
{
if (reader == null)
{
throw new ArgumentNullException(nameof(reader));
}
BusinessEntityID          = reader["BusinessEntityID"].ToString();
AddressID                 = reader["AddressID"].ToString();
AddressTypeID             = reader["AddressTypeID"].ToString();
Rowguid                   = reader.GetStringValue("rowguid");
ModifiedDate              = reader.GetStringValue("ModifiedDate");
}

public string BusinessEntityID { get; private set; }
public string AddressID { get; private set; }
public string AddressTypeID { get; private set; }
public string Rowguid { get; private set; }
public string ModifiedDate { get; private set; }
}

}
