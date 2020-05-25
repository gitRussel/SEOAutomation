using Google.Apis.PagespeedInsights.v5;
using Google.Apis.PagespeedInsights.v5.Data;
using Google.Apis.Services;
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

        internal async Task<PagespeedApiPagespeedResponseV5> CalculatePageSpeedAsync(string url)
        {
            var request = new PagespeedapiResource.RunpagespeedRequest(service)
            {
                Url = url,
                Strategy = PagespeedapiResource.RunpagespeedRequest.StrategyEnum.DESKTOP,
                Locale = "ru",
                Category = PagespeedapiResource.RunpagespeedRequest.CategoryEnum.PERFORMANCE
            };

            PagespeedApiPagespeedResponseV5 result = await request.ExecuteAsync();

            var cruxMetrix = result.LoadingExperience.Metrics;

            string FCP = cruxMetrix["FIRST_CONTENTFUL_PAINT_MS"].Category;
            string FIP = cruxMetrix["FIRST_INPUT_DELAY_MS"].Category;

            return result;
        }
    }
}
