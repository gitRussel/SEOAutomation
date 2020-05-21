using SEOAutomation.Commands;
using System.Threading.Tasks;
using TechnicalAuditModule;

namespace SEOAutomation.ViewModel
{
    public class TechnicalAuditViewModel : BindableBase
    {
        private string _url;
        private bool _isBusy;
        public bool IsBusy
        {
            get => _isBusy;
            private set => SetProperty(ref _isBusy, value);
        }

        public string Url { get => _url; set { _url = value; OnPropertyChanged("Url"); } }

        public IAsyncCommand AnalyzeCommand { get; private set; }

        public TechnicalAuditViewModel()
        {
            Url = "http://www.example.com/";
            AnalyzeCommand = new AsyncCommand(AnalyzeExecuteAsync, CanExecuteAnalyze);
        }

        private async Task AnalyzeExecuteAsync()
        {
            try
            {
                IsBusy = true;
                ApplicationService a = new ApplicationService();
                await a.CalculationPageLoadingSpeed(Url);
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
