using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.AdventureWorksProduction.Vocabularies
{
public class ProductionWorkOrderRoutingVocabulary : SimpleVocabulary
{
public ProductionWorkOrderRoutingVocabulary()
{
VocabularyName = "ProductionWorkOrderRouting"; // TODO: Set value
KeyPrefix = "AdventureWorksProduction.ProductionWorkOrderRouting"; // TODO: Set value
KeySeparator = ".";
Grouping = "ProductionWorkOrderRouting"; // TODO: Set value

AddGroup("ProductionWorkOrderRouting Details", group =>
{
WorkOrderID               = group.Add(new VocabularyKey("workOrderID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Work Order ID").WithDescription("Primary key. Foreign key to WorkOrder.WorkOrderID."));
ProductID                 = group.Add(new VocabularyKey("productID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Product ID").WithDescription("Primary key. Foreign key to Product.ProductID."));
OperationSequence         = group.Add(new VocabularyKey("operationSequence", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Operation Sequence").WithDescription("Primary key. Indicates the manufacturing process sequence."));
LocationID                = group.Add(new VocabularyKey("locationID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible).WithDisplayName("Location ID").WithDescription("Manufacturing location where the part is processed. Foreign key to Location.LocationID."));
ScheduledStartDate        = group.Add(new VocabularyKey("scheduledStartDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Scheduled Start Date").WithDescription("Planned manufacturing start date."));
ScheduledEndDate          = group.Add(new VocabularyKey("scheduledEndDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Scheduled End Date").WithDescription("Planned manufacturing end date."));
ActualStartDate           = group.Add(new VocabularyKey("actualStartDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Actual Start Date").WithDescription("Actual start date."));
ActualEndDate             = group.Add(new VocabularyKey("actualEndDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Actual End Date").WithDescription("Actual end date."));
ActualResourceHrs         = group.Add(new VocabularyKey("actualResourceHrs", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible).WithDisplayName("Actual Resource Hrs").WithDescription("Number of manufacturing hours used."));
PlannedCost               = group.Add(new VocabularyKey("plannedCost", VocabularyKeyDataType.Money, VocabularyKeyVisibility.Visible).WithDisplayName("Planned Cost").WithDescription("Estimated manufacturing cost."));
ActualCost                = group.Add(new VocabularyKey("actualCost", VocabularyKeyDataType.Money, VocabularyKeyVisibility.Visible).WithDisplayName("Actual Cost").WithDescription("Actual manufacturing cost."));
ModifiedDate              = group.Add(new VocabularyKey("modifiedDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Modified Date").WithDescription("Date and time the record was last updated."));
});
}

public VocabularyKey WorkOrderID { get; private set; }
public VocabularyKey ProductID { get; private set; }
public VocabularyKey OperationSequence { get; private set; }
public VocabularyKey LocationID { get; private set; }
public VocabularyKey ScheduledStartDate { get; private set; }
public VocabularyKey ScheduledEndDate { get; private set; }
public VocabularyKey ActualStartDate { get; private set; }
public VocabularyKey ActualEndDate { get; private set; }
public VocabularyKey ActualResourceHrs { get; private set; }
public VocabularyKey PlannedCost { get; private set; }
public VocabularyKey ActualCost { get; private set; }
public VocabularyKey ModifiedDate { get; private set; }
}
}
