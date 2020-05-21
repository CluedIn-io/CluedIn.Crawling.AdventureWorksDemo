using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.AdventureWorks.Vocabularies
{
    public class ProductionProductVocabulary : SimpleVocabulary
    {
        public ProductionProductVocabulary()
        {
            VocabularyName = "ProductionProduct"; // TODO: Set value
            KeyPrefix = "adventureWorks.ProductionProduct"; // TODO: Set value
            KeySeparator = ".";
            Grouping = EntityType.Product; // TODO: Set value

            AddGroup("ProductionProduct Details", group =>
            {
                ProductID = group.Add(new VocabularyKey("productID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Product ID").WithDescription("Primary key for Product records."));
                Name = group.Add(new VocabularyKey("name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Name").WithDescription("Name of the product."));
                ProductNumber = group.Add(new VocabularyKey("productNumber", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Product Number").WithDescription("Unique product identification number."));
                MakeFlag = group.Add(new VocabularyKey("makeFlag", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Make Flag").WithDescription("0 = Product is purchased, 1 = Product is manufactured in-house."));
                FinishedGoodsFlag = group.Add(new VocabularyKey("finishedGoodsFlag", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Finished Goods Flag").WithDescription("0 = Product is not a salable item. 1 = Product is salable."));
                Color = group.Add(new VocabularyKey("color", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Color").WithDescription("Product color."));
                SafetyStockLevel = group.Add(new VocabularyKey("safetyStockLevel", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible).WithDisplayName("Safety Stock Level").WithDescription("Minimum inventory quantity. "));
                ReorderPoint = group.Add(new VocabularyKey("reorderPoint", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible).WithDisplayName("Reorder Point").WithDescription("Inventory level that triggers a purchase order or work order. "));
                StandardCost = group.Add(new VocabularyKey("standardCost", VocabularyKeyDataType.Money, VocabularyKeyVisibility.Visible).WithDisplayName("Standard Cost").WithDescription("Standard cost of the product."));
                ListPrice = group.Add(new VocabularyKey("listPrice", VocabularyKeyDataType.Money, VocabularyKeyVisibility.Visible).WithDisplayName("List Price").WithDescription("Selling price."));
                Size = group.Add(new VocabularyKey("size", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Size").WithDescription("Product size."));
                SizeUnitMeasureCode = group.Add(new VocabularyKey("sizeUnitMeasureCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Size Unit Measure Code").WithDescription("Unit of measure for Size column."));
                WeightUnitMeasureCode = group.Add(new VocabularyKey("weightUnitMeasureCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Weight Unit Measure Code").WithDescription("Unit of measure for Weight column."));
                Weight = group.Add(new VocabularyKey("weight", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible).WithDisplayName("Weight").WithDescription("Product weight."));
                DaysToManufacture = group.Add(new VocabularyKey("daysToManufacture", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible).WithDisplayName("Days To Manufacture").WithDescription("Number of days required to manufacture the product."));
                ProductLine = group.Add(new VocabularyKey("productLine", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Product Line").WithDescription("R = Road, M = Mountain, T = Touring, S = Standard"));
                Class = group.Add(new VocabularyKey("class", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Class").WithDescription("H = High, M = Medium, L = Low"));
                Style = group.Add(new VocabularyKey("style", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Style").WithDescription("W = Womens, M = Mens, U = Universal"));
                ProductSubcategoryID = group.Add(new VocabularyKey("productSubcategoryID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible).WithDisplayName("Product Subcategory ID").WithDescription("Product is a member of this product subcategory. Foreign key to ProductSubCategory.ProductSubCategoryID. "));
                ProductModelID = group.Add(new VocabularyKey("productModelID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible).WithDisplayName("Product Model ID").WithDescription("Product is a member of this product model. Foreign key to ProductModel.ProductModelID."));
                SellStartDate = group.Add(new VocabularyKey("sellStartDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Sell Start Date").WithDescription("Date the product was available for sale."));
                SellEndDate = group.Add(new VocabularyKey("sellEndDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Sell End Date").WithDescription("Date the product was no longer available for sale."));
                DiscontinuedDate = group.Add(new VocabularyKey("discontinuedDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Discontinued Date").WithDescription("Date the product was discontinued."));
                Rowguid = group.Add(new VocabularyKey("rowguid", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Hidden).WithDisplayName("rowguid").WithDescription("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample."));
                ModifiedDate = group.Add(new VocabularyKey("modifiedDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Modified Date").WithDescription("Date and time the record was last updated."));
            });

            AddMapping(ProductNumber, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInProduct.CodeName);


        }

        public VocabularyKey ProductID { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ProductNumber { get; private set; }
        public VocabularyKey MakeFlag { get; private set; }
        public VocabularyKey FinishedGoodsFlag { get; private set; }
        public VocabularyKey Color { get; private set; }
        public VocabularyKey SafetyStockLevel { get; private set; }
        public VocabularyKey ReorderPoint { get; private set; }
        public VocabularyKey StandardCost { get; private set; }
        public VocabularyKey ListPrice { get; private set; }
        public VocabularyKey Size { get; private set; }
        public VocabularyKey SizeUnitMeasureCode { get; private set; }
        public VocabularyKey WeightUnitMeasureCode { get; private set; }
        public VocabularyKey Weight { get; private set; }
        public VocabularyKey DaysToManufacture { get; private set; }
        public VocabularyKey ProductLine { get; private set; }
        public VocabularyKey Class { get; private set; }
        public VocabularyKey Style { get; private set; }
        public VocabularyKey ProductSubcategoryID { get; private set; }
        public VocabularyKey ProductModelID { get; private set; }
        public VocabularyKey SellStartDate { get; private set; }
        public VocabularyKey SellEndDate { get; private set; }
        public VocabularyKey DiscontinuedDate { get; private set; }
        public VocabularyKey Rowguid { get; private set; }
        public VocabularyKey ModifiedDate { get; private set; }
    }
}
