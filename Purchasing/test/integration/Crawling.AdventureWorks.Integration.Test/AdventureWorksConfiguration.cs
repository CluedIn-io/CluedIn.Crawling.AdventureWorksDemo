using System.Collections.Generic;
using CluedIn.Crawling.AdventureWorks.Core;

namespace CluedIn.Crawling.AdventureWorks.Integration.Test
{
  public static class AdventureWorksConfiguration
  {
    public static Dictionary<string, object> Create()
    {
      return new Dictionary<string, object>
            {
                { AdventureWorksConstants.KeyName.ConnectionString, "Server=localhost;Database=AdventureWorks2017;Trusted_Connection=True;" }
            };
    }
  }
}
