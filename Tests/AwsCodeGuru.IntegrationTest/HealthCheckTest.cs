namespace AwsCodeGuru.IntegrationTest.Controllers
{
    using System.Net;
    using System.Net.Http;
    using System.Threading.Tasks;
    using AwsCodeGuru.IntegrationTest.Fixtures;
    using Xunit;

    public class HealthCheckTest : IClassFixture<CustomWebApplicationFactory<Startup>>
    {
        private readonly HttpClient client;

        public HealthCheckTest(CustomWebApplicationFactory<Startup> factory) =>
            this.client = factory.CreateClient();

        [Fact]
        public async Task GetStatus_Default_Returns200Ok()
        {
            var response = await this.client.GetAsync("/status");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task GetStatusSelf_Default_Returns200Ok()
        {
            var response = await this.client.GetAsync("/status/self");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
