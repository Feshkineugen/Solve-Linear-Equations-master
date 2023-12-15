using System;

namespace Framework
{
    
    public class ConfigHelper
    {
      
        private ConfigHelper() { }

       
        public static string GetConfig(string configName)
        {
            return System.Configuration.ConfigurationManager.AppSettings[configName];
        }

        
        public static string GetConifg(string configName)
        {
            return System.Configuration.ConfigurationManager.AppSettings[configName];
        }

        
        public static string GetPrefix(string configName)
        {
            return System.Configuration.ConfigurationManager.AppSettings[configName];
        }
    }
}