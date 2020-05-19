using CluedIn.Core.Crawling;
using CluedIn.Crawling;
using CluedIn.Crawling.AdventureWorks;
using CluedIn.Crawling.AdventureWorks.Infrastructure.Factories;
using Moq;
using Should;
using Xunit;

namespace Crawling.AdventureWorks.Unit.Test
{
    public class AdventureWorksCrawlerBehaviour
    {
        private readonly ICrawlerDataGenerator _sut;

        public AdventureWorksCrawlerBehaviour()
        {
            var nameClientFactory = new Mock<IAdventureWorksClientFactory>();

            _sut = new AdventureWorksCrawler(nameClientFactory.Object);
        }

        [Fact]
        public void GetDataReturnsData()
        {
            var jobData = new CrawlJobData();

            _sut.GetData(jobData)
                .ShouldNotBeNull();
        }
    }
}
