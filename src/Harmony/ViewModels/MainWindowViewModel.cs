using Prism.Mvvm;

namespace Harmony.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Harmony";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel()
        {

        }
    }
}
