using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.AdventureWorks.Vocabularies
{
public class ProductionWorkOrderVocabulary : SimpleVocabulary
{
public ProductionWorkOrderVocabulary()
{
VocabularyName = "ProductionWorkOrder"; // TODO: Set value
KeyPrefix = "adventureWorks.ProductionWorkOrder"; // TODO: Set value
KeySeparator = ".";
Grouping = "ProductionWorkOrder"; // TODO: Set value

AddGroup("ProductionWorkOrder Details", group =>
{
WorkOrderID               = group.Add(new VocabularyKey("workOrderID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Work Order ID").WithDescription("Primary key for WorkOrder records."));
ProductID                 = group.Add(new VocabularyKey("productID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible).WithDisplayName("Product ID").WithDescription("Product identification number. Foreign key to Product.ProductID."));
OrderQty                  = group.Add(new VocabularyKey("orderQty", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible).WithDisplayName("Order Qty").WithDescription("Product quantity to build."));
StockedQty                = group.Add(new VocabularyKey("stockedQty", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible).WithDisplayName("Stocked Qty").WithDescription("Quantity built and put in inventory."));
ScrappedQty               = group.Add(new VocabularyKey("scrappedQty", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible).WithDisplayName("Scrapped Qty").WithDescription("Quantity that failed inspection."));
StartDate                 = group.Add(new VocabularyKey("startDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Start Date").WithDescription("Work order start date."));
EndDate                   = group.Add(new VocabularyKey("endDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("End Date").WithDescription("Work order end date."));
DueDate                   = group.Add(new VocabularyKey("dueDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Due Date").WithDescription("Work order due date."));
ScrapReasonID             = group.Add(new VocabularyKey("scrapReasonID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible).WithDisplayName("Scrap Reason ID").WithDescription("Reason for inspection failure."));
ModifiedDate              = group.Add(new VocabularyKey("modifiedDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Modified Date").WithDescription("Date and time the record was last updated."));
});
}

public VocabularyKey WorkOrderID { get; private set; }
public VocabularyKey ProductID { get; private set; }
public VocabularyKey OrderQty { get; private set; }
public VocabularyKey StockedQty { get; private set; }
public VocabularyKey ScrappedQty { get; private set; }
public VocabularyKey StartDate { get; private set; }
public VocabularyKey EndDate { get; private set; }
public VocabularyKey DueDate { get; private set; }
public VocabularyKey ScrapReasonID { get; private set; }
public VocabularyKey ModifiedDate { get; private set; }
}
}
