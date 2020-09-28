namespace CluedIn.Crawling.AdventureWorksHumanResources.Core.Models
{
using System;
using System.ComponentModel;
using System.Data;

[DisplayName("HumanResources.Shift")]
public class HumanResourcesShift : BaseSqlEntity
{
public HumanResourcesShift (IDataReader reader) : base (reader)
{
if (reader == null)
{
throw new ArgumentNullException(nameof(reader));
}
ShiftID                   = reader["ShiftID"].ToString();
Name                      = reader.GetStringValue("Name");
StartTime                 = reader.GetStringValue("StartTime");
EndTime                   = reader.GetStringValue("EndTime");
ModifiedDate              = reader.GetStringValue("ModifiedDate");
}

public string ShiftID { get; private set; }
public string Name { get; private set; }
public string StartTime { get; private set; }
public string EndTime { get; private set; }
public string ModifiedDate { get; private set; }
}

}
