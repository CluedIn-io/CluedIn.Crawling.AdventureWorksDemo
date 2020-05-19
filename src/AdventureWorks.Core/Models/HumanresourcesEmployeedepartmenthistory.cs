namespace CluedIn.Crawling.AdventureWorks.Core.Models
{
using System;
using System.ComponentModel;
using System.Data;

[DisplayName("HumanResources.EmployeeDepartmentHistory")]
public class HumanResourcesEmployeeDepartmentHistory : BaseSqlEntity
{
public HumanResourcesEmployeeDepartmentHistory (IDataReader reader) : base (reader)
{
if (reader == null)
{
throw new ArgumentNullException(nameof(reader));
}
BusinessEntityID          = reader["BusinessEntityID"].ToString();
DepartmentID              = reader["DepartmentID"].ToString();
ShiftID                   = reader["ShiftID"].ToString();
StartDate                 = reader["StartDate"].ToString();
EndDate                   = reader.GetStringValue("EndDate");
ModifiedDate              = reader.GetStringValue("ModifiedDate");
}

public string BusinessEntityID { get; private set; }
public string DepartmentID { get; private set; }
public string ShiftID { get; private set; }
public string StartDate { get; private set; }
public string EndDate { get; private set; }
public string ModifiedDate { get; private set; }
}

}
