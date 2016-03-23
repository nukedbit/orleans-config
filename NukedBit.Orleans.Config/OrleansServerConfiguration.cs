using System.Configuration;

namespace NukedBit.Orleans.Config
{
    public class OrleansServerConfiguration : ConfigurationSection
    {

        // Create a "font" element.
        [ConfigurationProperty("xmlConfig")]
        public OrleansServerXmlConfigElement XmlConfig
        {
            get
            {
                return (OrleansServerXmlConfigElement)this["xmlConfig"];
            }
            set
            {
                this["xmlConfig"] = value;
            }
        }
    }
}