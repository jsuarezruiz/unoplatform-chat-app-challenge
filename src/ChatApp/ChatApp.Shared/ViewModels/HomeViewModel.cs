using ChatApp.Models;
using ChatApp.Services;
using System.Collections.ObjectModel;

namespace ChatApp.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        public HomeViewModel()
        {
            LoadData();
        }

        public ObservableCollection<User> Users { get; set; }

        public ObservableCollection<Message> RecentChat { get; set; }

        void LoadData()
        {
            Users = new ObservableCollection<User>(MessageService.Instance.GetUsers());
            RecentChat = new ObservableCollection<Message>(MessageService.Instance.GetChats());
        }
    }
}