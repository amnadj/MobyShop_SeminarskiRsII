using MobyShop.MobileA.ViewModels;
using MobyShop.Models;
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
    public partial class NarudzbaPracenjePage : ContentPage
    {
        NarudzbaPracenjeViewModel model = null;

        public NarudzbaPracenjePage(Narudzbe narudzba)
        {
            InitializeComponent();
            BindingContext = model = new NarudzbaPracenjeViewModel(narudzba);

        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

    }
}