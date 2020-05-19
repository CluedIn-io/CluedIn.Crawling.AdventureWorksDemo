namespace CluedIn.Crawling.AdventureWorks.Core.Models
{
using System;
using System.ComponentModel;
using System.Data;

[DisplayName("Production.Document")]
public class ProductionDocument : BaseSqlEntity
{
public ProductionDocument (IDataReader reader) : base (reader)
{
if (reader == null)
{
throw new ArgumentNullException(nameof(reader));
}
DocumentNode              = reader["DocumentNode"].ToString();
DocumentLevel             = reader.GetNullableValue<int?>("DocumentLevel");
Title                     = reader.GetStringValue("Title");
Owner                     = reader.GetNullableValue<int?>("Owner");
FolderFlag                = reader.GetNullableValue<bool?>("FolderFlag");
FileName                  = reader.GetStringValue("FileName");
FileExtension             = reader.GetStringValue("FileExtension");
Revision                  = reader.GetStringValue("Revision");
ChangeNumber              = reader.GetNullableValue<int?>("ChangeNumber");
Status                    = reader.GetNullableValue<byte?>("Status");
DocumentSummary           = reader.GetStringValue("DocumentSummary");
Document                  = reader.GetStringValue("Document");
Rowguid                   = reader.GetStringValue("rowguid");
ModifiedDate              = reader.GetStringValue("ModifiedDate");
}

public string DocumentNode { get; private set; }
public int? DocumentLevel { get; private set; }
public string Title { get; private set; }
public int? Owner { get; private set; }
public bool? FolderFlag { get; private set; }
public string FileName { get; private set; }
public string FileExtension { get; private set; }
public string Revision { get; private set; }
public int? ChangeNumber { get; private set; }
public byte? Status { get; private set; }
public string DocumentSummary { get; private set; }
public string Document { get; private set; }
public string Rowguid { get; private set; }
public string ModifiedDate { get; private set; }
}

}
