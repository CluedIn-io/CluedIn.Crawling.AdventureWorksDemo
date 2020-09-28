using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using CluedIn.Core;
using CluedIn.Core.Crawling;
using CluedIn.Core.Data.Relational;
using CluedIn.Core.Providers;
using CluedIn.Core.Webhooks;
using System.Configuration;
using System.Linq;
using CluedIn.Core.Configuration;
using CluedIn.Crawling.AdventureWorksPerson.Core;
using CluedIn.Crawling.AdventureWorksPerson.Infrastructure.Factories;
using CluedIn.Providers.Models;
using Newtonsoft.Json;

namespace CluedIn.Provider.AdventureWorksPerson
{
    public class AdventureWorksPersonProvider : ProviderBase, IExtendedProviderMetadata
    {
        private readonly IAdventureWorksPersonClientFactory _AdventureWorksPersonClientFactory;

        public AdventureWorksPersonProvider([NotNull] ApplicationContext appContext, IAdventureWorksPersonClientFactory AdventureWorksPersonClientFactory)
            : base(appContext, AdventureWorksPersonConstants.CreateProviderMetadata())
        {
            _AdventureWorksPersonClientFactory = AdventureWorksPersonClientFactory;
        }

        public override async Task<CrawlJobData> GetCrawlJobData(
            ProviderUpdateContext context,
            IDictionary<string, object> configuration,
            Guid organizationId,
            Guid userId,
            Guid providerDefinitionId)
        {
            if (configuration == null)
                throw new ArgumentNullException(nameof(configuration));

            var AdventureWorksPersonCrawlJobData = new AdventureWorksPersonCrawlJobData();
            if (configuration.ContainsKey(AdventureWorksPersonConstants.KeyName.ConnectionString))
            { AdventureWorksPersonCrawlJobData.ConnectionString = configuration[AdventureWorksPersonConstants.KeyName.ConnectionString].ToString(); }

            return await Task.FromResult(AdventureWorksPersonCrawlJobData);
        }

        public override Task<bool> TestAuthentication(
            ProviderUpdateContext context,
            IDictionary<string, object> configuration,
            Guid organizationId,
            Guid userId,
            Guid providerDefinitionId)
        {
            throw new NotImplementedException();
        }

        public override Task<ExpectedStatistics> FetchUnSyncedEntityStatistics(ExecutionContext context, IDictionary<string, object> configuration, Guid organizationId, Guid userId, Guid providerDefinitionId)
        {
            throw new NotImplementedException();
        }

        public override async Task<IDictionary<string, object>> GetHelperConfiguration(
            ProviderUpdateContext context,
            [NotNull] CrawlJobData jobData,
            Guid organizationId,
            Guid userId,
            Guid providerDefinitionId)
        {
            if (jobData == null)
                throw new ArgumentNullException(nameof(jobData));

            var dictionary = new Dictionary<string, object>();

            if (jobData is AdventureWorksPersonCrawlJobData AdventureWorksPersonCrawlJobData)
            {
                //TODO add the transformations from specific CrawlJobData object to dictionary
                // add tests to GetHelperConfigurationBehaviour.cs
                dictionary.Add(AdventureWorksPersonConstants.KeyName.ConnectionString, AdventureWorksPersonCrawlJobData.ConnectionString);
            }

            return await Task.FromResult(dictionary);
        }

        public override Task<IDictionary<string, object>> GetHelperConfiguration(
            ProviderUpdateContext context,
            CrawlJobData jobData,
            Guid organizationId,
            Guid userId,
            Guid providerDefinitionId,
            string folderId)
        {
            throw new NotImplementedException();
        }

