using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.AdventureWorks.Vocabularies
{
public class HumanResourcesJobCandidateVocabulary : SimpleVocabulary
{
public HumanResourcesJobCandidateVocabulary()
{
VocabularyName = "HumanResourcesJobCandidate"; // TODO: Set value
KeyPrefix = "adventureWorks.HumanResourcesJobCandidate"; // TODO: Set value
KeySeparator = ".";
Grouping = "HumanResourcesJobCandidate"; // TODO: Set value

AddGroup("HumanResourcesJobCandidate Details", group =>
{
JobCandidateID            = group.Add(new VocabularyKey("jobCandidateID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Job Candidate ID").WithDescription("Primary key for JobCandidate records."));
BusinessEntityID          = group.Add(new VocabularyKey("businessEntityID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible).WithDisplayName("Business Entity ID").WithDescription("Employee identification number if applicant was hired. Foreign key to Employee.BusinessEntityID."));
Resume                    = group.Add(new VocabularyKey("resume", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Resume").WithDescription("Résumé in XML format."));
ModifiedDate              = group.Add(new VocabularyKey("modifiedDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Modified Date").WithDescription("Date and time the record was last updated."));
});
}

public VocabularyKey JobCandidateID { get; private set; }
public VocabularyKey BusinessEntityID { get; private set; }
public VocabularyKey Resume { get; private set; }
public VocabularyKey ModifiedDate { get; private set; }
}
}
