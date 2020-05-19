using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.AdventureWorks.Vocabularies
{
public class ProductionProductReviewVocabulary : SimpleVocabulary
{
public ProductionProductReviewVocabulary()
{
VocabularyName = "Sql ProductionProductReview"; // TODO: Set value
KeyPrefix = "sql.ProductionProductReview"; // TODO: Set value
KeySeparator = ".";
Grouping = "ProductionProductReview"; // TODO: Set value

AddGroup("ProductionProductReview Details", group =>
{
ProductReviewID           = group.Add(new VocabularyKey("productReviewID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Product Review ID").WithDescription("Primary key for ProductReview records."));
ProductID                 = group.Add(new VocabularyKey("productID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible).WithDisplayName("Product ID").WithDescription("Product identification number. Foreign key to Product.ProductID."));
ReviewerName              = group.Add(new VocabularyKey("reviewerName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Reviewer Name").WithDescription("Name of the reviewer."));
ReviewDate                = group.Add(new VocabularyKey("reviewDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Review Date").WithDescription("Date review was submitted."));
EmailAddress              = group.Add(new VocabularyKey("emailAddress", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Email Address").WithDescription("Reviewer's e-mail address."));
Rating                    = group.Add(new VocabularyKey("rating", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible).WithDisplayName("Rating").WithDescription("Product rating given by the reviewer. Scale is 1 to 5 with 5 as the highest rating."));
Comments                  = group.Add(new VocabularyKey("comments", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Comments").WithDescription("Reviewer's comments"));
ModifiedDate              = group.Add(new VocabularyKey("modifiedDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Modified Date").WithDescription("Date and time the record was last updated."));
});
}

public VocabularyKey ProductReviewID { get; private set; }
public VocabularyKey ProductID { get; private set; }
public VocabularyKey ReviewerName { get; private set; }
public VocabularyKey ReviewDate { get; private set; }
public VocabularyKey EmailAddress { get; private set; }
public VocabularyKey Rating { get; private set; }
public VocabularyKey Comments { get; private set; }
public VocabularyKey ModifiedDate { get; private set; }
}
}
