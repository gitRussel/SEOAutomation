using SEOAutomation.Interfaces;
using TechnicalAuditModule;

namespace SEOAutomation.Implementation.ViewModel
{
    public class TechnicalAuditViewModel : BindableBase
    {
        private string _url;
        private int _byteCount;

        public string Url { get => _url; set { _url = value; OnPropertyChanged("Url"); } }

        public IAsyncCommand CountUrlBytesCommand { get; private set; }

        public int ByteCount { get => _byteCount; set { _byteCount = value; OnPropertyChanged("ByteCount"); } } // Raises PropertyChanged

        public TechnicalAuditViewModel()
        {
            Url = "http://www.example.com/";
            CountUrlBytesCommand = new AsyncCommand(async () =>
            {
                ByteCount = await MyService.DownloadAndCountBytesAsync(Url);
            });
        }
    }
}
