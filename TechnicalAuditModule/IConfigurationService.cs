namespace TechnicalAuditModule
{
    internal interface IConfigurationService
    {
        /// <summary>
        /// Ключ подключения к Page Speed Insights
        /// </summary>
        string PageSpeedInsightsKey { get; }

    }
}