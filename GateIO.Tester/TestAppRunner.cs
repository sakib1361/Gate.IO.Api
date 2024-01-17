using ApiSharp.Authentication;
using Gate.IO.Api;
using Gate.IO.Api.Enums;

namespace GateIO.Tester
{
    [TestClass]
    public class TestAppRunner
    {
        private GateRestApiClient commonApi;
        private readonly GateStreamClient commonStream;

        public TestAppRunner()
        {
            var address = GateApiAddresses.TestNet;
            var cred = new ApiCredentials(ApiConstants.TestKey, ApiConstants.TestSecret);
            commonApi = new GateRestApiClient(new GateRestApiClientOptions(cred));
            commonStream = new GateStreamClient();
            commonApi.Spot.ClientOptions.BaseAddress = address.RestApiAddress;

            commonStream.ClientOptions.BaseAddress = address.StreamSpotAddress;
            commonStream.ClientOptions.StreamSpotAddress = address.StreamSpotAddress;
            commonStream.ClientOptions.StreamPerpetualFuturesAddresses = new Dictionary<FuturesPerpetualSettle, string>
                {
                    { FuturesPerpetualSettle.BTC, address.StreamPerpetualFuturesAddresses[FuturesPerpetualSettle.BTC] },
                    { FuturesPerpetualSettle.USD, address.StreamPerpetualFuturesAddresses[FuturesPerpetualSettle.USD] },
                    { FuturesPerpetualSettle.USDT, address.StreamPerpetualFuturesAddresses[FuturesPerpetualSettle.USDT] },
                };

            // Stream-Delivery Futures
            commonStream.ClientOptions.StreamDeliveryFuturesAddresses = new Dictionary<FuturesDeliverySettle, string>
                {
                    { FuturesDeliverySettle.BTC, address.StreamDeliveryFuturesAddresses[FuturesDeliverySettle.BTC] },
                    { FuturesDeliverySettle.USDT, address.StreamDeliveryFuturesAddresses[FuturesDeliverySettle.USDT] },
                };

            // Stream-Options
            commonStream.ClientOptions.StreamOptionsAddress = address.StreamOptionsAddress;
        }
        [TestMethod]
        public async Task RunLogin()
        {
            var accounts = await commonApi.Futures.Perpetual.USDT.GetPositionsAsync();
            Assert.IsTrue(accounts.Success);
        }
    }
}