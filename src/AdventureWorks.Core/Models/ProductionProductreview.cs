namespace CluedIn.Crawling.AdventureWorks.Core.Models
{
using System;
using System.ComponentModel;
using System.Data;

[DisplayName("Production.ProductReview")]
public class ProductionProductReview : BaseSqlEntity
{
public ProductionProductReview (IDataReader reader) : base (reader)
{
if (reader == null)
{
throw new ArgumentNullException(nameof(reader));
}
ProductReviewID           = reader["ProductReviewID"].ToString();
ProductID                 = reader.GetNullableValue<int?>("ProductID");
ReviewerName              = reader.GetStringValue("ReviewerName");
ReviewDate                = reader.GetStringValue("ReviewDate");
EmailAddress              = reader.GetStringValue("EmailAddress");
Rating                    = reader.GetNullableValue<int?>("Rating");
Comments                  = reader.GetStringValue("Comments");
ModifiedDate              = reader.GetStringValue("ModifiedDate");
}

public string ProductReviewID { get; private set; }
public int? ProductID { get; private set; }
public string ReviewerName { get; private set; }
public string ReviewDate { get; private set; }
public string EmailAddress { get; private set; }
public int? Rating { get; private set; }
public string Comments { get; private set; }
public string ModifiedDate { get; private set; }
}

}
