using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.AdventureWorks.Vocabularies
{
    public class HumanResourcesDepartmentVocabulary : SimpleVocabulary
    {
        public HumanResourcesDepartmentVocabulary()
        {
            VocabularyName = "HumanResourcesDepartment"; // TODO: Set value
            KeyPrefix = "adventureWorks.HumanResourcesDepartment"; // TODO: Set value
            KeySeparator = ".";
            Grouping = EntityType.Organization.Department; // TODO: Set value

            AddGroup("HumanResourcesDepartment Details", group =>
            {
                DepartmentID = group.Add(new VocabularyKey("departmentID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Department ID").WithDescription("Primary key for Department records."));
                Name = group.Add(new VocabularyKey("name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Name").WithDescription("Name of the department."));
                GroupName = group.Add(new VocabularyKey("groupName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Group Name").WithDescription("Name of the group to which the department belongs."));
                ModifiedDate = group.Add(new VocabularyKey("modifiedDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Modified Date").WithDescription("Date and time the record was last updated."));
            });
        }

        public VocabularyKey DepartmentID { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey GroupName { get; private set; }
        public VocabularyKey ModifiedDate { get; private set; }
    }
}
