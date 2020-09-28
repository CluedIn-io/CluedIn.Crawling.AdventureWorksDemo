namespace CluedIn.Crawling.AdventureWorksProduction.Core.Models
{
using System;
using System.ComponentModel;
using System.Data;

[DisplayName("Production.WorkOrder")]
public class ProductionWorkOrder : BaseSqlEntity
{
public ProductionWorkOrder (IDataReader reader) : base (reader)
{
if (reader == null)
{
throw new ArgumentNullException(nameof(reader));
}
WorkOrderID               = reader["WorkOrderID"].ToString();
ProductID                 = reader.GetNullableValue<int?>("ProductID");
OrderQty                  = reader.GetNullableValue<int?>("OrderQty");
StockedQty                = reader.GetNullableValue<int?>("StockedQty");
ScrappedQty               = reader.GetNullableValue<int?>("ScrappedQty");
StartDate                 = reader.GetStringValue("StartDate");
EndDate                   = reader.GetStringValue("EndDate");
DueDate                   = reader.GetStringValue("DueDate");
ScrapReasonID             = reader.GetNullableValue<int?>("ScrapReasonID");
ModifiedDate              = reader.GetStringValue("ModifiedDate");
}

public string WorkOrderID { get; private set; }
public int? ProductID { get; private set; }
public int? OrderQty { get; private set; }
public int? StockedQty { get; private set; }
public int? ScrappedQty { get; private set; }
public string StartDate { get; private set; }
public string EndDate { get; private set; }
public string DueDate { get; private set; }
public int? ScrapReasonID { get; private set; }
public string ModifiedDate { get; private set; }
}

}
