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
    public class SalesCustomerClueProducer : BaseClueProducer<SalesCustomer>
    {
        private readonly IClueFactory _factory;

        public SalesCustomerClueProducer(IClueFactory factory)
        {
            _factory = factory;
        }

        protected override Clue MakeClueImpl(SalesCustomer input, Guid id)
        {

            var clue = _factory.Create("/SalesCustomer", $"{input.Rowguid}", id);

            var data = clue.Data.EntityData;



            data.Name = $"{input.AccountNumber}";

            data.Codes.Add(new EntityCode("/SalesCustomer", AdventureWorksConstants.CodeOrigin, $"{input.CustomerID}"));
            data.Codes.Add(new EntityCode("/SalesCustomer", AdventureWorksConstants.CodeOrigin, $"{input.AccountNumber}"));

            //add edges

            if (input.PersonID != null && !string.IsNullOrEmpty(input.PersonID.ToString()))
            {
                _factory.CreateOutgoingEntityReference(clue, "/PersonPerson", EntityEdgeType.AttachedTo, input.PersonID, input.PersonID.ToString());
            }
            if (input.StoreID != null && !string.IsNullOrEmpty(input.StoreID.ToString()))
            {
                _factory.CreateOutgoingEntityReference(clue, "/SalesStore", EntityEdgeType.AttachedTo, input.StoreID, input.StoreID.ToString());
            }
            if (input.TerritoryID != null && !string.IsNullOrEmpty(input.TerritoryID.ToString()))
            {
                _factory.CreateOutgoingEntityReference(clue, "/SalesSalesTerritory", EntityEdgeType.AttachedTo, input.TerritoryID, input.TerritoryID.ToString());
            }

            if (!data.OutgoingEdges.Any())
            {
                _factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);
            }


            var vocab = new SalesCustomerVocabulary();

            data.Properties[vocab.CustomerID] = input.CustomerID.PrintIfAvailable();
            data.Properties[vocab.PersonID] = input.PersonID.PrintIfAvailable();
            data.Properties[vocab.StoreID] = input.StoreID.PrintIfAvailable();
            data.Properties[vocab.TerritoryID] = input.TerritoryID.PrintIfAvailable();
            data.Properties[vocab.AccountNumber] = input.AccountNumber.PrintIfAvailable();
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


