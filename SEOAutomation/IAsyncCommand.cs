using System.Threading.Tasks;
using System.Windows.Input;

namespace SEOAutomation
{
    public interface IAsyncCommand : ICommand
    {
        Task ExecuteAsync(object parameter);
    }
}
