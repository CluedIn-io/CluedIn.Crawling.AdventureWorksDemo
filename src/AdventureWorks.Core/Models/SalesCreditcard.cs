namespace CluedIn.Crawling.AdventureWorks.Core.Models
{
using System;
using System.ComponentModel;
using System.Data;

[DisplayName("Sales.CreditCard")]
public class SalesCreditCard : BaseSqlEntity
{
public SalesCreditCard (IDataReader reader) : base (reader)
{
if (reader == null)
{
throw new ArgumentNullException(nameof(reader));
}
CreditCardID              = reader["CreditCardID"].ToString();
CardType                  = reader.GetStringValue("CardType");
CardNumber                = reader.GetStringValue("CardNumber");
ExpMonth                  = reader.GetNullableValue<byte?>("ExpMonth");
ExpYear                   = reader.GetNullableValue<int?>("ExpYear");
ModifiedDate              = reader.GetStringValue("ModifiedDate");
}

public string CreditCardID { get; private set; }
public string CardType { get; private set; }
public string CardNumber { get; private set; }
public byte? ExpMonth { get; private set; }
public int? ExpYear { get; private set; }
public string ModifiedDate { get; private set; }
}

}
