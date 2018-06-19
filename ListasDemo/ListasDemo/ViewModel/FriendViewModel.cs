namespace ListasDemo.ViewModel
{
    using System;
    using System.Threading.Tasks;
    using ListasDemo.Model;
    using Xamarin.Forms;

    public class FriendViewModel
    {
        public Command SaveFriendCommand
        {
            get;
            set;
        }

        public Friend FriendModel
        {
            get => _friendModel;
            set => _friendModel = value;
        }
        private INavigation Navigation;
        private Friend _friendModel;

        public FriendViewModel(INavigation navigation)
        {
            FriendModel = new Friend();
            SaveFriendCommand = new Command(async () => await SaveFriend());
            Navigation = navigation;
        }

        public FriendViewModel(INavigation navigation, Friend friend)
        {
            FriendModel = friend;
            SaveFriendCommand = new Command(async () => await SaveFriend());
            Navigation = navigation;

        }

        public async Task SaveFriend()
        {
            await App.Database.SaveFriendAsync(FriendModel);
            await Navigation.PopToRootAsync();
        }

    }
}
