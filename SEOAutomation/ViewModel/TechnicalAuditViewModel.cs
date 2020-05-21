using SEOAutomation.Commands;
using TechnicalAuditModule;

namespace SEOAutomation.ViewModel
{
    public class TechnicalAuditViewModel : BindableBase
    {
        private string _url;
        private int _byteCount;

        public string Url { get => _url; set { _url = value; OnPropertyChanged("Url"); } }

        public IAsyncCommand AnalyzeCommand { get; private set; }

        public TechnicalAuditViewModel()
        {
            Url = "http://www.example.com/";
            AnalyzeCommand = new AsyncCommand(async () =>
            {
                ApplicationService a = new ApplicationService();
                await a.CalculationPageLoadingSpeed(Url);
            });

            
        }
    }
}
