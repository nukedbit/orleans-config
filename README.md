# orleans-config

Install from nuget

        Install-Package NukedBit.Orleans.Config 

This is a simple library for loading Orleans Config from app.config and Web.config, that can be usefull on small projects, so you can use config file transformations

to use on your silo

        <configSections>
            <section
                name="orleansSiloConfig"
                type="NukedBit.Orleans.Config.OrleansSiloConfiguration,NukedBit.Orleans.Config"
                allowLocation="true"
                allowDefinition="Everywhere"
            /> 
        </configSections>
        
        ....
        
          <orleansSiloConfig>
                <xmlConfig>
                <![CDATA[
                        <OrleansConfiguration xmlns="urn:orleans">
                        .....
                        </OrleansConfiguration>      

                ]]>
                    </xmlConfig>
          </orleansSiloConfig>  
          
Client Side

        <configSections> 
            <section
                name="orleansClientConfig"
                type="NukedBit.Orleans.Config.OrleansClientConfiguration,NukedBit.Orleans.Config"
                allowLocation="true"
                allowDefinition="Everywhere"
                />
        </configSections>
                
        <orleansClientConfig>
            <xmlConfig>
                    <![CDATA[
                <ClientConfiguration xmlns="urn:orleans">
                        <Gateway Address="localhost" Port="40000"/> 
                        .....
                </ClientConfiguration>
                ]]>
            </xmlConfig>
        </orleansClientConfig>        
          
                                
