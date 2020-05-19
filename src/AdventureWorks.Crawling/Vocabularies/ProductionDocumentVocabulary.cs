using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.AdventureWorks.Vocabularies
{
public class ProductionDocumentVocabulary : SimpleVocabulary
{
public ProductionDocumentVocabulary()
{
VocabularyName = "Sql ProductionDocument"; // TODO: Set value
KeyPrefix = "sql.ProductionDocument"; // TODO: Set value
KeySeparator = ".";
Grouping = "ProductionDocument"; // TODO: Set value

AddGroup("ProductionDocument Details", group =>
{
DocumentNode              = group.Add(new VocabularyKey("documentNode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Document Node").WithDescription("Primary key for Document records."));
DocumentLevel             = group.Add(new VocabularyKey("documentLevel", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible).WithDisplayName("Document Level").WithDescription("Depth in the document hierarchy."));
Title                     = group.Add(new VocabularyKey("title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Title").WithDescription("Title of the document."));
Owner                     = group.Add(new VocabularyKey("owner", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible).WithDisplayName("Owner").WithDescription("Employee who controls the document.  Foreign key to Employee.BusinessEntityID"));
FolderFlag                = group.Add(new VocabularyKey("folderFlag", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible).WithDisplayName("Folder Flag").WithDescription("0 = This is a folder, 1 = This is a document."));
FileName                  = group.Add(new VocabularyKey("fileName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("File Name").WithDescription("File name of the document"));
FileExtension             = group.Add(new VocabularyKey("fileExtension", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("File Extension").WithDescription("File extension indicating the document type. For example, .doc or .txt."));
Revision                  = group.Add(new VocabularyKey("revision", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Revision").WithDescription("Revision number of the document. "));
ChangeNumber              = group.Add(new VocabularyKey("changeNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible).WithDisplayName("Change Number").WithDescription("Engineering change approval number."));
Status                    = group.Add(new VocabularyKey("status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Status").WithDescription("1 = Pending approval, 2 = Approved, 3 = Obsolete"));
DocumentSummary           = group.Add(new VocabularyKey("documentSummary", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Document Summary").WithDescription("Document abstract."));
Document                  = group.Add(new VocabularyKey("document", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Document").WithDescription("Complete document."));
Rowguid                   = group.Add(new VocabularyKey("rowguid", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("rowguid").WithDescription("ROWGUIDCOL number uniquely identifying the record. Required for FileStream."));
ModifiedDate              = group.Add(new VocabularyKey("modifiedDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible).WithDisplayName("Modified Date").WithDescription("Date and time the record was last updated."));
});
}

public VocabularyKey DocumentNode { get; private set; }
public VocabularyKey DocumentLevel { get; private set; }
public VocabularyKey Title { get; private set; }
public VocabularyKey Owner { get; private set; }
public VocabularyKey FolderFlag { get; private set; }
public VocabularyKey FileName { get; private set; }
public VocabularyKey FileExtension { get; private set; }
public VocabularyKey Revision { get; private set; }
public VocabularyKey ChangeNumber { get; private set; }
public VocabularyKey Status { get; private set; }
public VocabularyKey DocumentSummary { get; private set; }
public VocabularyKey Document { get; private set; }
public VocabularyKey Rowguid { get; private set; }
public VocabularyKey ModifiedDate { get; private set; }
}
}
