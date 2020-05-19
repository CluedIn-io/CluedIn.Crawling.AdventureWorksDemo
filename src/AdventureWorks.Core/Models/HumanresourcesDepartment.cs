namespace CluedIn.Crawling.AdventureWorks.Core.Models
{
using System;
using System.ComponentModel;
using System.Data;

[DisplayName("HumanResources.Department")]
public class HumanResourcesDepartment : BaseSqlEntity
{
public HumanResourcesDepartment (IDataReader reader) : base (reader)
{
if (reader == null)
{
throw new ArgumentNullException(nameof(reader));
}
DepartmentID              = reader["DepartmentID"].ToString();
Name                      = reader.GetStringValue("Name");
GroupName                 = reader.GetStringValue("GroupName");
ModifiedDate              = reader.GetStringValue("ModifiedDate");
}

public string DepartmentID { get; private set; }
public string Name { get; private set; }
public string GroupName { get; private set; }
public string ModifiedDate { get; private set; }
}

}