        public override async Task<AccountInformation> GetAccountInformation(ExecutionContext context, [NotNull] CrawlJobData jobData, Guid organizationId, Guid userId, Guid providerDefinitionId)
        {
            if (jobData == null)
                throw new ArgumentNullException(nameof(jobData));

            if (!(jobData is AdventureWorksPersonCrawlJobData AdventureWorksPersonCrawlJobData))
            {
                throw new Exception("Wrong CrawlJobData type");
            }

            var client = _AdventureWorksPersonClientFactory.CreateNew(AdventureWorksPersonCrawlJobData);
            return await Task.FromResult(client.GetAccountInformation());
        }

        public override string Schedule(DateTimeOffset relativeDateTime, bool webHooksEnabled)
        {
            return webHooksEnabled && ConfigurationManager.AppSettings.GetFlag("Feature.Webhooks.Enabled", false) ? $"{relativeDateTime.Minute} 0/23 * * *"
                : $"{relativeDateTime.Minute} 0/4 * * *";
        }

        public override Task<IEnumerable<WebHookSignature>> CreateWebHook(ExecutionContext context, [NotNull] CrawlJobData jobData, [NotNull] IWebhookDefinition webhookDefinition, [NotNull] IDictionary<string, object> config)
        {
            if (jobData == null)
                throw new ArgumentNullException(nameof(jobData));
            if (webhookDefinition == null)
                throw new ArgumentNullException(nameof(webhookDefinition));
            if (config == null)
                throw new ArgumentNullException(nameof(config));

            throw new NotImplementedException();
        }

        public override Task<IEnumerable<WebhookDefinition>> GetWebHooks(ExecutionContext context)
        {
            throw new NotImplementedException();
        }

        public override Task DeleteWebHook(ExecutionContext context, [NotNull] CrawlJobData jobData, [NotNull] IWebhookDefinition webhookDefinition)
        {
            if (jobData == null)
                throw new ArgumentNullException(nameof(jobData));
            if (webhookDefinition == null)
                throw new ArgumentNullException(nameof(webhookDefinition));

            throw new NotImplementedException();
        }

        public override IEnumerable<string> WebhookManagementEndpoints([NotNull] IEnumerable<string> ids)
        {
            if (ids == null)
            {
                throw new ArgumentNullException(nameof(ids));
            }

            if (!ids.Any())
            {
                throw new ArgumentException(nameof(ids));
            }

            throw new NotImplementedException();
        }

        public override async Task<CrawlLimit> GetRemainingApiAllowance(ExecutionContext context, [NotNull] CrawlJobData jobData, Guid organizationId, Guid userId, Guid providerDefinitionId)
        {
            if (jobData == null)
                throw new ArgumentNullException(nameof(jobData));


            //There is no limit set, so you can pull as often and as much as you want.
            return await Task.FromResult(new CrawlLimit(-1, TimeSpan.Zero));
        }

        // TODO Please see https://cluedin-io.github.io/CluedIn.Documentation/docs/1-Integration/build-integration.html
        public string Icon => AdventureWorksPersonConstants.IconResourceName;
        public string Domain { get; } = AdventureWorksPersonConstants.Uri;
        public string About { get; } = AdventureWorksPersonConstants.CrawlerDescription;
        public AuthMethods AuthMethods { get; } = AdventureWorksPersonConstants.AuthMethods;
        public IEnumerable<Control> Properties => null;
        public string ServiceType { get; } = JsonConvert.SerializeObject(AdventureWorksPersonConstants.ServiceType);
        public string Aliases { get; } = JsonConvert.SerializeObject(AdventureWorksPersonConstants.Aliases);
        public Guide Guide { get; set; } = new Guide
        {
            Instructions = AdventureWorksPersonConstants.Instructions,
            Value = new List<string> { AdventureWorksPersonConstants.CrawlerDescription },
            Details = AdventureWorksPersonConstants.Details

        };

        public string Details { get; set; } = AdventureWorksPersonConstants.Details;
        public string Category { get; set; } = AdventureWorksPersonConstants.Category;
        public new IntegrationType Type { get; set; } = AdventureWorksPersonConstants.Type;
    }
}
