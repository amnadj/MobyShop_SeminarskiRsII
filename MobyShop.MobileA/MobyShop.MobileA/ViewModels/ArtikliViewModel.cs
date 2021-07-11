using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MobyShop.Model.Requests;
using MobyShop.Models;
using Xamarin.Forms;

namespace MobyShop.MobileA.ViewModels
{
    public class ArtikliViewModel : BaseViewModel
    {
        private readonly APIService _artikliService = new APIService("Artikli");
        private readonly APIService _proizvodjaciService = new APIService("Proizvodjaci");


        public ArtikliViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ObservableCollection<Artikli> ArtikliList { get; set; } = new ObservableCollection<Artikli>();
        public ObservableCollection<Proizvodjaci> ProizvodjaciList { get; set; } = new ObservableCollection<Proizvodjaci>();





        Proizvodjaci _SelectedProizvodjac = null;
        public Proizvodjaci SelectedProizvodjac
        {
            get { return _SelectedProizvodjac; }
            set
            {
                SetProperty(ref _SelectedProizvodjac, value);

                if (value != null)
                {

                    InitCommand.Execute(null);
                }

            }
        }
        public ICommand InitCommand { get; set; }



        public async Task Init()
        {
            var listaproizvodjaci = await _proizvodjaciService.Get<List<Proizvodjaci>>(null);

            if (ProizvodjaciList.Count == 0)
            {
                foreach (var item in listaproizvodjaci)
                {
                    ProizvodjaciList.Add(item);
                }
            }
            if (SelectedProizvodjac != null)
            {
                ArtikliSearchRequest search = new ArtikliSearchRequest();
                search.ProizvodjacId = SelectedProizvodjac.ProizvodjacId;

                List<Artikli> lista = await _artikliService.Get<List<Artikli>>(search);

                ArtikliList.Clear();


                foreach (var item in lista)
                {
                    ArtikliList.Add(item);
                }
            }
            else
            {
                List<Artikli> lista = await _artikliService.Get<List<Artikli>>(null);

                ArtikliList.Clear();


                foreach (var item in lista)
                {
                    ArtikliList.Add(item);
                }
            }


        }

    }
}
