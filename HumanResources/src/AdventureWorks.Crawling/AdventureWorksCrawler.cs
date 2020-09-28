using System.Collections.Generic;

using CluedIn.Core.Crawling;
using CluedIn.Crawling.AdventureWorksHumanResources.Core;
using CluedIn.Crawling.AdventureWorksHumanResources.Core.Models;
using CluedIn.Crawling.AdventureWorksHumanResources.Infrastructure.Factories;

namespace CluedIn.Crawling.AdventureWorksHumanResources
{
    public class AdventureWorksHumanResourcesCrawler : ICrawlerDataGenerator
    {
        private readonly IAdventureWorksHumanResourcesClientFactory clientFactory;
        public AdventureWorksHumanResourcesCrawler(IAdventureWorksHumanResourcesClientFactory clientFactory)
        {
            this.clientFactory = clientFactory;
        }

        public IEnumerable<object> GetData(CrawlJobData jobData)
        {
            if (!(jobData is AdventureWorksHumanResourcesCrawlJobData AdventureWorksHumanResourcescrawlJobData))
            {
                yield break;
            }

            var client = clientFactory.CreateNew(AdventureWorksHumanResourcescrawlJobData);

            foreach (var obj in client.GetObject<HumanResourcesDepartment>(500))
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<HumanResourcesEmployee>(500))
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<HumanResourcesEmployeeDepartmentHistory>(500))
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<HumanResourcesEmployeePayHistory>(500))
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<HumanResourcesJobCandidate>(500))
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<HumanResourcesShift>(500))
            {
                yield return obj;
            }

        }
    }
}
