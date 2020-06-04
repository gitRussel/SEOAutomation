using Newtonsoft.Json;
using SEOAutomationContracts;
using System.Threading.Tasks;
using TechnicalAuditModule;

namespace SEOAutomation.Models
{
    public class TechnicalAuditModel : BindableBase
    {
        //Chrome user Experience Report Result
        private string _fcpC;
        private string _fidC;
        //Lighthous Result
        private string _fcpL;
        private string _siL;
        private string _ttiL;
        private string _fmpL;
        private string _fciL;
        private string _eilL;

        private string _url;

        /// <summary>
        /// Контейнер сервисов
        /// </summary>
        private ApplicationService applicationService { get; set; }

        public TechnicalAuditModel()
        {
            Url = "http://example.com/";
            applicationService = new ApplicationService();
        }

        public string Url
        {
            get => _url;
            set
            {
                _url = value;
                OnPropertyChanged("Url");
            }

        }
        public string FCPCategory
        {
            get => _fcpC;
            set
            {
                _fcpC = value;
                OnPropertyChanged("FCPCategory");
            }
        }
        public string FIDCategory
        {
            get => _fidC;
            set
            {
                _fidC = value;
                OnPropertyChanged("FIDCategory");
            }
        }
        public string FCPLighthous
        {
            get => _fcpL;
            set
            {
                _fcpL = value;
                OnPropertyChanged("FCPLighthous");
            }
        }
        public string SiLighthous
        {
            get => _siL;
            set
            {
                _siL = value;
                OnPropertyChanged("SiLighthous");
            }
        }
        public string TtiLighthous
        {
            get => _ttiL;
            set
            {
                _ttiL = value;
                OnPropertyChanged("TtiLighthous");
            }
        }
        public string FmpLighthous
        {
            get => _fmpL;
            set
            {
                _fmpL = value;
                OnPropertyChanged("FmpLighthous");
            }
        }
        public string FciLighthous
        {
            get => _fciL;
            set
            {
                _fciL = value;
                OnPropertyChanged("FciLighthous");
            }
        }
        public string EilLighthous
        {
            get => _eilL; set
            {
                _eilL = value;
                OnPropertyChanged("EilLighthous");
            }
        }

        /// <summary>
        /// Заполнение модели скорости загрузки сайта
        /// </summary>
        public async Task FillSpeedModelAsync()
        {
            SpeedTestValues result = await applicationService.CalculationPageLoadingSpeed(Url);

            FCPCategory = result.FCPCategory;
            FIDCategory = result.FIDCategory;
            FCPLighthous = result.FCPLighthous;
            SiLighthous = result.SiLighthous;
            TtiLighthous = result.TtiLighthous;
            FmpLighthous = result.FmpLighthous;
            FciLighthous = result.FciLighthous;
            EilLighthous = result.EilLighthous;
        }

        /// <summary>
        /// Заполнение модели скорости загрузки сайта
        /// </summary>
        public async Task FillHtmlValidationModelAsync()
        {
            string uri = "https://validator.nu/?doc=" + Url + "&out=json";
            string json = await applicationService.HtmlValidationAsync(uri);

            ValidationMessages info = JsonConvert.DeserializeObject<ValidationMessages>(json);
        }
    }
}
