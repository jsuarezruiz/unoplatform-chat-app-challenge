using ChatApp.ViewModels;
using Microsoft.UI.Xaml.Controls;

namespace ChatApp.Views
{
    public sealed partial class HomeView : Page
    {
        public HomeView()
        {
            this.InitializeComponent();

            DataContext = new HomeViewModel();
        }
    }
}
