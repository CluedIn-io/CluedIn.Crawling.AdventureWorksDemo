namespace CluedIn.Crawling.AdventureWorks.Core.Models
{
using System;
using System.ComponentModel;
using System.Data;

[DisplayName("Person.Password")]
public class PersonPassword : BaseSqlEntity
{
public PersonPassword (IDataReader reader) : base (reader)
{
if (reader == null)
{
throw new ArgumentNullException(nameof(reader));
}
BusinessEntityID          = reader["BusinessEntityID"].ToString();
PasswordHash              = reader.GetStringValue("PasswordHash");
PasswordSalt              = reader.GetStringValue("PasswordSalt");
Rowguid                   = reader.GetStringValue("rowguid");
ModifiedDate              = reader.GetStringValue("ModifiedDate");
}

public string BusinessEntityID { get; private set; }
public string PasswordHash { get; private set; }
public string PasswordSalt { get; private set; }
public string Rowguid { get; private set; }
public string ModifiedDate { get; private set; }
}

}
