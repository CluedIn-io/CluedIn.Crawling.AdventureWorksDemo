namespace CluedIn.Crawling.AdventureWorksPerson.Core.Models
{
using System;
using System.ComponentModel;
using System.Data;

[DisplayName("Person.ContactType")]
public class PersonContactType : BaseSqlEntity
{
public PersonContactType (IDataReader reader) : base (reader)
{
if (reader == null)
{
throw new ArgumentNullException(nameof(reader));
}
ContactTypeID             = reader["ContactTypeID"].ToString();
Name                      = reader.GetStringValue("Name");
ModifiedDate              = reader.GetStringValue("ModifiedDate");
}

public string ContactTypeID { get; private set; }
public string Name { get; private set; }
public string ModifiedDate { get; private set; }
}

}
