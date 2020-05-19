namespace CluedIn.Crawling.AdventureWorks.Core.Models
{
using System;
using System.ComponentModel;
using System.Data;

[DisplayName("Production.ProductPhoto")]
public class ProductionProductPhoto : BaseSqlEntity
{
public ProductionProductPhoto (IDataReader reader) : base (reader)
{
if (reader == null)
{
throw new ArgumentNullException(nameof(reader));
}
ProductPhotoID            = reader["ProductPhotoID"].ToString();
ThumbNailPhoto            = reader.GetStringValue("ThumbNailPhoto");
ThumbnailPhotoFileName    = reader.GetStringValue("ThumbnailPhotoFileName");
LargePhoto                = reader.GetStringValue("LargePhoto");
LargePhotoFileName        = reader.GetStringValue("LargePhotoFileName");
ModifiedDate              = reader.GetStringValue("ModifiedDate");
}

public string ProductPhotoID { get; private set; }
public string ThumbNailPhoto { get; private set; }
public string ThumbnailPhotoFileName { get; private set; }
public string LargePhoto { get; private set; }
public string LargePhotoFileName { get; private set; }
public string ModifiedDate { get; private set; }
}

}
