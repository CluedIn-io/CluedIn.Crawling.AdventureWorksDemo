namespace CluedIn.Crawling.AdventureWorksSales.Core.Models
{
using System;
using System.ComponentModel;
using System.Data;

[DisplayName("Sales.ShoppingCartItem")]
public class SalesShoppingCartItem : BaseSqlEntity
{
public SalesShoppingCartItem (IDataReader reader) : base (reader)
{
if (reader == null)
{
throw new ArgumentNullException(nameof(reader));
}
ShoppingCartItemID        = reader["ShoppingCartItemID"].ToString();
ShoppingCartID            = reader.GetStringValue("ShoppingCartID");
Quantity                  = reader.GetNullableValue<int?>("Quantity");
ProductID                 = reader.GetNullableValue<int?>("ProductID");
DateCreated               = reader.GetStringValue("DateCreated");
ModifiedDate              = reader.GetStringValue("ModifiedDate");
}

public string ShoppingCartItemID { get; private set; }
public string ShoppingCartID { get; private set; }
public int? Quantity { get; private set; }
public int? ProductID { get; private set; }
public string DateCreated { get; private set; }
public string ModifiedDate { get; private set; }
}

}
