using System;
using System.Collections.Generic;
using System.Text;

namespace TechnicalAuditModule
{
    internal interface ILoggerService
    {
        /// <summary>
        /// Создать логгер
        /// </summary>
        ILogger Create(string name);
    }
}
