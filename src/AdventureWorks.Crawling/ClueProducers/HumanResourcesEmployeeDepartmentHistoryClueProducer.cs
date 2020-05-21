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
    public class HumanResourcesEmployeeDepartmentHistoryClueProducer : BaseClueProducer<HumanResourcesEmployeeDepartmentHistory>
    {
        private readonly IClueFactory _factory;

        public HumanResourcesEmployeeDepartmentHistoryClueProducer(IClueFactory factory)
        {
            _factory = factory;
        }

        protected override Clue MakeClueImpl(HumanResourcesEmployeeDepartmentHistory input, Guid id)
        {

            var clue = _factory.Create("/HumanResourcesEmployeeDepartmentHistory", $"{input.BusinessEntityID}.{input.DepartmentID}.{input.ShiftID}.{input.StartDate}", id);

            var data = clue.Data.EntityData;



            data.Name = $"Department Shift History: {input.BusinessEntityID} at {input.DepartmentID}: {input.StartDate} - {input.EndDate}";


            data.ModifiedDate = input.ModifiedDate.ParseAsDateTimeOffset(); 
            //add edges

            if (input.BusinessEntityID != null && !string.IsNullOrEmpty(input.BusinessEntityID.ToString()))
            {
                _factory.CreateOutgoingEntityReference(clue, "/HumanResourcesEmployee", EntityEdgeType.For, input.BusinessEntityID, input.BusinessEntityID.ToString());
            }
            if (input.DepartmentID != null && !string.IsNullOrEmpty(input.DepartmentID.ToString()))
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Organization.Department, EntityEdgeType.For, input.DepartmentID, input.DepartmentID.ToString());
            }
            if (input.ShiftID != null && !string.IsNullOrEmpty(input.ShiftID.ToString()))
            {
                _factory.CreateOutgoingEntityReference(clue, "/HumanResourcesShift", "During", input.ShiftID, input.ShiftID.ToString());
            }

            if (!data.OutgoingEdges.Any())
            {
                _factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);
            }


            var vocab = new HumanResourcesEmployeeDepartmentHistoryVocabulary();

            data.Properties[vocab.BusinessEntityID] = input.BusinessEntityID.PrintIfAvailable();
            data.Properties[vocab.DepartmentID] = input.DepartmentID.PrintIfAvailable();
            data.Properties[vocab.ShiftID] = input.ShiftID.PrintIfAvailable();
            data.Properties[vocab.StartDate] = input.StartDate.PrintIfAvailable();
            data.Properties[vocab.EndDate] = input.EndDate.PrintIfAvailable();
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


