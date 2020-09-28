using System;
using CluedIn.Core;
using CluedIn.Core.Data;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.AdventureWorksSales.Core;
using RuleConstants = CluedIn.Core.Constants.Validation.Rules;

namespace CluedIn.Crawling.AdventureWorksSales.Factories
{
    public class AdventureWorksSalesClueFactory : ClueFactory
    {
        public AdventureWorksSalesClueFactory()
            : base(AdventureWorksSalesConstants.CodeOrigin, AdventureWorksSalesConstants.ProviderRootCodeValue)
        {
        }

        protected override Clue ConfigureProviderRoot([NotNull] Clue clue)
        {
            if (clue == null)
            {
                throw new ArgumentNullException(nameof(clue));
            }

            var data = clue.Data.EntityData;
            data.Name = AdventureWorksSalesConstants.CrawlerName;
            data.Uri = new Uri(AdventureWorksSalesConstants.Uri);
            data.Description = AdventureWorksSalesConstants.CrawlerDescription;

            clue.ValidationRuleSuppressions.AddRange(new[] {RuleConstants.PROPERTIES_001_MustExist,});

            clue.ValidationRuleSuppressions.AddRange(new[]
            {
                RuleConstants.METADATA_002_Uri_MustBeSet, RuleConstants.PROPERTIES_002_Unknown_VocabularyKey_Used
            });

            return clue;
        }
    }
}
