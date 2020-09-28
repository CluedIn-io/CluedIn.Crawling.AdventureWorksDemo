using System;
using CluedIn.Core;
using CluedIn.Core.Data;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.AdventureWorksPerson.Core;
using RuleConstants = CluedIn.Core.Constants.Validation.Rules;

namespace CluedIn.Crawling.AdventureWorksPerson.Factories
{
    public class AdventureWorksPersonClueFactory : ClueFactory
    {
        public AdventureWorksPersonClueFactory()
            : base(AdventureWorksPersonConstants.CodeOrigin, AdventureWorksPersonConstants.ProviderRootCodeValue)
        {
        }

        protected override Clue ConfigureProviderRoot([NotNull] Clue clue)
        {
            if (clue == null)
            {
                throw new ArgumentNullException(nameof(clue));
            }

            var data = clue.Data.EntityData;
            data.Name = AdventureWorksPersonConstants.CrawlerName;
            data.Uri = new Uri(AdventureWorksPersonConstants.Uri);
            data.Description = AdventureWorksPersonConstants.CrawlerDescription;

            clue.ValidationRuleSuppressions.AddRange(new[] {RuleConstants.PROPERTIES_001_MustExist,});

            clue.ValidationRuleSuppressions.AddRange(new[]
            {
                RuleConstants.METADATA_002_Uri_MustBeSet, RuleConstants.PROPERTIES_002_Unknown_VocabularyKey_Used
            });

            return clue;
        }
    }
}
