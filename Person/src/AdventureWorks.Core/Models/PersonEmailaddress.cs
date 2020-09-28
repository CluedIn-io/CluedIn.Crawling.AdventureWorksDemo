namespace CluedIn.Crawling.AdventureWorksPerson.Core.Models
{
using System;
using System.ComponentModel;
using System.Data;

[DisplayName("Person.EmailAddress")]
public class PersonEmailAddress : BaseSqlEntity
{
public PersonEmailAddress (IDataReader reader) : base (reader)
{
if (reader == null)
{
throw new ArgumentNullException(nameof(reader));
}
BusinessEntityID          = reader["BusinessEntityID"].ToString();
EmailAddressID            = reader["EmailAddressID"].ToString();
EmailAddress              = reader.GetStringValue("EmailAddress");
Rowguid                   = reader.GetStringValue("rowguid");
ModifiedDate              = reader.GetStringValue("ModifiedDate");
}

public string BusinessEntityID { get; private set; }
public string EmailAddressID { get; private set; }
public string EmailAddress { get; private set; }
public string Rowguid { get; private set; }
public string ModifiedDate { get; private set; }
}

}
