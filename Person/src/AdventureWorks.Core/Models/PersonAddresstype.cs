namespace CluedIn.Crawling.AdventureWorksPerson.Core.Models
{
using System;
using System.ComponentModel;
using System.Data;

[DisplayName("Person.AddressType")]
public class PersonAddressType : BaseSqlEntity
{
public PersonAddressType (IDataReader reader) : base (reader)
{
if (reader == null)
{
throw new ArgumentNullException(nameof(reader));
}
AddressTypeID             = reader["AddressTypeID"].ToString();
Name                      = reader.GetStringValue("Name");
Rowguid                   = reader.GetStringValue("rowguid");
ModifiedDate              = reader.GetStringValue("ModifiedDate");
}

public string AddressTypeID { get; private set; }
public string Name { get; private set; }
public string Rowguid { get; private set; }
public string ModifiedDate { get; private set; }
}

}
