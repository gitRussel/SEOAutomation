using System;
using System.Collections.Generic;
using System.Text;

namespace TechnicalAuditModule
{
    class LoggerService: ILoggerService
    {
        /// <summary>
        /// Список логгеров
        /// </summary>
        public Dictionary<string, Logger> Loggers { get; protected set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        public LoggerService()
        {
            Loggers = new Dictionary<string, Logger>();
        }

        /// <summary>
        /// Создать логгер
        /// </summary>
        public ILogger Create(string name)
        {
            lock (Loggers)
            {
                if (!Loggers.ContainsKey(name))
                {
                    Loggers.Add(name, new Logger(name));
                }

                return Loggers[name];
            }
        }
    }
}
