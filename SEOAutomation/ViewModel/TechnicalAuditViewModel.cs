using SEOAutomation.Commands;
using SEOAutomation.Models;
using System;
using System.Threading.Tasks;

namespace SEOAutomation.ViewModel
{
    public class TechnicalAuditViewModel : BindableBase
    {
        private bool _isBusy;

        public TechnicalAuditModel AuditModel { get; set; }

        public IErrorHandler ErrorHandler { get; set; }

        public bool IsBusy
        {
            get => _isBusy;
            private set
            {
                SetProperty(ref _isBusy, value);
                AnalyzeSpeedCommand.RaiseCanExecuteChanged();
            }
        }

        public AsyncCommand AnalyzeSpeedCommand { get; private set; }

        public AsyncCommand AnalyzeHtmlCommand { get; private set; }

        public TechnicalAuditViewModel()
        {
            AuditModel = new TechnicalAuditModel();

            ErrorHandler = new ErrorHandler();

            AnalyzeSpeedCommand = new AsyncCommand(AnalyzeSpeedExecuteAsync, CanExecuteAnalyze, ErrorHandler);

            AnalyzeHtmlCommand = new AsyncCommand(AnalyzeHtmlValidationExecuteAsync, CanExecuteAnalyze, ErrorHandler);
        }

        private async Task AnalyzeHtmlValidationExecuteAsync()
        {
            try
            {
                IsBusy = true;
                await AuditModel.FillHtmlValidationModelAsync();
            }
            finally
            {
                IsBusy = false;
            }
        }

        private async Task AnalyzeSpeedExecuteAsync()
        {
            try
            {
                IsBusy = true;
                await AuditModel.FillSpeedModelAsync();
            }
            finally
            {
                IsBusy = false;
            }
        }

        private bool CanExecuteAnalyze()
        {
            return !IsBusy;
        }
    }
}
