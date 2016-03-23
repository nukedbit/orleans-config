using System.Configuration;

namespace NukedBit.Orleans.Config
{
    public class OrleansClientConfiguration : ConfigurationSection
    {

        // Create a "font" element.
        [ConfigurationProperty("xmlConfig")]
        public OrleansClientXmlConfigElement XmlConfig
        {
            get
            {
                return (OrleansClientXmlConfigElement)this["xmlConfig"];
            }
            set
            {
                this["xmlConfig"] = value;
            }
        }
    }
}