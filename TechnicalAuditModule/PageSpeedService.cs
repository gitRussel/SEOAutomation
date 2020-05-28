using Google.Apis.PagespeedInsights.v5;
using Google.Apis.PagespeedInsights.v5.Data;
using Google.Apis.Services;
using SEOAutomationContracts;
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

        internal async Task<SpeedTestValues> CalculatePageSpeedAsync(string url)
        {
            var request = new PagespeedapiResource.RunpagespeedRequest(service)
            {
                Url = url,
                Strategy = PagespeedapiResource.RunpagespeedRequest.StrategyEnum.DESKTOP,
                Locale = "ru",
                Category = PagespeedapiResource.RunpagespeedRequest.CategoryEnum.PERFORMANCE
            };

            PagespeedApiPagespeedResponseV5 response = await request.ExecuteAsync();

            var cruxMetrix = response.LoadingExperience.Metrics;

            string FCP = cruxMetrix["FIRST_CONTENTFUL_PAINT_MS"].Category;
            string FIP = cruxMetrix["FIRST_INPUT_DELAY_MS"].Category;

            var result = new SpeedTestValues
            {

            };


            return result;
        }
    }
}
