using MobyShop.MobileA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobyShop.MobileA.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    //public partial class MainPage : MasterDetailPage
    //{
    //    public MainPage()
    //    {
    //        InitializeComponent();
    //        MasterPage.ListView.ItemSelected += ListView_ItemSelected;
    //    }

    //    private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    //    {
    //        var item = e.SelectedItem as MainPageMasterMenuItem;
    //        if (item == null)
    //            return;

    //        var page = (Page)Activator.CreateInstance(item.TargetType);
    //        page.Title = item.Title;

    //        Detail = new NavigationPage(page);
    //        IsPresented = false;

    //        MasterPage.ListView.SelectedItem = null;
    //    }
    //}
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.Browse, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Browse:
                        MenuPages.Add(id, new NavigationPage(new ItemsPage()));
                        break;
                    case (int)MenuItemType.Artikli:
                        MenuPages.Add(id, new NavigationPage(new ArtikliPage()));
                        break;
                    case (int)MenuItemType.Narudzba:
                        MenuPages.Add(id, new NavigationPage(new NarudzbaPage()));
                        break;
                    case (int)MenuItemType.HistorijaNarudzbi:
                        MenuPages.Add(id, new NavigationPage(new HistorijaNarudzbiPage()));
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                newPage.Title = Title;
                IsPresented = false;
            }
        }
    }
}