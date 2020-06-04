using Google.Apis.PagespeedInsights.v5.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SEOAutomationContracts;

namespace TechnicalAuditModule
{
    public class ApplicationService : IApplicationService
    {
        IConfigurationService configuration { get; set; }

        ILoggerService loggerService{ get; set; }

        ILogger logger { get; set; }

        PageSpeedService servicePageSpeed { get; set; }

        HtmlValidationService htmlValidationService { get; set; }

        public ApplicationService()
        {
            configuration = new ConfigurationService();
            loggerService = new LoggerService();
            logger = loggerService.Create("App");


            servicePageSpeed = new PageSpeedService(logger, configuration);

            htmlValidationService = new HtmlValidationService(logger, configuration);
        }

        public async Task<SpeedTestValues> CalculationPageLoadingSpeed(string url)
        {
           return await servicePageSpeed.CalculatePageSpeedAsync(url);
        }

        public async Task<string> HtmlValidationAsync(string url)
        {
            return await htmlValidationService.HtmlCheckAsync(url);
        }
    }
}
