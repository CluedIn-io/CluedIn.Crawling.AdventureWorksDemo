namespace CluedIn.Crawling.AdventureWorks.Core.Models
{
using System;
using System.ComponentModel;
using System.Data;

[DisplayName("Person.BusinessEntityContact")]
public class PersonBusinessEntityContact : BaseSqlEntity
{
public PersonBusinessEntityContact (IDataReader reader) : base (reader)
{
if (reader == null)
{
throw new ArgumentNullException(nameof(reader));
}
BusinessEntityID          = reader["BusinessEntityID"].ToString();
PersonID                  = reader["PersonID"].ToString();
ContactTypeID             = reader["ContactTypeID"].ToString();
Rowguid                   = reader.GetStringValue("rowguid");
ModifiedDate              = reader.GetStringValue("ModifiedDate");
}

public string BusinessEntityID { get; private set; }
public string PersonID { get; private set; }
public string ContactTypeID { get; private set; }
public string Rowguid { get; private set; }
public string ModifiedDate { get; private set; }
}

}
