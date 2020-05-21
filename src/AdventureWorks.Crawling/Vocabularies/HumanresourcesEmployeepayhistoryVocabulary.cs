using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.AdventureWorks.Vocabularies
{
public class HumanResourcesEmployeePayHistoryVocabulary : SimpleVocabulary
{
public HumanResourcesEmployeePayHistoryVocabulary()
{
VocabularyName = "HumanResourcesEmployeePayHistory"; // TODO: Set value
KeyPrefix = "adventureWorks.HumanResourcesEmployeePayHistory"; // TODO: Set value
KeySeparator = ".";
Grouping = "HumanResourcesEmployeePayHistory"; // TODO: Set value

AddGroup("HumanResourcesEmployeePayHistory Details", group =>
{
BusinessEntityID          = group.Add(new VocabularyKey("businessEntityID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Business Entity ID").WithDescription("Employee identification number. Foreign key to Employee.BusinessEntityID."));
RateChangeDate            = group.Add(new VocabularyKey("rateChangeDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Rate Change Date").WithDescription("Date the change in pay is effective"));
Rate                      = group.Add(new VocabularyKey("rate", VocabularyKeyDataType.Money, VocabularyKeyVisibility.Visible).WithDisplayName("Rate").WithDescription("Salary hourly rate."));
PayFrequency              = group.Add(new VocabularyKey("payFrequency", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Pay Frequency").WithDescription("1 = Salary received monthly, 2 = Salary received biweekly"));
ModifiedDate              = group.Add(new VocabularyKey("modifiedDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Modified Date").WithDescription("Date and time the record was last updated."));
});
}

public VocabularyKey BusinessEntityID { get; private set; }
public VocabularyKey RateChangeDate { get; private set; }
public VocabularyKey Rate { get; private set; }
public VocabularyKey PayFrequency { get; private set; }
public VocabularyKey ModifiedDate { get; private set; }
}
}
