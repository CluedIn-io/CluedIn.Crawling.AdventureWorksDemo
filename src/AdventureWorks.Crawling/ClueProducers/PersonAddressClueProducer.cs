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
    public class PersonAddressClueProducer : BaseClueProducer<PersonAddress>
    {
        private readonly IClueFactory _factory;

        public PersonAddressClueProducer(IClueFactory factory)
        {
            _factory = factory;
        }

        protected override Clue MakeClueImpl(PersonAddress input, Guid id)
        {

            var clue = _factory.Create("/PersonAddress", $"{input.Rowguid}", id);

            var data = clue.Data.EntityData;



            data.Name = $"{input.AddressLine1} {input.AddressLine2} {input.City}";

            data.Codes.Add(new EntityCode("/PersonAddress", AdventureWorksConstants.CodeOrigin, $"{input.AddressID}"));

            //add edges

            if (input.StateProvinceID != null && !string.IsNullOrEmpty(input.StateProvinceID.ToString()))
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Geography.State, EntityEdgeType.LocatedIn, input.StateProvinceID, input.StateProvinceID.ToString());
            }

            if (!data.OutgoingEdges.Any())
            {
                _factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);
            }


            var vocab = new PersonAddressVocabulary();

            data.Properties[vocab.AddressID] = input.AddressID.PrintIfAvailable();
            data.Properties[vocab.AddressLine1] = input.AddressLine1.PrintIfAvailable();
            data.Properties[vocab.AddressLine2] = input.AddressLine2.PrintIfAvailable();
            data.Properties[vocab.City] = input.City.PrintIfAvailable();
            data.Properties[vocab.StateProvinceID] = input.StateProvinceID.PrintIfAvailable();
            data.Properties[vocab.PostalCode] = input.PostalCode.PrintIfAvailable();
            //data.Properties[vocab.SpatialLocation]           = input.SpatialLocation.PrintIfAvailable();
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


