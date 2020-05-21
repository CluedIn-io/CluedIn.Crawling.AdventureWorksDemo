using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.AdventureWorks.Vocabularies
{
    public class PurchasingShipMethodVocabulary : SimpleVocabulary
    {
        public PurchasingShipMethodVocabulary()
        {
            VocabularyName = "PurchasingShipMethod"; // TODO: Set value
            KeyPrefix = "adventureWorks.PurchasingShipMethod"; // TODO: Set value
            KeySeparator = ".";
            Grouping = "PurchasingShipMethod"; // TODO: Set value

            AddGroup("PurchasingShipMethod Details", group =>
            {
                ShipMethodID = group.Add(new VocabularyKey("shipMethodID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Ship Method ID").WithDescription("Primary key for ShipMethod records."));
                Name = group.Add(new VocabularyKey("name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Name").WithDescription("Shipping company name."));
                ShipBase = group.Add(new VocabularyKey("shipBase", VocabularyKeyDataType.Money, VocabularyKeyVisibility.Visible).WithDisplayName("Ship Base").WithDescription("Minimum shipping charge."));
                ShipRate = group.Add(new VocabularyKey("shipRate", VocabularyKeyDataType.Money, VocabularyKeyVisibility.Visible).WithDisplayName("Ship Rate").WithDescription("Shipping charge per pound."));
                Rowguid = group.Add(new VocabularyKey("rowguid", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("rowguid").WithDescription("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample."));
                ModifiedDate = group.Add(new VocabularyKey("modifiedDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Modified Date").WithDescription("Date and time the record was last updated."));
            });
        }

        public VocabularyKey ShipMethodID { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ShipBase { get; private set; }
        public VocabularyKey ShipRate { get; private set; }
        public VocabularyKey Rowguid { get; private set; }
        public VocabularyKey ModifiedDate { get; private set; }
    }
}
