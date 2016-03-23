using System.Configuration;
using Orleans.Runtime.Configuration;

namespace NukedBit.Orleans.Config
{
    public class OrleansSiloConfig
    {
        private readonly string _configSectionName;

        private OrleansSiloConfig(string configSectionName)
        {
            _configSectionName = configSectionName;
        }

        public static OrleansSiloConfig From(string configSectionName)
        {
            return new OrleansSiloConfig(configSectionName);
        }

        public ClusterConfiguration Get()
        {
            var config = (OrleansSiloConfiguration)ConfigurationManager.GetSection(_configSectionName);
            return config.XmlConfig.Load(); 
        }
    }
}
