using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace TechnicalAuditModule
{
    public class ConfigurationService
    {
        private IConfiguration _config;

        public ConfigurationService(IConfiguration config)
        {
            _config = config;
            string key = _config["PageSpeedInsights:ServiceApiKey"]
        }

    }
}
