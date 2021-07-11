using MobyShop.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MobyShop.MobileA.ViewModels
{
    public class HistorijaNarudzbiViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("narudzbe");

        public HistorijaNarudzbiViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ObservableCollection<Narudzbe> ListaNarudzbi { get; set; } = new ObservableCollection<Narudzbe>();

        public ICommand InitCommand { get; set; }


        public async Task Init()
        {
            List<Narudzbe> lista = await _service.Get<List<Narudzbe>>(null);
            ListaNarudzbi.Clear();
            foreach (var item in lista)
            {

                if (item.KlijentId == Global.PrijavljeniKlijent.KlijentId)
                {
                    ListaNarudzbi.Add(item);

                }
            }
        }
    }
}
