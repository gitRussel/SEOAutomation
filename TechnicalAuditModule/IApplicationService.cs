using Google.Apis.PagespeedInsights.v5.Data;
using System.Threading.Tasks;
using SEOAutomationContracts;

namespace TechnicalAuditModule
{
    /// <summary>
    /// Операции приложения
    /// </summary>
    public interface IApplicationService
    {
        /// <summary>
        /// Расчёт скрости загрузки страницы
        /// </summary>        
        Task<SpeedTestValues> CalculationPageLoadingSpeed(string url);
    }
}
