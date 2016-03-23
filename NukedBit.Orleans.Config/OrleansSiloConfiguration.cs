using System.Configuration;

namespace NukedBit.Orleans.Config
{
    public class OrleansSiloConfiguration : ConfigurationSection
    {

        // Create a "font" element.
        [ConfigurationProperty("xmlConfig")]
        public OrleansSiloXmlConfigElement XmlConfig
        {
            get
            {
                return (OrleansSiloXmlConfigElement)this["xmlConfig"];
            }
            set
            {
                this["xmlConfig"] = value;
            }
        }
    }
}