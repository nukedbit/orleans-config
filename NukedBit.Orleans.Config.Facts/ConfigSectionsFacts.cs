using System.Linq;
using Xunit;

namespace NukedBit.Orleans.Config.Facts
{
    public class ConfigSectionsFacts
    {
        [Fact]
        public void ServerConfig()
        {
            var clusterConfig = OrleansSiloConfig.From("orleansSiloConfig").Get();
            Assert.True(clusterConfig.Globals.GetAllProviderConfigurations().Any(p => p.Name == "MemoryStore"));
        }


        [Fact]
        public void ClientConfig()
        {
            var clusterConfig = OrleansClientConfig.From("orleansClientConfig").Get();
            Assert.True(clusterConfig.Gateways.Count == 1);
        }
    }
}
