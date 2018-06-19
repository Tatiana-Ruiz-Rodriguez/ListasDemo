namespace ListasDemo.ViewModel
{
    using ListasDemo.Model;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using ListasDemo.Helpers;
    using Xamarin.Forms;
    using ListasDemo.View;

    public class MainPageViewModel : Notificable
    {

        public ObservableCollection
             <Grouping<string, Friend>> Friends
        { get; set; }

        Friends = repository.GetAllGrouped();
    }
}
