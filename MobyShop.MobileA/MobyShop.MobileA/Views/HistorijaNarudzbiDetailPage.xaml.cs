using MobyShop.MobileA.ViewModels;
using MobyShop.Model.Requests;
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
    public partial class HistorijaNarudzbiDetailPage : ContentPage
    {
        private readonly APIService _service = new APIService("PoslanaNarudzba");
        private readonly APIService _serviceNarudzbePracenjeInfo = new APIService("NarudzbePracenjeInfo");

        HistorijaNarudzbiDetailViewModel model = null;
        public HistorijaNarudzbiDetailPage(Narudzbe narudzba)
        {
            InitializeComponent();
            BindingContext = model = new HistorijaNarudzbiDetailViewModel
            {
                Narudzba = narudzba
            };


        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {

            int NarudzbaPostoji = 0;
            var lista = await _service.Get<List<PoslanaNarudzba>>(null);
            foreach (var item in lista)
            {
                if (item.NarudzbaId == model.Narudzba.NarudzbaId)
                {
                    NarudzbaPostoji = model.Narudzba.NarudzbaId;
                }
            }
            if (NarudzbaPostoji != 0)
            {
                await DisplayAlert("Upozorenje", "Narudzba je zavrsena", "OK");
            }
            else
            {
                model.IsPrimljenaEnabled = false;

                PoslanaNarudzbaInsertRequest request = new PoslanaNarudzbaInsertRequest
                {
                    Datum = DateTime.Now,
                    KlijentId = Global.PrijavljeniKlijent.KlijentId,
                    Poslano = false,
                    NarudzbaId = model.Narudzba.NarudzbaId,
                    KorisnikId = model.Narudzba.KorisnikId

                };

                await _service.Insert<PoslanaNarudzba>(request);

                NarudzbePracenjeInfoInsertRequest request2 = new NarudzbePracenjeInfoInsertRequest
                {
                    Datum = DateTime.Now,
                    NarudzbaId = model.Narudzba.NarudzbaId,
                    StatusPracenja = StatusPracenja.Stigla
                };

                await _serviceNarudzbePracenjeInfo.Insert<NarudzbePracenjeInfo>(request2);

                await DisplayAlert("Uspjeh", "Potvrdjeno da je narudzba primljena", "OK");
            }

        }

        private async void PratiBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NarudzbaPracenjePage(model.Narudzba));
        }
    }
}