namespace CluedIn.Crawling.AdventureWorksPerson.Core.Models
{
using System;
using System.ComponentModel;
using System.Data;

[DisplayName("Person.CountryRegion")]
public class PersonCountryRegion : BaseSqlEntity
{
public PersonCountryRegion (IDataReader reader) : base (reader)
{
if (reader == null)
{
throw new ArgumentNullException(nameof(reader));
}
CountryRegionCode         = reader["CountryRegionCode"].ToString();
Name                      = reader.GetStringValue("Name");
ModifiedDate              = reader.GetStringValue("ModifiedDate");
}

public string CountryRegionCode { get; private set; }
public string Name { get; private set; }
public string ModifiedDate { get; private set; }
}

}
