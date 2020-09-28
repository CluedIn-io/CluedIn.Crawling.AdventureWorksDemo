namespace CluedIn.Crawling.AdventureWorksProduction.Core.Models
{
using System;
using System.ComponentModel;
using System.Data;

[DisplayName("Production.WorkOrderRouting")]
public class ProductionWorkOrderRouting : BaseSqlEntity
{
public ProductionWorkOrderRouting (IDataReader reader) : base (reader)
{
if (reader == null)
{
throw new ArgumentNullException(nameof(reader));
}
WorkOrderID               = reader["WorkOrderID"].ToString();
ProductID                 = reader["ProductID"].ToString();
OperationSequence         = reader["OperationSequence"].ToString();
LocationID                = reader.GetNullableValue<int?>("LocationID");
ScheduledStartDate        = reader.GetStringValue("ScheduledStartDate");
ScheduledEndDate          = reader.GetStringValue("ScheduledEndDate");
ActualStartDate           = reader.GetStringValue("ActualStartDate");
ActualEndDate             = reader.GetStringValue("ActualEndDate");
ActualResourceHrs         = reader.GetNullableValue<decimal?>("ActualResourceHrs");
PlannedCost               = reader.GetNullableValue<decimal?>("PlannedCost");
ActualCost                = reader.GetNullableValue<decimal?>("ActualCost");
ModifiedDate              = reader.GetStringValue("ModifiedDate");
}

public string WorkOrderID { get; private set; }
public string ProductID { get; private set; }
public string OperationSequence { get; private set; }
public int? LocationID { get; private set; }
public string ScheduledStartDate { get; private set; }
public string ScheduledEndDate { get; private set; }
public string ActualStartDate { get; private set; }
public string ActualEndDate { get; private set; }
public decimal? ActualResourceHrs { get; private set; }
public decimal? PlannedCost { get; private set; }
public decimal? ActualCost { get; private set; }
public string ModifiedDate { get; private set; }
}

}
