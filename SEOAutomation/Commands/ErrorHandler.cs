using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using Google.Apis.Requests;

namespace SEOAutomation.Commands
{
    public class ErrorHandler : IErrorHandler
    {
        public string ErrorMassage { get; set; }

        public void HandleError(Exception ex)
        {
            ErrorMassage = ex.Message;
            MessageBox.Show(ErrorMassage,"Ошибка выполнения сценария", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
