using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Helpers;
using CluedIn.Crawling.AdventureWorks.Vocabularies;
using CluedIn.Crawling.AdventureWorks.Core.Models;
using CluedIn.Core;
using RuleConstants = CluedIn.Core.Constants.Validation.Rules;
using System.Linq;
using System;

namespace CluedIn.Crawling.AdventureWorks.ClueProducers
{
    public class HumanResourcesEmployeeClueProducer : BaseClueProducer<HumanResourcesEmployee>
    {
        private readonly IClueFactory _factory;

        public HumanResourcesEmployeeClueProducer(IClueFactory factory)
        {
            _factory = factory;
        }

        protected override Clue MakeClueImpl(HumanResourcesEmployee input, Guid id)
        {

            var clue = _factory.Create("/HumanResourcesEmployee", $"{input.BusinessEntityID}", id);

            var data = clue.Data.EntityData;



            //add edges

            if (input.BusinessEntityID != null && !string.IsNullOrEmpty(input.BusinessEntityID.ToString()))
            {
                _factory.CreateOutgoingEntityReference(clue, "/PersonBusinessEntity", EntityEdgeType.AttachedTo, input.BusinessEntityID, input.BusinessEntityID.ToString());
            }

            if (!data.OutgoingEdges.Any())
                _factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);


            var vocab = new HumanResourcesEmployeeVocabulary();

            data.Properties[vocab.BusinessEntityID] = input.BusinessEntityID.PrintIfAvailable();
            data.Properties[vocab.NationalIDNumber] = input.NationalIDNumber.PrintIfAvailable();
            data.Properties[vocab.LoginID] = input.LoginID.PrintIfAvailable();
            data.Properties[vocab.OrganizationNode] = input.OrganizationNode.PrintIfAvailable();
            data.Properties[vocab.OrganizationLevel] = input.OrganizationLevel.PrintIfAvailable();
            data.Properties[vocab.JobTitle] = input.JobTitle.PrintIfAvailable();
            data.Properties[vocab.BirthDate] = input.BirthDate.PrintIfAvailable();
            data.Properties[vocab.MaritalStatus] = input.MaritalStatus.PrintIfAvailable();
            data.Properties[vocab.Gender] = input.Gender.PrintIfAvailable();
            data.Properties[vocab.HireDate] = input.HireDate.PrintIfAvailable();
            data.Properties[vocab.SalariedFlag] = input.SalariedFlag.PrintIfAvailable();
            data.Properties[vocab.VacationHours] = input.VacationHours.PrintIfAvailable();
            data.Properties[vocab.SickLeaveHours] = input.SickLeaveHours.PrintIfAvailable();
            data.Properties[vocab.CurrentFlag] = input.CurrentFlag.PrintIfAvailable();
            data.Properties[vocab.Rowguid] = input.Rowguid.PrintIfAvailable();
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


