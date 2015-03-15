using System;
using System.Configuration;

namespace MedPort.Commons
{
    public class ConfigurationUtiliy
    {
        public static string GetConfigValue(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }
    }
}
