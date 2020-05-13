using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace TechnicalAuditModule
{
    ///<inheritdoc cref="IConfigurationService"/>
    internal class ConfigurationService : IConfigurationService
    {
        private IConfiguration _config;

        public ConfigurationService()
        {
            _config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", true, true)
                .Build();
        }

        public string PageSpeedInsightsKey
        {
            get
            {
                return _config["PageSpeedInsights:ServiceApiKey"];
            }
        }

    }
}
