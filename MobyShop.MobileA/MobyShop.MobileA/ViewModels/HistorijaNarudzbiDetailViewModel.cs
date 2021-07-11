using MobyShop.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace MobyShop.MobileA.ViewModels
{
    public class HistorijaNarudzbiDetailViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("StavkeNarudzbe");
        public HistorijaNarudzbiDetailViewModel()
        {

        }

        public Narudzbe Narudzba { get; set; }
        public ObservableCollection<StavkeNarudzbe> listastavki { get; set; } = new ObservableCollection<StavkeNarudzbe>();



        public async Task Init()
        {
            var lista = await _service.Get<List<StavkeNarudzbe>>(null);
            listastavki.Clear();
            foreach (var item in lista)
            {
                if (item.NarudzbaId == Narudzba.NarudzbaId)
                {
                    listastavki.Add(item);
                }
            }

        }
    }
}
