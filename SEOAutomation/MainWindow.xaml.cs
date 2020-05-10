using SEOAutomation.ViewModel;
using System.Windows;

namespace SEOAutomation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ApplicationViewModel ViewModel { get; protected set; }

        public MainWindow()
        {
            InitializeComponent();

            ViewModel = new ApplicationViewModel();
            DataContext = ViewModel;
        }
    }
}
