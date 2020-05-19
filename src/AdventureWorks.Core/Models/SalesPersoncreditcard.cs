namespace CluedIn.Crawling.AdventureWorks.Core.Models
{
using System;
using System.ComponentModel;
using System.Data;

[DisplayName("Sales.PersonCreditCard")]
public class SalesPersonCreditCard : BaseSqlEntity
{
public SalesPersonCreditCard (IDataReader reader) : base (reader)
{
if (reader == null)
{
throw new ArgumentNullException(nameof(reader));
}
BusinessEntityID          = reader["BusinessEntityID"].ToString();
CreditCardID              = reader["CreditCardID"].ToString();
ModifiedDate              = reader.GetStringValue("ModifiedDate");
}

public string BusinessEntityID { get; private set; }
public string CreditCardID { get; private set; }
public string ModifiedDate { get; private set; }
}

}
