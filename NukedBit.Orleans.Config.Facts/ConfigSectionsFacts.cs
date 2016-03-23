﻿using System.Linq;
using Xunit;

namespace NukedBit.Orleans.Config.Facts
{
    public class ConfigSectionsFacts
    {
        [Fact]
        public void ServerConfig()
        {
            var config = (OrleansServerConfiguration)System.Configuration.ConfigurationManager.GetSection("orleansServerConfig");
            var clusterConfig = config.XmlConfig.Load();
            Assert.True(clusterConfig.Globals.GetAllProviderConfigurations().Any(p => p.Name == "MemoryStore"));
        }


        [Fact]
        public void ClientConfig()
        {
            var config = (OrleansClientConfiguration)System.Configuration.ConfigurationManager.GetSection("orleansClientConfig");
            var clusterConfig = config.XmlConfig.Load();
            Assert.True(clusterConfig.Gateways.Count == 1);
        }
    }
}