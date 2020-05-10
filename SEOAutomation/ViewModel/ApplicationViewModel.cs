using SEOAutomation.Commands;
using System.Windows;

namespace SEOAutomation.ViewModel
{
    public class ApplicationViewModel : BindableBase
    {
        private BindableBase _сurrentViewModel;
        private bool _chekedTechnicalAuditView;

        public Command<string> NavigationCommand { get; private set; }

        public Command<Window> ExitCommand { get; private set; }

        /// <summary>
        /// Выбран пункт меню: технический аудит
        /// </summary>
        public bool ChekedTechnicalAuditView
        {
            get => _chekedTechnicalAuditView;
            set
            {
                _chekedTechnicalAuditView = value;
                OnPropertyChanged("ChekedScenarioView");
            }
        }

        /// <summary>
        /// View model молудя технического аудита
        /// </summary>
        public TechnicalAuditViewModel TechnicalAuditVM = new TechnicalAuditViewModel();

        /// <summary>
        /// Текущая ViewModel
        /// </summary>
        public BindableBase CurrentViewModel
        {
            get { return _сurrentViewModel; }
            set { SetProperty(ref _сurrentViewModel, value); }
        }

        public ApplicationViewModel()
        {
            NavigationCommand = new Command<string>(OnNav);
            ExitCommand = new Command<Window>(OnExit);

            CurrentViewModel = TechnicalAuditVM;
            ChekedTechnicalAuditView = true;
        }

        private void OnNav(string destination)
        {
            switch (destination)
            {
                case "audit":
                    CurrentViewModel = TechnicalAuditVM;
                    ChekedTechnicalAuditView = true;
                    break;

                default:
                    CurrentViewModel = TechnicalAuditVM;
                    ChekedTechnicalAuditView = true;
                    break;
            }
        }

        private void OnExit(Window window)
        {
            //window.Close();
        }
    }
}

