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
    public class PersonEmailAddressClueProducer : BaseClueProducer<PersonEmailAddress>
    {
        private readonly IClueFactory _factory;

        public PersonEmailAddressClueProducer(IClueFactory factory)
        {
            _factory = factory;
        }

        protected override Clue MakeClueImpl(PersonEmailAddress input, Guid id)
        {

            var clue = _factory.Create(EntityType.Mail, $"{input.Rowguid}", id);

            var data = clue.Data.EntityData;

            data.Name = $"{input.EmailAddress}";

            data.Codes.Add(new EntityCode(EntityType.Mail, AdventureWorksPersonConstants.CodeOrigin, $"{input.BusinessEntityID}.{input.EmailAddressID}"));

            data.ModifiedDate = input.ModifiedDate.ParseAsDateTimeOffset(); 
            //add edges

            if (input.BusinessEntityID != null && !string.IsNullOrEmpty(input.BusinessEntityID.ToString()))
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.For, input.BusinessEntityID, input.BusinessEntityID.ToString());
            }

            if (!data.OutgoingEdges.Any())
            {
                _factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);
            }


            var vocab = new PersonEmailAddressVocabulary();

            data.Properties[vocab.BusinessEntityID] = input.BusinessEntityID.PrintIfAvailable();
            data.Properties[vocab.EmailAddressID] = input.EmailAddressID.PrintIfAvailable();
            data.Properties[vocab.EmailAddress] = input.EmailAddress.PrintIfAvailable();
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


