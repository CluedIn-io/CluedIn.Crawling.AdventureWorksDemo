using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Helpers;
using CluedIn.Crawling.AdventureWorks.Vocabularies;
using CluedIn.Crawling.AdventureWorks.Core.Models;
using CluedIn.Crawling.AdventureWorks.Core;
using CluedIn.Core;
using RuleConstants = CluedIn.Core.Constants.Validation.Rules;
using System.Linq;
using System;

namespace CluedIn.Crawling.AdventureWorks.ClueProducers
{
    public class HumanResourcesShiftClueProducer : BaseClueProducer<HumanResourcesShift>
    {
        private readonly IClueFactory _factory;

        public HumanResourcesShiftClueProducer(IClueFactory factory)
        {
            _factory = factory;
        }

        protected override Clue MakeClueImpl(HumanResourcesShift input, Guid id)
        {

            var clue = _factory.Create(EntityType.HR.WorkSchedule, $"{input.ShiftID}", id);

            var data = clue.Data.EntityData;



            data.Name = input.Name;



            data.ModifiedDate = input.ModifiedDate.ParseAsDateTimeOffset(); 
            //add edges


            if (!data.OutgoingEdges.Any())
            {
                _factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);
            }


            var vocab = new HumanResourcesShiftVocabulary();

            data.Properties[vocab.ShiftID] = input.ShiftID.PrintIfAvailable();
            data.Properties[vocab.Name] = input.Name.PrintIfAvailable();
            data.Properties[vocab.StartTime] = input.StartTime.PrintIfAvailable();
            data.Properties[vocab.EndTime] = input.EndTime.PrintIfAvailable();
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


