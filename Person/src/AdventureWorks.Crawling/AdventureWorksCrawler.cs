using System.Collections.Generic;

using CluedIn.Core.Crawling;
using CluedIn.Crawling.AdventureWorksPerson.Core;
using CluedIn.Crawling.AdventureWorksPerson.Core.Models;
using CluedIn.Crawling.AdventureWorksPerson.Infrastructure.Factories;

namespace CluedIn.Crawling.AdventureWorksPerson
{
    public class AdventureWorksPersonCrawler : ICrawlerDataGenerator
    {
        private readonly IAdventureWorksPersonClientFactory clientFactory;
        public AdventureWorksPersonCrawler(IAdventureWorksPersonClientFactory clientFactory)
        {
            this.clientFactory = clientFactory;
        }

        public IEnumerable<object> GetData(CrawlJobData jobData)
        {
            if (!(jobData is AdventureWorksPersonCrawlJobData AdventureWorksPersoncrawlJobData))
            {
                yield break;
            }

            var client = clientFactory.CreateNew(AdventureWorksPersoncrawlJobData);

            foreach (var obj in client.GetObject<PersonAddress>(500))
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<PersonAddressType>(500))
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<PersonBusinessEntity>(500))
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<PersonBusinessEntityAddress>(500))
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<PersonBusinessEntityContact>(500))
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<PersonContactType>(500))
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<PersonCountryRegion>(500))
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<PersonEmailAddress>(500))
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<PersonPerson>(500))
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<PersonPersonPhone>(500))
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<PersonPhoneNumberType>(500))
            {
                yield return obj;
            }

            foreach (var obj in client.GetObject<PersonStateProvince>(500))
            {
                yield return obj;
            }

        }
    }
}
