namespace CluedIn.Crawling.AdventureWorks.Core.Models
{
using System;
using System.ComponentModel;
using System.Data;

[DisplayName("Production.Product")]
public class ProductionProduct : BaseSqlEntity
{
public ProductionProduct (IDataReader reader) : base (reader)
{
if (reader == null)
{
throw new ArgumentNullException(nameof(reader));
}
ProductID                 = reader["ProductID"].ToString();
Name                      = reader.GetStringValue("Name");
ProductNumber             = reader.GetStringValue("ProductNumber");
MakeFlag                  = reader.GetStringValue("MakeFlag");
FinishedGoodsFlag         = reader.GetStringValue("FinishedGoodsFlag");
Color                     = reader.GetStringValue("Color");
SafetyStockLevel          = reader.GetNullableValue<int?>("SafetyStockLevel");
ReorderPoint              = reader.GetNullableValue<int?>("ReorderPoint");
StandardCost              = reader.GetNullableValue<decimal?>("StandardCost");
ListPrice                 = reader.GetNullableValue<decimal?>("ListPrice");
Size                      = reader.GetStringValue("Size");
SizeUnitMeasureCode       = reader.GetStringValue("SizeUnitMeasureCode");
WeightUnitMeasureCode     = reader.GetStringValue("WeightUnitMeasureCode");
Weight                    = reader.GetNullableValue<decimal?>("Weight");
DaysToManufacture         = reader.GetNullableValue<int?>("DaysToManufacture");
ProductLine               = reader.GetStringValue("ProductLine");
Class                     = reader.GetStringValue("Class");
Style                     = reader.GetStringValue("Style");
ProductSubcategoryID      = reader.GetNullableValue<int?>("ProductSubcategoryID");
ProductModelID            = reader.GetNullableValue<int?>("ProductModelID");
SellStartDate             = reader.GetStringValue("SellStartDate");
SellEndDate               = reader.GetStringValue("SellEndDate");
DiscontinuedDate          = reader.GetStringValue("DiscontinuedDate");
Rowguid                   = reader.GetStringValue("rowguid");
ModifiedDate              = reader.GetStringValue("ModifiedDate");
}

public string ProductID { get; private set; }
public string Name { get; private set; }
public string ProductNumber { get; private set; }
public string MakeFlag { get; private set; }
public string FinishedGoodsFlag { get; private set; }
public string Color { get; private set; }
public int? SafetyStockLevel { get; private set; }
public int? ReorderPoint { get; private set; }
public decimal? StandardCost { get; private set; }
public decimal? ListPrice { get; private set; }
public string Size { get; private set; }
public string SizeUnitMeasureCode { get; private set; }
public string WeightUnitMeasureCode { get; private set; }
public decimal? Weight { get; private set; }
public int? DaysToManufacture { get; private set; }
public string ProductLine { get; private set; }
public string Class { get; private set; }
public string Style { get; private set; }
public int? ProductSubcategoryID { get; private set; }
public int? ProductModelID { get; private set; }
public string SellStartDate { get; private set; }
public string SellEndDate { get; private set; }
public string DiscontinuedDate { get; private set; }
public string Rowguid { get; private set; }
public string ModifiedDate { get; private set; }
}

}
