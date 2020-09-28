using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Helpers;
using CluedIn.Crawling.AdventureWorksPerson.Vocabularies;
using CluedIn.Crawling.AdventureWorksPerson.Core.Models;
using CluedIn.Crawling.AdventureWorksPerson.Core;
using CluedIn.Core;
using RuleConstants = CluedIn.Core.Constants.Validation.Rules;
using System.Linq;
using System;

namespace CluedIn.Crawling.AdventureWorksPerson.ClueProducers
{
    public class PersonPersonClueProducer : BaseClueProducer<PersonPerson>
    {
        private readonly IClueFactory _factory;

        public PersonPersonClueProducer(IClueFactory factory)
        {
            _factory = factory;
        }

        protected override Clue MakeClueImpl(PersonPerson input, Guid id)
        {

            var clue = _factory.Create(EntityType.Person, $"{input.Rowguid}", id);

            var data = clue.Data.EntityData;

            data.Name = $"{input.FirstName} {input.MiddleName} {input.LastName}";

            data.Codes.Add(new EntityCode(EntityType.Person, AdventureWorksPersonConstants.CodeOrigin, $"{input.BusinessEntityID}"));

            data.ModifiedDate = input.ModifiedDate.ParseAsDateTimeOffset(); 
            //add edges

            if (input.BusinessEntityID != null && !string.IsNullOrEmpty(input.BusinessEntityID.ToString()))
            {
                _factory.CreateOutgoingEntityReference(clue, "/PersonBusinessEntity", "Is", input.BusinessEntityID, input.BusinessEntityID.ToString());
            }

            if (!data.OutgoingEdges.Any())
            {
                _factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);
            }


            var vocab = new PersonPersonVocabulary();

            data.Properties[vocab.BusinessEntityID] = input.BusinessEntityID.PrintIfAvailable();
            data.Properties[vocab.PersonType] = input.PersonType.PrintIfAvailable();
            data.Properties[vocab.NameStyle] = input.NameStyle.PrintIfAvailable();
            data.Properties[vocab.Title] = input.Title.PrintIfAvailable();
            data.Properties[vocab.FirstName] = input.FirstName.PrintIfAvailable();
            data.Properties[vocab.MiddleName] = input.MiddleName.PrintIfAvailable();
            data.Properties[vocab.LastName] = input.LastName.PrintIfAvailable();
            data.Properties[vocab.Suffix] = input.Suffix.PrintIfAvailable();
            data.Properties[vocab.EmailPromotion] = input.EmailPromotion.PrintIfAvailable();
            data.Properties[vocab.AdditionalContactInfo] = input.AdditionalContactInfo.PrintIfAvailable();
            data.Properties[vocab.Demographics] = input.Demographics.PrintIfAvailable();
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


