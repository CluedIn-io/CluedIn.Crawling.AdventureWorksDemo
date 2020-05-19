namespace CluedIn.Crawling.AdventureWorks.Core.Models
{
    using System;
    using System.ComponentModel;
    using System.Data;

    [DisplayName("Person.Person")]
    public class PersonPerson : BaseSqlEntity
    {
        public PersonPerson(IDataReader reader) : base(reader)
        {
            if (reader == null)
            {
                throw new ArgumentNullException(nameof(reader));
            }
            BusinessEntityID = reader["BusinessEntityID"].ToString();
            PersonType = reader.GetStringValue("PersonType");
            NameStyle = reader.GetStringValue("NameStyle");
            Title = reader.GetStringValue("Title");
            FirstName = reader.GetStringValue("FirstName");
            MiddleName = reader.GetStringValue("MiddleName");
            LastName = reader.GetStringValue("LastName");
            Suffix = reader.GetStringValue("Suffix");
            EmailPromotion = reader.GetNullableValue<int?>("EmailPromotion");
            AdditionalContactInfo = reader.GetStringValue("AdditionalContactInfo");
            Demographics = reader.GetStringValue("Demographics");
            Rowguid = reader.GetStringValue("rowguid");
            ModifiedDate = reader.GetStringValue("ModifiedDate");
        }

        public string BusinessEntityID { get; private set; }
        public string PersonType { get; private set; }
        public string NameStyle { get; private set; }
        public string Title { get; private set; }
        public string FirstName { get; private set; }
        public string MiddleName { get; private set; }
        public string LastName { get; private set; }
        public string Suffix { get; private set; }
        public int? EmailPromotion { get; private set; }
        public string AdditionalContactInfo { get; private set; }
        public string Demographics { get; private set; }
        public string Rowguid { get; private set; }
        public string ModifiedDate { get; private set; }
    }

}
