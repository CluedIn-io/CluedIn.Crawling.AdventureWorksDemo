namespace CluedIn.Crawling.AdventureWorksHumanResources.Core.Models
{
using System;
using System.ComponentModel;
using System.Data;

[DisplayName("HumanResources.JobCandidate")]
public class HumanResourcesJobCandidate : BaseSqlEntity
{
public HumanResourcesJobCandidate (IDataReader reader) : base (reader)
{
if (reader == null)
{
throw new ArgumentNullException(nameof(reader));
}
JobCandidateID            = reader["JobCandidateID"].ToString();
BusinessEntityID          = reader.GetNullableValue<int?>("BusinessEntityID");
Resume                    = reader.GetStringValue("Resume");
ModifiedDate              = reader.GetStringValue("ModifiedDate");
}

public string JobCandidateID { get; private set; }
public int? BusinessEntityID { get; private set; }
public string Resume { get; private set; }
public string ModifiedDate { get; private set; }
}

}
