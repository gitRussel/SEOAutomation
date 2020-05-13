using System;
using System.Collections.Generic;
using System.Text;
using NLog;

namespace TechnicalAuditModule
{
    /// <summary>
    /// Логгер
    /// </summary>
    class Logger : ILogger
    {
        /// <summary>
        /// Логгер
        /// </summary>
        protected NLog.Logger Log { get; set; }

        /// <summary>
        /// Конструктор логгера
        /// </summary>
        public Logger(string name)
        {
            Log = NLog.LogManager.GetLogger(name);
        }

        /// <summary>
        /// Трассировочное сообщение
        /// </summary>
        public void Trace(string message)
        {
            Log.Trace(message);
        }

        /// <summary>
        /// Отладочное сообщение
        /// </summary>
        public void Debug(string message)
        {
            Log.Debug(message);
        }

        /// <summary>
        /// Информационное сообщение
        /// </summary>
        public void Info(string message)
        {
            Log.Info(message);
        }

        /// <summary>
        /// Предупреждение
        /// </summary>
        public void Warn(string message)
        {
            Log.Warn(message);
        }

        /// <summary>
        /// Сообщение об ошибке
        /// </summary>
        public void Error(string message)
        {
            Log.Error(message);
        }

        /// <summary>
        /// Критичная ошибка
        /// </summary>
        public void Fatal(string message)
        {
            Log.Fatal(message);
        }
    }
}
