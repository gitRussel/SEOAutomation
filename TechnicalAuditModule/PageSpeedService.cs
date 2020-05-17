using System;
using System.Collections.Generic;
using System.Text;
using Google.Apis.Services;
using Google.Apis.PagespeedInsights.v5;
using Google.Apis.PagespeedInsights.v5.Data;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace TechnicalAuditModule
{
    internal class PageSpeedService
    {
        private ILogger _logger;
        private IConfigurationService _config;
        private PagespeedInsightsService service;

        internal PageSpeedService(ILogger logger, IConfigurationService config)
        {
            _logger = logger;
            _config = config;

            service = new PagespeedInsightsService(new BaseClientService.Initializer
            {
                ApplicationName = "PageSpeed Sample",
                ApiKey = _config.PageSpeedInsightsKey
            });
        }

        internal async Task CalculatePageSpeedAsync(string url)
        {
            var request = new PagespeedapiResource.RunpagespeedRequest(service)
            {
                Url = url,
                Strategy = PagespeedapiResource.RunpagespeedRequest.StrategyEnum.DESKTOP,
                Locale = "ru",
                Category = PagespeedapiResource.RunpagespeedRequest.CategoryEnum.SEO
            };

            var result = await request.ExecuteAsync();

         }
    }
}
