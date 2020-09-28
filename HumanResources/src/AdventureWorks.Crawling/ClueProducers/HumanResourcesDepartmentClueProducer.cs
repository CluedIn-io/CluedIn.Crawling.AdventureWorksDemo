using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Helpers;
using CluedIn.Crawling.AdventureWorksHumanResources.Vocabularies;
using CluedIn.Crawling.AdventureWorksHumanResources.Core.Models;
using CluedIn.Crawling.AdventureWorksHumanResources.Core;
using CluedIn.Core;
using RuleConstants = CluedIn.Core.Constants.Validation.Rules;
using System.Linq;
using System;

namespace CluedIn.Crawling.AdventureWorksHumanResources.ClueProducers
{
    public class HumanResourcesDepartmentClueProducer : BaseClueProducer<HumanResourcesDepartment>
    {
        private readonly IClueFactory _factory;

        public HumanResourcesDepartmentClueProducer(IClueFactory factory)
        {
            _factory = factory;
        }

        protected override Clue MakeClueImpl(HumanResourcesDepartment input, Guid id)
        {

            var clue = _factory.Create(EntityType.Organization.Department, $"{input.DepartmentID}", id);

            var data = clue.Data.EntityData;

            data.Name = input.Name;

            data.ModifiedDate = input.ModifiedDate.ParseAsDateTimeOffset(); 
			           //add edges


            if (!data.OutgoingEdges.Any())
            {
                _factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);
            }

            var vocab = new HumanResourcesDepartmentVocabulary();

            data.Properties[vocab.DepartmentID] = input.DepartmentID.PrintIfAvailable();
            data.Properties[vocab.Name] = input.Name.PrintIfAvailable();
            data.Properties[vocab.GroupName] = input.GroupName.PrintIfAvailable();
            data.Properties[vocab.ModifiedDate] = input.ModifiedDate.PrintIfAvailable();

            clue.ValidationRuleSuppressions.AddRange(new[]
                                        {
                                RuleConstants.METADATA_001_Name_MustBeSet,
                                RuleConstants.PROPERTIES_001_MustExist,
                                RuleConstants.METADATA_002_Uri_MustBeSet,
                                RuleConstants.METADATA_003_Author_Name_MustBeSet,
                                RuleConstants.METADATA_005_PreviewImage_RawData_MustBeSet
                            });

            return clue;
        }
    }
}

