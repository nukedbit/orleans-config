using System.Configuration;
using Orleans.Runtime.Configuration;

namespace NukedBit.Orleans.Config
{
    public class OrleansClientConfig
    {
        private readonly string _configSectionName;

        private OrleansClientConfig(string configSectionName)
        {
            _configSectionName = configSectionName;
        }

        public static OrleansClientConfig From(string configSectionName)
        {
            return new OrleansClientConfig(configSectionName);
        }

        public ClientConfiguration Get()
        {
            var config = (OrleansClientConfiguration)ConfigurationManager.GetSection(_configSectionName);
            return config.XmlConfig.Load();
        }
    }
}