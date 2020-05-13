using System;
using System.Collections.Generic;
using System.Text;

namespace TechnicalAuditModule
{
    internal interface ILogger
    {
        /// <summary>
        /// Трассировочное сообщение
        /// </summary>        
        void Trace(string name);

        /// <summary>
        /// Отладочное сообщение
        /// </summary>        
        void Debug(string name);

        /// <summary>
        /// Информационное сообщение
        /// </summary>        
        void Info(string name);

        /// <summary>
        /// Предупреждающее сообщение
        /// </summary>        
        void Warn(string name);

        /// <summary>
        /// Сообщение об ошибке
        /// </summary>        
        void Error(string name);

        /// <summary>
        /// Сообщение о критической ошибке
        /// </summary>        
        void Fatal(string name);
    }
}
