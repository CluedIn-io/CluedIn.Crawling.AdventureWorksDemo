using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Helpers;
using CluedIn.Crawling.AdventureWorksProduction.Vocabularies;
using CluedIn.Crawling.AdventureWorksProduction.Core.Models;
using CluedIn.Crawling.AdventureWorksProduction.Core;
using CluedIn.Core;
using RuleConstants = CluedIn.Core.Constants.Validation.Rules;
using System.Linq;
using System;

namespace CluedIn.Crawling.AdventureWorksProduction.ClueProducers
{
    public class ProductionDocumentClueProducer : BaseClueProducer<ProductionDocument>
    {
        private readonly IClueFactory _factory;

        public ProductionDocumentClueProducer(IClueFactory factory)
        {
            _factory = factory;
        }

        protected override Clue MakeClueImpl(ProductionDocument input, Guid id)
        {

            var clue = _factory.Create(EntityType.Documents.Document, $"{input.Rowguid}", id);

            var data = clue.Data.EntityData;

            data.Name = $"{input.Title}";

            //data.Codes.Add(new EntityCode(EntityType.Documents.Document, AdventureWorksProductionConstants.CodeOrigin, $"{input.DocumentNode}"));

            data.ModifiedDate = input.ModifiedDate.ParseAsDateTimeOffset(); 
            //add edges

            if (input.Owner != null && !string.IsNullOrEmpty(input.Owner.ToString()))
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.OwnedBy, input.Owner, input.Owner.ToString());
            }

            if (!data.OutgoingEdges.Any())
            {
                _factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);
            }


            var vocab = new ProductionDocumentVocabulary();

            //data.Properties[vocab.DocumentNode] = input.DocumentNode.PrintIfAvailable();
            data.Properties[vocab.DocumentLevel] = input.DocumentLevel.PrintIfAvailable();
            data.Properties[vocab.Title] = input.Title.PrintIfAvailable();
            data.Properties[vocab.Owner] = input.Owner.PrintIfAvailable();
            data.Properties[vocab.FolderFlag] = input.FolderFlag.PrintIfAvailable();
            data.Properties[vocab.FileName] = input.FileName.PrintIfAvailable();
            data.Properties[vocab.FileExtension] = input.FileExtension.PrintIfAvailable();
            data.Properties[vocab.Revision] = input.Revision.PrintIfAvailable();
            data.Properties[vocab.ChangeNumber] = input.ChangeNumber.PrintIfAvailable();
            data.Properties[vocab.Status] = input.Status.PrintIfAvailable();
            data.Properties[vocab.DocumentSummary] = input.DocumentSummary.PrintIfAvailable();
            //data.Properties[vocab.Document] = input.Document.PrintIfAvailable();
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


