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
    public partial class ArtikliDetailPage : ContentPage
    {
        private ArtikliDetailViewModel model = null;
        private readonly APIService _karakteristikeService = new APIService("Karakteristike");

        public ArtikliDetailPage(Artikli artikal, Karakteristike karakteristike)
        {
            BindingContext = model = new ArtikliDetailViewModel
            {
                Artikal = artikal,
                Karakteristika = karakteristike

            };
            InitializeComponent();


        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            if (model.Kolicina > 0)
            {
                DisplayAlert("Uspjeh", "Uspjesno dodan artikal u korpu", "OK");
            }

        }

        protected override async void OnAppearing()
        {

            base.OnAppearing();
            model.NaStanju_IsVisible = model.Artikal.Status.Value;
            model.NijeNaStanju_IsVisible = !model.Artikal.Status.Value;
            await model.Init();
            await model.Recommender();



        }
        private async void preporuceniProizvodiList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var artikal1 = e.SelectedItem as Artikli;
            var karakteristike = await _karakteristikeService.GetById<Karakteristike>(artikal1.KarakteristikeId);

            await Navigation.PushAsync(new ArtikliDetailPage(artikal1, karakteristike));
        }

    }
}