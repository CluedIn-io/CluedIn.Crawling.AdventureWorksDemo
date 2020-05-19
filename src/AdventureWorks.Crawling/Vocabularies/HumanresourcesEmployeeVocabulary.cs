using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.AdventureWorks.Vocabularies
{
    public class HumanResourcesEmployeeVocabulary : SimpleVocabulary
    {
        public HumanResourcesEmployeeVocabulary()
        {
            VocabularyName = "Sql HumanResourcesEmployee"; // TODO: Set value
            KeyPrefix = "sql.HumanResourcesEmployee"; // TODO: Set value
            KeySeparator = ".";
            Grouping = "HumanResourcesEmployee"; // TODO: Set value

            AddGroup("HumanResourcesEmployee Details", group =>
            {
                BusinessEntityID = group.Add(new VocabularyKey("businessEntityID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Business Entity ID").WithDescription("Primary key for Employee records.  Foreign key to BusinessEntity.BusinessEntityID."));
                NationalIDNumber = group.Add(new VocabularyKey("nationalIDNumber", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("National ID Number").WithDescription("Unique national identification number such as a social security number."));
                LoginID = group.Add(new VocabularyKey("loginID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Login ID").WithDescription("Network login."));
                OrganizationNode = group.Add(new VocabularyKey("organizationNode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Organization Node").WithDescription("Where the employee is located in corporate hierarchy."));
                OrganizationLevel = group.Add(new VocabularyKey("organizationLevel", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible).WithDisplayName("Organization Level").WithDescription("The depth of the employee in the corporate hierarchy."));
                JobTitle = group.Add(new VocabularyKey("jobTitle", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Job Title").WithDescription("Work title such as Buyer or Sales Representative."));
                BirthDate = group.Add(new VocabularyKey("birthDate", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Birth Date").WithDescription("Date of birth."));
                MaritalStatus = group.Add(new VocabularyKey("maritalStatus", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Marital Status").WithDescription("M = Married, S = Single"));
                Gender = group.Add(new VocabularyKey("gender", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Gender").WithDescription("M = Male, F = Female"));
                HireDate = group.Add(new VocabularyKey("hireDate", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Hire Date").WithDescription("Employee hired on this date."));
                SalariedFlag = group.Add(new VocabularyKey("salariedFlag", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Salaried Flag").WithDescription("Job classification. 0 = Hourly, not exempt from collective bargaining. 1 = Salaried, exempt from collective bargaining."));
                VacationHours = group.Add(new VocabularyKey("vacationHours", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible).WithDisplayName("Vacation Hours").WithDescription("Number of available vacation hours."));
                SickLeaveHours = group.Add(new VocabularyKey("sickLeaveHours", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible).WithDisplayName("Sick Leave Hours").WithDescription("Number of available sick leave hours."));
                CurrentFlag = group.Add(new VocabularyKey("currentFlag", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Current Flag").WithDescription("0 = Inactive, 1 = Active"));
                Rowguid = group.Add(new VocabularyKey("rowguid", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("rowguid").WithDescription("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample."));
                ModifiedDate = group.Add(new VocabularyKey("modifiedDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Modified Date").WithDescription("Date and time the record was last updated."));
            });
        }

        public VocabularyKey BusinessEntityID { get; private set; }
        public VocabularyKey NationalIDNumber { get; private set; }
        public VocabularyKey LoginID { get; private set; }
        public VocabularyKey OrganizationNode { get; private set; }
        public VocabularyKey OrganizationLevel { get; private set; }
        public VocabularyKey JobTitle { get; private set; }
        public VocabularyKey BirthDate { get; private set; }
        public VocabularyKey MaritalStatus { get; private set; }
        public VocabularyKey Gender { get; private set; }
        public VocabularyKey HireDate { get; private set; }
        public VocabularyKey SalariedFlag { get; private set; }
        public VocabularyKey VacationHours { get; private set; }
        public VocabularyKey SickLeaveHours { get; private set; }
        public VocabularyKey CurrentFlag { get; private set; }
        public VocabularyKey Rowguid { get; private set; }
        public VocabularyKey ModifiedDate { get; private set; }
    }
}
