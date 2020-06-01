using SEOAutomation.Commands;
using SEOAutomation.Models;
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
                AnalyzeCommand.RaiseCanExecuteChanged();
            }
        }

        public AsyncCommand AnalyzeCommand { get; private set; }

        public TechnicalAuditViewModel()
        {
            AuditModel = new TechnicalAuditModel();

            ErrorHandler = new ErrorHandler();

            AnalyzeCommand = new AsyncCommand(AnalyzeExecuteAsync, CanExecuteAnalyze, ErrorHandler);
        }


        private async Task AnalyzeExecuteAsync()
        {
            try
            {
                IsBusy = true;
                await AuditModel.FillModelAsync();
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
