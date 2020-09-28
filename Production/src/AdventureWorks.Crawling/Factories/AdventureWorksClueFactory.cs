using System;
using CluedIn.Core;
using CluedIn.Core.Data;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.AdventureWorksProduction.Core;
using RuleConstants = CluedIn.Core.Constants.Validation.Rules;

namespace CluedIn.Crawling.AdventureWorksProduction.Factories
{
    public class AdventureWorksProductionClueFactory : ClueFactory
    {
        public AdventureWorksProductionClueFactory()
            : base(AdventureWorksProductionConstants.CodeOrigin, AdventureWorksProductionConstants.ProviderRootCodeValue)
        {
        }

        protected override Clue ConfigureProviderRoot([NotNull] Clue clue)
        {
            if (clue == null)
            {
                throw new ArgumentNullException(nameof(clue));
            }

            var data = clue.Data.EntityData;
            data.Name = AdventureWorksProductionConstants.CrawlerName;
            data.Uri = new Uri(AdventureWorksProductionConstants.Uri);
            data.Description = AdventureWorksProductionConstants.CrawlerDescription;

            clue.ValidationRuleSuppressions.AddRange(new[] {RuleConstants.PROPERTIES_001_MustExist,});

            clue.ValidationRuleSuppressions.AddRange(new[]
            {
                RuleConstants.METADATA_002_Uri_MustBeSet, RuleConstants.PROPERTIES_002_Unknown_VocabularyKey_Used
            });

            return clue;
        }
    }
}
