using MobyShop.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobyShop.MobileA.ViewModels
{
    public class HistorijaNarudzbiDetailViewModel : BaseViewModel
    {
        private readonly APIService _serviceNarudzbe = new APIService("StavkeNarudzbe");
        private readonly APIService _serviceNarudzbePracenjeInfo = new APIService("NarudzbePracenjeInfo");
        public HistorijaNarudzbiDetailViewModel()
        {

        }

        public Narudzbe Narudzba { get; set; }
        public ObservableCollection<StavkeNarudzbe> listastavki { get; set; } = new ObservableCollection<StavkeNarudzbe>();

        private bool _IsPrimljenaEnabled = false;

        public bool IsPrimljenaEnabled
        {
            get { return _IsPrimljenaEnabled; }
            set { SetProperty(ref _IsPrimljenaEnabled, value); }
        }



        public async Task Init()
        {
            var lista = await _serviceNarudzbe.Get<List<StavkeNarudzbe>>(null);
            listastavki.Clear();
            foreach (var item in lista)
            {
                if (item.NarudzbaId == Narudzba.NarudzbaId)
                {
                    listastavki.Add(item);
                }
            }

            var listaPracenje = await _serviceNarudzbePracenjeInfo.Get<List<NarudzbePracenjeInfo>>(new Model.Requests.NarudzbePracenjeInfoSearchRequest
            {
                NarudzbaId = Narudzba.NarudzbaId
            });
            
            if(Narudzba.Otkazano.HasValue && Narudzba.Otkazano == false && 
                listaPracenje.Any(x=>x.StatusPracenja == StatusPracenja.Poslana) &&
                !listaPracenje.Any(x=>x.StatusPracenja == StatusPracenja.Stigla)
                )
            {
                IsPrimljenaEnabled = true;
            }

        }
    }
}
