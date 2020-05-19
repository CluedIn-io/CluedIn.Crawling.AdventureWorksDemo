namespace CluedIn.Crawling.AdventureWorks.Core.Models
{
using System;
using System.ComponentModel;
using System.Data;

[DisplayName("Person.PhoneNumberType")]
public class PersonPhoneNumberType : BaseSqlEntity
{
public PersonPhoneNumberType (IDataReader reader) : base (reader)
{
if (reader == null)
{
throw new ArgumentNullException(nameof(reader));
}
PhoneNumberTypeID         = reader["PhoneNumberTypeID"].ToString();
Name                      = reader.GetStringValue("Name");
ModifiedDate              = reader.GetStringValue("ModifiedDate");
}

public string PhoneNumberTypeID { get; private set; }
public string Name { get; private set; }
public string ModifiedDate { get; private set; }
}

}
