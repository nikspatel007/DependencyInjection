using System.Configuration;
using DependencyInjection.Interfaces;

namespace DependencyInjection.Web.Infrastructure
{
    public class ConfigProvider : IConfigProvider
    {
        public string Get(string key)
        {
            return ConfigurationManager.AppSettings[key] ?? string.Empty;
        }
    }
}