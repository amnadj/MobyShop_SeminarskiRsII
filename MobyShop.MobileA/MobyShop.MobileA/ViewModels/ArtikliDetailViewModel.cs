using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using MobyShop.Models;
using System.Threading.Tasks;
using MobyShop.Model.Requests;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using MobyShop.MobileA.Views;

namespace MobyShop.MobileA.ViewModels
{
    public class ArtikliDetailViewModel : BaseViewModel
    {
        private readonly APIService _karakteristikeService = new APIService("Karakteristike");
        private readonly APIService _artikliService = new APIService("Artikli");
        private readonly APIService _ocjeneService = new APIService("Ocjene");
        private readonly APIService _recommenderService = new APIService("Recommender");
        public ArtikliDetailViewModel()
        {
            PovecajKolicinuCommand = new Command(() => Kolicina += 1);
            SmanjiKolicinuCommand = new Command(() => Kolicina -= 1);
            UporediDvaArtiklaCommand = new Command(async () =>
            {
                if (SelectedArtikal == null)
                {
                    await App.Current.MainPage.DisplayAlert("Not Found selected article", "", "OK");
                }
                else
                {
                    // UcitajKaratkeristiku();

                    await ((App.Current.MainPage as MasterDetailPage).Detail as NavigationPage)
                    .Navigation.PushAsync(new UporediDvaArtiklaPage(Artikal, Karakteristika, SelectedArtikal, SelectedKarakteristika));
                }

            });
            NaruciCommand = new Command(Naruci);
            InitCommand = new Command(async () => await Init());
            RecommenderCommand = new Command(async () => await Recommender());
            OcijeniSa1Command = new Command(async () => await Ocijeni(1));
            OcijeniSa2Command = new Command(async () => await Ocijeni(2));
            OcijeniSa3Command = new Command(async () => await Ocijeni(3));
            OcijeniSa4Command = new Command(async () => await Ocijeni(4));
            OcijeniSa5Command = new Command(async () => await Ocijeni(5));

        }
        public async Task Recommender()
        {
            RecommenderList.Clear();
            List<Artikli> lista = new List<Artikli>();
            lista = await _recommenderService.GetSlicneArtikle<List<Artikli>>(Artikal.ArtikalId);

            List<Ocjene> listaocjena = new List<Ocjene>();
            listaocjena = await _ocjeneService.Get<List<Ocjene>>(null);



            foreach (var item in lista)
            {
                int ukupno = 0;
                decimal iznos = 0;

                foreach (var item2 in listaocjena)
                {
                    if (item2.ArtikalId == item.ArtikalId)
                    {
                        iznos += item2.Ocjena;
                        ukupno++;
                    }
                }

                item.ProsjecnaOcjena = iznos / ukupno;


                RecommenderList.Add(item);

            }





        }
        public async Task Ocijeni(int ocjena)
        {
            OcjeneInsertRequest x = new OcjeneInsertRequest
            {
                ArtikalId = Artikal.ArtikalId,
                KlijentId = Global.PrijavljeniKlijent.KlijentId,
                Ocjena = ocjena,
                Datum = DateTime.Now
            };


            await _ocjeneService.Insert<Ocjene>(x);
            Ocijenjeno = true;
            NijeOcijenjeno = false;
            await App.Current.MainPage.DisplayAlert("Uspješno ocijenjeno", "", "OK");


        }

        public Artikli Artikal { get; set; }
        public Karakteristike Karakteristika { get; set; } = new Karakteristike();
        public Karakteristike SelectedKarakteristika { get; set; } = new Karakteristike();
        public ObservableCollection<Artikli> ArtikliList { get; set; } = new ObservableCollection<Artikli>();
        public ObservableCollection<Ocjene> OcjeneArtiklaList { get; set; } = new ObservableCollection<Ocjene>();

        public ObservableCollection<Artikli> RecommenderList { get; set; } = new ObservableCollection<Artikli>();


