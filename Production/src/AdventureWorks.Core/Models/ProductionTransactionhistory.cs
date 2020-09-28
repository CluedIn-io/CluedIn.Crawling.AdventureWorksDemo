namespace CluedIn.Crawling.AdventureWorksProduction.Core.Models
{
using System;
using System.ComponentModel;
using System.Data;

[DisplayName("Production.TransactionHistory")]
public class ProductionTransactionHistory : BaseSqlEntity
{
public ProductionTransactionHistory (IDataReader reader) : base (reader)
{
if (reader == null)
{
throw new ArgumentNullException(nameof(reader));
}
TransactionID             = reader["TransactionID"].ToString();
ProductID                 = reader.GetNullableValue<int?>("ProductID");
ReferenceOrderID          = reader.GetNullableValue<int?>("ReferenceOrderID");
ReferenceOrderLineID      = reader.GetNullableValue<int?>("ReferenceOrderLineID");
TransactionDate           = reader.GetStringValue("TransactionDate");
TransactionType           = reader.GetStringValue("TransactionType");
Quantity                  = reader.GetNullableValue<int?>("Quantity");
ActualCost                = reader.GetNullableValue<decimal?>("ActualCost");
ModifiedDate              = reader.GetStringValue("ModifiedDate");
}

public string TransactionID { get; private set; }
public int? ProductID { get; private set; }
public int? ReferenceOrderID { get; private set; }
public int? ReferenceOrderLineID { get; private set; }
public string TransactionDate { get; private set; }
public string TransactionType { get; private set; }
public int? Quantity { get; private set; }
public decimal? ActualCost { get; private set; }
public string ModifiedDate { get; private set; }
}

}
