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
    public class NarudzbaPracenjeViewModel : BaseViewModel
    {

        private readonly APIService _serviceNarudzbePracenjeInfo = new APIService("NarudzbePracenjeInfo");
        private readonly Narudzbe narudzba;

        public NarudzbaPracenjeViewModel(Narudzbe narudzba)
        {
            this.narudzba = narudzba;
        }
        public ObservableCollection<NarudzbePracenjeInfo> NarudzbaPracenjeList { get; set; } = new ObservableCollection<NarudzbePracenjeInfo>();

        public async Task Init()
        {
            NarudzbaPracenjeList.Clear();

            var listaPracenje = await _serviceNarudzbePracenjeInfo.Get<List<NarudzbePracenjeInfo>>(new Model.Requests.NarudzbePracenjeInfoSearchRequest
            {
               NarudzbaId = narudzba.NarudzbaId
            });

            foreach (var item in listaPracenje)
            {
                NarudzbaPracenjeList.Add(item);
            }
          
        }

    }
}
