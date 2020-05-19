namespace CluedIn.Crawling.AdventureWorks.Core.Models
{
    using System;
    using System.ComponentModel;
    using System.Data;

    [DisplayName("Person.Address")]
    public class PersonAddress : BaseSqlEntity
    {
        public PersonAddress(IDataReader reader) : base(reader)
        {
            if (reader == null)
            {
                throw new ArgumentNullException(nameof(reader));
            }
            AddressID = reader["AddressID"].ToString();
            AddressLine1 = reader.GetStringValue("AddressLine1");
            AddressLine2 = reader.GetStringValue("AddressLine2");
            City = reader.GetStringValue("City");
            StateProvinceID = reader.GetNullableValue<int?>("StateProvinceID");
            PostalCode = reader.GetStringValue("PostalCode");
            SpatialLocation = reader.GetStringValue("SpatialLocation");
            Rowguid = reader.GetStringValue("rowguid");
            ModifiedDate = reader.GetStringValue("ModifiedDate");
        }

        public string AddressID { get; private set; }
        public string AddressLine1 { get; private set; }
        public string AddressLine2 { get; private set; }
        public string City { get; private set; }
        public int? StateProvinceID { get; private set; }
        public string PostalCode { get; private set; }
        public string SpatialLocation { get; private set; }
        public string Rowguid { get; private set; }
        public string ModifiedDate { get; private set; }
    }

}
