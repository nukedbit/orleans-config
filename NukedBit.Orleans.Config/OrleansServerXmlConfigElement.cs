using System.Configuration;
using System.IO;
using System.Xml;
using Orleans.Runtime.Configuration;

namespace NukedBit.Orleans.Config
{
    public class OrleansServerXmlConfigElement : ConfigurationElement
    {
        private string Config { get; set; }

        protected override void DeserializeElement(XmlReader reader, bool serializeCollectionKey)
        {
            var content = reader.ReadElementContentAs(typeof (string), null) as string;
            Config = content;
        }

        public ClusterConfiguration Load()
        {
            return new ClusterConfiguration(new StringReader(Config));
        }
    }
}
