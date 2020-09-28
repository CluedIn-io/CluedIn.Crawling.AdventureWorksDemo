using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.AdventureWorksPerson.Vocabularies
{
    public class PersonPersonVocabulary : SimpleVocabulary
    {
        public PersonPersonVocabulary()
        {
            VocabularyName = "PersonPerson"; // TODO: Set value
            KeyPrefix = "AdventureWorksPerson.PersonPerson"; // TODO: Set value
            KeySeparator = ".";
            Grouping = EntityType.Person; // TODO: Set value

            AddGroup("PersonPerson Details", group =>
            {
                BusinessEntityID = group.Add(new VocabularyKey("businessEntityID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Business Entity ID").WithDescription("Primary key for Person records."));
                PersonType = group.Add(new VocabularyKey("personType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Person Type").WithDescription("Primary type of person: SC = Store Contact, IN = Individual (retail) customer, SP = Sales person, EM = Employee (non-sales), VC = Vendor contact, GC = General contact"));
                NameStyle = group.Add(new VocabularyKey("nameStyle", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Name Style").WithDescription("0 = The data in FirstName and LastName are stored in western style (first name, last name) order.  1 = Eastern style (last name, first name) order."));
                Title = group.Add(new VocabularyKey("title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Title").WithDescription("A courtesy title. For example, Mr. or Ms."));
                FirstName = group.Add(new VocabularyKey("firstName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible).WithDisplayName("First Name").WithDescription("First name of the person."));
                MiddleName = group.Add(new VocabularyKey("middleName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Middle Name").WithDescription("Middle name or middle initial of the person."));
                LastName = group.Add(new VocabularyKey("lastName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible).WithDisplayName("Last Name").WithDescription("Last name of the person."));
                Suffix = group.Add(new VocabularyKey("suffix", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Suffix").WithDescription("Surname suffix. For example, Sr. or Jr."));
                EmailPromotion = group.Add(new VocabularyKey("emailPromotion", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible).WithDisplayName("Email Promotion").WithDescription("0 = Contact does not wish to receive e-mail promotions, 1 = Contact does wish to receive e-mail promotions from AdventureWorksPerson, 2 = Contact does wish to receive e-mail promotions from AdventureWorksPerson and selected partners. "));
                AdditionalContactInfo = group.Add(new VocabularyKey("additionalContactInfo", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Additional Contact Info").WithDescription("Additional contact information about the person stored in xml format. "));
                Demographics = group.Add(new VocabularyKey("demographics", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Demographics").WithDescription("Personal information such as hobbies, and income collected from online shoppers. Used for sales analysis."));
                Rowguid = group.Add(new VocabularyKey("rowguid", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Row Guid").WithDescription("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample."));
                ModifiedDate = group.Add(new VocabularyKey("modifiedDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Modified Date").WithDescription("Date and time the record was last updated."));
            });

            AddMapping(Title, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInPerson.Title);
            AddMapping(FirstName, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInPerson.FirstName);
            AddMapping(MiddleName, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInPerson.MiddleName);
            AddMapping(LastName, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInPerson.LastName);
        }

        public VocabularyKey BusinessEntityID { get; private set; }
        public VocabularyKey PersonType { get; private set; }
        public VocabularyKey NameStyle { get; private set; }
        public VocabularyKey Title { get; private set; }
        public VocabularyKey FirstName { get; private set; }
        public VocabularyKey MiddleName { get; private set; }
        public VocabularyKey LastName { get; private set; }
        public VocabularyKey Suffix { get; private set; }
        public VocabularyKey EmailPromotion { get; private set; }
        public VocabularyKey AdditionalContactInfo { get; private set; }
        public VocabularyKey Demographics { get; private set; }
        public VocabularyKey Rowguid { get; private set; }
        public VocabularyKey ModifiedDate { get; private set; }
    }
}
