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

            if (model.Narudzba.KorisnikId > 1)
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
                    PoslanaNarudzbaInsertRequest request = new PoslanaNarudzbaInsertRequest
                    {
                        Datum = DateTime.Now,
                        KlijentId = Global.PrijavljeniKlijent.KlijentId,
                        Poslano = false,
                        NarudzbaId = model.Narudzba.NarudzbaId,
                        KorisnikId = model.Narudzba.KorisnikId

                    };

                    await _service.Insert<PoslanaNarudzba>(request);
                    await DisplayAlert("Uspjeh", "Potvrdjeno da je narudzba primljena", "OK");
                }

            }

            else
            {
                await DisplayAlert("Upozorenje", "Ova narudzba nije zakljucena od strane prodavaca", "OK");
            }



        }
    }
}