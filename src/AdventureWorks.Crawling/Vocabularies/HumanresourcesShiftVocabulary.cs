using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.AdventureWorks.Vocabularies
{
public class HumanResourcesShiftVocabulary : SimpleVocabulary
{
public HumanResourcesShiftVocabulary()
{
VocabularyName = "HumanResourcesShift"; // TODO: Set value
KeyPrefix = "adventureWorks.HumanResourcesShift"; // TODO: Set value
KeySeparator = ".";
Grouping = EntityType.HR.WorkSchedule; // TODO: Set value

AddGroup("HumanResourcesShift Details", group =>
{
ShiftID                   = group.Add(new VocabularyKey("shiftID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Shift ID").WithDescription("Primary key for Shift records."));
Name                      = group.Add(new VocabularyKey("name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Name").WithDescription("Shift description."));
StartTime                 = group.Add(new VocabularyKey("startTime", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Start Time").WithDescription("Shift start time."));
EndTime                   = group.Add(new VocabularyKey("endTime", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("End Time").WithDescription("Shift end time."));
ModifiedDate              = group.Add(new VocabularyKey("modifiedDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Modified Date").WithDescription("Date and time the record was last updated."));
});
}

public VocabularyKey ShiftID { get; private set; }
public VocabularyKey Name { get; private set; }
public VocabularyKey StartTime { get; private set; }
public VocabularyKey EndTime { get; private set; }
public VocabularyKey ModifiedDate { get; private set; }
}
}
