using FluentAssertions;
using NetworkUtility.Ping;
using System.Net.NetworkInformation;

namespace NetworkUtility.Tests
{
    public class NetworkServiceTests
    {
        private readonly NetworkService _pingService;
        public NetworkServiceTests()
        {
            _pingService = new NetworkService();
        }
        [Fact]
        public void NetworkService_SendPing_ReturnsString()
        {
            //Arrange - variables,classes,mocks

            //Act
            var result = _pingService.SendPing();

            //Assert
            result.Should().NotBeNullOrWhiteSpace();
            result.Should().Be("Ping Sent!");
        }

        [Theory]
        [InlineData(1,2,3)]
        public void NetworkService_PingTimeout_ReturnsInt(int a, int b, int expected)
        {
            //arrange

            //act
            var result = _pingService.PingTimeout(a,b);

            //assert
            result.Should().Be(expected);
            result.Should().NotBeInRange(-10000,0);
        }

        [Fact]
        public void NetworkService_LastPingDate_ReturnsDateTime()
        {
            var result = _pingService.LastPingDate();
        }

        [Fact]
        public void NetworkService_GetPingOptions_ReturnsObject()
        {
            var expected = new PingOptions()
            {
                DontFragment = true,
                Ttl = 1
            };

            var result = _pingService.GetPingOptions();

            result.Should().BeOfType<PingOptions>();
            result.Should().BeEquivalentTo(expected);
            result.Ttl.Should().Be(1);
        }
        
        [Fact]
        public void NetworkService_MostRecentPings_ReturnsObject()
        {
            var expected = new PingOptions()
            {
                DontFragment = true,
                Ttl = 1
            };

            var result = _pingService.MostRecentPings();

            result.Should().BeOfType<PingOptions[]>();
            result.Should().ContainEquivalentOf(expected);
            result.Should().Contain(x => x.DontFragment == true);
        }
    }
}