        public async Task Init()
        {
            var listaocjena = await _ocjeneService.Get<List<Ocjene>>(null);
            Ocijenjeno = false;
            foreach (var item in listaocjena)
            {
                if (item.ArtikalId == Artikal.ArtikalId)
                {
                    OcjeneArtiklaList.Add(item);
                    if (item.KlijentId == Global.PrijavljeniKlijent.KlijentId)
                    {
                        Ocijenjeno = true;
                    }

                }
            }
            NijeOcijenjeno = !Ocijenjeno;
            if (OcjeneArtiklaList.Count() != 0)
            {
                ProsjecnaOcjena = OcjeneArtiklaList.Select(s => s.Ocjena).Average();
            }
            else
            {
                ProsjecnaOcjena = 0;
            }


            var listaartikala = await _artikliService.Get<List<Artikli>>(null);

            if (ArtikliList.Count == 0)
            {
                foreach (var item in listaartikala)
                {
                    ArtikliList.Add(item);
                }
            }
            if (SelectedArtikal != null)
            {
                SelectedKarakteristika = await _karakteristikeService.GetById<Karakteristike>(_SelectedArtikal.KarakteristikeId);
            }
        }

        int _kolicina = 0;

        public int Kolicina
        {
            get { return _kolicina; }
            set { SetProperty(ref _kolicina, value); }
        }

        public ICommand PovecajKolicinuCommand { get; set; }
        public ICommand SmanjiKolicinuCommand { get; set; }
        public ICommand UporediDvaArtiklaCommand { get; set; }
        public ICommand OcijeniSa1Command { get; set; }
        public ICommand OcijeniSa2Command { get; set; }
        public ICommand OcijeniSa3Command { get; set; }
        public ICommand OcijeniSa4Command { get; set; }
        public ICommand OcijeniSa5Command { get; set; }


        public ICommand NaruciCommand { get; set; }
        public ICommand InitCommand { get; set; }

        public ICommand RecommenderCommand { get; set; }
        private async void UcitajKaratkeristiku()
        {
            var karakteristike = await _karakteristikeService.GetById<Karakteristike>(_SelectedArtikal.KarakteristikeId);
            SelectedKarakteristika = karakteristike;
        }
        private void Naruci()
        {
            if (Kolicina > 0)
            {
                if (CartService.Cart.ContainsKey(Artikal.ArtikalId))
                {
                    CartService.Cart.Remove(Artikal.ArtikalId);
                }
                CartService.Cart.Add(Artikal.ArtikalId, this);
            }
            else
            {
                App.Current.MainPage.DisplayAlert("Kolicina ne moze biti 0,povecaj kolicinu", "", "OK");
            }

        }

        double _ProsjecnaOcjena;
        public double ProsjecnaOcjena
        {
            get { return _ProsjecnaOcjena; }
            set
            {
                SetProperty(ref _ProsjecnaOcjena, value);
            }
        }
        bool _Ocijenjeno;
        public bool Ocijenjeno
        {
            get { return _Ocijenjeno; }
            set
            {
                SetProperty(ref _Ocijenjeno, value);
            }
        }
        bool _NijeOcijenjeno;
        public bool NijeOcijenjeno
        {
            get { return _NijeOcijenjeno; }
            set
            {
                SetProperty(ref _NijeOcijenjeno, value);
            }
        }

        bool _NaStanju_IsVisible;
        public bool NaStanju_IsVisible
        {
            get { return _NaStanju_IsVisible; }
            set
            {
                SetProperty(ref _NaStanju_IsVisible, value);
            }
        }

        bool _NijeNaStanju_IsVisible;
        public bool NijeNaStanju_IsVisible
        {
            get { return _NijeNaStanju_IsVisible; }
            set
            {
                SetProperty(ref _NijeNaStanju_IsVisible, value);

            }
        }
        Artikli _SelectedArtikal = null;
        public Artikli SelectedArtikal
        {
            get { return _SelectedArtikal; }
            set
            {
                SetProperty(ref _SelectedArtikal, value);

                if (value != null)
                {
                    InitCommand.Execute(null);
                }

            }
        }



    }
}
