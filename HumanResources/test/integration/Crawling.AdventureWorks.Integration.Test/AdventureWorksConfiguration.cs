using System.Collections.Generic;
using CluedIn.Crawling.AdventureWorksHumanResources.Core;

namespace CluedIn.Crawling.AdventureWorksHumanResources.Integration.Test
{
  public static class AdventureWorksHumanResourcesConfiguration
  {
    public static Dictionary<string, object> Create()
    {
      return new Dictionary<string, object>
            {
                { AdventureWorksHumanResourcesConstants.KeyName.ConnectionString, "Server=localhost;Database=AdventureWorksHumanResources2017;Trusted_Connection=True;" }
            };
    }
  }
}
