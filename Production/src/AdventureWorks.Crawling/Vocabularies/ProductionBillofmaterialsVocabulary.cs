using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.AdventureWorksProduction.Vocabularies
{
public class ProductionBillOfMaterialsVocabulary : SimpleVocabulary
{
public ProductionBillOfMaterialsVocabulary()
{
VocabularyName = "ProductionBillOfMaterials"; // TODO: Set value
KeyPrefix = "AdventureWorksProduction.ProductionBillOfMaterials"; // TODO: Set value
KeySeparator = ".";
Grouping = "ProductionBillOfMaterials"; // TODO: Set value

AddGroup("ProductionBillOfMaterials Details", group =>
{
BillOfMaterialsID         = group.Add(new VocabularyKey("billOfMaterialsID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Bill Of Materials ID").WithDescription("Primary key for BillOfMaterials records."));
ProductAssemblyID         = group.Add(new VocabularyKey("productAssemblyID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible).WithDisplayName("Product Assembly ID").WithDescription("Parent product identification number. Foreign key to Product.ProductID."));
ComponentID               = group.Add(new VocabularyKey("componentID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible).WithDisplayName("Component ID").WithDescription("Component identification number. Foreign key to Product.ProductID."));
StartDate                 = group.Add(new VocabularyKey("startDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Start Date").WithDescription("Date the component started being used in the assembly item."));
EndDate                   = group.Add(new VocabularyKey("endDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("End Date").WithDescription("Date the component stopped being used in the assembly item."));
UnitMeasureCode           = group.Add(new VocabularyKey("unitMeasureCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Unit Measure Code").WithDescription("Standard code identifying the unit of measure for the quantity."));
BOMLevel                  = group.Add(new VocabularyKey("bOMLevel", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible).WithDisplayName("BOM Level").WithDescription("Indicates the depth the component is from its parent (AssemblyID)."));
PerAssemblyQty            = group.Add(new VocabularyKey("perAssemblyQty", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible).WithDisplayName("Per Assembly Qty").WithDescription("Quantity of the component needed to create the assembly."));
ModifiedDate              = group.Add(new VocabularyKey("modifiedDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Modified Date").WithDescription("Date and time the record was last updated."));
});
}

public VocabularyKey BillOfMaterialsID { get; private set; }
public VocabularyKey ProductAssemblyID { get; private set; }
public VocabularyKey ComponentID { get; private set; }
public VocabularyKey StartDate { get; private set; }
public VocabularyKey EndDate { get; private set; }
public VocabularyKey UnitMeasureCode { get; private set; }
public VocabularyKey BOMLevel { get; private set; }
public VocabularyKey PerAssemblyQty { get; private set; }
public VocabularyKey ModifiedDate { get; private set; }
}
}
