namespace CluedIn.Crawling.AdventureWorksPerson.Core.Models
{
using System;
using System.ComponentModel;
using System.Data;

[DisplayName("Person.BusinessEntity")]
public class PersonBusinessEntity : BaseSqlEntity
{
public PersonBusinessEntity (IDataReader reader) : base (reader)
{
if (reader == null)
{
throw new ArgumentNullException(nameof(reader));
}
BusinessEntityID          = reader["BusinessEntityID"].ToString();
Rowguid                   = reader.GetStringValue("rowguid");
ModifiedDate              = reader.GetStringValue("ModifiedDate");
}

public string BusinessEntityID { get; private set; }
public string Rowguid { get; private set; }
public string ModifiedDate { get; private set; }
}

}
