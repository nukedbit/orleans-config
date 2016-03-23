using System.Configuration;
using System.IO;
using System.Xml;
using Orleans.Runtime.Configuration;

namespace NukedBit.Orleans.Config
{
    public class OrleansClientXmlConfigElement : ConfigurationElement
    {
        private string Config { get; set; }

        protected override void DeserializeElement(XmlReader reader, bool serializeCollectionKey)
        {
            var content = reader.ReadElementContentAs(typeof(string), null) as string;
            Config = content;
        }

        public ClientConfiguration Load()
        {
            var config = new ClientConfiguration();
            config.Load(new StringReader(Config));
            return config;
        }
    }
}