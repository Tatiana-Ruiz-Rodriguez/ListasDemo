namespace XmnSQLite.ViewModels
{
    using System.Collections.ObjectModel;
    using System.Threading.Tasks;
    using Xamarin.Forms;
    using ListasDemo.Helpers;
    using ListasDemo.Model;
    using ListasDemo.ViewModel;
    using ListasDemo.View;

    public class MainPageViewModel : Notificable
    {
        #region Atributos
        private Friend currentFriend;
        private string filter;
        #endregion

        #region Propiedades
        private INavigation Navigation;
        private FriendReposity FriendRepository;
        public ObservableCollection<Grouping<string, Friend>> Friends { get; set; }
        public Command SearchCommand { get; set; }
        public Command AddFriendCommand { get; set; }
        public Command ITemTappedCommand { get; set; }

        public string Filter
        {
            get
            {
                return filter;
            }
            set
            {
                SetValue(ref filter, value);
            }
        }

        public Friend CurrentFriend
        {
            get
            {
                return currentFriend;
            }
            set
            {
                SetValue(ref currentFriend, value);
            }

        }
        #endregion

        #region Constructores
        public MainPageViewModel(INavigation navigation)
        {
            FriendRepository = new FriendReposity();
            Friends = FriendRepository.GetAllGrouped();
            Navigation = navigation;
            AddFriendCommand = new Command(async () => await AddFriend());
            ITemTappedCommand = new Command(async () => await NavigateToEditFriendView());
        }
        #endregion

        #region Metodos
        public async Task AddFriend()
        {
            await Navigation.PushAsync(new FriendPage());
        }
        public async Task NavigateToEditFriendView()
        {
            await Navigation.PushAsync(new FriendPage(CurrentFriend));
        }
        #endregion
    }
}
