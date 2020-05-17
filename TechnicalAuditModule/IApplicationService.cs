using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

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
        Task CalculationPageLoadingSpeed(string url);
    }
}
