namespace CluedIn.Crawling.AdventureWorks.Core.Models
{
using System;
using System.ComponentModel;
using System.Data;

[DisplayName("Person.PersonPhone")]
public class PersonPersonPhone : BaseSqlEntity
{
public PersonPersonPhone (IDataReader reader) : base (reader)
{
if (reader == null)
{
throw new ArgumentNullException(nameof(reader));
}
BusinessEntityID          = reader["BusinessEntityID"].ToString();
PhoneNumber               = reader["PhoneNumber"].ToString();
PhoneNumberTypeID         = reader["PhoneNumberTypeID"].ToString();
ModifiedDate              = reader.GetStringValue("ModifiedDate");
}

public string BusinessEntityID { get; private set; }
public string PhoneNumber { get; private set; }
public string PhoneNumberTypeID { get; private set; }
public string ModifiedDate { get; private set; }
}

}
