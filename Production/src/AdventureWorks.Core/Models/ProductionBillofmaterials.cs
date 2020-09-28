namespace CluedIn.Crawling.AdventureWorksProduction.Core.Models
{
using System;
using System.ComponentModel;
using System.Data;

[DisplayName("Production.BillOfMaterials")]
public class ProductionBillOfMaterials : BaseSqlEntity
{
public ProductionBillOfMaterials (IDataReader reader) : base (reader)
{
if (reader == null)
{
throw new ArgumentNullException(nameof(reader));
}
BillOfMaterialsID         = reader["BillOfMaterialsID"].ToString();
ProductAssemblyID         = reader.GetNullableValue<int?>("ProductAssemblyID");
ComponentID               = reader.GetNullableValue<int?>("ComponentID");
StartDate                 = reader.GetStringValue("StartDate");
EndDate                   = reader.GetStringValue("EndDate");
UnitMeasureCode           = reader.GetStringValue("UnitMeasureCode");
BOMLevel                  = reader.GetNullableValue<int?>("BOMLevel");
PerAssemblyQty            = reader.GetNullableValue<decimal?>("PerAssemblyQty");
ModifiedDate              = reader.GetStringValue("ModifiedDate");
}

public string BillOfMaterialsID { get; private set; }
public int? ProductAssemblyID { get; private set; }
public int? ComponentID { get; private set; }
public string StartDate { get; private set; }
public string EndDate { get; private set; }
public string UnitMeasureCode { get; private set; }
public int? BOMLevel { get; private set; }
public decimal? PerAssemblyQty { get; private set; }
public string ModifiedDate { get; private set; }
}

}
