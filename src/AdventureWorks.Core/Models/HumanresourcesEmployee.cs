namespace CluedIn.Crawling.AdventureWorks.Core.Models
{
    using System;
    using System.ComponentModel;
    using System.Data;

    [DisplayName("HumanResources.Employee")]
    public class HumanResourcesEmployee : BaseSqlEntity
    {
        public HumanResourcesEmployee(IDataReader reader) : base(reader)
        {
            if (reader == null)
            {
                throw new ArgumentNullException(nameof(reader));
            }
            BusinessEntityID = reader["BusinessEntityID"].ToString();
            NationalIDNumber = reader.GetStringValue("NationalIDNumber");
            LoginID = reader.GetStringValue("LoginID");
            //OrganizationNode = (SqlHierarchyId)reader["OrganizationNode"];
            OrganizationLevel = reader.GetNullableValue<int?>("OrganizationLevel");
            JobTitle = reader.GetStringValue("JobTitle");
            BirthDate = reader.GetStringValue("BirthDate");
            MaritalStatus = reader.GetStringValue("MaritalStatus");
            Gender = reader.GetStringValue("Gender");
            HireDate = reader.GetStringValue("HireDate");
            SalariedFlag = reader.GetStringValue("SalariedFlag");
            VacationHours = reader.GetNullableValue<int?>("VacationHours");
            SickLeaveHours = reader.GetNullableValue<int?>("SickLeaveHours");
            CurrentFlag = reader.GetStringValue("CurrentFlag");
            Rowguid = reader.GetStringValue("rowguid");
            ModifiedDate = reader.GetStringValue("ModifiedDate");
        }

        public string BusinessEntityID { get; private set; }
        public string NationalIDNumber { get; private set; }
        public string LoginID { get; private set; }
        //public SqlHierarchyId OrganizationNode { get; private set; }
        public int? OrganizationLevel { get; private set; }
        public string JobTitle { get; private set; }
        public string BirthDate { get; private set; }
        public string MaritalStatus { get; private set; }
        public string Gender { get; private set; }
        public string HireDate { get; private set; }
        public string SalariedFlag { get; private set; }
        public int? VacationHours { get; private set; }
        public int? SickLeaveHours { get; private set; }
        public string CurrentFlag { get; private set; }
        public string Rowguid { get; private set; }
        public string ModifiedDate { get; private set; }
    }

}
