namespace CluedIn.Crawling.AdventureWorks.Core.Models
{
using System;
using System.ComponentModel;
using System.Data;

[DisplayName("Person.StateProvince")]
public class PersonStateProvince : BaseSqlEntity
{
public PersonStateProvince (IDataReader reader) : base (reader)
{
if (reader == null)
{
throw new ArgumentNullException(nameof(reader));
}
StateProvinceID           = reader["StateProvinceID"].ToString();
StateProvinceCode         = reader.GetStringValue("StateProvinceCode");
CountryRegionCode         = reader.GetStringValue("CountryRegionCode");
IsOnlyStateProvinceFlag   = reader.GetStringValue("IsOnlyStateProvinceFlag");
Name                      = reader.GetStringValue("Name");
TerritoryID               = reader.GetNullableValue<int?>("TerritoryID");
Rowguid                   = reader.GetStringValue("rowguid");
ModifiedDate              = reader.GetStringValue("ModifiedDate");
}

public string StateProvinceID { get; private set; }
public string StateProvinceCode { get; private set; }
public string CountryRegionCode { get; private set; }
public string IsOnlyStateProvinceFlag { get; private set; }
public string Name { get; private set; }
public int? TerritoryID { get; private set; }
public string Rowguid { get; private set; }
public string ModifiedDate { get; private set; }
}

}
