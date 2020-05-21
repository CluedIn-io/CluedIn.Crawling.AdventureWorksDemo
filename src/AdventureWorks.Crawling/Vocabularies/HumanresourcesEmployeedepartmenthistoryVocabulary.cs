using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.AdventureWorks.Vocabularies
{
public class HumanResourcesEmployeeDepartmentHistoryVocabulary : SimpleVocabulary
{
public HumanResourcesEmployeeDepartmentHistoryVocabulary()
{
VocabularyName = "HumanResourcesEmployeeDepartmentHistory"; // TODO: Set value
KeyPrefix = "adventureWorks.HumanResourcesEmployeeDepartmentHistory"; // TODO: Set value
KeySeparator = ".";
Grouping = "HumanResourcesEmployeeDepartmentHistory"; // TODO: Set value

AddGroup("HumanResourcesEmployeeDepartmentHistory Details", group =>
{
BusinessEntityID          = group.Add(new VocabularyKey("businessEntityID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Business Entity ID").WithDescription("Employee identification number. Foreign key to Employee.BusinessEntityID."));
DepartmentID              = group.Add(new VocabularyKey("departmentID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Department ID").WithDescription("Department in which the employee worked including currently. Foreign key to Department.DepartmentID."));
ShiftID                   = group.Add(new VocabularyKey("shiftID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Shift ID").WithDescription("Identifies which 8-hour shift the employee works. Foreign key to Shift.Shift.ID."));
StartDate                 = group.Add(new VocabularyKey("startDate", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Start Date").WithDescription("Date the employee started work in the department."));
EndDate                   = group.Add(new VocabularyKey("endDate", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("End Date").WithDescription("Date the employee left the department. NULL = Current department."));
ModifiedDate              = group.Add(new VocabularyKey("modifiedDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Modified Date").WithDescription("Date and time the record was last updated."));
});
}

public VocabularyKey BusinessEntityID { get; private set; }
public VocabularyKey DepartmentID { get; private set; }
public VocabularyKey ShiftID { get; private set; }
public VocabularyKey StartDate { get; private set; }
public VocabularyKey EndDate { get; private set; }
public VocabularyKey ModifiedDate { get; private set; }
}
}
