namespace ListasDemo.View
{
    using ListasDemo.Model;
    using ListasDemo.ViewModel;
    using Xamarin.Forms;
    public partial class FriendPage : ContentPage
    {
        public FriendPage(Friend friend = null)
        {
            InitializeComponent();
            if (friend == null)
            {
                this.BindingContext = new FriendViewModel(Navigation);

            }
            else
            {
                this.BindingContext = new FriendViewModel(Navigation, friend);
            }

        }
    }
}